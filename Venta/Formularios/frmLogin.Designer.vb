<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmLogin
#Region "Código generado por el Diseñador de Windows Forms "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'Llamada necesaria para el Diseñador de Windows Forms.
		InitializeComponent()
	End Sub
	'Form invalida a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Requerido por el Diseñador de Windows Forms
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents btnAceptar As System.Windows.Forms.Button
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.CheckBoxLogin = New System.Windows.Forms.CheckBox()
        Me.Image1 = New System.Windows.Forms.PictureBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtusuxlite = New System.Windows.Forms.TextBox()
        Me.cmbUsuarios = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblBienvenida = New System.Windows.Forms.Label()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAceptar.Location = New System.Drawing.Point(144, 364)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAceptar.Size = New System.Drawing.Size(133, 41)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "Ingresar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'CheckBoxLogin
        '
        Me.CheckBoxLogin.AutoSize = True
        Me.CheckBoxLogin.Location = New System.Drawing.Point(34, 387)
        Me.CheckBoxLogin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBoxLogin.Name = "CheckBoxLogin"
        Me.CheckBoxLogin.Size = New System.Drawing.Size(18, 17)
        Me.CheckBoxLogin.TabIndex = 6
        Me.CheckBoxLogin.UseVisualStyleBackColor = True
        '
        'Image1
        '
        Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Image1.Image = Global.APP_778.My.Resources.Resources.Imagen_Cordial_Phone1
        Me.Image1.Location = New System.Drawing.Point(73, 2)
        Me.Image1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Image1.Name = "Image1"
        Me.Image1.Size = New System.Drawing.Size(283, 245)
        Me.Image1.TabIndex = 5
        Me.Image1.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSalir.Location = New System.Drawing.Point(178, 430)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSalir.Size = New System.Drawing.Size(83, 26)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(4, 408)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(104, 28)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Recuperacion"
        '
        'txtusuxlite
        '
        Me.txtusuxlite.AcceptsReturn = True
        Me.txtusuxlite.BackColor = System.Drawing.SystemColors.Window
        Me.txtusuxlite.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtusuxlite.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtusuxlite.Location = New System.Drawing.Point(182, 322)
        Me.txtusuxlite.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtusuxlite.MaxLength = 0
        Me.txtusuxlite.Name = "txtusuxlite"
        Me.txtusuxlite.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtusuxlite.Size = New System.Drawing.Size(107, 22)
        Me.txtusuxlite.TabIndex = 31
        '
        'cmbUsuarios
        '
        Me.cmbUsuarios.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbUsuarios.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbUsuarios.FormattingEnabled = True
        Me.cmbUsuarios.Location = New System.Drawing.Point(157, 276)
        Me.cmbUsuarios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbUsuarios.Name = "cmbUsuarios"
        Me.cmbUsuarios.Size = New System.Drawing.Size(232, 24)
        Me.cmbUsuarios.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(16, 325)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(158, 21)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Ingrese usuario XLite"
        '
        'LblBienvenida
        '
        Me.LblBienvenida.BackColor = System.Drawing.Color.White
        Me.LblBienvenida.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblBienvenida.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblBienvenida.Location = New System.Drawing.Point(19, 276)
        Me.LblBienvenida.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblBienvenida.Name = "LblBienvenida"
        Me.LblBienvenida.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblBienvenida.Size = New System.Drawing.Size(140, 30)
        Me.LblBienvenida.TabIndex = 30
        Me.LblBienvenida.Text = "Usuario Logeado"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ClientSize = New System.Drawing.Size(434, 484)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtusuxlite)
        Me.Controls.Add(Me.cmbUsuarios)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblBienvenida)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.CheckBoxLogin)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Image1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 27)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents Image1 As System.Windows.Forms.PictureBox
    Friend WithEvents CheckBoxLogin As System.Windows.Forms.CheckBox
    Public WithEvents btnSalir As Button
    Public WithEvents Label2 As Label
    Public WithEvents txtusuxlite As TextBox
    Friend WithEvents cmbUsuarios As ComboBox
    Public WithEvents Label1 As Label
    Public WithEvents LblBienvenida As Label
#End Region
End Class