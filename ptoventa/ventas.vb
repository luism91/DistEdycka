Imports System.Data
Imports System.Text
Public Class ventas

    Dim elementos, i, i2, rowview, test As Integer
    Dim desc, codigo, errorimp As String
    Dim tprod As New DataTable
    Dim currentDate As DateTime = DateTime.Now
    Dim dateString As String = "dd-MM-yyyy"
    Dim DataString As StringBuilder
    Dim drarray() As DataRow
    Private ReaderFormEventHandler As System.EventHandler = Nothing
    Private Sub MyReader_ReadNotify(ByVal sender As Object, ByVal e As EventArgs)

        Dim TheReaderData As Symbol.Barcode.ReaderData = Scanning.MyReaderData

        ' If it is a successful read (as opposed to a failed one)
        If (TheReaderData.Result = Symbol.Results.SUCCESS) Then

            ' Handle the data from this read
            Me.HandleData(TheReaderData)
            ' Start the next read
            Scanning.StartRead()

        Else

            Dim sMsg As String
            sMsg = "Read Failed" + vbCrLf + "Result = " + (TheReaderData.Result).ToString()

            MessageBox.Show(sMsg, "ReadNotify")

            If (TheReaderData.Result = Symbol.Results.E_SCN_READINCOMPATIBLE) Then
                'If the failure is E_SCN_READINCOMPATIBLE, exit the application.
                MessageBox.Show("The application will now exit.")
                Me.Close()
                Return
            End If

        End If

    End Sub
    Private Sub HandleData(ByVal TheReaderData As Symbol.Barcode.ReaderData)
        If RadioButton1.Checked = True Then
            txtbusqueda.Text = TheReaderData.Text
        End If
    End Sub
    
    Sub ProductosCarga()


        'Obtener el indice maximo de carga
        poblartablas(5, 0)
        'Cargar productos de la ultima carga
        CodigoCargaVentas = tablaProdCarga(0)(0)
        'Asociar tabla de carga con listas
        poblartablas(3, 0)

        lstprecio1.DisplayMember = "precio"
        lstprecio1.DataSource = tablaquery

        lstprecio2.DisplayMember = "precio1"
        lstprecio2.DataSource = tablaquery

        lstprecio3.DisplayMember = "precio2"
        lstprecio3.DataSource = tablaquery
   
        lstcantidad2.DisplayMember = "cantidad"
        lstcantidad2.DataSource = tablaquery

        lstupc.DisplayMember = "upc"
        lstupc.DataSource = tablaquery

        lstdescripcion2.ValueMember = "codigo"
        lstdescripcion2.DisplayMember = "descripcion"
        lstdescripcion2.DataSource = tablaquery

        cmbtipoprecio.SelectedIndex = 0


    End Sub

    Public Function imprimirecibo(ByVal tiporecibo As String) As Integer

        DataString = New StringBuilder()

        Try
            If n.IsOpen = False Then
                n.Open()
            End If

            fila = 20
            DataString.Append("! U1 SETLP 5 1 70" & vbCrLf)
            DataString.Append("! U1 XY 10 20" & vbCrLf)
            DataString.Append("========  DISTRIBUIDORA EDCYKA  ========" & vbCrLf)
            DataString.Append("! U1 SETLP 5 0 35" & vbCrLf)
            DataString.Append("! U1 XY 10 70" & vbCrLf)
            DataString.Append("MARCO ANTONIO FERNANDEZ CASTILLO" & vbCrLf)
            DataString.Append("! U1 XY 10 100" & vbCrLf)
            DataString.Append("RFC: FECM-700424-8C4" & vbCrLf)
            DataString.Append("! U1 XY 10 130" & vbCrLf)
            DataString.Append("RINCONES #155 COL.CTM CUAUH.,CHIH." & vbCrLf)
            DataString.Append("! U1 XY 10 160" & vbCrLf)
            DataString.Append("TEL.582-7897 // Cel. 625-121-0460" & vbCrLf)
            DataString.Append("! U1 XY 10 190" & vbCrLf)
            DataString.Append("========================================" & vbCrLf)
            'Datos Cliente
            DataString.Append("! U1 XY 10 210" & vbCrLf)
            DataString.Append("Cliente: " & ComboBox1.Text & vbCrLf)
            DataString.Append("! U1 XY 10 240" & vbCrLf)
            tablaclientes.RowFilter = "codigocliente = " & ComboBox1.SelectedValue & ""
            Dim localidad As String = tablaclientes(0)(3).ToString()
            If localidad.Equals(DBNull.Value) Or localidad.Equals(Nothing) Or localidad = "" Then
                localidad = "N/A"
            End If
            DataString.Append("Localidad: " & localidad & vbCrLf)
            DataString.Append("! U1 XY 10 270" & vbCrLf)
            DataString.Append(currentDate.ToString(dateString) & vbCrLf)
            DataString.Append("! U1 XY 10 300" & vbCrLf)
            DataString.Append(tiporecibo & vbCrLf)
            DataString.Append("! U1 SETLP 7 0 20" & vbCrLf)
            DataString.Append("! U1 XY 360 300" & vbCrLf)
            DataString.Append("Folio:" & vbCrLf)
            DataString.Append("! U1 XY 440 300" & vbCrLf)
            DataString.Append(codventa & vbCrLf)
            DataString.Append("! U1 XY 10 330" & vbCrLf)
            DataString.Append("***********************************************" & vbCrLf)
            DataString.Append("! U1 XY 0 360" & vbCrLf)
            DataString.Append("C." & vbCrLf)
            DataString.Append("! U1 XY 25 360" & vbCrLf)
            DataString.Append("Descripcion" & vbCrLf)
            DataString.Append("! U1 XY 395 360" & vbCrLf)
            DataString.Append("Prec." & vbCrLf)
            DataString.Append("! U1 XY 490 360" & vbCrLf)
            DataString.Append("Imp." & vbCrLf)

            DataString.Append("! U1 SETLP 7 0 20" & vbCrLf)
            'cambiar
            fila = 390
            For Me.elementos = 0 To (lstdescripcion.Items.Count - 1)
                lstprecio.SelectedIndex = elementos
                lstdescripcion.SelectedIndex = elementos
                lstcantidad.SelectedIndex = elementos
                lstimporte.SelectedIndex = elementos

                DataString.Append("! U1 XY 0 " & fila & "" & vbCrLf)
                DataString.Append("" & lstcantidad.Text & "" & vbCrLf)
                DataString.Append("! U1 XY 30 " & fila & "" & vbCrLf)
                DataString.Append("" & lstdescripcion.Text & "" & vbCrLf)
                DataString.Append("! U1 XY 395 " & fila & "" & vbCrLf)
                DataString.Append("" & lstprecio.Text & "" & vbCrLf)
                DataString.Append("! U1 XY 490 " & fila & "" & vbCrLf)
                DataString.Append("" & lstimporte.Text & "" & vbCrLf)

                fila = fila + 27
            Next Me.elementos

            fila = fila + 40
            DataString.Append("! U1 SETLP 7 0 20" & vbCrLf)
            DataString.Append("! U1 XY 10 " & fila & "" & vbCrLf)
            DataString.Append("***********************************************" & vbCrLf)
            DataString.Append("! U1 SETLP 4 0 35" & vbCrLf)
            fila = fila + 50
            DataString.Append("! U1 XY 55 " & fila & "" & vbCrLf)
            DataString.Append("Total: " & "$" & (Format(CDec(total), ".00")) & "" & vbCrLf)
            DataString.Append("! U1 SETLP 7 0 20" & vbCrLf)
            fila = fila + 50
            DataString.Append("! U1 XY 10 " & fila & "" & vbCrLf)
            DataString.Append(" " & vbCrLf)

            'Texto pagaré
            DataString.Append("! U1 SETLP 7 0 20" & vbCrLf)
            fila = fila + 27
            DataString.Append("! U1 XY 10 " & fila & "" & vbCrLf)
            DataString.Append("Por este pagare me nos obligo(amos) a pagar" & vbCrLf)
            fila = fila + 27
            DataString.Append("! U1 XY 10 " & fila & "" & vbCrLf)
            DataString.Append("incodicionalmente a la orden de: " & vbCrLf)
            fila = fila + 27
            DataString.Append("! U1 XY 10 " & fila & "" & vbCrLf)
            DataString.Append("MARCO ANTONIO FERNANDEZ CASTILLO en este lugar" & vbCrLf)
            fila = fila + 27
            DataString.Append("! U1 XY 10 " & fila & "" & vbCrLf)
            DataString.Append("la cantidad de $ " & (Format(CDec(total), ".00")) & "." & vbCrLf)
            fila = fila + 27
            DataString.Append("! U1 XY 10 " & fila & "" & vbCrLf)
            DataString.Append("Por concepto de mercancias recibidas a entera" & vbCrLf)
            fila = fila + 27
            DataString.Append("! U1 XY 10 " & fila & "" & vbCrLf)
            DataString.Append("satisfaccion. De no pagarse el dia ____" & vbCrLf)
            fila = fila + 27
            DataString.Append("! U1 XY 10 " & fila & "" & vbCrLf)
            DataString.Append("de _____________ del ________ causara intereses" & vbCrLf)
            fila = fila + 27
            DataString.Append("! U1 XY 10 " & fila & "" & vbCrLf)
            DataString.Append("moratorios a razon del _____ % mensual hasta su" & vbCrLf)
            fila = fila + 27
            DataString.Append("! U1 XY 10 " & fila & "" & vbCrLf)
            DataString.Append("total liquidacion." & vbCrLf)

            DataString.Append("! U1 SETLP 4 0 35" & vbCrLf)
            fila = fila + 40
            DataString.Append("! U1 XY 10 " & fila & "" & vbCrLf)
            DataString.Append("----------------------" & vbCrLf)
            fila = fila + 40
            DataString.Append("! U1 XY 10 " & fila & "" & vbCrLf)
            DataString.Append("ACEPTO(AMOS)" & vbCrLf)
            fila = fila + 27
            DataString.Append("! U1 XY 10 " & fila & "" & vbCrLf)
            DataString.Append("  " & vbCrLf)

            n.WriteLine(DataString.ToString())
            System.Threading.Thread.Sleep(2500)
            n.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle.OkOnly)
        End Try

    End Function

    Public Sub agregarproductos()

        If ComboBox1.Enabled = True Then
            generarnota = 1
            ComboBox1.Enabled = False
        End If


        If generarnota = 1 Then

            poblartablas(0, 0)
            tablacargas.RowFilter = "codigocliente =" & ComboBox1.SelectedValue & " AND venta_finalizada =0"

            If tablacargas.Count = 0 Then
                Try
                    ComboBox1.Enabled = False
                    cmd.Connection = conn
                    cmd.CommandText = "INSERT INTO ventas(codigocliente,dia,mes,anio,venta_finalizada,importe) VALUES('" & ComboBox1.SelectedValue & "','" & Date.Now.Day & "','" & Date.Now.Month & "','" & Date.Now.Year & "','0',0)"
                    cmd.ExecuteNonQuery()
                    generarnota = 0
                    poblartablas(0, 0)
                    tablacargas.RowFilter = "codigocliente =" & ComboBox1.SelectedValue & " AND venta_finalizada =0"
                    codventa = tablacargas(0)("codigoventa")
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
                End Try
            Else
                MsgBox("Ya hay una nota abierta con este cliente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                generarnota = 0
                cargarnota(ComboBox1.SelectedValue)
                txtbusqueda.Focus()
                Exit Sub

            End If
        End If

        If generarnota = 0 Then

            'Query para instertar productos a la nota
            If Val(txtcantidad.Text) > 0 Then
                Try
                    cantidad = Val(txtcantidad.Text)
                    If cantidad <= Val(lstcantidad2.Text) Then
                        desc = lstdescripcion2.Text
                        'Codigo del producto en seleccion
                        codigo = lstdescripcion2.SelectedValue
                        importe = Val(lstprecio1.Text) * Val(txtcantidad.Text)
                        Dim CantidadActual As Integer
                        CantidadActual = Val(lstcantidad2.Text) - cantidad
                        'Descontar del inventario
                        cmd.Connection = conn
                        cmd.CommandText = "UPDATE detalle_carga SET cantidad=" & CantidadActual & " WHERE codigo= " & codigo & ""
                        cmd.ExecuteNonQuery()

                        If cmbtipoprecio.SelectedIndex = 0 Then
                            precio = Val(lstprecio1.Text)
                        ElseIf cmbtipoprecio.SelectedIndex = 1 Then
                            precio = Val(lstprecio2.Text)
                        ElseIf cmbtipoprecio.SelectedIndex = 2 Then
                            precio = Val(lstprecio3.Text)
                        End If

                        'Agregar codigo a lista de productos en nota
                        cmd.Connection = conn
                        cmd.CommandText = "INSERT INTO detalle_ventas(codigoventa,codigo,descuento,cantidad) VALUES('" & codventa & "','" & codigo & "'," & precio & ",'" & cantidad & "')"
                        cmd.ExecuteNonQuery()

                        lstcodigo.Items.Add(codigo)
                        lstdescripcion.Items.Add(desc)
                        lstprecio.Items.Add(Format(CDec(precio), ".00"))
                        lstimporte.Items.Add(Format(CDec(importe), ".00"))
                        lstcantidad.Items.Add(cantidad)
                        ProductosCarga()
                    Else
                        MsgBox("La cantidad que deseas agregar es mayor a la con la que se cuenta en carga", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
                Finally
                    precio = 0
                    importe = 0
                    cantidad = 0
                    total = 0
                    desc = ""
                    txtcantidad.Text = ""
                    txtbusqueda.Text = ""
                    txtbusqueda.Focus()
                End Try
            Else
                MsgBox("La cantidad debe ser mayor a 0", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
            End If
        End If


    End Sub
    Public Sub calcimporte()
        total = 0
        For Me.i = 0 To (lstimporte.Items.Count - 1)
            lstimporte.SelectedIndex = Me.i
            total = (total) + (Val(lstimporte.Text))
        Next Me.i
        lbimporte.Text = Nothing
        lbimporte.Text = (Format(CDec(total), ".00"))

    End Sub
    Private Sub ventas_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Dim currentDate As DateTime = DateTime.Now
        Dim dateString As String = "dd-MM-yyyy"
        'Label5.Text = currentDate.ToString(dateString)
    End Sub
    Public Function cargarnota(ByVal codigocliente As Integer) As Integer

        ComboBox1.Enabled = False
        lstcantidad.Items.Clear()
        lstdescripcion.Items.Clear()
        lstcodigo.Items.Clear()
        'Filtrar por codigo de cliente y si la nota esta abierta.
        tablacargas.RowFilter = "codigocliente ='" & ComboBox1.SelectedValue & "' AND venta_finalizada =0"

        If tablacargas.Count = 0 Then
            MsgBox("No hay notas abiertas con este cliente!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Notas")
            ComboBox1.Enabled = True
            ComboBox1.Focus()
        Else
            'Obtener el codigo el cual corresponde a la nota abierta
            codventa = tablacargas(0)("codigoventa")
            'Pasar el codigo al query para obtener los productos de la nota
            cvCargarNota = codventa
            'Ejecutar el query y poblar el dataset
            poblartablas(2, 0)

            For Me.rowview = 0 To dsdetalleNota.Tables("informacionticket").Rows.Count - 1
                Dim cantidad As Double
                cantidad = (CDec(dsdetalleNota.Tables("informacionticket").Rows(rowview)("cantidad").ToString()))
                lstcantidad.Items.Add(cantidad)
                lstdescripcion.Items.Add(dsdetalleNota.Tables("informacionticket").Rows(rowview)("descripcion").ToString())
                lstcodigo.Items.Add(dsdetalleNota.Tables("informacionticket").Rows(rowview)("codigo").ToString())
                precio = (CDec(dsdetalleNota.Tables("informacionticket").Rows(rowview)("descuento").ToString()))
                importe = precio * (cantidad)
                lstprecio.Items.Add(Format(CDec(precio), ".00"))
                lstimporte.Items.Add(Format(CDec(importe), ".00"))
                total = total + importe
            Next Me.rowview

            'lblcantidad.Text = lstdescripcion.Items.Count
            txtbusqueda.Text = ""
            txtcantidad.Text = ""
            cantidad = 0
            precio = 0
            importe = 0

        End If


    End Function
    Private Sub ventas_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Me.Hide()
        e.Cancel = True
    End Sub

    Private Sub ventas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        'If e.KeyCode = Keys.Down Then
        '    If lstdescripcion2.SelectedIndex >= 0 And lstdescripcion2.SelectedIndex <= lstdescripcion2.Items.Count - 2 Then
        '        mover = lstdescripcion2.SelectedIndex
        '        mover = mover + 1
        '        lstdescripcion2.SelectedIndex = mover
        '    End If
        'ElseIf e.KeyCode = Keys.Up Then
        '    If lstdescripcion2.SelectedIndex >= 1 And lstdescripcion2.SelectedIndex <= lstdescripcion2.Items.Count - 1 Then
        '        mover = lstdescripcion2.SelectedIndex
        '        mover = mover - 1
        '        lstdescripcion2.SelectedIndex = mover
        '    End If
        'End If

        If e.KeyCode = Keys.Tab Then

            If MsgBox("Desea imprimir el recibo?", MsgBoxStyle.OkCancel, "Realizar venta") = MsgBoxResult.Ok Then
                total = 0

                Try
                    calcimporte()
                    imprimirecibo("*--ORIGINAL--*")

                    If MsgBox("Oprime YES para imprimir la COPIA", MsgBoxStyle.YesNo, "Impresion") = MsgBoxResult.Yes Then
                        imprimirecibo("*--COPIA--*")
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                End Try


            End If
        End If

    End Sub
    Private Sub ventas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        poblartablas(0, 0)


        Try
            SellModeClient = True
            ProductosCarga()
            diasemana = Date.Now.DayOfWeek + 1
            'diasemana = 2
            poblartablas(4, 0)

            ComboBox1.ValueMember = "codigocliente"
            ComboBox1.DisplayMember = "nombrecliente"
            ComboBox1.DataSource = tablaclientes

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try      


        ' If we can initialize the Reader
        If (Scanning.InitReader()) Then

            ' Create a new delegate to handle scan notifications
            Me.ReaderFormEventHandler = New System.EventHandler(AddressOf MyReader_ReadNotify)

            ' Set the event handler of the Scanning class to our delegate
            Scanning.MyEventHandler = ReaderFormEventHandler

            ' Attach to activate and deactivate events
            AddHandler Me.Activated, New System.EventHandler(AddressOf ventas_Activated)

            ' Start a read on the reader
            Scanning.StartRead()

        Else

            Return

        End If
    End Sub
    Private Sub txtbusqueda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbusqueda.KeyDown

        If txtbusqueda.Text <> "" Then
            If e.KeyCode = Keys.Enter Then
                txtcantidad.Focus()
            End If

        End If

    End Sub
    Private Sub txtbusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.TextChanged
        If RadioButton1.Checked = True Then
            tablaquery.RowFilter = ("upc = '" & txtbusqueda.Text & "'")
        ElseIf RadioButton2.Checked = True Then
            tablaquery.RowFilter = ("descripcion LIKE '%" & txtbusqueda.Text & "%'")
        End If
       
    End Sub

    Private Sub btnagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregar.Click
        agregarproductos()
    End Sub

    Private Sub txtcantidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcantidad.KeyDown

        If e.KeyCode = Keys.Enter Then
            agregarproductos()
        End If

    End Sub
    Private Sub lstcantidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstcantidad.SelectedIndexChanged
        lstdescripcion.SelectedIndex = lstcantidad.SelectedIndex
        lstprecio.SelectedIndex = lstcantidad.SelectedIndex
        lstcodigo.SelectedIndex = lstcantidad.SelectedIndex
        lstimporte.SelectedIndex = lstcantidad.SelectedIndex
    End Sub

    Private Sub lstdescripcion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstdescripcion.SelectedIndexChanged
        lstcantidad.SelectedIndex = lstdescripcion.SelectedIndex
        lstprecio.SelectedIndex = lstdescripcion.SelectedIndex
        lstcodigo.SelectedIndex = lstdescripcion.SelectedIndex
        lstimporte.SelectedIndex = lstdescripcion.SelectedIndex
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click

        Scanning.StopRead()
        Scanning.TermReader()
        Dim principal As New principal
        principal.ShowDialog()
        Me.Close()
  
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles modifcant.Click

        Try
            Dim cantUpdate As Integer
            cantUpdate = InputBox("Introduce la cantidad deseada de " & vbCrLf & "[ " & lstdescripcion.Text & " ]", "Modificar Cantidad")
            'Actualizar la cantidad de carga
            Dim OldAmount, NewAmount As Integer
            OldAmount = lstcantidad.Items.Item(lstcantidad.SelectedIndex)
            NewAmount = cantUpdate

            If NewAmount < OldAmount Then
                NewAmount = OldAmount - NewAmount

                cmd.Connection = conn
                cmd.CommandText = "UPDATE detalle_carga SET cantidad= cantidad + " & NewAmount & " WHERE codigo= " & lstcodigo.Text & ""
                cmd.ExecuteNonQuery()

                'Actualizar la cantidad del detalle de la nota
                cmd.Connection = conn
                cmd.CommandText = "UPDATE detalle_ventas SET cantidad = '" & cantUpdate & "' WHERE codigoventa ='" & codventa & "' AND codigo ='" & lstcodigo.Text & "'"
                cmd.ExecuteNonQuery()
                lstcantidad.Items.Item(lstcantidad.SelectedIndex) = cantUpdate
                cantinput = 0
                preimporte = Val(lstprecio.Text) * Val(lstcantidad.Text)
                lstimporte.Items.Item(lstcantidad.SelectedIndex) = (Format(CDec(preimporte), ".00"))
                poblartablas(2, 0)
                ProductosCarga()
            Else
                MsgBox("La cantidad nueva es mayor a la antigua!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
        End Try


    End Sub

    Private Sub MenuItem3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click

        Try
            'Actualizar la cantidad de carga
            cmd.Connection = conn
            cmd.CommandText = "UPDATE detalle_carga SET cantidad = cantidad + " & Val(lstcantidad.Text) & " WHERE codigo= " & lstcodigo.Text & ""
            cmd.ExecuteNonQuery()

            cmd.Connection = conn
            cmd.CommandText = "DELETE FROM detalle_ventas WHERE codigoventa = '" & codventa & "' AND codigo = '" & lstcodigo.Text & "'"
            cmd.ExecuteNonQuery()
            Dim itseleccionado As Integer
            itseleccionado = lstcantidad.SelectedIndex
            lstcantidad.Items.RemoveAt(itseleccionado)
            lstdescripcion.Items.RemoveAt(itseleccionado)
            lstcodigo.Items.RemoveAt(itseleccionado)
            lstprecio.Items.RemoveAt(itseleccionado)
            lstimporte.Items.RemoveAt(itseleccionado)
            itseleccionado = 0
            txtbusqueda.Focus()
            poblartablas(2, 0)
            ProductosCarga()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
        End Try


    End Sub

    Private Sub MenuItem5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        total = 0
        For Me.i = 0 To (lstimporte.Items.Count - 1)
            lstimporte.SelectedIndex = Me.i
            total = (total) + (Val(lstimporte.Text))
        Next Me.i
        lbimporte.Text = (Format(CDec(total), ".00"))
        imprimirecibo("*--DUPLICADO--*")

    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        cargarnota(ComboBox1.SelectedIndex + 1)
    End Sub

    Private Sub lstprecio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstprecio.SelectedIndexChanged
        lstcantidad.SelectedIndex = lstprecio.SelectedIndex
        lstdescripcion.SelectedIndex = lstprecio.SelectedIndex
        lstcodigo.SelectedIndex = lstprecio.SelectedIndex
        lstimporte.SelectedIndex = lstprecio.SelectedIndex
    End Sub

    Private Sub lstimporte_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstimporte.SelectedIndexChanged
        lstcantidad.SelectedIndex = lstimporte.SelectedIndex
        lstdescripcion.SelectedIndex = lstimporte.SelectedIndex
        lstcodigo.SelectedIndex = lstimporte.SelectedIndex
        lstprecio.SelectedIndex = lstimporte.SelectedIndex
    End Sub

    Private Sub txtcantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcantidad.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lstprecio.Items.Clear()
        lstdescripcion.Items.Clear()
        lstimporte.Items.Clear()
        lstcantidad.Items.Clear()
        lstcodigo.Items.Clear()
        'lstcantidad3.Items.Clear()
        'lstdescripcion3.Items.Clear()
        'lstprecio3.Items.Clear()
        'lstimp4.Items.Clear()
        'lblcantidad.Text = ""
        precio = 0
        importe = 0
        preimporte = 0
        total = 0
        lbimporte.Text = Nothing
        txtbusqueda.Focus()
        ComboBox1.Enabled = True
        ComboBox1.SelectedIndex = 0
        ComboBox1.Focus()

    End Sub
    Private Sub MenuItem7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        Try
            If lstdescripcion.Items.Count > 0 Then
                calcimporte()
                cmd.Connection = conn
                cmd.CommandText = "UPDATE ventas SET venta_finalizada= '1',importe='" & total & "' WHERE codigoventa ='" & codventa & "'"
                cmd.ExecuteNonQuery()
                MsgBox("Venta cerrada correctamente con folio: '" & codventa & "'", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Venta cerrada")
                poblartablas(0, 0)
                lstdescripcion.Items.Clear()
                lstcodigo.Items.Clear()
                lstprecio.Items.Clear()
                lstimporte.Items.Clear()
                lstcantidad.Items.Clear()
                txtbusqueda.Text = ""
                txtcantidad.Text = ""
                txtbusqueda.Focus()
                'lstcantidad3.Items.Clear()
                'lstdescripcion3.Items.Clear()
                'lstprecio3.Items.Clear()
                'lstimp4.Items.Clear()
                'lblcantidad.Text = ""
                precio = 0
                importe = 0
                preimporte = 0
                total = 0
                ComboBox1.Enabled = True
                ComboBox1.SelectedIndex = 0
                ComboBox1.Focus()
            ElseIf lstdescripcion.Items.Count = 0 Then
                MsgBox("La nota está vacía, no se puede cerrar!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Ventas")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub
    Private Sub lstdescripcion2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstdescripcion2.SelectedIndexChanged
        If lstdescripcion2.Items.Count > 0 And lstupc.Items.Count > 0 Then
            lstcantidad2.SelectedIndex = lstdescripcion2.SelectedIndex
            lstprecio1.SelectedIndex = lstdescripcion2.SelectedIndex
            lstprecio2.SelectedIndex = lstdescripcion2.SelectedIndex
            lstprecio3.SelectedIndex = lstdescripcion2.SelectedIndex
            lstupc.SelectedIndex = lstdescripcion2.SelectedIndex
        End If
    End Sub
    Private Sub lstupc_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstupc.SelectedIndexChanged
        If lstupc.Items.Count > 0 And lstdescripcion2.Items.Count > 0 Then
            lstdescripcion2.SelectedIndex = lstupc.SelectedIndex
            lstcantidad2.SelectedIndex = lstupc.SelectedIndex
            lstprecio1.SelectedIndex = lstupc.SelectedIndex
            lstprecio2.SelectedIndex = lstupc.SelectedIndex
            lstprecio3.SelectedIndex = lstupc.SelectedIndex
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            txtbusqueda.Text = ""
            tablaquery.RowFilter = ("descripcion LIKE '%" & txtbusqueda.Text & "%'")
        End If
    End Sub
End Class