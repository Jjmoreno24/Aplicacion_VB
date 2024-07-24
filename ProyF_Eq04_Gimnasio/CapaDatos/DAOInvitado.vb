Imports System.Data.SqlClient
Imports CapaEntidad
Public Class DAOInvitado
    Dim objCon As New Conexion
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter

    ' Obtener la cantidad de visitas de un cliente en el mes actual
    Public Function obtenerCantidadVisitas(ByVal ced_cliente As String) As Integer
        cn = objCon.conectar
        Dim cantidad As Integer = 0
        Try
            cn.Open()
            Dim query As String = "SELECT COUNT(*) FROM invitado WHERE ced_cliente = @ced_cliente AND MONTH(fecha_visita) = MONTH(GETDATE()) AND YEAR(fecha_visita) = YEAR(GETDATE())"
            Dim command As New SqlCommand(query, cn)
            command.Parameters.AddWithValue("@ced_cliente", ced_cliente)
            cantidad = CInt(command.ExecuteScalar())
        Catch ex As Exception
            MsgBox("Error al obtener cantidad de visitas: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            cn.Close()
        End Try
        Return cantidad
    End Function

    ' Insertar un nuevo invitado en la base de datos
    Public Sub insertarInvitado(ByVal objC As CEInvitado)
        cn = objCon.conectar
        Try
            cn.Open()
            da = New SqlDataAdapter("InsertarInvitado", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@ced_invitado", SqlDbType.NVarChar).Value = objC.cedulaInvitado
                .Add("@fecha_visita", SqlDbType.Date).Value = objC.fechaInvitacion
                .Add("@nomb_invitado", SqlDbType.NVarChar).Value = objC.nombreInvitado
                .Add("@ced_cliente", SqlDbType.NVarChar).Value = objC.cedulaCliente

            End With
            da.SelectCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error al registrar invitacion: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            cn.Close()
        End Try
        da.Dispose()
        cn.Dispose()
    End Sub


End Class
