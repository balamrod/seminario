Imports WindowsApplication1.clsABC
Imports WindowsApplication1.clsHelperSQL
Imports WindowsApplication1.clsHelper
Imports WindowsApplication1.clsGlobales


Public Class mstHorario
#Region "variables"
    Dim VectorTxt(2) As TextBox
    Dim sActualizarGrid As String = "select id_horario as 'Id Horario', hora_inicial as 'Hora Inicial', hora_final as 'Hora Final' from horario"

    Dim iId As String
#End Region

    Private Sub LlenarTextBox(incluirID As Boolean)

        VectorTxt(0) = txtHoraInicial
        VectorTxt(1) = txtHoraFinal
        VectorTxt(2) = New TextBox
        VectorTxt(2).Tag = "Id_Horario" ''nombre bd
        If incluirID Then
            VectorTxt(2).Text = Guid.NewGuid.ToString
        Else
            VectorTxt(2).Text = iId
        End If

    End Sub
    Sub tip()
        ToolTip1.SetToolTip(btnAniadir, "GUARDAR")
        ToolTip2.SetToolTip(btnEliminar, "ELIMINAR")
        ToolTip3.SetToolTip(btnModificar, "MODIFICAR")
        ToolTip4.SetToolTip(btnLimpiar, "LIMPIAR")
    End Sub
    Private Sub mstHorario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDataGridView(dgvHorario, ExecuteQuery(sActualizarGrid))
        dgvHorario.Columns("Id Horario").Visible = False
        tip()
        LimpiarTxtBox(Me)

    End Sub


    Private Sub btnAniadir_Click(sender As Object, e As EventArgs) Handles btnAniadir.Click
        LlenarTextBox(True)
        Dim sError As String = SaveData("horario", VectorTxt)
        If (sError = "") Then
            FillDataGridView(dgvHorario, ExecuteQuery("select id_horario as 'Id Horario', hora_inicial as 'Hora Inicial', hora_final as 'Hora Final' from horario"))
            LimpiarTxtBox(Me)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim sError As String = DeleteData("horario", "Id_horario= '" & iId & "'")
        If (sError = "") Then
            FillDataGridView(dgvHorario, ExecuteQuery("select id_horario as 'Id Horario', hora_inicial as 'Hora Inicial', hora_final as 'Hora Final' from horario"))
            LimpiarTxtBox(Me)
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        LlenarTextBox(False)
        Dim sError As String = UpdateData("horario", VectorTxt, "id_horario = '" & iId & "'")
        If (sError = "") Then
            FillDataGridView(dgvHorario, ExecuteQuery("select id_horario as 'Id Horario', hora_inicial as 'Hora Inicial', hora_final as 'Hora Final' from horario"))
            LimpiarTxtBox(Me)
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarTxtBox(Me)
    End Sub

    Private Sub dgvHorario_SelectionChanged(sender As Object, e As EventArgs) Handles dgvHorario.SelectionChanged
        iId = GetItem(dgvHorario, "Id Horario")
        txtHoraInicial.Text = GetItem(dgvHorario, "Hora Inicial")
        txtHoraFinal.Text = GetItem(dgvHorario, "Hora Final") ''nombre de la bd
    End Sub
End Class