Public Class frmBclientes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        My.Forms.frmmcliente.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        My.Forms.frmmenu.Show()
    End Sub

    Private Sub frmBclientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class