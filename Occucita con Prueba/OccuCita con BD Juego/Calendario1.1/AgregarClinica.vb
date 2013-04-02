Imports MySql.Data.MySqlClient

Public Class AgregarClinica

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New MySqlConnection()
        con.ConnectionString = "server=localhost;User Id=root;password=231312;Persist Security Info=True;database=optometria"

        Dim txUbicacion As String
        txUbicacion = txtUbicacion.Text

        'Falta numCheck ###############################################
        Dim idClinicas As Integer
        idClinicas = txtIdClinica.Text

        Dim cMySql As String
        cMySql = "INSERT INTO Clínicas (idClínicas,Ubicación) VALUES(@IdClinicas,@Ubicación)"


        Dim cCommand As New MySqlCommand(cMySql, con)


        cCommand.Parameters.Add(New MySqlParameter("@IdClinicas", MySqlDbType.Text))
        cCommand.Parameters("@IdClinicas").Value = idClinicas

        cCommand.Parameters.Add(New MySqlParameter("@Ubicación", MySqlDbType.Text))
        cCommand.Parameters("@Ubicación").Value = txUbicacion

        Dim iResultado As Integer

        Try
            con.Open()
            iResultado = cCommand.ExecuteNonQuery
            con.Close()

            MsgBox("Especialidad agregada con exito")

        Catch exError As MySqlException
            MsgBox("Ocurrio un error. " & exError.Number & " – " & exError.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        VerClinicas.Show()

    End Sub
End Class