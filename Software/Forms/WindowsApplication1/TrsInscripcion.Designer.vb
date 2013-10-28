<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrsInscripcion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TrsInscripcion))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbCiclo = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnAniadir = New System.Windows.Forms.Button()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtContrato = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtMatricula = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCorrelativo = New System.Windows.Forms.TextBox()
        Me.txtCodAnio = New System.Windows.Forms.TextBox()
        Me.txtCodCarrera = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dvgHistorialInscripciones = New System.Windows.Forms.DataGridView()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnAsignar = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dvgHistorialInscripciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbCiclo)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.btnAniadir)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.txtContrato)
        Me.GroupBox1.Controls.Add(Me.txtFecha)
        Me.GroupBox1.Controls.Add(Me.txtMatricula)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txtCorrelativo)
        Me.GroupBox1.Controls.Add(Me.txtCodAnio)
        Me.GroupBox1.Controls.Add(Me.txtCodCarrera)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(621, 134)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de datos"
        '
        'cbCiclo
        '
        Me.cbCiclo.FormattingEnabled = True
        Me.cbCiclo.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cbCiclo.Location = New System.Drawing.Point(359, 50)
        Me.cbCiclo.Name = "cbCiclo"
        Me.cbCiclo.Size = New System.Drawing.Size(97, 21)
        Me.cbCiclo.TabIndex = 9
        Me.cbCiclo.Tag = ""
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(576, 21)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(25, 26)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnAniadir
        '
        Me.btnAniadir.Image = CType(resources.GetObject("btnAniadir.Image"), System.Drawing.Image)
        Me.btnAniadir.Location = New System.Drawing.Point(544, 21)
        Me.btnAniadir.Name = "btnAniadir"
        Me.btnAniadir.Size = New System.Drawing.Size(25, 26)
        Me.btnAniadir.TabIndex = 5
        Me.btnAniadir.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(111, 80)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(490, 43)
        Me.txtDescripcion.TabIndex = 11
        Me.txtDescripcion.Tag = "observaciones"
        '
        'txtContrato
        '
        Me.txtContrato.Enabled = False
        Me.txtContrato.Location = New System.Drawing.Point(515, 51)
        Me.txtContrato.Name = "txtContrato"
        Me.txtContrato.Size = New System.Drawing.Size(86, 20)
        Me.txtContrato.TabIndex = 10
        Me.txtContrato.Tag = "no_contrato_est"
        '
        'txtFecha
        '
        Me.txtFecha.Enabled = False
        Me.txtFecha.Location = New System.Drawing.Point(232, 51)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(82, 20)
        Me.txtFecha.TabIndex = 8
        Me.txtFecha.Tag = "fecha"
        '
        'txtMatricula
        '
        Me.txtMatricula.Enabled = False
        Me.txtMatricula.Location = New System.Drawing.Point(111, 51)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(69, 20)
        Me.txtMatricula.TabIndex = 7
        Me.txtMatricula.Tag = "matricula"
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(282, 25)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(256, 20)
        Me.txtNombre.TabIndex = 4
        '
        'txtCorrelativo
        '
        Me.txtCorrelativo.Location = New System.Drawing.Point(189, 25)
        Me.txtCorrelativo.Name = "txtCorrelativo"
        Me.txtCorrelativo.Size = New System.Drawing.Size(34, 20)
        Me.txtCorrelativo.TabIndex = 3
        Me.txtCorrelativo.Tag = "numero_carnet"
        '
        'txtCodAnio
        '
        Me.txtCodAnio.Location = New System.Drawing.Point(156, 25)
        Me.txtCodAnio.Name = "txtCodAnio"
        Me.txtCodAnio.Size = New System.Drawing.Size(27, 20)
        Me.txtCodAnio.TabIndex = 2
        Me.txtCodAnio.Tag = "anio_carnet"
        '
        'txtCodCarrera
        '
        Me.txtCodCarrera.Location = New System.Drawing.Point(111, 25)
        Me.txtCodCarrera.Name = "txtCodCarrera"
        Me.txtCodCarrera.Size = New System.Drawing.Size(39, 20)
        Me.txtCodCarrera.TabIndex = 1
        Me.txtCodCarrera.Tag = "id_carrera"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Observación:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(229, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Alumno:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(463, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Contrato:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(320, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Ciclo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(186, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Fecha:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Matricula: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Carnet:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dvgHistorialInscripciones)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 152)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(621, 156)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Historial Inscripciones"
        '
        'dvgHistorialInscripciones
        '
        Me.dvgHistorialInscripciones.AllowUserToAddRows = False
        Me.dvgHistorialInscripciones.AllowUserToDeleteRows = False
        Me.dvgHistorialInscripciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgHistorialInscripciones.Location = New System.Drawing.Point(24, 18)
        Me.dvgHistorialInscripciones.Name = "dvgHistorialInscripciones"
        Me.dvgHistorialInscripciones.ReadOnly = True
        Me.dvgHistorialInscripciones.Size = New System.Drawing.Size(577, 132)
        Me.dvgHistorialInscripciones.TabIndex = 12
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(443, 313)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(82, 40)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "         Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnAsignar
        '
        Me.btnAsignar.Image = CType(resources.GetObject("btnAsignar.Image"), System.Drawing.Image)
        Me.btnAsignar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAsignar.Location = New System.Drawing.Point(531, 314)
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.Size = New System.Drawing.Size(82, 40)
        Me.btnAsignar.TabIndex = 3
        Me.btnAsignar.Text = "          Asignar"
        Me.btnAsignar.UseVisualStyleBackColor = True
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblError.Location = New System.Drawing.Point(12, 327)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 13)
        Me.lblError.TabIndex = 4
        '
        'TrsInscripcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 365)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnAsignar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TrsInscripcion"
        Me.Text = "Inscripcion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dvgHistorialInscripciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCodCarrera As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents txtMatricula As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtCorrelativo As System.Windows.Forms.TextBox
    Friend WithEvents txtCodAnio As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnAniadir As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dvgHistorialInscripciones As System.Windows.Forms.DataGridView
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnAsignar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtContrato As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents cbCiclo As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
