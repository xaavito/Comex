<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarOperaciones
    Inherits Comex.BaseForm

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumeroOperacionLabel = New System.Windows.Forms.Label()
        Me.ProveedorComboBox = New Comex.MyComboBox()
        Me.OperacionesDataGrid = New Comex.MyDataGrid()
        Me.EliminarOperacionButton = New Comex.MyButton()
        Me.ModificarOperacionButton = New Comex.MyButton()
        Me.BuscarOperacionButton = New Comex.MyButton()
        Me.AltaOperacionButton = New Comex.MyButton()
        Me.NumeroOperacionTextBox = New Comex.MyTextBox()
        Me.IdentificadorColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroOperacionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoOperacionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProveedorColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoTotalColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.OperacionesDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Proveedor"
        '
        'NumeroOperacionLabel
        '
        Me.NumeroOperacionLabel.AutoSize = True
        Me.NumeroOperacionLabel.Location = New System.Drawing.Point(26, 23)
        Me.NumeroOperacionLabel.Name = "NumeroOperacionLabel"
        Me.NumeroOperacionLabel.Size = New System.Drawing.Size(96, 13)
        Me.NumeroOperacionLabel.TabIndex = 50
        Me.NumeroOperacionLabel.Text = "Numero Operacion"
        '
        'ProveedorComboBox
        '
        Me.ProveedorComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ProveedorComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ProveedorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ProveedorComboBox.emptyItem = Nothing
        Me.ProveedorComboBox.FormattingEnabled = True
        Me.ProveedorComboBox.lista = Nothing
        Me.ProveedorComboBox.Location = New System.Drawing.Point(128, 47)
        Me.ProveedorComboBox.Name = "ProveedorComboBox"
        Me.ProveedorComboBox.Size = New System.Drawing.Size(205, 21)
        Me.ProveedorComboBox.TabIndex = 49
        '
        'OperacionesDataGrid
        '
        Me.OperacionesDataGrid.AllowUserToAddRows = False
        Me.OperacionesDataGrid.AllowUserToDeleteRows = False
        Me.OperacionesDataGrid.AllowUserToResizeRows = False
        Me.OperacionesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.OperacionesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OperacionesDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdentificadorColumn, Me.NroOperacionColumn, Me.TipoOperacionColumn, Me.ProveedorColumn, Me.MontoTotalColumn})
        Me.OperacionesDataGrid.Location = New System.Drawing.Point(29, 96)
        Me.OperacionesDataGrid.Name = "OperacionesDataGrid"
        Me.OperacionesDataGrid.ReadOnly = True
        Me.OperacionesDataGrid.RowHeadersVisible = False
        Me.OperacionesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.OperacionesDataGrid.Size = New System.Drawing.Size(757, 237)
        Me.OperacionesDataGrid.TabIndex = 44
        '
        'EliminarOperacionButton
        '
        Me.EliminarOperacionButton.Image = Global.Comex.My.Resources.Resources.basura
        Me.EliminarOperacionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EliminarOperacionButton.Location = New System.Drawing.Point(809, 259)
        Me.EliminarOperacionButton.Name = "EliminarOperacionButton"
        Me.EliminarOperacionButton.Size = New System.Drawing.Size(75, 23)
        Me.EliminarOperacionButton.TabIndex = 46
        Me.EliminarOperacionButton.Text = "Eliminar"
        Me.EliminarOperacionButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EliminarOperacionButton.UseVisualStyleBackColor = True
        '
        'ModificarOperacionButton
        '
        Me.ModificarOperacionButton.Image = Global.Comex.My.Resources.Resources.editar
        Me.ModificarOperacionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ModificarOperacionButton.Location = New System.Drawing.Point(809, 198)
        Me.ModificarOperacionButton.Name = "ModificarOperacionButton"
        Me.ModificarOperacionButton.Size = New System.Drawing.Size(75, 23)
        Me.ModificarOperacionButton.TabIndex = 45
        Me.ModificarOperacionButton.Text = "Modificar"
        Me.ModificarOperacionButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ModificarOperacionButton.UseVisualStyleBackColor = True
        '
        'BuscarOperacionButton
        '
        Me.BuscarOperacionButton.Image = Global.Comex.My.Resources.Resources.buscar
        Me.BuscarOperacionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BuscarOperacionButton.Location = New System.Drawing.Point(809, 40)
        Me.BuscarOperacionButton.Name = "BuscarOperacionButton"
        Me.BuscarOperacionButton.Size = New System.Drawing.Size(75, 23)
        Me.BuscarOperacionButton.TabIndex = 43
        Me.BuscarOperacionButton.Text = "Buscar"
        Me.BuscarOperacionButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BuscarOperacionButton.UseVisualStyleBackColor = True
        '
        'AltaOperacionButton
        '
        Me.AltaOperacionButton.Image = Global.Comex.My.Resources.Resources.aceptar
        Me.AltaOperacionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AltaOperacionButton.Location = New System.Drawing.Point(809, 144)
        Me.AltaOperacionButton.Name = "AltaOperacionButton"
        Me.AltaOperacionButton.Size = New System.Drawing.Size(75, 23)
        Me.AltaOperacionButton.TabIndex = 52
        Me.AltaOperacionButton.Text = "Generar"
        Me.AltaOperacionButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AltaOperacionButton.UseVisualStyleBackColor = True
        '
        'NumeroOperacionTextBox
        '
        Me.NumeroOperacionTextBox.alfanumerico = False
        Me.NumeroOperacionTextBox.boton = Nothing
        Me.NumeroOperacionTextBox.Location = New System.Drawing.Point(128, 20)
        Me.NumeroOperacionTextBox.mail = False
        Me.NumeroOperacionTextBox.nada = False
        Me.NumeroOperacionTextBox.Name = "NumeroOperacionTextBox"
        Me.NumeroOperacionTextBox.numerico = False
        Me.NumeroOperacionTextBox.sinEspacio = False
        Me.NumeroOperacionTextBox.Size = New System.Drawing.Size(205, 20)
        Me.NumeroOperacionTextBox.TabIndex = 53
        Me.NumeroOperacionTextBox.texto = False
        '
        'IdentificadorColumn
        '
        Me.IdentificadorColumn.DataPropertyName = "identificador"
        Me.IdentificadorColumn.HeaderText = "Identificador"
        Me.IdentificadorColumn.Name = "IdentificadorColumn"
        Me.IdentificadorColumn.ReadOnly = True
        Me.IdentificadorColumn.Visible = False
        '
        'NroOperacionColumn
        '
        Me.NroOperacionColumn.DataPropertyName = "nroOperacion"
        Me.NroOperacionColumn.HeaderText = "Nro Operacion"
        Me.NroOperacionColumn.Name = "NroOperacionColumn"
        Me.NroOperacionColumn.ReadOnly = True
        '
        'TipoOperacionColumn
        '
        Me.TipoOperacionColumn.DataPropertyName = "tipoOperacion"
        Me.TipoOperacionColumn.HeaderText = "Tipo Operacion"
        Me.TipoOperacionColumn.Name = "TipoOperacionColumn"
        Me.TipoOperacionColumn.ReadOnly = True
        '
        'ProveedorColumn
        '
        Me.ProveedorColumn.DataPropertyName = "proveedor"
        Me.ProveedorColumn.HeaderText = "Proveedor"
        Me.ProveedorColumn.Name = "ProveedorColumn"
        Me.ProveedorColumn.ReadOnly = True
        '
        'MontoTotalColumn
        '
        Me.MontoTotalColumn.DataPropertyName = "montoTotal"
        Me.MontoTotalColumn.HeaderText = "MontoTotal"
        Me.MontoTotalColumn.Name = "MontoTotalColumn"
        Me.MontoTotalColumn.ReadOnly = True
        '
        'BuscarOperaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(916, 393)
        Me.Controls.Add(Me.NumeroOperacionTextBox)
        Me.Controls.Add(Me.AltaOperacionButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NumeroOperacionLabel)
        Me.Controls.Add(Me.ProveedorComboBox)
        Me.Controls.Add(Me.EliminarOperacionButton)
        Me.Controls.Add(Me.ModificarOperacionButton)
        Me.Controls.Add(Me.OperacionesDataGrid)
        Me.Controls.Add(Me.BuscarOperacionButton)
        Me.Name = "BuscarOperaciones"
        Me.Text = "Operaciones"
        CType(Me.OperacionesDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents NumeroOperacionLabel As Label
    Friend WithEvents ProveedorComboBox As MyComboBox
    Friend WithEvents EliminarOperacionButton As MyButton
    Friend WithEvents ModificarOperacionButton As MyButton
    Friend WithEvents OperacionesDataGrid As MyDataGrid
    Friend WithEvents BuscarOperacionButton As MyButton
    Friend WithEvents AltaOperacionButton As MyButton
    Friend WithEvents NumeroOperacionTextBox As MyTextBox
    Friend WithEvents IdentificadorColumn As DataGridViewTextBoxColumn
    Friend WithEvents NroOperacionColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoOperacionColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProveedorColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontoTotalColumn As DataGridViewTextBoxColumn
End Class
