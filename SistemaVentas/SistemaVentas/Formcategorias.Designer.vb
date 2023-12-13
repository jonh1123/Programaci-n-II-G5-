<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formcategorias
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
        Me.dgvcategoria = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdes = New System.Windows.Forms.TextBox()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.txtcodigocat = New System.Windows.Forms.TextBox()
        Me.btncancelar = New System.Windows.Forms.Button()
        CType(Me.dgvcategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvcategoria
        '
        Me.dgvcategoria.AllowUserToAddRows = False
        Me.dgvcategoria.AllowUserToDeleteRows = False
        Me.dgvcategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcategoria.Location = New System.Drawing.Point(6, 64)
        Me.dgvcategoria.Name = "dgvcategoria"
        Me.dgvcategoria.ReadOnly = True
        Me.dgvcategoria.Size = New System.Drawing.Size(368, 179)
        Me.dgvcategoria.TabIndex = 9
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtbuscar)
        Me.GroupBox2.Controls.Add(Me.dgvcategoria)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(320, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(380, 280)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lista de Categorias Registradas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Buscar :"
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(111, 26)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(214, 22)
        Me.txtbuscar.TabIndex = 10
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnnuevo.ForeColor = System.Drawing.Color.White
        Me.btnnuevo.Location = New System.Drawing.Point(24, 12)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(75, 33)
        Me.btnnuevo.TabIndex = 14
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'btnmodificar
        '
        Me.btnmodificar.BackColor = System.Drawing.Color.Green
        Me.btnmodificar.ForeColor = System.Drawing.Color.White
        Me.btnmodificar.Location = New System.Drawing.Point(116, 12)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(75, 33)
        Me.btnmodificar.TabIndex = 15
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Descripcion"
        '
        'btneliminar
        '
        Me.btneliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btneliminar.Location = New System.Drawing.Point(207, 12)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 33)
        Me.btneliminar.TabIndex = 16
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 16)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Codigo Categoria"
        '
        'txtdes
        '
        Me.txtdes.Location = New System.Drawing.Point(140, 166)
        Me.txtdes.Name = "txtdes"
        Me.txtdes.Size = New System.Drawing.Size(136, 20)
        Me.txtdes.TabIndex = 13
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnguardar.ForeColor = System.Drawing.Color.White
        Me.btnguardar.Location = New System.Drawing.Point(23, 208)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(110, 33)
        Me.btnguardar.TabIndex = 17
        Me.btnguardar.Text = "Guardar categoria"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'txtcodigocat
        '
        Me.txtcodigocat.Enabled = False
        Me.txtcodigocat.Location = New System.Drawing.Point(140, 112)
        Me.txtcodigocat.Name = "txtcodigocat"
        Me.txtcodigocat.Size = New System.Drawing.Size(142, 20)
        Me.txtcodigocat.TabIndex = 12
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btncancelar.ForeColor = System.Drawing.Color.Black
        Me.btncancelar.Location = New System.Drawing.Point(154, 208)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(122, 33)
        Me.btncancelar.TabIndex = 18
        Me.btncancelar.Text = "Cancelar operación"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'Formcategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(712, 278)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtdes)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.txtcodigocat)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Location = New System.Drawing.Point(30, 55)
        Me.Name = "Formcategorias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.dgvcategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvcategoria As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnmodificar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btneliminar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtdes As TextBox
    Friend WithEvents btnguardar As Button
    Friend WithEvents txtcodigocat As TextBox
    Friend WithEvents btncancelar As Button
End Class
