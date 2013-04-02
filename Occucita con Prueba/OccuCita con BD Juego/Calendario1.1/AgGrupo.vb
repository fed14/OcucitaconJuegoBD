Imports MySql.Data.MySqlClient
Public Class AgGrupo

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New MySqlConnection()
        con.ConnectionString = "server=localhost;User Id=root;password=231312;Persist Security Info=True;database=optometria"

        Dim cMySql As String
        cMySql = "INSERT INTO Especialidad_has_estudiantes (Especialidad_idEspecialidad,Estudiantes_Estudiantes,Grupo,Horario,Especialidad) VALUES(@idEspecialidad,@Estudiantes,@Grupo,@Horario,@Especialidad)"
        Dim cCommand As New MySqlCommand(cMySql, con)

        cCommand.Parameters.Add(New MySqlParameter("@Grupo", MySqlDbType.Text))
        cCommand.Parameters("@Grupo").Value = txtNombreGrupo.Text


        cCommand.Parameters.Add(New MySqlParameter("@Especialidad", MySqlDbType.Text))
        cCommand.Parameters("@Especialidad").Value = cmbxEspecialidad.Text
        '##############################################################################

        'No funciona porque aun no se le ha puesto el resto
        ' de los parametros.
        'Se esta esperando al tio de lopez a que le diga

        '###########################################################################
        Dim iResultado As Integer

        Try
            con.Open()
            iResultado = cCommand.ExecuteNonQuery
            con.Close()

            MsgBox("Grupo agregado con exito")

        Catch exError As MySqlException
            MsgBox("Ocurrio un error. " & exError.Number & " – " & exError.Message)
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub AgGrupo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'OptometriaDataSet.especialidad' Puede moverla o quitarla según sea necesario.
        Me.EspecialidadTableAdapter.Fill(Me.OptometriaDataSet.especialidad)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        VerGruos.Show()

    End Sub
End Class