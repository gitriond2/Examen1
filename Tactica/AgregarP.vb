Public Class AgregarP

    Private Sub ProductosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PruebademoDataSet)

    End Sub

    Private Sub AgregarP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PruebademoDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.PruebademoDataSet.productos)
        Me.ProductosBindingSource.AddNew()

    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Me.ProductosBindingSource.EndEdit()
        Me.ProductosBindingSource.AddNew()
        Me.ProductosBindingSource.Current("Nombre") = NombreTextBox.Text
        Me.ProductosBindingSource.Current("Precio") = Val(PrecioTextBox.Text)
        Me.ProductosBindingSource.Current("Categoria") = CategoriaTextBox.Text
        
        'guardo los datos ingresados
        Me.TableAdapterManager.UpdateAll(Me.PruebademoDataSet)
        Me.ProductosTableAdapter.Fill(Me.PruebademoDataSet.productos)
        Productos.ProductosTableAdapter.Fill(Productos.PruebademoDataSet.productos)
        MsgBox("El archivo se guardo con exito. ") 'podrias mostrar el nro de articulo

        Me.ProductosBindingSource.AddNew()
        NombreTextBox.Focus()
    End Sub

    Private Sub BtnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click
        Me.Close()
    End Sub
End Class