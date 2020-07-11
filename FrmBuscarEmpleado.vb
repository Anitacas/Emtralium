

Imports MySql.Data.MySqlClient
Public Class FrmBuscarEmpleado

    Dim oconexion As New MySqlConnection
    Dim oDataAdapter As New MySqlDataAdapter
    Dim oDataSet As New DataSet


    Private Sub mostra()
        Dim oda As New MySqlDataAdapter
        Dim ods As New DataSet
        Dim consulta As String

        consulta = "Select *From empleados"
        oda = New MySqlDataAdapter()
        ods.Tables.Add("empleados")
        oda.Fill(ods.Tables("empleados"))
        DataGridView1.DataSource = ods.Tables("empleados")



    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub BuscarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class