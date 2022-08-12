<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cont_Tareas
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
        Me.cboContacto = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboContacto
        '
        Me.cboContacto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboContacto.FormattingEnabled = True
        Me.cboContacto.Location = New System.Drawing.Point(12, 53)
        Me.cboContacto.Name = "cboContacto"
        Me.cboContacto.Size = New System.Drawing.Size(364, 28)
        Me.cboContacto.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Seleccione el contacto"
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(12, 87)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(112, 34)
        Me.btnAtras.TabIndex = 2
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(264, 87)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(112, 34)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Cont_Tareas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(388, 133)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboContacto)
        Me.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Cont_Tareas"
        Me.Text = "Contactos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboContacto As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnAceptar As Button
End Class
