Imports WindowsApplication1.clsABC
Imports WindowsApplication1.clsHelperSQL
Imports WindowsApplication1.clsHelper
Imports WindowsApplication1.clsGlobales

Public Class TrsSeccion
#Region "variables"
    Dim IngresaraCombo As Boolean = False
    Dim VectorTxt(5) As TextBox
    Dim iId As String
#End Region

   

    Private Sub llenarCatedra()
        VaciarCombos(cbCatedra)


        If cbPensum.Text <> "" And cbJornada.Text <> "" And cbPensum.Text <> "No Datos" And cbJornada.Text <> "No Datos" Then
            Dim DsCatedra As DataSet = ExecuteQuery("select id_catedra as id, concat(cic.nombre,' - ',c.nombre) as nombre from catedra c inner join detalle_catedra s on s.catedra_id_catedra = c.id_catedra" +
                                                         " inner join ciclo cic on s.ciclo_id_ciclo = cic.id_ciclo where pensum_id_pensum = '" & cbPensum.SelectedValue & "' order by cic.nombre")
            FillComboBox(cbCatedra, DsCatedra, "id", "nombre")


            If cbCatedra.Text <> "" And cbCatedra.Text <> "No Datos" Then
                pnlBotones.Visible = True
               
            Else
                VaciarCombos(cbCatedra)
                cbCatedra.Items.Add("No Datos")
                cbCatedra.SelectedIndex = 0
                pnlBotones.Visible = False
            End If
        Else
            cbCatedra.Items.Add("No Datos")
            cbCatedra.SelectedIndex = 0
            pnlBotones.Visible = False
        End If
    End Sub

    Private Sub llenarJornada()
        VaciarCombos(cbJornada)

        Dim DsComboJornada As DataSet = ExecuteQuery("select id_jornada as id, nombre from jornada where id_carrera = '" & cbCarrera.SelectedValue & "'")
        FillComboBox(cbJornada, DsComboJornada, "id", "nombre")

        If cbJornada.Text = "" Then
            VaciarCombos(cbJornada)
            cbJornada.Items.Add("No Datos")
            cbJornada.SelectedIndex = 0
        End If

        llenarCatedra()

    End Sub

    Private Sub llenarPensum()
        VaciarCombos(cbPensum)

        Dim DsPensum As DataSet = ExecuteQuery("select id_pensum as id, descripcion from pensum where carrera_id_carrera = '" & cbCarrera.SelectedValue & "'")
        FillComboBox(cbPensum, DsPensum, "id", "descripcion")

        If cbPensum.Text = "" Then
            VaciarCombos(cbPensum)
            cbPensum.Items.Add("No Datos")
            cbPensum.SelectedIndex = 0
        End If

        llenarCatedra()
    End Sub

    Private Sub llenarCarrera()
        Dim DsComboCarrera As DataSet = ExecuteQuery("select id_carrera as id, nombre from carrera")
        FillComboBox(cbCarrera, DsComboCarrera, "id", "nombre")

        If cbCarrera.Text <> "" Then
            llenarPensum()
            llenarJornada()
        End If
    End Sub
    Sub tip()
        ToolTip1.SetToolTip(btnAniadir, "GUARDAR")
        ToolTip2.SetToolTip(btnEliminar, "BORRAR")
        ToolTip3.SetToolTip(btnModificar, "MODIFICAR")


    End Sub
    Private Sub TrsAsignacionCatedratico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tip()
        cbAnio.SelectedText = Year(Now)
        llenarCarrera()
        IngresaraCombo = True
        actualizarGrid()
        LimpiarTxtBox(Me)


    End Sub

    Private Sub cbCarrera_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCarrera.SelectedIndexChanged
        If IngresaraCombo Then
            If cbCarrera.Text <> "" Then
                llenarPensum()
                llenarJornada()
            End If
        End If
    End Sub

    Private Sub cbJornada_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbJornada.SelectedIndexChanged
        If IngresaraCombo Then
            llenarCatedra()
        End If
    End Sub

    Private Sub cbPensum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPensum.SelectedIndexChanged
        If IngresaraCombo Then
            llenarCatedra()
        End If
    End Sub

    Public Sub VaciarCombos(cb As ComboBox)
        If IngresaraCombo Then
            cb.DataSource = Nothing
            cb.Items.Clear()
        End If
    End Sub

    Private Sub actualizarGrid()
        Dim sActualizarGrid As String = "select id_seccion,catedra_id_catedra, cat.nombre as Catedra ,anio, s.nombre, ciclo_anual from seccion s inner join catedra cat on cat.id_catedra = s.catedra_id_catedra where s.catedra_id_catedra = '" + cbCatedra.SelectedValue + "' and s.anio = '" + cbAnio.Text + "'"
        'select s.nombre, c.nombre, cat.nombre from seccion s inner join catedra cat on s.catedra_id_catedra = cat.id_catedra 	inner join ciclo c on c.id_ciclo = s.ciclo_id_ciclo
        ' este query lo tengo que meter en el grid.
        FillDataGridView(dgvCatedras, ExecuteQuery(sActualizarGrid))
        dgvCatedras.Columns("catedra_id_catedra").Visible = False
        dgvCatedras.Columns("id_seccion").Visible = False
        dgvCatedras.ClearSelection()
    End Sub

    Private Sub LlenarTextBox(incluirID As Boolean)
        VectorTxt(0) = New TextBox
        VectorTxt(0).Tag = "anio"
        VectorTxt(0).Text = cbAnio.Text
        VectorTxt(1) = txtNombre
        VectorTxt(2) = New TextBox
        VectorTxt(2).Tag = "catedra_id_catedra"
        VectorTxt(2).Text = cbCatedra.SelectedValue()
        VectorTxt(3) = New TextBox
        VectorTxt(3).Tag = "ciclo_anual"
        VectorTxt(3).Text = cbCiclo.Text
        VectorTxt(4) = New TextBox
        VectorTxt(4).Tag = "id_seccion"
        If incluirID Then
            VectorTxt(4).Text = Guid.NewGuid.ToString()
        Else
            VectorTxt(4).Text = iId
        End If

        Dim sd As String = "select ciclo_id_ciclo from detalle_catedra where catedra_id_catedra =  '" + cbCatedra.SelectedValue + "'"


        Dim DsObtener As DataSet = ExecuteQuery(sd)
        VectorTxt(5) = New TextBox
        VectorTxt(5).Tag = "ciclo_id_ciclo"
        VectorTxt(5).Text = GetItem(DsObtener, "ciclo_id_ciclo")


    End Sub

    Private Sub btnAniadir_Click(sender As Object, e As EventArgs) Handles btnAniadir.Click

        LlenarTextBox(True)
        Dim sError As String = SaveData("seccion", VectorTxt)
        If (sError = "") Then
            actualizarGrid()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim sError As String = DeleteData("seccion", "id_seccion = '" & iId & "'")
        If (sError = "") Then
            actualizarGrid()
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        LlenarTextBox(False)
        Dim sError As String = UpdateData("seccion", VectorTxt, "id_seccion = '" & iId & "'")
        If (sError = "") Then
            actualizarGrid()
        End If
    End Sub

    Private Sub dgvCatedras_SelectionChanged(sender As Object, e As EventArgs) Handles dgvCatedras.SelectionChanged
        iId = GetItem(dgvCatedras, "id_seccion")

        If iId <> "" Then
            cbCatedra.SelectedValue = GetItem(dgvCatedras, "catedra_id_catedra")
            cbCiclo.Text = GetItem(dgvCatedras, "ciclo_anual")
            txtNombre.Text = GetItem(dgvCatedras, "nombre")
            cbAnio.Text = GetItem(dgvCatedras, "anio")
        End If
       
    End Sub

    Private Sub cbCatedra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCatedra.SelectedIndexChanged
        If IngresaraCombo Then
            actualizarGrid()
        End If
    End Sub

    Private Sub cbAnio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAnio.SelectedIndexChanged
        If IngresaraCombo Then
            actualizarGrid()
        End If
    End Sub
End Class