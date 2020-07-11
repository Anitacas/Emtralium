Public Class frmempleados
    Private mover As Boolean = False

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs)
        mover = True
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs)
        If mover Then
            If e.Button = Windows.Forms.MouseButtons.Left Then
                Me.Location = Cursor.Position
            End If
        End If


    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs)
        mover = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        My.Forms.frmempleados.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        My.Forms.frmmenu.Show()
    End Sub

    Private Sub frmempleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class