<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Citas
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
        Me.OptometriaDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CitaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CitaTableAdapter = New OccuCita.optometria1DataSetTableAdapters.citaTableAdapter()
        Me.CodigoDeCitaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PacientesidpacientesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstudiantesidestudiantesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraInicialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraFinalizaciÃnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaYHoraDeActualizaciÃnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioDeActualizaciÃnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OptometriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OptometriaDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CitaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDeCitaDataGridViewTextBoxColumn, Me.PacientesidpacientesDataGridViewTextBoxColumn, Me.EstudiantesidestudiantesDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.HoraInicialDataGridViewTextBoxColumn, Me.HoraFinalizaciÃnDataGridViewTextBoxColumn, Me.FechaYHoraDeActualizaciÃnDataGridViewTextBoxColumn, Me.UsuarioDeActualizaciÃnDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CitaBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(849, 262)
        Me.DataGridView1.TabIndex = 0
        '
        'OptometriaDataSet
        '
        Me.OptometriaDataSet.DataSetName = "optometriaDataSet"
        Me.OptometriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OptometriaDataSetBindingSource
        '
        Me.OptometriaDataSetBindingSource.DataSource = Me.OptometriaDataSet
        Me.OptometriaDataSetBindingSource.Position = 0
        '
        'CitaBindingSource
        '
        Me.CitaBindingSource.DataMember = "cita"
        Me.CitaBindingSource.DataSource = Me.OptometriaDataSet
        '
        'CitaTableAdapter
        '
        Me.CitaTableAdapter.ClearBeforeFill = True
        '
        'CodigoDeCitaDataGridViewTextBoxColumn
        '
        Me.CodigoDeCitaDataGridViewTextBoxColumn.DataPropertyName = "Codigo de Cita"
        Me.CodigoDeCitaDataGridViewTextBoxColumn.HeaderText = "Codigo de Cita"
        Me.CodigoDeCitaDataGridViewTextBoxColumn.Name = "CodigoDeCitaDataGridViewTextBoxColumn"
        '
        'PacientesidpacientesDataGridViewTextBoxColumn
        '
        Me.PacientesidpacientesDataGridViewTextBoxColumn.DataPropertyName = "pacientes_idpacientes"
        Me.PacientesidpacientesDataGridViewTextBoxColumn.HeaderText = "pacientes_idpacientes"
        Me.PacientesidpacientesDataGridViewTextBoxColumn.Name = "PacientesidpacientesDataGridViewTextBoxColumn"
        '
        'EstudiantesidestudiantesDataGridViewTextBoxColumn
        '
        Me.EstudiantesidestudiantesDataGridViewTextBoxColumn.DataPropertyName = "estudiantes_idestudiantes"
        Me.EstudiantesidestudiantesDataGridViewTextBoxColumn.HeaderText = "estudiantes_idestudiantes"
        Me.EstudiantesidestudiantesDataGridViewTextBoxColumn.Name = "EstudiantesidestudiantesDataGridViewTextBoxColumn"
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        '
        'HoraInicialDataGridViewTextBoxColumn
        '
        Me.HoraInicialDataGridViewTextBoxColumn.DataPropertyName = "Hora Inicial"
        Me.HoraInicialDataGridViewTextBoxColumn.HeaderText = "Hora Inicial"
        Me.HoraInicialDataGridViewTextBoxColumn.Name = "HoraInicialDataGridViewTextBoxColumn"
        '
        'HoraFinalizaciÃnDataGridViewTextBoxColumn
        '
        Me.HoraFinalizaciÃnDataGridViewTextBoxColumn.DataPropertyName = "Hora FinalizaciÃ³n"
        Me.HoraFinalizaciÃnDataGridViewTextBoxColumn.HeaderText = "Hora FinalizaciÃ³n"
        Me.HoraFinalizaciÃnDataGridViewTextBoxColumn.Name = "HoraFinalizaciÃnDataGridViewTextBoxColumn"
        '
        'FechaYHoraDeActualizaciÃnDataGridViewTextBoxColumn
        '
        Me.FechaYHoraDeActualizaciÃnDataGridViewTextBoxColumn.DataPropertyName = "Fecha y Hora de ActualizaciÃ³n"
        Me.FechaYHoraDeActualizaciÃnDataGridViewTextBoxColumn.HeaderText = "Fecha y Hora de ActualizaciÃ³n"
        Me.FechaYHoraDeActualizaciÃnDataGridViewTextBoxColumn.Name = "FechaYHoraDeActualizaciÃnDataGridViewTextBoxColumn"
        '
        'UsuarioDeActualizaciÃnDataGridViewTextBoxColumn
        '
        Me.UsuarioDeActualizaciÃnDataGridViewTextBoxColumn.DataPropertyName = "Usuario de ActualizaciÃ³n"
        Me.UsuarioDeActualizaciÃnDataGridViewTextBoxColumn.HeaderText = "Usuario de ActualizaciÃ³n"
        Me.UsuarioDeActualizaciÃnDataGridViewTextBoxColumn.Name = "UsuarioDeActualizaciÃnDataGridViewTextBoxColumn"
        '
        'Citas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 262)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Citas"
        Me.Text = "Citas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OptometriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OptometriaDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CitaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents OptometriaDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OptometriaDataSet As OccuCita.optometria1DataSet
    Friend WithEvents CitaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CitaTableAdapter As OccuCita.optometria1DataSetTableAdapters.citaTableAdapter
    Friend WithEvents CodigoDeCitaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PacientesidpacientesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstudiantesidestudiantesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HoraInicialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HoraFinalizaciÃnDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaYHoraDeActualizaciÃnDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDeActualizaciÃnDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
