Imports System.Data
Imports System.Text
Imports System.IO.Ports

Public Class Carga
    Dim ConteoCarga As Integer
    Dim CodigoCarga, elementos As Integer
    Dim DataString As StringBuilder
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
        poblartablas(6, 0)

        lstdescripcion2.DisplayMember = "descripcion"
        lstdescripcion2.DataSource = tablaProdDevolucion

        lstcantidad2.DisplayMember = "cantidad"
        lstcantidad2.DataSource = tablaProdDevolucion
    End Sub
    Sub AgregarACarga()

        Try
            cmd.Connection = conn
            cmd.CommandText = "INSERT INTO detalle_carga(codigocarga,codigo,cantidad) VALUES(" & CodigoCarga & "," & lstdescripcion.SelectedValue & ",'" & txtcantidad.Text & "')"
            cmd.ExecuteNonQuery()
            lblcarga.Text = CodigoCarga
            ConteoCarga = ConteoCarga + CInt(txtcantidad.Text)
            lblcantidadcarga.Text = ConteoCarga
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
        End Try
        txtcantidad.Text = Nothing
        txtbusqueda.Focus()
    End Sub

    Private Sub Carga_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
 
    End Sub

    Private Sub Carga_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Me.Hide()
        e.Cancel = True
    End Sub

    Private Sub Carga_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        poblartablas(3, 0)

        tablaquery.Table = dsprod.Tables("productos2")

        lstupc.ValueMember = "codigo"
        lstupc.DisplayMember = "upc"
        lstupc.DataSource = tablaquery

        lstdescripcion.ValueMember = "codigo"
        lstdescripcion.DisplayMember = "descripcion"
        lstdescripcion.DataSource = tablaquery

        ' If we can initialize the Reader
        If (Scanning.InitReader()) Then

            ' Create a new delegate to handle scan notifications
            Me.ReaderFormEventHandler = New System.EventHandler(AddressOf MyReader_ReadNotify)

            ' Set the event handler of the Scanning class to our delegate
            Scanning.MyEventHandler = ReaderFormEventHandler

            ' Attach to activate and deactivate events
            AddHandler Me.Activated, New System.EventHandler(AddressOf Carga_Activated)

            ' Start a read on the reader
            Scanning.StartRead()

        Else
            

            Return

        End If

    End Sub

    Private Sub txtbusqueda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbusqueda.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtcantidad.Focus()
        End If
    End Sub

    Private Sub txtbusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.TextChanged
        If RadioButton1.Checked = True Then
            tablaquery.RowFilter = ("upc = '" & txtbusqueda.Text & "'")
        ElseIf RadioButton2.Checked = True Then
            tablaquery.RowFilter = ("descripcion LIKE '%" & txtbusqueda.Text & "%'")
        End If
    End Sub

    Private Sub txtcantidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcantidad.KeyDown
        If e.KeyCode = Keys.Enter And txtcantidad.Text <> Nothing Then
            SellModeClient = True
            AgregarACarga()
        End If
    End Sub

    Private Sub btnagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregar.Click
        If txtcantidad.Text <> Nothing Then
            AgregarACarga()
            SellModeClient = True
            ProductosCarga()
        End If

    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Scanning.StopRead()
        Scanning.TermReader()
        Dim principal As New principal
        principal.ShowDialog()
        Me.Close()
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        If MsgBox("Deseas generar una nueva carga?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Generar carga") = MsgBoxResult.Yes Then
            Try
                cmd.Connection = conn
                cmd.CommandText = "INSERT INTO carga(dia,mes,anio) VALUES('" & Date.Now.Day & "','" & Date.Now.Month & "','" & Date.Now.Year & "')"
                cmd.ExecuteNonQuery()
                generarnota = 0
                poblartablas(5, 0)
                'Obtener el indice maximo de carga
                CodigoCarga = tablaProdCarga(0)(0)
                lblcarga.Text = CodigoCarga
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
            End Try
            txtbusqueda.Focus()
        End If
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        SellModeClient = True
        ProductosCarga()
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        DataString = New StringBuilder
        Dim cantidadDevolucion As Integer
        total = 0

        Try
            If SP2.IsOpen = False Then
                SP2.Open()
            End If

            DataString.Append("! U1 SETLP 7 3 27" & vbCrLf)
            DataString.Append("! U1 XY 10 0" & vbCrLf)
            DataString.Append("*--DEVOLUCION DE CARGA--*" & vbCrLf)
            DataString.Append("! U1 XY 10 40" & vbCrLf)
            DataString.Append("" & Date.Today & "" & vbCrLf)
            DataString.Append("! U1 SETLP 7 0 20" & vbCrLf)
            DataString.Append("! U1 XY 10 100" & vbCrLf)
            DataString.Append("Cant." & vbCrLf)
            DataString.Append("! U1 XY 70 100" & vbCrLf)
            DataString.Append("Descricpion" & vbCrLf)
            fila = 130

            For Me.elementos = 0 To (lstcantidad2.Items.Count - 1)
                lstcantidad2.SelectedIndex = elementos
                lstdescripcion2.SelectedIndex = elementos
                DataString.Append("! U1 XY 10 " & fila & "" & vbCrLf)
                DataString.Append("" & lstcantidad2.Text & "" & vbCrLf)
                DataString.Append("! U1 XY 70 " & fila & "" & vbCrLf)
                DataString.Append("" & lstdescripcion2.Text & "" & vbCrLf)
                fila = fila + 28
                cantidadDevolucion = cantidadDevolucion + Val(lstcantidad2.Text)
            Next Me.elementos

            fila = fila + 40
            DataString.Append("! U1 SETLP 7 4 27" & vbCrLf)
            DataString.Append("! U1 XY 10 " & fila & "" & vbCrLf)
            DataString.Append("Cantidad de articulos: " & cantidadDevolucion & "" & vbCrLf)
            DataString.Append("! U1 SETLP 7 4 27" & vbCrLf)
            fila = fila + 100
            DataString.Append("! U1 XY 10 " & fila & "" & vbCrLf)
            DataString.Append("*--FIN DEVOLUCION--*")
            fila = fila + 50
            DataString.Append("! U1 XY 10 " & fila & "" & vbCrLf)
            DataString.Append(" ")
            SP2.WriteLine(DataString.ToString())
            System.Threading.Thread.Sleep(2500)
            SP2.Close()
        Catch ex As Exception
            MsgBox("Por favor encienda la impresora o acerquese", MsgBoxStyle.OkOnly, "Error")
        End Try

        total = 0
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            txtbusqueda.Text = ""
            tablaquery.RowFilter = ("descripcion LIKE '%" & txtbusqueda.Text & "%'")
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            txtbusqueda.Text = ""
        End If
    End Sub
End Class