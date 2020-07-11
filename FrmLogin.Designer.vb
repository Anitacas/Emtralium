<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Me.btningresar = New System.Windows.Forms.Button()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btningresar
        '
        Me.btningresar.Font = New System.Drawing.Font("Arial", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btningresar.Location = New System.Drawing.Point(192, 230)
        Me.btningresar.Margin = New System.Windows.Forms.Padding(2)
        Me.btningresar.Name = "btningresar"
        Me.btningresar.Size = New System.Drawing.Size(109, 41)
        Me.btningresar.TabIndex = 1
        Me.btningresar.Text = "LOGIN"
        Me.btningresar.UseVisualStyleBackColor = True
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Font = New System.Drawing.Font("Perpetua Titling MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.Location = New System.Drawing.Point(202, 97)
        Me.LblUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(99, 22)
        Me.LblUsuario.TabIndex = 2
        Me.LblUsuario.Text = "Usuario:"
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Font = New System.Drawing.Font("Perpetua Titling MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPassword.Location = New System.Drawing.Point(200, 148)
        Me.LblPassword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(116, 22)
        Me.LblPassword.TabIndex = 3
        Me.LblPassword.Text = "Password:"
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(320, 101)
        Me.txtusuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(131, 20)
        Me.txtusuario.TabIndex = 4
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(320, 148)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(38)
        Me.txtPassword.Size = New System.Drawing.Size(131, 20)
        Me.txtPassword.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(89, 19)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(245, 43)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "EMTRALIUM"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Emtralium.My.Resources.Resources.login
        Me.PictureBox1.Location = New System.Drawing.Point(35, 79)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 123)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(484, 324)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtusuario)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.LblUsuario)
        Me.Controls.Add(Me.btningresar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btningresar As Button
    Friend WithEvents LblUsuario As Label
    Friend WithEvents LblPassword As Label
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
