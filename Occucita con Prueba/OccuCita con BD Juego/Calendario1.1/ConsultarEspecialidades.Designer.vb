<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultarEspecialidades
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
        Me.EspecialidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EspecialidadTableAdapter = New OccuCita.optometria1DataSetTableAdapters.especialidadTableAdapter()
        Me.IdEspecialidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EspecialidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDeActualizaciÃnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioDeActualizaciÃnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OptometriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EspecialidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdEspecialidadDataGridViewTextBoxColumn, Me.EspecialidadDataGridViewTextBoxColumn, Me.FechaDeActualizaciÃnDataGridViewTextBoxColumn, Me.UsuarioDeActualizaciÃnDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EspecialidadBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(444, 262)
        Me.DataGridView1.TabIndex = 0
        '
        'OptometriaDataSet
        '
        Me.OptometriaDataSet.DataSetName = "optometriaDataSet"
        Me.OptometriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EspecialidadBindingSource
        '
        Me.EspecialidadBindingSource.DataMember = "especialidad"
        Me.EspecialidadBindingSource.DataSource = Me.OptometriaDataSet
        '
        'EspecialidadTableAdapter
        '
        Me.EspecialidadTableAdapter.ClearBeforeFill = True
        '
        'IdEspecialidadDataGridViewTextBoxColumn
        '
        Me.IdEspecialidadDataGridViewTextBoxColumn.DataPropertyName = "idEspecialidad"
        Me.IdEspecialidadDataGridViewTextBoxColumn.HeaderText = "idEspecialidad"
        Me.IdEspecialidadDataGridViewTextBoxColumn.Name = "IdEspecialidadDataGridViewTextBoxColumn"
        '
        'EspecialidadDataGridViewTextBoxColumn
        '
        Me.EspecialidadDataGridViewTextBoxColumn.DataPropertyName = "Especialidad"
        Me.EspecialidadDataGridViewTextBoxColumn.HeaderText = "Especialidad"
        Me.EspecialidadDataGridViewTextBoxColumn.Name = "EspecialidadDataGridViewTextBoxColumn"
        '
        'FechaDeActualizaciÃnDataGridViewTextBoxColumn
        '
        Me.FechaDeActualizaciÃnDataGridViewTextBoxColumn.DataPropertyName = "Fecha de ActualizaciÃ³n"
        Me.FechaDeActualizaciÃnDataGridViewTextBoxColumn.HeaderText = "Fecha de ActualizaciÃ³n"
        Me.FechaDeActualizaciÃnDataGridViewTextBoxColumn.Name = "FechaDeActualizaciÃnDataGridViewTextBoxColumn"
        '
        'UsuarioDeActualizaciÃnDataGridViewTextBoxColumn
        '
        Me.UsuarioDeActualizaciÃnDataGridViewTextBoxColumn.DataPropertyName = "Usuario de ActualizaciÃ³n"
        Me.UsuarioDeActualizaciÃnDataGridViewTextBoxColumn.HeaderText = "Usuario de ActualizaciÃ³n"
        Me.UsuarioDeActualizaciÃnDataGridViewTextBoxColumn.Name = "UsuarioDeActualizaciÃnDataGridViewTextBoxColumn"
        '
        'ConsultarEspecialidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 262)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ConsultarEspecialidades"
        Me.Text = "ConsultarEspecialidades"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OptometriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EspecialidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents OptometriaDataSet As OccuCita.optometria1DataSet
    Friend WithEvents EspecialidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EspecialidadTableAdapter As OccuCita.optometria1DataSetTableAdapters.especialidadTableAdapter
    Friend WithEvents IdEspecialidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EspecialidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDeActualizaciÃnDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDeActualizaciÃnDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
