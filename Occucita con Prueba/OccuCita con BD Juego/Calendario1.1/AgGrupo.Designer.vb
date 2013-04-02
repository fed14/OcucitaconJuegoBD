<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgGrupo
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtNombreGrupo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbxEspecialidad = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OptometriaDataSet = New OccuCita.optometria1DataSet()
        Me.EspecialidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EspecialidadTableAdapter = New OccuCita.optometria1DataSetTableAdapters.especialidadTableAdapter()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.OptometriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EspecialidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(270, 143)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(159, 143)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtNombreGrupo
        '
        Me.txtNombreGrupo.Location = New System.Drawing.Point(12, 25)
        Me.txtNombreGrupo.Name = "txtNombreGrupo"
        Me.txtNombreGrupo.Size = New System.Drawing.Size(220, 20)
        Me.txtNombreGrupo.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nombre del nuevo grupo:"
        '
        'cmbxEspecialidad
        '
        Me.cmbxEspecialidad.DataSource = Me.EspecialidadBindingSource
        Me.cmbxEspecialidad.DisplayMember = "Especialidad"
        Me.cmbxEspecialidad.FormattingEnabled = True
        Me.cmbxEspecialidad.Location = New System.Drawing.Point(13, 90)
        Me.cmbxEspecialidad.Name = "cmbxEspecialidad"
        Me.cmbxEspecialidad.Size = New System.Drawing.Size(219, 21)
        Me.cmbxEspecialidad.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Especialidad:"
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
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(258, 51)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Ver Grupos"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'AgGrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 178)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbxEspecialidad)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtNombreGrupo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AgGrupo"
        Me.Text = "Agregar Grupo"
        CType(Me.OptometriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EspecialidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtNombreGrupo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbxEspecialidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents OptometriaDataSet As OccuCita.optometria1DataSet
    Friend WithEvents EspecialidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EspecialidadTableAdapter As OccuCita.optometria1DataSetTableAdapters.especialidadTableAdapter
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
