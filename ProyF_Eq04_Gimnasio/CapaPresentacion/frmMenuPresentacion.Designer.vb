<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuPresentacion
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ListaDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarInvitadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuia = New System.Windows.Forms.Button()
        Me.btnCurso = New System.Windows.Forms.Button()
        Me.btnAplicacion = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaDeClientesToolStripMenuItem, Me.ListaDeEmpleadosToolStripMenuItem, Me.RegistrarInvitadosToolStripMenuItem, Me.SalirToolStripMenuItem, Me.RegistrarClienteToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ListaDeClientesToolStripMenuItem
        '
        Me.ListaDeClientesToolStripMenuItem.Name = "ListaDeClientesToolStripMenuItem"
        Me.ListaDeClientesToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.ListaDeClientesToolStripMenuItem.Text = "Lista de Empleados"
        '
        'ListaDeEmpleadosToolStripMenuItem
        '
        Me.ListaDeEmpleadosToolStripMenuItem.Name = "ListaDeEmpleadosToolStripMenuItem"
        Me.ListaDeEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(130, 24)
        Me.ListaDeEmpleadosToolStripMenuItem.Text = "Lista de Clientes"
        '
        'RegistrarInvitadosToolStripMenuItem
        '
        Me.RegistrarInvitadosToolStripMenuItem.Name = "RegistrarInvitadosToolStripMenuItem"
        Me.RegistrarInvitadosToolStripMenuItem.Size = New System.Drawing.Size(140, 24)
        Me.RegistrarInvitadosToolStripMenuItem.Text = "Registrar Invitado"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'RegistrarClienteToolStripMenuItem
        '
        Me.RegistrarClienteToolStripMenuItem.Name = "RegistrarClienteToolStripMenuItem"
        Me.RegistrarClienteToolStripMenuItem.Size = New System.Drawing.Size(132, 24)
        Me.RegistrarClienteToolStripMenuItem.Text = "Registrar Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Elephant", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(621, 94)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Bienvenido a la administracion" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "POWERFIT"
        '
        'btnGuia
        '
        Me.btnGuia.Font = New System.Drawing.Font("Elephant", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuia.Location = New System.Drawing.Point(20, 195)
        Me.btnGuia.Name = "btnGuia"
        Me.btnGuia.Size = New System.Drawing.Size(364, 54)
        Me.btnGuia.TabIndex = 2
        Me.btnGuia.Text = "Guia de usuario"
        Me.btnGuia.UseVisualStyleBackColor = True
        '
        'btnCurso
        '
        Me.btnCurso.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCurso.Location = New System.Drawing.Point(20, 280)
        Me.btnCurso.Name = "btnCurso"
        Me.btnCurso.Size = New System.Drawing.Size(364, 54)
        Me.btnCurso.TabIndex = 3
        Me.btnCurso.Text = "Generales del curso"
        Me.btnCurso.UseVisualStyleBackColor = True
        '
        'btnAplicacion
        '
        Me.btnAplicacion.Font = New System.Drawing.Font("Elephant", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAplicacion.Location = New System.Drawing.Point(20, 361)
        Me.btnAplicacion.Name = "btnAplicacion"
        Me.btnAplicacion.Size = New System.Drawing.Size(364, 98)
        Me.btnAplicacion.TabIndex = 3
        Me.btnAplicacion.Text = "Generales de la aplicacion"
        Me.btnAplicacion.UseVisualStyleBackColor = True
        '
        'frmMenuPresentacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CapaPresentacion.My.Resources.Resources.portada
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 527)
        Me.Controls.Add(Me.btnAplicacion)
        Me.Controls.Add(Me.btnCurso)
        Me.Controls.Add(Me.btnGuia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMenuPresentacion"
        Me.Text = "Menu de presentacion"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ListaDeClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaDeEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarInvitadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGuia As Button
    Friend WithEvents btnCurso As Button
    Friend WithEvents btnAplicacion As Button
    Friend WithEvents RegistrarClienteToolStripMenuItem As ToolStripMenuItem
End Class
