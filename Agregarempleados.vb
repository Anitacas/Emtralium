



Imports MySql.Data.MySqlClient



Public Class Frmagregarempleados

    Dim oconexion As New MySqlConnection
    Dim oDataAdapter As New MySqlDataAdapter
    Dim oDataSet As New DataSet


    Private mover As Boolean = False

    Private Sub AgregarEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            oconexion.ConnectionString = "server=localhost;user=root;password=; database=conexion"
            oconexion.Open()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

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

    Private Sub Textidem_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        My.Forms.frmempleados.Show()
    End Sub

    Private Sub Dtgempleado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)


    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class