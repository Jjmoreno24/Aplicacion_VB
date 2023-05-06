<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.txtUserIn = New System.Windows.Forms.TextBox()
        Me.txtContraIn = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.cmdVisual = New System.Windows.Forms.Button()
        Me.cmdTerminar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUserIn
        '
        Me.txtUserIn.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserIn.Location = New System.Drawing.Point(289, 262)
        Me.txtUserIn.Multiline = True
        Me.txtUserIn.Name = "txtUserIn"
        Me.txtUserIn.Size = New System.Drawing.Size(272, 39)
        Me.txtUserIn.TabIndex = 0
        '
        'txtContraIn
        '
        Me.txtContraIn.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraIn.Location = New System.Drawing.Point(289, 336)
        Me.txtContraIn.Multiline = True
        Me.txtContraIn.Name = "txtContraIn"
        Me.txtContraIn.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraIn.Size = New System.Drawing.Size(272, 39)
        Me.txtContraIn.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(63, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(190, 169)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(336, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 40)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Sign In"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Book", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label2.Location = New System.Drawing.Point(350, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 29)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Registrate!"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Book", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label3.Location = New System.Drawing.Point(312, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 29)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Crea una cuenta?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(124, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 27)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Usuario:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(98, 336)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 27)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Contraseña:"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Location = New System.Drawing.Point(63, 431)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(124, 88)
        Me.cmdGuardar.TabIndex = 8
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'cmdVisual
        '
        Me.cmdVisual.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVisual.Location = New System.Drawing.Point(252, 431)
        Me.cmdVisual.Name = "cmdVisual"
        Me.cmdVisual.Size = New System.Drawing.Size(124, 88)
        Me.cmdVisual.TabIndex = 9
        Me.cmdVisual.Text = "Visualizar Info"
        Me.cmdVisual.UseVisualStyleBackColor = True
        '
        'cmdTerminar
        '
        Me.cmdTerminar.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTerminar.Location = New System.Drawing.Point(437, 431)
        Me.cmdTerminar.Name = "cmdTerminar"
        Me.cmdTerminar.Size = New System.Drawing.Size(124, 88)
        Me.cmdTerminar.TabIndex = 10
        Me.cmdTerminar.Text = "Terminar"
        Me.cmdTerminar.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(635, 592)
        Me.Controls.Add(Me.txtUserIn)
        Me.Controls.Add(Me.txtContraIn)
        Me.Controls.Add(Me.cmdTerminar)
        Me.Controls.Add(Me.cmdVisual)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUserIn As TextBox
    Friend WithEvents txtContraIn As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmdGuardar As Button
    Friend WithEvents cmdVisual As Button
    Friend WithEvents cmdTerminar As Button
End Class
