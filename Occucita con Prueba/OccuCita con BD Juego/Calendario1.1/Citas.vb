Public Class Citas

    Private Sub Citas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'OptometriaDataSet.cita' Puede moverla o quitarla según sea necesario.
        Me.CitaTableAdapter.Fill(Me.OptometriaDataSet.cita)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class