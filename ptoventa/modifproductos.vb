Imports System.Data.SqlClient
Imports System.Data.SqlServerCe
Imports System
Imports System.Data


Public Class modifproductos
    Private ReaderFormEventHandler As System.EventHandler = Nothing
    Dim tablaquery As New DataView
    Dim tprod As New DataTable
    Dim modoedicion As Boolean

    ' Read complete or failure notification
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
        ElseIf chkboxupc.Checked = True Then
            txtupc.Text = TheReaderData.Text
        End If
    End Sub
    Public Sub limpiartablas()
        SellModeClient = False

        tablaquery.Table = dsprod.Tables("productos2")

        lstcodigo.DisplayMember = "upc"
        lstcodigo.ValueMember = "codigo"
        lstcodigo.DataSource = tablaquery

        lstprecio.DisplayMember = "precio"
        lstprecio.DataSource = tablaquery

        lstprecio1.DisplayMember = "precio1"
        lstprecio1.DataSource = tablaquery

        lstprecio2.DisplayMember = "precio2"
        lstprecio2.DataSource = tablaquery

        'lstid.DataSource = tablaquery
        'lstid.DisplayMember = "codigo"

        lstdescripcion.DisplayMember = "descripcion"
        lstdescripcion.ValueMember = "codigo"
        lstdescripcion.DataSource = tablaquery



    End Sub

    Public Sub limpiarcampos()
        txtupc.Text = ""
        txtdescripcion.Text = ""
        txtprecio.Text = ""
        txtprecio1.Text = ""
        txtprecio2.Text = ""
        txtbusqueda.Focus()
        txtbusqueda.Text = ""
    End Sub
    Private Sub modifproductos_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
    

    End Sub
    Private Sub modifproductos_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        
        Me.Hide()
        e.Cancel = True
    End Sub


    Private Sub modifproductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If


        SellModeClient = False
        poblartablas(3, 0)
        limpiartablas()

        ' If we can initialize the Reader
        If (Scanning.InitReader()) Then

            ' Create a new delegate to handle scan notifications
            Me.ReaderFormEventHandler = New System.EventHandler(AddressOf MyReader_ReadNotify)

            ' Set the event handler of the Scanning class to our delegate
            Scanning.MyEventHandler = ReaderFormEventHandler

            ' Attach to activate and deactivate events
            AddHandler Me.Activated, New System.EventHandler(AddressOf modifproductos_Activated)

            ' Start a read on the reader
            Scanning.StartRead()

        Else
            ' If not, close this form

            ' Create a new delegate to handle scan notifications
            Me.ReaderFormEventHandler = New System.EventHandler(AddressOf MyReader_ReadNotify)

            ' Set the event handler of the Scanning class to our delegate
            Scanning.MyEventHandler = ReaderFormEventHandler

            ' Attach to activate and deactivate events
            AddHandler Me.Activated, New System.EventHandler(AddressOf modifproductos_Activated)

            ' Start a read on the reader
            Scanning.StartRead()

            Return

        End If
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.TextChanged
        If RadioButton1.Checked = True Then
            tablaquery.RowFilter = ("upc = '" & txtbusqueda.Text & "'")
        ElseIf RadioButton2.Checked = True Then
            tablaquery.RowFilter = ("descripcion LIKE '%" & txtbusqueda.Text & "%'")
        ElseIf txtbusqueda.Text = Nothing Then
            tablaquery.RowFilter = Nothing
        End If
    End Sub
  

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        txtdescripcion.Enabled = True
        txtprecio.Enabled = True
        txtprecio1.Enabled = True
        txtprecio2.Enabled = True
        modoedicion = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If modoedicion = True Then
            If txtupc.Text <> Nothing And txtdescripcion.Text <> Nothing And txtprecio.Text <> Nothing And txtprecio1.Text <> Nothing And txtprecio2.Text <> Nothing Then
                Try
                    cmd.Connection = conn
                    cmd.CommandText = "UPDATE productos SET upc = '" & txtupc.Text & "',descripcion = '" & UCase(txtdescripcion.Text) & "', precio='" & Val(txtprecio.Text) & "',precio1='" & Val(txtprecio1.Text) & "',precio2='" & Val(txtprecio2.Text) & "' WHERE codigo ='" & txtcodigo.Text & "'"
                    cmd.ExecuteNonQuery()
                    MsgBox("Producto modificado con exito!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Modificar Productos")
                    limpiartablas()
                    poblartablas(3, 0)
                    limpiarcampos()
                    modoedicion = False
                    txtupc.Enabled = False
                    txtdescripcion.Enabled = False
                    txtprecio.Enabled = False
                    txtprecio1.Enabled = False
                    txtprecio2.Enabled = False
                    txtbusqueda.Focus()
                Catch ex As SqlCeException
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error")
                End Try
            Else
                MsgBox("Los datos no están completos!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error")
            End If
        Else
            If txtdescripcion.Text <> Nothing And txtprecio.Text <> Nothing And txtprecio1.Text <> Nothing And txtprecio2.Text <> Nothing Then
                If MsgBox("Deseas agregar el producto?", MsgBoxStyle.OkCancel, "Productos") = MsgBoxResult.Ok Then
                    Try
                        Dim upc As String
                        If txtupc.Text = Nothing Then
                            upc = 0
                        Else
                            upc = txtupc.Text
                        End If
                        cmd.Connection = conn
                        cmd.CommandText = "INSERT INTO productos(upc,descripcion,precio,precio1,precio2) VALUES('" & upc & "','" & UCase(txtdescripcion.Text) & "','" & Val(txtprecio.Text) & "','" & Val(txtprecio1.Text) & "','" & Val(txtprecio2.Text) & "')"
                        cmd.ExecuteNonQuery()
                        MsgBox("Producto agregado con exito", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar Productos")
                        limpiartablas()
                        poblartablas(3, 0)
                        limpiarcampos()
                        modoedicion = False
                        txtupc.Enabled = False
                        txtdescripcion.Enabled = False
                        txtprecio.Enabled = False
                        txtprecio1.Enabled = False
                        txtprecio2.Enabled = False
                        txtbusqueda.Focus()
                    Catch excep As SqlCeException
                        MsgBox(excep.Message, MsgBoxStyle.OkOnly, "Error")
                    End Try
                End If
            Else
                MsgBox("Los datos no están completos!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error")
            End If
        End If
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click

        If MsgBox("Deseas eliminar el producto seleccionado?", MsgBoxStyle.YesNo, "Modificacion") = MsgBoxResult.Yes Then
            Try
                cmd.Connection = conn
                cmd.CommandText = "DELETE FROM productos WHERE codigo = '" & txtcodigo.Text & "' "
                cmd.ExecuteNonQuery()
                limpiartablas()
                poblartablas(3, 0)
                limpiarcampos()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            End Try

        End If

    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        limpiarcampos()
        modoedicion = False
        txtdescripcion.Enabled = True
        txtprecio.Enabled = True
        txtprecio1.Enabled = True
        txtprecio2.Enabled = True
        txtdescripcion.Text = Nothing
        txtprecio.Text = Nothing
        txtprecio1.Text = Nothing
        txtprecio2.Text = Nothing
        txtcodigo.Text = Nothing
        txtdescripcion.Focus()
    End Sub

    Private Sub txtcodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtupc.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtdescripcion.Focus()
        End If
    End Sub
    Private Sub txtdescripcion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdescripcion.KeyDown, txtdescripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtprecio.Focus()
        End If
    End Sub

    Private Sub txtprecio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtprecio.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtprecio1.Focus()
        End If
    End Sub

    Private Sub txtprecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprecio.KeyPress
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
    Private Sub txtprecio1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtprecio1.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtprecio2.Focus()
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            txtbusqueda.Text = Nothing
            chkboxupc.Checked = False
        End If
    End Sub

    Private Sub chkboxupc_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkboxupc.CheckStateChanged
        If chkboxupc.Checked = True Then
            RadioButton1.Checked = False
        End If
    End Sub
    Private Sub lstdescripcion_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstdescripcion.SelectedIndexChanged
        txtupc.Text = lstcodigo.Text
        txtcodigo.Text = lstdescripcion.SelectedValue
        txtdescripcion.Text = lstdescripcion.Text
        txtprecio.Text = lstprecio.Text
        txtprecio1.Text = lstprecio1.Text
        txtprecio2.Text = lstprecio2.Text
    End Sub

    Private Sub lstdescripcion_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstdescripcion.SelectedValueChanged

        lstcodigo.SelectedIndex = lstdescripcion.SelectedIndex
        lstprecio.SelectedIndex = lstdescripcion.SelectedIndex
        lstprecio1.SelectedIndex = lstdescripcion.SelectedIndex
        lstprecio2.SelectedIndex = lstdescripcion.SelectedIndex
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Scanning.StopRead()
        Scanning.TermReader()
        Dim principal As New principal
        principal.ShowDialog()
        Me.Close()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            txtbusqueda.Text = ""
            tablaquery.RowFilter = ("descripcion LIKE '%" & txtbusqueda.Text & "%'")
        End If
    End Sub
End Class