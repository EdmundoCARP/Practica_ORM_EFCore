Imports System.Windows.Forms
Imports Microsoft.EntityFrameworkCore

Public Class FrmProductos

    Private Sub FrmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCategorias()
        CargarProductos()
        LimpiarCampos()
    End Sub


    Private Sub CargarCategorias()
        Try
            Using db As New AppDbContext()
                cboCategoria.DataSource = db.Categorias.
                    OrderBy(Function(c) c.Nombre).ToList()

                cboCategoria.DisplayMember = "Nombre"
                cboCategoria.ValueMember = "Id"
                cboCategoria.SelectedIndex = -1
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar categorías: " & ex.Message)
        End Try
    End Sub

    Private Sub CargarProductos()
        Try
            Using db As New AppDbContext()
                dgvProductos.DataSource = db.Productos.
                    Include(Function(p) p.Categoria).
                    Select(Function(p) New With {
                        .Id = p.Id,
                        .Nombre = p.Nombre,
                        .Categoria = p.Categoria.Nombre,
                        .Precio = p.Precio,
                        .Existencia = p.Existencia
                    }).ToList()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar productos: " & ex.Message)
        End Try
    End Sub

    Private Sub LimpiarCampos()
        txtNombre.Clear()
        cboCategoria.SelectedIndex = -1
        nudPrecio.Value = nudPrecio.Minimum
        nudExistencia.Value = nudExistencia.Minimum
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Using db As New AppDbContext()
                Dim texto = txtBuscar.Text.Trim()

                dgvProductos.DataSource = db.Productos.
                    Include(Function(p) p.Categoria).
                    Where(Function(p) p.Nombre.Contains(texto)).
                    Select(Function(p) New With {
                        .Id = p.Id,
                        .Nombre = p.Nombre,
                        .Categoria = p.Categoria.Nombre,
                        .Precio = p.Precio,
                        .Existencia = p.Existencia
                    }).ToList()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al buscar: " & ex.Message)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        LimpiarCampos()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If String.IsNullOrWhiteSpace(txtNombre.Text) Then
            MessageBox.Show("Ingresá el nombre del producto.")
            txtNombre.Focus()
            Return
        End If

        If cboCategoria.SelectedValue Is Nothing OrElse
       Not IsNumeric(cboCategoria.SelectedValue) Then
            MessageBox.Show("Seleccioná una categoría.")
            Return
        End If

        Try
            Using db As New AppDbContext()
                Dim nuevo As New Producto With {
                .Nombre = txtNombre.Text.Trim(),
                .Precio = nudPrecio.Value,
                .Existencia = CInt(nudExistencia.Value),
                .CategoriaId = CInt(cboCategoria.SelectedValue)
            }

                db.Productos.Add(nuevo)
                db.SaveChanges()
            End Using

            CargarProductos()
            LimpiarCampos()
            MessageBox.Show("Producto guardado correctamente.")

        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvProductos.CurrentRow Is Nothing OrElse
   dgvProductos.CurrentRow.IsNewRow Then
            MessageBox.Show("Seleccioná un producto para eliminar.")
            Return
        End If

        Dim id As Integer =
            CInt(dgvProductos.CurrentRow.Cells("Id").Value)

        If MessageBox.Show(
            "¿Seguro que querés eliminar este producto?",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        ) <> DialogResult.Yes Then
            Return
        End If

        Try
            Using db As New AppDbContext()
                Dim producto = db.Productos.Find(id)

                If producto Is Nothing Then
                    MessageBox.Show("El producto ya no existe.")
                    Return
                End If

                db.Productos.Remove(producto)
                db.SaveChanges()
            End Using

            CargarProductos()
            LimpiarCampos()
            MessageBox.Show("Producto eliminado correctamente.")

        Catch ex As Exception
            MessageBox.Show("Error al eliminar: " & ex.Message)
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If dgvProductos.CurrentRow Is Nothing OrElse
   dgvProductos.CurrentRow.IsNewRow Then
            MessageBox.Show("Seleccioná un producto para actualizar.")
            Return
        End If

        If String.IsNullOrWhiteSpace(txtNombre.Text) Then
            MessageBox.Show("Ingresá el nombre del producto.")
            Return
        End If

        If cboCategoria.SelectedValue Is Nothing OrElse
           Not IsNumeric(cboCategoria.SelectedValue) Then
            MessageBox.Show("Seleccioná una categoría.")
            Return
        End If

        Try
            Dim id As Integer =
                CInt(dgvProductos.CurrentRow.Cells("Id").Value)

            Using db As New AppDbContext()
                Dim producto = db.Productos.Find(id)

                If producto Is Nothing Then
                    MessageBox.Show("No se encontró el producto.")
                    Return
                End If

                producto.Nombre = txtNombre.Text.Trim()
                producto.Precio = nudPrecio.Value
                producto.Existencia = CInt(nudExistencia.Value)
                producto.CategoriaId = CInt(cboCategoria.SelectedValue)

                db.SaveChanges()
            End Using

            CargarProductos()
            LimpiarCampos()

            MessageBox.Show("Producto actualizado correctamente.")

        Catch ex As Exception
            MessageBox.Show("Error al actualizar: " & ex.Message)
        End Try
    End Sub
End Class