﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarCompradorForm
    Inherits Comex.BaseForm

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarCompradorForm))
        Me.DptoLabel = New System.Windows.Forms.Label()
        Me.DptoTextBox = New Comex.MyTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TelefonoTextBox = New Comex.MyTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CodPostTextBox = New Comex.MyTextBox()
        Me.PisoLabel = New System.Windows.Forms.Label()
        Me.PisoTextBox = New Comex.MyTextBox()
        Me.NumeroLabel = New System.Windows.Forms.Label()
        Me.NumeroTextBox = New Comex.MyTextBox()
        Me.QuitarPreferenciaButton = New Comex.MyButton()
        Me.AgregarPreferenciaButton = New Comex.MyButton()
        Me.PreferenciaDataGrid = New Comex.MyDataGrid()
        Me.Identificador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreferenciasLabel = New System.Windows.Forms.Label()
        Me.PreferenciaComboBox = New Comex.MyComboBox()
        Me.DireccionLabel = New System.Windows.Forms.Label()
        Me.DireccionTextBox = New Comex.MyTextBox()
        Me.MailLabel = New System.Windows.Forms.Label()
        Me.MailTextBox = New Comex.MyTextBox()
        Me.ApellidoLabel = New System.Windows.Forms.Label()
        Me.ApellidoTextBox = New Comex.MyTextBox()
        Me.NombreLabel = New System.Windows.Forms.Label()
        Me.NombreTextBox = New Comex.MyTextBox()
        Me.GenerarCompradorButton = New Comex.MyButton()
        CType(Me.PreferenciaDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DptoLabel
        '
        Me.DptoLabel.AutoSize = True
        Me.DptoLabel.Location = New System.Drawing.Point(25, 172)
        Me.DptoLabel.Name = "DptoLabel"
        Me.DptoLabel.Size = New System.Drawing.Size(30, 13)
        Me.DptoLabel.TabIndex = 66
        Me.DptoLabel.Text = "Dpto"
        '
        'DptoTextBox
        '
        Me.DptoTextBox.alfanumerico = False
        Me.DptoTextBox.boton = Nothing
        Me.DptoTextBox.Location = New System.Drawing.Point(106, 169)
        Me.DptoTextBox.nada = False
        Me.DptoTextBox.Name = "DptoTextBox"
        Me.DptoTextBox.numerico = False
        Me.DptoTextBox.sinEspacio = False
        Me.DptoTextBox.Size = New System.Drawing.Size(140, 20)
        Me.DptoTextBox.TabIndex = 65
        Me.DptoTextBox.texto = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Telefono"
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.alfanumerico = False
        Me.TelefonoTextBox.boton = Nothing
        Me.TelefonoTextBox.Location = New System.Drawing.Point(106, 221)
        Me.TelefonoTextBox.nada = False
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.numerico = False
        Me.TelefonoTextBox.sinEspacio = False
        Me.TelefonoTextBox.Size = New System.Drawing.Size(140, 20)
        Me.TelefonoTextBox.TabIndex = 63
        Me.TelefonoTextBox.texto = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Codigo Postal"
        '
        'CodPostTextBox
        '
        Me.CodPostTextBox.alfanumerico = False
        Me.CodPostTextBox.boton = Nothing
        Me.CodPostTextBox.Location = New System.Drawing.Point(106, 195)
        Me.CodPostTextBox.nada = False
        Me.CodPostTextBox.Name = "CodPostTextBox"
        Me.CodPostTextBox.numerico = False
        Me.CodPostTextBox.sinEspacio = False
        Me.CodPostTextBox.Size = New System.Drawing.Size(140, 20)
        Me.CodPostTextBox.TabIndex = 61
        Me.CodPostTextBox.texto = False
        '
        'PisoLabel
        '
        Me.PisoLabel.AutoSize = True
        Me.PisoLabel.Location = New System.Drawing.Point(25, 146)
        Me.PisoLabel.Name = "PisoLabel"
        Me.PisoLabel.Size = New System.Drawing.Size(27, 13)
        Me.PisoLabel.TabIndex = 60
        Me.PisoLabel.Text = "Piso"
        '
        'PisoTextBox
        '
        Me.PisoTextBox.alfanumerico = False
        Me.PisoTextBox.boton = Nothing
        Me.PisoTextBox.Location = New System.Drawing.Point(106, 143)
        Me.PisoTextBox.nada = False
        Me.PisoTextBox.Name = "PisoTextBox"
        Me.PisoTextBox.numerico = False
        Me.PisoTextBox.sinEspacio = False
        Me.PisoTextBox.Size = New System.Drawing.Size(140, 20)
        Me.PisoTextBox.TabIndex = 59
        Me.PisoTextBox.texto = False
        '
        'NumeroLabel
        '
        Me.NumeroLabel.AutoSize = True
        Me.NumeroLabel.Location = New System.Drawing.Point(25, 120)
        Me.NumeroLabel.Name = "NumeroLabel"
        Me.NumeroLabel.Size = New System.Drawing.Size(44, 13)
        Me.NumeroLabel.TabIndex = 58
        Me.NumeroLabel.Text = "Numero"
        '
        'NumeroTextBox
        '
        Me.NumeroTextBox.alfanumerico = False
        Me.NumeroTextBox.boton = Nothing
        Me.NumeroTextBox.Location = New System.Drawing.Point(106, 117)
        Me.NumeroTextBox.nada = False
        Me.NumeroTextBox.Name = "NumeroTextBox"
        Me.NumeroTextBox.numerico = False
        Me.NumeroTextBox.sinEspacio = False
        Me.NumeroTextBox.Size = New System.Drawing.Size(140, 20)
        Me.NumeroTextBox.TabIndex = 57
        Me.NumeroTextBox.texto = False
        '
        'QuitarPreferenciaButton
        '
        Me.QuitarPreferenciaButton.Image = CType(resources.GetObject("QuitarPreferenciaButton.Image"), System.Drawing.Image)
        Me.QuitarPreferenciaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.QuitarPreferenciaButton.Location = New System.Drawing.Point(259, 224)
        Me.QuitarPreferenciaButton.Name = "QuitarPreferenciaButton"
        Me.QuitarPreferenciaButton.Size = New System.Drawing.Size(75, 23)
        Me.QuitarPreferenciaButton.TabIndex = 56
        Me.QuitarPreferenciaButton.Text = "Quitar"
        Me.QuitarPreferenciaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.QuitarPreferenciaButton.UseVisualStyleBackColor = True
        '
        'AgregarPreferenciaButton
        '
        Me.AgregarPreferenciaButton.Image = CType(resources.GetObject("AgregarPreferenciaButton.Image"), System.Drawing.Image)
        Me.AgregarPreferenciaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AgregarPreferenciaButton.Location = New System.Drawing.Point(259, 192)
        Me.AgregarPreferenciaButton.Name = "AgregarPreferenciaButton"
        Me.AgregarPreferenciaButton.Size = New System.Drawing.Size(75, 23)
        Me.AgregarPreferenciaButton.TabIndex = 55
        Me.AgregarPreferenciaButton.Text = "Agregar"
        Me.AgregarPreferenciaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AgregarPreferenciaButton.UseVisualStyleBackColor = True
        '
        'PreferenciaDataGrid
        '
        Me.PreferenciaDataGrid.AllowUserToAddRows = False
        Me.PreferenciaDataGrid.AllowUserToDeleteRows = False
        Me.PreferenciaDataGrid.AllowUserToResizeRows = False
        Me.PreferenciaDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.PreferenciaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PreferenciaDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Identificador, Me.DescripcionColumn})
        Me.PreferenciaDataGrid.Location = New System.Drawing.Point(340, 116)
        Me.PreferenciaDataGrid.MultiSelect = False
        Me.PreferenciaDataGrid.Name = "PreferenciaDataGrid"
        Me.PreferenciaDataGrid.ReadOnly = True
        Me.PreferenciaDataGrid.RowHeadersVisible = False
        Me.PreferenciaDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PreferenciaDataGrid.Size = New System.Drawing.Size(218, 152)
        Me.PreferenciaDataGrid.TabIndex = 54
        '
        'Identificador
        '
        Me.Identificador.HeaderText = "Identificador"
        Me.Identificador.Name = "Identificador"
        Me.Identificador.ReadOnly = True
        Me.Identificador.Visible = False
        '
        'DescripcionColumn
        '
        Me.DescripcionColumn.DataPropertyName = "descripcion"
        Me.DescripcionColumn.HeaderText = "Descripcion"
        Me.DescripcionColumn.Name = "DescripcionColumn"
        Me.DescripcionColumn.ReadOnly = True
        '
        'PreferenciasLabel
        '
        Me.PreferenciasLabel.AutoSize = True
        Me.PreferenciasLabel.Location = New System.Drawing.Point(25, 250)
        Me.PreferenciasLabel.Name = "PreferenciasLabel"
        Me.PreferenciasLabel.Size = New System.Drawing.Size(66, 13)
        Me.PreferenciasLabel.TabIndex = 53
        Me.PreferenciasLabel.Text = "Preferencias"
        '
        'PreferenciaComboBox
        '
        Me.PreferenciaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PreferenciaComboBox.emptyItem = Nothing
        Me.PreferenciaComboBox.FormattingEnabled = True
        Me.PreferenciaComboBox.lista = Nothing
        Me.PreferenciaComboBox.Location = New System.Drawing.Point(106, 247)
        Me.PreferenciaComboBox.Name = "PreferenciaComboBox"
        Me.PreferenciaComboBox.Size = New System.Drawing.Size(140, 21)
        Me.PreferenciaComboBox.TabIndex = 52
        '
        'DireccionLabel
        '
        Me.DireccionLabel.AutoSize = True
        Me.DireccionLabel.Location = New System.Drawing.Point(25, 92)
        Me.DireccionLabel.Name = "DireccionLabel"
        Me.DireccionLabel.Size = New System.Drawing.Size(52, 13)
        Me.DireccionLabel.TabIndex = 51
        Me.DireccionLabel.Text = "Direccion"
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.alfanumerico = False
        Me.DireccionTextBox.boton = Nothing
        Me.DireccionTextBox.Location = New System.Drawing.Point(106, 89)
        Me.DireccionTextBox.nada = False
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.numerico = False
        Me.DireccionTextBox.sinEspacio = False
        Me.DireccionTextBox.Size = New System.Drawing.Size(140, 20)
        Me.DireccionTextBox.TabIndex = 50
        Me.DireccionTextBox.texto = False
        '
        'MailLabel
        '
        Me.MailLabel.AutoSize = True
        Me.MailLabel.Location = New System.Drawing.Point(25, 66)
        Me.MailLabel.Name = "MailLabel"
        Me.MailLabel.Size = New System.Drawing.Size(26, 13)
        Me.MailLabel.TabIndex = 49
        Me.MailLabel.Text = "Mail"
        '
        'MailTextBox
        '
        Me.MailTextBox.alfanumerico = False
        Me.MailTextBox.boton = Nothing
        Me.MailTextBox.Location = New System.Drawing.Point(106, 63)
        Me.MailTextBox.nada = False
        Me.MailTextBox.Name = "MailTextBox"
        Me.MailTextBox.numerico = False
        Me.MailTextBox.sinEspacio = False
        Me.MailTextBox.Size = New System.Drawing.Size(140, 20)
        Me.MailTextBox.TabIndex = 48
        Me.MailTextBox.texto = False
        '
        'ApellidoLabel
        '
        Me.ApellidoLabel.AutoSize = True
        Me.ApellidoLabel.Location = New System.Drawing.Point(25, 40)
        Me.ApellidoLabel.Name = "ApellidoLabel"
        Me.ApellidoLabel.Size = New System.Drawing.Size(44, 13)
        Me.ApellidoLabel.TabIndex = 47
        Me.ApellidoLabel.Text = "Apellido"
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.alfanumerico = False
        Me.ApellidoTextBox.boton = Nothing
        Me.ApellidoTextBox.Location = New System.Drawing.Point(106, 37)
        Me.ApellidoTextBox.nada = False
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.numerico = False
        Me.ApellidoTextBox.sinEspacio = False
        Me.ApellidoTextBox.Size = New System.Drawing.Size(140, 20)
        Me.ApellidoTextBox.TabIndex = 46
        Me.ApellidoTextBox.texto = False
        '
        'NombreLabel
        '
        Me.NombreLabel.AutoSize = True
        Me.NombreLabel.Location = New System.Drawing.Point(25, 14)
        Me.NombreLabel.Name = "NombreLabel"
        Me.NombreLabel.Size = New System.Drawing.Size(44, 13)
        Me.NombreLabel.TabIndex = 45
        Me.NombreLabel.Text = "Nombre"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.alfanumerico = False
        Me.NombreTextBox.boton = Nothing
        Me.NombreTextBox.Location = New System.Drawing.Point(106, 11)
        Me.NombreTextBox.nada = False
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.numerico = False
        Me.NombreTextBox.sinEspacio = False
        Me.NombreTextBox.Size = New System.Drawing.Size(140, 20)
        Me.NombreTextBox.TabIndex = 44
        Me.NombreTextBox.texto = False
        '
        'GenerarCompradorButton
        '
        Me.GenerarCompradorButton.Image = CType(resources.GetObject("GenerarCompradorButton.Image"), System.Drawing.Image)
        Me.GenerarCompradorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GenerarCompradorButton.Location = New System.Drawing.Point(587, 9)
        Me.GenerarCompradorButton.Name = "GenerarCompradorButton"
        Me.GenerarCompradorButton.Size = New System.Drawing.Size(75, 23)
        Me.GenerarCompradorButton.TabIndex = 43
        Me.GenerarCompradorButton.Text = "Generar"
        Me.GenerarCompradorButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.GenerarCompradorButton.UseVisualStyleBackColor = True
        '
        'ModificarCompradorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(686, 280)
        Me.Controls.Add(Me.DptoLabel)
        Me.Controls.Add(Me.DptoTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CodPostTextBox)
        Me.Controls.Add(Me.PisoLabel)
        Me.Controls.Add(Me.PisoTextBox)
        Me.Controls.Add(Me.NumeroLabel)
        Me.Controls.Add(Me.NumeroTextBox)
        Me.Controls.Add(Me.QuitarPreferenciaButton)
        Me.Controls.Add(Me.AgregarPreferenciaButton)
        Me.Controls.Add(Me.PreferenciaDataGrid)
        Me.Controls.Add(Me.PreferenciasLabel)
        Me.Controls.Add(Me.PreferenciaComboBox)
        Me.Controls.Add(Me.DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(Me.MailLabel)
        Me.Controls.Add(Me.MailTextBox)
        Me.Controls.Add(Me.ApellidoLabel)
        Me.Controls.Add(Me.ApellidoTextBox)
        Me.Controls.Add(Me.NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.GenerarCompradorButton)
        Me.Name = "ModificarCompradorForm"
        Me.Text = "Modificar Comprador"
        CType(Me.PreferenciaDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DptoLabel As System.Windows.Forms.Label
    Friend WithEvents DptoTextBox As Comex.MyTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TelefonoTextBox As Comex.MyTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CodPostTextBox As Comex.MyTextBox
    Friend WithEvents PisoLabel As System.Windows.Forms.Label
    Friend WithEvents PisoTextBox As Comex.MyTextBox
    Friend WithEvents NumeroLabel As System.Windows.Forms.Label
    Friend WithEvents NumeroTextBox As Comex.MyTextBox
    Friend WithEvents QuitarPreferenciaButton As Comex.MyButton
    Friend WithEvents AgregarPreferenciaButton As Comex.MyButton
    Friend WithEvents PreferenciaDataGrid As Comex.MyDataGrid
    Friend WithEvents PreferenciasLabel As System.Windows.Forms.Label
    Friend WithEvents PreferenciaComboBox As Comex.MyComboBox
    Friend WithEvents DireccionLabel As System.Windows.Forms.Label
    Friend WithEvents DireccionTextBox As Comex.MyTextBox
    Friend WithEvents MailLabel As System.Windows.Forms.Label
    Friend WithEvents MailTextBox As Comex.MyTextBox
    Friend WithEvents ApellidoLabel As System.Windows.Forms.Label
    Friend WithEvents ApellidoTextBox As Comex.MyTextBox
    Friend WithEvents NombreLabel As System.Windows.Forms.Label
    Friend WithEvents NombreTextBox As Comex.MyTextBox
    Friend WithEvents GenerarCompradorButton As Comex.MyButton
    Friend WithEvents Identificador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
