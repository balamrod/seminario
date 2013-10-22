Imports WindowsApplication1.clsGlobales
Imports WindowsApplication1.clsHelper
Imports WindowsApplication1.clsHelperSQL
Imports WindowsApplication1.clsABC

Public Class MstPensum

#Region "variables"
    Dim iId As String
    Dim VectorTxt(3) As TextBox
    ''Dim sActualizarGrid As String = "select * from pensum"
#End Region

    Private Sub LlenarTextBox(incluirID As Boolean)
        VectorTxt(0) = txtAnio
        VectorTxt(1) = txtDescripcion

        VectorTxt(2) = New TextBox
        VectorTxt(2).Tag = "id_pensum" ''nombre bd
        If incluirID Then
            VectorTxt(2).Text = Guid.NewGuid.ToString
        Else
            VectorTxt(2).Text = iId
        End If

        VectorTxt(3) = New TextBox
        VectorTxt(3).Tag = "carrera_id_carrera"
        VectorTxt(3).Text = cbxCarrera.SelectedValue()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub MstPensum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DsComboSucursal As DataSet = ExecuteQuery("select id_carrera as id, nombre from carrera")
        FillComboBox(cbxCarrera, DsComboSucursal, "id", "nombre")
        FillDataGridView(dgvPensum, ExecuteQuery("Select * from pensum"))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        LlenarTextBox(True)
        Dim sError As String = SaveData("pensum", VectorTxt)
        If (sError = "") Then
            FillDataGridView(dgvPensum, ExecuteQuery("Select * from pensum"))
            LimpiarTxtBox(Me)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim sError As String = DeleteData("pensum", "id_pensum = '" & iId & "'")
        If (sError = "") Then
            FillDataGridView(dgvPensum, ExecuteQuery("Select * from pensum"))
            LimpiarTxtBox(Me)
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        LlenarTextBox(False)
        Dim sError As String = UpdateData("pensum", VectorTxt, "id_pensum = '" & iId & "'")
        If (sError = "") Then
            FillDataGridView(dgvPensum, ExecuteQuery("Select * from pensum"))
            LimpiarTxtBox(Me)
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarTxtBox(Me)
    End Sub

    Private Sub dgvPensum_SelectionChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgvPensum_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPensum.CellContentClick

    End Sub

    Private Sub dgvPensum_SelectionChanged1(sender As Object, e As EventArgs) Handles dgvPensum.SelectionChanged
        iId = GetItem(dgvPensum, "id_pensum")
        txtAnio.Text = GetItem(dgvPensum, "anio")
        txtDescripcion.Text = GetItem(dgvPensum, "descripcion")
        cbxCarrera.SelectedValue = GetItem(dgvPensum, "carrera_id_carrera")
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class