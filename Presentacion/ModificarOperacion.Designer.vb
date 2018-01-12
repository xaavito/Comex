<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarOperacion
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
        Me.CompradorGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumeroCompradorTextBox = New Comex.MyTextBox()
        Me.NombreLabel = New System.Windows.Forms.Label()
        Me.ApellidoLabel = New System.Windows.Forms.Label()
        Me.CompradoresComboBox = New Comex.MyComboBox()
        Me.ApellidoTextBox = New Comex.MyTextBox()
        Me.NombreTextBox = New Comex.MyTextBox()
        Me.NuevoCompradorButton = New Comex.MyButton()
        Me.BuscarCompradorButton = New Comex.MyButton()
        Me.ShowGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FechaComboBox = New Comex.MyComboBox()
        Me.ShowLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BuscarShowButton = New Comex.MyButton()
        Me.ShowComboBox = New Comex.MyComboBox()
        Me.ShowTextBox = New Comex.MyTextBox()
        Me.CompradorGroupBox.SuspendLayout()
        Me.ShowGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'CompradorGroupBox
        '
        Me.CompradorGroupBox.Controls.Add(Me.Label1)
        Me.CompradorGroupBox.Controls.Add(Me.NumeroCompradorTextBox)
        Me.CompradorGroupBox.Controls.Add(Me.NombreLabel)
        Me.CompradorGroupBox.Controls.Add(Me.NuevoCompradorButton)
        Me.CompradorGroupBox.Controls.Add(Me.BuscarCompradorButton)
        Me.CompradorGroupBox.Controls.Add(Me.ApellidoLabel)
        Me.CompradorGroupBox.Controls.Add(Me.CompradoresComboBox)
        Me.CompradorGroupBox.Controls.Add(Me.ApellidoTextBox)
        Me.CompradorGroupBox.Controls.Add(Me.NombreTextBox)
        Me.CompradorGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.CompradorGroupBox.Name = "CompradorGroupBox"
        Me.CompradorGroupBox.Size = New System.Drawing.Size(861, 70)
        Me.CompradorGroupBox.TabIndex = 7
        Me.CompradorGroupBox.TabStop = False
        Me.CompradorGroupBox.Text = "Comprador"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(183, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "N° Comprador"
        '
        'NumeroCompradorTextBox
        '
        Me.NumeroCompradorTextBox.alfanumerico = False
        Me.NumeroCompradorTextBox.boton = Nothing
        Me.NumeroCompradorTextBox.Location = New System.Drawing.Point(267, 15)
        Me.NumeroCompradorTextBox.mail = False
        Me.NumeroCompradorTextBox.nada = False
        Me.NumeroCompradorTextBox.Name = "NumeroCompradorTextBox"
        Me.NumeroCompradorTextBox.numerico = False
        Me.NumeroCompradorTextBox.sinEspacio = False
        Me.NumeroCompradorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NumeroCompradorTextBox.TabIndex = 8
        Me.NumeroCompradorTextBox.texto = False
        '
        'NombreLabel
        '
        Me.NombreLabel.AutoSize = True
        Me.NombreLabel.Location = New System.Drawing.Point(8, 48)
        Me.NombreLabel.Name = "NombreLabel"
        Me.NombreLabel.Size = New System.Drawing.Size(44, 13)
        Me.NombreLabel.TabIndex = 6
        Me.NombreLabel.Text = "Nombre"
        '
        'ApellidoLabel
        '
        Me.ApellidoLabel.AutoSize = True
        Me.ApellidoLabel.Location = New System.Drawing.Point(8, 18)
        Me.ApellidoLabel.Name = "ApellidoLabel"
        Me.ApellidoLabel.Size = New System.Drawing.Size(44, 13)
        Me.ApellidoLabel.TabIndex = 1
        Me.ApellidoLabel.Text = "Apellido"
        '
        'CompradoresComboBox
        '
        Me.CompradoresComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CompradoresComboBox.emptyItem = Nothing
        Me.CompradoresComboBox.FormattingEnabled = True
        Me.CompradoresComboBox.lista = Nothing
        Me.CompradoresComboBox.Location = New System.Drawing.Point(428, 15)
        Me.CompradoresComboBox.Name = "CompradoresComboBox"
        Me.CompradoresComboBox.Size = New System.Drawing.Size(205, 21)
        Me.CompradoresComboBox.TabIndex = 4
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.alfanumerico = False
        Me.ApellidoTextBox.boton = Nothing
        Me.ApellidoTextBox.Location = New System.Drawing.Point(81, 15)
        Me.ApellidoTextBox.mail = False
        Me.ApellidoTextBox.nada = False
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.numerico = False
        Me.ApellidoTextBox.sinEspacio = False
        Me.ApellidoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ApellidoTextBox.TabIndex = 2
        Me.ApellidoTextBox.texto = False
        '
        'NombreTextBox
        '
        Me.NombreTextBox.alfanumerico = False
        Me.NombreTextBox.boton = Nothing
        Me.NombreTextBox.Location = New System.Drawing.Point(81, 45)
        Me.NombreTextBox.mail = False
        Me.NombreTextBox.nada = False
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.numerico = False
        Me.NombreTextBox.sinEspacio = False
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 3
        Me.NombreTextBox.texto = False
        '
        'NuevoCompradorButton
        '
        Me.NuevoCompradorButton.Image = Global.Comex.My.Resources.Resources.nuevo
        Me.NuevoCompradorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NuevoCompradorButton.Location = New System.Drawing.Point(675, 10)
        Me.NuevoCompradorButton.Name = "NuevoCompradorButton"
        Me.NuevoCompradorButton.Size = New System.Drawing.Size(75, 23)
        Me.NuevoCompradorButton.TabIndex = 0
        Me.NuevoCompradorButton.Text = "Nuevo"
        Me.NuevoCompradorButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NuevoCompradorButton.UseVisualStyleBackColor = True
        '
        'BuscarCompradorButton
        '
        Me.BuscarCompradorButton.Image = Global.Comex.My.Resources.Resources.buscar
        Me.BuscarCompradorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BuscarCompradorButton.Location = New System.Drawing.Point(276, 43)
        Me.BuscarCompradorButton.Name = "BuscarCompradorButton"
        Me.BuscarCompradorButton.Size = New System.Drawing.Size(75, 23)
        Me.BuscarCompradorButton.TabIndex = 5
        Me.BuscarCompradorButton.Text = "Buscar"
        Me.BuscarCompradorButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BuscarCompradorButton.UseVisualStyleBackColor = True
        '
        'ShowGroupBox
        '
        Me.ShowGroupBox.Controls.Add(Me.Label4)
        Me.ShowGroupBox.Controls.Add(Me.Label2)
        Me.ShowGroupBox.Controls.Add(Me.FechaComboBox)
        Me.ShowGroupBox.Controls.Add(Me.ShowLabel)
        Me.ShowGroupBox.Controls.Add(Me.Label3)
        Me.ShowGroupBox.Controls.Add(Me.BuscarShowButton)
        Me.ShowGroupBox.Controls.Add(Me.ShowComboBox)
        Me.ShowGroupBox.Controls.Add(Me.ShowTextBox)
        Me.ShowGroupBox.Location = New System.Drawing.Point(12, 88)
        Me.ShowGroupBox.Name = "ShowGroupBox"
        Me.ShowGroupBox.Size = New System.Drawing.Size(861, 104)
        Me.ShowGroupBox.TabIndex = 10
        Me.ShowGroupBox.TabStop = False
        Me.ShowGroupBox.Text = "Show"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(372, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(372, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 9
        '
        'FechaComboBox
        '
        Me.FechaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FechaComboBox.emptyItem = Nothing
        Me.FechaComboBox.FormattingEnabled = True
        Me.FechaComboBox.lista = Nothing
        Me.FechaComboBox.Location = New System.Drawing.Point(428, 57)
        Me.FechaComboBox.Name = "FechaComboBox"
        Me.FechaComboBox.Size = New System.Drawing.Size(205, 21)
        Me.FechaComboBox.TabIndex = 8
        '
        'ShowLabel
        '
        Me.ShowLabel.AutoSize = True
        Me.ShowLabel.Location = New System.Drawing.Point(372, 22)
        Me.ShowLabel.Name = "ShowLabel"
        Me.ShowLabel.Size = New System.Drawing.Size(34, 13)
        Me.ShowLabel.TabIndex = 7
        Me.ShowLabel.Text = "Show"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nombre"
        '
        'BuscarShowButton
        '
        Me.BuscarShowButton.Image = Global.Comex.My.Resources.Resources.buscar
        Me.BuscarShowButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BuscarShowButton.Location = New System.Drawing.Point(276, 19)
        Me.BuscarShowButton.Name = "BuscarShowButton"
        Me.BuscarShowButton.Size = New System.Drawing.Size(75, 23)
        Me.BuscarShowButton.TabIndex = 5
        Me.BuscarShowButton.Text = "Buscar"
        Me.BuscarShowButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BuscarShowButton.UseVisualStyleBackColor = True
        '
        'ShowComboBox
        '
        Me.ShowComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ShowComboBox.emptyItem = Nothing
        Me.ShowComboBox.FormattingEnabled = True
        Me.ShowComboBox.lista = Nothing
        Me.ShowComboBox.Location = New System.Drawing.Point(428, 19)
        Me.ShowComboBox.Name = "ShowComboBox"
        Me.ShowComboBox.Size = New System.Drawing.Size(205, 21)
        Me.ShowComboBox.TabIndex = 4
        '
        'ShowTextBox
        '
        Me.ShowTextBox.alfanumerico = False
        Me.ShowTextBox.boton = Nothing
        Me.ShowTextBox.Location = New System.Drawing.Point(81, 20)
        Me.ShowTextBox.mail = False
        Me.ShowTextBox.nada = False
        Me.ShowTextBox.Name = "ShowTextBox"
        Me.ShowTextBox.numerico = False
        Me.ShowTextBox.sinEspacio = False
        Me.ShowTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ShowTextBox.TabIndex = 3
        Me.ShowTextBox.texto = False
        '
        'ModificarOperacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(949, 348)
        Me.Controls.Add(Me.ShowGroupBox)
        Me.Controls.Add(Me.CompradorGroupBox)
        Me.Name = "ModificarOperacion"
        Me.CompradorGroupBox.ResumeLayout(False)
        Me.CompradorGroupBox.PerformLayout()
        Me.ShowGroupBox.ResumeLayout(False)
        Me.ShowGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CompradorGroupBox As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents NumeroCompradorTextBox As MyTextBox
    Friend WithEvents NombreLabel As Label
    Friend WithEvents NuevoCompradorButton As MyButton
    Friend WithEvents BuscarCompradorButton As MyButton
    Friend WithEvents ApellidoLabel As Label
    Friend WithEvents CompradoresComboBox As MyComboBox
    Friend WithEvents ApellidoTextBox As MyTextBox
    Friend WithEvents NombreTextBox As MyTextBox
    Friend WithEvents ShowGroupBox As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FechaComboBox As MyComboBox
    Friend WithEvents ShowLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BuscarShowButton As MyButton
    Friend WithEvents ShowComboBox As MyComboBox
    Friend WithEvents ShowTextBox As MyTextBox
End Class
