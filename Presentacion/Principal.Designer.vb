<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
    Inherits Comex.BaseForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.Ventas = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarVenta = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarVenta = New System.Windows.Forms.ToolStripMenuItem()
        Me.Negocio = New System.Windows.Forms.ToolStripMenuItem()
        Me.Administracion = New System.Windows.Forms.ToolStripMenuItem()
        Me.Usuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.Familias = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarFamilias = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarFamilias = New System.Windows.Forms.ToolStripMenuItem()
        Me.Permisos = New System.Windows.Forms.ToolStripMenuItem()
        Me.PermisosUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.PermisosFamilias = New System.Windows.Forms.ToolStripMenuItem()
        Me.Configuracion = New System.Windows.Forms.ToolStripMenuItem()
        Me.Idiomas = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarIdiomas = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarIdiomas = New System.Windows.Forms.ToolStripMenuItem()
        Me.Backups = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarBackups = New System.Windows.Forms.ToolStripMenuItem()
        Me.RealizarRestores = New System.Windows.Forms.ToolStripMenuItem()
        Me.Bitacoras = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiUsuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.Logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ZonaFrancaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SIMIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiscelaneosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Reporte1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Reporte2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParametrizacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Ventas, Me.Negocio, Me.SIMIToolStripMenuItem, Me.MiscelaneosToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.Configuracion, Me.Administracion, Me.MiUsuario, Me.Logout})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(797, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'Ventas
        '
        Me.Ventas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarVenta, Me.GenerarVenta, Me.ZonaFrancaToolStripMenuItem})
        Me.Ventas.Image = Global.Comex.My.Resources.Resources.section
        Me.Ventas.Name = "Ventas"
        Me.Ventas.Size = New System.Drawing.Size(101, 20)
        Me.Ventas.Text = "Operaciones"
        '
        'BuscarVenta
        '
        Me.BuscarVenta.Image = Global.Comex.My.Resources.Resources.buscar
        Me.BuscarVenta.Name = "BuscarVenta"
        Me.BuscarVenta.Size = New System.Drawing.Size(152, 22)
        Me.BuscarVenta.Text = "Importaciones"
        '
        'GenerarVenta
        '
        Me.GenerarVenta.Image = Global.Comex.My.Resources.Resources.nuevo
        Me.GenerarVenta.Name = "GenerarVenta"
        Me.GenerarVenta.Size = New System.Drawing.Size(152, 22)
        Me.GenerarVenta.Text = "Exportaciones"
        '
        'Negocio
        '
        Me.Negocio.Image = Global.Comex.My.Resources.Resources.monedas
        Me.Negocio.Name = "Negocio"
        Me.Negocio.Size = New System.Drawing.Size(67, 20)
        Me.Negocio.Text = "Pagos"
        '
        'Administracion
        '
        Me.Administracion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Usuarios, Me.Familias, Me.Permisos})
        Me.Administracion.Image = Global.Comex.My.Resources.Resources.administracion
        Me.Administracion.Name = "Administracion"
        Me.Administracion.Size = New System.Drawing.Size(116, 20)
        Me.Administracion.Text = "Administracion"
        '
        'Usuarios
        '
        Me.Usuarios.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarUsuarios, Me.GenerarUsuarios})
        Me.Usuarios.Image = Global.Comex.My.Resources.Resources.persona
        Me.Usuarios.Name = "Usuarios"
        Me.Usuarios.Size = New System.Drawing.Size(152, 22)
        Me.Usuarios.Text = "Usuarios"
        '
        'BuscarUsuarios
        '
        Me.BuscarUsuarios.Image = Global.Comex.My.Resources.Resources.buscar
        Me.BuscarUsuarios.Name = "BuscarUsuarios"
        Me.BuscarUsuarios.Size = New System.Drawing.Size(163, 22)
        Me.BuscarUsuarios.Text = "Buscar Usuarios"
        '
        'GenerarUsuarios
        '
        Me.GenerarUsuarios.Image = Global.Comex.My.Resources.Resources.nuevo
        Me.GenerarUsuarios.Name = "GenerarUsuarios"
        Me.GenerarUsuarios.Size = New System.Drawing.Size(163, 22)
        Me.GenerarUsuarios.Text = "Generar Usuarios"
        '
        'Familias
        '
        Me.Familias.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarFamilias, Me.GenerarFamilias})
        Me.Familias.Enabled = False
        Me.Familias.Image = Global.Comex.My.Resources.Resources.personas
        Me.Familias.Name = "Familias"
        Me.Familias.Size = New System.Drawing.Size(152, 22)
        Me.Familias.Text = "Familia"
        '
        'BuscarFamilias
        '
        Me.BuscarFamilias.Image = Global.Comex.My.Resources.Resources.buscar
        Me.BuscarFamilias.Name = "BuscarFamilias"
        Me.BuscarFamilias.Size = New System.Drawing.Size(161, 22)
        Me.BuscarFamilias.Text = "Buscar Familias"
        '
        'GenerarFamilias
        '
        Me.GenerarFamilias.Image = Global.Comex.My.Resources.Resources.nuevo
        Me.GenerarFamilias.Name = "GenerarFamilias"
        Me.GenerarFamilias.Size = New System.Drawing.Size(161, 22)
        Me.GenerarFamilias.Text = "Generar Familias"
        '
        'Permisos
        '
        Me.Permisos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PermisosUsuarios, Me.PermisosFamilias})
        Me.Permisos.Image = Global.Comex.My.Resources.Resources.permission
        Me.Permisos.Name = "Permisos"
        Me.Permisos.Size = New System.Drawing.Size(152, 22)
        Me.Permisos.Text = "Permisos"
        '
        'PermisosUsuarios
        '
        Me.PermisosUsuarios.Image = Global.Comex.My.Resources.Resources.persona
        Me.PermisosUsuarios.Name = "PermisosUsuarios"
        Me.PermisosUsuarios.Size = New System.Drawing.Size(165, 22)
        Me.PermisosUsuarios.Text = "Permisos Usuario"
        '
        'PermisosFamilias
        '
        Me.PermisosFamilias.Image = Global.Comex.My.Resources.Resources.personas
        Me.PermisosFamilias.Name = "PermisosFamilias"
        Me.PermisosFamilias.Size = New System.Drawing.Size(165, 22)
        Me.PermisosFamilias.Text = "Permiso Familia"
        '
        'Configuracion
        '
        Me.Configuracion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Idiomas, Me.Backups, Me.Bitacoras, Me.ImportacionToolStripMenuItem, Me.ParametrizacionToolStripMenuItem})
        Me.Configuracion.Image = Global.Comex.My.Resources.Resources.configuracion
        Me.Configuracion.Name = "Configuracion"
        Me.Configuracion.Size = New System.Drawing.Size(111, 20)
        Me.Configuracion.Text = "Configuracion"
        '
        'Idiomas
        '
        Me.Idiomas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarIdiomas, Me.GenerarIdiomas})
        Me.Idiomas.Enabled = False
        Me.Idiomas.Image = Global.Comex.My.Resources.Resources._1350172460_system_config_language1
        Me.Idiomas.Name = "Idiomas"
        Me.Idiomas.Size = New System.Drawing.Size(159, 22)
        Me.Idiomas.Text = "Idioma"
        '
        'BuscarIdiomas
        '
        Me.BuscarIdiomas.Image = Global.Comex.My.Resources.Resources.buscar
        Me.BuscarIdiomas.Name = "BuscarIdiomas"
        Me.BuscarIdiomas.Size = New System.Drawing.Size(155, 22)
        Me.BuscarIdiomas.Text = "Buscar Idioma"
        '
        'GenerarIdiomas
        '
        Me.GenerarIdiomas.Image = Global.Comex.My.Resources.Resources.nuevo
        Me.GenerarIdiomas.Name = "GenerarIdiomas"
        Me.GenerarIdiomas.Size = New System.Drawing.Size(155, 22)
        Me.GenerarIdiomas.Text = "Generar Idioma"
        '
        'Backups
        '
        Me.Backups.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarBackups, Me.RealizarRestores})
        Me.Backups.Image = Global.Comex.My.Resources.Resources.backup
        Me.Backups.Name = "Backups"
        Me.Backups.Size = New System.Drawing.Size(152, 22)
        Me.Backups.Text = "Backup"
        '
        'BuscarBackups
        '
        Me.BuscarBackups.Image = Global.Comex.My.Resources.Resources.buscar
        Me.BuscarBackups.Name = "BuscarBackups"
        Me.BuscarBackups.Size = New System.Drawing.Size(156, 22)
        Me.BuscarBackups.Text = "Buscar Backup"
        '
        'RealizarRestores
        '
        Me.RealizarRestores.Image = Global.Comex.My.Resources.Resources.nuevo
        Me.RealizarRestores.Name = "RealizarRestores"
        Me.RealizarRestores.Size = New System.Drawing.Size(156, 22)
        Me.RealizarRestores.Text = "Realizar Restore"
        '
        'Bitacoras
        '
        Me.Bitacoras.Enabled = False
        Me.Bitacoras.Image = Global.Comex.My.Resources.Resources.log
        Me.Bitacoras.Name = "Bitacoras"
        Me.Bitacoras.Size = New System.Drawing.Size(159, 22)
        Me.Bitacoras.Text = "Bitacora"
        '
        'MiUsuario
        '
        Me.MiUsuario.Image = Global.Comex.My.Resources.Resources.persona
        Me.MiUsuario.Name = "MiUsuario"
        Me.MiUsuario.Size = New System.Drawing.Size(92, 20)
        Me.MiUsuario.Text = "Mi Usuario"
        '
        'Logout
        '
        Me.Logout.Image = Global.Comex.My.Resources.Resources.logout
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(73, 20)
        Me.Logout.Text = "Logout"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(797, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'ZonaFrancaToolStripMenuItem
        '
        Me.ZonaFrancaToolStripMenuItem.Image = Global.Comex.My.Resources.Resources.section
        Me.ZonaFrancaToolStripMenuItem.Name = "ZonaFrancaToolStripMenuItem"
        Me.ZonaFrancaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ZonaFrancaToolStripMenuItem.Text = "Zona Franca"
        '
        'SIMIToolStripMenuItem
        '
        Me.SIMIToolStripMenuItem.Name = "SIMIToolStripMenuItem"
        Me.SIMIToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.SIMIToolStripMenuItem.Text = "SIMI"
        '
        'MiscelaneosToolStripMenuItem
        '
        Me.MiscelaneosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProveedoresToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.ProductosToolStripMenuItem})
        Me.MiscelaneosToolStripMenuItem.Name = "MiscelaneosToolStripMenuItem"
        Me.MiscelaneosToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.MiscelaneosToolStripMenuItem.Text = "Miscelaneos"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Image = Global.Comex.My.Resources.Resources.personas
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Image = Global.Comex.My.Resources.Resources.personas
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Image = Global.Comex.My.Resources.Resources.log
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Reporte1ToolStripMenuItem, Me.Reporte2ToolStripMenuItem, Me.ReporteNToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'Reporte1ToolStripMenuItem
        '
        Me.Reporte1ToolStripMenuItem.Name = "Reporte1ToolStripMenuItem"
        Me.Reporte1ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.Reporte1ToolStripMenuItem.Text = "Reporte 1"
        '
        'Reporte2ToolStripMenuItem
        '
        Me.Reporte2ToolStripMenuItem.Name = "Reporte2ToolStripMenuItem"
        Me.Reporte2ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.Reporte2ToolStripMenuItem.Text = "Reporte 2"
        '
        'ReporteNToolStripMenuItem
        '
        Me.ReporteNToolStripMenuItem.Name = "ReporteNToolStripMenuItem"
        Me.ReporteNToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ReporteNToolStripMenuItem.Text = "Reporte N"
        '
        'ImportacionToolStripMenuItem
        '
        Me.ImportacionToolStripMenuItem.Name = "ImportacionToolStripMenuItem"
        Me.ImportacionToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ImportacionToolStripMenuItem.Text = "Importacion"
        '
        'ParametrizacionToolStripMenuItem
        '
        Me.ParametrizacionToolStripMenuItem.Name = "ParametrizacionToolStripMenuItem"
        Me.ParametrizacionToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ParametrizacionToolStripMenuItem.Text = "Parametrizacion"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = False
        Me.ClientSize = New System.Drawing.Size(797, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comex"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents Logout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Administracion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Usuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarUsuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarUsuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Familias As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarFamilias As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarFamilias As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Permisos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PermisosUsuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PermisosFamilias As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Configuracion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Idiomas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarIdiomas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarIdiomas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Backups As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarBackups As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RealizarRestores As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Bitacoras As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MiUsuario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Ventas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarVenta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarVenta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Negocio As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZonaFrancaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SIMIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MiscelaneosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Reporte1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Reporte2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteNToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ParametrizacionToolStripMenuItem As ToolStripMenuItem
End Class
