Imports System.Data
Imports System.Data.SqlServerCe
Public Class clientes

    Dim modoedicion As Boolean
    Private Sub limpiarcampos()
        txtcodigo.Text = ""
        txtnombre.Text = ""
        txtlocalidad.Text = ""
        cmbdiaruta.SelectedIndex = 0
        txtbusqueda.Focus()
        txtbusqueda.Text = ""
    End Sub
    Private Sub clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        poblartablas(4, 0)
        lstnombre.DataSource = tablaclientes
        lstnombre.DisplayMember = "nombrecliente"

        lstcodigo.DataSource = tablaclientes
        lstcodigo.DisplayMember = "codigocliente"

        lstlocalidad.DataSource = tablaclientes
        lstlocalidad.DisplayMember = "localidad"

        lstdiaruta.DataSource = tablaclientes
        lstdiaruta.DisplayMember = "grupocliente"

    End Sub

    Private Sub txtbusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.TextChanged
        tablaclientes.RowFilter = ("nombrecliente LIKE '%" & txtbusqueda.Text & "%'")
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneditar.Click
        modoedicion = True
        txtcodigo.Text = lstcodigo.Text
        txtnombre.Text = lstnombre.Text
        txtlocalidad.Text = lstlocalidad.Text
        cmbdiaruta.SelectedIndex = CInt(lstdiaruta.Text) - 1

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click

        If modoedicion = True Then
            Try
                If cmbdiaruta.SelectedIndex > 0 And txtnombre.Text <> Nothing And txtlocalidad.Text <> Nothing Then
                    cmd.Connection = conn
                    cmd.CommandText = "UPDATE clientes SET nombrecliente= '" & UCase(txtnombre.Text) & "',localidad='" & UCase(txtlocalidad.Text) & "',grupocliente= " & cmbdiaruta.SelectedIndex + 1 & "   WHERE codigocliente ='" & txtcodigo.Text & "'"
                    cmd.ExecuteNonQuery()
                    MsgBox("Cliente modificado con exito!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Modificar Clientes")
                    poblartablas(4, 0)
                    limpiarcampos()
                    modoedicion = False
                Else
                    MsgBox("Debes llenar todos los campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informacion clientes")
                End If
            Catch ex As SqlCeException
                MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error")
            End Try
        Else
            If MsgBox("Deseas agregar el CLIENTE?", MsgBoxStyle.OkCancel, "Clientes") = MsgBoxResult.Ok Then
                Try
                    If cmbdiaruta.SelectedIndex > 0 And txtnombre.Text <> Nothing And txtlocalidad.Text <> Nothing Then
                        cmd.Connection = conn
                        cmd.CommandText = "INSERT INTO clientes(nombrecliente,grupocliente,localidad) VALUES('" & UCase(txtnombre.Text) & "'," & cmbdiaruta.SelectedIndex + 1 & ",'" & UCase(txtlocalidad.Text) & "')"
                        cmd.ExecuteNonQuery()
                        MsgBox("CLIENTE agregado con exito", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar Productos")
                        limpiarcampos()
                        poblartablas(4, 0)
                        modoedicion = False
                    Else
                        MsgBox("Debes llenar todos los campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informacion clientes")
                    End If
                Catch excep As SqlCeException
                    MsgBox(excep.Message, MsgBoxStyle.OkOnly, "Error")
                End Try
            End If
        End If
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click

        If MsgBox("Deseas eliminar el CLIENTE: '" & lstnombre.Text & "'?", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Modificacion") = MsgBoxResult.Ok Then
            Try
                cmd.Connection = conn
                cmd.CommandText = "DELETE FROM clientes WHERE codigocliente = '" & lstcodigo.Text & "'"
                cmd.ExecuteNonQuery()
                poblartablas(4, 0)
                limpiarcampos()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            End Try
        End If

    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click

        limpiarcampos()
        txtnombre.Focus()
        modoedicion = False
    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Dim principal As New principal
        principal.ShowDialog()
        Me.Close()
    End Sub
End Class