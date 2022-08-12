<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VistaPendientes
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
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.gbTarea = New System.Windows.Forms.GroupBox()
        Me.btnVer = New System.Windows.Forms.Button()
        Me.btnAgendar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnTareaN = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbPendientes = New System.Windows.Forms.ListBox()
        Me.gbTarea.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblInfo
        '
        Me.lblInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblInfo.Font = New System.Drawing.Font("Courier New", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblInfo.Location = New System.Drawing.Point(15, 28)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(305, 100)
        Me.lblInfo.TabIndex = 19
        Me.lblInfo.Text = "-"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Montserrat SemiBold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitulo.Location = New System.Drawing.Point(15, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(20, 28)
        Me.lblTitulo.TabIndex = 20
        Me.lblTitulo.Text = "-"
        '
        'gbTarea
        '
        Me.gbTarea.Controls.Add(Me.btnVer)
        Me.gbTarea.Controls.Add(Me.btnAgendar)
        Me.gbTarea.Controls.Add(Me.btnEliminar)
        Me.gbTarea.Enabled = False
        Me.gbTarea.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.gbTarea.Location = New System.Drawing.Point(15, 131)
        Me.gbTarea.Name = "gbTarea"
        Me.gbTarea.Size = New System.Drawing.Size(278, 150)
        Me.gbTarea.TabIndex = 18
        Me.gbTarea.TabStop = False
        Me.gbTarea.Text = "Pendiente Seleccionado"
        '
        'btnVer
        '
        Me.btnVer.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnVer.Location = New System.Drawing.Point(6, 97)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(123, 34)
        Me.btnVer.TabIndex = 1
        Me.btnVer.Text = "Ver"
        Me.btnVer.UseVisualStyleBackColor = True
        '
        'btnAgendar
        '
        Me.btnAgendar.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAgendar.Location = New System.Drawing.Point(6, 43)
        Me.btnAgendar.Name = "btnAgendar"
        Me.btnAgendar.Size = New System.Drawing.Size(123, 34)
        Me.btnAgendar.TabIndex = 2
        Me.btnAgendar.Text = "Agendar"
        Me.btnAgendar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEliminar.Location = New System.Drawing.Point(149, 97)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(123, 34)
        Me.btnEliminar.TabIndex = 1
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAtras.Location = New System.Drawing.Point(12, 349)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(153, 34)
        Me.btnAtras.TabIndex = 16
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnTareaN
        '
        Me.btnTareaN.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnTareaN.Location = New System.Drawing.Point(15, 287)
        Me.btnTareaN.Name = "btnTareaN"
        Me.btnTareaN.Size = New System.Drawing.Size(278, 34)
        Me.btnTareaN.TabIndex = 17
        Me.btnTareaN.Text = "Nueva Tarea"
        Me.btnTareaN.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.lblTitulo)
        Me.Panel1.Controls.Add(Me.gbTarea)
        Me.Panel1.Controls.Add(Me.btnTareaN)
        Me.Panel1.Controls.Add(Me.lblInfo)
        Me.Panel1.Location = New System.Drawing.Point(309, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(338, 329)
        Me.Panel1.TabIndex = 3
        '
        'lbPendientes
        '
        Me.lbPendientes.FormattingEnabled = True
        Me.lbPendientes.ItemHeight = 25
        Me.lbPendientes.Location = New System.Drawing.Point(12, 12)
        Me.lbPendientes.Name = "lbPendientes"
        Me.lbPendientes.Size = New System.Drawing.Size(298, 329)
        Me.lbPendientes.TabIndex = 3
        '
        'VistaPendientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(641, 391)
        Me.Controls.Add(Me.lbPendientes)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "VistaPendientes"
        Me.Text = "Tareas Pendientes"
        Me.gbTarea.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblInfo As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents gbTarea As GroupBox
    Friend WithEvents btnVer As Button
    Friend WithEvents btnAgendar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnTareaN As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbPendientes As ListBox
End Class
