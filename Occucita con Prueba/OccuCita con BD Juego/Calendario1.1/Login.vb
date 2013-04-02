Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Security.Cryptography

Public Class Login
    Dim SQL As MySqlCommand

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim conexion As MySqlConnection
        conexion = New MySqlConnection()
        conexion.ConnectionString = "server=localhost;user=root; password=root; database=optometria"

        Try
            conexion.Open()
        Catch myerror As MySqlException
            MessageBox.Show("Error Connecting to Database: " & myerror.Message)
        End Try
        Dim myAdapter As New MySqlDataAdapter

        Dim SQL = "SELECT Nombre, Contraseña FROM Usuarios WHERE Nombre ='" & TextBox1.Text & "' AND Contraseña='" & TextBox2.Text & "'"

        Dim Comando As New MySqlCommand()
        Comando.Connection = conexion
        Comando.CommandText = SQL

        myAdapter.SelectCommand = Comando
        Dim Consultar As MySqlDataReader
        Consultar = Comando.ExecuteReader()

        If Consultar.HasRows = 0 Then
            MessageBox.Show("Usuario o Contraseña Incorrectos")
        Else
            Dim frm1 = New Form1
            Form1.Show()
            Me.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class