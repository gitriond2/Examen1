Public Class Ventas

    Private Sub VentasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.VentasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PruebademoDataSet)

    End Sub

    Private Sub Ventas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PruebademoDataSet.ventasitems' Puede moverla o quitarla según sea necesario.
        Me.VentasitemsTableAdapter.Fill(Me.PruebademoDataSet.ventasitems)
        'TODO: esta línea de código carga datos en la tabla 'PruebademoDataSet.ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.PruebademoDataSet.ventas)

    End Sub

    Private Sub BtnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click
        Principal.Show()
        Me.Close()

    End Sub

    Private Sub BtnVender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVender.Click
        Transacciones.Show()
        Me.Close()

    End Sub

    Private Sub TBXFiltro_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TBXFiltro.KeyPress
        e.KeyChar = ChrW(Solo_Numeros(e))
        If e.KeyChar = Chr(13) Then             ' para saber si apreto enter que hacer...
            BtnBuscar.Focus()
        End If
    End Sub

    Private Sub TBXFiltro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBXFiltro.TextChanged
        'Dim vista As New DataView
        'vista.Table = Me.PruebademoDataSet.ventas

        'vista.RowFilter = "IDCliente LIKE'" & Val(TBXFiltro.Text) & "%'"
        'Me.VentasDataGridView.DataSource = vista
    End Sub

    Private Sub BtnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles BtnBuscar.Click
        Dim fila As Integer
        'If TBXFiltro.Text <> "" Or IsNumeric(TBXFiltro.Text) Then
        If TBXFiltro.Text = "" Then
            MsgBox("debe ingresar un valor")
        Else

            fila = Val(Me.VentasBindingSource.Find("ID", Val(TBXFiltro.Text)))

            If fila = -1 Then
                MsgBox("El Registro no se encuentra en los campos establecidos")
            Else
                Me.VentasBindingSource.Position = fila

            End If
        End If

        'PosProduc = Me.ProductosBindingSource.Current("Nombre").ToString
        'filaC = Me.ProductosBindingSource.Find("Cliente", PosProduc)
        'filaC = Me.ClientesBindingSource.Find("ID", IDClienteComboBox.Text)

        'PosProduc = Me.ProductosBindingSource.Current("Nombre").ToString
        'fila = Me.ProductosBindingSource.Find("Nombre", PosProduc)
        'Me.ProductosBindingSource.Position = fila
    End Sub

    Private Sub BtnEliminarVentas_Click(sender As System.Object, e As System.EventArgs) Handles BtnEliminarVentas.Click

        'Me.StockRegistroBindingSource.RemoveCurrent()
        'preguntar si es vacio
        Dim filaV, FilaI, Pregunta As Integer

        filaV = Me.VentasBindingSource.Find("ID", Val(Me.VentasBindingSource.Current("ID")))                    'corregir puede que de mal
        FilaI = Me.VentasitemsBindingSource.Find("ID", Val(Me.VentasBindingSource.Current("ID")))

        If filaV = -1 Then
            MsgBox("El Registro no se encuentra en los campos establecidos o debe igresar un valor numerico")
        Else
            Me.VentasBindingSource.Position = filaV                                   'para la base de datos inicia en 0
            Me.VentasitemsBindingSource.Position = FilaI
            Pregunta = MsgBox("Desea Eliminar el archivo seleccionado?", 32 + 1, "Eliminar")
            If Pregunta = 1 Then

                Me.VentasitemsBindingSource.RemoveCurrent()
                Me.VentasitemsBindingSource.EndEdit()

                Me.VentasBindingSource.RemoveCurrent()
                Me.VentasBindingSource.EndEdit()

                Me.VentasitemsTableAdapter.Update(Me.PruebademoDataSet.ventasitems)
                Me.VentasTableAdapter.Update(Me.PruebademoDataSet.ventas)

                Me.VentasitemsTableAdapter.Fill(Me.PruebademoDataSet.ventasitems)
                Me.VentasTableAdapter.Fill(Me.PruebademoDataSet.ventas)

                MsgBox("El Archivo fue eliminado con exito")

            End If

        End If
        'Dim i, j, b As Integer

        'For i = 1 To CantidadR
        '    If UCase(RTrim(Agenda(i).nombre)) = UCase(RTrim(TextBoxEliminar.Text)) Then
        '        TextBoxNombre2.Text = Agenda(i).nombre
        '        TextBoxApellido2.Text = Agenda(i).apellido
        '        TextBoxEdad2.Text = Agenda(i).edad
        '        b = MsgBox("Quiere Eliminar el Registro: " + TextBoxEliminar.Text, 32 + 1, "Eliminar")
        '        If b = 1 Then
        '            CantidadR = CantidadR - 1
        '            For j = 1 To CantidadR
        '                Agenda(j).nombre = Agenda(j + 1).nombre
        '                Agenda(j).apellido = Agenda(j + 1).apellido
        '                Agenda(j).edad = Agenda(j + 1).edad
        '            Next
        '            TextBoxNombre2.Text = ""
        '            TextBoxApellido2.Text = ""
        '            TextBoxEdad2.Text = ""
        '            TextBoxEliminar.Text = ""
        '            MsgBox("El Registro Se ha Eliminado.")
        '        End If
        '    End If
        'Next
    End Sub

    Private Sub BusqPart_Click(sender As System.Object, e As System.EventArgs) Handles BusqPart.Click
        VentasDetalladas.Show()
        Me.Close()

    End Sub
End Class