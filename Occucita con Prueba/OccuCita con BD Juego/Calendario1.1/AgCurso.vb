Imports MySql.Data.MySqlClient

Public Class AgCurso

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New MySqlConnection()
        con.ConnectionString = "server=localhost;User Id=root;password=231312;Persist Security Info=True;database=optometria1"

        Dim cMySql As String
        cMySql = "INSERT INTO especialidad (Especialidad) VALUES(@Especialidad)"

        Dim Especialidad As String
        Especialidad = txtNombreNuevoCurso.Text

        Dim cCommand As New MySqlCommand(cMySql, con)

        cCommand.Parameters.Add(New MySqlParameter("@Especialidad", MySqlDbType.Text))
        cCommand.Parameters("@Especialidad").Value = Especialidad

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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ConsultarEspecialidades.Show()

    End Sub
End Class