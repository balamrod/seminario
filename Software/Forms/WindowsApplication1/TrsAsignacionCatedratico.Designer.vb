<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrsAsignacionCatedratico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TrsAsignacionCatedratico))
        Me.dgvCatedras = New System.Windows.Forms.DataGridView()
        Me.gbIngresoDatos = New System.Windows.Forms.GroupBox()
        Me.cbSeccion = New System.Windows.Forms.ComboBox()
        Me.cbSalon = New System.Windows.Forms.ComboBox()
        Me.cbHorario = New System.Windows.Forms.ComboBox()
        Me.cbCatedratico = New System.Windows.Forms.ComboBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAniadir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bgBusquedaCatedra = New System.Windows.Forms.GroupBox()
        Me.cbJornada = New System.Windows.Forms.ComboBox()
        Me.cbCarrera = New System.Windows.Forms.ComboBox()
        Me.cbCiclo = New System.Windows.Forms.ComboBox()
        Me.cbAnio = New System.Windows.Forms.ComboBox()
        Me.cbCatedra = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbPensum = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.dgvCatedras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbIngresoDatos.SuspendLayout()
        Me.bgBusquedaCatedra.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvCatedras
        '
        Me.dgvCatedras.AllowUserToAddRows = False
        Me.dgvCatedras.AllowUserToDeleteRows = False
        Me.dgvCatedras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCatedras.Location = New System.Drawing.Point(12, 215)
        Me.dgvCatedras.Name = "dgvCatedras"
        Me.dgvCatedras.ReadOnly = True
        Me.dgvCatedras.Size = New System.Drawing.Size(529, 204)
        Me.dgvCatedras.TabIndex = 18
        '
        'gbIngresoDatos
        '
        Me.gbIngresoDatos.Controls.Add(Me.cbSeccion)
        Me.gbIngresoDatos.Controls.Add(Me.cbSalon)
        Me.gbIngresoDatos.Controls.Add(Me.cbHorario)
        Me.gbIngresoDatos.Controls.Add(Me.cbCatedratico)
        Me.gbIngresoDatos.Controls.Add(Me.btnModificar)
        Me.gbIngresoDatos.Controls.Add(Me.btnEliminar)
        Me.gbIngresoDatos.Controls.Add(Me.btnAniadir)
        Me.gbIngresoDatos.Controls.Add(Me.Label2)
        Me.gbIngresoDatos.Controls.Add(Me.Label6)
        Me.gbIngresoDatos.Controls.Add(Me.Label3)
        Me.gbIngresoDatos.Controls.Add(Me.Label1)
        Me.gbIngresoDatos.Location = New System.Drawing.Point(12, 85)
        Me.gbIngresoDatos.Name = "gbIngresoDatos"
        Me.gbIngresoDatos.Size = New System.Drawing.Size(529, 124)
        Me.gbIngresoDatos.TabIndex = 17
        Me.gbIngresoDatos.TabStop = False
        Me.gbIngresoDatos.Text = "Asignacion de Catedratico para la Catedra "
        '
        'cbSeccion
        '
        Me.cbSeccion.FormattingEnabled = True
        Me.cbSeccion.Location = New System.Drawing.Point(73, 61)
        Me.cbSeccion.Name = "cbSeccion"
        Me.cbSeccion.Size = New System.Drawing.Size(68, 21)
        Me.cbSeccion.TabIndex = 11
        '
        'cbSalon
        '
        Me.cbSalon.FormattingEnabled = True
        Me.cbSalon.Location = New System.Drawing.Point(73, 88)
        Me.cbSalon.Name = "cbSalon"
        Me.cbSalon.Size = New System.Drawing.Size(137, 21)
        Me.cbSalon.TabIndex = 11
        '
        'cbHorario
        '
        Me.cbHorario.FormattingEnabled = True
        Me.cbHorario.Location = New System.Drawing.Point(263, 88)
        Me.cbHorario.Name = "cbHorario"
        Me.cbHorario.Size = New System.Drawing.Size(251, 21)
        Me.cbHorario.TabIndex = 10
        '
        'cbCatedratico
        '
        Me.cbCatedratico.FormattingEnabled = True
        Me.cbCatedratico.Location = New System.Drawing.Point(219, 61)
        Me.cbCatedratico.Name = "cbCatedratico"
        Me.cbCatedratico.Size = New System.Drawing.Size(295, 21)
        Me.cbCatedratico.TabIndex = 10
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
        'btnAniadir
        '
        Me.btnAniadir.Image = CType(resources.GetObject("btnAniadir.Image"), System.Drawing.Image)
        Me.btnAniadir.Location = New System.Drawing.Point(394, 19)
        Me.btnAniadir.Name = "btnAniadir"
        Me.btnAniadir.Size = New System.Drawing.Size(36, 36)
        Me.btnAniadir.TabIndex = 7
        Me.btnAniadir.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Sección:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(156, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Empleado:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(216, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Horario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Salon:"
        '
        'bgBusquedaCatedra
        '
        Me.bgBusquedaCatedra.Controls.Add(Me.cbJornada)
        Me.bgBusquedaCatedra.Controls.Add(Me.cbCarrera)
        Me.bgBusquedaCatedra.Controls.Add(Me.cbCiclo)
        Me.bgBusquedaCatedra.Controls.Add(Me.cbAnio)
        Me.bgBusquedaCatedra.Controls.Add(Me.cbCatedra)
        Me.bgBusquedaCatedra.Controls.Add(Me.Label9)
        Me.bgBusquedaCatedra.Controls.Add(Me.cbPensum)
        Me.bgBusquedaCatedra.Controls.Add(Me.Label10)
        Me.bgBusquedaCatedra.Controls.Add(Me.Label4)
        Me.bgBusquedaCatedra.Controls.Add(Me.Label7)
        Me.bgBusquedaCatedra.Controls.Add(Me.Label5)
        Me.bgBusquedaCatedra.Controls.Add(Me.Label8)
        Me.bgBusquedaCatedra.Location = New System.Drawing.Point(12, 3)
        Me.bgBusquedaCatedra.Name = "bgBusquedaCatedra"
        Me.bgBusquedaCatedra.Size = New System.Drawing.Size(529, 76)
        Me.bgBusquedaCatedra.TabIndex = 17
        Me.bgBusquedaCatedra.TabStop = False
        Me.bgBusquedaCatedra.Text = "Busqueda cátedra"
        '
        'cbJornada
        '
        Me.cbJornada.FormattingEnabled = True
        Me.cbJornada.Location = New System.Drawing.Point(263, 19)
        Me.cbJornada.Name = "cbJornada"
        Me.cbJornada.Size = New System.Drawing.Size(99, 21)
        Me.cbJornada.TabIndex = 11
        '
        'cbCarrera
        '
        Me.cbCarrera.FormattingEnabled = True
        Me.cbCarrera.Location = New System.Drawing.Point(66, 19)
        Me.cbCarrera.Name = "cbCarrera"
        Me.cbCarrera.Size = New System.Drawing.Size(137, 21)
        Me.cbCarrera.TabIndex = 11
        '
        'cbCiclo
        '
        Me.cbCiclo.FormattingEnabled = True
        Me.cbCiclo.Location = New System.Drawing.Point(422, 46)
        Me.cbCiclo.Name = "cbCiclo"
        Me.cbCiclo.Size = New System.Drawing.Size(92, 21)
        Me.cbCiclo.TabIndex = 11
        '
        'cbAnio
        '
        Me.cbAnio.FormattingEnabled = True
        Me.cbAnio.Location = New System.Drawing.Point(260, 46)
        Me.cbAnio.Name = "cbAnio"
        Me.cbAnio.Size = New System.Drawing.Size(102, 21)
        Me.cbAnio.TabIndex = 11
        '
        'cbCatedra
        '
        Me.cbCatedra.FormattingEnabled = True
        Me.cbCatedra.Location = New System.Drawing.Point(66, 46)
        Me.cbCatedra.Name = "cbCatedra"
        Me.cbCatedra.Size = New System.Drawing.Size(137, 21)
        Me.cbCatedra.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(209, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Jornada:"
        '
        'cbPensum
        '
        Me.cbPensum.FormattingEnabled = True
        Me.cbPensum.Location = New System.Drawing.Point(422, 19)
        Me.cbPensum.Name = "cbPensum"
        Me.cbPensum.Size = New System.Drawing.Size(92, 21)
        Me.cbPensum.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(368, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Ciclo:"
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(209, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Año:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(368, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Pensum:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Catedra:"
        '
        'TrsAsignacionCatedratico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 430)
        Me.Controls.Add(Me.dgvCatedras)
        Me.Controls.Add(Me.bgBusquedaCatedra)
        Me.Controls.Add(Me.gbIngresoDatos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TrsAsignacionCatedratico"
        Me.Text = "Asignacion Catedraticos"
        CType(Me.dgvCatedras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbIngresoDatos.ResumeLayout(False)
        Me.gbIngresoDatos.PerformLayout()
        Me.bgBusquedaCatedra.ResumeLayout(False)
        Me.bgBusquedaCatedra.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvCatedras As System.Windows.Forms.DataGridView
    Friend WithEvents gbIngresoDatos As System.Windows.Forms.GroupBox
    Friend WithEvents cbSeccion As System.Windows.Forms.ComboBox
    Friend WithEvents cbSalon As System.Windows.Forms.ComboBox
    Friend WithEvents cbHorario As System.Windows.Forms.ComboBox
    Friend WithEvents cbCatedratico As System.Windows.Forms.ComboBox
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnAniadir As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bgBusquedaCatedra As System.Windows.Forms.GroupBox
    Friend WithEvents cbJornada As System.Windows.Forms.ComboBox
    Friend WithEvents cbCarrera As System.Windows.Forms.ComboBox
    Friend WithEvents cbCatedra As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbPensum As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbAnio As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbCiclo As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
