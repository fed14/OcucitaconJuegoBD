Public Class ConsultarEspecialidades

    Private Sub ConsultarEspecialidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'OptometriaDataSet.especialidad' Puede moverla o quitarla según sea necesario.
        Me.EspecialidadTableAdapter.Fill(Me.OptometriaDataSet.especialidad)

    End Sub
End Class