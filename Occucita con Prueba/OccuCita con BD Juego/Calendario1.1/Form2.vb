Imports MySql.Data.MySqlClient
Imports System.Data



Public Class Form2


    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'OptometriaDataSet2.estudiantes' Puede moverla o quitarla según sea necesario.
        Me.EstudiantesTableAdapter2.Fill(Me.OptometriaDataSet2.estudiantes)



        'Eliminar Esto ################################################################
        Dim a As String
        timeDe.Value = Form1.MonthCalendar1.SelectionRange.Start
        a = timeDe.Value
        lblReviso.Text = a
        '#############################################################################


        Dim diadecita As Date



        'Se da el valor del dia seleccionado a la variable "diadecita"
        diadecita = Form1.MonthCalendar1.SelectionRange.Start


        timeDe.Value = diadecita
        timeA.Value = diadecita


        'el lable muestra la variable "diadecita" en formato de "date" longstdate (con el nombre del dia y etc.)
        lblDiadeCita.Text = "Agregar nueva cita para el " + diadecita.ToLongDateString

        'a los 'timepickers' se le da el valor que esta seleccionado en el calendario de Form1, eso es
        'para que asi los timepickers funcionen solo dentro del rango de la fecha escogida y no mas alla
        timeDe.Value = Form1.MonthCalendar1.SelectionRange.Start
        timeA.Value = Form1.MonthCalendar1.SelectionRange.Start

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim con As New MySqlConnection()
        con.ConnectionString = "server=localhost;User Id=root;password=231312;Persist Security Info=True;database=optometria"

        If txtCedula.Text = "" Then
            MsgBox("Porfavor Introduzca porlomenos el numero de cedula")

        ElseIf txtCedula.Text <> "" Then

            Dim diadecita As DateTime
            diadecita = Form1.MonthCalendar1.SelectionRange.Start

            Dim HoraDe As DateTime
            HoraDe = timeDe.Value
            Dim HoraA As DateTime
            HoraA = timeA.Value

            Dim NumeroCedula As String
            NumeroCedula = txtCedula.Text

            Dim id As String
            id = NumeroCedula

            Dim nombre As String
            nombre = txtNombre.Text

            Dim NumTelefono As String
            NumTelefono = txtNumTel.Text

            Dim Direccion As String
            Direccion = txtDireccion.Text

            Dim HoradeActualizacion As DateTime
            HoradeActualizacion = Today

            Dim idEstudiantes As Integer
            idEstudiantes = cmbEstudiantes.Text

            ' #######################################################################33
            'Comando Mysql para agragar informacion a la tabla cita

            Dim CMySql As String
            CMySql = "INSERT INTO pacientes (idpacientes,`Nombre del paciente`,Tèlefono,Dirección,`Correo Electrónico`) VALUES(@idPaciente,@nombre,@Telefono,@Direccion,@CorreoElectronico)"


            Dim CCommand As New MySqlCommand(CMySql, con)

            CCommand.Parameters.Add(New MySqlParameter("@idPaciente", MySqlDbType.Int24))
            CCommand.Parameters("@idPaciente").Value = id

            CCommand.Parameters.Add(New MySqlParameter("@nombre", MySqlDbType.Text))
            CCommand.Parameters("@nombre").Value = nombre

            CCommand.Parameters.Add(New MySqlParameter("@Telefono", MySqlDbType.Text))
            CCommand.Parameters("@Telefono").Value = NumTelefono

            CCommand.Parameters.Add(New MySqlParameter("@Direccion", MySqlDbType.Text))
            CCommand.Parameters("@Direccion").Value = Direccion

            CCommand.Parameters.Add(New MySqlParameter("@CorreoElectronico", MySqlDbType.Text))
            CCommand.Parameters("@CorreoElectronico").Value = txtCorreoElex.Text

 

            '#####################################################################3

            '#####################################################################3

            ' commando MySql para agregar informacion a citas

            Dim sMySql As String
            sMySql = "INSERT INTO cita (pacientes_idpacientes,estudiantes_idestudiantes,Fecha,`Hora Inicial`,`Hora Finalización`) VALUES(@idpacientes,@Estudiante,@Fecha,@HoraInicio,@HoraFinal)"

            Dim oCommand As New MySqlCommand(sMySql, con)

            oCommand.Parameters.Add(New MySqlParameter("@idpacientes", MySqlDbType.Int24))
            oCommand.Parameters("@idpacientes").Value = id

            oCommand.Parameters.Add(New MySqlParameter("@Estudiante", MySqlDbType.Int24))
            oCommand.Parameters("@Estudiante").Value = idEstudiantes

            oCommand.Parameters.Add(New MySqlParameter("@Fecha", MySqlDbType.Date))
            oCommand.Parameters("@Fecha").Value = Form1.MonthCalendar1.SelectionRange.Start


            oCommand.Parameters.Add(New MySqlParameter("@HoraInicio", MySqlDbType.DateTime))  ' HoraDE.Year & "-" & HoraDE.Month & "-" & 
            oCommand.Parameters("@HoraInicio").Value = HoraDe.Year & "-" & HoraDe.Month & "-" & HoraDe.Day & " " & HoraDe.Hour & ":" & HoraDe.Minute & ":" & HoraDe.Second

            oCommand.Parameters.Add(New MySqlParameter("@HoraFinal", MySqlDbType.DateTime))  ' HoraA.Year & "-" & HoraA.Month & "-" & HoraA.Day & " " &
            oCommand.Parameters("@HoraFinal").Value = HoraA.Year & "-" & HoraA.Month & "-" & HoraA.Day & " " & HoraA.Hour & ":" & HoraA.Minute & ":" & HoraA.Second


       


            Dim MMMySql As String
            MMMySql = ""


            Dim NumericCheck As Boolean
            NumericCheck = IsNumeric(id)

            If NumericCheck = True Then


                Dim iResultado As Integer
                Dim hResultado As Integer
                Try

                    con.Open()
                    hResultado = CCommand.ExecuteNonQuery()
                    iResultado = oCommand.ExecuteNonQuery()

                    MsgBox("Cita Agregada con Exito")
                    con.Close()


                Catch exError As MySqlException

                    MsgBox("Ocurrio un error. " & exError.Number & " – " & exError.Message)

                End Try




        ElseIf NumericCheck = False Then
                MsgBox("Porfavor introduzca solo numeros en la cedula")
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub



    Private Sub cmbClinica_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Citas.Show()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        VerPacientes.Show()

    End Sub


    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class