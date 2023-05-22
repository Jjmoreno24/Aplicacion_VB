<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Presentacion
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Presentacion))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(263, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(340, 22)
        Label1.TabIndex = 1
        Label1.Text = "UNIVERSIDAD TECNOLÓGICA DE PANAMÁ"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(147, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(510, 22)
        Label2.TabIndex = 2
        Label2.Text = "FACULTAD DE INGENIERÍA DE SISTEMAS COMPUTACIONALES"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(197, 143)
        Label3.Name = "Label3"
        Label3.Size = New Size(450, 22)
        Label3.TabIndex = 3
        Label3.Text = "LIC. EN INGENIERIA DE SISTEMAS Y COMPUTACION"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(197, 111)
        Label4.Name = "Label4"
        Label4.Size = New Size(450, 22)
        Label4.TabIndex = 4
        Label4.Text = "DEPARTAMENTO DE PROGRAMACIÓN DE COMPUTADORAS"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(263, 205)
        Label5.Name = "Label5"
        Label5.Size = New Size(330, 22)
        Label5.TabIndex = 5
        Label5.Text = "HERRAMIENTAS DE PROGRAMACION III"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Consolas", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(312, 263)
        Label6.Name = "Label6"
        Label6.Size = New Size(153, 20)
        Label6.TabIndex = 6
        Label6.Text = "DESARROLLADORES:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Consolas", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(396, 306)
        Label7.Name = "Label7"
        Label7.Size = New Size(108, 20)
        Label7.TabIndex = 7
        Label7.Text = "JOSE MORENO"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Consolas", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(396, 346)
        Label8.Name = "Label8"
        Label8.Size = New Size(144, 20)
        Label8.TabIndex = 8
        Label8.Text = "ISMAEL VALENCIA"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Consolas", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(396, 385)
        Label9.Name = "Label9"
        Label9.Size = New Size(135, 20)
        Label9.TabIndex = 9
        Label9.Text = "MICHAEL JORDAN"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveBorder
        Button1.Font = New Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(96, 446)
        Button1.Name = "Button1"
        Button1.Size = New Size(147, 53)
        Button1.TabIndex = 10
        Button1.Text = "Ejemplo Radio Button "
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ActiveBorder
        Button2.Font = New Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(340, 446)
        Button2.Name = "Button2"
        Button2.Size = New Size(158, 53)
        Button2.TabIndex = 11
        Button2.Text = "Ejemplo ListBox"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ActiveBorder
        Button3.Font = New Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(580, 447)
        Button3.Name = "Button3"
        Button3.Size = New Size(151, 52)
        Button3.TabIndex = 12
        Button3.Text = "Salir"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(834, 598)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = SystemColors.InactiveCaptionText
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(229, 306)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(146, 102)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 14
        PictureBox2.TabStop = False
        ' 
        ' Presentacion
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(823, 586)
        Controls.Add(PictureBox2)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Presentacion"
        Text = "Presentacion"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
