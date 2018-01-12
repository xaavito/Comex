Imports BE

Public Class ModificarOperacion
    Dim _oper As BE.OperacionBE
    Friend Sub addOperacion(fam As OperacionBE)
        _oper = fam
    End Sub

    Private Sub ModificarOperacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Normal
    End Sub
End Class
