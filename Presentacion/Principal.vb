Imports System.Windows.Forms

Public Class Principal
    Inherits BaseForm

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Logout.Click
        Try
            BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, BLL.Actual.usuario.usuario, Utilitarios.Enumeradores.Bitacora.LogoutExitoso)
        Catch excep As Excepciones.InsertExcepcion
            My.Application.manejarExcepcion(excep)
        End Try
        Me.Close()
    End Sub

    Private Sub BuscarUsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarUsuarios.Click
        Dim form As New BuscarUsuarioForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BuscarFamiliasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarFamilias.Click
        Dim form As New BuscarFamiliaForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub GenerarFamiliasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarFamilias.Click
        Dim form As New GenerarFamiliaForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub PermisosUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermisosUsuarios.Click
        Dim form As New GenerarPermisoUsuarioForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub PermisoFamiliaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermisosFamilias.Click
        Dim form As New GenerarPermisoFamiliaForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BuscarBackupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarBackups.Click
        Dim form As New BuscarBackupForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub RealizarRestoreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RealizarRestores.Click
        Dim form As New RealizarRestoreForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BitacoraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bitacoras.Click
        Dim form As New BuscarBitacoraForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BuscarVentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarVenta.Click
        Dim form As New BuscarVentaForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub GenerarVentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarVenta.Click
        Dim form As New GenerarVentaForm
        form.MdiParent = Me
        form.Show()
    End Sub



    Private Sub BuscarCompradorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim form As New BuscarCompradorForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BuscarTipoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GenerarTipoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
