Imports MySql.Data.MySqlClient

Public Class Form1



    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'OptometriaDataSet.estudiantes' Puede moverla o quitarla según sea necesario.
        Me.EstudiantesTableAdapter.Fill(Me.OptometriaDataSet.estudiantes)
        'TODO: esta línea de código carga datos en la tabla 'OptometriaDataSet.especialidad' Puede moverla o quitarla según sea necesario.
        Me.EspecialidadTableAdapter.Fill(Me.OptometriaDataSet.especialidad)
 


    End Sub


    Private Sub picBox3_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)


    End Sub







    Private Sub picBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub









    Private Sub picBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AgCurso.Show()

    End Sub





    Private Sub picBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub picBox7_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picBox7.MouseHover
        'cuando el mouse pasa sobre picbox7 entonces picbox8 aparece
        picBox8.Show()

    End Sub

    Private Sub picBox8_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picBox8.MouseLeave
        'cuando el mouse sale de los limites de picbox8 entonces este deaparece
        picBox8.Hide()

    End Sub

    Private Sub picBox8_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picBox8.MouseClick
        'cuando se hace clic en picbox8 esta desaparece
        picBox8.Hide()

    End Sub

    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged

        'se da el valor de Date a la variable "dia"
        Dim dia As Date


        'el valor de "dia" es igual a la fecha que esta seleccionada en el calendario
        dia = MonthCalendar1.SelectionRange.Start


        'el lable "lblDia" obtiene el valor de "dia" convertido en un formato de "Long Date" y aparece como texto.
        lblDia.Text = dia.ToLongDateString





    End Sub

    Private Sub picBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picBox7.Click

    End Sub



    Private Sub picBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub picBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub picBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picBox8.Click


        Dim valor As Boolean

        Try
            '########################################################

            'si no hay ningun dia seleccionado en el calendario entonces lbldia va a ser "" entonces "valor" es mentira

            If lblDia.Text = "" Then
                valor = False

                'si lbldia no es "" entonces "valor" es verdad
            ElseIf lblDia.Text <> "" Then
                valor = True
            End If

            '########################################################


            'si no hay ninguna fecha seleccionada entonces se muestra un mensaje de error.
            If valor = False Then

                MsgBox("Por favor seleccione una fecha a la cual asignar la cita.", MsgBoxStyle.OkOnly, "No hay ninguna fecha seleccionada")

                'si hay alguna fecha seleccionada entonces se habre el form para escribir la informacion de la cita.
            ElseIf valor = True Then

                Form2.Show()
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Panel7_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel7.Paint

    End Sub

    Private Sub Panel8_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel8.Paint

    End Sub

    Private Sub AgregarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub VerInformacionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AgregarHorario.Show()

    End Sub



    Private Sub CrearHorarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AgregarHorario.Show()

    End Sub





    Private Sub AgregarEstudianesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarEstudianesToolStripMenuItem.Click
        AgregarEst.Show()

    End Sub

    Private Sub ModificarHorarioToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AgregarEspecialidadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarEspecialidadesToolStripMenuItem.Click
        AgCurso.Show()

    End Sub

    Private Sub AgregarGrupoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        AgGrupo.Show()

    End Sub

    Private Sub AgregarClinicaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarClinicaToolStripMenuItem.Click
        AgregarClinica.show()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
