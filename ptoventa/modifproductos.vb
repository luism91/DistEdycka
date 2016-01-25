Imports System.Data.SqlClient
Imports System.Data.SqlServerCe
Imports System
Imports System.Data
Public Class modifproductos
    Dim tablaquery As New DataView
    Dim tprod As New DataTable
    Dim modoedicion As Boolean
    Public Sub limpiarcampos()
        txtupc.Text = ""
        txtdescripcion.Text = ""
        txtprecio.Text = ""
        txtprecio1.Text = ""
        txtprecio2.Text = ""
        txtbusqueda.Focus()
        txtbusqueda.Text = ""
    End Sub
    Private Sub modifproductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        poblartablas(3, 0)

        tablaquery.Table = dsprod.Tables("productos2")

        lstdescripcion.DataSource = tablaquery
        lstdescripcion.DisplayMember = "descripcion"

        lstprecio.DataSource = tablaquery
        lstprecio.DisplayMember = "precio"

        lstprecio1.DataSource = tablaquery
        lstprecio1.DisplayMember = "precio1"

        lstprecio2.DataSource = tablaquery
        lstprecio2.DisplayMember = "precio2"

        lstcodigo.DataSource = tablaquery
        lstcodigo.DisplayMember = "upc"

        lstid.DataSource = tablaquery
        lstid.DisplayMember = "codigo"

    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.TextChanged
        If RadioButton1.Checked = True Then
            tablaquery.RowFilter = ("upc = '%" & txtbusqueda.Text & "'")
        ElseIf RadioButton2.Checked = True Then
            tablaquery.RowFilter = ("descripcion LIKE '%" & txtbusqueda.Text & "%'")
        End If
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Dim principal As New principal
        principal.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtupc.Text = lstcodigo.Text
        txtupc.Enabled = True
        txtcodigo.Text = lstid.Text
        txtdescripcion.Text = lstdescripcion.Text
        txtprecio.Text = lstprecio.Text
        txtprecio1.Text = lstprecio1.Text
        txtprecio2.Text = lstprecio2.Text
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
                    poblartablas(3, 0)
                    limpiarcampos()
                    modoedicion = False
                    txtupc.Enabled = False
                Catch ex As SqlCeException
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error")
                End Try
            Else
                MsgBox("Los datos no están completos!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error")
            End If
        Else
            If txtupc.Text <> Nothing And txtdescripcion.Text <> Nothing And txtprecio.Text <> Nothing And txtprecio1.Text <> Nothing And txtprecio2.Text <> Nothing Then
                If MsgBox("Deseas agregar el producto?", MsgBoxStyle.OkCancel, "Productos") = MsgBoxResult.Ok Then
                    Try
                        cmd.Connection = conn
                        cmd.CommandText = "INSERT INTO productos(upc,descripcion,precio,precio1,precio2) VALUES('" & txtupc.Text & "','" & UCase(txtdescripcion.Text) & "','" & Val(txtprecio.Text) & "',,'" & Val(txtprecio1.Text) & "',,'" & Val(txtprecio2.Text) & "')"
                        cmd.ExecuteNonQuery()
                        MsgBox("Producto agregado con exito", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar Productos")
                        poblartablas(3, 0)
                        txtupc.Enabled = False
                        limpiarcampos()
                        modoedicion = False
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

        If MsgBox("Deseas eliminar el producto seleccionado?", MsgBoxStyle.OkCancel, "Modificacion") = MsgBoxResult.Ok Then
            Try
                cmd.Connection = conn
                cmd.CommandText = "DELETE FROM productos WHERE codigo = '" & lstcodigo.Text & "' "
                cmd.ExecuteNonQuery()
                poblartablas(3, 0)
                limpiarcampos()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            End Try

        End If

    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click 
        limpiarcampos()
        txtupc.Enabled = True
        txtupc.Focus()
        modoedicion = False
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

    Private Sub lstdescripcion_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstdescripcion.SelectedIndexChanged
        txtupc.Text = lstcodigo.Text
        txtcodigo.Text = lstid.Text
        txtdescripcion.Text = lstdescripcion.Text
        txtprecio.Text = lstprecio.Text
        txtprecio1.Text = lstprecio1.Text
        txtprecio2.Text = lstprecio2.Text
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged

    End Sub
End Class