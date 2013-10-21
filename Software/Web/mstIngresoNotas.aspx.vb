Imports System.Data
Imports Maestros
Imports General
Imports Conexion
Imports Query
Imports Globales

Partial Class mstIngresoNotas
    Inherits System.Web.UI.Page

#Region "variables"
    Dim sLlenarGrid As String = "select concat (d.nombres, ' ',d.apellidos) as Alumno, SUM(IF(a.nombre='1er Parcial', a.punteo, 0)) as '1er. parcial', SUM(IF(a.nombre='2do Parcial', a.punteo, 0)) as '2do. parcial', SUM(IF(a.nombre='3er Parcial', a.punteo, 0)) as '3er. parcial', SUM(IF(a.nombre='final', a.punteo, 0)) as 'final' from actividad a inner join asignacion b on a.asignacion_id_asignacion = b.id_asignacion inner join inscripcion c on c.id_inscripcion = b.inscripcion_id_inscripcion inner	join alumno d on d.anio_carnet = c.anio_carnet and d.correlativo_carnet = c.numero_carnet 				and d.id_carrera = c.id_carrera"
    Dim sCadenaConexion As String = cadenaConexion
#End Region

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Not IsPostBack Then
            Dim dView As DataView = FillDataGridView(sCadenaConexion, sLlenarGrid, "catedra")
            grvActualizacion.DataSource = dView
            grvActualizacion.DataBind()
        End If
       
    End Sub
End Class
