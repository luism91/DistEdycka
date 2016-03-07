<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Carga
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
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.lstdescripcion = New System.Windows.Forms.ListBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtbusqueda = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtcantidad = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnagregar = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblcarga = New System.Windows.Forms.Label
        Me.lblcantidadcarga = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lstdescripcion2 = New System.Windows.Forms.ListBox
        Me.lstcantidad2 = New System.Windows.Forms.ListBox
        Me.SP2 = New System.IO.Ports.SerialPort(Me.components)
        Me.lstupc = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.MenuItem1)
        Me.mainMenu1.MenuItems.Add(Me.MenuItem3)
        '
        'MenuItem1
        '
        Me.MenuItem1.MenuItems.Add(Me.MenuItem2)
        Me.MenuItem1.MenuItems.Add(Me.MenuItem4)
        Me.MenuItem1.MenuItems.Add(Me.MenuItem5)
        Me.MenuItem1.Text = "Opciones"
        '
        'MenuItem2
        '
        Me.MenuItem2.Text = "Nueva carga"
        '
        'MenuItem4
        '
        Me.MenuItem4.Text = "Ver Carga"
        '
        'MenuItem5
        '
        Me.MenuItem5.Text = "Imprimir devolucion"
        '
        'MenuItem3
        '
        Me.MenuItem3.Text = "Menú principal"
        '
        'RadioButton2
        '
        Me.RadioButton2.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.RadioButton2.Location = New System.Drawing.Point(143, 21)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(75, 20)
        Me.RadioButton2.TabIndex = 72
        Me.RadioButton2.Text = "Descripción"
        '
        'RadioButton1
        '
        Me.RadioButton1.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.RadioButton1.Location = New System.Drawing.Point(143, 3)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(75, 20)
        Me.RadioButton1.TabIndex = 71
        Me.RadioButton1.Text = "Cod.Barras"
        '
        'lstdescripcion
        '
        Me.lstdescripcion.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstdescripcion.Location = New System.Drawing.Point(1, 65)
        Me.lstdescripcion.Name = "lstdescripcion"
        Me.lstdescripcion.Size = New System.Drawing.Size(236, 57)
        Me.lstdescripcion.TabIndex = 70
        Me.lstdescripcion.TabStop = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(-1, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(240, 5)
        Me.Label5.Text = "Label5"
        '
        'txtbusqueda
        '
        Me.txtbusqueda.Location = New System.Drawing.Point(50, 5)
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(87, 21)
        Me.txtbusqueda.TabIndex = 68
        Me.txtbusqueda.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.Text = "Buscar"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(-3, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 5)
        Me.Label2.Text = "Label2"
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(68, 155)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(87, 21)
        Me.txtcantidad.TabIndex = 77
        Me.txtcantidad.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(3, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 15)
        Me.Label3.Text = "Cantidad:"
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(165, 155)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(72, 20)
        Me.btnagregar.TabIndex = 80
        Me.btnagregar.Text = "Agregar"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(91, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 15)
        Me.Label4.Text = "Numero Carga:"
        '
        'lblcarga
        '
        Me.lblcarga.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblcarga.Location = New System.Drawing.Point(192, 42)
        Me.lblcarga.Name = "lblcarga"
        Me.lblcarga.Size = New System.Drawing.Size(33, 15)
        '
        'lblcantidadcarga
        '
        Me.lblcantidadcarga.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblcantidadcarga.Location = New System.Drawing.Point(189, 249)
        Me.lblcantidadcarga.Name = "lblcantidadcarga"
        Me.lblcantidadcarga.Size = New System.Drawing.Size(33, 15)
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(19, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(183, 15)
        Me.Label7.Text = "Cantidad productos en carga:"
        '
        'lstdescripcion2
        '
        Me.lstdescripcion2.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstdescripcion2.Location = New System.Drawing.Point(37, 184)
        Me.lstdescripcion2.Name = "lstdescripcion2"
        Me.lstdescripcion2.Size = New System.Drawing.Size(200, 57)
        Me.lstdescripcion2.TabIndex = 85
        Me.lstdescripcion2.TabStop = False
        '
        'lstcantidad2
        '
        Me.lstcantidad2.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstcantidad2.Location = New System.Drawing.Point(3, 184)
        Me.lstcantidad2.Name = "lstcantidad2"
        Me.lstcantidad2.Size = New System.Drawing.Size(30, 57)
        Me.lstcantidad2.TabIndex = 86
        Me.lstcantidad2.TabStop = False
        '
        'SP2
        '
        Me.SP2.BaudRate = 57600
        Me.SP2.PortName = "COM4"
        '
        'lstupc
        '
        Me.lstupc.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstupc.Location = New System.Drawing.Point(73, 125)
        Me.lstupc.Name = "lstupc"
        Me.lstupc.Size = New System.Drawing.Size(99, 13)
        Me.lstupc.TabIndex = 95
        Me.lstupc.TabStop = False
        '
        'Carga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.lstupc)
        Me.Controls.Add(Me.lstcantidad2)
        Me.Controls.Add(Me.lstdescripcion2)
        Me.Controls.Add(Me.lblcantidadcarga)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblcarga)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.lstdescripcion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtbusqueda)
        Me.Controls.Add(Me.Label1)
        Me.Menu = Me.mainMenu1
        Me.Name = "Carga"
        Me.Text = "Carga"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents lstdescripcion As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtbusqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnagregar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents lblcarga As System.Windows.Forms.Label
    Friend WithEvents lblcantidadcarga As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents lstdescripcion2 As System.Windows.Forms.ListBox
    Friend WithEvents lstcantidad2 As System.Windows.Forms.ListBox
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents SP2 As System.IO.Ports.SerialPort
    Friend WithEvents lstupc As System.Windows.Forms.ListBox
End Class
