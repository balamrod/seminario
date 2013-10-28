Imports Maestros
Imports General
Imports Conexion
Imports System.Data
Imports Query
Imports Globales

Partial Class mstIngresoNotas
    Inherits System.Web.UI.Page

#Region "varibales"
    Dim sAnio As String = "select anio 	from seccion s inner join detalle_seccion ds on s.id_seccion = ds.seccion_id_seccion	inner join empleado emp on emp.id_empleado = ds.empleado_id_empleado	inner join asignacion asig on asig.id_asignacion_catedratico = ds.id_asignacion_catedratico where usuario_id_usuario = '" & idUsuario & "' group by anio"
    Shared idSeccion As String
    Dim sCadenaConexion As String = cadenaConexion
    Shared asignacion As String
    Shared inscripcion As String
#End Region

    Private Sub contruirGridview()
        Dim sSeccion As String = " select car.nombre as carrera, cat.nombre as catedra, s.nombre as 'sección' ,  asig.id_asignacion_catedratico as id " +
                                "from detalle_seccion  ds inner join empleado e  " +
                                        "on ds.empleado_id_empleado = e.id_empleado " +
                                    "inner join seccion s on s.id_seccion = ds.seccion_id_seccion " +
                                    "inner join detalle_catedra dc on dc.ciclo_id_ciclo = s.ciclo_id_ciclo " +
                                        "and dc.catedra_id_catedra = s.catedra_id_catedra " +
                                    "inner join catedra cat on cat.id_catedra = dc.catedra_id_catedra " +
                                    "inner join pensum p on p.id_pensum = cat.pensum_id_pensum " +
                                    "inner join carrera car on car.id_carrera = p.carrera_id_carrera " +
                                    "inner join asignacion asig on asig.id_asignacion_catedratico = ds.id_asignacion_catedratico " +
                                    "inner join ciclo c on c.id_ciclo = dc.ciclo_id_ciclo " +
                                    "inner join inscripcion ins on ins.id_inscripcion = asig.inscripcion_id_inscripcion " +
                                "where usuario_id_usuario = '" + idUsuario + "' " +
                                "and s.anio = " + ddlAnio.Text +
                                " group by car.nombre, cat.nombre, s.nombre ,  asig.id_asignacion_catedratico "

        Dim dView As DataView = FillDataGridView(sCadenaConexion, sSeccion, "alumno")
        gvSecciones.DataSource = dView
        gvSecciones.DataBind()
    End Sub

    Private Sub contruirNotas(idSeccion As String)
        If gvNotas.Columns.Count > 0 Then
            gvNotas.Columns.RemoveAt(0)
        End If

        Dim ButtonField As ButtonField = New ButtonField
        ButtonField.ButtonType = ButtonType.Button
        ButtonField.Text = "Actualizar Nota"
        ButtonField.CommandName = "testing"
        gvNotas.Columns.Add(ButtonField)


        Dim sNotas As String = "select al.nombres,asig.inscripcion_id_inscripcion, asig.id_asignacion_catedratico, " +
                                "	(select punteo from actividad act, tipo_actividad ta   where act.asignacion_id_asignacion_catedratico  = asig.id_asignacion_catedratico and act.asignacion_inscripcion_id_inscripcion = asig.inscripcion_id_inscripcion and ta.id_tipo_actividad = act.tipo_actividad_id_tipo_actividad and ta.nombre = '1') as '1er parcial', " +
                                    "(select punteo from actividad act, tipo_actividad ta   where act.asignacion_id_asignacion_catedratico  = asig.id_asignacion_catedratico and act.asignacion_inscripcion_id_inscripcion = asig.inscripcion_id_inscripcion and ta.id_tipo_actividad = act.tipo_actividad_id_tipo_actividad and ta.nombre = '2') as '2do parcial', " +
                                    "(select punteo from actividad act, tipo_actividad ta   where act.asignacion_id_asignacion_catedratico  = asig.id_asignacion_catedratico and act.asignacion_inscripcion_id_inscripcion = asig.inscripcion_id_inscripcion and ta.id_tipo_actividad = act.tipo_actividad_id_tipo_actividad and ta.nombre = '3') as 'Zona', " +
                                    "(select punteo from actividad act, tipo_actividad ta   where act.asignacion_id_asignacion_catedratico  = asig.id_asignacion_catedratico and act.asignacion_inscripcion_id_inscripcion = asig.inscripcion_id_inscripcion and ta.id_tipo_actividad = act.tipo_actividad_id_tipo_actividad and ta.nombre = '4') as 'Final', " +
                                    "asig.notafinal as 'Nota final' from asignacion asig " +
                                    "inner join inscripcion ins  on asig.inscripcion_id_inscripcion = ins.id_inscripcion " +
                                    "inner join alumno al on ins.anio_carnet = al.anio_carnet and ins.id_carrera = al.id_carrera " +
                                    "	and ins.numero_carnet = al.correlativo_carnet " +
                                    "inner join detalle_seccion ds on ds.id_asignacion_catedratico = asig.id_asignacion_catedratico " +
                                    "where ds.id_asignacion_catedratico = '" + idSeccion + "'"

        Dim dView As DataView = FillDataGridView(sCadenaConexion, sNotas, "alumno")
        gvNotas.DataSource = dView
        gvNotas.DataBind()

        Dim tamanio As Int16 = gvNotas.Columns.Count


    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Not Me.Page.IsPostBack Then
            'gvNotas.Columns(0).ItemStyle.Width = Unit.Pixel(100)
            Dim dsAnio As DataSet = ExecuteQuery(sAnio, sCadenaConexion)
            FillComboBox(ddlAnio, dsAnio, "anio", "anio")
            ddlAnio.DataBind()

            contruirGridview()
        End If
    End Sub

    Protected Sub gvSecciones_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles gvSecciones.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            e.Row.Cells(4).Visible = False
        End If

    End Sub

    Protected Sub gvSecciones_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvSecciones.SelectedIndexChanged
        Dim row As GridViewRow = gvSecciones.SelectedRow

        idSeccion = row.Cells(4).Text
        contruirNotas(idSeccion)
    End Sub

    Protected Sub gvNotas_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gvNotas.RowCommand
        If e.CommandName = "testing" Then
            txt4.Text = "0"
            txt3.Text = "0"
            txt2.Text = "0"
            txt1.Text = "0"
            Dim index As Integer = Convert.ToInt32(e.CommandArgument)
            Dim row As GridViewRow = gvNotas.Rows(index)

            inscripcion = row.Cells(2).Text
            asignacion = row.Cells(3).Text

            mpeUserDetail.Show()

        End If

    End Sub


    Protected Sub btnGuardar_Click1(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim Script As String
        Dim notaFinal As Int16 = Convert.ToInt16(txt1.Text) + Convert.ToInt16(txt2.Text) + Convert.ToInt16(txt3.Text) + Convert.ToInt16(txt4.Text)
        Dim sActualizarActividad As String = " update actividad set punteo = " + txt1.Text + " where asignacion_id_asignacion_catedratico = '" + asignacion + "' and asignacion_inscripcion_id_inscripcion = '" + inscripcion + "' and tipo_actividad_id_tipo_actividad = 'C7ED6B4A-380D-44A5-9972-7329EAE3AD24';" +
                                             " update actividad set punteo = " + txt2.Text + " where asignacion_id_asignacion_catedratico = '" + asignacion + "' and asignacion_inscripcion_id_inscripcion = '" + inscripcion + "' and tipo_actividad_id_tipo_actividad = 'DF77F9F8-51AF-43A0-83B0-AE171BC68137';" +
                                            " update actividad set punteo = " + txt3.Text + " where asignacion_id_asignacion_catedratico = '" + asignacion + "' and asignacion_inscripcion_id_inscripcion = '" + inscripcion + "' and tipo_actividad_id_tipo_actividad = '480FAD54-D66A-46BF-B677-24386135AB9B';" +
                                             " update actividad set punteo = " + txt4.Text + " where asignacion_id_asignacion_catedratico = '" + asignacion + "' and asignacion_inscripcion_id_inscripcion = '" + inscripcion + "' and tipo_actividad_id_tipo_actividad = '883AB84B-F7DF-4CC9-BE9B-B291C5039F97';" +
                                             " update asignacion set notafinal = " + notaFinal.ToString + " where id_asignacion_catedratico = '" + asignacion + "' and inscripcion_id_inscripcion = '" + inscripcion + "';"

        Try
            ExecuteQuery(sActualizarActividad, sCadenaConexion)

            Script = "<script type='text/javascript'>" & _
                               "alert('Datos Actualizados Correctamente');" & _
                           "</script>"
        Catch ex As Exception
            Script = "<script type='text/javascript'>" & _
                              "alert('Error al ingresar, intentelo nuevamente');" & _
                          "</script>"
        Finally
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alerta", Script, False)
            contruirNotas(idSeccion)
        End Try
    End Sub

    Protected Sub btnsalir_Click1(sender As Object, e As EventArgs) Handles btnsalir.Click
        mpeUserDetail.Hide()
    End Sub
End Class
