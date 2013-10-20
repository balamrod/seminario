Imports WindowsApplication1.clsABC
Imports WindowsApplication1.clsHelperSQL
Imports WindowsApplication1.clsHelper
Imports WindowsApplication1.clsGlobales


Public Class mstHorario
#Region "variables"
    Dim VectorTxt(2) As TextBox
    Dim sActualizarGrid As String = "select * from horario"

    Dim iId As String
#End Region

    Private Sub LlenarTextBox()
        VectorTxt(0) = txtCodigo
        VectorTxt(1) = txtHoraInicial
        VectorTxt(2) = txtHoraFinal
        

    End Sub

    Private Sub mstHorario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDataGridView(dgvHorario, ExecuteQuery(sActualizarGrid))
        LimpiarTxtBox(Me)
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles LblIdHorario.Click

    End Sub

    Private Sub btnAniadir_Click(sender As Object, e As EventArgs) Handles btnAniadir.Click
        LlenarTextBox()
        Dim sError As String = SaveData("horario", VectorTxt)
        If (sError = "") Then
            FillDataGridView(dgvHorario, ExecuteQuery(sActualizarGrid))
            LimpiarTxtBox(Me)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim sError As String = DeleteData("horario", "id_horario = " & iId)
        If (sError = "") Then
            FillDataGridView(dgvHorario, ExecuteQuery(sActualizarGrid))
            LimpiarTxtBox(Me)
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

    End Sub

    Private Sub dgvCarrera_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHorario.CellContentClick

    End Sub

    Private Sub gbIngresoDatos_Enter(sender As Object, e As EventArgs) Handles gbIngresoDatos.Enter

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarTxtBox(Me)
    End Sub

    Private Sub dgvHorario_SelectionChanged(sender As Object, e As EventArgs) Handles dgvHorario.SelectionChanged
        iId = GetItem(dgvHorario, "id_horario")

        txtCodigo.Text = GetItem(dgvHorario, "id_horario")
        txtHoraInicial.Text = GetItem(dgvHorario, "hora_inicial")
        txtHoraFinal.Text = GetItem(dgvHorario, "hora_final") ''nombre de la bd
    End Sub
End Class