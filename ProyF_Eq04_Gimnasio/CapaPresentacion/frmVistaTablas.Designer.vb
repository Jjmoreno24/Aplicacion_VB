<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVistaTablas
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
        Me.dgvCondiciones = New System.Windows.Forms.DataGridView()
        Me.dgvPosicion = New System.Windows.Forms.DataGridView()
        Me.dgvSucursales = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvCondiciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPosicion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSucursales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvCondiciones
        '
        Me.dgvCondiciones.AllowUserToAddRows = False
        Me.dgvCondiciones.AllowUserToDeleteRows = False
        Me.dgvCondiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCondiciones.Location = New System.Drawing.Point(47, 70)
        Me.dgvCondiciones.Name = "dgvCondiciones"
        Me.dgvCondiciones.ReadOnly = True
        Me.dgvCondiciones.RowHeadersVisible = False
        Me.dgvCondiciones.RowHeadersWidth = 51
        Me.dgvCondiciones.RowTemplate.Height = 24
        Me.dgvCondiciones.Size = New System.Drawing.Size(281, 382)
        Me.dgvCondiciones.TabIndex = 7
        '
        'dgvPosicion
        '
        Me.dgvPosicion.AllowUserToAddRows = False
        Me.dgvPosicion.AllowUserToDeleteRows = False
        Me.dgvPosicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPosicion.ColumnHeadersVisible = False
        Me.dgvPosicion.Location = New System.Drawing.Point(351, 70)
        Me.dgvPosicion.Name = "dgvPosicion"
        Me.dgvPosicion.ReadOnly = True
        Me.dgvPosicion.RowHeadersVisible = False
        Me.dgvPosicion.RowHeadersWidth = 51
        Me.dgvPosicion.RowTemplate.Height = 24
        Me.dgvPosicion.Size = New System.Drawing.Size(272, 124)
        Me.dgvPosicion.TabIndex = 10
        '
        'dgvSucursales
        '
        Me.dgvSucursales.AllowUserToAddRows = False
        Me.dgvSucursales.AllowUserToDeleteRows = False
        Me.dgvSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSucursales.ColumnHeadersVisible = False
        Me.dgvSucursales.Location = New System.Drawing.Point(351, 238)
        Me.dgvSucursales.Name = "dgvSucursales"
        Me.dgvSucursales.ReadOnly = True
        Me.dgvSucursales.RowHeadersVisible = False
        Me.dgvSucursales.RowHeadersWidth = 51
        Me.dgvSucursales.RowTemplate.Height = 24
        Me.dgvSucursales.Size = New System.Drawing.Size(272, 214)
        Me.dgvSucursales.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label5.Location = New System.Drawing.Point(228, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(235, 33)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Vista de tablas "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(43, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 22)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Tabla condiciones de clientes"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(Me.btnActualizar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dgvSucursales)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dgvPosicion)
        Me.GroupBox1.Controls.Add(Me.dgvCondiciones)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(658, 530)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tablas"
        '
        'btnActualizar
        '
        Me.btnActualizar.Font = New System.Drawing.Font("Century", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.Location = New System.Drawing.Point(47, 468)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(281, 46)
        Me.btnActualizar.TabIndex = 28
        Me.btnActualizar.Text = "Actualizar condiciones"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(346, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 22)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Tabla de sucursales"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(347, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(262, 22)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Tabla posiciones de trabajo"
        '
        'frmVistaTablas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(726, 637)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Name = "frmVistaTablas"
        Me.Text = "Vista de tablas adicionales"
        CType(Me.dgvCondiciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPosicion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSucursales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvCondiciones As DataGridView
    Friend WithEvents dgvPosicion As DataGridView
    Friend WithEvents dgvSucursales As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnActualizar As Button
End Class
