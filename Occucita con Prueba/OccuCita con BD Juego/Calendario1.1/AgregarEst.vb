Imports MySql.Data.MySqlClient

Public Class AgregarEst

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New MySqlConnection()
        con.ConnectionString = "server=localhost;User Id=root;password=231312;Persist Security Info=True;database=optometria1"

        Dim CMySql As String
        CMySql = "INSERT INTO estudiantes (Estudiantes,Nombre,Cédula,`Correo Electrónico`,Teléfono,Grupo,especialidad_idEspecialidad) VALUES(@idEstudiante,@nombre,@cedula,@CorreoElectronico,@Telefono,@grupo,@idEspecialidad)"

        '%%%%^^^%%%%\
        'A_adir un check  para numeric
        '4$$%%$$%^%$

        Dim NumeroGrupo As Integer
        NumeroGrupo = numGrupo.Value

        Dim CarneEstudiante As Integer
        CarneEstudiante = txtidEstudiante.Text

        Dim AgregarEstudiante As New MySqlCommand(CMySql, con)

        AgregarEstudiante.Parameters.Add(New MySqlParameter("@idEstudiante", MySqlDbType.Int24))
        AgregarEstudiante.Parameters("@idEstudiante").Value = CarneEstudiante

        AgregarEstudiante.Parameters.Add(New MySqlParameter("@nombre", MySqlDbType.Text))
        AgregarEstudiante.Parameters("@nombre").Value = txtEstudiante.Text

        AgregarEstudiante.Parameters.Add(New MySqlParameter("@cedula", MySqlDbType.Text))
        AgregarEstudiante.Parameters("@cedula").Value = txtCedula.Text

        AgregarEstudiante.Parameters.Add(New MySqlParameter("@CorreoElectronico", MySqlDbType.Text))
        AgregarEstudiante.Parameters("@CorreoElectronico").Value = txtCorreo.Text

        AgregarEstudiante.Parameters.Add(New MySqlParameter("@Telefono", MySqlDbType.Text))
        AgregarEstudiante.Parameters("@Telefono").Value = txtTelefono.Text


        AgregarEstudiante.Parameters.Add(New MySqlParameter("@grupo", MySqlDbType.Int32))
        AgregarEstudiante.Parameters("@grupo").Value = NumeroGrupo

        AgregarEstudiante.Parameters.Add(New MySqlParameter("@idEspecialidad", MySqlDbType.Int32))
        AgregarEstudiante.Parameters("@idEspecialidad").Value = NumeroGrupo

        Dim iResultado As Integer

        Try
            con.Open()
            iResultado = AgregarEstudiante.ExecuteNonQuery()
            con.Close()

            MsgBox("Estudiante agregado con exito")
        Catch exError As MySqlException
            MsgBox("Ocurrio un error. " & exError.Number & " – " & exError.Message)
        End Try


    End Sub

    Private Sub AgregarEst_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'OptometriaDataSet.especialidad' Puede moverla o quitarla según sea necesario.
        Me.EspecialidadTableAdapter.Fill(Me.OptometriaDataSet.especialidad)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class