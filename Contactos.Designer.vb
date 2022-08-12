<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contactos
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
        Me.lbContactos = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnVer = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbContactos
        '
        Me.lbContactos.FormattingEnabled = True
        Me.lbContactos.ItemHeight = 20
        Me.lbContactos.Location = New System.Drawing.Point(12, 40)
        Me.lbContactos.Name = "lbContactos"
        Me.lbContactos.Size = New System.Drawing.Size(305, 264)
        Me.lbContactos.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Lista de Contactos"
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(12, 310)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(112, 34)
        Me.btnAtras.TabIndex = 2
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.Transparent
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Location = New System.Drawing.Point(8, 50)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(148, 34)
        Me.btnNuevo.TabIndex = 2
        Me.btnNuevo.Text = "+ Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnVer
        '
        Me.btnVer.BackColor = System.Drawing.Color.Transparent
        Me.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVer.Location = New System.Drawing.Point(8, 100)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(148, 34)
        Me.btnVer.TabIndex = 2
        Me.btnVer.Text = "Ver"
        Me.btnVer.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Location = New System.Drawing.Point(8, 150)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(148, 34)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Controls.Add(Me.btnVer)
        Me.Panel1.Controls.Add(Me.btnNuevo)
        Me.Panel1.Location = New System.Drawing.Point(315, -10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(174, 368)
        Me.Panel1.TabIndex = 3
        '
        'Contactos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(482, 351)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbContactos)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Contactos"
        Me.Text = "Contactos"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbContactos As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnVer As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Panel1 As Panel
End Class
