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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        btnLimpiar = New Button()
        btnTerminar = New Button()
        PictureBox1 = New PictureBox()
        GroupBox1 = New GroupBox()
        optFondoAzul = New RadioButton()
        optFondoRojo = New RadioButton()
        optFondoVerde = New RadioButton()
        GroupBox2 = New GroupBox()
        optFuenteBlanco = New Button()
        optFuenteMagenta = New Button()
        optFuenteCyan = New Button()
        GroupBox3 = New GroupBox()
        chkNegrita = New CheckBox()
        chkMayuscula = New CheckBox()
        txtTexto = New TextBox()
        nextFrmDatos = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.BackColor = Color.Silver
        btnLimpiar.Location = New Point(246, 515)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(195, 46)
        btnLimpiar.TabIndex = 0
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = False
        ' 
        ' btnTerminar
        ' 
        btnTerminar.BackColor = Color.Silver
        btnTerminar.Location = New Point(45, 515)
        btnTerminar.Name = "btnTerminar"
        btnTerminar.Size = New Size(195, 46)
        btnTerminar.TabIndex = 1
        btnTerminar.Text = "Terminar"
        btnTerminar.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.RoyalBlue
        PictureBox1.Location = New Point(45, 184)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(713, 302)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.PapayaWhip
        GroupBox1.Controls.Add(optFondoAzul)
        GroupBox1.Controls.Add(optFondoRojo)
        GroupBox1.Controls.Add(optFondoVerde)
        GroupBox1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox1.Location = New Point(68, 223)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(203, 223)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Color de Fondo"
        ' 
        ' optFondoAzul
        ' 
        optFondoAzul.AutoSize = True
        optFondoAzul.ForeColor = Color.Blue
        optFondoAzul.Location = New Point(17, 160)
        optFondoAzul.Name = "optFondoAzul"
        optFondoAzul.Size = New Size(71, 29)
        optFondoAzul.TabIndex = 2
        optFondoAzul.TabStop = True
        optFondoAzul.Text = "Azul"
        optFondoAzul.UseVisualStyleBackColor = True
        ' 
        ' optFondoRojo
        ' 
        optFondoRojo.AutoSize = True
        optFondoRojo.ForeColor = Color.Red
        optFondoRojo.Location = New Point(17, 99)
        optFondoRojo.Name = "optFondoRojo"
        optFondoRojo.Size = New Size(72, 29)
        optFondoRojo.TabIndex = 1
        optFondoRojo.TabStop = True
        optFondoRojo.Text = "Rojo"
        optFondoRojo.UseVisualStyleBackColor = True
        ' 
        ' optFondoVerde
        ' 
        optFondoVerde.AutoSize = True
        optFondoVerde.ForeColor = Color.Green
        optFondoVerde.Location = New Point(17, 42)
        optFondoVerde.Name = "optFondoVerde"
        optFondoVerde.Size = New Size(82, 29)
        optFondoVerde.TabIndex = 0
        optFondoVerde.TabStop = True
        optFondoVerde.Text = "Verde"
        optFondoVerde.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Pink
        GroupBox2.Controls.Add(optFuenteBlanco)
        GroupBox2.Controls.Add(optFuenteMagenta)
        GroupBox2.Controls.Add(optFuenteCyan)
        GroupBox2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox2.Location = New Point(302, 223)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(204, 223)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        GroupBox2.Text = "Color de Fuente"
        ' 
        ' optFuenteBlanco
        ' 
        optFuenteBlanco.BackColor = Color.LightGray
        optFuenteBlanco.Location = New Point(19, 155)
        optFuenteBlanco.Name = "optFuenteBlanco"
        optFuenteBlanco.Size = New Size(119, 38)
        optFuenteBlanco.TabIndex = 2
        optFuenteBlanco.Text = "Blanco"
        optFuenteBlanco.UseVisualStyleBackColor = False
        ' 
        ' optFuenteMagenta
        ' 
        optFuenteMagenta.BackColor = Color.Magenta
        optFuenteMagenta.Location = New Point(17, 91)
        optFuenteMagenta.Name = "optFuenteMagenta"
        optFuenteMagenta.Size = New Size(121, 44)
        optFuenteMagenta.TabIndex = 1
        optFuenteMagenta.Text = "Magenta"
        optFuenteMagenta.TextAlign = ContentAlignment.MiddleLeft
        optFuenteMagenta.UseVisualStyleBackColor = False
        ' 
        ' optFuenteCyan
        ' 
        optFuenteCyan.BackColor = Color.Cyan
        optFuenteCyan.Location = New Point(17, 36)
        optFuenteCyan.Name = "optFuenteCyan"
        optFuenteCyan.Size = New Size(121, 41)
        optFuenteCyan.TabIndex = 0
        optFuenteCyan.Text = "Cyan"
        optFuenteCyan.TextAlign = ContentAlignment.MiddleLeft
        optFuenteCyan.UseVisualStyleBackColor = False
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.OliveDrab
        GroupBox3.Controls.Add(chkNegrita)
        GroupBox3.Controls.Add(chkMayuscula)
        GroupBox3.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox3.Location = New Point(536, 223)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(207, 223)
        GroupBox3.TabIndex = 5
        GroupBox3.TabStop = False
        GroupBox3.Text = "Opciones de Fuente"
        ' 
        ' chkNegrita
        ' 
        chkNegrita.AutoSize = True
        chkNegrita.Location = New Point(25, 106)
        chkNegrita.Name = "chkNegrita"
        chkNegrita.Size = New Size(98, 29)
        chkNegrita.TabIndex = 1
        chkNegrita.Text = "Negrita"
        chkNegrita.UseVisualStyleBackColor = True
        ' 
        ' chkMayuscula
        ' 
        chkMayuscula.AutoSize = True
        chkMayuscula.Location = New Point(25, 48)
        chkMayuscula.Name = "chkMayuscula"
        chkMayuscula.Size = New Size(125, 29)
        chkMayuscula.TabIndex = 0
        chkMayuscula.Text = "Mayuscula"
        chkMayuscula.UseVisualStyleBackColor = True
        ' 
        ' txtTexto
        ' 
        txtTexto.BorderStyle = BorderStyle.FixedSingle
        txtTexto.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtTexto.Location = New Point(45, 139)
        txtTexto.Multiline = True
        txtTexto.Name = "txtTexto"
        txtTexto.Size = New Size(447, 39)
        txtTexto.TabIndex = 6
        txtTexto.Text = "Texto a cambiar"
        ' 
        ' nextFrmDatos
        ' 
        nextFrmDatos.BackColor = Color.Transparent
        nextFrmDatos.BackgroundImage = CType(resources.GetObject("nextFrmDatos.BackgroundImage"), Image)
        nextFrmDatos.Location = New Point(670, 503)
        nextFrmDatos.Name = "nextFrmDatos"
        nextFrmDatos.Size = New Size(73, 70)
        nextFrmDatos.TabIndex = 7
        nextFrmDatos.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(784, 586)
        Controls.Add(nextFrmDatos)
        Controls.Add(txtTexto)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(btnTerminar)
        Controls.Add(btnLimpiar)
        Controls.Add(PictureBox1)
        ForeColor = Color.Black
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Ejemplo Radio Button y Checkbox"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnTerminar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optFondoAzul As RadioButton
    Friend WithEvents optFondoRojo As RadioButton
    Friend WithEvents optFondoVerde As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents optFuenteCyan As Button
    Friend WithEvents optFuenteBlanco As Button
    Friend WithEvents optFuenteMagenta As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents chkNegrita As CheckBox
    Friend WithEvents chkMayuscula As CheckBox
    Friend WithEvents txtTexto As TextBox
    Friend WithEvents nextFrmDatos As Button
End Class
