<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarEstudianesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CursosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarEspecialidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblDia = New System.Windows.Forms.Label()
        Me.picBox7 = New System.Windows.Forms.PictureBox()
        Me.picBox8 = New System.Windows.Forms.PictureBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ClinicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarClinicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.OptometriaDataSet = New OccuCita.optometria1DataSet()
        Me.CitahasclínicasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cita_has_clínicasTableAdapter = New OccuCita.optometria1DataSetTableAdapters.citaTableAdapter()
        Me.EspecialidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EspecialidadTableAdapter = New OccuCita.optometria1DataSetTableAdapters.especialidadTableAdapter()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.EstudiantesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstudiantesTableAdapter = New OccuCita.optometria1DataSetTableAdapters.estudiantesTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.picBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.OptometriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CitahasclínicasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EspecialidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstudiantesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1043, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DatosToolStripMenuItem
        '
        Me.DatosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarEstudianesToolStripMenuItem, Me.CursosToolStripMenuItem, Me.ClinicaToolStripMenuItem})
        Me.DatosToolStripMenuItem.Name = "DatosToolStripMenuItem"
        Me.DatosToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.DatosToolStripMenuItem.Text = "Datos"
        '
        'AgregarEstudianesToolStripMenuItem
        '
        Me.AgregarEstudianesToolStripMenuItem.Name = "AgregarEstudianesToolStripMenuItem"
        Me.AgregarEstudianesToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.AgregarEstudianesToolStripMenuItem.Text = "Agregar Estudianes"
        '
        'CursosToolStripMenuItem
        '
        Me.CursosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarEspecialidadesToolStripMenuItem})
        Me.CursosToolStripMenuItem.Name = "CursosToolStripMenuItem"
        Me.CursosToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.CursosToolStripMenuItem.Text = "Especialidades"
        '
        'AgregarEspecialidadesToolStripMenuItem
        '
        Me.AgregarEspecialidadesToolStripMenuItem.Name = "AgregarEspecialidadesToolStripMenuItem"
        Me.AgregarEspecialidadesToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.AgregarEspecialidadesToolStripMenuItem.Text = "Agregar Especialidades"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.ListBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(174, 243)
        Me.Panel1.TabIndex = 0
        '
        'lblDia
        '
        Me.lblDia.AutoSize = True
        Me.lblDia.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDia.ForeColor = System.Drawing.Color.White
        Me.lblDia.Location = New System.Drawing.Point(12, 9)
        Me.lblDia.Name = "lblDia"
        Me.lblDia.Size = New System.Drawing.Size(0, 23)
        Me.lblDia.TabIndex = 7
        '
        'picBox7
        '
        Me.picBox7.BackgroundImage = CType(resources.GetObject("picBox7.BackgroundImage"), System.Drawing.Image)
        Me.picBox7.Image = CType(resources.GetObject("picBox7.Image"), System.Drawing.Image)
        Me.picBox7.Location = New System.Drawing.Point(363, 3)
        Me.picBox7.Name = "picBox7"
        Me.picBox7.Size = New System.Drawing.Size(36, 35)
        Me.picBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBox7.TabIndex = 2
        Me.picBox7.TabStop = False
        '
        'picBox8
        '
        Me.picBox8.BackgroundImage = CType(resources.GetObject("picBox8.BackgroundImage"), System.Drawing.Image)
        Me.picBox8.Image = CType(resources.GetObject("picBox8.Image"), System.Drawing.Image)
        Me.picBox8.Location = New System.Drawing.Point(363, 3)
        Me.picBox8.Name = "picBox8"
        Me.picBox8.Size = New System.Drawing.Size(36, 35)
        Me.picBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBox8.TabIndex = 5
        Me.picBox8.TabStop = False
        Me.picBox8.Visible = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Green
        Me.Panel8.Controls.Add(Me.picBox8)
        Me.Panel8.Controls.Add(Me.picBox7)
        Me.Panel8.Controls.Add(Me.lblDia)
        Me.Panel8.Location = New System.Drawing.Point(617, 67)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(402, 41)
        Me.Panel8.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Green
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(174, 38)
        Me.Panel5.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(18, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Grupos"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Location = New System.Drawing.Point(211, 67)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(174, 243)
        Me.Panel2.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Green
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(174, 38)
        Me.Panel6.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Estudiantes"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Controls.Add(Me.ListBox2)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Location = New System.Drawing.Point(409, 67)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(174, 243)
        Me.Panel3.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(14, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Especialidades"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Green
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Location = New System.Drawing.Point(12, 67)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(174, 38)
        Me.Panel4.TabIndex = 0
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.BackColor = System.Drawing.Color.Green
        Me.MonthCalendar1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MonthCalendar1.Location = New System.Drawing.Point(155, 392)
        Me.MonthCalendar1.MaximumSize = New System.Drawing.Size(999, 999)
        Me.MonthCalendar1.MaxSelectionCount = 1
        Me.MonthCalendar1.MinDate = New Date(2010, 2, 28, 0, 0, 0, 0)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.ShowTodayCircle = False
        Me.MonthCalendar1.TabIndex = 2
        Me.MonthCalendar1.TitleBackColor = System.Drawing.Color.Green
        Me.MonthCalendar1.TitleForeColor = System.Drawing.SystemColors.ControlDark
        Me.MonthCalendar1.TrailingForeColor = System.Drawing.Color.OliveDrab
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(617, 69)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(402, 525)
        Me.Panel7.TabIndex = 3
        '
        'Panel10
        '
        Me.Panel10.Location = New System.Drawing.Point(617, 392)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(272, 36)
        Me.Panel10.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(658, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 20)
        Me.Label4.TabIndex = 5
        '
        'ClinicaToolStripMenuItem
        '
        Me.ClinicaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarClinicaToolStripMenuItem})
        Me.ClinicaToolStripMenuItem.Name = "ClinicaToolStripMenuItem"
        Me.ClinicaToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ClinicaToolStripMenuItem.Text = "Clinica "
        '
        'AgregarClinicaToolStripMenuItem
        '
        Me.AgregarClinicaToolStripMenuItem.Name = "AgregarClinicaToolStripMenuItem"
        Me.AgregarClinicaToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.AgregarClinicaToolStripMenuItem.Text = "Agregar Clinica"
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.EspecialidadBindingSource
        Me.ListBox1.DisplayMember = "Especialidad"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(0, 35)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(174, 212)
        Me.ListBox1.TabIndex = 0
        '
        'OptometriaDataSet
        '
        Me.OptometriaDataSet.DataSetName = "optometriaDataSet"
        Me.OptometriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CitahasclínicasBindingSource
        '
        Me.CitahasclínicasBindingSource.DataMember = "cita_has_clínicas"
        Me.CitahasclínicasBindingSource.DataSource = Me.OptometriaDataSet
        '
        'Cita_has_clínicasTableAdapter
        '
        Me.Cita_has_clínicasTableAdapter.ClearBeforeFill = True
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
        'ListBox2
        '
        Me.ListBox2.DataSource = Me.EstudiantesBindingSource
        Me.ListBox2.DisplayMember = "Nombre"
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(0, 35)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(174, 212)
        Me.ListBox2.TabIndex = 3
        '
        'EstudiantesBindingSource
        '
        Me.EstudiantesBindingSource.DataMember = "estudiantes"
        Me.EstudiantesBindingSource.DataSource = Me.OptometriaDataSet
        '
        'EstudiantesTableAdapter
        '
        Me.EstudiantesTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1043, 617)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.RightToLeftLayout = True
        Me.Text = "Especialidades"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.picBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblDia As System.Windows.Forms.Label
    Friend WithEvents picBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarEstudianesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CursosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarEspecialidadesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClinicaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarClinicaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents OptometriaDataSet As OccuCita.optometria1DataSet
    Friend WithEvents CitahasclínicasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cita_has_clínicasTableAdapter As OccuCita.optometria1DataSetTableAdapters.citaTableAdapter
    Friend WithEvents EspecialidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EspecialidadTableAdapter As OccuCita.optometria1DataSetTableAdapters.especialidadTableAdapter
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents EstudiantesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EstudiantesTableAdapter As OccuCita.optometria1DataSetTableAdapters.estudiantesTableAdapter

End Class
