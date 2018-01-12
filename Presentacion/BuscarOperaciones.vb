Public Class BuscarOperaciones
    Private Sub BuscarOperacionButton_Click(sender As Object, e As EventArgs) Handles BuscarOperacionButton.Click
        Try
            OperacionesDataGrid.DataSource = BLL.GestorOperacionesBLL.buscarOperaciones
        Catch ex As Excepciones.VentasNoEncontradasExcepcion
            My.Application.manejarExcepcion(ex)
        Catch ex As Exception
            My.Application.manejarExcepcion(ex)
        End Try
    End Sub

    Private Sub AltaOperacionButton_Click(sender As Object, e As EventArgs) Handles AltaOperacionButton.Click
        If Not OperacionesDataGrid.CurrentRow.DataBoundItem Is Nothing Then
            Dim fam As BE.OperacionBE = DirectCast(OperacionesDataGrid.CurrentRow.DataBoundItem, BE.OperacionBE)
            Dim form As ModificarOperacion

            If (Not fam Is Nothing) Then
                form = New ModificarOperacion
                form.ShowDialog()
            End If
        End If
    End Sub

    Private Sub ModificarOperacionButton_Click(sender As Object, e As EventArgs) Handles ModificarOperacionButton.Click
        If Not OperacionesDataGrid.CurrentRow.DataBoundItem Is Nothing Then
            Dim fam As BE.OperacionBE = DirectCast(OperacionesDataGrid.CurrentRow.DataBoundItem, BE.OperacionBE)
            Dim form As ModificarOperacion

            If (Not fam Is Nothing) Then
                form = New ModificarOperacion
                form.addOperacion(fam)
                form.ShowDialog()
            End If
        End If
    End Sub

    Private Sub EliminarOperacionButton_Click(sender As Object, e As EventArgs) Handles EliminarOperacionButton.Click

    End Sub
End Class
