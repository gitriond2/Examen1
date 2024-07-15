Public Class AgregarC

    Private Sub ClientesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PruebademoDataSet)

    End Sub

    Private Sub AgregarC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PruebademoDataSet.clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.PruebademoDataSet.clientes)
        Me.ClientesBindingSource.AddNew()

        
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub BtnAgregarC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregarC.Click
        Me.ClientesBindingSource.EndEdit()

        Me.ClientesBindingSource.Current("Cliente") = ClienteTextBox.Text
        Me.ClientesBindingSource.Current("Correo") = CorreoTextBox.Text
        Me.ClientesBindingSource.Current("Telefono") = Val(TelefonoTextBox.Text)


        'guardo los datos ingresados
        Me.TableAdapterManager.UpdateAll(Me.PruebademoDataSet)
        Me.ClientesTableAdapter.Fill(Me.PruebademoDataSet.clientes)
        Clientes.ClientesTableAdapter.Fill(Clientes.PruebademoDataSet.clientes)
        ClienteTextBox.Text = ""
        TelefonoTextBox.Text = ""
        CorreoTextBox.Text = ""


        MsgBox("El Cliente se guardo con exito. ") 'podrias mostrar el dni o el nombre del cliente
        Me.ClientesBindingSource.AddNew()
        ClienteTextBox.Focus()

    End Sub
End Class