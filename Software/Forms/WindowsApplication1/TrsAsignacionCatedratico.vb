Imports WindowsApplication1.clsABC
Imports WindowsApplication1.clsHelperSQL
Imports WindowsApplication1.clsHelper
Imports WindowsApplication1.clsGlobales

Public Class TrsAsignacionCatedratico
    Private Sub TrsAsignacionCatedratico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DsComboCarrera As DataSet = ExecuteQuery("select id_carrera as id, nombre from carrera")
        FillComboBox(cbCarrera, DsComboCarrera, "id", "nombre")

        Dim DsComboCategratico As DataSet = ExecuteQuery("select id_empleado as id,concat(nombres, ' ', apellidos) as nombre from empleado")
        FillComboBox(cbCatedratico, DsComboCategratico, "id", "nombre")

        Dim DsSalon As DataSet = ExecuteQuery("select id_salon as id, nombre as nombre from salon")
        FillComboBox(cbSalon, DsSalon, "id", "nombre")

        Dim DsHorario As DataSet = ExecuteQuery("select id_horario as id,concat(hora_inicial, ' - ', hora_final) as nombre from horario")
        FillComboBox(cbHorario, DsHorario, "id", "nombre")

        If cbCarrera.Text <> "" Then
            Dim DsComboJornada As DataSet = ExecuteQuery("select id_jornada as id, nombre from jornada where id_carrera = '" & cbCarrera.SelectedValue & "'")
            FillComboBox(cbJornada, DsComboJornada, "id", "nombre")

            Dim DsPensum As DataSet = ExecuteQuery("select id_pensum as id, descripcion from pensum where carrera_id_carrera = '" & cbCarrera.SelectedValue & "'")
            FillComboBox(cbPensum, DsPensum, "id", "descripcion")

            Dim DsCatedratico As DataSet = ExecuteQuery("select id_pensum as id, descripcion from pensum where carrera_id_carrera = '" & cbCarrera.SelectedValue & "'")
            FillComboBox(cbPensum, DsPensum, "id", "descripcion")

            If cbPensum.Text <> "" And cbJornada.Text <> "" Then
                Dim DsCatedra As DataSet = ExecuteQuery("select id_catedra as id, nombre from catedra where pensum_id_pensum = '" & cbPensum.SelectedValue & "'")
                FillComboBox(cbCatedra, DsCatedra, "id", "nombre")

                If cbCatedra.Text <> "" Then
                    gbIngresoDatos.Text = "Asignacion de Catedratico para la Cátedra:" + cbCatedra.Text

                    Dim DsAnio As DataSet = ExecuteQuery("select anio from seccion where catedra_id_catedra = '" & cbCatedra.SelectedValue & "'  group by anio ")
                    FillComboBox(cbAnio, DsAnio, "anio", "anio")

                    If cbAnio.Text <> "" Then
                        Dim DsCiclo As DataSet = ExecuteQuery("select ciclo_anual from seccion where catedra_id_catedra = '" & cbCatedra.SelectedValue & "'  group by ciclo_anual")
                        FillComboBox(cbCiclo, DsCiclo, "ciclo_anual", "ciclo_anual")

                        If cbAnio.Text <> "" Then
                            Dim DsSeccion As DataSet = ExecuteQuery("select id_seccion as id, nombre from seccion where catedra_id_catedra = '" & cbCatedra.SelectedValue & "' and anio = " & cbAnio.Text & " and ciclo_anual = '" & cbCiclo.Text & "'")
                            FillComboBox(cbSeccion, DsSeccion, "id", "nombre")
                        End If
                    End If

                End If
            End If
        End If
    End Sub

    Private Sub cbJornada_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbJornada.SelectedIndexChanged
       
    End Sub
End Class