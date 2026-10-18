<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmProductos
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblBuscar = New System.Windows.Forms.Label()
        lblNombre = New System.Windows.Forms.Label()
        lblCategoria = New System.Windows.Forms.Label()
        lblPrecio = New System.Windows.Forms.Label()
        lblExistencia = New System.Windows.Forms.Label()
        txtBuscar = New System.Windows.Forms.TextBox()
        txtNombre = New System.Windows.Forms.TextBox()
        btnNuevo = New System.Windows.Forms.Button()
        btnGuardar = New System.Windows.Forms.Button()
        btnActualizar = New System.Windows.Forms.Button()
        btnEliminar = New System.Windows.Forms.Button()
        btnBuscar = New System.Windows.Forms.Button()
        cboCategoria = New System.Windows.Forms.ComboBox()
        nudPrecio = New System.Windows.Forms.NumericUpDown()
        nudExistencia = New System.Windows.Forms.NumericUpDown()
        dgvProductos = New System.Windows.Forms.DataGridView()
        lblListo = New System.Windows.Forms.ToolStripStatusLabel()
        lblEstado = New System.Windows.Forms.StatusStrip()
        CType(nudPrecio, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudExistencia, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvProductos, ComponentModel.ISupportInitialize).BeginInit()
        lblEstado.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblBuscar
        ' 
        lblBuscar.AutoSize = True
        lblBuscar.Location = New System.Drawing.Point(12, 9)
        lblBuscar.Name = "lblBuscar"
        lblBuscar.Size = New System.Drawing.Size(48, 15)
        lblBuscar.TabIndex = 0
        lblBuscar.Text = "Buscar :"
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Location = New System.Drawing.Point(621, 47)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New System.Drawing.Size(51, 15)
        lblNombre.TabIndex = 1
        lblNombre.Text = "Nombre"
        ' 
        ' lblCategoria
        ' 
        lblCategoria.AutoSize = True
        lblCategoria.Location = New System.Drawing.Point(621, 110)
        lblCategoria.Name = "lblCategoria"
        lblCategoria.Size = New System.Drawing.Size(58, 15)
        lblCategoria.TabIndex = 2
        lblCategoria.Text = "Categoria"
        ' 
        ' lblPrecio
        ' 
        lblPrecio.AutoSize = True
        lblPrecio.Location = New System.Drawing.Point(621, 176)
        lblPrecio.Name = "lblPrecio"
        lblPrecio.Size = New System.Drawing.Size(65, 15)
        lblPrecio.TabIndex = 3
        lblPrecio.Text = "Precio (C$)"
        ' 
        ' lblExistencia
        ' 
        lblExistencia.AutoSize = True
        lblExistencia.Location = New System.Drawing.Point(621, 245)
        lblExistencia.Name = "lblExistencia"
        lblExistencia.Size = New System.Drawing.Size(61, 15)
        lblExistencia.TabIndex = 4
        lblExistencia.Text = "Existencia "
        ' 
        ' txtBuscar
        ' 
        txtBuscar.BackColor = Drawing.Color.PaleTurquoise
        txtBuscar.Location = New System.Drawing.Point(66, 9)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New System.Drawing.Size(270, 23)
        txtBuscar.TabIndex = 6
        ' 
        ' txtNombre
        ' 
        txtNombre.BackColor = Drawing.Color.FromArgb(CByte(192), CByte(255), CByte(255))
        txtNombre.Location = New System.Drawing.Point(621, 65)
        txtNombre.MaxLength = 100
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New System.Drawing.Size(278, 23)
        txtNombre.TabIndex = 7
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New System.Drawing.Point(637, 340)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New System.Drawing.Size(124, 32)
        btnNuevo.TabIndex = 8
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = Drawing.Color.Blue
        btnGuardar.ForeColor = Drawing.SystemColors.ButtonHighlight
        btnGuardar.Location = New System.Drawing.Point(637, 378)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New System.Drawing.Size(124, 31)
        btnGuardar.TabIndex = 9
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' btnActualizar
        ' 
        btnActualizar.BackColor = Drawing.Color.Red
        btnActualizar.ForeColor = Drawing.SystemColors.Control
        btnActualizar.Location = New System.Drawing.Point(779, 378)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New System.Drawing.Size(124, 32)
        btnActualizar.TabIndex = 10
        btnActualizar.Text = "Actualizar"
        btnActualizar.UseVisualStyleBackColor = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = Drawing.Color.Blue
        btnEliminar.ForeColor = Drawing.SystemColors.Control
        btnEliminar.Location = New System.Drawing.Point(779, 340)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New System.Drawing.Size(124, 32)
        btnEliminar.TabIndex = 11
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New System.Drawing.Point(342, 9)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New System.Drawing.Size(75, 23)
        btnBuscar.TabIndex = 12
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' cboCategoria
        ' 
        cboCategoria.BackColor = Drawing.Color.FromArgb(CByte(192), CByte(255), CByte(255))
        cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        cboCategoria.FormattingEnabled = True
        cboCategoria.Location = New System.Drawing.Point(621, 128)
        cboCategoria.Name = "cboCategoria"
        cboCategoria.Size = New System.Drawing.Size(278, 23)
        cboCategoria.TabIndex = 13
        ' 
        ' nudPrecio
        ' 
        nudPrecio.BackColor = Drawing.Color.FromArgb(CByte(192), CByte(255), CByte(255))
        nudPrecio.DecimalPlaces = 2
        nudPrecio.Location = New System.Drawing.Point(621, 194)
        nudPrecio.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        nudPrecio.Name = "nudPrecio"
        nudPrecio.Size = New System.Drawing.Size(120, 23)
        nudPrecio.TabIndex = 14
        ' 
        ' nudExistencia
        ' 
        nudExistencia.BackColor = Drawing.Color.FromArgb(CByte(192), CByte(255), CByte(255))
        nudExistencia.Location = New System.Drawing.Point(621, 263)
        nudExistencia.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        nudExistencia.Name = "nudExistencia"
        nudExistencia.Size = New System.Drawing.Size(120, 23)
        nudExistencia.TabIndex = 15
        ' 
        ' dgvProductos
        ' 
        dgvProductos.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
        dgvProductos.BackgroundColor = Drawing.Color.PaleTurquoise
        dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProductos.Location = New System.Drawing.Point(12, 38)
        dgvProductos.Name = "dgvProductos"
        dgvProductos.Size = New System.Drawing.Size(555, 394)
        dgvProductos.TabIndex = 16
        ' 
        ' lblListo
        ' 
        lblListo.Name = "lblListo"
        lblListo.Size = New System.Drawing.Size(32, 17)
        lblListo.Text = "Listo"
        ' 
        ' lblEstado
        ' 
        lblEstado.AutoSize = False
        lblEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {lblListo})
        lblEstado.Location = New System.Drawing.Point(0, 459)
        lblEstado.Name = "lblEstado"
        lblEstado.Size = New System.Drawing.Size(924, 22)
        lblEstado.TabIndex = 17
        lblEstado.Text = "StatusStrip1"
        ' 
        ' FrmProductos
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(924, 481)
        Controls.Add(lblEstado)
        Controls.Add(dgvProductos)
        Controls.Add(nudExistencia)
        Controls.Add(nudPrecio)
        Controls.Add(cboCategoria)
        Controls.Add(btnBuscar)
        Controls.Add(btnEliminar)
        Controls.Add(btnActualizar)
        Controls.Add(btnGuardar)
        Controls.Add(btnNuevo)
        Controls.Add(txtNombre)
        Controls.Add(txtBuscar)
        Controls.Add(lblExistencia)
        Controls.Add(lblPrecio)
        Controls.Add(lblCategoria)
        Controls.Add(lblNombre)
        Controls.Add(lblBuscar)
        Name = "FrmProductos"
        Text = "Inventario - Libreria y Papeleria Segovia"
        CType(nudPrecio, ComponentModel.ISupportInitialize).EndInit()
        CType(nudExistencia, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvProductos, ComponentModel.ISupportInitialize).EndInit()
        lblEstado.ResumeLayout(False)
        lblEstado.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblCategoria As System.Windows.Forms.Label
    Friend WithEvents lblPrecio As System.Windows.Forms.Label
    Friend WithEvents lblExistencia As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents cboCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents nudPrecio As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudExistencia As System.Windows.Forms.NumericUpDown
    Friend WithEvents dgvProductos As System.Windows.Forms.DataGridView
    Friend WithEvents lblListo As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblEstado As System.Windows.Forms.StatusStrip

End Class
