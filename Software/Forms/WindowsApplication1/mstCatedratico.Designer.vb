<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mstCatedratico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mstCatedratico))
        Me.dgvEmpleado = New System.Windows.Forms.DataGridView()
        Me.gbIngresoDatos = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextCorreo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextCedula = New System.Windows.Forms.TextBox()
        Me.TextApellido = New System.Windows.Forms.TextBox()
        Me.TextNombre = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextDireccion = New System.Windows.Forms.TextBox()
        Me.TextTelefono = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextCelular = New System.Windows.Forms.TextBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnAniadir = New System.Windows.Forms.Button()
        Me.txtSueldo = New System.Windows.Forms.TextBox()
        Me.txtFechaIngreso = New System.Windows.Forms.TextBox()
        Me.txtFechaEgreso = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.dgvEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbIngresoDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvEmpleado
        '
        Me.dgvEmpleado.AllowUserToAddRows = False
        Me.dgvEmpleado.AllowUserToDeleteRows = False
        Me.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpleado.Location = New System.Drawing.Point(23, 299)
        Me.dgvEmpleado.Name = "dgvEmpleado"
        Me.dgvEmpleado.ReadOnly = True
        Me.dgvEmpleado.Size = New System.Drawing.Size(529, 184)
        Me.dgvEmpleado.TabIndex = 14
        '
        'gbIngresoDatos
        '
        Me.gbIngresoDatos.Controls.Add(Me.ComboBox1)
        Me.gbIngresoDatos.Controls.Add(Me.Label10)
        Me.gbIngresoDatos.Controls.Add(Me.Label11)
        Me.gbIngresoDatos.Controls.Add(Me.TextCorreo)
        Me.gbIngresoDatos.Controls.Add(Me.Label9)
        Me.gbIngresoDatos.Controls.Add(Me.TextCedula)
        Me.gbIngresoDatos.Controls.Add(Me.TextApellido)
        Me.gbIngresoDatos.Controls.Add(Me.TextNombre)
        Me.gbIngresoDatos.Controls.Add(Me.Label8)
        Me.gbIngresoDatos.Controls.Add(Me.Label7)
        Me.gbIngresoDatos.Controls.Add(Me.Label5)
        Me.gbIngresoDatos.Controls.Add(Me.TextDireccion)
        Me.gbIngresoDatos.Controls.Add(Me.TextTelefono)
        Me.gbIngresoDatos.Controls.Add(Me.Label4)
        Me.gbIngresoDatos.Controls.Add(Me.Label3)
        Me.gbIngresoDatos.Controls.Add(Me.TextCelular)
        Me.gbIngresoDatos.Controls.Add(Me.btnModificar)
        Me.gbIngresoDatos.Controls.Add(Me.btnEliminar)
        Me.gbIngresoDatos.Controls.Add(Me.btnLimpiar)
        Me.gbIngresoDatos.Controls.Add(Me.btnAniadir)
        Me.gbIngresoDatos.Controls.Add(Me.txtSueldo)
        Me.gbIngresoDatos.Controls.Add(Me.txtFechaIngreso)
        Me.gbIngresoDatos.Controls.Add(Me.txtFechaEgreso)
        Me.gbIngresoDatos.Controls.Add(Me.Label2)
        Me.gbIngresoDatos.Controls.Add(Me.Label6)
        Me.gbIngresoDatos.Controls.Add(Me.Label1)
        Me.gbIngresoDatos.Location = New System.Drawing.Point(23, 28)
        Me.gbIngresoDatos.Name = "gbIngresoDatos"
        Me.gbIngresoDatos.Size = New System.Drawing.Size(529, 251)
        Me.gbIngresoDatos.TabIndex = 13
        Me.gbIngresoDatos.TabStop = False
        Me.gbIngresoDatos.Text = "Ingreso de datos"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(280, 174)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Correo"
        '
        'TextCorreo
        '
        Me.TextCorreo.Location = New System.Drawing.Point(356, 168)
        Me.TextCorreo.Name = "TextCorreo"
        Me.TextCorreo.Size = New System.Drawing.Size(158, 20)
        Me.TextCorreo.TabIndex = 24
        Me.TextCorreo.Tag = "correo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 175)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "No. Cedula"
        '
        'TextCedula
        '
        Me.TextCedula.Location = New System.Drawing.Point(108, 168)
        Me.TextCedula.Name = "TextCedula"
        Me.TextCedula.Size = New System.Drawing.Size(100, 20)
        Me.TextCedula.TabIndex = 20
        Me.TextCedula.Tag = "no_cedula"
        '
        'TextApellido
        '
        Me.TextApellido.Location = New System.Drawing.Point(339, 144)
        Me.TextApellido.Name = "TextApellido"
        Me.TextApellido.Size = New System.Drawing.Size(175, 20)
        Me.TextApellido.TabIndex = 19
        Me.TextApellido.Tag = "apellidos"
        '
        'TextNombre
        '
        Me.TextNombre.Location = New System.Drawing.Point(108, 142)
        Me.TextNombre.Name = "TextNombre"
        Me.TextNombre.Size = New System.Drawing.Size(158, 20)
        Me.TextNombre.TabIndex = 18
        Me.TextNombre.Tag = "nombres"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(280, 147)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Apellido"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Direccion"
        '
        'TextDireccion
        '
        Me.TextDireccion.Location = New System.Drawing.Point(108, 116)
        Me.TextDireccion.Name = "TextDireccion"
        Me.TextDireccion.Size = New System.Drawing.Size(406, 20)
        Me.TextDireccion.TabIndex = 14
        Me.TextDireccion.Tag = "direccion"
        '
        'TextTelefono
        '
        Me.TextTelefono.Location = New System.Drawing.Point(414, 87)
        Me.TextTelefono.Name = "TextTelefono"
        Me.TextTelefono.Size = New System.Drawing.Size(100, 20)
        Me.TextTelefono.TabIndex = 13
        Me.TextTelefono.Tag = "telefono_casa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(353, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Telefono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(196, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Celular"
        '
        'TextCelular
        '
        Me.TextCelular.Location = New System.Drawing.Point(252, 86)
        Me.TextCelular.Name = "TextCelular"
        Me.TextCelular.Size = New System.Drawing.Size(95, 20)
        Me.TextCelular.TabIndex = 10
        Me.TextCelular.Tag = "celular"
        '
        'btnModificar
        '
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(478, 19)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(36, 36)
        Me.btnModificar.TabIndex = 9
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(436, 19)
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
        Me.btnAniadir.Location = New System.Drawing.Point(394, 19)
        Me.btnAniadir.Name = "btnAniadir"
        Me.btnAniadir.Size = New System.Drawing.Size(36, 36)
        Me.btnAniadir.TabIndex = 7
        Me.btnAniadir.UseVisualStyleBackColor = True
        '
        'txtSueldo
        '
        Me.txtSueldo.Location = New System.Drawing.Point(108, 84)
        Me.txtSueldo.MaxLength = 200
        Me.txtSueldo.Multiline = True
        Me.txtSueldo.Name = "txtSueldo"
        Me.txtSueldo.Size = New System.Drawing.Size(79, 22)
        Me.txtSueldo.TabIndex = 6
        Me.txtSueldo.Tag = "sueldo"
        '
        'txtFechaIngreso
        '
        Me.txtFechaIngreso.Location = New System.Drawing.Point(108, 60)
        Me.txtFechaIngreso.MaxLength = 4
        Me.txtFechaIngreso.Name = "txtFechaIngreso"
        Me.txtFechaIngreso.Size = New System.Drawing.Size(79, 20)
        Me.txtFechaIngreso.TabIndex = 1
        Me.txtFechaIngreso.Tag = "fecha_ingreso"
        '
        'txtFechaEgreso
        '
        Me.txtFechaEgreso.Location = New System.Drawing.Point(275, 61)
        Me.txtFechaEgreso.MaxLength = 100
        Me.txtFechaEgreso.Name = "txtFechaEgreso"
        Me.txtFechaEgreso.Size = New System.Drawing.Size(239, 20)
        Me.txtFechaEgreso.TabIndex = 2
        Me.txtFechaEgreso.Tag = "fecha_egreso"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Sueldo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Fecha Ingreso"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(193, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Egreso:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 205)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Tipo Empleado:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(108, 196)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 27
        '
        'mstCatedratico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 505)
        Me.Controls.Add(Me.dgvEmpleado)
        Me.Controls.Add(Me.gbIngresoDatos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mstCatedratico"
        Me.Text = "Empleado"
        CType(Me.dgvEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbIngresoDatos.ResumeLayout(False)
        Me.gbIngresoDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvEmpleado As System.Windows.Forms.DataGridView
    Friend WithEvents gbIngresoDatos As System.Windows.Forms.GroupBox
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnAniadir As System.Windows.Forms.Button
    Friend WithEvents txtSueldo As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaIngreso As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaEgreso As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextCorreo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextCedula As System.Windows.Forms.TextBox
    Friend WithEvents TextApellido As System.Windows.Forms.TextBox
    Friend WithEvents TextNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextDireccion As System.Windows.Forms.TextBox
    Friend WithEvents TextTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextCelular As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
