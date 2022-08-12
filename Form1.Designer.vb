<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnVistaT = New System.Windows.Forms.Button()
        Me.btnPendientes = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.btnHPB = New System.Windows.Forms.Button()
        Me.btnContactos = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(-12, -11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(786, 76)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Azure
        Me.Label1.Location = New System.Drawing.Point(24, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "TAREAS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Azure
        Me.Label2.Location = New System.Drawing.Point(371, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 39)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CONTACTOS"
        '
        'btnVistaT
        '
        Me.btnVistaT.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnVistaT.Location = New System.Drawing.Point(12, 87)
        Me.btnVistaT.Name = "btnVistaT"
        Me.btnVistaT.Size = New System.Drawing.Size(255, 34)
        Me.btnVistaT.TabIndex = 4
        Me.btnVistaT.Text = "Tareas Cercanas"
        Me.btnVistaT.UseVisualStyleBackColor = True
        '
        'btnPendientes
        '
        Me.btnPendientes.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnPendientes.Location = New System.Drawing.Point(12, 139)
        Me.btnPendientes.Name = "btnPendientes"
        Me.btnPendientes.Size = New System.Drawing.Size(255, 34)
        Me.btnPendientes.TabIndex = 5
        Me.btnPendientes.Text = "Tareas sin Agendar"
        Me.btnPendientes.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnSalir.Location = New System.Drawing.Point(12, 192)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(255, 34)
        Me.BtnSalir.TabIndex = 6
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'btnHPB
        '
        Me.btnHPB.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnHPB.Location = New System.Drawing.Point(306, 139)
        Me.btnHPB.Name = "btnHPB"
        Me.btnHPB.Size = New System.Drawing.Size(255, 34)
        Me.btnHPB.TabIndex = 8
        Me.btnHPB.Text = "Lista de Cumpleaños"
        Me.btnHPB.UseVisualStyleBackColor = True
        '
        'btnContactos
        '
        Me.btnContactos.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnContactos.Location = New System.Drawing.Point(306, 87)
        Me.btnContactos.Name = "btnContactos"
        Me.btnContactos.Size = New System.Drawing.Size(255, 34)
        Me.btnContactos.TabIndex = 9
        Me.btnContactos.Text = "Todos los Contactos"
        Me.btnContactos.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(573, 251)
        Me.Controls.Add(Me.btnContactos)
        Me.Controls.Add(Me.btnHPB)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.btnPendientes)
        Me.Controls.Add(Me.btnVistaT)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Inicio"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnVistaT As Button
    Friend WithEvents btnPendientes As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents btnHPB As Button
    Friend WithEvents btnContactos As Button
End Class
