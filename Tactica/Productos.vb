Public Class Productos

    Private Sub ProductosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PruebademoDataSet)

    End Sub

    Private Sub Productos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PruebademoDataSet.ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.PruebademoDataSet.ventas)
        'TODO: esta línea de código carga datos en la tabla 'PruebademoDataSet.ventasitems' Puede moverla o quitarla según sea necesario.
        Me.VentasitemsTableAdapter.Fill(Me.PruebademoDataSet.ventasitems)
        'TODO: esta línea de código carga datos en la tabla 'PruebademoDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.PruebademoDataSet.productos)

    End Sub

    Private Sub BtnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click
        Principal.Show()
        Me.Close()

    End Sub

    Private Sub TBXFiltroArticulo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBXFiltroArticulo.KeyPress
        e.KeyChar = ChrW(Solo_Letras(e))
    End Sub

    Private Sub TBXFiltroArticulo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBXFiltroArticulo.TextChanged
        Dim vista As New DataView
        vista.Table = Me.PruebademoDataSet.productos

        vista.RowFilter = "Nombre LIKE'" & TBXFiltroArticulo.Text & "%'"
        Me.ProductosDataGridView.DataSource = vista
    End Sub

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        AgregarP.Show()

    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        'Me.StockRegistroBindingSource.RemoveCurrent()
        'preguntar si es vacio
        Dim Pregunta, fila, CodigoConsulta, filaI, filaV As Integer

        CodigoConsulta = Val(InputBox("ingrese El codigo de busqueda: "))
        fila = Me.ProductosBindingSource.Find("ID", CodigoConsulta)
        filaI = Me.VentasitemsBindingSource.Find("ID", Val(Me.ProductosBindingSource.Current("ID")))
        filaV = Me.VentasBindingSource.Find("ID", Val(Me.ProductosBindingSource.Current("ID")))

        If fila = -1 Then
            MsgBox("El Registro no se encuentra en los campos establecidos o debe igresar un valor numerico")
        Else
            If filaI = -1 Or filaV = -1 Then
                Me.ProductosBindingSource.Position = fila
                Pregunta = MsgBox("Desea Eliminar el archivo seleccionado?", 32 + 1, "Eliminar")
                If Pregunta = 1 Then
                    Me.ProductosBindingSource.RemoveCurrent()
                    Me.ProductosBindingSource.EndEdit()
                    Me.ProductosTableAdapter.Update(Me.PruebademoDataSet.productos)
                    Me.ProductosTableAdapter.Fill(Me.PruebademoDataSet.productos)
                    MsgBox("El Archivo fue eliminado con exito")
                End If
            Else
                MsgBox("Este producto no es posible eliminarlo porque pertenece a un registro, elimine los registros relacionados para poder eliminarlo")
            End If
        End If
    End Sub

    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        Me.ProductosBindingSource.EndEdit()
        Me.ProductosTableAdapter.Update(Me.PruebademoDataSet.productos)              'Guarda
        Me.ProductosTableAdapter.Fill(Me.PruebademoDataSet.productos)                'Actualiza
        'ProductoTableAdapter.Fill(Me.FerreteriaDataSet.Producto)
        MsgBox("El Archivo fue modificado exitosamente")

    End Sub
End Class