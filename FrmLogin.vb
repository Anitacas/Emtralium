Imports MySql.Data.MySqlClient

Public Class FrmLogin
    Private mover As Boolean = False
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        Me.WindowState = 1

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btningresar.Click

        Me.Hide()
        My.Forms.frmmenu.Show()
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

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
