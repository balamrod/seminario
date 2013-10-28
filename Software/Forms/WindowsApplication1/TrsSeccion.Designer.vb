<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrsSeccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TrsSeccion))
        Me.dgvCatedras = New System.Windows.Forms.DataGridView()
        Me.bgBusquedaCatedra = New System.Windows.Forms.GroupBox()
        Me.cbJornada = New System.Windows.Forms.ComboBox()
        Me.cbCarrera = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbPensum = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbCatedra = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gbIngresoDatos = New System.Windows.Forms.GroupBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlBotones = New System.Windows.Forms.Panel()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAniadir = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.cbAnio = New System.Windows.Forms.ComboBox()
        Me.cbCiclo = New System.Windows.Forms.ComboBox()
        CType(Me.dgvCatedras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bgBusquedaCatedra.SuspendLayout()
        Me.gbIngresoDatos.SuspendLayout()
        Me.pnlBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvCatedras
        '
        Me.dgvCatedras.AllowUserToAddRows = False
        Me.dgvCatedras.AllowUserToDeleteRows = False
        Me.dgvCatedras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCatedras.Location = New System.Drawing.Point(12, 160)
        Me.dgvCatedras.Name = "dgvCatedras"
        Me.dgvCatedras.ReadOnly = True
        Me.dgvCatedras.Size = New System.Drawing.Size(554, 259)
        Me.dgvCatedras.TabIndex = 21
        '
        'bgBusquedaCatedra
        '
        Me.bgBusquedaCatedra.Controls.Add(Me.cbJornada)
        Me.bgBusquedaCatedra.Controls.Add(Me.cbCarrera)
        Me.bgBusquedaCatedra.Controls.Add(Me.Label9)
        Me.bgBusquedaCatedra.Controls.Add(Me.cbPensum)
        Me.bgBusquedaCatedra.Controls.Add(Me.Label4)
        Me.bgBusquedaCatedra.Controls.Add(Me.Label5)
        Me.bgBusquedaCatedra.Location = New System.Drawing.Point(12, 3)
        Me.bgBusquedaCatedra.Name = "bgBusquedaCatedra"
        Me.bgBusquedaCatedra.Size = New System.Drawing.Size(554, 52)
        Me.bgBusquedaCatedra.TabIndex = 19
        Me.bgBusquedaCatedra.TabStop = False
        Me.bgBusquedaCatedra.Text = "Busqueda cátedra"
        '
        'cbJornada
        '
        Me.cbJornada.FormattingEnabled = True
        Me.cbJornada.Location = New System.Drawing.Point(291, 19)
        Me.cbJornada.Name = "cbJornada"
        Me.cbJornada.Size = New System.Drawing.Size(99, 21)
        Me.cbJornada.TabIndex = 11
        '
        'cbCarrera
        '
        Me.cbCarrera.FormattingEnabled = True
        Me.cbCarrera.Location = New System.Drawing.Point(66, 19)
        Me.cbCarrera.Name = "cbCarrera"
        Me.cbCarrera.Size = New System.Drawing.Size(171, 21)
        Me.cbCarrera.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(237, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Jornada:"
        '
        'cbPensum
        '
        Me.cbPensum.FormattingEnabled = True
        Me.cbPensum.Location = New System.Drawing.Point(451, 19)
        Me.cbPensum.Name = "cbPensum"
        Me.cbPensum.Size = New System.Drawing.Size(92, 21)
        Me.cbPensum.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Carrera:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(393, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Pensum:"
        '
        'cbCatedra
        '
        Me.cbCatedra.FormattingEnabled = True
        Me.cbCatedra.Location = New System.Drawing.Point(76, 60)
        Me.cbCatedra.Name = "cbCatedra"
        Me.cbCatedra.Size = New System.Drawing.Size(161, 21)
        Me.cbCatedra.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Catedra:"
        '
        'gbIngresoDatos
        '
        Me.gbIngresoDatos.Controls.Add(Me.txtNombre)
        Me.gbIngresoDatos.Controls.Add(Me.Label7)
        Me.gbIngresoDatos.Controls.Add(Me.Label6)
        Me.gbIngresoDatos.Controls.Add(Me.Label3)
        Me.gbIngresoDatos.Controls.Add(Me.Label1)
        Me.gbIngresoDatos.Controls.Add(Me.pnlBotones)
        Me.gbIngresoDatos.Controls.Add(Me.cbAnio)
        Me.gbIngresoDatos.Controls.Add(Me.cbCiclo)
        Me.gbIngresoDatos.Controls.Add(Me.cbCatedra)
        Me.gbIngresoDatos.Controls.Add(Me.Label8)
        Me.gbIngresoDatos.Location = New System.Drawing.Point(12, 61)
        Me.gbIngresoDatos.Name = "gbIngresoDatos"
        Me.gbIngresoDatos.Size = New System.Drawing.Size(554, 93)
        Me.gbIngresoDatos.TabIndex = 20
        Me.gbIngresoDatos.TabStop = False
        Me.gbIngresoDatos.Text = "Creación de Sección"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(398, 61)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(43, 20)
        Me.txtNombre.TabIndex = 15
        Me.txtNombre.Tag = "nombre"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(146, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(243, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Año:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(343, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(441, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Ciclo:"
        '
        'pnlBotones
        '
        Me.pnlBotones.Controls.Add(Me.btnEliminar)
        Me.pnlBotones.Controls.Add(Me.btnAniadir)
        Me.pnlBotones.Controls.Add(Me.btnModificar)
        Me.pnlBotones.Location = New System.Drawing.Point(413, 13)
        Me.pnlBotones.Name = "pnlBotones"
        Me.pnlBotones.Size = New System.Drawing.Size(130, 42)
        Me.pnlBotones.TabIndex = 12
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(48, 3)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(36, 36)
        Me.btnEliminar.TabIndex = 8
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAniadir
        '
        Me.btnAniadir.Image = CType(resources.GetObject("btnAniadir.Image"), System.Drawing.Image)
        Me.btnAniadir.Location = New System.Drawing.Point(6, 3)
        Me.btnAniadir.Name = "btnAniadir"
        Me.btnAniadir.Size = New System.Drawing.Size(36, 36)
        Me.btnAniadir.TabIndex = 7
        Me.btnAniadir.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(90, 3)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(36, 36)
        Me.btnModificar.TabIndex = 9
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'cbAnio
        '
        Me.cbAnio.FormattingEnabled = True
        Me.cbAnio.Items.AddRange(New Object() {"2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014"})
        Me.cbAnio.Location = New System.Drawing.Point(270, 60)
        Me.cbAnio.Name = "cbAnio"
        Me.cbAnio.Size = New System.Drawing.Size(54, 21)
        Me.cbAnio.TabIndex = 11
        '
        'cbCiclo
        '
        Me.cbCiclo.FormattingEnabled = True
        Me.cbCiclo.Items.AddRange(New Object() {"1", "2"})
        Me.cbCiclo.Location = New System.Drawing.Point(480, 61)
        Me.cbCiclo.Name = "cbCiclo"
        Me.cbCiclo.Size = New System.Drawing.Size(63, 21)
        Me.cbCiclo.TabIndex = 11
        '
        'TrsSeccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 425)
        Me.Controls.Add(Me.dgvCatedras)
        Me.Controls.Add(Me.bgBusquedaCatedra)
        Me.Controls.Add(Me.gbIngresoDatos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TrsSeccion"
        Me.Text = "TrsSeccion"
        CType(Me.dgvCatedras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bgBusquedaCatedra.ResumeLayout(False)
        Me.bgBusquedaCatedra.PerformLayout()
        Me.gbIngresoDatos.ResumeLayout(False)
        Me.gbIngresoDatos.PerformLayout()
        Me.pnlBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvCatedras As System.Windows.Forms.DataGridView
    Friend WithEvents bgBusquedaCatedra As System.Windows.Forms.GroupBox
    Friend WithEvents cbJornada As System.Windows.Forms.ComboBox
    Friend WithEvents cbCarrera As System.Windows.Forms.ComboBox
    Friend WithEvents cbCatedra As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbPensum As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents gbIngresoDatos As System.Windows.Forms.GroupBox
    Friend WithEvents pnlBotones As System.Windows.Forms.Panel
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnAniadir As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbAnio As System.Windows.Forms.ComboBox
    Friend WithEvents cbCiclo As System.Windows.Forms.ComboBox
End Class
