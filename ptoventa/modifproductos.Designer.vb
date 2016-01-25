<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class modifproductos
    Inherits System.Windows.Forms.Form

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer
    Private mainMenu1 As System.Windows.Forms.MainMenu

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar con el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtbusqueda = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lstcodigo = New System.Windows.Forms.ListBox
        Me.lstdescripcion = New System.Windows.Forms.ListBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtupc = New System.Windows.Forms.TextBox
        Me.txtdescripcion = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtprecio = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lstprecio = New System.Windows.Forms.ListBox
        Me.txtprecio1 = New System.Windows.Forms.TextBox
        Me.txtprecio2 = New System.Windows.Forms.TextBox
        Me.lstprecio2 = New System.Windows.Forms.ListBox
        Me.lstprecio1 = New System.Windows.Forms.ListBox
        Me.lstid = New System.Windows.Forms.ListBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtcodigo = New System.Windows.Forms.TextBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.MenuItem1)
        Me.mainMenu1.MenuItems.Add(Me.MenuItem4)
        '
        'MenuItem1
        '
        Me.MenuItem1.MenuItems.Add(Me.MenuItem5)
        Me.MenuItem1.MenuItems.Add(Me.MenuItem2)
        Me.MenuItem1.Text = "Opciones"
        '
        'MenuItem5
        '
        Me.MenuItem5.Text = "Eliminar Prod."
        '
        'MenuItem2
        '
        Me.MenuItem2.MenuItems.Add(Me.MenuItem6)
        Me.MenuItem2.Text = "Nuevo Prod."
        '
        'MenuItem6
        '
        Me.MenuItem6.Text = "1 - Agregar"
        '
        'MenuItem4
        '
        Me.MenuItem4.Text = "Menú Principal"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(4, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.Text = "Buscar"
        '
        'txtbusqueda
        '
        Me.txtbusqueda.Location = New System.Drawing.Point(51, 1)
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(87, 21)
        Me.txtbusqueda.TabIndex = 1
        Me.txtbusqueda.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(1, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 10)
        Me.Label2.Text = "Codigo"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(78, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 10)
        Me.Label3.Text = "Descripcion"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(0, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(240, 5)
        Me.Label5.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(0, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(240, 5)
        Me.Label6.Text = "Label6"
        '
        'lstcodigo
        '
        Me.lstcodigo.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstcodigo.Location = New System.Drawing.Point(2, 56)
        Me.lstcodigo.Name = "lstcodigo"
        Me.lstcodigo.Size = New System.Drawing.Size(75, 79)
        Me.lstcodigo.TabIndex = 12
        Me.lstcodigo.TabStop = False
        '
        'lstdescripcion
        '
        Me.lstdescripcion.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstdescripcion.Location = New System.Drawing.Point(79, 56)
        Me.lstdescripcion.Name = "lstdescripcion"
        Me.lstdescripcion.Size = New System.Drawing.Size(149, 79)
        Me.lstdescripcion.TabIndex = 13
        Me.lstdescripcion.TabStop = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(0, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.Text = "Desc."
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(1, 175)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.Text = "Cod. Barras"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(41, 158)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 17)
        Me.Label10.Text = "Producto a Modificar"
        '
        'txtupc
        '
        Me.txtupc.Enabled = False
        Me.txtupc.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.txtupc.Location = New System.Drawing.Point(59, 172)
        Me.txtupc.MaxLength = 15
        Me.txtupc.Name = "txtupc"
        Me.txtupc.Size = New System.Drawing.Size(101, 18)
        Me.txtupc.TabIndex = 22
        Me.txtupc.TabStop = False
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.txtdescripcion.Location = New System.Drawing.Point(32, 192)
        Me.txtdescripcion.MaxLength = 50
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(207, 18)
        Me.txtdescripcion.TabIndex = 23
        Me.txtdescripcion.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(13, 233)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 20)
        Me.Button1.TabIndex = 25
        Me.Button1.TabStop = False
        Me.Button1.Text = "&Editar Producto"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(114, 233)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 20)
        Me.Button2.TabIndex = 26
        Me.Button2.TabStop = False
        Me.Button2.Text = "&Guardar Cambios"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(3, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.Text = "Precio"
        '
        'txtprecio
        '
        Me.txtprecio.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.txtprecio.Location = New System.Drawing.Point(37, 212)
        Me.txtprecio.MaxLength = 10
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(44, 18)
        Me.txtprecio.TabIndex = 24
        Me.txtprecio.TabStop = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(234, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 10)
        Me.Label4.Text = "Precio"
        '
        'lstprecio
        '
        Me.lstprecio.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstprecio.Location = New System.Drawing.Point(234, 56)
        Me.lstprecio.Name = "lstprecio"
        Me.lstprecio.Size = New System.Drawing.Size(46, 79)
        Me.lstprecio.TabIndex = 14
        Me.lstprecio.TabStop = False
        '
        'txtprecio1
        '
        Me.txtprecio1.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.txtprecio1.Location = New System.Drawing.Point(83, 212)
        Me.txtprecio1.MaxLength = 10
        Me.txtprecio1.Name = "txtprecio1"
        Me.txtprecio1.Size = New System.Drawing.Size(44, 18)
        Me.txtprecio1.TabIndex = 37
        Me.txtprecio1.TabStop = False
        '
        'txtprecio2
        '
        Me.txtprecio2.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.txtprecio2.Location = New System.Drawing.Point(130, 212)
        Me.txtprecio2.MaxLength = 10
        Me.txtprecio2.Name = "txtprecio2"
        Me.txtprecio2.Size = New System.Drawing.Size(44, 18)
        Me.txtprecio2.TabIndex = 38
        Me.txtprecio2.TabStop = False
        '
        'lstprecio2
        '
        Me.lstprecio2.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstprecio2.Location = New System.Drawing.Point(331, 56)
        Me.lstprecio2.Name = "lstprecio2"
        Me.lstprecio2.Size = New System.Drawing.Size(46, 79)
        Me.lstprecio2.TabIndex = 39
        Me.lstprecio2.TabStop = False
        '
        'lstprecio1
        '
        Me.lstprecio1.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstprecio1.Location = New System.Drawing.Point(282, 56)
        Me.lstprecio1.Name = "lstprecio1"
        Me.lstprecio1.Size = New System.Drawing.Size(46, 79)
        Me.lstprecio1.TabIndex = 40
        Me.lstprecio1.TabStop = False
        '
        'lstid
        '
        Me.lstid.Font = New System.Drawing.Font("Tahoma", 6.0!, System.Drawing.FontStyle.Regular)
        Me.lstid.Location = New System.Drawing.Point(265, 158)
        Me.lstid.Name = "lstid"
        Me.lstid.Size = New System.Drawing.Size(32, 82)
        Me.lstid.TabIndex = 41
        Me.lstid.TabStop = False
        Me.lstid.Visible = False
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(265, 147)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 10)
        Me.Label11.Text = "Id."
        Me.Label11.Visible = False
        '
        'txtcodigo
        '
        Me.txtcodigo.Enabled = False
        Me.txtcodigo.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.txtcodigo.Location = New System.Drawing.Point(165, 172)
        Me.txtcodigo.MaxLength = 12
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(45, 18)
        Me.txtcodigo.TabIndex = 52
        Me.txtcodigo.TabStop = False
        '
        'RadioButton1
        '
        Me.RadioButton1.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.RadioButton1.Location = New System.Drawing.Point(144, -1)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(75, 20)
        Me.RadioButton1.TabIndex = 64
        Me.RadioButton1.Text = "Cod.Barras"
        '
        'RadioButton2
        '
        Me.RadioButton2.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.RadioButton2.Location = New System.Drawing.Point(144, 17)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(75, 20)
        Me.RadioButton2.TabIndex = 65
        Me.RadioButton2.Text = "Descripción"
        '
        'modifproductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lstid)
        Me.Controls.Add(Me.lstprecio1)
        Me.Controls.Add(Me.lstprecio2)
        Me.Controls.Add(Me.txtprecio2)
        Me.Controls.Add(Me.txtprecio1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.txtdescripcion)
        Me.Controls.Add(Me.txtupc)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lstprecio)
        Me.Controls.Add(Me.lstdescripcion)
        Me.Controls.Add(Me.lstcodigo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtbusqueda)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 6.0!, System.Drawing.FontStyle.Regular)
        Me.Menu = Me.mainMenu1
        Me.Name = "modifproductos"
        Me.Text = "Modificar Productos"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtbusqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lstcodigo As System.Windows.Forms.ListBox
    Friend WithEvents lstdescripcion As System.Windows.Forms.ListBox
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtupc As System.Windows.Forms.TextBox
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtprecio As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lstprecio As System.Windows.Forms.ListBox
    Friend WithEvents txtprecio1 As System.Windows.Forms.TextBox
    Friend WithEvents txtprecio2 As System.Windows.Forms.TextBox
    Friend WithEvents lstprecio2 As System.Windows.Forms.ListBox
    Friend WithEvents lstprecio1 As System.Windows.Forms.ListBox
    Friend WithEvents lstid As System.Windows.Forms.ListBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
End Class
