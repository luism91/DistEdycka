<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ventas
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
        Me.components = New System.ComponentModel.Container
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.modifcant = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.txtbusqueda = New System.Windows.Forms.TextBox
        Me.txtcantidad = New System.Windows.Forms.TextBox
        Me.btnagregar = New System.Windows.Forms.Button
        Me.lstcantidad = New System.Windows.Forms.ListBox
        Me.lstdescripcion = New System.Windows.Forms.ListBox
        Me.lstprecio = New System.Windows.Forms.ListBox
        Me.lstimporte = New System.Windows.Forms.ListBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lbimporte = New System.Windows.Forms.Label
        Me.lstcodigo = New System.Windows.Forms.ListBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.n = New System.IO.Ports.SerialPort(Me.components)
        Me.lstdescripcion2 = New System.Windows.Forms.ListBox
        Me.cmbtipoprecio = New System.Windows.Forms.ComboBox
        Me.lstprecio1 = New System.Windows.Forms.ListBox
        Me.lstcantidad2 = New System.Windows.Forms.ListBox
        Me.lstprecio2 = New System.Windows.Forms.ListBox
        Me.lstprecio3 = New System.Windows.Forms.ListBox
        Me.lstupc = New System.Windows.Forms.ListBox
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.MenuItem1)
        Me.mainMenu1.MenuItems.Add(Me.MenuItem2)
        '
        'MenuItem1
        '
        Me.MenuItem1.MenuItems.Add(Me.modifcant)
        Me.MenuItem1.MenuItems.Add(Me.MenuItem3)
        Me.MenuItem1.Text = "Modif. Prod."
        '
        'modifcant
        '
        Me.modifcant.Text = "Modif. Cant."
        '
        'MenuItem3
        '
        Me.MenuItem3.Text = "Quitar Prod."
        '
        'MenuItem2
        '
        Me.MenuItem2.MenuItems.Add(Me.MenuItem6)
        Me.MenuItem2.MenuItems.Add(Me.MenuItem7)
        Me.MenuItem2.MenuItems.Add(Me.MenuItem4)
        Me.MenuItem2.Text = "Opciones"
        '
        'MenuItem6
        '
        Me.MenuItem6.Text = "Cargar Nota"
        '
        'MenuItem7
        '
        Me.MenuItem7.Text = "Cerrar venta"
        '
        'MenuItem4
        '
        Me.MenuItem4.Text = "Ir a Menu Prin."
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(4, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 20)
        Me.Label2.Text = "Buscar"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(6, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 20)
        Me.Label3.Text = "Cant."
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.ComboBox1.Location = New System.Drawing.Point(4, 3)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(216, 19)
        Me.ComboBox1.TabIndex = 5
        Me.ComboBox1.TabStop = False
        '
        'txtbusqueda
        '
        Me.txtbusqueda.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtbusqueda.Location = New System.Drawing.Point(53, 33)
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(83, 19)
        Me.txtbusqueda.TabIndex = 6
        Me.txtbusqueda.TabStop = False
        '
        'txtcantidad
        '
        Me.txtcantidad.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtcantidad.Location = New System.Drawing.Point(49, 119)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(35, 19)
        Me.txtcantidad.TabIndex = 7
        Me.txtcantidad.TabStop = False
        '
        'btnagregar
        '
        Me.btnagregar.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnagregar.Location = New System.Drawing.Point(91, 118)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(59, 20)
        Me.btnagregar.TabIndex = 8
        Me.btnagregar.TabStop = False
        Me.btnagregar.Text = " Agregar"
        '
        'lstcantidad
        '
        Me.lstcantidad.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstcantidad.Location = New System.Drawing.Point(0, 174)
        Me.lstcantidad.Name = "lstcantidad"
        Me.lstcantidad.Size = New System.Drawing.Size(24, 387)
        Me.lstcantidad.TabIndex = 11
        Me.lstcantidad.TabStop = False
        '
        'lstdescripcion
        '
        Me.lstdescripcion.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstdescripcion.Location = New System.Drawing.Point(25, 174)
        Me.lstdescripcion.Name = "lstdescripcion"
        Me.lstdescripcion.Size = New System.Drawing.Size(127, 387)
        Me.lstdescripcion.TabIndex = 12
        Me.lstdescripcion.TabStop = False
        '
        'lstprecio
        '
        Me.lstprecio.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstprecio.Location = New System.Drawing.Point(153, 174)
        Me.lstprecio.Name = "lstprecio"
        Me.lstprecio.Size = New System.Drawing.Size(40, 387)
        Me.lstprecio.TabIndex = 13
        Me.lstprecio.TabStop = False
        '
        'lstimporte
        '
        Me.lstimporte.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstimporte.Location = New System.Drawing.Point(194, 174)
        Me.lstimporte.Name = "lstimporte"
        Me.lstimporte.Size = New System.Drawing.Size(40, 387)
        Me.lstimporte.TabIndex = 14
        Me.lstimporte.TabStop = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(69, 578)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 20)
        Me.Label4.Text = "Importe Total"
        '
        'lbimporte
        '
        Me.lbimporte.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lbimporte.Location = New System.Drawing.Point(159, 578)
        Me.lbimporte.Name = "lbimporte"
        Me.lbimporte.Size = New System.Drawing.Size(58, 20)
        '
        'lstcodigo
        '
        Me.lstcodigo.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.lstcodigo.Location = New System.Drawing.Point(7, 604)
        Me.lstcodigo.Name = "lstcodigo"
        Me.lstcodigo.Size = New System.Drawing.Size(88, 41)
        Me.lstcodigo.TabIndex = 27
        Me.lstcodigo.TabStop = False
        Me.lstcodigo.Visible = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(0, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 10)
        Me.Label6.Text = "Cant."
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(26, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 10)
        Me.Label7.Text = "Descripcion"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(154, 161)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 10)
        Me.Label8.Text = "Prec."
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(195, 161)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 10)
        Me.Label9.Text = "Imp."
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(-4, 152)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(240, 5)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.txtbusqueda)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(231, 62)
        '
        'RadioButton2
        '
        Me.RadioButton2.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.RadioButton2.Location = New System.Drawing.Point(145, 41)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(75, 20)
        Me.RadioButton2.TabIndex = 67
        Me.RadioButton2.Text = "Descripción"
        '
        'RadioButton1
        '
        Me.RadioButton1.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.RadioButton1.Location = New System.Drawing.Point(145, 23)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(75, 20)
        Me.RadioButton1.TabIndex = 66
        Me.RadioButton1.Text = "Cod.Barras"
        '
        'n
        '
        Me.n.BaudRate = 57600
        Me.n.PortName = "COM4"
        '
        'lstdescripcion2
        '
        Me.lstdescripcion2.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstdescripcion2.Location = New System.Drawing.Point(20, 67)
        Me.lstdescripcion2.Name = "lstdescripcion2"
        Me.lstdescripcion2.Size = New System.Drawing.Size(203, 24)
        Me.lstdescripcion2.TabIndex = 61
        '
        'cmbtipoprecio
        '
        Me.cmbtipoprecio.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.cmbtipoprecio.Items.Add("REGULAR")
        Me.cmbtipoprecio.Items.Add("MEDIO MAYOREO")
        Me.cmbtipoprecio.Items.Add("MAYOREO")
        Me.cmbtipoprecio.Location = New System.Drawing.Point(131, 95)
        Me.cmbtipoprecio.Name = "cmbtipoprecio"
        Me.cmbtipoprecio.Size = New System.Drawing.Size(92, 19)
        Me.cmbtipoprecio.TabIndex = 62
        '
        'lstprecio1
        '
        Me.lstprecio1.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstprecio1.Location = New System.Drawing.Point(1, 95)
        Me.lstprecio1.Name = "lstprecio1"
        Me.lstprecio1.Size = New System.Drawing.Size(30, 13)
        Me.lstprecio1.TabIndex = 63
        '
        'lstcantidad2
        '
        Me.lstcantidad2.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstcantidad2.Location = New System.Drawing.Point(1, 67)
        Me.lstcantidad2.Name = "lstcantidad2"
        Me.lstcantidad2.Size = New System.Drawing.Size(18, 24)
        Me.lstcantidad2.TabIndex = 73
        '
        'lstprecio2
        '
        Me.lstprecio2.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstprecio2.Location = New System.Drawing.Point(37, 95)
        Me.lstprecio2.Name = "lstprecio2"
        Me.lstprecio2.Size = New System.Drawing.Size(30, 13)
        Me.lstprecio2.TabIndex = 83
        '
        'lstprecio3
        '
        Me.lstprecio3.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstprecio3.Location = New System.Drawing.Point(73, 95)
        Me.lstprecio3.Name = "lstprecio3"
        Me.lstprecio3.Size = New System.Drawing.Size(30, 13)
        Me.lstprecio3.TabIndex = 84
        '
        'lstupc
        '
        Me.lstupc.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.lstupc.Location = New System.Drawing.Point(159, 601)
        Me.lstupc.Name = "lstupc"
        Me.lstupc.Size = New System.Drawing.Size(45, 41)
        Me.lstupc.TabIndex = 94
        Me.lstupc.TabStop = False
        Me.lstupc.Visible = False
        '
        'ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.lstupc)
        Me.Controls.Add(Me.lstprecio3)
        Me.Controls.Add(Me.lstprecio2)
        Me.Controls.Add(Me.lstcantidad2)
        Me.Controls.Add(Me.lstprecio1)
        Me.Controls.Add(Me.cmbtipoprecio)
        Me.Controls.Add(Me.lstdescripcion2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lstcodigo)
        Me.Controls.Add(Me.lbimporte)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lstimporte)
        Me.Controls.Add(Me.lstprecio)
        Me.Controls.Add(Me.lstdescripcion)
        Me.Controls.Add(Me.lstcantidad)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.Label3)
        Me.KeyPreview = True
        Me.Menu = Me.mainMenu1
        Me.Name = "ventas"
        Me.Text = "Ventas"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtbusqueda As System.Windows.Forms.TextBox
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents btnagregar As System.Windows.Forms.Button
    Friend WithEvents lstcantidad As System.Windows.Forms.ListBox
    Friend WithEvents lstdescripcion As System.Windows.Forms.ListBox
    Friend WithEvents lstprecio As System.Windows.Forms.ListBox
    Friend WithEvents lstimporte As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbimporte As System.Windows.Forms.Label
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents modifcant As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents lstcodigo As System.Windows.Forms.ListBox
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents n As System.IO.Ports.SerialPort


    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents lstdescripcion2 As System.Windows.Forms.ListBox
    Friend WithEvents cmbtipoprecio As System.Windows.Forms.ComboBox
    Friend WithEvents lstprecio1 As System.Windows.Forms.ListBox
    Friend WithEvents lstcantidad2 As System.Windows.Forms.ListBox
    Friend WithEvents lstprecio2 As System.Windows.Forms.ListBox
    Friend WithEvents lstprecio3 As System.Windows.Forms.ListBox
    Friend WithEvents lstupc As System.Windows.Forms.ListBox
End Class
