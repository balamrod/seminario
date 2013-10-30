<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mstBusquedaAlumno
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mstBusquedaAlumno))
        Me.dgvAlumno = New System.Windows.Forms.DataGridView()
        Me.gbIngresoDatos = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnBus = New System.Windows.Forms.Button()
        CType(Me.dgvAlumno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbIngresoDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvAlumno
        '
        Me.dgvAlumno.AllowUserToAddRows = False
        Me.dgvAlumno.AllowUserToDeleteRows = False
        Me.dgvAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlumno.Location = New System.Drawing.Point(12, 165)
        Me.dgvAlumno.Name = "dgvAlumno"
        Me.dgvAlumno.ReadOnly = True
        Me.dgvAlumno.Size = New System.Drawing.Size(503, 83)
        Me.dgvAlumno.TabIndex = 12
        '
        'gbIngresoDatos
        '
        Me.gbIngresoDatos.Controls.Add(Me.btnBuscar)
        Me.gbIngresoDatos.Controls.Add(Me.btnLimpiar)
        Me.gbIngresoDatos.Controls.Add(Me.txtApellido)
        Me.gbIngresoDatos.Controls.Add(Me.txtNombre)
        Me.gbIngresoDatos.Controls.Add(Me.Label3)
        Me.gbIngresoDatos.Controls.Add(Me.Label1)
        Me.gbIngresoDatos.Location = New System.Drawing.Point(12, 5)
        Me.gbIngresoDatos.Name = "gbIngresoDatos"
        Me.gbIngresoDatos.Size = New System.Drawing.Size(503, 145)
        Me.gbIngresoDatos.TabIndex = 11
        Me.gbIngresoDatos.TabStop = False
        Me.gbIngresoDatos.Text = "Ingreso de datos"
        '
        'btnBuscar
        '
        Me.btnBuscar.AccessibleDescription = ""
        Me.btnBuscar.AccessibleName = "Buscar"
        Me.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(442, 15)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(52, 45)
        Me.btnBuscar.TabIndex = 8
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimpiar.Location = New System.Drawing.Point(21, 19)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(44, 41)
        Me.btnLimpiar.TabIndex = 7
        Me.btnLimpiar.Text = "          "
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(177, 103)
        Me.txtApellido.MaxLength = 50
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(219, 20)
        Me.txtApellido.TabIndex = 4
        Me.txtApellido.Tag = "apellidos"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(177, 74)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(219, 20)
        Me.txtNombre.TabIndex = 2
        Me.txtNombre.Tag = "nombres"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(109, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Apellidos:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(109, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombres:"
        '
        'btnBus
        '
        Me.btnBus.Image = Global.WindowsApplication1.My.Resources.Resources.Ok_icon
        Me.btnBus.Location = New System.Drawing.Point(461, 254)
        Me.btnBus.Name = "btnBus"
        Me.btnBus.Size = New System.Drawing.Size(54, 51)
        Me.btnBus.TabIndex = 13
        Me.btnBus.UseVisualStyleBackColor = True
        '
        'mstBusquedaAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 309)
        Me.Controls.Add(Me.btnBus)
        Me.Controls.Add(Me.dgvAlumno)
        Me.Controls.Add(Me.gbIngresoDatos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mstBusquedaAlumno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda Alumno"
        CType(Me.dgvAlumno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbIngresoDatos.ResumeLayout(False)
        Me.gbIngresoDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvAlumno As System.Windows.Forms.DataGridView
    Friend WithEvents gbIngresoDatos As System.Windows.Forms.GroupBox
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents btnBus As System.Windows.Forms.Button
    Friend WithEvents ToolTip3 As System.Windows.Forms.ToolTip
End Class
