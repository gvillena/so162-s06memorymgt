<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ParticionDinamica
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnTerminarProceso = New System.Windows.Forms.Button()
        Me.btnAgregarProceso = New System.Windows.Forms.Button()
        Me.btnEjecutar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.txtSalida = New System.Windows.Forms.RichTextBox()
        Me.dgvParticiones = New System.Windows.Forms.DataGridView()
        Me.Numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tamaño = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProcesoN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProcesoT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvProcesos = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblAlgoritmo = New System.Windows.Forms.Label()
        Me.lblParticiones = New System.Windows.Forms.Label()
        Me.lblMemoria = New System.Windows.Forms.Label()
        CType(Me.dgvParticiones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProcesos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTerminarProceso
        '
        Me.btnTerminarProceso.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnTerminarProceso.FlatAppearance.BorderSize = 0
        Me.btnTerminarProceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTerminarProceso.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTerminarProceso.ForeColor = System.Drawing.Color.Purple
        Me.btnTerminarProceso.Location = New System.Drawing.Point(741, 175)
        Me.btnTerminarProceso.Margin = New System.Windows.Forms.Padding(0)
        Me.btnTerminarProceso.Name = "btnTerminarProceso"
        Me.btnTerminarProceso.Size = New System.Drawing.Size(25, 41)
        Me.btnTerminarProceso.TabIndex = 34
        Me.btnTerminarProceso.Text = "-"
        Me.btnTerminarProceso.UseVisualStyleBackColor = True
        '
        'btnAgregarProceso
        '
        Me.btnAgregarProceso.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAgregarProceso.FlatAppearance.BorderSize = 0
        Me.btnAgregarProceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarProceso.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarProceso.ForeColor = System.Drawing.Color.Purple
        Me.btnAgregarProceso.Location = New System.Drawing.Point(709, 175)
        Me.btnAgregarProceso.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgregarProceso.Name = "btnAgregarProceso"
        Me.btnAgregarProceso.Size = New System.Drawing.Size(25, 41)
        Me.btnAgregarProceso.TabIndex = 35
        Me.btnAgregarProceso.Text = "+"
        Me.btnAgregarProceso.UseVisualStyleBackColor = True
        '
        'btnEjecutar
        '
        Me.btnEjecutar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEjecutar.FlatAppearance.BorderSize = 0
        Me.btnEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEjecutar.Font = New System.Drawing.Font("Segoe UI Light", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEjecutar.Location = New System.Drawing.Point(402, 54)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(233, 97)
        Me.btnEjecutar.TabIndex = 32
        Me.btnEjecutar.Text = "Haga click aqui para iniciar..."
        Me.btnEjecutar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.Purple
        Me.btnCerrar.Location = New System.Drawing.Point(746, 6)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(32, 33)
        Me.btnCerrar.TabIndex = 33
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'txtSalida
        '
        Me.txtSalida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSalida.Font = New System.Drawing.Font("Calibri Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalida.Location = New System.Drawing.Point(30, 411)
        Me.txtSalida.Name = "txtSalida"
        Me.txtSalida.Size = New System.Drawing.Size(484, 107)
        Me.txtSalida.TabIndex = 31
        Me.txtSalida.Text = ""
        '
        'dgvParticiones
        '
        Me.dgvParticiones.AllowUserToAddRows = False
        Me.dgvParticiones.AllowUserToDeleteRows = False
        Me.dgvParticiones.AllowUserToResizeColumns = False
        Me.dgvParticiones.AllowUserToResizeRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvParticiones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvParticiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvParticiones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Numero, Me.Direccion, Me.Tamaño, Me.ProcesoN, Me.ProcesoT, Me.Estado})
        Me.dgvParticiones.Location = New System.Drawing.Point(28, 219)
        Me.dgvParticiones.MultiSelect = False
        Me.dgvParticiones.Name = "dgvParticiones"
        Me.dgvParticiones.ReadOnly = True
        Me.dgvParticiones.RowHeadersVisible = False
        Me.dgvParticiones.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvParticiones.Size = New System.Drawing.Size(482, 146)
        Me.dgvParticiones.TabIndex = 30
        '
        'Numero
        '
        Me.Numero.HeaderText = "N"
        Me.Numero.Name = "Numero"
        Me.Numero.ReadOnly = True
        Me.Numero.Width = 40
        '
        'Direccion
        '
        Me.Direccion.HeaderText = "Direccion"
        Me.Direccion.Name = "Direccion"
        Me.Direccion.ReadOnly = True
        Me.Direccion.Width = 85
        '
        'Tamaño
        '
        Me.Tamaño.HeaderText = "Tamaño"
        Me.Tamaño.Name = "Tamaño"
        Me.Tamaño.ReadOnly = True
        Me.Tamaño.Width = 85
        '
        'ProcesoN
        '
        Me.ProcesoN.HeaderText = "Proceso N"
        Me.ProcesoN.Name = "ProcesoN"
        Me.ProcesoN.ReadOnly = True
        Me.ProcesoN.Width = 85
        '
        'ProcesoT
        '
        Me.ProcesoT.HeaderText = "Proceso T"
        Me.ProcesoT.Name = "ProcesoT"
        Me.ProcesoT.ReadOnly = True
        Me.ProcesoT.Width = 85
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Width = 85
        '
        'dgvProcesos
        '
        Me.dgvProcesos.AllowUserToAddRows = False
        Me.dgvProcesos.AllowUserToDeleteRows = False
        Me.dgvProcesos.AllowUserToOrderColumns = True
        Me.dgvProcesos.AllowUserToResizeColumns = False
        Me.dgvProcesos.AllowUserToResizeRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProcesos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvProcesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProcesos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.EstadoP})
        Me.dgvProcesos.Location = New System.Drawing.Point(529, 219)
        Me.dgvProcesos.MultiSelect = False
        Me.dgvProcesos.Name = "dgvProcesos"
        Me.dgvProcesos.ReadOnly = True
        Me.dgvProcesos.RowHeadersVisible = False
        Me.dgvProcesos.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvProcesos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProcesos.Size = New System.Drawing.Size(237, 299)
        Me.dgvProcesos.TabIndex = 29
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Proceso"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 75
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Tamaño"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 75
        '
        'EstadoP
        '
        Me.EstadoP.HeaderText = "Estado"
        Me.EstadoP.Name = "EstadoP"
        Me.EstadoP.ReadOnly = True
        Me.EstadoP.Width = 75
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Purple
        Me.Label1.Location = New System.Drawing.Point(21, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 37)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Partición Dinamica"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(415, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 25)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Particiones"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Purple
        Me.Label3.Location = New System.Drawing.Point(25, 373)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 30)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Log"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Purple
        Me.Label8.Location = New System.Drawing.Point(23, 179)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 30)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Particiones"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Purple
        Me.Label7.Location = New System.Drawing.Point(524, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 30)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Procesos"
        '
        'lblAlgoritmo
        '
        Me.lblAlgoritmo.AutoSize = True
        Me.lblAlgoritmo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlgoritmo.ForeColor = System.Drawing.Color.DimGray
        Me.lblAlgoritmo.Location = New System.Drawing.Point(26, 68)
        Me.lblAlgoritmo.Name = "lblAlgoritmo"
        Me.lblAlgoritmo.Size = New System.Drawing.Size(229, 15)
        Me.lblAlgoritmo.TabIndex = 26
        Me.lblAlgoritmo.Text = "Algoritmo de Asignación -> Primer Ajuste"
        '
        'lblParticiones
        '
        Me.lblParticiones.AutoSize = True
        Me.lblParticiones.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParticiones.ForeColor = System.Drawing.Color.DimGray
        Me.lblParticiones.Location = New System.Drawing.Point(26, 142)
        Me.lblParticiones.Name = "lblParticiones"
        Me.lblParticiones.Size = New System.Drawing.Size(104, 15)
        Me.lblParticiones.TabIndex = 27
        Me.lblParticiones.Text = "P1: 50kb | P2: 15kb"
        '
        'lblMemoria
        '
        Me.lblMemoria.AutoSize = True
        Me.lblMemoria.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemoria.ForeColor = System.Drawing.Color.Purple
        Me.lblMemoria.Location = New System.Drawing.Point(23, 108)
        Me.lblMemoria.Name = "lblMemoria"
        Me.lblMemoria.Size = New System.Drawing.Size(225, 30)
        Me.lblMemoria.TabIndex = 28
        Me.lblMemoria.Text = "Memoria Ram ~ 600kb"
        '
        'ParticionDinamica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(787, 540)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnTerminarProceso)
        Me.Controls.Add(Me.btnAgregarProceso)
        Me.Controls.Add(Me.btnEjecutar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.txtSalida)
        Me.Controls.Add(Me.dgvParticiones)
        Me.Controls.Add(Me.dgvProcesos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblAlgoritmo)
        Me.Controls.Add(Me.lblParticiones)
        Me.Controls.Add(Me.lblMemoria)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ParticionDinamica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvParticiones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProcesos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTerminarProceso As Button
    Friend WithEvents btnAgregarProceso As Button
    Friend WithEvents btnEjecutar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents txtSalida As RichTextBox
    Friend WithEvents dgvParticiones As DataGridView
    Friend WithEvents Numero As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
    Friend WithEvents Tamaño As DataGridViewTextBoxColumn
    Friend WithEvents ProcesoN As DataGridViewTextBoxColumn
    Friend WithEvents ProcesoT As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents dgvProcesos As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents EstadoP As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblAlgoritmo As Label
    Friend WithEvents lblParticiones As Label
    Friend WithEvents lblMemoria As Label
End Class
