Imports WindowsApplication1.clsHelperSQL
Imports WindowsApplication1.clsHelper
''' <summary>
''' Soluciones Analíticas Empresariales S.A. 
''' Contiene las funciones que se encargan de realizar las operaciones ABC
''' </summary>
''' <remarks></remarks>
Public Class clsABC
#Region "Funciones"
    ''' <summary>
    ''' Construye una consulta SQL
    ''' </summary>    
    Public Shared Function BuildQuery(ByVal sTabala As String, ByVal sCampos As String, ByVal sCondicion As String, ByVal sOrderBy As String, ByVal sTypeOrder As String) As DataSet
        Dim sSQL As String
        sSQL = "SELECT " & sCampos
        sSQL += " FROM " & sTabala
        If (sCondicion <> "") Then
            sSQL += " WHERE " & sCondicion
        End If
        If (sOrderBy <> "") Then
            sSQL += " ORDER BY " & sOrderBy & " " & sTypeOrder
        End If
        Return ExecuteQuery(sSQL)
    End Function

    ''' <summary>
    ''' Construye una sentencia SQL
    ''' </summary>    
    Public Shared Function BuildProcedure(ByVal iTipo As Integer, ByVal sTabla As String, ByVal sCampos As String, ByVal sValues As String, ByVal sCondicion As String) As String
        Dim sSQL As String
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
        Return ExecuteProcedure(sSQL)
    End Function

    ''' <summary>
    ''' Procedimiento para guardar datos en la BD
    ''' </summary>    
    Public Shared Function SaveData(ByVal sTabla As String, ByVal sCampos As String, ByVal sValores As String) As String
        Dim sSQL As String
        sSQL = "INSERT INTO " & sTabla & "(" & sCampos & ") VALUES(" & sValores & ")"
        Return ExecuteProcedure(sSQL)
    End Function

    ''' <summary>  
    ''' Procedimiento para guardar datos en la BD
    ''' </summary>    
    Public Shared Function SaveData(ByVal sTabla As String, ByVal ObjTextBox As Windows.Forms.TextBox()) As String
        Dim sSQL As String = ""
        Dim sValoresTabla As String = ""
        Dim sValores As String = ""
        Dim iContador As String = ObjTextBox.Length - 1
        Dim iCuenta As Integer = 0
        For iCuenta = 0 To iContador
            If iContador > 0 Then
                If iCuenta = 0 Then
                    sValoresTabla = ObjTextBox(iCuenta).Tag
                    If IsDouble(ObjTextBox(iCuenta).Text) Then
                        sValores = ObjTextBox(iCuenta).Text
                    Else
                        sValores = "'" & ObjTextBox(iCuenta).Text & "'"
                    End If
                Else
                    sValoresTabla += ", " & ObjTextBox(iCuenta).Tag
                    If IsDouble(ObjTextBox(iCuenta).Text) Then
                        sValores += ", " & ObjTextBox(iCuenta).Text
                    Else
                        sValores += ", '" & ObjTextBox(iCuenta).Text & "'"
                    End If
                End If
            Else
                sValoresTabla = ObjTextBox(iCuenta).Tag
                If IsDouble(ObjTextBox(iCuenta).Text) Then
                    sValores += ObjTextBox(iCuenta).Text
                Else
                    sValores += "'" & ObjTextBox(iCuenta).Text & "'"
                End If
            End If
        Next
        sSQL = "INSERT INTO  " & sTabla & "(" & sValoresTabla & ") VALUES(" & sValores & ")"

        Dim exito As String = ExecuteProcedure(sSQL)
        If exito = "" Then
            MsgBox("Datos guardados correctamente", MsgBoxStyle.Information, "Información")
        End If

        Return exito
    End Function

    ''' <summary>   
    ''' Procedimiento para actualizar datos en la BD
    ''' </summary> 
    Public Shared Function UpdateData(ByVal sTabla As String, ByVal sCamposValores As String, ByVal sCondicion As String) As String
        Dim sSQL As String
        sSQL = "UPDATE " & sTabla & " SET " & sCamposValores
        If (sCondicion <> "") Then
            sSQL += " WHERE " & sCondicion
        End If
        Return ExecuteProcedure(sSQL)
    End Function

    ''' <summary>    
    ''' Procedimiento que actualiza los datos de una BD
    ''' </summary>
    Public Shared Function UpdateData(ByVal sTabla As String, ByVal ObjTextBox() As Windows.Forms.TextBox, ByVal sCondicion As String) As String
        Dim sSQL As String = ""
        Dim sValores As String = ""
        Dim iContador As String = ObjTextBox.Length - 1
        Dim iCuenta As Integer = 0
        For iCuenta = 0 To iContador
            If iContador > 0 Then
                If iCuenta = 0 Then
                    If IsDouble(ObjTextBox(iCuenta).Text) Then
                        sValores = ObjTextBox(iCuenta).Tag & " = " & ObjTextBox(iCuenta).Text
                    Else
                        sValores = ObjTextBox(iCuenta).Tag & " = '" & ObjTextBox(iCuenta).Text & "'"
                    End If
                Else
                    If IsDouble(ObjTextBox(iCuenta).Text) Then
                        sValores += ", " & ObjTextBox(iCuenta).Tag & " = " & ObjTextBox(iCuenta).Text
                    Else
                        sValores += ", " & ObjTextBox(iCuenta).Tag & " = '" & ObjTextBox(iCuenta).Text & "'"
                    End If
                End If
            Else
                If IsDouble(ObjTextBox(iCuenta).Text) Then
                    sValores += ", " & ObjTextBox(iCuenta).Tag & " = " & ObjTextBox(iCuenta).Text
                Else
                    sValores += ", " & ObjTextBox(iCuenta).Tag & " = '" & ObjTextBox(iCuenta).Text & "'"
                End If
            End If
        Next

        sSQL = "UPDATE  " & sTabla & " SET " & sValores & " WHERE " & sCondicion

        Dim exito As String = ExecuteProcedure(sSQL)
        If exito = "" Then
            MsgBox("Datos actualizados correctamente", MsgBoxStyle.Information, "Información")
        End If

        Return exito
    End Function

    ''' <summary>
    ''' Procedimiento para eliminar en la BD
    ''' </summary>
    Public Shared Function DeleteData(ByVal sTabla As String, ByVal sCondicion As String) As String
        Dim result = MessageBox.Show("Desea Eliminar el registro seleccionado?", "Mensaje", MessageBoxButtons.OKCancel)
        Dim sSQL As String = ""
        If result = DialogResult.OK Then
            sSQL = "DELETE FROM " & sTabla & " WHERE " & sCondicion

            Dim exito As String = ExecuteProcedure(sSQL)
            If exito = "" Then
                MsgBox("Datos eliminados correctamente", MsgBoxStyle.Information, "Información")
            End If

            Return exito
        End If
        Return "1"
    End Function

#End Region
End Class