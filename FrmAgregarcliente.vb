Public Class frmagrecliente
    Private Sub frmagrecliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        My.Forms.frmagrecliente.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        My.Forms.frmmcliente.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Close()
        My.Forms.frmmenu.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        My.Forms.frmmenu.Show()
    End Sub
End Class