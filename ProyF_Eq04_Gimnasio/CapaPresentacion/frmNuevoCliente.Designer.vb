<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNuevoCliente
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Apellido = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtbNombre = New System.Windows.Forms.TextBox()
        Me.txtbApellido = New System.Windows.Forms.TextBox()
        Me.txtbCedula = New System.Windows.Forms.TextBox()
        Me.txtbPeso = New System.Windows.Forms.TextBox()
        Me.dtpFechaNaci = New System.Windows.Forms.DateTimePicker()
        Me.cmbSexo = New System.Windows.Forms.ComboBox()
        Me.cmbSucursal = New System.Windows.Forms.ComboBox()
        Me.cmbMembresia = New System.Windows.Forms.ComboBox()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.dtpFechaAdqui = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ListaDeEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarInvitadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuPresentacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Apellido
        '
        Me.Apellido.AutoSize = True
        Me.Apellido.Font = New System.Drawing.Font("Century", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Apellido.Location = New System.Drawing.Point(52, 80)
        Me.Apellido.Name = "Apellido"
        Me.Apellido.Size = New System.Drawing.Size(130, 33)
        Me.Apellido.TabIndex = 1
        Me.Apellido.Text = "Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(69, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 33)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cedula"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 33)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nacimiento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(103, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 33)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Peso"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(102, 308)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 33)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Sexo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(45, 375)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 33)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Sucursal"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 435)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(169, 33)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Membresia"
        '
        'txtbNombre
        '
        Me.txtbNombre.Font = New System.Drawing.Font("Century", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbNombre.Location = New System.Drawing.Point(190, 21)
        Me.txtbNombre.Name = "txtbNombre"
        Me.txtbNombre.Size = New System.Drawing.Size(231, 35)
        Me.txtbNombre.TabIndex = 8
        '
        'txtbApellido
        '
        Me.txtbApellido.Font = New System.Drawing.Font("Century", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbApellido.Location = New System.Drawing.Point(190, 78)
        Me.txtbApellido.Name = "txtbApellido"
        Me.txtbApellido.Size = New System.Drawing.Size(231, 35)
        Me.txtbApellido.TabIndex = 9
        '
        'txtbCedula
        '
        Me.txtbCedula.Font = New System.Drawing.Font("Century", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbCedula.Location = New System.Drawing.Point(190, 130)
        Me.txtbCedula.Name = "txtbCedula"
        Me.txtbCedula.Size = New System.Drawing.Size(231, 35)
        Me.txtbCedula.TabIndex = 10
        '
        'txtbPeso
        '
        Me.txtbPeso.Font = New System.Drawing.Font("Century", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbPeso.Location = New System.Drawing.Point(190, 244)
        Me.txtbPeso.Name = "txtbPeso"
        Me.txtbPeso.Size = New System.Drawing.Size(231, 35)
        Me.txtbPeso.TabIndex = 11
        '
        'dtpFechaNaci
        '
        Me.dtpFechaNaci.CustomFormat = "yyyy-MM-dd"
        Me.dtpFechaNaci.Font = New System.Drawing.Font("Century", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaNaci.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaNaci.Location = New System.Drawing.Point(190, 185)
        Me.dtpFechaNaci.Name = "dtpFechaNaci"
        Me.dtpFechaNaci.Size = New System.Drawing.Size(231, 35)
        Me.dtpFechaNaci.TabIndex = 12
        '
        'cmbSexo
        '
        Me.cmbSexo.Font = New System.Drawing.Font("Century", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSexo.FormattingEnabled = True
        Me.cmbSexo.Location = New System.Drawing.Point(190, 308)
        Me.cmbSexo.Name = "cmbSexo"
        Me.cmbSexo.Size = New System.Drawing.Size(231, 36)
        Me.cmbSexo.TabIndex = 13
        '
        'cmbSucursal
        '
        Me.cmbSucursal.Font = New System.Drawing.Font("Century", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.Location = New System.Drawing.Point(190, 372)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(231, 36)
        Me.cmbSucursal.TabIndex = 14
        '
        'cmbMembresia
        '
        Me.cmbMembresia.Font = New System.Drawing.Font("Century", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMembresia.FormattingEnabled = True
        Me.cmbMembresia.Location = New System.Drawing.Point(190, 435)
        Me.cmbMembresia.Name = "cmbMembresia"
        Me.cmbMembresia.Size = New System.Drawing.Size(231, 36)
        Me.cmbMembresia.TabIndex = 15
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Font = New System.Drawing.Font("Century", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.Location = New System.Drawing.Point(34, 372)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(264, 73)
        Me.btnSiguiente.TabIndex = 16
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'dtpFechaAdqui
        '
        Me.dtpFechaAdqui.CustomFormat = "yyyy-MM-dd"
        Me.dtpFechaAdqui.Font = New System.Drawing.Font("Century", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaAdqui.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaAdqui.Location = New System.Drawing.Point(190, 499)
        Me.dtpFechaAdqui.Name = "dtpFechaAdqui"
        Me.dtpFechaAdqui.Size = New System.Drawing.Size(231, 35)
        Me.dtpFechaAdqui.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(84, 499)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 33)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Fecha"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label9.Location = New System.Drawing.Point(160, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(510, 47)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Registro de nuevo cliente"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox1.Controls.Add(Me.dtpFechaAdqui)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cmbMembresia)
        Me.GroupBox1.Controls.Add(Me.cmbSucursal)
        Me.GroupBox1.Controls.Add(Me.cmbSexo)
        Me.GroupBox1.Controls.Add(Me.dtpFechaNaci)
        Me.GroupBox1.Controls.Add(Me.txtbPeso)
        Me.GroupBox1.Controls.Add(Me.txtbCedula)
        Me.GroupBox1.Controls.Add(Me.txtbApellido)
        Me.GroupBox1.Controls.Add(Me.txtbNombre)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Apellido)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 100)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 556)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.btnSiguiente)
        Me.GroupBox2.Location = New System.Drawing.Point(511, 100)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(332, 555)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Siguiente"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaDeEmpleadosToolStripMenuItem, Me.ListaDeClientesToolStripMenuItem, Me.RegistrarInvitadoToolStripMenuItem, Me.MenuPresentacionToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(855, 28)
        Me.MenuStrip1.TabIndex = 30
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ListaDeEmpleadosToolStripMenuItem
        '
        Me.ListaDeEmpleadosToolStripMenuItem.Name = "ListaDeEmpleadosToolStripMenuItem"
        Me.ListaDeEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.ListaDeEmpleadosToolStripMenuItem.Text = "Lista de Empleados"
        '
        'ListaDeClientesToolStripMenuItem
        '
        Me.ListaDeClientesToolStripMenuItem.Name = "ListaDeClientesToolStripMenuItem"
        Me.ListaDeClientesToolStripMenuItem.Size = New System.Drawing.Size(130, 24)
        Me.ListaDeClientesToolStripMenuItem.Text = "Lista de Clientes"
        '
        'RegistrarInvitadoToolStripMenuItem
        '
        Me.RegistrarInvitadoToolStripMenuItem.Name = "RegistrarInvitadoToolStripMenuItem"
        Me.RegistrarInvitadoToolStripMenuItem.Size = New System.Drawing.Size(140, 24)
        Me.RegistrarInvitadoToolStripMenuItem.Text = "Registrar Invitado"
        '
        'MenuPresentacionToolStripMenuItem
        '
        Me.MenuPresentacionToolStripMenuItem.Name = "MenuPresentacionToolStripMenuItem"
        Me.MenuPresentacionToolStripMenuItem.Size = New System.Drawing.Size(148, 24)
        Me.MenuPresentacionToolStripMenuItem.Text = "Menu Presentacion"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CapaPresentacion.My.Resources.Resources.registrouser1
        Me.PictureBox1.Location = New System.Drawing.Point(34, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(264, 279)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'frmNuevoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(855, 685)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmNuevoCliente"
        Me.Text = "Registro de cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Apellido As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtbNombre As TextBox
    Friend WithEvents txtbApellido As TextBox
    Friend WithEvents txtbCedula As TextBox
    Friend WithEvents txtbPeso As TextBox
    Friend WithEvents dtpFechaNaci As DateTimePicker
    Friend WithEvents cmbSexo As ComboBox
    Friend WithEvents cmbSucursal As ComboBox
    Friend WithEvents cmbMembresia As ComboBox
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents dtpFechaAdqui As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ListaDeEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaDeClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarInvitadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuPresentacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
