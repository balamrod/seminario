Imports WindowsApplication1.clsABC
Imports WindowsApplication1.clsHelperSQL
Imports WindowsApplication1.clsHelper
Imports WindowsApplication1.clsGlobales

Public Class TrsInscripcion

#Region "variables"
    Dim VectorTxt(8) As TextBox
    Dim iId As String
    Dim sActualizarGrid As String
    Dim DsAlumno As DataSet
    Dim ins As String
    Dim anio As String
#End Region

    Private Sub LlenarTextBox()
        VectorTxt(0) = txtCodAnio
        VectorTxt(1) = txtCodCarrera
        VectorTxt(2) = txtCorrelativo
        VectorTxt(3) = txtFecha
        VectorTxt(4) = txtContrato
        VectorTxt(5) = New TextBox
        VectorTxt(5).Tag = "ciclo_escolar"
        VectorTxt(5).Text = cbCiclo.Text
        VectorTxt(6) = txtMatricula
        VectorTxt(7) = txtDescripcion
        VectorTxt(8) = New TextBox
        VectorTxt(8).Tag = "id_inscripcion"
        VectorTxt(8).Text = Guid.NewGuid().ToString
    End Sub

    Private Function verificarDuplicado() As Boolean
        Dim DsAlumnoDuplicado As DataSet = ExecuteQuery("select observaciones from inscripcion where anio_carnet = " & Convert.ToInt16(txtCodAnio.Text) & " and numero_carnet = " & txtCorrelativo.Text & " and id_carrera = " & txtCodCarrera.Text & " and ciclo_escolar = '" & cbCiclo.Text & "'")
        Dim existeAlumno As String = GetItem(DsAlumnoDuplicado, "observaciones")

        If existeAlumno = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Function obtenerAlumno() As String
        DsAlumno = ExecuteQuery("select concat (nombres,' ', apellidos) as nombre from alumno where anio_carnet = " & Convert.ToInt16(txtCodAnio.Text) & " and correlativo_carnet = " & txtCorrelativo.Text & " and id_carrera = " & txtCodCarrera.Text)
        Dim test As String = GetItem(DsAlumno, "nombre")

        If test = "" Then
            Return ""
        Else
            Return test
        End If
    End Function

    Private Sub txtCodAnio_LostFocus(sender As Object, e As EventArgs) Handles txtCodAnio.LostFocus, txtCodCarrera.LostFocus, txtCorrelativo.LostFocus
        If txtCodAnio.Text <> "" And txtCodCarrera.Text <> "" And txtCorrelativo.Text <> "" Then
            Dim nombre As String = obtenerAlumno()

            If nombre = "" Then
                lblError.Visible = True
                btnGuardar.Enabled = False
                btnAsignar.Enabled = False
                lblError.Text = "Alumno no encontrado, por favor intente nuevamente.  Puede buscarlo o crearlo"
            Else

                sActualizarGrid = "select concat(ciclo_escolar, ' - ', year(fecha)) as 'período',matricula,no_contrato_est as contrato, fecha as 'fecha creación', observaciones from inscripcion where anio_carnet = " & Convert.ToInt16(txtCodAnio.Text) & " and numero_carnet = " & txtCorrelativo.Text & " and id_carrera = " & txtCodCarrera.Text & " order by fecha desc"
                txtFecha.Text = FormatearFechaMysql(Now)
                txtNombre.Text = nombre
                txtMatricula.Text = Convert.ToInt16(txtCodCarrera.Text) & Convert.ToInt16(txtCodAnio.Text) & Convert.ToInt16(txtCorrelativo.Text) & cbCiclo.Text(0)
                txtContrato.Text = "U-" & Convert.ToInt16(txtCodCarrera.Text) & Convert.ToInt16(txtCodAnio.Text) & Convert.ToInt16(txtCorrelativo.Text) & cbCiclo.Text(0)
                lblError.Visible = False

                btnGuardar.Visible = True
                FillDataGridView(dvgHistorialInscripciones, ExecuteQuery(sActualizarGrid))
            End If
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Not verificarDuplicado() Then
            LlenarTextBox()
            Dim sError As String = SaveData("inscripcion", VectorTxt)
            If (sError = "") Then
                FillDataGridView(dvgHistorialInscripciones, ExecuteQuery(sActualizarGrid))
                LimpiarTxtBox(Me)
            End If
            ins = VectorTxt(8).Text
            anio = VectorTxt(3).Text
            btnGuardar.Visible = False
        Else
            lblError.Visible = True
            lblError.Text = "El Alumno ya se encuentra inscrito en este ciclo"
        End If
    End Sub

    Private Sub cbCiclo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCiclo.SelectedIndexChanged
        txtMatricula.Text = Convert.ToInt16(txtCodCarrera.Text) & Convert.ToInt16(txtCodAnio.Text) & Convert.ToInt16(txtCorrelativo.Text) & cbCiclo.Text(0)
        txtContrato.Text = "U-" & Convert.ToInt16(txtCodCarrera.Text) & Convert.ToInt16(txtCodAnio.Text) & Convert.ToInt16(txtCorrelativo.Text) & cbCiclo.Text(0)
        lblError.Visible = False
    End Sub

    Private Sub TrsInscripcion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbCiclo.SelectedIndex = 0
    End Sub

    Private Sub btnAsignar_Click(sender As Object, e As EventArgs) Handles btnAsignar.Click

        Using frm As New TrsAsignacion
            frm.inscripcion = ins
            frm.anio = Year(Now)
            frm.ShowDialog()
        End Using

    End Sub
    
End Class