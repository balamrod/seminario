Imports Microsoft.VisualBasic
Imports WindowsApplication1.Query


Public Class Globales
    Public Shared cadenaConexion As String = "server= localhost ;user id=root;password=mysql;database = cerby;Pooling=false;Connection Lifetime=1; Max Pool Size=1"
    'Public Shared reporteAsignacion As String
    'Public Shared reporteAlumnoRetirado As String
    'Public Shared perfilUsuario As String
    '  Public Shared nombreUsuario As String
    Public Shared usuario2 As String
    Public Shared id_acceso2 As String
    Public Shared aplicacion As String
    Public Shared indice As Integer
    Public Shared id_empleado As Integer

    Public Shared inscribirAlumno As Boolean = False
    Public Shared asignarAlumno As Boolean = False

    Public Shared anioGlobal As String
    Public Shared carreraGlobal As String
    Public Shared randomGlobal As String
End Class
