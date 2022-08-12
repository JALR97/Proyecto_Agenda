<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HBD
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbHBD = New System.Windows.Forms.ListBox()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnVer = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cumpleaños Cercanos"
        '
        'lbHBD
        '
        Me.lbHBD.FormattingEnabled = True
        Me.lbHBD.ItemHeight = 20
        Me.lbHBD.Location = New System.Drawing.Point(12, 50)
        Me.lbHBD.Name = "lbHBD"
        Me.lbHBD.Size = New System.Drawing.Size(338, 264)
        Me.lbHBD.TabIndex = 1
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(12, 329)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(159, 34)
        Me.btnAtras.TabIndex = 2
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnVer
        '
        Me.btnVer.Enabled = False
        Me.btnVer.Location = New System.Drawing.Point(191, 329)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(159, 34)
        Me.btnVer.TabIndex = 2
        Me.btnVer.Text = "Ver Contacto"
        Me.btnVer.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Location = New System.Drawing.Point(-6, -7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(374, 197)
        Me.Panel1.TabIndex = 3
        '
        'HBD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(362, 375)
        Me.Controls.Add(Me.btnVer)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.lbHBD)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "HBD"
        Me.Text = "HBD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbHBD As ListBox
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnVer As Button
    Friend WithEvents Panel1 As Panel
End Class
