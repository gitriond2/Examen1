Public Class Clientes

    Private Sub ClientesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PruebademoDataSet)

    End Sub

    Private Sub Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PruebademoDataSet.ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.PruebademoDataSet.ventas)
        'TODO: esta línea de código carga datos en la tabla 'PruebademoDataSet.ventasitems' Puede moverla o quitarla según sea necesario.
        Me.VentasitemsTableAdapter.Fill(Me.PruebademoDataSet.ventasitems)
        'TODO: esta línea de código carga datos en la tabla 'PruebademoDataSet.clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.PruebademoDataSet.clientes)



    End Sub

    Private Sub BtnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click
        Principal.Show()
        Me.Close()

    End Sub

    Private Sub TbxBusquedaClientes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxBusquedaClientes.TextChanged
        'Dim vista As New DataView
        'vista.Table = Me.PruebademoDataSet.clientes

        'vista.RowFilter = "Cliente LIKE'" & TbxBusquedaClientes.Text & "%'"
        'Me.ClientesDataGridView.DataSource = vista
    End Sub

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        AgregarC.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.ClientesBindingSource.EndEdit()
        Me.ClientesTableAdapter.Update(Me.PruebademoDataSet.clientes)              'Guarda
        Me.ClientesTableAdapter.Fill(Me.PruebademoDataSet.clientes)                'Actualiza
        'ProductoTableAdapter.Fill(Me.FerreteriaDataSet.Producto)
        MsgBox("El Archivo fue modificado exitosamente")
    End Sub

    Private Sub BtnBuscarClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscarClientes.Click
        Dim fila As Integer
        fila = Val(Me.ClientesBindingSource.Find("Cliente", TbxBusquedaClientes.Text))

        If fila = -1 Then
            MsgBox("El Registro no se encuentra en los campos establecidos o no agrego un valor numerico")
        Else
            Me.ClientesBindingSource.Position = fila

        End If
    End Sub

    
    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        'Me.StockRegistroBindingSource.RemoveCurrent()
        'preguntar si es vacio
        Dim Pregunta, fila, CodigoConsulta, filaI, filaV As Integer

        CodigoConsulta = Val(InputBox("ingrese El Nombre de Cliente: "))
        fila = Me.ClientesBindingSource.Find("ID", CodigoConsulta)
        filaI = Me.VentasitemsBindingSource.Find("ID", Val(Me.ClientesBindingSource.Current("ID")))
        filaV = Me.VentasBindingSource.Find("ID", Val(Me.ClientesBindingSource.Current("ID")))

        If fila = -1 Then
            MsgBox("El Registro no se encuentra en los campos establecidos o debe igresar un valor numerico")
        Else
            If filaI = -1 Or filaV = -1 Then
                Me.ClientesBindingSource.Position = fila
                Pregunta = MsgBox("Desea Eliminar el archivo seleccionado?", 32 + 1, "Eliminar")
                If Pregunta = 1 Then
                    Me.ClientesBindingSource.RemoveCurrent()
                    Me.ClientesBindingSource.EndEdit()
                    Me.ClientesTableAdapter.Update(Me.PruebademoDataSet.clientes)

                    Me.ClientesTableAdapter.Fill(Me.PruebademoDataSet.clientes)
                    MsgBox("El Archivo fue eliminado con exito")

                End If
            Else
                MsgBox("Este producto no es posible eliminarlo porque pertenece a un registro, elimine los registros relacionados para poder eliminarlo")
            End If
            

            End If
    End Sub

    Private Sub ClientesDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ClientesDataGridView.CellContentClick
        'Dim fila As Integer
        'fila = ProductoDataGridView.CurrentCellAddress.Y
        'Transaccion.TBXBusqueda.Text = ProductoDataGridView.Item(0, fila).Value()      'pega el seleccionado en otro formulario
        'Transaccion.TbxCantidad.Focus()                                              ' hace focus al siguiente del otro formulario
        'Transaccion.Show()                                                           'abre el formulario de ventas
        'Me.Close()                                                              'cierro el actual

    End Sub
End Class