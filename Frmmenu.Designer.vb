<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmmenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnhorario = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnmantenimiento = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(96, 88)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 49)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Empleado"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(228, 89)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 48)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Unidad"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(96, 154)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(128, 53)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Cliente"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(228, 154)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(128, 53)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "Facturación"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnhorario
        '
        Me.btnhorario.Location = New System.Drawing.Point(96, 230)
        Me.btnhorario.Margin = New System.Windows.Forms.Padding(2)
        Me.btnhorario.Name = "btnhorario"
        Me.btnhorario.Size = New System.Drawing.Size(130, 54)
        Me.btnhorario.TabIndex = 15
        Me.btnhorario.Text = "Horarios"
        Me.btnhorario.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(139, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 30)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Menu Principal"
        '
        'btnmantenimiento
        '
        Me.btnmantenimiento.BackColor = System.Drawing.Color.Transparent
        Me.btnmantenimiento.Location = New System.Drawing.Point(238, 230)
        Me.btnmantenimiento.Name = "btnmantenimiento"
        Me.btnmantenimiento.Size = New System.Drawing.Size(118, 54)
        Me.btnmantenimiento.TabIndex = 17
        Me.btnmantenimiento.Text = "Mantenimiento"
        Me.btnmantenimiento.UseVisualStyleBackColor = False
        '
        'frmmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(467, 370)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnmantenimiento)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnhorario)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmmenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnhorario As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnmantenimiento As Button
End Class
