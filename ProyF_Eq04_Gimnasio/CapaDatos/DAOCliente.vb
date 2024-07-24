Imports System.Data.SqlClient
Imports CapaEntidad

Public Class DAOCliente
    Dim objCon As New Conexion
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter

    ' Obtener listado de clientes
    Public Function listadoClientes() As DataSet
        Dim ds As New DataSet
        cn = objCon.conectar
        da = New SqlDataAdapter("ListarClientes", cn)
        da.Fill(ds, "Cliente")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()

    End Function

    ' Obtener listado de condiciones
    Public Function listadoCondiciones() As DataSet
        Dim ds As New DataSet
        cn = objCon.conectar
        da = New SqlDataAdapter("ListarCondiciones", cn)
        da.Fill(ds, "condicion")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()

    End Function

    ' Obtener listado de condiciones de clientes
    Public Function listaCondicionesClientes() As DataSet
        Dim ds As New DataSet
        cn = objCon.conectar
        da = New SqlDataAdapter("ListaCondicionesClientes", cn)
        da.Fill(ds, "Condicion_cliente")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    ' Obtener listado de membresías
    Public Function listaMembresia() As DataSet
        Dim ds As New DataSet
        cn = objCon.conectar
        da = New SqlDataAdapter("ListarMembresia", cn)
        da.Fill(ds, "Membresia")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    ' Obtener listado de sucursales
    Public Function listaSucursal() As DataSet
        Dim ds As New DataSet
        cn = objCon.conectar
        da = New SqlDataAdapter("ListarSucursales", cn)
        da.Fill(ds, "Sucursal")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    ' Insertar nueva condición de cliente
    Public Sub insertarCondicion(ByVal objC As CECondicion)
        cn = objCon.conectar
        Try
            cn.Open()
            da = New SqlDataAdapter("InsertarCondiciones", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@ced_cliente", SqlDbType.NVarChar).Value = objC.cedulaCliente
                .Add("@cod_cond", SqlDbType.NChar).Value = objC.codCondicion
            End With
            da.SelectCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error al registrar condición: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            cn.Close()
        End Try
        da.Dispose()
        cn.Dispose()
    End Sub

    ' Insertar nuevo cliente
    Public Sub nuevoCliente(ByVal objC As CECliente)
        cn = objCon.conectar
        Try
            cn.Open()
            da = New SqlDataAdapter("NuevoCliente", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@ced_cliente", SqlDbType.NVarChar).Value = objC.cedulaCliente
                .Add("@fecha_adqui", SqlDbType.Date).Value = objC.fechaAdquiCliente
                .Add("@nomb_cliente", SqlDbType.NVarChar).Value = objC.nombreCliente
                .Add("@apell_cliente", SqlDbType.NVarChar).Value = objC.apellidoCliente
                .Add("@fecha_nac", SqlDbType.Date).Value = objC.fechaNaciCliente
                .Add("@peso", SqlDbType.Float).Value = objC.pesoCliente
                .Add("@sexo", SqlDbType.NVarChar).Value = objC.sexoCliente
                .Add("@cod_sucursal", SqlDbType.NChar).Value = objC.codSucursCliente
                .Add("@cod_memb", SqlDbType.NChar).Value = objC.codMembCliente
            End With
            da.SelectCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error al registrar nuevo cliente", MsgBoxStyle.Critical)
        End Try
        da.Dispose()
        cn.Dispose()

    End Sub

    ' Actualizar clientes
    Public Sub actualizarClientes()
        Dim query As String = "DELETE FROM Cliente WHERE DATEDIFF(MONTH, fecha_adqui, GETDATE()) >= 1"
        cn = objCon.conectar

        Try
            cn.Open()
            da = New SqlDataAdapter(query, cn)
            da.SelectCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error al eliminar datos antiguos: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            cn.Close()
        End Try
        da.Dispose()
        cn.Dispose()
    End Sub

    ' Actualizar condiciones de clientes
    Public Sub actualizarCondiciones()
        Dim query As String = "DELETE FROM Condicion_cliente WHERE ced_cliente NOT IN (SELECT ced_cliente FROM cliente)"
        cn = objCon.conectar

        Try
            cn.Open()
            da = New SqlDataAdapter(query, cn)
            da.SelectCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error al eliminar datos antiguos: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            cn.Close()
        End Try
        da.Dispose()
        cn.Dispose()
    End Sub

End Class
