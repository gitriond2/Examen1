<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transacciones
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ClienteLabel As System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FechaCaptura = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnConcretar = New System.Windows.Forms.Button()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.TBXBusqueda = New System.Windows.Forms.TextBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.PruebademoDataSet = New Tactica.pruebademoDataSet()
        Me.VentasitemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentasitemsTableAdapter = New Tactica.pruebademoDataSetTableAdapters.ventasitemsTableAdapter()
        Me.TableAdapterManager = New Tactica.pruebademoDataSetTableAdapters.TableAdapterManager()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosTableAdapter = New Tactica.pruebademoDataSetTableAdapters.productosTableAdapter()
        Me.ProductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnAgregarProd = New System.Windows.Forms.Button()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New Tactica.pruebademoDataSetTableAdapters.clientesTableAdapter()
        Me.VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentasTableAdapter = New Tactica.pruebademoDataSetTableAdapters.ventasTableAdapter()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.VentasitemsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewVentas = New System.Windows.Forms.DataGridView()
        Me.IDVentaAux = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDProductoAux = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnitarioAux = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadAux = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioTotalAux = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteComboBox = New System.Windows.Forms.ComboBox()
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.BtnAgregarP = New System.Windows.Forms.Button()
        Me.BtnClean = New System.Windows.Forms.Button()
        ClienteLabel = New System.Windows.Forms.Label()
        CType(Me.PruebademoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasitemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasitemsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClienteLabel
        '
        ClienteLabel.AutoSize = True
        ClienteLabel.Location = New System.Drawing.Point(39, 267)
        ClienteLabel.Name = "ClienteLabel"
        ClienteLabel.Size = New System.Drawing.Size(42, 13)
        ClienteLabel.TabIndex = 51
        ClienteLabel.Text = "Cliente:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(574, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Fecha"
        '
        'FechaCaptura
        '
        Me.FechaCaptura.Location = New System.Drawing.Point(627, 221)
        Me.FechaCaptura.Name = "FechaCaptura"
        Me.FechaCaptura.Size = New System.Drawing.Size(200, 20)
        Me.FechaCaptura.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Producto"
        '
        'BtnConcretar
        '
        Me.BtnConcretar.Location = New System.Drawing.Point(577, 257)
        Me.BtnConcretar.Name = "BtnConcretar"
        Me.BtnConcretar.Size = New System.Drawing.Size(134, 23)
        Me.BtnConcretar.TabIndex = 35
        Me.BtnConcretar.Text = "Concretar Venta"
        Me.BtnConcretar.UseVisualStyleBackColor = True
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(800, 257)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(75, 23)
        Me.BtnVolver.TabIndex = 34
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'TBXBusqueda
        '
        Me.TBXBusqueda.Location = New System.Drawing.Point(96, 215)
        Me.TBXBusqueda.Name = "TBXBusqueda"
        Me.TBXBusqueda.Size = New System.Drawing.Size(131, 20)
        Me.TBXBusqueda.TabIndex = 33
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(264, 213)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 32
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'PruebademoDataSet
        '
        Me.PruebademoDataSet.DataSetName = "pruebademoDataSet"
        Me.PruebademoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VentasitemsBindingSource
        '
        Me.VentasitemsBindingSource.DataMember = "ventasitems"
        Me.VentasitemsBindingSource.DataSource = Me.PruebademoDataSet
        '
        'VentasitemsTableAdapter
        '
        Me.VentasitemsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.productosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Tactica.pruebademoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ventasitemsTableAdapter = Me.VentasitemsTableAdapter
        Me.TableAdapterManager.ventasTableAdapter = Nothing
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "productos"
        Me.ProductosBindingSource.DataSource = Me.PruebademoDataSet
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'ProductosDataGridView
        '
        Me.ProductosDataGridView.AllowUserToAddRows = False
        Me.ProductosDataGridView.AllowUserToDeleteRows = False
        Me.ProductosDataGridView.AutoGenerateColumns = False
        Me.ProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.ProductosDataGridView.DataSource = Me.ProductosBindingSource
        Me.ProductosDataGridView.Location = New System.Drawing.Point(30, 12)
        Me.ProductosDataGridView.Name = "ProductosDataGridView"
        Me.ProductosDataGridView.ReadOnly = True
        Me.ProductosDataGridView.Size = New System.Drawing.Size(244, 157)
        Me.ProductosDataGridView.TabIndex = 46
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Precio"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'BtnAgregarProd
        '
        Me.BtnAgregarProd.Location = New System.Drawing.Point(317, 47)
        Me.BtnAgregarProd.Name = "BtnAgregarProd"
        Me.BtnAgregarProd.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregarProd.TabIndex = 47
        Me.BtnAgregarProd.Text = "> Agregar"
        Me.BtnAgregarProd.UseVisualStyleBackColor = True
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        Me.ClientesBindingSource.DataSource = Me.PruebademoDataSet
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'VentasBindingSource
        '
        Me.VentasBindingSource.DataMember = "ventas"
        Me.VentasBindingSource.DataSource = Me.PruebademoDataSet
        '
        'VentasTableAdapter
        '
        Me.VentasTableAdapter.ClearBeforeFill = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(317, 86)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 50
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'VentasitemsBindingSource1
        '
        Me.VentasitemsBindingSource1.DataMember = "ventasitems"
        Me.VentasitemsBindingSource1.DataSource = Me.PruebademoDataSet
        '
        'DataGridViewVentas
        '
        Me.DataGridViewVentas.AllowUserToAddRows = False
        Me.DataGridViewVentas.AllowUserToDeleteRows = False
        Me.DataGridViewVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDVentaAux, Me.IDProductoAux, Me.PrecioUnitarioAux, Me.CantidadAux, Me.PrecioTotalAux})
        Me.DataGridViewVentas.Location = New System.Drawing.Point(431, 12)
        Me.DataGridViewVentas.Name = "DataGridViewVentas"
        Me.DataGridViewVentas.ReadOnly = True
        Me.DataGridViewVentas.Size = New System.Drawing.Size(488, 157)
        Me.DataGridViewVentas.TabIndex = 51
        '
        'IDVentaAux
        '
        Me.IDVentaAux.HeaderText = "IDVenta"
        Me.IDVentaAux.Name = "IDVentaAux"
        Me.IDVentaAux.ReadOnly = True
        Me.IDVentaAux.Visible = False
        '
        'IDProductoAux
        '
        Me.IDProductoAux.HeaderText = "IDProducto"
        Me.IDProductoAux.Name = "IDProductoAux"
        Me.IDProductoAux.ReadOnly = True
        Me.IDProductoAux.Width = 75
        '
        'PrecioUnitarioAux
        '
        Me.PrecioUnitarioAux.HeaderText = "PrecioUnitario"
        Me.PrecioUnitarioAux.Name = "PrecioUnitarioAux"
        Me.PrecioUnitarioAux.ReadOnly = True
        Me.PrecioUnitarioAux.Width = 126
        '
        'CantidadAux
        '
        Me.CantidadAux.HeaderText = "Cantidad"
        Me.CantidadAux.Name = "CantidadAux"
        Me.CantidadAux.ReadOnly = True
        '
        'PrecioTotalAux
        '
        Me.PrecioTotalAux.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PrecioTotalAux.HeaderText = "PrecioTotal"
        Me.PrecioTotalAux.Name = "PrecioTotalAux"
        Me.PrecioTotalAux.ReadOnly = True
        '
        'ClienteComboBox
        '
        Me.ClienteComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Cliente", True))
        Me.ClienteComboBox.DataSource = Me.ClientesBindingSource
        Me.ClienteComboBox.DisplayMember = "Cliente"
        Me.ClienteComboBox.FormattingEnabled = True
        Me.ClienteComboBox.Location = New System.Drawing.Point(96, 264)
        Me.ClienteComboBox.Name = "ClienteComboBox"
        Me.ClienteComboBox.Size = New System.Drawing.Size(131, 21)
        Me.ClienteComboBox.TabIndex = 52
        Me.ClienteComboBox.ValueMember = "Cliente"
        '
        'BtnClientes
        '
        Me.BtnClientes.Location = New System.Drawing.Point(264, 262)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(116, 23)
        Me.BtnClientes.TabIndex = 53
        Me.BtnClientes.Text = "Agregar Clientes"
        Me.BtnClientes.UseVisualStyleBackColor = True
        '
        'BtnAgregarP
        '
        Me.BtnAgregarP.Location = New System.Drawing.Point(366, 212)
        Me.BtnAgregarP.Name = "BtnAgregarP"
        Me.BtnAgregarP.Size = New System.Drawing.Size(110, 23)
        Me.BtnAgregarP.TabIndex = 54
        Me.BtnAgregarP.Text = "Agregar Producto"
        Me.BtnAgregarP.UseVisualStyleBackColor = True
        '
        'BtnClean
        '
        Me.BtnClean.Location = New System.Drawing.Point(317, 131)
        Me.BtnClean.Name = "BtnClean"
        Me.BtnClean.Size = New System.Drawing.Size(75, 23)
        Me.BtnClean.TabIndex = 55
        Me.BtnClean.Text = "Limpiar grilla"
        Me.BtnClean.UseVisualStyleBackColor = True
        '
        'Transacciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 331)
        Me.Controls.Add(Me.BtnClean)
        Me.Controls.Add(Me.BtnAgregarP)
        Me.Controls.Add(Me.BtnClientes)
        Me.Controls.Add(ClienteLabel)
        Me.Controls.Add(Me.ClienteComboBox)
        Me.Controls.Add(Me.DataGridViewVentas)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnAgregarProd)
        Me.Controls.Add(Me.ProductosDataGridView)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.FechaCaptura)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnConcretar)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.TBXBusqueda)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Name = "Transacciones"
        Me.Text = "Transacciones"
        CType(Me.PruebademoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasitemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasitemsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FechaCaptura As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnConcretar As System.Windows.Forms.Button
    Friend WithEvents BtnVolver As System.Windows.Forms.Button
    Friend WithEvents TBXBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents PruebademoDataSet As Tactica.pruebademoDataSet
    Friend WithEvents VentasitemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VentasitemsTableAdapter As Tactica.pruebademoDataSetTableAdapters.ventasitemsTableAdapter
    Friend WithEvents TableAdapterManager As Tactica.pruebademoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter As Tactica.pruebademoDataSetTableAdapters.productosTableAdapter
    Friend WithEvents ProductosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnAgregarProd As System.Windows.Forms.Button
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As Tactica.pruebademoDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents VentasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VentasTableAdapter As Tactica.pruebademoDataSetTableAdapters.ventasTableAdapter
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents VentasitemsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewVentas As System.Windows.Forms.DataGridView
    Friend WithEvents ClienteComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BtnClientes As System.Windows.Forms.Button
    Friend WithEvents IDVentaAux As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDProductoAux As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnitarioAux As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadAux As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioTotalAux As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnAgregarP As System.Windows.Forms.Button
    Friend WithEvents BtnClean As System.Windows.Forms.Button
End Class
