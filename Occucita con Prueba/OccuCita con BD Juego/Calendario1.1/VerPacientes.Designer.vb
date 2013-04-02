<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerPacientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.OptometriaDataSet = New OccuCita.optometria1DataSet()
        Me.EstudianteshasclínicasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Estudiantes_has_clínicasTableAdapter = New OccuCita.optometria1DataSetTableAdapters.estudiantesTableAdapter()
        Me.PacientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PacientesTableAdapter = New OccuCita.optometria1DataSetTableAdapters.pacientesTableAdapter()
        Me.IdpacientesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDelPacienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TÃlefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirecciÃnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoElectrÃnicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaYHoraDeActualizaciÃnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioDeActualizaciÃnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OptometriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstudianteshasclínicasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdpacientesDataGridViewTextBoxColumn, Me.NombreDelPacienteDataGridViewTextBoxColumn, Me.TÃlefonoDataGridViewTextBoxColumn, Me.DirecciÃnDataGridViewTextBoxColumn, Me.CorreoElectrÃnicoDataGridViewTextBoxColumn, Me.FechaYHoraDeActualizaciÃnDataGridViewTextBoxColumn, Me.UsuarioDeActualizaciÃnDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PacientesBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(765, 262)
        Me.DataGridView1.TabIndex = 0
        '
        'OptometriaDataSet
        '
        Me.OptometriaDataSet.DataSetName = "optometriaDataSet"
        Me.OptometriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EstudianteshasclínicasBindingSource
        '
        Me.EstudianteshasclínicasBindingSource.DataMember = "estudiantes_has_clínicas"
        Me.EstudianteshasclínicasBindingSource.DataSource = Me.OptometriaDataSet
        '
        'Estudiantes_has_clínicasTableAdapter
        '
        Me.Estudiantes_has_clínicasTableAdapter.ClearBeforeFill = True
        '
        'PacientesBindingSource
        '
        Me.PacientesBindingSource.DataMember = "pacientes"
        Me.PacientesBindingSource.DataSource = Me.OptometriaDataSet
        '
        'PacientesTableAdapter
        '
        Me.PacientesTableAdapter.ClearBeforeFill = True
        '
        'IdpacientesDataGridViewTextBoxColumn
        '
        Me.IdpacientesDataGridViewTextBoxColumn.DataPropertyName = "idpacientes"
        Me.IdpacientesDataGridViewTextBoxColumn.HeaderText = "Id Pacientes"
        Me.IdpacientesDataGridViewTextBoxColumn.Name = "IdpacientesDataGridViewTextBoxColumn"
        '
        'NombreDelPacienteDataGridViewTextBoxColumn
        '
        Me.NombreDelPacienteDataGridViewTextBoxColumn.DataPropertyName = "Nombre del paciente"
        Me.NombreDelPacienteDataGridViewTextBoxColumn.HeaderText = "Nombre del paciente"
        Me.NombreDelPacienteDataGridViewTextBoxColumn.Name = "NombreDelPacienteDataGridViewTextBoxColumn"
        '
        'TÃlefonoDataGridViewTextBoxColumn
        '
        Me.TÃlefonoDataGridViewTextBoxColumn.DataPropertyName = "TÃ¨lefono"
        Me.TÃlefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TÃlefonoDataGridViewTextBoxColumn.Name = "TÃlefonoDataGridViewTextBoxColumn"
        '
        'DirecciÃnDataGridViewTextBoxColumn
        '
        Me.DirecciÃnDataGridViewTextBoxColumn.DataPropertyName = "DirecciÃ³n"
        Me.DirecciÃnDataGridViewTextBoxColumn.HeaderText = "Direccion"
        Me.DirecciÃnDataGridViewTextBoxColumn.Name = "DirecciÃnDataGridViewTextBoxColumn"
        '
        'CorreoElectrÃnicoDataGridViewTextBoxColumn
        '
        Me.CorreoElectrÃnicoDataGridViewTextBoxColumn.DataPropertyName = "Correo ElectrÃ³nico"
        Me.CorreoElectrÃnicoDataGridViewTextBoxColumn.HeaderText = "Correo Electronico"
        Me.CorreoElectrÃnicoDataGridViewTextBoxColumn.Name = "CorreoElectrÃnicoDataGridViewTextBoxColumn"
        '
        'FechaYHoraDeActualizaciÃnDataGridViewTextBoxColumn
        '
        Me.FechaYHoraDeActualizaciÃnDataGridViewTextBoxColumn.DataPropertyName = "Fecha y Hora de ActualizaciÃ³n"
        Me.FechaYHoraDeActualizaciÃnDataGridViewTextBoxColumn.HeaderText = "Fecha y Hora de Actualizacion"
        Me.FechaYHoraDeActualizaciÃnDataGridViewTextBoxColumn.Name = "FechaYHoraDeActualizaciÃnDataGridViewTextBoxColumn"
        '
        'UsuarioDeActualizaciÃnDataGridViewTextBoxColumn
        '
        Me.UsuarioDeActualizaciÃnDataGridViewTextBoxColumn.DataPropertyName = "Usuario de ActualizaciÃ³n"
        Me.UsuarioDeActualizaciÃnDataGridViewTextBoxColumn.HeaderText = "Usuario de Actualizacion"
        Me.UsuarioDeActualizaciÃnDataGridViewTextBoxColumn.Name = "UsuarioDeActualizaciÃnDataGridViewTextBoxColumn"
        '
        'VerPacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 262)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "VerPacientes"
        Me.Text = "VerPacientes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OptometriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstudianteshasclínicasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents OptometriaDataSet As OccuCita.optometria1DataSet
    Friend WithEvents EstudianteshasclínicasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Estudiantes_has_clínicasTableAdapter As OccuCita.optometria1DataSetTableAdapters.estudiantesTableAdapter
    Friend WithEvents PacientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PacientesTableAdapter As OccuCita.optometria1DataSetTableAdapters.pacientesTableAdapter
    Friend WithEvents IdpacientesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDelPacienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TÃlefonoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DirecciÃnDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CorreoElectrÃnicoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaYHoraDeActualizaciÃnDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDeActualizaciÃnDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
