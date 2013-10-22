<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mstAlumno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mstAlumno))
        Me.dgvAlumno = New System.Windows.Forms.DataGridView()
        Me.gbIngresoDatos = New System.Windows.Forms.GroupBox()
        Me.Label = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtCorrelativo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtAnio = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbxCarrera = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCarreraEgresado = New System.Windows.Forms.TextBox()
        Me.txtColegioEgresado = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtDpi = New System.Windows.Forms.TextBox()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.txtFechaNacimiento = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnAniadir = New System.Windows.Forms.Button()
        Me.txtSexo = New System.Windows.Forms.TextBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvAlumno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbIngresoDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvAlumno
        '
        Me.dgvAlumno.AllowUserToAddRows = False
        Me.dgvAlumno.AllowUserToDeleteRows = False
        Me.dgvAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlumno.Location = New System.Drawing.Point(33, 350)
        Me.dgvAlumno.Name = "dgvAlumno"
        Me.dgvAlumno.ReadOnly = True
        Me.dgvAlumno.Size = New System.Drawing.Size(529, 168)
        Me.dgvAlumno.TabIndex = 12
        '
        'gbIngresoDatos
        '
        Me.gbIngresoDatos.Controls.Add(Me.Label)
        Me.gbIngresoDatos.Controls.Add(Me.txtDireccion)
        Me.gbIngresoDatos.Controls.Add(Me.txtCorrelativo)
        Me.gbIngresoDatos.Controls.Add(Me.Label13)
        Me.gbIngresoDatos.Controls.Add(Me.txtAnio)
        Me.gbIngresoDatos.Controls.Add(Me.Label12)
        Me.gbIngresoDatos.Controls.Add(Me.cbxCarrera)
        Me.gbIngresoDatos.Controls.Add(Me.Label11)
        Me.gbIngresoDatos.Controls.Add(Me.txtCarreraEgresado)
        Me.gbIngresoDatos.Controls.Add(Me.txtColegioEgresado)
        Me.gbIngresoDatos.Controls.Add(Me.Label10)
        Me.gbIngresoDatos.Controls.Add(Me.Label9)
        Me.gbIngresoDatos.Controls.Add(Me.Label8)
        Me.gbIngresoDatos.Controls.Add(Me.Label7)
        Me.gbIngresoDatos.Controls.Add(Me.txtCelular)
        Me.gbIngresoDatos.Controls.Add(Me.txtTelefono)
        Me.gbIngresoDatos.Controls.Add(Me.txtDpi)
        Me.gbIngresoDatos.Controls.Add(Me.TxtCorreo)
        Me.gbIngresoDatos.Controls.Add(Me.txtFechaNacimiento)
        Me.gbIngresoDatos.Controls.Add(Me.Label5)
        Me.gbIngresoDatos.Controls.Add(Me.Label4)
        Me.gbIngresoDatos.Controls.Add(Me.btnModificar)
        Me.gbIngresoDatos.Controls.Add(Me.btnEliminar)
        Me.gbIngresoDatos.Controls.Add(Me.btnLimpiar)
        Me.gbIngresoDatos.Controls.Add(Me.btnAniadir)
        Me.gbIngresoDatos.Controls.Add(Me.txtSexo)
        Me.gbIngresoDatos.Controls.Add(Me.txtNombres)
        Me.gbIngresoDatos.Controls.Add(Me.txtApellidos)
        Me.gbIngresoDatos.Controls.Add(Me.Label2)
        Me.gbIngresoDatos.Controls.Add(Me.Label6)
        Me.gbIngresoDatos.Controls.Add(Me.Label3)
        Me.gbIngresoDatos.Controls.Add(Me.Label1)
        Me.gbIngresoDatos.Location = New System.Drawing.Point(33, 14)
        Me.gbIngresoDatos.Name = "gbIngresoDatos"
        Me.gbIngresoDatos.Size = New System.Drawing.Size(529, 322)
        Me.gbIngresoDatos.TabIndex = 11
        Me.gbIngresoDatos.TabStop = False
        Me.gbIngresoDatos.Text = "Ingreso de datos"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(18, 174)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(55, 13)
        Me.Label.TabIndex = 29
        Me.Label.Text = "Direccion:"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(108, 174)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(406, 20)
        Me.txtDireccion.TabIndex = 9
        Me.txtDireccion.Tag = "direccion"
        '
        'txtCorrelativo
        '
        Me.txtCorrelativo.Location = New System.Drawing.Point(375, 200)
        Me.txtCorrelativo.Name = "txtCorrelativo"
        Me.txtCorrelativo.Size = New System.Drawing.Size(139, 20)
        Me.txtCorrelativo.TabIndex = 11
        Me.txtCorrelativo.Tag = "correlativo_carnet"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(273, 203)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 13)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Correlativo Carnet"
        '
        'txtAnio
        '
        Me.txtAnio.Location = New System.Drawing.Point(108, 200)
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(158, 20)
        Me.txtAnio.TabIndex = 10
        Me.txtAnio.Tag = "anio_carnet"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 203)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Anio Carnet"
        '
        'cbxCarrera
        '
        Me.cbxCarrera.FormattingEnabled = True
        Me.cbxCarrera.Location = New System.Drawing.Point(108, 234)
        Me.cbxCarrera.Name = "cbxCarrera"
        Me.cbxCarrera.Size = New System.Drawing.Size(121, 21)
        Me.cbxCarrera.TabIndex = 12
        Me.cbxCarrera.Tag = "id_carrera"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 234)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "IdCarrera"
        '
        'txtCarreraEgresado
        '
        Me.txtCarreraEgresado.Location = New System.Drawing.Point(108, 292)
        Me.txtCarreraEgresado.Name = "txtCarreraEgresado"
        Me.txtCarreraEgresado.Size = New System.Drawing.Size(348, 20)
        Me.txtCarreraEgresado.TabIndex = 14
        Me.txtCarreraEgresado.Tag = "carrera_egresado"
        '
        'txtColegioEgresado
        '
        Me.txtColegioEgresado.Location = New System.Drawing.Point(108, 265)
        Me.txtColegioEgresado.Name = "txtColegioEgresado"
        Me.txtColegioEgresado.Size = New System.Drawing.Size(348, 20)
        Me.txtColegioEgresado.TabIndex = 13
        Me.txtColegioEgresado.Tag = "colegio_egresado"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 295)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Carrera Egresado:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 272)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Colegio Egresado:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(272, 140)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Celular:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Telefono:"
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(375, 140)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(139, 20)
        Me.txtCelular.TabIndex = 8
        Me.txtCelular.Tag = "celular"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(108, 141)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(158, 20)
        Me.txtTelefono.TabIndex = 7
        Me.txtTelefono.Tag = "telefono_casa"
        '
        'txtDpi
        '
        Me.txtDpi.Location = New System.Drawing.Point(375, 113)
        Me.txtDpi.Name = "txtDpi"
        Me.txtDpi.Size = New System.Drawing.Size(139, 20)
        Me.txtDpi.TabIndex = 6
        Me.txtDpi.Tag = "dpi"
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Location = New System.Drawing.Point(108, 114)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(158, 20)
        Me.TxtCorreo.TabIndex = 5
        Me.TxtCorreo.Tag = "correo"
        '
        'txtFechaNacimiento
        '
        Me.txtFechaNacimiento.Location = New System.Drawing.Point(375, 87)
        Me.txtFechaNacimiento.Name = "txtFechaNacimiento"
        Me.txtFechaNacimiento.Size = New System.Drawing.Size(139, 20)
        Me.txtFechaNacimiento.TabIndex = 4
        Me.txtFechaNacimiento.Tag = "fecha_nac"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(272, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Fecha Nacimiento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Sexo"
        '
        'btnModificar
        '
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(478, 19)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(36, 36)
        Me.btnModificar.TabIndex = 17
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(436, 19)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(36, 36)
        Me.btnEliminar.TabIndex = 16
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimpiar.Location = New System.Drawing.Point(21, 19)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(86, 36)
        Me.btnLimpiar.TabIndex = 18
        Me.btnLimpiar.Text = "          Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnAniadir
        '
        Me.btnAniadir.Image = CType(resources.GetObject("btnAniadir.Image"), System.Drawing.Image)
        Me.btnAniadir.Location = New System.Drawing.Point(394, 19)
        Me.btnAniadir.Name = "btnAniadir"
        Me.btnAniadir.Size = New System.Drawing.Size(36, 36)
        Me.btnAniadir.TabIndex = 15
        Me.btnAniadir.UseVisualStyleBackColor = True
        '
        'txtSexo
        '
        Me.txtSexo.Location = New System.Drawing.Point(108, 86)
        Me.txtSexo.MaxLength = 200
        Me.txtSexo.Multiline = True
        Me.txtSexo.Name = "txtSexo"
        Me.txtSexo.Size = New System.Drawing.Size(158, 20)
        Me.txtSexo.TabIndex = 3
        Me.txtSexo.Tag = "sexo"
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(108, 60)
        Me.txtNombres.MaxLength = 100
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(158, 20)
        Me.txtNombres.TabIndex = 1
        Me.txtNombres.Tag = "nombres"
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(333, 61)
        Me.txtApellidos.MaxLength = 100
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(181, 20)
        Me.txtApellidos.TabIndex = 2
        Me.txtApellidos.Tag = "apellidos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(272, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "DPI:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Nombres:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Correo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(272, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apellidos: "
        '
        'mstAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 530)
        Me.Controls.Add(Me.dgvAlumno)
        Me.Controls.Add(Me.gbIngresoDatos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mstAlumno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alumno"
        CType(Me.dgvAlumno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbIngresoDatos.ResumeLayout(False)
        Me.gbIngresoDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvAlumno As System.Windows.Forms.DataGridView
    Friend WithEvents gbIngresoDatos As System.Windows.Forms.GroupBox
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnAniadir As System.Windows.Forms.Button
    Friend WithEvents txtSexo As System.Windows.Forms.TextBox
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents txtApellidos As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaNacimiento As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCarreraEgresado As System.Windows.Forms.TextBox
    Friend WithEvents txtColegioEgresado As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCelular As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtDpi As System.Windows.Forms.TextBox
    Friend WithEvents cbxCarrera As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCorrelativo As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtAnio As System.Windows.Forms.TextBox
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
End Class
