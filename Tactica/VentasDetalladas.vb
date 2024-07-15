Public Class VentasDetalladas

    Private Sub VentasBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.VentasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PruebademoDataSet)

    End Sub

    Private Sub VentasDetalladas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PruebademoDataSet.ventasitems' Puede moverla o quitarla según sea necesario.
        Me.VentasitemsTableAdapter.Fill(Me.PruebademoDataSet.ventasitems)
        'TODO: esta línea de código carga datos en la tabla 'PruebademoDataSet.ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.PruebademoDataSet.ventas)

    End Sub

    Private Sub BtnVolver_Click(sender As System.Object, e As System.EventArgs) Handles BtnVolver.Click
        Ventas.Show()
        Me.Close()

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TBXFiltro.TextChanged
        Dim vista As New DataView
        vista.Table = Me.PruebademoDataSet.ventasitems

        vista.RowFilter = "IDVenta LIKE'" & Val(TBXFiltro.Text) & "%'"
        Me.VentasitemsDataGridView.DataSource = vista
    End Sub
End Class