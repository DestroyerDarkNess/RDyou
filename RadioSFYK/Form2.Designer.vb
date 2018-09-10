<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.estadointernet = New System.Windows.Forms.Label()
        Me.ip = New System.Windows.Forms.Label()
        Me.estado = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FlatButton1 = New RadioSFYK.FlatButton()
        Me.FlatAlertBox1 = New RadioSFYK.FlatAlertBox()
        Me.FlatButton2 = New RadioSFYK.FlatButton()
        Me.SuspendLayout()
        '
        'estadointernet
        '
        Me.estadointernet.AutoSize = True
        Me.estadointernet.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estadointernet.ForeColor = System.Drawing.Color.DodgerBlue
        Me.estadointernet.Location = New System.Drawing.Point(95, 9)
        Me.estadointernet.Name = "estadointernet"
        Me.estadointernet.Size = New System.Drawing.Size(77, 14)
        Me.estadointernet.TabIndex = 0
        Me.estadointernet.Text = "Getting..."
        '
        'ip
        '
        Me.ip.AutoSize = True
        Me.ip.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ip.ForeColor = System.Drawing.Color.DodgerBlue
        Me.ip.Location = New System.Drawing.Point(129, 202)
        Me.ip.Name = "ip"
        Me.ip.Size = New System.Drawing.Size(105, 14)
        Me.ip.TabIndex = 1
        Me.ip.Text = "---.---.---.--"
        '
        'estado
        '
        Me.estado.AutoSize = True
        Me.estado.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estado.ForeColor = System.Drawing.Color.DodgerBlue
        Me.estado.Location = New System.Drawing.Point(-2, 188)
        Me.estado.Name = "estado"
        Me.estado.Size = New System.Drawing.Size(294, 14)
        Me.estado.TabIndex = 2
        Me.estado.Text = "Status: Validating Internet connection..."
        Me.estado.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 14)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Internet:"
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(298, 83)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.DodgerBlue
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(206, 1)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(100, 28)
        Me.FlatButton1.TabIndex = 6
        Me.FlatButton1.Text = "Continue"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.FlatButton1.Visible = False
        '
        'FlatAlertBox1
        '
        Me.FlatAlertBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatAlertBox1.Enabled = False
        Me.FlatAlertBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatAlertBox1.kind = RadioSFYK.FlatAlertBox._Kind.Info
        Me.FlatAlertBox1.Location = New System.Drawing.Point(-1, 35)
        Me.FlatAlertBox1.Name = "FlatAlertBox1"
        Me.FlatAlertBox1.Size = New System.Drawing.Size(330, 42)
        Me.FlatAlertBox1.TabIndex = 3
        Me.FlatAlertBox1.Text = "Verifying Connectivity .."
        Me.FlatAlertBox1.Visible = False
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.Red
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton2.Location = New System.Drawing.Point(206, 1)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = False
        Me.FlatButton2.Size = New System.Drawing.Size(100, 28)
        Me.FlatButton2.TabIndex = 8
        Me.FlatButton2.Text = "Close"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.FlatButton2.Visible = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(298, 83)
        Me.Controls.Add(Me.FlatButton2)
        Me.Controls.Add(Me.FlatButton1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FlatAlertBox1)
        Me.Controls.Add(Me.estado)
        Me.Controls.Add(Me.ip)
        Me.Controls.Add(Me.estadointernet)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents estadointernet As System.Windows.Forms.Label
    Friend WithEvents ip As System.Windows.Forms.Label
    Friend WithEvents estado As System.Windows.Forms.Label
    Friend WithEvents FlatAlertBox1 As RadioSFYK.FlatAlertBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FlatButton1 As RadioSFYK.FlatButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents FlatButton2 As RadioSFYK.FlatButton
End Class
