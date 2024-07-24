Imports System.Data.SqlClient
Imports CapaEntidad

Public Class DAOEmpleado
    Dim objCon As New Conexion
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter

    ' Obtener listado de empleados
    Public Function listaEmpleados() As DataSet
        Dim ds As New DataSet
        cn = objCon.conectar
        da = New SqlDataAdapter("ListarEmpleados", cn)
        da.Fill(ds, "empleado")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()

    End Function

    ' Obtener listado de posiciones
    Public Function listarPosiciones() As DataSet
        Dim ds As New DataSet
        cn = objCon.conectar
        da = New SqlDataAdapter("ListarPosiciones", cn)
        da.Fill(ds, "Posicion")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()

    End Function

    ' Obtener listado de sucursales
    Public Function listarSucursales() As DataSet
        Dim ds As New DataSet
        cn = objCon.conectar
        da = New SqlDataAdapter("ListarSucursales", cn)
        da.Fill(ds, "Sucursal")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()

    End Function

    ' Actualizar salario de un empleado
    Public Sub actualizarSalario(ByVal objC As CEEmpleado)
        cn = objCon.conectar
        Try
            cn.Open()
            da = New SqlDataAdapter("actualizarSalario", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@ced_empleado", SqlDbType.NVarChar).Value = objC.cedulaEmpleado
                .Add("@salario", SqlDbType.Float).Value = objC.Salario

            End With
            da.SelectCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error al realizar la actualizacion", MsgBoxStyle.Critical)
        End Try
        da.Dispose()
        cn.Dispose()

    End Sub

    ' Actualizar sucursal de un empleado
    Public Sub actualizarSucursal(ByVal objC As CEEmpleado)
        cn = objCon.conectar
        Try
            cn.Open()
            da = New SqlDataAdapter("actualizarSucursal", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@ced_empleado", SqlDbType.NVarChar).Value = objC.cedulaEmpleado
                .Add("@cod_sucursal", SqlDbType.NChar).Value = objC.codSucursal

            End With
            da.SelectCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error al realizar la actualizacion", MsgBoxStyle.Critical)
        End Try
        da.Dispose()
        cn.Dispose()

    End Sub


End Class
