Imports WindowsApplication1.clsGlobales
Imports WindowsApplication1.clsHelper
Imports WindowsApplication1.clsHelperSQL
Imports WindowsApplication1.clsABC

Public Class mstBusquedaAlumno

#Region "variables"
    Dim iId As String
    Dim VectorTxt(2) As TextBox
    Public anio As String
    Public carrera As String
    Public correlativo As String

#End Region
    Private Sub LlenarTextBox(incluirID As Boolean)
        VectorTxt(0) = txtNombre
        VectorTxt(1) = txtApellido

        VectorTxt(2) = New TextBox
        VectorTxt(2).Tag = "anio_carnet" ''nombre bd
        If incluirID Then
            VectorTxt(2).Text = Guid.NewGuid.ToString
        Else
            VectorTxt(2).Text = iId
        End If
    End Sub
    Sub tip()
        ToolTip1.SetToolTip(btnBuscar, "BUSCAR")
        ToolTip2.SetToolTip(btnLimpiar, "LIMPIAR")
        ToolTip3.SetToolTip(btnBus, "SELECCIONAR")
    End Sub
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarTxtBox(Me)
    End Sub
    Private Sub mstBusquedaAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        LimpiarTxtBox(Me)
        tip()
    End Sub
    Private Sub dgvAlumno_SelectionChanged(sender As Object, e As EventArgs) Handles dgvAlumno.SelectionChanged
        anio = GetItem(dgvAlumno, "anio_carnet")
        carrera = GetItem(dgvAlumno, "id_carrera")
        correlativo = GetItem(dgvAlumno, "correlativo_carnet")

    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        FillDataGridView(dgvAlumno, ExecuteQuery("select id_carrera, anio_carnet, correlativo_carnet, nombres, apellidos from alumno where nombres like '%" + txtNombre.Text + "%' and apellidos like '%" + txtApellido.Text + "%'"))
        LimpiarTxtBox(Me)
    End Sub

    Private Sub dgvAlumno_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAlumno.CellContentClick

    End Sub

    Private Sub btnBus_Click(sender As Object, e As EventArgs) Handles btnBus.Click
        Me.Close()
    End Sub
End Class