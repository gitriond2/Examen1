
Public Class Principal

    Private Sub BtnArticulos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnArticulos.Click
        Productos.Show()
        Me.Hide()
    End Sub

    Private Sub BtnVender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVender.Click
        Ventas.Show()
        Me.Hide()
    End Sub

    Private Sub BtnClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClientes.Click
        Clientes.Show()
        Me.Hide()
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub



    Private Sub ConcretarVentaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConcretarVentaToolStripMenuItem.Click
        Transacciones.Show()
        Me.Hide()

    End Sub
End Class