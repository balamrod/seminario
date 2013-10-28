<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrsAsignacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TrsAsignacion))
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtAlumno = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.txtCarrera = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbCursos = New System.Windows.Forms.GroupBox()
        Me.lblCiclo5 = New System.Windows.Forms.Label()
        Me.lblCiclo4 = New System.Windows.Forms.Label()
        Me.lblCiclo3 = New System.Windows.Forms.Label()
        Me.lblCiclo2 = New System.Windows.Forms.Label()
        Me.lblCiclo1 = New System.Windows.Forms.Label()
        Me.dgv5 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dgv4 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dgv3 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dgv2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.chkOk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.gbCursos.SuspendLayout()
        CType(Me.dgv5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(330, 674)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(82, 40)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "          Asignar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.txtAlumno)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.txtCarrera)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(483, 62)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de datos"
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(437, 21)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(25, 26)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtAlumno
        '
        Me.txtAlumno.Enabled = False
        Me.txtAlumno.Location = New System.Drawing.Point(201, 25)
        Me.txtAlumno.Name = "txtAlumno"
        Me.txtAlumno.Size = New System.Drawing.Size(230, 20)
        Me.txtAlumno.TabIndex = 1
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(252, 25)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(24, 20)
        Me.TextBox5.TabIndex = 1
        '
        'txtCarrera
        '
        Me.txtCarrera.Enabled = False
        Me.txtCarrera.Location = New System.Drawing.Point(53, 25)
        Me.txtCarrera.Name = "txtCarrera"
        Me.txtCarrera.Size = New System.Drawing.Size(68, 20)
        Me.txtCarrera.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(152, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Alumno:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Carnet:"
        '
        'gbCursos
        '
        Me.gbCursos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbCursos.Controls.Add(Me.lblCiclo5)
        Me.gbCursos.Controls.Add(Me.lblCiclo4)
        Me.gbCursos.Controls.Add(Me.lblCiclo3)
        Me.gbCursos.Controls.Add(Me.lblCiclo2)
        Me.gbCursos.Controls.Add(Me.lblCiclo1)
        Me.gbCursos.Controls.Add(Me.dgv5)
        Me.gbCursos.Controls.Add(Me.dgv4)
        Me.gbCursos.Controls.Add(Me.dgv3)
        Me.gbCursos.Controls.Add(Me.dgv2)
        Me.gbCursos.Controls.Add(Me.dgv1)
        Me.gbCursos.Location = New System.Drawing.Point(10, 3)
        Me.gbCursos.Name = "gbCursos"
        Me.gbCursos.Size = New System.Drawing.Size(477, 742)
        Me.gbCursos.TabIndex = 8
        Me.gbCursos.TabStop = False
        Me.gbCursos.Text = "Cursos Disponibles"
        '
        'lblCiclo5
        '
        Me.lblCiclo5.AutoSize = True
        Me.lblCiclo5.Location = New System.Drawing.Point(15, 588)
        Me.lblCiclo5.Name = "lblCiclo5"
        Me.lblCiclo5.Size = New System.Drawing.Size(83, 13)
        Me.lblCiclo5.TabIndex = 1
        Me.lblCiclo5.Text = "10mo. Semestre"
        '
        'lblCiclo4
        '
        Me.lblCiclo4.AutoSize = True
        Me.lblCiclo4.Location = New System.Drawing.Point(15, 445)
        Me.lblCiclo4.Name = "lblCiclo4"
        Me.lblCiclo4.Size = New System.Drawing.Size(75, 13)
        Me.lblCiclo4.TabIndex = 1
        Me.lblCiclo4.Text = "8vo. Semestre"
        '
        'lblCiclo3
        '
        Me.lblCiclo3.AutoSize = True
        Me.lblCiclo3.Location = New System.Drawing.Point(15, 304)
        Me.lblCiclo3.Name = "lblCiclo3"
        Me.lblCiclo3.Size = New System.Drawing.Size(72, 13)
        Me.lblCiclo3.TabIndex = 1
        Me.lblCiclo3.Text = "6to. Semestre"
        '
        'lblCiclo2
        '
        Me.lblCiclo2.AutoSize = True
        Me.lblCiclo2.Location = New System.Drawing.Point(15, 160)
        Me.lblCiclo2.Name = "lblCiclo2"
        Me.lblCiclo2.Size = New System.Drawing.Size(72, 13)
        Me.lblCiclo2.TabIndex = 1
        Me.lblCiclo2.Text = "4to. Semestre"
        '
        'lblCiclo1
        '
        Me.lblCiclo1.AutoSize = True
        Me.lblCiclo1.Location = New System.Drawing.Point(15, 16)
        Me.lblCiclo1.Name = "lblCiclo1"
        Me.lblCiclo1.Size = New System.Drawing.Size(75, 13)
        Me.lblCiclo1.TabIndex = 1
        Me.lblCiclo1.Text = "2do. Semestre"
        '
        'dgv5
        '
        Me.dgv5.AllowUserToAddRows = False
        Me.dgv5.AllowUserToDeleteRows = False
        Me.dgv5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv5.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn4})
        Me.dgv5.Location = New System.Drawing.Point(18, 604)
        Me.dgv5.Name = "dgv5"
        Me.dgv5.Size = New System.Drawing.Size(444, 121)
        Me.dgv5.TabIndex = 0
        '
        'DataGridViewCheckBoxColumn4
        '
        Me.DataGridViewCheckBoxColumn4.HeaderText = ""
        Me.DataGridViewCheckBoxColumn4.Name = "DataGridViewCheckBoxColumn4"
        Me.DataGridViewCheckBoxColumn4.ReadOnly = True
        '
        'dgv4
        '
        Me.dgv4.AllowUserToAddRows = False
        Me.dgv4.AllowUserToDeleteRows = False
        Me.dgv4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn3})
        Me.dgv4.Location = New System.Drawing.Point(18, 461)
        Me.dgv4.Name = "dgv4"
        Me.dgv4.Size = New System.Drawing.Size(444, 121)
        Me.dgv4.TabIndex = 0
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.HeaderText = ""
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        Me.DataGridViewCheckBoxColumn3.ReadOnly = True
        '
        'dgv3
        '
        Me.dgv3.AllowUserToAddRows = False
        Me.dgv3.AllowUserToDeleteRows = False
        Me.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn2})
        Me.dgv3.Location = New System.Drawing.Point(18, 320)
        Me.dgv3.Name = "dgv3"
        Me.dgv3.Size = New System.Drawing.Size(444, 121)
        Me.dgv3.TabIndex = 0
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.HeaderText = ""
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.ReadOnly = True
        '
        'dgv2
        '
        Me.dgv2.AllowUserToAddRows = False
        Me.dgv2.AllowUserToDeleteRows = False
        Me.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1})
        Me.dgv2.Location = New System.Drawing.Point(18, 176)
        Me.dgv2.Name = "dgv2"
        Me.dgv2.Size = New System.Drawing.Size(444, 121)
        Me.dgv2.TabIndex = 0
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = ""
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chkOk})
        Me.dgv1.Location = New System.Drawing.Point(18, 32)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(444, 121)
        Me.dgv1.TabIndex = 0
        '
        'chkOk
        '
        Me.chkOk.HeaderText = ""
        Me.chkOk.Name = "chkOk"
        Me.chkOk.ReadOnly = True
        '
        'Button7
        '
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(418, 674)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(90, 40)
        Me.Button7.TabIndex = 5
        Me.Button7.Text = "          Generar"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.gbCursos)
        Me.Panel1.Location = New System.Drawing.Point(12, 80)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(514, 573)
        Me.Panel1.TabIndex = 2
        '
        'TrsAsignacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 726)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TrsAsignacion"
        Me.Text = "Asignacion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbCursos.ResumeLayout(False)
        Me.gbCursos.PerformLayout()
        CType(Me.dgv5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAlumno As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents txtCarrera As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbCursos As System.Windows.Forms.GroupBox
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents chkOk As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents lblCiclo1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblCiclo5 As System.Windows.Forms.Label
    Friend WithEvents lblCiclo4 As System.Windows.Forms.Label
    Friend WithEvents lblCiclo3 As System.Windows.Forms.Label
    Friend WithEvents lblCiclo2 As System.Windows.Forms.Label
    Friend WithEvents dgv5 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn4 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents dgv4 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents dgv3 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents dgv2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
