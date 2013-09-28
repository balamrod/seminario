Imports System.Windows.Forms
Imports System.Data
Imports MySql.Data.MySqlClient
Imports Conexion

Public Class General

    Public Shared Function FillDataGridView(ByVal sCadenaConexion As String, ByVal stringTabla As String, ByVal nomTabla As String) As DataView
        Dim dSet As DataSet
        Dim dView As DataView
        Dim cmd As New MySqlCommand(stringTabla, ConectarBD(sCadenaConexion))

        cmd.CommandType = CommandType.Text
        Dim sqlDapter As New MySqlDataAdapter(cmd)

        dSet = New DataSet()

        sqlDapter.Fill(dSet, nomTabla)
        dView = dSet.Tables(nomTabla).DefaultView
        Return dView
    End Function
    
End Class


