Imports Maestros
Imports General
Imports Conexion
Imports System.Data
Imports Query
Imports Globales

Partial Class trsConsultaNotasAlumno
    Inherits System.Web.UI.Page

#Region "variables"
    ' Dim temp As String = "5413E1D5-8F27-4008-AD4F-6517021A87D5"
    Dim sAnio As String = "select anio " +
                "from seccion s  inner join detalle_seccion ds on s.id_seccion = ds.seccion_id_seccion " +
                "					 inner join asignacion asig on asig.id_asignacion_catedratico = ds.id_asignacion_catedratico	 " +
                "					 inner join inscripcion ins on ins.id_inscripcion = asig.inscripcion_id_inscripcion " +
                "					 inner join alumno al on al.id_carrera = ins.id_carrera  " +
                "					 							and  al.correlativo_carnet = ins.numero_carnet " +
                "					 							and al.anio_carnet = ins.anio_carnet " +
                "where al.usuario_id_usuario = '" + idUsuario + "' " +
                "group by s.anio "

    Dim sCadenaConexion As String = cadenaConexion

#End Region

    Private Sub construirGrid()
        Dim sNotas As String = "SELECT cat.nombre as catedra, " +
        "(select punteo from actividad act, tipo_actividad ta where act.asignacion_id_asignacion_catedratico  = asig.id_asignacion_catedratico  " +
        "and act.asignacion_inscripcion_id_inscripcion = asig.inscripcion_id_inscripcion and ta.id_tipo_actividad = act.tipo_actividad_id_tipo_actividad and ta.nombre = '1') as '1er parcial', " +
        "(select punteo from actividad act, tipo_actividad ta where act.asignacion_id_asignacion_catedratico  = asig.id_asignacion_catedratico  " +
        "and act.asignacion_inscripcion_id_inscripcion = asig.inscripcion_id_inscripcion and ta.id_tipo_actividad = act.tipo_actividad_id_tipo_actividad and ta.nombre = '2') as '2do parcial', " +
        "(select punteo from actividad act, tipo_actividad ta where act.asignacion_id_asignacion_catedratico  = asig.id_asignacion_catedratico  " +
        "and act.asignacion_inscripcion_id_inscripcion = asig.inscripcion_id_inscripcion and ta.id_tipo_actividad = act.tipo_actividad_id_tipo_actividad and ta.nombre = '3') as 'Zona', " +
        "(select punteo from actividad act, tipo_actividad ta where act.asignacion_id_asignacion_catedratico  = asig.id_asignacion_catedratico " +
        "and act.asignacion_inscripcion_id_inscripcion = asig.inscripcion_id_inscripcion and ta.id_tipo_actividad = act.tipo_actividad_id_tipo_actividad and ta.nombre = '4') as 'Examen Final', " +
        " asig.notafinal as 'Punteo Final' " +
        "FROM seccion s " +
            "inner join catedra cat on s.catedra_id_catedra = cat.id_catedra " +
            "INNER JOIN detalle_seccion ds ON s.id_seccion = ds.seccion_id_seccion " +
            "INNER JOIN asignacion asig ON asig.id_asignacion_catedratico = ds.id_asignacion_catedratico " +
            "INNER JOIN inscripcion ins ON ins.id_inscripcion = asig.inscripcion_id_inscripcion " +
            "INNER JOIN alumno al ON al.id_carrera = ins.id_carrera AND al.correlativo_carnet = ins.numero_carnet AND al.anio_carnet = ins.anio_carnet " +
        "WHERE al.usuario_id_usuario = '" + idUsuario + "' " +
        " and s.anio = " + ddlAnio.Text + " and s.ciclo_anual = " + ddlCiclo.Text

        Dim dView As DataView = FillDataGridView(sCadenaConexion, sNotas, "catedra")
        gvCatedras.DataSource = dView
        gvCatedras.DataBind()
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Not Me.Page.IsPostBack Then
            
            Dim dsAnio As DataSet = ExecuteQuery(sAnio, sCadenaConexion)
            FillComboBox(ddlAnio, dsAnio, "anio", "anio")
            ddlAnio.DataBind()

        End If
        
    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As ImageClickEventArgs) Handles btnBuscar.Click
        construirGrid()
    End Sub
End Class
