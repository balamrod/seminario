Imports WindowsApplication1.clsGlobales
Imports WindowsApplication1.clsHelper
Imports WindowsApplication1.clsHelperSQL
Imports WindowsApplication1.clsABC
Public Class MstSeccion

#Region "variables"
    Dim iId As String
    Dim VectorTxt(5) As TextBox
    Dim ActualizarGrid As String = "select s.nombre as 'Nombre', s.anio as 'Anio', s.id_seccion as 'Id Seccion', s.ciclo_anual as 'Ciclo Anual', s.catedra_id_catedra as 'Id Catedra', s.ciclo_id_ciclo as 'Id Ciclo', c.nombre as 'Nombre Carrera', ci.nombre as 'Ciclo Carrera' from seccion as s, catedra as c, ciclo as ci where s.catedra_id_catedra=c.id_catedra and s.ciclo_id_ciclo=ci.id_ciclo"
#End Region

    Private Sub LlenarTextBox(incluirID As Boolean)
        VectorTxt(0) = txtNombre
        VectorTxt(1) = txtAnio
        VectorTxt(2) = txtCicloAnual

        VectorTxt(3) = New TextBox
        VectorTxt(3).Tag = "id_seccion" ''nombre bd
        If incluirID Then
            VectorTxt(3).Text = Guid.NewGuid.ToString
        Else
            VectorTxt(3).Text = iId
        End If

        VectorTxt(4) = New TextBox
        VectorTxt(4).Tag = "catedra_id_catedra"
        VectorTxt(4).Text = cbxCatedra.SelectedValue()

        VectorTxt(5) = New TextBox
        VectorTxt(5).Tag = "ciclo_id_ciclo"
        VectorTxt(5).Text = cbxCiclo.SelectedValue()
     


    End Sub

    Private Sub btnAniadir_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        LlenarTextBox(True)
        Dim sError As String = SaveData("seccion", VectorTxt)
        If (sError = "") Then
            FillDataGridView(dgvSeccion, ExecuteQuery(ActualizarGrid))
            LimpiarTxtBox(Me)
        End If
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim sError As String = DeleteData("seccion", "id_seccion = '" & iId & "'")
        If (sError = "") Then
            FillDataGridView(dgvSeccion, ExecuteQuery(ActualizarGrid))
            LimpiarTxtBox(Me)
        End If
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        LlenarTextBox(False)
        Dim sError As String = UpdateData("seccion", VectorTxt, "id_seccion = '" & iId & "'")
        If (sError = "") Then
            FillDataGridView(dgvSeccion, ExecuteQuery(ActualizarGrid))
            LimpiarTxtBox(Me)
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarTxtBox(Me)
    End Sub
    Sub tip()
        ToolTip1.SetToolTip(btnAgregar, "GUARDAR")
        ToolTip2.SetToolTip(btnEliminar, "BORRAR")
        ToolTip3.SetToolTip(btnModificar, "MODIFICAR")
        ToolTip4.SetToolTip(btnLimpiar, "LIMPIAR")

    End Sub
    Private Sub MstSeccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DsComboSucursal As DataSet = ExecuteQuery("select id_catedra as id, nombre from catedra")
        FillComboBox(cbxCatedra, DsComboSucursal, "id", "nombre")
        tip()
        Dim DsComboSucursal1 As DataSet = ExecuteQuery("select id_ciclo as id, nombre from ciclo")
        FillComboBox(cbxCiclo, DsComboSucursal1, "id", "nombre")
        FillDataGridView(dgvSeccion, ExecuteQuery(ActualizarGrid))
        dgvSeccion.Columns("Id Seccion").Visible = False
        dgvSeccion.Columns("Id Catedra").Visible = False
        dgvSeccion.Columns("Id Ciclo").Visible = False
    End Sub


    Private Sub dgvSeccion_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSeccion.SelectionChanged
        iId = GetItem(dgvSeccion, "id_seccion")
        txtNombre.Text = GetItem(dgvSeccion, "Nombre")
        txtAnio.Text = GetItem(dgvSeccion, "Anio")
        txtCicloAnual.Text = GetItem(dgvSeccion, "Ciclo Anual")
        cbxCatedra.SelectedValue = GetItem(dgvSeccion, "Id Catedra")
        cbxCiclo.SelectedValue = GetItem(dgvSeccion, "Id Ciclo")
    End Sub

    
End Class