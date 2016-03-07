Imports System.Data.SqlClient
Imports System.Data.SqlServerCe
Imports System
Imports System.Text
Imports System.IO.Ports
Imports System.Threading
Imports System.Data
Imports System.IO

Module Funciones
    
    Public fila, mover, generarnota, codventa, indice, cvCargarNota, i, elementos, optcorte, dia, mes, anio, dia1, mes1, anio1, ccliente, diasemana, CodigoCargaVentas As Integer
    Public desc, uni, codigo, fecharespaldo As String
    Public importe, precio, cantinput, cantcargar, preimporte, total As Decimal
    Public cantidad As Double
    Public tabladetallesnotas, tablaproductosnota, tablacargas, tablaquery, tablaclientes, tablaProdCarga, tablaProdDevolucion As New DataView
    Public cmd As New SqlCeCommand
    'Codigo para cargar productos y agregar notas nuevas
    Public conn As New SqlCeConnection("Data Source=\Program Files\ptoventa\ptoventa.sdf")
    Public dataprod As New SqlCeDataAdapter("SELECT * FROM productos ORDER BY codigo ASC", conn)
    Public datapedi As New SqlCeDataAdapter("SELECT * FROM ventas", conn)

    Public dsped, dscorte, dsprod, dsclientes, dsdetalleNota, dsProdCarga, dsCargaNueva, dsProdDevolucion As New DataSet
    Public mov As Integer = 0
    Public conteo As Integer = 1
    Public SellModeClient As Boolean = False
    Public log(0) As String

    
    Public Sub poblartablas(ByVal opt As Integer, ByVal optcorte As Integer)
        If opt = 0 Then
            Try
                dsped.Clear()
                datapedi.Fill(dsped, "ventas")
                tablacargas.Table = dsped.Tables("ventas")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error")
            End Try
        ElseIf opt = 1 Then
            'Codigo para cargar notas existentes
            If optcorte = 1 Then
                Dim dataCargarVentas As New SqlCeDataAdapter("SELECT c.[codigocliente],c.[nombrecliente],v.[codigoventa],v.[dia]" & _
                  ",v.[mes],v.[anio],v.[importe] FROM clientes AS c " & _
                 "INNER JOIN [ventas] AS v ON c.[codigocliente] = v.[codigocliente] " & _
                 "WHERE v.[dia]>= '" & dia & "' AND v.[dia]<='" & dia1 & "' " & _
                 "AND v.[mes]>= '" & mes & "' AND v.[mes]<='" & mes1 & "' " & _
                 "AND v.[anio]>= '" & anio & "' AND v.[anio]<='" & anio1 & "' " & _
                "AND v.[venta_finalizada]=  1" & _
                 "ORDER BY v.[codigoventa]", conn)
                dscorte.Clear()
                dataCargarVentas.Fill(dscorte, "corte")

            End If
        ElseIf opt = 2 Then
            Try
                Dim dataCargarDetalleNota As New SqlCeDataAdapter("SELECT p.[descripcion],d.[codigo],d.[codigoventa],d.[descuento],d.[cantidad] FROM productos AS P " & _
               "INNER JOIN [detalle_ventas] AS d ON p.[codigo] = d.[codigo] " & _
               "WHERE d.[codigoventa]='" & cvCargarNota & "' ", conn)
                dsdetalleNota.Clear()
                dataCargarDetalleNota.Fill(dsdetalleNota, "informacionticket")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
            End Try
        ElseIf opt = 3 Then
            'Evaluar si es modo venta o modo de modificacion de productos
            If SellModeClient = False Then
                Try
                    dsprod.Clear()
                    dataprod.Fill(dsprod, "productos2")
                    tablaquery.Table = dsprod.Tables("productos2")
                    tablaquery.Sort = "codigo ASC"
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error")
                End Try
            Else

                'Cargar productos de carga del dia en nota de ventas para poder insertar los que haya existentes
                Dim dataProdCarga As New SqlCeDataAdapter("SELECT p.[upc],p.[codigo],p.[descripcion],p.[precio],p.[precio1],p.[precio2],c.[cantidad]" & _
                     "FROM productos AS p " & _
                     "INNER JOIN [detalle_carga] AS c ON p.[codigo] = c.[codigo] " & _
                     "WHERE c.[cantidad] > 0 AND c.[codigocarga] = " & CodigoCargaVentas & " " & _
                     "ORDER BY c.[codigo] ASC", conn)
                Try
                    dsProdCarga.Clear()
                    dataProdCarga.Fill(dsProdCarga, "productos")
                    tablaquery.Table = dsProdCarga.Tables("productos")
                    tablaquery.Sort = "codigo ASC"
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error")
                End Try

            End If

        ElseIf opt = 4 Then
            'Evaluar si es modo venta o modo de visualizacion de clientes
            Try
                Dim query1 As String = "SELECT * FROM clientes"
                Dim query2 As String = "SELECT * FROM clientes where grupocliente= 0 OR grupocliente = " & diasemana & "  order by codigocliente ASC"
                If SellModeClient = False Then
                    Dim dataCargarClientes As New SqlCeDataAdapter(query1, conn)
                    dsclientes.Clear()
                    dataCargarClientes.Fill(dsclientes, "clientes")
                    tablaclientes.Table = dsclientes.Tables("clientes")
                Else
                    Dim dataCargarClientes As New SqlCeDataAdapter(query2, conn)
                    dsclientes.Clear()
                    dataCargarClientes.Fill(dsclientes, "clientes")
                    tablaclientes.Table = dsclientes.Tables("clientes")
                End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error")
            End Try
        ElseIf opt = 5 Then
            'Cargar la tabla con todas las cargas existentes y en el codigo obtener la maxima
            Dim dataCargaProductos As New SqlCeDataAdapter("SELECT MAX(codigocarga) from carga", conn)
            Try
                dsCargaNueva.Clear()
                dataCargaProductos.Fill(dsCargaNueva, "carga")
                tablaProdCarga.Table = dsCargaNueva.Tables("carga")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error")
            End Try
        ElseIf opt = 6 Then
            'Cargar productos de carga del dia en nota de ventas para poder insertar los que haya existentes
            Dim dataProdCarga As New SqlCeDataAdapter("SELECT p.[upc],p.[codigo],p.[descripcion],p.[precio],p.[precio1],p.[precio2],c.[cantidad]" & _
                 "FROM productos AS p " & _
                 "INNER JOIN [detalle_carga] AS c ON p.[codigo] = c.[codigo] " & _
                 "WHERE c.[cantidad] > 0 AND c.[codigocarga] = " & CodigoCargaVentas & " " & _
                 "ORDER BY c.[codigo]", conn)
            Try
                dsProdDevolucion.Clear()
                dataProdCarga.Fill(dsProdDevolucion, "productos")
                tablaProdDevolucion.Table = dsProdDevolucion.Tables("productos")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error")
            End Try

        End If
    End Sub

    Public Sub generarrespaldo()

        fecharespaldo = Date.Today.Day.ToString & Date.Today.Month.ToString & Date.Today.Year.ToString & Date.Today.Millisecond
        Try
            File.Copy("\Program Files\ptoventa\ptoventa.sdf", "\Storage Card\ptoventa-" & fecharespaldo & ".sdf", True)
            MsgBox("Respaldo de base de datos generado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Respaldos")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Respaldos")
        End Try

    End Sub

    

End Module
