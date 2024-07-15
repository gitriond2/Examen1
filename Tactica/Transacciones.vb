


Public Class Transacciones
    Dim registroSel = 0
    Dim n = 0



    Private Sub VentasitemsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.VentasitemsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PruebademoDataSet)

    End Sub

    Private Sub Transacciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PruebademoDataSet.ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.PruebademoDataSet.ventas)
        'TODO: esta línea de código carga datos en la tabla 'PruebademoDataSet.clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.PruebademoDataSet.clientes)
        'TODO: esta línea de código carga datos en la tabla 'PruebademoDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.PruebademoDataSet.productos)
        'TODO: esta línea de código carga datos en la tabla 'PruebademoDataSet.ventasitems' Puede moverla o quitarla según sea necesario.
        Me.VentasitemsTableAdapter.Fill(Me.PruebademoDataSet.ventasitems)

    End Sub

    Private Sub BtnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click
        Ventas.Show()
        Me.Close()

    End Sub

    Private Sub BtnAgregarProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregarProd.Click
        'Realizar for i j para recorrer la matriz
        Dim filaP, filaV, Pregunta, ConsultaCant, AddF, PosFV As Integer
        Dim PosProduc As String

        PosProduc = Me.ProductosBindingSource.Current("Nombre").ToString
        filaP = Me.ProductosBindingSource.Find("Nombre", PosProduc)
        'filaC = Me.ClientesBindingSource.Find("Cliente", ClienteComboBox.Text)
        AddF = Me.DataGridViewVentas.RowCount()
        filaV = Me.VentasBindingSource.Count + 1


        If filaP = -1 Then
            MsgBox("No se encontro el Producto")
        Else
            'lo encontro
                Pregunta = MsgBox("Quiere agregar este producto? ", 32 + 1, "Vender")
                If Pregunta = 1 Then
                ConsultaCant = Val(InputBox("Cantidad que desea Vender: "))
                If ConsultaCant <= 0 Then                                                   'preguntar si es vacio
                    MsgBox("ingrese un valor correspondiente numerico mayor que 0, e intentelo nuevamente")
                Else
                    'inicia  la carga de datos en la grilla
                    DataGridViewVentas.RowCount = AddF + 1                               ' este es el add new en grilla agrega una fila
                    PosFV = AddF + filaV
                    DataGridViewVentas(0, AddF).Value = PosFV
                    DataGridViewVentas(1, AddF).Value = filaP + 1
                    DataGridViewVentas(2, AddF).Value = Val(Me.ProductosBindingSource.Current("Precio"))
                    DataGridViewVentas(3, AddF).Value = ConsultaCant
                    DataGridViewVentas(4, AddF).Value = ConsultaCant * DataGridViewVentas(2, AddF).Value

                    MsgBox("Se Ha guardado con Exito")

                End If
                    
                End If
        End If


        '-------------------------------------------------------------------actividad anterior-----------------------------------------------------------------------------------------------
        'Dim filaP, filaC, Pregunta, ConsultaCant As Integer
        'Dim PosProduc As String


        'PosProduc = Me.ProductosBindingSource.Current("Nombre").ToString                       '' obtengo el posicionado y lo guardo en una variable
        'filaP = Me.ProductosBindingSource.Find("Cliente", PosProduc)                           ''obtengo el numero de fila  comparando la variable

        'filaC = Me.ClientesBindingSource.Find("Cliente", IDClienteComboBox.Text)

        'If filaP = -1 Then
        '    MsgBox("No se encontro")
        'Else
        '    'lo encontro
        '    Me.ProductosBindingSource.Position = filaP
        '    Pregunta = MsgBox("Quiere agregar este producto? ", 32 + 1, "Vender")
        '    If Pregunta = 1 Then
        '        ConsultaCant = InputBox("Cantidad que desea Vender: ")
        '        If 20 >= ConsultaCant Then                    ' hacer la pregunta de cantidad stock
        '            Me.VentasitemsBindingSource.AddNew()
        '            Me.VentasitemsBindingSource.Current("IDVenta") = filaC
        '            Me.VentasitemsBindingSource.Current("IDProducto") = filaP + 1
        '            Me.VentasitemsBindingSource.Current("PrecioUnitario") = Val(Me.ProductosBindingSource.Current("Precio"))
        '            Me.VentasitemsBindingSource.Current("Cantidad") = ConsultaCant
        '            Me.VentasitemsBindingSource.Current("PrecioTotal") = ConsultaCant * Me.VentasitemsBindingSource.Current("PrecioUnitario")

        '            ''MsgBox("La venta ha sido exitosa el importe es: " & importe & " Pesos")

        '            Me.VentasitemsBindingSource.EndEdit()

        '            Me.TableAdapterManager.UpdateAll(Me.PruebademoDataSet)
        '            Me.VentasitemsTableAdapter.Fill(Me.PruebademoDataSet.ventasitems)


        '        Else
        '            MsgBox("No hay suficiente stock" & Me.ProductosBindingSource.Current("Cantidad") & "Unidades")
        '        End If
        '    End If


        'End If


    End Sub


    Private Sub BtnConcretar_Click(sender As System.Object, e As System.EventArgs) Handles BtnConcretar.Click
        'CantMax = DataGridViewVentas.RowCount                              'obtengo la cantidad de filas creadas en la grilla    
        'DataGridViewVentas.Rows.Clear()            'Limpiar el datagridview
        Dim Pregunta, i, filas, filaV, filaC, importe As Integer


        filas = Me.DataGridViewVentas.RowCount()
        filaC = Me.ClientesBindingSource.Find("Cliente", ClienteComboBox.Text)
        'filaC = Me.VentasBindingSource.Find("ID", Val(Me.VentasBindingSource.Current("ID")))                       fijarse que el ID cuando eliminas de bien
        Pregunta = MsgBox("Quiere realizar esta venta ", 32 + 1, "Vender")
        If Pregunta = 1 Then
            For i = 0 To filas - 1                      'recorre la fila y despues va por columnas
                'tabla de ventasitems
                'DGV(j, i).Value = Valorquequieras
                Me.VentasBindingSource.AddNew()
                Me.VentasBindingSource.Current("IDCliente") = filaC + 1
                Me.VentasBindingSource.Current("Fecha") = FechaCaptura.Value
                Me.VentasBindingSource.Current("Total") = DataGridViewVentas(4, i).Value

            Next
            Me.VentasBindingSource.EndEdit()
            Me.VentasTableAdapter.Update(Me.PruebademoDataSet.ventas)
            Me.VentasTableAdapter.Fill(Me.PruebademoDataSet.ventas)
            filaV = Me.VentasBindingSource.Count - filas + 1

            For i = 0 To filas - 1
                Me.VentasitemsBindingSource.AddNew()
                Me.VentasitemsBindingSource.Current("IDVenta") = filaV                                             'recuperar ID de la tabla ventas y pega
                Me.VentasitemsBindingSource.Current("IDProducto") = Val(DataGridViewVentas(1, i).Value)
                Me.VentasitemsBindingSource.Current("PrecioUnitario") = Val(DataGridViewVentas(2, i).Value)
                Me.VentasitemsBindingSource.Current("Cantidad") = Val(DataGridViewVentas(3, i).Value)
                Me.VentasitemsBindingSource.Current("PrecioTotal") = Val(DataGridViewVentas(4, i).Value)
                importe = DataGridViewVentas(4, i).Value + importe
                filaV = filaV + 1
            Next


            Me.VentasitemsBindingSource.EndEdit()
            'Me.TableAdapterManager.UpdateAll(Me.PruebademoDataSet)
            Me.VentasitemsTableAdapter.Update(Me.PruebademoDataSet.ventasitems)
            Me.VentasTableAdapter.Fill(Me.PruebademoDataSet.ventas)
            Me.VentasitemsTableAdapter.Fill(Me.PruebademoDataSet.ventasitems)

            MsgBox("La venta ha sido exitosa el importe es: " & importe & " Pesos")


            ''tabla de venta-------------------------

            'Me.VentasBindingSource.EndEdit()
            'Me.VentasTableAdapter.Update(Me.PruebademoDataSet.ventas)
            ''cierro y guardo la tabla venta
            ''tabla stock-----------------------------
            ''Me.ProductoBindingSource.Current("Cantidad") = Me.ProductoBindingSource.Current("Cantidad") - Val(TbxCantidad.Text)
            
            'MsgBox("La venta ha sido exitosa el importe es: " & Me.VentasitemsBindingSource.Current("PrecioTotal") & " Pesos")
            ''guardo todo y actualizo las tablas
            'Me.TableAdapterManager.UpdateAll(Me.PruebademoDataSet)                  'guardo todo en la base de datos
            'Ventas.VentasTableAdapter.Fill(Ventas.PruebademoDataSet.ventas)         'actualizo el data set del principal
            ''            Me.VentasitemsBindingSource.EndEdit()

            ''            Me.TableAdapterManager.UpdateAll(Me.PruebademoDataSet)
            ''            Me.VentasitemsTableAdapter.Fill(Me.PruebademoDataSet.ventasitems)

            'Me.VentasitemsTableAdapter.Fill(Me.PruebademoDataSet.ventasitems)
            'Me.VentasTableAdapter.Fill(Me.PruebademoDataSet.ventas)

            ''Limpio txtbox------------------------------------------------------------
            TBXBusqueda.Focus()
            TBXBusqueda.Text = ""



        End If




    End Sub

    Private Sub BtnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles BtnBuscar.Click
        Dim fila As Integer

        fila = Me.ProductosBindingSource.Find("Nombre", TBXBusqueda.Text)
        'agregar consulta de ingreso de valores
        'If CodigoConsulta <> "" And IsNumeric(CodigoConsulta) Then
        If fila = -1 Then
            MsgBox("El Registro no se encuentra en los campos establecidos")
        Else
            Me.ProductosBindingSource.Position = fila
            ClienteComboBox.Focus()

        End If
        'e.KeyChar = ChrW(Solo_Letras(e))
        'If e.KeyChar = Chr(13) Then             ' para saber si apreto enter que hacer...
        '    CbxDistrito.Focus()
        'End If
    End Sub



    Private Sub CbxEmpleado_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub
    Private Sub DataGridViewVentas_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewVentas.CellClick

        n = DataGridViewVentas.Rows.Count - 1                   'da posicion de filas en el data grid view
        registroSel = e.RowIndex                                'da el seleccionado e

    End Sub

    Private Sub BtnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles BtnEliminar.Click
        'eliminar a la tabla grid view
        Dim i, j As Integer
        n = DataGridViewVentas.Rows.Count                    'da posicion de filas en el data grid view
        j = Me.VentasitemsBindingSource.Count + 1

        If registroSel <> -1 And registroSel > n Then
            MsgBox("parametro mal indicado")
        Else
            DataGridViewVentas.Rows.RemoveAt(registroSel)
            For i = 0 To n - 2
                DataGridViewVentas(0, i).Value = j
                j = j + 1
            Next

        End If


        'anterior eliminar-------------------------------------------------------------------------------------------------------------------------------------------------------
        ''Me.StockRegistroBindingSource.RemoveCurrent()
        ''preguntar si es vacio
        'Dim fila, Pregunta, FilaID As Integer

        'FilaID = Val(Me.VentasitemsBindingSource.Current("ID"))



        'If fila = -1 Then
        '    MsgBox("El Registro no se encuentra en los campos establecidos o debe igresar un valor numerico")
        'Else
        '    Me.VentasitemsBindingSource.Position = FilaID - 1                                   'para la base de datos inicia en 0
        '    Pregunta = MsgBox("Desea Eliminar el archivo seleccionado?", 32 + 1, "Eliminar")
        '    If Pregunta = 1 Then
        '        Me.VentasitemsBindingSource.RemoveCurrent()
        '        Me.VentasitemsBindingSource.EndEdit()
        '        Me.VentasitemsTableAdapter.Update(Me.PruebademoDataSet.ventasitems)

        '        Me.VentasitemsTableAdapter.Fill(Me.PruebademoDataSet.ventasitems)
        '        MsgBox("El Archivo fue eliminado con exito")

        '    End If

        'End If
    End Sub

    

    Private Sub BtnClientes_Click(sender As System.Object, e As System.EventArgs) Handles BtnClientes.Click
        AgregarC.Show()

    End Sub

    Private Sub BtnAgregarP_Click(sender As System.Object, e As System.EventArgs) Handles BtnAgregarP.Click
        AgregarP.Show()
    End Sub

    Private Sub BtnClean_Click(sender As System.Object, e As System.EventArgs) Handles BtnClean.Click
        DataGridViewVentas.Rows.Clear()           'Limpiar el datagridview
    End Sub
End Class