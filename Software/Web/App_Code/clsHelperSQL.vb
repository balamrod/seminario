Imports System.Data

Public Class Maestros
    Public tusuario As String

#Region "Funciones"
    ''' <summary>
    '''  Realiza el insert, update, delete
    ''' </summary> 
    Public Shared Function BuildQuery(ByVal sTabala As String, ByVal sCampos As String, ByVal sCondicion As String, ByVal sOrderBy As String, ByVal sTypeOrder As String, ByVal sCadenaConexion As String) As DataSet
        Dim sSQL As String
        sSQL = "SELECT " & sCampos
        sSQL += " FROM " & sTabala
        If (sCondicion <> "") Then
            sSQL += " WHERE " & sCondicion
        End If
        If (sOrderBy <> "") Then
            sSQL += " ORDER BY " & sOrderBy & " " & sTypeOrder
        End If
        Return Query.ExecuteQuery(sSQL, sCadenaConexion)
    End Function

    Public Shared Function BuildProcedure(ByVal iTipo As Integer, ByVal sTabla As String, ByVal sCampos As String, ByVal sValues As String, ByVal sCondicion As String, ByVal sCadenaConexion As String, ByVal parent As Control) As String
        Dim sSQL As String
        Dim script As String
        Dim sError As String

        If (iTipo = 1) Then
            sSQL = "INSERT INTO " & sTabla & "(" & sCampos & ") VALUES (" & sValues & ")"
        Else
            If (iTipo = 2) Then
                sSQL = "UPDATE " & sTabla & " SET " & sCampos
                If (sCondicion <> "") Then
                    sSQL += " WHERE " & sCondicion
                End If
            Else
                If (iTipo = 3) Then
                    sSQL = "DELETE FROM " + sTabla
                    If (sCondicion <> "") Then
                        sSQL += " WHERE " + sCondicion
                    End If
                Else
                    Return "Error en la construcción, por favor intentalo más tarde"
                End If
            End If
        End If
        sError = Query.ExecuteProcedure(sTabla, iTipo, sSQL, sCadenaConexion)
        If sError <> "" Then
            Select Case iTipo
                Case 1
                    script = "<script type='text/javascript'>" & _
                                       "alert('Error al ingresar, intentelo nuevamente');" & _
                                   "</script>"
                Case 2
                    script = "<script type='text/javascript'>" & _
                                      "alert('Error al modificar, intentelo nuevamente');" & _
                                  "</script>"
                Case 3
                    script = "<script type='text/javascript'>" & _
                                      "alert('Error al eliminar, intentelo nuevamente');" & _
                                  "</script>"
            End Select
            ScriptManager.RegisterStartupScript(parent, GetType(Page), "alerta", script, False)
        Else
            Select Case iTipo
                Case 1
                    script = "<script type='text/javascript'>" & _
                                       "alert('Datos Ingresados Correctamente');" & _
                                   "</script>"

                Case 2
                    script = "<script type='text/javascript'>" & _
                                      "alert('Datos Modificados Correctamente');" & _
                                  "</script>"

                Case 3
                    script = "<script type='text/javascript'>" & _
                                      "alert('Datos Eliminados Correctamente');" & _
                                  "</script>"

            End Select
            ScriptManager.RegisterStartupScript(parent, GetType(Page), "alerta", script, False)
        End If
        Return sError
    End Function

#End Region
End Class