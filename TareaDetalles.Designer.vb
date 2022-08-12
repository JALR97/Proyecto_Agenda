<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TareaDetalles
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblPrioridad = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.chkListo = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnVerContacto = New System.Windows.Forms.Button()
        Me.lblModificar = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnEliminarTarea = New System.Windows.Forms.Button()
        Me.lbContactos = New System.Windows.Forms.ListBox()
        Me.lblContactos = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTitulo.Location = New System.Drawing.Point(12, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(33, 33)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "--"
        '
        'lblPrioridad
        '
        Me.lblPrioridad.AutoSize = True
        Me.lblPrioridad.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.lblPrioridad.Location = New System.Drawing.Point(12, 48)
        Me.lblPrioridad.Name = "lblPrioridad"
        Me.lblPrioridad.Size = New System.Drawing.Size(108, 20)
        Me.lblPrioridad.TabIndex = 0
        Me.lblPrioridad.Text = "Prioridad"
        '
        'lblInfo
        '
        Me.lblInfo.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblInfo.Location = New System.Drawing.Point(12, 87)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(509, 71)
        Me.lblInfo.TabIndex = 0
        Me.lblInfo.Text = "-"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblFecha.Location = New System.Drawing.Point(406, 23)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(70, 22)
        Me.lblFecha.TabIndex = 0
        Me.lblFecha.Text = "Fecha"
        '
        'chkListo
        '
        Me.chkListo.AutoSize = True
        Me.chkListo.Location = New System.Drawing.Point(431, 48)
        Me.chkListo.Name = "chkListo"
        Me.chkListo.Size = New System.Drawing.Size(90, 24)
        Me.chkListo.TabIndex = 1
        Me.chkListo.Text = "Lista"
        Me.chkListo.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.btnVerContacto)
        Me.Panel1.Controls.Add(Me.lblModificar)
        Me.Panel1.Controls.Add(Me.btnAtras)
        Me.Panel1.Controls.Add(Me.btnEliminarTarea)
        Me.Panel1.Controls.Add(Me.lbContactos)
        Me.Panel1.Controls.Add(Me.lblContactos)
        Me.Panel1.Controls.Add(Me.lblDireccion)
        Me.Panel1.Controls.Add(Me.lblCategoria)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-7, 164)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(547, 266)
        Me.Panel1.TabIndex = 2
        '
        'btnVerContacto
        '
        Me.btnVerContacto.Enabled = False
        Me.btnVerContacto.Location = New System.Drawing.Point(372, 57)
        Me.btnVerContacto.Name = "btnVerContacto"
        Me.btnVerContacto.Size = New System.Drawing.Size(156, 34)
        Me.btnVerContacto.TabIndex = 2
        Me.btnVerContacto.Text = "Ver Contacto"
        Me.btnVerContacto.UseVisualStyleBackColor = True
        '
        'lblModificar
        '
        Me.lblModificar.Location = New System.Drawing.Point(197, 207)
        Me.lblModificar.Name = "lblModificar"
        Me.lblModificar.Size = New System.Drawing.Size(156, 34)
        Me.lblModificar.TabIndex = 2
        Me.lblModificar.Text = "Modificar"
        Me.lblModificar.UseVisualStyleBackColor = True
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(19, 207)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(156, 34)
        Me.btnAtras.TabIndex = 2
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnEliminarTarea
        '
        Me.btnEliminarTarea.Location = New System.Drawing.Point(372, 207)
        Me.btnEliminarTarea.Name = "btnEliminarTarea"
        Me.btnEliminarTarea.Size = New System.Drawing.Size(156, 34)
        Me.btnEliminarTarea.TabIndex = 2
        Me.btnEliminarTarea.Text = "Eliminar"
        Me.btnEliminarTarea.UseVisualStyleBackColor = True
        '
        'lbContactos
        '
        Me.lbContactos.FormattingEnabled = True
        Me.lbContactos.ItemHeight = 20
        Me.lbContactos.Location = New System.Drawing.Point(19, 97)
        Me.lbContactos.Name = "lbContactos"
        Me.lbContactos.Size = New System.Drawing.Size(509, 104)
        Me.lbContactos.TabIndex = 1
        '
        'lblContactos
        '
        Me.lblContactos.AutoSize = True
        Me.lblContactos.Font = New System.Drawing.Font("Courier New", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblContactos.Location = New System.Drawing.Point(19, 67)
        Me.lblContactos.Name = "lblContactos"
        Me.lblContactos.Size = New System.Drawing.Size(127, 24)
        Me.lblContactos.TabIndex = 0
        Me.lblContactos.Text = "CONTACTOS"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDireccion.Location = New System.Drawing.Point(143, 35)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(22, 22)
        Me.lblDireccion.TabIndex = 0
        Me.lblDireccion.Text = "-"
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCategoria.Location = New System.Drawing.Point(143, 13)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(22, 22)
        Me.lblCategoria.TabIndex = 0
        Me.lblCategoria.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(19, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Direccion:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(19, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Categoria:"
        '
        'TareaDetalles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(533, 414)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.chkListo)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblPrioridad)
        Me.Controls.Add(Me.lblTitulo)
        Me.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "TareaDetalles"
        Me.Text = "Tarea"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblPrioridad As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents chkListo As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnVerContacto As Button
    Friend WithEvents lblModificar As Button
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnEliminarTarea As Button
    Friend WithEvents lbContactos As ListBox
    Friend WithEvents lblContactos As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblCategoria As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
