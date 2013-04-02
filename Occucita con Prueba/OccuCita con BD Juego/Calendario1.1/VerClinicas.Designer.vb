<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerClinicas
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
        Me.ClínicasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClínicasTableAdapter = New OccuCita.optometria1DataSetTableAdapters.clínicasTableAdapter()
        Me.IdClÃnicasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UbicaciÃnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OptometriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClínicasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdClÃnicasDataGridViewTextBoxColumn, Me.UbicaciÃnDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ClínicasBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(241, 262)
        Me.DataGridView1.TabIndex = 0
        '
        'OptometriaDataSet
        '
        Me.OptometriaDataSet.DataSetName = "optometriaDataSet"
        Me.OptometriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClínicasBindingSource
        '
        Me.ClínicasBindingSource.DataMember = "clínicas"
        Me.ClínicasBindingSource.DataSource = Me.OptometriaDataSet
        '
        'ClínicasTableAdapter
        '
        Me.ClínicasTableAdapter.ClearBeforeFill = True
        '
        'IdClÃnicasDataGridViewTextBoxColumn
        '
        Me.IdClÃnicasDataGridViewTextBoxColumn.DataPropertyName = "idClÃ­nicas"
        Me.IdClÃnicasDataGridViewTextBoxColumn.HeaderText = "idClÃ­nicas"
        Me.IdClÃnicasDataGridViewTextBoxColumn.Name = "IdClÃnicasDataGridViewTextBoxColumn"
        '
        'UbicaciÃnDataGridViewTextBoxColumn
        '
        Me.UbicaciÃnDataGridViewTextBoxColumn.DataPropertyName = "UbicaciÃ³n"
        Me.UbicaciÃnDataGridViewTextBoxColumn.HeaderText = "UbicaciÃ³n"
        Me.UbicaciÃnDataGridViewTextBoxColumn.Name = "UbicaciÃnDataGridViewTextBoxColumn"
        '
        'VerClinicas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(241, 262)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "VerClinicas"
        Me.Text = "VerClinicas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OptometriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClínicasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents OptometriaDataSet As OccuCita.optometria1DataSet
    Friend WithEvents ClínicasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClínicasTableAdapter As OccuCita.optometria1DataSetTableAdapters.clínicasTableAdapter
    Friend WithEvents IdClÃnicasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UbicaciÃnDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
