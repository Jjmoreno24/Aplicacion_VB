<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatos
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmDatos))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtNombre = New TextBox()
        txtEdad = New TextBox()
        txtTelefono = New TextBox()
        btnAgregar_Click = New Button()
        btnEliminar_Click = New Button()
        btnLimpiar_Click = New Button()
        btnSalir_Click = New Button()
        CheckBox1 = New CheckBox()
        PictureBox1 = New PictureBox()
        Label4 = New Label()
        lboNombre = New ListBox()
        Label5 = New Label()
        lboEdad = New ListBox()
        Label6 = New Label()
        lboTel = New ListBox()
        Label7 = New Label()
        lboEstado = New ListBox()
        Label8 = New Label()
        txtContador = New TextBox()
        PictureBox2 = New PictureBox()
        lboFilas = New ListBox()
        Label9 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Control
        Label1.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(42, 116)
        Label1.Name = "Label1"
        Label1.Size = New Size(170, 25)
        Label1.TabIndex = 0
        Label1.Text = "Apellido y Nombre"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.Control
        Label2.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(42, 175)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 25)
        Label2.TabIndex = 1
        Label2.Text = "Edad"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.Control
        Label3.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(42, 234)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 25)
        Label3.TabIndex = 2
        Label3.Text = "Telefono"
        ' 
        ' txtNombre
        ' 
        txtNombre.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        txtNombre.Location = New Point(228, 116)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(412, 30)
        txtNombre.TabIndex = 3
        ' 
        ' txtEdad
        ' 
        txtEdad.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        txtEdad.Location = New Point(228, 173)
        txtEdad.Name = "txtEdad"
        txtEdad.Size = New Size(412, 30)
        txtEdad.TabIndex = 4
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        txtTelefono.Location = New Point(228, 235)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(412, 30)
        txtTelefono.TabIndex = 5
        ' 
        ' btnAgregar_Click
        ' 
        btnAgregar_Click.BackColor = SystemColors.ActiveBorder
        btnAgregar_Click.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnAgregar_Click.Location = New Point(841, 96)
        btnAgregar_Click.Name = "btnAgregar_Click"
        btnAgregar_Click.Size = New Size(141, 32)
        btnAgregar_Click.TabIndex = 6
        btnAgregar_Click.Text = "Agregar"
        btnAgregar_Click.UseVisualStyleBackColor = False
        ' 
        ' btnEliminar_Click
        ' 
        btnEliminar_Click.BackColor = SystemColors.ActiveBorder
        btnEliminar_Click.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnEliminar_Click.Location = New Point(841, 153)
        btnEliminar_Click.Name = "btnEliminar_Click"
        btnEliminar_Click.Size = New Size(141, 32)
        btnEliminar_Click.TabIndex = 7
        btnEliminar_Click.Text = "Eliminar"
        btnEliminar_Click.UseVisualStyleBackColor = False
        ' 
        ' btnLimpiar_Click
        ' 
        btnLimpiar_Click.BackColor = SystemColors.ActiveBorder
        btnLimpiar_Click.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnLimpiar_Click.Location = New Point(841, 215)
        btnLimpiar_Click.Name = "btnLimpiar_Click"
        btnLimpiar_Click.Size = New Size(141, 32)
        btnLimpiar_Click.TabIndex = 8
        btnLimpiar_Click.Text = "Limpiar"
        btnLimpiar_Click.UseVisualStyleBackColor = False
        ' 
        ' btnSalir_Click
        ' 
        btnSalir_Click.BackColor = SystemColors.ActiveBorder
        btnSalir_Click.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnSalir_Click.Location = New Point(843, 268)
        btnSalir_Click.Name = "btnSalir_Click"
        btnSalir_Click.Size = New Size(141, 32)
        btnSalir_Click.TabIndex = 9
        btnSalir_Click.Text = "Salir"
        btnSalir_Click.UseVisualStyleBackColor = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = SystemColors.Control
        CheckBox1.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        CheckBox1.Location = New Point(662, 235)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(93, 29)
        CheckBox1.TabIndex = 10
        CheckBox1.Text = "Casado"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ActiveCaption
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(42, 331)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(974, 301)
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ActiveCaption
        Label4.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(71, 351)
        Label4.Name = "Label4"
        Label4.Size = New Size(170, 25)
        Label4.TabIndex = 12
        Label4.Text = "Apellido y Nombre"
        ' 
        ' lboNombre
        ' 
        lboNombre.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lboNombre.FormattingEnabled = True
        lboNombre.HorizontalScrollbar = True
        lboNombre.ItemHeight = 23
        lboNombre.Location = New Point(56, 395)
        lboNombre.Name = "lboNombre"
        lboNombre.Size = New Size(204, 142)
        lboNombre.TabIndex = 13
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ActiveCaption
        Label5.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(297, 351)
        Label5.Name = "Label5"
        Label5.Size = New Size(52, 25)
        Label5.TabIndex = 14
        Label5.Text = "Edad"
        ' 
        ' lboEdad
        ' 
        lboEdad.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lboEdad.FormattingEnabled = True
        lboEdad.HorizontalScrollbar = True
        lboEdad.ItemHeight = 23
        lboEdad.Location = New Point(281, 395)
        lboEdad.Name = "lboEdad"
        lboEdad.Size = New Size(107, 142)
        lboEdad.TabIndex = 15
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.ActiveCaption
        Label6.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(434, 351)
        Label6.Name = "Label6"
        Label6.Size = New Size(92, 25)
        Label6.TabIndex = 16
        Label6.Text = "Telefonos"
        ' 
        ' lboTel
        ' 
        lboTel.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lboTel.FormattingEnabled = True
        lboTel.HorizontalScrollbar = True
        lboTel.ItemHeight = 23
        lboTel.Location = New Point(404, 395)
        lboTel.Name = "lboTel"
        lboTel.Size = New Size(153, 142)
        lboTel.TabIndex = 17
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.ActiveCaption
        Label7.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(627, 351)
        Label7.Name = "Label7"
        Label7.Size = New Size(107, 25)
        Label7.TabIndex = 18
        Label7.Text = "Estado Civil"
        ' 
        ' lboEstado
        ' 
        lboEstado.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lboEstado.FormattingEnabled = True
        lboEstado.HorizontalScrollbar = True
        lboEstado.ItemHeight = 23
        lboEstado.Location = New Point(590, 395)
        lboEstado.Name = "lboEstado"
        lboEstado.Size = New Size(188, 142)
        lboEstado.TabIndex = 19
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = SystemColors.ActiveCaption
        Label8.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(200, 588)
        Label8.Name = "Label8"
        Label8.Size = New Size(174, 25)
        Label8.TabIndex = 20
        Label8.Text = "Total de Ingresados"
        ' 
        ' txtContador
        ' 
        txtContador.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        txtContador.Location = New Point(389, 585)
        txtContador.Name = "txtContador"
        txtContador.Size = New Size(260, 31)
        txtContador.TabIndex = 21
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(-2, -5)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(1077, 667)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 22
        PictureBox2.TabStop = False
        ' 
        ' lboFilas
        ' 
        lboFilas.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lboFilas.FormattingEnabled = True
        lboFilas.HorizontalScrollbar = True
        lboFilas.ItemHeight = 23
        lboFilas.Location = New Point(804, 395)
        lboFilas.Name = "lboFilas"
        lboFilas.Size = New Size(180, 142)
        lboFilas.TabIndex = 23
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = SystemColors.ActiveCaption
        Label9.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(855, 351)
        Label9.Name = "Label9"
        Label9.Size = New Size(90, 25)
        Label9.TabIndex = 24
        Label9.Text = "Registros"
        ' 
        ' frmDatos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1076, 663)
        Controls.Add(Label9)
        Controls.Add(lboFilas)
        Controls.Add(txtContador)
        Controls.Add(Label8)
        Controls.Add(lboEstado)
        Controls.Add(Label7)
        Controls.Add(lboTel)
        Controls.Add(Label6)
        Controls.Add(lboEdad)
        Controls.Add(Label5)
        Controls.Add(lboNombre)
        Controls.Add(Label4)
        Controls.Add(PictureBox1)
        Controls.Add(CheckBox1)
        Controls.Add(btnSalir_Click)
        Controls.Add(btnLimpiar_Click)
        Controls.Add(btnEliminar_Click)
        Controls.Add(btnAgregar_Click)
        Controls.Add(txtTelefono)
        Controls.Add(txtEdad)
        Controls.Add(txtNombre)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "frmDatos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Datos Generales"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents btnAgregar_Click As Button
    Friend WithEvents btnEliminar_Click As Button
    Friend WithEvents btnLimpiar_Click As Button
    Friend WithEvents btnSalir_Click As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lboNombre As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lboEdad As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lboTel As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lboEstado As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtContador As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lboFilas As ListBox
    Friend WithEvents Label9 As Label
End Class
