<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerGruos
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
        Me.EspecialidadhasestudiantesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Especialidad_has_estudiantesTableAdapter = New OccuCita.optometria1DataSetTableAdapters.especialidadTableAdapter()
        Me.EspecialidadidEspecialidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstudiantesEstudiantesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrupoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EspecialidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OptometriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EspecialidadhasestudiantesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EspecialidadidEspecialidadDataGridViewTextBoxColumn, Me.EstudiantesEstudiantesDataGridViewTextBoxColumn, Me.GrupoDataGridViewTextBoxColumn, Me.HorarioDataGridViewTextBoxColumn, Me.EspecialidadDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EspecialidadhasestudiantesBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(557, 262)
        Me.DataGridView1.TabIndex = 0
        '
        'OptometriaDataSet
        '
        Me.OptometriaDataSet.DataSetName = "optometriaDataSet"
        Me.OptometriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EspecialidadhasestudiantesBindingSource
        '
        Me.EspecialidadhasestudiantesBindingSource.DataMember = "especialidad_has_estudiantes"
        Me.EspecialidadhasestudiantesBindingSource.DataSource = Me.OptometriaDataSet
        '
        'Especialidad_has_estudiantesTableAdapter
        '
        Me.Especialidad_has_estudiantesTableAdapter.ClearBeforeFill = True
        '
        'EspecialidadidEspecialidadDataGridViewTextBoxColumn
        '
        Me.EspecialidadidEspecialidadDataGridViewTextBoxColumn.DataPropertyName = "Especialidad_idEspecialidad"
        Me.EspecialidadidEspecialidadDataGridViewTextBoxColumn.HeaderText = "Especialidad_idEspecialidad"
        Me.EspecialidadidEspecialidadDataGridViewTextBoxColumn.Name = "EspecialidadidEspecialidadDataGridViewTextBoxColumn"
        '
        'EstudiantesEstudiantesDataGridViewTextBoxColumn
        '
        Me.EstudiantesEstudiantesDataGridViewTextBoxColumn.DataPropertyName = "Estudiantes_Estudiantes"
        Me.EstudiantesEstudiantesDataGridViewTextBoxColumn.HeaderText = "Estudiantes_Estudiantes"
        Me.EstudiantesEstudiantesDataGridViewTextBoxColumn.Name = "EstudiantesEstudiantesDataGridViewTextBoxColumn"
        '
        'GrupoDataGridViewTextBoxColumn
        '
        Me.GrupoDataGridViewTextBoxColumn.DataPropertyName = "Grupo"
        Me.GrupoDataGridViewTextBoxColumn.HeaderText = "Grupo"
        Me.GrupoDataGridViewTextBoxColumn.Name = "GrupoDataGridViewTextBoxColumn"
        '
        'HorarioDataGridViewTextBoxColumn
        '
        Me.HorarioDataGridViewTextBoxColumn.DataPropertyName = "Horario"
        Me.HorarioDataGridViewTextBoxColumn.HeaderText = "Horario"
        Me.HorarioDataGridViewTextBoxColumn.Name = "HorarioDataGridViewTextBoxColumn"
        '
        'EspecialidadDataGridViewTextBoxColumn
        '
        Me.EspecialidadDataGridViewTextBoxColumn.DataPropertyName = "Especialidad"
        Me.EspecialidadDataGridViewTextBoxColumn.HeaderText = "Especialidad"
        Me.EspecialidadDataGridViewTextBoxColumn.Name = "EspecialidadDataGridViewTextBoxColumn"
        '
        'VerGruos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 262)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "VerGruos"
        Me.Text = "VerGruos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OptometriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EspecialidadhasestudiantesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents OptometriaDataSet As OccuCita.optometria1DataSet
    Friend WithEvents EspecialidadhasestudiantesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Especialidad_has_estudiantesTableAdapter As OccuCita.optometria1DataSetTableAdapters.especialidadTableAdapter
    Friend WithEvents EspecialidadidEspecialidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstudiantesEstudiantesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GrupoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HorarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EspecialidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
