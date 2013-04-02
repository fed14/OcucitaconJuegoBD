<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblDiadeCita = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.timeDe = New System.Windows.Forms.DateTimePicker()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCorreoElex = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNumTel = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.timeA = New System.Windows.Forms.DateTimePicker()
        Me.lblReviso = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.EstudiantesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstudiantesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbEstudiantes = New System.Windows.Forms.ComboBox()
        Me.OptometriaDataSet2 = New OccuCita.optometria1DataSet()
        Me.EstudiantesBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstudiantesTableAdapter2 = New OccuCita.optometria1DataSetTableAdapters.estudiantesTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.EstudiantesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstudiantesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OptometriaDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstudiantesBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDiadeCita
        '
        Me.lblDiadeCita.AutoSize = True
        Me.lblDiadeCita.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiadeCita.Location = New System.Drawing.Point(36, 35)
        Me.lblDiadeCita.Name = "lblDiadeCita"
        Me.lblDiadeCita.Size = New System.Drawing.Size(0, 23)
        Me.lblDiadeCita.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(101, 42)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(228, 20)
        Me.txtNombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cedula:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 328)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Hora:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(375, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Numero de Telelfono:"
        '
        'timeDe
        '
        Me.timeDe.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.timeDe.Location = New System.Drawing.Point(119, 335)
        Me.timeDe.Name = "timeDe"
        Me.timeDe.ShowUpDown = True
        Me.timeDe.Size = New System.Drawing.Size(88, 20)
        Me.timeDe.TabIndex = 7
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(101, 86)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(228, 20)
        Me.txtCedula.TabIndex = 4
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(329, 389)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(142, 26)
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(524, 389)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(142, 26)
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtCorreoElex)
        Me.GroupBox1.Controls.Add(Me.txtDireccion)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtNumTel)
        Me.GroupBox1.Controls.Add(Me.txtCedula)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(686, 174)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Paciente"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(387, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Correo Electronico:"
        '
        'txtCorreoElex
        '
        Me.txtCorreoElex.Location = New System.Drawing.Point(490, 133)
        Me.txtCorreoElex.Name = "txtCorreoElex"
        Me.txtCorreoElex.Size = New System.Drawing.Size(186, 20)
        Me.txtCorreoElex.TabIndex = 19
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(490, 85)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(186, 20)
        Me.txtDireccion.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(429, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Direccion:"
        '
        'txtNumTel
        '
        Me.txtNumTel.Location = New System.Drawing.Point(490, 39)
        Me.txtNumTel.Name = "txtNumTel"
        Me.txtNumTel.Size = New System.Drawing.Size(186, 20)
        Me.txtNumTel.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(609, 325)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 20)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Ver Citas"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(89, 338)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "De:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(96, 365)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "A:"
        '
        'timeA
        '
        Me.timeA.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.timeA.Location = New System.Drawing.Point(119, 365)
        Me.timeA.Name = "timeA"
        Me.timeA.ShowUpDown = True
        Me.timeA.Size = New System.Drawing.Size(88, 20)
        Me.timeA.TabIndex = 8
        '
        'lblReviso
        '
        Me.lblReviso.AutoSize = True
        Me.lblReviso.Location = New System.Drawing.Point(627, 269)
        Me.lblReviso.Name = "lblReviso"
        Me.lblReviso.Size = New System.Drawing.Size(39, 13)
        Me.lblReviso.TabIndex = 17
        Me.lblReviso.Text = "Label5"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(599, 296)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Ver Pacientes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'EstudiantesBindingSource1
        '
        Me.EstudiantesBindingSource1.DataMember = "estudiantes"
        '
        'EstudiantesBindingSource
        '
        Me.EstudiantesBindingSource.DataMember = "estudiantes"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(37, 290)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Estudiante:"
        '
        'cmbEstudiantes
        '
        Me.cmbEstudiantes.DataSource = Me.EstudiantesBindingSource2
        Me.cmbEstudiantes.DisplayMember = "Estudiantes"
        Me.cmbEstudiantes.FormattingEnabled = True
        Me.cmbEstudiantes.Location = New System.Drawing.Point(103, 287)
        Me.cmbEstudiantes.Name = "cmbEstudiantes"
        Me.cmbEstudiantes.Size = New System.Drawing.Size(121, 21)
        Me.cmbEstudiantes.TabIndex = 22
        '
        'OptometriaDataSet2
        '
        Me.OptometriaDataSet2.DataSetName = "optometriaDataSet"
        Me.OptometriaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EstudiantesBindingSource2
        '
        Me.EstudiantesBindingSource2.DataMember = "estudiantes"
        Me.EstudiantesBindingSource2.DataSource = Me.OptometriaDataSet2
        '
        'EstudiantesTableAdapter2
        '
        Me.EstudiantesTableAdapter2.ClearBeforeFill = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 442)
        Me.Controls.Add(Me.cmbEstudiantes)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblReviso)
        Me.Controls.Add(Me.timeA)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.timeDe)
        Me.Controls.Add(Me.lblDiadeCita)
        Me.Controls.Add(Me.Label3)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Nueva Cita"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.EstudiantesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstudiantesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OptometriaDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstudiantesBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDiadeCita As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents timeDe As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents timeA As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtNumTel As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lblReviso As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCorreoElex As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents OptometriaDataSet As OccuCita.optometria1DataSet
    Friend WithEvents EstudiantesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EstudiantesTableAdapter As OccuCita.optometria1DataSetTableAdapters.estudiantesTableAdapter
    Friend WithEvents OptometriaDataSet1 As OccuCita.optometria1DataSet
    Friend WithEvents EstudiantesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents EstudiantesTableAdapter1 As OccuCita.optometria1DataSetTableAdapters.estudiantesTableAdapter
    Friend WithEvents cmbEstudiantes As System.Windows.Forms.ComboBox
    Friend WithEvents OptometriaDataSet2 As OccuCita.optometria1DataSet
    Friend WithEvents EstudiantesBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents EstudiantesTableAdapter2 As OccuCita.optometria1DataSetTableAdapters.estudiantesTableAdapter
End Class
