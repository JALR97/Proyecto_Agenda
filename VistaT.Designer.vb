<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VistaT
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
        Me.gbLayout = New System.Windows.Forms.GroupBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.chkListas = New System.Windows.Forms.CheckBox()
        Me.radFecha = New System.Windows.Forms.RadioButton()
        Me.radSemana = New System.Windows.Forms.RadioButton()
        Me.radHoy = New System.Windows.Forms.RadioButton()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblPrioridad = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gbTarea = New System.Windows.Forms.GroupBox()
        Me.btnVer = New System.Windows.Forms.Button()
        Me.btnReagendar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnTareaN = New System.Windows.Forms.Button()
        Me.lbTareas = New System.Windows.Forms.ListBox()
        Me.gbLayout.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gbTarea.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbLayout
        '
        Me.gbLayout.Controls.Add(Me.dtpFecha)
        Me.gbLayout.Controls.Add(Me.chkListas)
        Me.gbLayout.Controls.Add(Me.radFecha)
        Me.gbLayout.Controls.Add(Me.radSemana)
        Me.gbLayout.Controls.Add(Me.radHoy)
        Me.gbLayout.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.gbLayout.Location = New System.Drawing.Point(501, 219)
        Me.gbLayout.Name = "gbLayout"
        Me.gbLayout.Size = New System.Drawing.Size(294, 146)
        Me.gbLayout.TabIndex = 16
        Me.gbLayout.TabStop = False
        Me.gbLayout.Text = "Tareas a mostrar"
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(42, 73)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(184, 29)
        Me.dtpFecha.TabIndex = 2
        '
        'chkListas
        '
        Me.chkListas.AutoSize = True
        Me.chkListas.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.chkListas.Location = New System.Drawing.Point(15, 116)
        Me.chkListas.Name = "chkListas"
        Me.chkListas.Size = New System.Drawing.Size(266, 24)
        Me.chkListas.TabIndex = 1
        Me.chkListas.Text = "Mostrar tareas listas"
        Me.chkListas.UseVisualStyleBackColor = True
        '
        'radFecha
        '
        Me.radFecha.AutoSize = True
        Me.radFecha.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.radFecha.Location = New System.Drawing.Point(15, 78)
        Me.radFecha.Name = "radFecha"
        Me.radFecha.Size = New System.Drawing.Size(21, 20)
        Me.radFecha.TabIndex = 0
        Me.radFecha.TabStop = True
        Me.radFecha.UseVisualStyleBackColor = True
        '
        'radSemana
        '
        Me.radSemana.AutoSize = True
        Me.radSemana.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.radSemana.Location = New System.Drawing.Point(126, 39)
        Me.radSemana.Name = "radSemana"
        Me.radSemana.Size = New System.Drawing.Size(100, 24)
        Me.radSemana.TabIndex = 0
        Me.radSemana.TabStop = True
        Me.radSemana.Text = "Semana"
        Me.radSemana.UseVisualStyleBackColor = True
        '
        'radHoy
        '
        Me.radHoy.AutoSize = True
        Me.radHoy.Checked = True
        Me.radHoy.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.radHoy.Location = New System.Drawing.Point(15, 39)
        Me.radHoy.Name = "radHoy"
        Me.radHoy.Size = New System.Drawing.Size(67, 24)
        Me.radHoy.TabIndex = 0
        Me.radHoy.TabStop = True
        Me.radHoy.Text = "Hoy"
        Me.radHoy.UseVisualStyleBackColor = True
        '
        'lblInfo
        '
        Me.lblInfo.BackColor = System.Drawing.SystemColors.Control
        Me.lblInfo.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblInfo.Location = New System.Drawing.Point(496, 75)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(299, 141)
        Me.lblInfo.TabIndex = 12
        Me.lblInfo.Text = "-"
        '
        'lblPrioridad
        '
        Me.lblPrioridad.AutoSize = True
        Me.lblPrioridad.BackColor = System.Drawing.SystemColors.Control
        Me.lblPrioridad.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPrioridad.Location = New System.Drawing.Point(531, 46)
        Me.lblPrioridad.Name = "lblPrioridad"
        Me.lblPrioridad.Size = New System.Drawing.Size(20, 20)
        Me.lblPrioridad.TabIndex = 13
        Me.lblPrioridad.Text = "-"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.SystemColors.Control
        Me.lblTitulo.Font = New System.Drawing.Font("Montserrat SemiBold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitulo.Location = New System.Drawing.Point(531, 18)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(20, 28)
        Me.lblTitulo.TabIndex = 14
        Me.lblTitulo.Text = "-"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.lblPrioridad)
        Me.Panel1.Controls.Add(Me.lblTitulo)
        Me.Panel1.Location = New System.Drawing.Point(-35, -5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(852, 221)
        Me.Panel1.TabIndex = 15
        '
        'gbTarea
        '
        Me.gbTarea.Controls.Add(Me.btnVer)
        Me.gbTarea.Controls.Add(Me.btnReagendar)
        Me.gbTarea.Controls.Add(Me.btnEliminar)
        Me.gbTarea.Enabled = False
        Me.gbTarea.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.gbTarea.Location = New System.Drawing.Point(496, 371)
        Me.gbTarea.Name = "gbTarea"
        Me.gbTarea.Size = New System.Drawing.Size(300, 121)
        Me.gbTarea.TabIndex = 11
        Me.gbTarea.TabStop = False
        Me.gbTarea.Text = "Tarea Seleccionada"
        '
        'btnVer
        '
        Me.btnVer.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnVer.Location = New System.Drawing.Point(6, 37)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(123, 34)
        Me.btnVer.TabIndex = 1
        Me.btnVer.Text = "Ver"
        Me.btnVer.UseVisualStyleBackColor = True
        '
        'btnReagendar
        '
        Me.btnReagendar.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnReagendar.Location = New System.Drawing.Point(6, 77)
        Me.btnReagendar.Name = "btnReagendar"
        Me.btnReagendar.Size = New System.Drawing.Size(288, 34)
        Me.btnReagendar.TabIndex = 2
        Me.btnReagendar.Text = "Reagendar"
        Me.btnReagendar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEliminar.Location = New System.Drawing.Point(171, 37)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(123, 34)
        Me.btnEliminar.TabIndex = 1
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAtras.Location = New System.Drawing.Point(18, 516)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(153, 34)
        Me.btnAtras.TabIndex = 8
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnTareaN
        '
        Me.btnTareaN.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnTareaN.Location = New System.Drawing.Point(501, 516)
        Me.btnTareaN.Name = "btnTareaN"
        Me.btnTareaN.Size = New System.Drawing.Size(294, 34)
        Me.btnTareaN.TabIndex = 10
        Me.btnTareaN.Text = "Nueva Tarea"
        Me.btnTareaN.UseVisualStyleBackColor = True
        '
        'lbTareas
        '
        Me.lbTareas.FormattingEnabled = True
        Me.lbTareas.ItemHeight = 25
        Me.lbTareas.Location = New System.Drawing.Point(12, 13)
        Me.lbTareas.Name = "lbTareas"
        Me.lbTareas.Size = New System.Drawing.Size(478, 479)
        Me.lbTareas.TabIndex = 17
        '
        'VistaT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(807, 562)
        Me.Controls.Add(Me.lbTareas)
        Me.Controls.Add(Me.gbLayout)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gbTarea)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnTareaN)
        Me.Name = "VistaT"
        Me.Text = "Tareas Cercanas"
        Me.gbLayout.ResumeLayout(False)
        Me.gbLayout.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gbTarea.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbLayout As GroupBox
    Friend WithEvents radSemana As RadioButton
    Friend WithEvents radHoy As RadioButton
    Friend WithEvents lblInfo As Label
    Friend WithEvents lblPrioridad As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents gbTarea As GroupBox
    Friend WithEvents btnVer As Button
    Friend WithEvents btnReagendar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnTareaN As Button
    Friend WithEvents chkListas As CheckBox
    Friend WithEvents lbTareas As ListBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents radFecha As RadioButton
End Class
