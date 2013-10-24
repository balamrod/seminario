<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MstCarrera
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MstCarrera))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbIngresoDatos = New System.Windows.Forms.GroupBox()
        Me.cbSucursal = New System.Windows.Forms.ComboBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnAniadir = New System.Windows.Forms.Button()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtFechaAcuerdo = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtAcuerdo = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvCarrera = New System.Windows.Forms.DataGridView()
        Me.pnlBotones = New System.Windows.Forms.Panel()
        Me.gbIngresoDatos.SuspendLayout()
        CType(Me.dgvCarrera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(193, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'gbIngresoDatos
        '
        Me.gbIngresoDatos.Controls.Add(Me.pnlBotones)
        Me.gbIngresoDatos.Controls.Add(Me.cbSucursal)
        Me.gbIngresoDatos.Controls.Add(Me.btnLimpiar)
        Me.gbIngresoDatos.Controls.Add(Me.txtDescripcion)
        Me.gbIngresoDatos.Controls.Add(Me.txtFechaAcuerdo)
        Me.gbIngresoDatos.Controls.Add(Me.txtCodigo)
        Me.gbIngresoDatos.Controls.Add(Me.txtAcuerdo)
        Me.gbIngresoDatos.Controls.Add(Me.txtNombre)
        Me.gbIngresoDatos.Controls.Add(Me.Label5)
        Me.gbIngresoDatos.Controls.Add(Me.Label2)
        Me.gbIngresoDatos.Controls.Add(Me.Label4)
        Me.gbIngresoDatos.Controls.Add(Me.Label6)
        Me.gbIngresoDatos.Controls.Add(Me.Label3)
        Me.gbIngresoDatos.Controls.Add(Me.Label1)
        Me.gbIngresoDatos.Location = New System.Drawing.Point(12, 12)
        Me.gbIngresoDatos.Name = "gbIngresoDatos"
        Me.gbIngresoDatos.Size = New System.Drawing.Size(529, 172)
        Me.gbIngresoDatos.TabIndex = 1
        Me.gbIngresoDatos.TabStop = False
        Me.gbIngresoDatos.Text = "Ingreso de datos"
        '
        'cbSucursal
        '
        Me.cbSucursal.FormattingEnabled = True
        Me.cbSucursal.Location = New System.Drawing.Point(108, 86)
        Me.cbSucursal.Name = "cbSucursal"
        Me.cbSucursal.Size = New System.Drawing.Size(121, 21)
        Me.cbSucursal.TabIndex = 3
        '
        'btnModificar
        '
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(86, 3)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(36, 36)
        Me.btnModificar.TabIndex = 9
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(44, 3)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(36, 36)
        Me.btnEliminar.TabIndex = 8
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimpiar.Location = New System.Drawing.Point(21, 19)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(86, 36)
        Me.btnLimpiar.TabIndex = 7
        Me.btnLimpiar.Text = "          Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnAniadir
        '
        Me.btnAniadir.Image = CType(resources.GetObject("btnAniadir.Image"), System.Drawing.Image)
        Me.btnAniadir.Location = New System.Drawing.Point(2, 3)
        Me.btnAniadir.Name = "btnAniadir"
        Me.btnAniadir.Size = New System.Drawing.Size(36, 36)
        Me.btnAniadir.TabIndex = 7
        Me.btnAniadir.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(108, 118)
        Me.txtDescripcion.MaxLength = 200
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(406, 43)
        Me.txtDescripcion.TabIndex = 6
        Me.txtDescripcion.Tag = "descripcion"
        '
        'txtFechaAcuerdo
        '
        Me.txtFechaAcuerdo.Location = New System.Drawing.Point(449, 87)
        Me.txtFechaAcuerdo.Name = "txtFechaAcuerdo"
        Me.txtFechaAcuerdo.Size = New System.Drawing.Size(65, 20)
        Me.txtFechaAcuerdo.TabIndex = 5
        Me.txtFechaAcuerdo.Tag = "fecha_acuerdo"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(108, 60)
        Me.txtCodigo.MaxLength = 4
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(79, 20)
        Me.txtCodigo.TabIndex = 1
        Me.txtCodigo.Tag = "id_carrera"
        '
        'txtAcuerdo
        '
        Me.txtAcuerdo.Location = New System.Drawing.Point(291, 87)
        Me.txtAcuerdo.MaxLength = 50
        Me.txtAcuerdo.Name = "txtAcuerdo"
        Me.txtAcuerdo.Size = New System.Drawing.Size(59, 20)
        Me.txtAcuerdo.TabIndex = 4
        Me.txtAcuerdo.Tag = "acuerdo"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(246, 61)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(268, 20)
        Me.txtNombre.TabIndex = 2
        Me.txtNombre.Tag = "nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(356, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Fecha acuerdo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Descripción:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(235, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Acuerdo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Código"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Sucursal:"
        '
        'dgvCarrera
        '
        Me.dgvCarrera.AllowUserToAddRows = False
        Me.dgvCarrera.AllowUserToDeleteRows = False
        Me.dgvCarrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCarrera.Location = New System.Drawing.Point(12, 190)
        Me.dgvCarrera.Name = "dgvCarrera"
        Me.dgvCarrera.ReadOnly = True
        Me.dgvCarrera.Size = New System.Drawing.Size(529, 256)
        Me.dgvCarrera.TabIndex = 10
        '
        'pnlBotones
        '
        Me.pnlBotones.Controls.Add(Me.btnEliminar)
        Me.pnlBotones.Controls.Add(Me.btnAniadir)
        Me.pnlBotones.Controls.Add(Me.btnModificar)
        Me.pnlBotones.Location = New System.Drawing.Point(388, 10)
        Me.pnlBotones.Name = "pnlBotones"
        Me.pnlBotones.Size = New System.Drawing.Size(126, 45)
        Me.pnlBotones.TabIndex = 10
        '
        'MstCarrera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 456)
        Me.Controls.Add(Me.dgvCarrera)
        Me.Controls.Add(Me.gbIngresoDatos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MstCarrera"
        Me.Text = "Carrera"
        Me.gbIngresoDatos.ResumeLayout(False)
        Me.gbIngresoDatos.PerformLayout()
        CType(Me.dgvCarrera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbIngresoDatos As System.Windows.Forms.GroupBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnAniadir As System.Windows.Forms.Button
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents dgvCarrera As System.Windows.Forms.DataGridView
    Friend WithEvents cbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents txtFechaAcuerdo As System.Windows.Forms.TextBox
    Friend WithEvents txtAcuerdo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents pnlBotones As System.Windows.Forms.Panel

End Class
