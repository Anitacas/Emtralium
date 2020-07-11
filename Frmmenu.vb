Public Class frmmenu
    Private mover As Boolean = False
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        Me.Close()
        My.Forms.FrmLogin.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        Me.WindowState = 1
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        My.Forms.frmempleados.Show()
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        My.Forms.frmMunidad.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        My.Forms.frmmcliente.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        My.Forms.frmFacturacion.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnhorario.Click
        Me.Close()
        My.Forms.frmHorarios.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnmantenimiento_Click(sender As Object, e As EventArgs) Handles btnmantenimiento.Click
        Me.Close()
        My.Forms.frmFacturacion.Show()
    End Sub
End Class