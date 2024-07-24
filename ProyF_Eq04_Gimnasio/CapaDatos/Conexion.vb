Imports System.Data.SqlClient


Public Class Conexion
    Dim conexion As SqlConnection

    ' Función para establecer la conexión con la base de datos
    Public Function conectar() As SqlConnection
        ' Se establece la cadena de conexión con el servidor de base de datos
        conexion = New SqlConnection("server=DELL\SQLEXPRESS;database=POWERFITBD; Integrated Security=true")
        Return conexion
    End Function

End Class
