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

    Dim sCadenaConexion As String = cadenaConexion
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
        Dim sNotas As String = "select al.nombres , " +
                                "	(select punteo from actividad act, tipo_actividad ta   where act.asignacion_id_asignacion_catedratico  = asig.id_asignacion_catedratico and act.asignacion_inscripcion_id_inscripcion = asig.inscripcion_id_inscripcion and ta.id_tipo_actividad = act.tipo_actividad_id_tipo_actividad and ta.nombre = '1') as '1er parcial', " +
                                    "(select punteo from actividad act, tipo_actividad ta   where act.asignacion_id_asignacion_catedratico  = asig.id_asignacion_catedratico and act.asignacion_inscripcion_id_inscripcion = asig.inscripcion_id_inscripcion and ta.id_tipo_actividad = act.tipo_actividad_id_tipo_actividad and ta.nombre = '2') as '2do parcial', " +
                                    "(select punteo from actividad act, tipo_actividad ta   where act.asignacion_id_asignacion_catedratico  = asig.id_asignacion_catedratico and act.asignacion_inscripcion_id_inscripcion = asig.inscripcion_id_inscripcion and ta.id_tipo_actividad = act.tipo_actividad_id_tipo_actividad and ta.nombre = '3') as 'final' " +
                                    "from asignacion asig " +
                                    "inner join inscripcion ins  on asig.inscripcion_id_inscripcion = ins.id_inscripcion " +
                                    "inner join alumno al on ins.anio_carnet = al.anio_carnet and ins.id_carrera = al.id_carrera " +
                                    "	and ins.numero_carnet = al.correlativo_carnet " +
                                    "inner join detalle_seccion ds on ds.id_asignacion_catedratico = asig.id_asignacion_catedratico " +
                                    "where ds.id_asignacion_catedratico = '" + idSeccion + "'"

        Dim dView As DataView = FillDataGridView(sCadenaConexion, sNotas, "alumno")
        gvNotas.DataSource = dView
        gvNotas.DataBind()
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Not Me.Page.IsPostBack Then

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

        Dim idSeccion As String = row.Cells(4).Text
        contruirNotas(idSeccion)
    End Sub
End Class
