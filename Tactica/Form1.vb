Public Class Form1

    Private Sub ClientesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PruebademoDataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PruebademoDataSet.ventasitems' Puede moverla o quitarla según sea necesario.
        Me.VentasitemsTableAdapter.Fill(Me.PruebademoDataSet.ventasitems)
        'TODO: esta línea de código carga datos en la tabla 'PruebademoDataSet.ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.PruebademoDataSet.ventas)
        'TODO: esta línea de código carga datos en la tabla 'PruebademoDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.PruebademoDataSet.productos)
        'TODO: esta línea de código carga datos en la tabla 'PruebademoDataSet.clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.PruebademoDataSet.clientes)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Principal.Show()
        Me.Close()

    End Sub
End Class
