<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NuevaTarea
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.radSi = New System.Windows.Forms.RadioButton()
        Me.radNo = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnNuevoContacto = New System.Windows.Forms.Button()
        Me.lbContactos = New System.Windows.Forms.ListBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtLugar = New System.Windows.Forms.TextBox()
        Me.txtInfo = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.cboCategoria = New System.Windows.Forms.ComboBox()
        Me.cboPrioridad = New System.Windows.Forms.ComboBox()
        Me.btnNuevaCat = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblHeader.Location = New System.Drawing.Point(12, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(490, 33)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Ingrese la informacion de la nueva tarea"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(23, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Titulo"
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(137, 63)
        Me.txtTitulo.MaxLength = 25
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(326, 28)
        Me.txtTitulo.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(23, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Prioridad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(23, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Categoria"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(23, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Lugar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(23, 272)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Info Extra"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 400)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 20)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Agendar?"
        '
        'radSi
        '
        Me.radSi.AutoSize = True
        Me.radSi.Location = New System.Drawing.Point(126, 398)
        Me.radSi.Name = "radSi"
        Me.radSi.Size = New System.Drawing.Size(56, 24)
        Me.radSi.TabIndex = 3
        Me.radSi.Text = "Si"
        Me.radSi.UseVisualStyleBackColor = True
        '
        'radNo
        '
        Me.radNo.AutoSize = True
        Me.radNo.Checked = True
        Me.radNo.Location = New System.Drawing.Point(188, 398)
        Me.radNo.Name = "radNo"
        Me.radNo.Size = New System.Drawing.Size(56, 24)
        Me.radNo.TabIndex = 4
        Me.radNo.TabStop = True
        Me.radNo.Text = "No"
        Me.radNo.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 437)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 20)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Fecha"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 489)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 20)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Contactos"
        '
        'btnNuevoContacto
        '
        Me.btnNuevoContacto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNuevoContacto.Location = New System.Drawing.Point(393, 512)
        Me.btnNuevoContacto.Name = "btnNuevoContacto"
        Me.btnNuevoContacto.Size = New System.Drawing.Size(109, 34)
        Me.btnNuevoContacto.TabIndex = 6
        Me.btnNuevoContacto.Text = "Agregar"
        Me.btnNuevoContacto.UseVisualStyleBackColor = True
        '
        'lbContactos
        '
        Me.lbContactos.FormattingEnabled = True
        Me.lbContactos.ItemHeight = 20
        Me.lbContactos.Location = New System.Drawing.Point(23, 512)
        Me.lbContactos.Name = "lbContactos"
        Me.lbContactos.Size = New System.Drawing.Size(364, 84)
        Me.lbContactos.TabIndex = 7
        '
        'btnEliminar
        '
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEliminar.Location = New System.Drawing.Point(393, 562)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(109, 34)
        Me.btnEliminar.TabIndex = 6
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(93, 432)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(370, 28)
        Me.dtpFecha.TabIndex = 8
        '
        'txtLugar
        '
        Me.txtLugar.Location = New System.Drawing.Point(137, 220)
        Me.txtLugar.MaxLength = 30
        Me.txtLugar.Name = "txtLugar"
        Me.txtLugar.Size = New System.Drawing.Size(326, 28)
        Me.txtLugar.TabIndex = 2
        '
        'txtInfo
        '
        Me.txtInfo.Location = New System.Drawing.Point(23, 295)
        Me.txtInfo.MaxLength = 110
        Me.txtInfo.Multiline = True
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.Size = New System.Drawing.Size(440, 80)
        Me.txtInfo.TabIndex = 9
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(23, 620)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(179, 34)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Atras"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnFinalizar
        '
        Me.btnFinalizar.Location = New System.Drawing.Point(322, 620)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(179, 34)
        Me.btnFinalizar.TabIndex = 6
        Me.btnFinalizar.Text = "Finalizar"
        Me.btnFinalizar.UseVisualStyleBackColor = True
        '
        'cboCategoria
        '
        Me.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategoria.FormattingEnabled = True
        Me.cboCategoria.Location = New System.Drawing.Point(137, 170)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(243, 28)
        Me.cboCategoria.TabIndex = 10
        '
        'cboPrioridad
        '
        Me.cboPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPrioridad.FormattingEnabled = True
        Me.cboPrioridad.Items.AddRange(New Object() {"Baja", "Media", "Alta"})
        Me.cboPrioridad.Location = New System.Drawing.Point(137, 117)
        Me.cboPrioridad.Name = "cboPrioridad"
        Me.cboPrioridad.Size = New System.Drawing.Size(243, 28)
        Me.cboPrioridad.TabIndex = 10
        '
        'btnNuevaCat
        '
        Me.btnNuevaCat.BackColor = System.Drawing.Color.Transparent
        Me.btnNuevaCat.Location = New System.Drawing.Point(394, 122)
        Me.btnNuevaCat.Name = "btnNuevaCat"
        Me.btnNuevaCat.Size = New System.Drawing.Size(77, 28)
        Me.btnNuevaCat.TabIndex = 6
        Me.btnNuevaCat.Text = "Nueva"
        Me.btnNuevaCat.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.btnNuevaCat)
        Me.Panel1.Location = New System.Drawing.Point(-8, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(531, 289)
        Me.Panel1.TabIndex = 11
        '
        'NuevaTarea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(513, 666)
        Me.Controls.Add(Me.cboPrioridad)
        Me.Controls.Add(Me.cboCategoria)
        Me.Controls.Add(Me.txtInfo)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.lbContactos)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnFinalizar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnNuevoContacto)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.radNo)
        Me.Controls.Add(Me.radSi)
        Me.Controls.Add(Me.txtLugar)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "NuevaTarea"
        Me.Text = "Nueva Tarea"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents radSi As RadioButton
    Friend WithEvents radNo As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnNuevoContacto As Button
    Friend WithEvents lbContactos As ListBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents txtLugar As TextBox
    Friend WithEvents txtInfo As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnFinalizar As Button
    Friend WithEvents cboCategoria As ComboBox
    Friend WithEvents cboPrioridad As ComboBox
    Friend WithEvents btnNuevaCat As Button
    Friend WithEvents Panel1 As Panel
End Class
