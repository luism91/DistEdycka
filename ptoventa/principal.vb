Imports System.Windows.Forms
Public Class principal
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Application.Exit()
    End Sub

    Private Sub btnventas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnventas.Click
        Dim ventas As New ventas
        ventas.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btncorte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncorte.Click
        Dim corte As New corte
        corte.ShowDialog()
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim modifproductos As New modifproductos
        modifproductos.ShowDialog()
        Me.Close()
    End Sub
    Private Sub principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = Date.Today
    End Sub
    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Clientes As New clientes
        Clientes.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        generarrespaldo()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim Carga As New Carga
        Carga.ShowDialog()
        Me.Close()
    End Sub
End Class
