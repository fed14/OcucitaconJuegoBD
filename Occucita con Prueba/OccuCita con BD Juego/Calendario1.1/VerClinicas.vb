Public Class VerClinicas

    Private Sub VerClinicas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'OptometriaDataSet.clínicas' Puede moverla o quitarla según sea necesario.
        Me.ClínicasTableAdapter.Fill(Me.OptometriaDataSet.clínicas)

    End Sub
End Class