Public Class frmAgreunidad
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        My.Forms.frmMunidad.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        My.Forms.frmmenu.Show()
    End Sub
End Class