<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVenta))
        Me.dgvdetalles = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Producto = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcabtidad = New System.Windows.Forms.NumericUpDown()
        Me.btnegregar = New System.Windows.Forms.Button()
        Me.cbproducto = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtnumdocu = New System.Windows.Forms.TextBox()
        Me.txtfecha = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtdnicli = New System.Windows.Forms.TextBox()
        Me.cbcliente = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvdetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Producto.SuspendLayout()
        CType(Me.txtcabtidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvdetalles
        '
        Me.dgvdetalles.AllowUserToAddRows = False
        Me.dgvdetalles.AllowUserToDeleteRows = False
        Me.dgvdetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdetalles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvdetalles.EnableHeadersVisualStyles = False
        Me.dgvdetalles.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgvdetalles.Location = New System.Drawing.Point(16, 342)
        Me.dgvdetalles.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvdetalles.Name = "dgvdetalles"
        Me.dgvdetalles.ReadOnly = True
        Me.dgvdetalles.RowHeadersWidth = 51
        Me.dgvdetalles.Size = New System.Drawing.Size(741, 185)
        Me.dgvdetalles.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "codproducto"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "cantidad"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "descripcion"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 200
        '
        'Column4
        '
        Me.Column4.HeaderText = "P. Unitario"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Importe"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 125
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(493, 549)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total"
        '
        'Producto
        '
        Me.Producto.Controls.Add(Me.Label3)
        Me.Producto.Controls.Add(Me.Label2)
        Me.Producto.Controls.Add(Me.txtcabtidad)
        Me.Producto.Controls.Add(Me.btnegregar)
        Me.Producto.Controls.Add(Me.cbproducto)
        Me.Producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Producto.Location = New System.Drawing.Point(243, 213)
        Me.Producto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Producto.Name = "Producto"
        Me.Producto.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Producto.Size = New System.Drawing.Size(515, 119)
        Me.Producto.TabIndex = 2
        Me.Producto.TabStop = False
        Me.Producto.Text = "Items"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 82)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cantidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 30)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Producto"
        '
        'txtcabtidad
        '
        Me.txtcabtidad.Enabled = False
        Me.txtcabtidad.Location = New System.Drawing.Point(175, 80)
        Me.txtcabtidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtcabtidad.Name = "txtcabtidad"
        Me.txtcabtidad.Size = New System.Drawing.Size(191, 26)
        Me.txtcabtidad.TabIndex = 2
        '
        'btnegregar
        '
        Me.btnegregar.BackgroundImage = CType(resources.GetObject("btnegregar.BackgroundImage"), System.Drawing.Image)
        Me.btnegregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnegregar.Enabled = False
        Me.btnegregar.Location = New System.Drawing.Point(396, 34)
        Me.btnegregar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnegregar.Name = "btnegregar"
        Me.btnegregar.Size = New System.Drawing.Size(88, 68)
        Me.btnegregar.TabIndex = 1
        Me.btnegregar.UseVisualStyleBackColor = True
        '
        'cbproducto
        '
        Me.cbproducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbproducto.Enabled = False
        Me.cbproducto.FormattingEnabled = True
        Me.cbproducto.Location = New System.Drawing.Point(175, 26)
        Me.cbproducto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbproducto.Name = "cbproducto"
        Me.cbproducto.Size = New System.Drawing.Size(189, 28)
        Me.cbproducto.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtnumdocu)
        Me.GroupBox1.Controls.Add(Me.txtfecha)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtdnicli)
        Me.GroupBox1.Controls.Add(Me.cbcliente)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(311, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(447, 191)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Cliente"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(99, 26)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 20)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Numeroo"
        '
        'txtnumdocu
        '
        Me.txtnumdocu.Enabled = False
        Me.txtnumdocu.Location = New System.Drawing.Point(188, 22)
        Me.txtnumdocu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtnumdocu.Name = "txtnumdocu"
        Me.txtnumdocu.Size = New System.Drawing.Size(132, 26)
        Me.txtnumdocu.TabIndex = 6
        '
        'txtfecha
        '
        Me.txtfecha.Enabled = False
        Me.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfecha.Location = New System.Drawing.Point(188, 148)
        Me.txtfecha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(227, 26)
        Me.txtfecha.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 155)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Fecha"
        '
        'txtdnicli
        '
        Me.txtdnicli.Enabled = False
        Me.txtdnicli.Location = New System.Drawing.Point(188, 101)
        Me.txtdnicli.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtdnicli.Name = "txtdnicli"
        Me.txtdnicli.Size = New System.Drawing.Size(227, 26)
        Me.txtdnicli.TabIndex = 3
        '
        'cbcliente
        '
        Me.cbcliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbcliente.Enabled = False
        Me.cbcliente.FormattingEnabled = True
        Me.cbcliente.Location = New System.Drawing.Point(188, 57)
        Me.cbcliente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbcliente.Name = "cbcliente"
        Me.cbcliente.Size = New System.Drawing.Size(227, 28)
        Me.cbcliente.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 107)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "DNI Cliente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 66)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nombre Cliente"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(36, 37)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(244, 41)
        Me.Panel1.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(27, 11)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 20)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "CrazyStore"
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(0, 64)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(244, 57)
        Me.Panel2.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Location = New System.Drawing.Point(36, 80)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(244, 57)
        Me.Panel3.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(29, 16)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(166, 25)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Boleta de Venta"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Location = New System.Drawing.Point(36, 139)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(244, 41)
        Me.Panel4.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(61, 11)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 20)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Serie 001"
        '
        'Panel5
        '
        Me.Panel5.Location = New System.Drawing.Point(0, 64)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(244, 57)
        Me.Panel5.TabIndex = 5
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.Lime
        Me.btnguardar.Enabled = False
        Me.btnguardar.Location = New System.Drawing.Point(116, 239)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(100, 64)
        Me.btnguardar.TabIndex = 8
        Me.btnguardar.Text = "Guardar Venta"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'txttotal
        '
        Me.txttotal.Enabled = False
        Me.txttotal.Location = New System.Drawing.Point(576, 551)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(149, 22)
        Me.txttotal.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(16, 239)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 66)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Nuevo"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FormVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 591)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Producto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvdetalles)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Venta"
        CType(Me.dgvdetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Producto.ResumeLayout(False)
        Me.Producto.PerformLayout()
        CType(Me.txtcabtidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvdetalles As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Producto As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcabtidad As NumericUpDown
    Friend WithEvents btnegregar As Button
    Friend WithEvents cbproducto As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtfecha As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents txtdnicli As TextBox
    Friend WithEvents cbcliente As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnguardar As Button
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Label9 As Label
    Friend WithEvents txtnumdocu As TextBox
    Friend WithEvents Button1 As Button
End Class
