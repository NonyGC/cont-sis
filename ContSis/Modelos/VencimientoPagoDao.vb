Imports Capa_Entidad
Imports Modelos
Imports MySql.Data.MySqlClient

Public Class VencimientoPagoDao
    Inherits BaseDao
    Implements ICrud
    Private vencimientoPago As VencimientoPagos
    Public Sub New()

    End Sub
    Public Sub New(vencimientoPago)
        Me.vencimientoPago = vencimientoPago

    End Sub
    Public Function Actualizar() As Boolean Implements ICrud.Actualizar
        Try
            Dim resp As Integer
            Dim cmd As MySqlCommand = CommandText("UPDATE `cronograma_pagos` SET `fecha`=@fecha WHERE  `periodo`=@periodo AND `ruc`=@ruc;")
            cmd.Parameters.AddWithValue("@fecha", vencimientoPago.Fecha.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@periodo", vencimientoPago.Periodo)
            cmd.Parameters.AddWithValue("@ruc", vencimientoPago.Ruc)
            resp = cmd.ExecuteNonQuery
            If resp > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        Finally
            CloseDB()
        End Try
    End Function

    Public Function Crear() As Boolean Implements ICrud.Crear
        Try
            Dim resp As Integer
            Dim cmd As MySqlCommand = CommandText("INSERT INTO `cronograma_pagos` (`periodo`, `ruc`, `fecha`) VALUES (@periodo, @ruc,@fecha);")
            cmd.Parameters.AddWithValue("@periodo", vencimientoPago.Periodo)
            cmd.Parameters.AddWithValue("@ruc", vencimientoPago.Ruc)
            cmd.Parameters.AddWithValue("@fecha", vencimientoPago.Fecha.ToString("yyyy-MM-dd"))
            resp = cmd.ExecuteNonQuery
            If resp > 0 Then
                Return True
            Else
                Return False
            End If
        Catch exMysql As MySqlException
            Return False
        Catch ex As Exception
            Return False
        Finally
            CloseDB()
        End Try
    End Function

    Public Function Elminar() As Boolean Implements ICrud.Elminar
        Try
            Dim resp As Integer
            Dim cmd As MySqlCommand = CommandText("DELETE FROM `cronograma_pagos` WHERE  `periodo`=@periodo AND `ruc`=@ruc;")
            cmd.Parameters.AddWithValue("@periodo", vencimientoPago.Periodo)
            cmd.Parameters.AddWithValue("@ruc", vencimientoPago.Ruc)
            resp = cmd.ExecuteNonQuery
            If resp > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        Finally
            CloseDB()
        End Try
    End Function
    Public Function GetByPeridoAndRuc() As VencimientoPagos
        Try
            Dim cmd As MySqlCommand = CommandText("SELECT *  FROM `cronograma_pagos` WHERE  `periodo`=@periodo AND `ruc`=@ruc;")
            Dim newVencimientoPago As New VencimientoPagos
            cmd.Parameters.AddWithValue("@periodo", vencimientoPago.Periodo)
            cmd.Parameters.AddWithValue("@ruc", vencimientoPago.Ruc)

            Using dr As MySqlDataReader = cmd.ExecuteReader

                If dr.Read Then
                    newVencimientoPago.Periodo = dr.GetInt32("periodo")
                    newVencimientoPago.Ruc = dr.GetInt32("ruc")
                    newVencimientoPago.Fecha = dr.GetDateTime("fecha")
                Else
                    newVencimientoPago = Nothing
                End If
            End Using
            Return newVencimientoPago
        Catch ex As Exception
            Return Nothing
        Finally
            CloseDB()
        End Try

    End Function
    Public Function GetAll() As List(Of VencimientoPagos)
        Try
            Dim cmd As MySqlCommand = CommandText("SELECT *  FROM `cronograma_pagos`;")
            Dim listVencimientoPago As New List(Of VencimientoPagos)
            Using dr As MySqlDataReader = cmd.ExecuteReader

                While dr.Read
                    Dim newVencimientoPago As New VencimientoPagos
                    newVencimientoPago.Periodo = dr.GetInt32("periodo")
                    newVencimientoPago.Ruc = dr.GetInt32("ruc")
                    newVencimientoPago.Fecha = dr.GetDateTime("fecha")
                    listVencimientoPago.Add(newVencimientoPago)
                End While
            End Using
            Return listVencimientoPago
        Catch ex As Exception
            Return Nothing
        Finally
            CloseDB()
        End Try
    End Function


End Class
