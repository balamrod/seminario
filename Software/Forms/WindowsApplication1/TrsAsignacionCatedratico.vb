Imports WindowsApplication1.clsABC
Imports WindowsApplication1.clsHelperSQL
Imports WindowsApplication1.clsHelper
Imports WindowsApplication1.clsGlobales

Public Class TrsAsignacionCatedratico

#Region "variables"
    Dim IngresaraCombo As Boolean = False
    Dim VectorTxt(4) As TextBox
    Dim iId As String
    Dim temp As String
#End Region

    Private Sub llenarDatosAsignacion()
        Dim DsComboCategratico As DataSet = ExecuteQuery("select id_empleado as id,concat(nombres, ' ', apellidos) as nombre from empleado")
        FillComboBox(cbCatedratico, DsComboCategratico, "id", "nombre")

        Dim DsSalon As DataSet = ExecuteQuery("select id_salon as id, nombre as nombre from salon")
        FillComboBox(cbSalon, DsSalon, "id", "nombre")

        Dim DsHorario As DataSet = ExecuteQuery("select id_horario as id,concat(hora_inicial, ' - ', hora_final) as nombre from horario")
        FillComboBox(cbHorario, DsHorario, "id", "nombre")
    End Sub

    Private Sub llenarSeccion()

        If cbCiclo.Text <> "" And cbAnio.Text <> "" And cbCiclo.Text <> "No Datos" And cbAnio.Text <> "No Datos" Then
            VaciarCombos(cbSeccion)
            Dim DsSeccion As DataSet = ExecuteQuery("select id_seccion as id, nombre from seccion where catedra_id_catedra = '" & cbCatedra.SelectedValue & "' and anio = " & cbAnio.Text & " and ciclo_anual = '" & cbCiclo.Text & "'")
            FillComboBox(cbSeccion, DsSeccion, "id", "nombre")


            If cbSeccion.Text <> "" And cbSeccion.Text <> "No Datos" Then
                cbSeccion.Enabled = True
                pnlBotones.Visible = True
                actualizarGrid()
            Else
                VaciarCombos(cbSeccion)
                cbSeccion.Items.Add("No Datos")
                cbSeccion.SelectedIndex = 0
                pnlBotones.Visible = False
                cbSeccion.Enabled = False
            End If

        Else
            cbSeccion.Enabled = False
            pnlBotones.Visible = False
        End If
        
    End Sub

    Private Sub llenarAnioSeccion()
        VaciarCombos(cbAnio)

        If cbCatedra.Text <> "" And cbCatedra.Text <> "No Datos" Then
            Try
                Dim DsAnio As DataSet = ExecuteQuery("select id_seccion as id , anio from seccion where catedra_id_catedra = '" & cbCatedra.SelectedValue & "' group by anio ")
                FillComboBox(cbAnio, DsAnio, "id", "anio")
            Catch ex As Exception

            End Try
           
        Else
            cbAnio.Items.Add("No Datos")
            cbAnio.SelectedIndex = 0
        End If

        llenarSeccion()

    End Sub

    Private Sub llenarCicloSeccion()
        VaciarCombos(cbCiclo)

        If cbCatedra.Text <> "" And cbCatedra.Text <> "No Datos" Then
            Dim DsCiclo As DataSet = ExecuteQuery("select ciclo_anual from seccion where catedra_id_catedra = '" & cbCatedra.SelectedValue & "'  group by anio ")
            FillComboBox(cbCiclo, DsCiclo, "ciclo_anual", "ciclo_anual")
        Else
            cbCiclo.Items.Add("No Datos")
            cbCiclo.SelectedIndex = 0
        End If

        llenarSeccion()

    End Sub

    Private Sub llenarCatedra()
        VaciarCombos(cbCatedra)
        

        If cbPensum.Text <> "" And cbJornada.Text <> "" And cbPensum.Text <> "No Datos" And cbJornada.Text <> "No Datos" Then
            Dim DsCatedra As DataSet = ExecuteQuery("select id_catedra as id, concat(cic.nombre,' - ',c.nombre) as nombre from catedra c inner join detalle_catedra s on s.catedra_id_catedra = c.id_catedra" +
                                                         " inner join ciclo cic on s.ciclo_id_ciclo = cic.id_ciclo where pensum_id_pensum = '" & cbPensum.SelectedValue & "' order by cic.nombre")
            FillComboBox(cbCatedra, DsCatedra, "id", "nombre")
            If cbCatedra.Text <> "" And cbCatedra.Text <> "No Datos" Then
                'pnlBotones.Visible = True

            Else
                VaciarCombos(cbCatedra)
                cbCatedra.Items.Add("No Datos")
                cbCatedra.SelectedIndex = 0
                'pnlBotones.Visible = False
            End If
        Else
            cbCatedra.Items.Add("No Datos")
            cbCatedra.SelectedIndex = 0
        End If

        'llenarAnioSeccion()
        'llenarCicloSeccion()
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

    Private Sub TrsAsignacionCatedratico_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        llenarCarrera()
        llenarDatosAsignacion()

        IngresaraCombo = True
        cbAnio.SelectedText = Year(Now)
        cbCiclo.SelectedIndex = 1

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

    Private Sub cbCatedra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCatedra.SelectedIndexChanged
        If IngresaraCombo Then
            ' llenarAnioSeccion()
            ' llenarCicloSeccion()
        End If
    End Sub

    Private Sub cbAnio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAnio.SelectedIndexChanged
        If IngresaraCombo Then
            'llenarSeccion()
        End If
    End Sub

    Private Sub cbCiclo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCiclo.SelectedIndexChanged
        If IngresaraCombo Then
            ' llenarSeccion()
        End If
    End Sub

    Public Sub VaciarCombos(cb As ComboBox)
        If IngresaraCombo Then
            cb.DataSource = Nothing
            cb.Items.Clear()
        End If
    End Sub

    Private Sub actualizarGrid()
        Dim sActualizarGrid As String = "select concat(emp.nombres,' ', emp.apellidos) as catedratico, sal.nombre as salon,s.nombre as seccion,concat(h.hora_inicial, ' - ', h.hora_final) as horario, id_asignacion_catedratico, empleado_id_empleado,salon_id_salon,horario_id_horario,seccion_id_seccion, s.anio  from empleado emp  " +
                                   "	inner join detalle_seccion ds on emp.id_empleado = ds.empleado_id_empleado " +
                                   "	inner join salon sal on sal.id_salon = ds.salon_id_salon " +
                                   "	inner join horario h on h.id_horario = ds.horario_id_horario " +
                                   "	inner join seccion s on s.id_seccion = ds.seccion_id_seccion " +
                                   "where s.catedra_id_catedra = '" + cbCatedra.SelectedValue + "' and s.ciclo_anual = '" + cbCiclo.Text + "' and s.anio  = '" + temp + "'" +
                                   "order by s.anio desc "

        FillDataGridView(dgvCatedras, ExecuteQuery(sActualizarGrid))
        dgvCatedras.Columns("id_asignacion_catedratico").Visible = False
        dgvCatedras.Columns("empleado_id_empleado").Visible = False
        dgvCatedras.Columns("salon_id_salon").Visible = False
        dgvCatedras.Columns("horario_id_horario").Visible = False
        dgvCatedras.Columns("seccion_id_seccion").Visible = False
    End Sub

    Private Sub LlenarTextBox(incluirID As Boolean)
        VectorTxt(0) = New TextBox
        VectorTxt(0).Tag = "empleado_id_empleado"
        VectorTxt(0).Text = cbCatedratico.SelectedValue()
        VectorTxt(1) = New TextBox
        VectorTxt(1).Tag = "salon_id_salon"
        VectorTxt(1).Text = cbSalon.SelectedValue()
        VectorTxt(2) = New TextBox
        VectorTxt(2).Tag = "horario_id_horario"
        VectorTxt(2).Text = cbHorario.SelectedValue()
        VectorTxt(3) = New TextBox
        VectorTxt(3).Tag = "seccion_id_seccion"
        VectorTxt(3).Text = cbSeccion.SelectedValue()
        VectorTxt(4) = New TextBox
        VectorTxt(4).Tag = "id_asignacion_catedratico"
        If incluirID Then
            VectorTxt(4).Text = Guid.NewGuid.ToString()
        Else
            VectorTxt(4).Text = iId
        End If
    End Sub

    Private Sub btnAniadir_Click(sender As Object, e As EventArgs) Handles btnAniadir.Click
       
        LlenarTextBox(True)
        Dim sError As String = SaveData("detalle_seccion", VectorTxt)
        If (sError = "") Then
            actualizarGrid()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim sError As String = DeleteData("detalle_seccion", "id_asignacion_catedratico = '" & iId & "'")
        If (sError = "") Then
            actualizarGrid()
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        LlenarTextBox(False)
        Dim sError As String = UpdateData("detalle_seccion", VectorTxt, "id_asignacion_catedratico = '" & iId & "'")
        If (sError = "") Then
            actualizarGrid()
        End If
    End Sub

    Private Sub dgvCatedras_SelectionChanged(sender As Object, e As EventArgs) Handles dgvCatedras.SelectionChanged
        iId = GetItem(dgvCatedras, "id_asignacion_catedratico")

        cbHorario.SelectedValue = GetItem(dgvCatedras, "horario_id_horario")
        cbSeccion.SelectedValue = GetItem(dgvCatedras, "seccion_id_seccion")
        cbSalon.SelectedValue = GetItem(dgvCatedras, "salon_id_salon")
        cbCatedratico.SelectedValue = GetItem(dgvCatedras, "empleado_id_empleado")
    End Sub
    
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        temp = cbAnio.Text
        llenarSeccion()
    End Sub
End Class