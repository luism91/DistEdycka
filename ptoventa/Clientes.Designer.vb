<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class clientes
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
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtbusqueda = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnguardar = New System.Windows.Forms.Button
        Me.btneditar = New System.Windows.Forms.Button
        Me.txtnombre = New System.Windows.Forms.TextBox
        Me.txtcodigo = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lstnombre = New System.Windows.Forms.ListBox
        Me.lstcodigo = New System.Windows.Forms.ListBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lstlocalidad = New System.Windows.Forms.ListBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtlocalidad = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.cmbdiaruta = New System.Windows.Forms.ComboBox
        Me.lstdiaruta = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.MenuItem1)
        Me.mainMenu1.MenuItems.Add(Me.MenuItem2)
        '
        'MenuItem1
        '
        Me.MenuItem1.MenuItems.Add(Me.MenuItem3)
        Me.MenuItem1.MenuItems.Add(Me.MenuItem4)
        Me.MenuItem1.Text = "Opciones"
        '
        'MenuItem3
        '
        Me.MenuItem3.Text = "Eliminar Cliente"
        '
        'MenuItem4
        '
        Me.MenuItem4.MenuItems.Add(Me.MenuItem5)
        Me.MenuItem4.Text = "Cliente Nuevo"
        '
        'MenuItem5
        '
        Me.MenuItem5.Text = "1 - Agregar"
        '
        'MenuItem2
        '
        Me.MenuItem2.Text = "Menú Principal"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(5, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.Text = "Buscar"
        '
        'txtbusqueda
        '
        Me.txtbusqueda.Location = New System.Drawing.Point(57, 3)
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(100, 21)
        Me.txtbusqueda.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(0, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(270, 5)
        Me.Label5.Text = "Label5"
        '
        'btnguardar
        '
        Me.btnguardar.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnguardar.Location = New System.Drawing.Point(118, 233)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(105, 20)
        Me.btnguardar.TabIndex = 37
        Me.btnguardar.TabStop = False
        Me.btnguardar.Text = "&Guardar Cambios"
        '
        'btneditar
        '
        Me.btneditar.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btneditar.Location = New System.Drawing.Point(16, 232)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(95, 20)
        Me.btneditar.TabIndex = 36
        Me.btneditar.TabStop = False
        Me.btneditar.Text = "&Editar Cliente"
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.txtnombre.Location = New System.Drawing.Point(51, 190)
        Me.txtnombre.MaxLength = 50
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(180, 18)
        Me.txtnombre.TabIndex = 35
        Me.txtnombre.TabStop = False
        '
        'txtcodigo
        '
        Me.txtcodigo.Enabled = False
        Me.txtcodigo.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.txtcodigo.Location = New System.Drawing.Point(51, 169)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(51, 18)
        Me.txtcodigo.TabIndex = 34
        Me.txtcodigo.TabStop = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(43, 146)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(164, 20)
        Me.Label10.Text = "Cliente a modificar/crear"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(2, 190)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.Text = "Nombre"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(2, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.Text = "Codigo"
        '
        'lstnombre
        '
        Me.lstnombre.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstnombre.Location = New System.Drawing.Point(34, 48)
        Me.lstnombre.Name = "lstnombre"
        Me.lstnombre.Size = New System.Drawing.Size(125, 90)
        Me.lstnombre.TabIndex = 33
        Me.lstnombre.TabStop = False
        '
        'lstcodigo
        '
        Me.lstcodigo.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstcodigo.Location = New System.Drawing.Point(0, 48)
        Me.lstcodigo.Name = "lstcodigo"
        Me.lstcodigo.Size = New System.Drawing.Size(32, 90)
        Me.lstcodigo.TabIndex = 32
        Me.lstcodigo.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(33, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 10)
        Me.Label3.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(-1, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 10)
        Me.Label2.Text = "Cod."
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(0, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(270, 5)
        Me.Label4.Text = "Label4"
        '
        'lstlocalidad
        '
        Me.lstlocalidad.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstlocalidad.Location = New System.Drawing.Point(160, 48)
        Me.lstlocalidad.Name = "lstlocalidad"
        Me.lstlocalidad.Size = New System.Drawing.Size(115, 90)
        Me.lstlocalidad.TabIndex = 45
        Me.lstlocalidad.TabStop = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(160, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 10)
        Me.Label6.Text = "Localidad"
        '
        'txtlocalidad
        '
        Me.txtlocalidad.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.txtlocalidad.Location = New System.Drawing.Point(51, 212)
        Me.txtlocalidad.MaxLength = 50
        Me.txtlocalidad.Name = "txtlocalidad"
        Me.txtlocalidad.Size = New System.Drawing.Size(180, 18)
        Me.txtlocalidad.TabIndex = 49
        Me.txtlocalidad.TabStop = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(1, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.Text = "Localidad"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(102, 172)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.Text = "Dia ruta"
        '
        'cmbdiaruta
        '
        Me.cmbdiaruta.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.cmbdiaruta.Items.Add("- DIA RUTA -")
        Me.cmbdiaruta.Items.Add("LUNES")
        Me.cmbdiaruta.Items.Add("MARTES")
        Me.cmbdiaruta.Items.Add("MIERCOLES")
        Me.cmbdiaruta.Items.Add("JUEVES")
        Me.cmbdiaruta.Items.Add("VIERNES")
        Me.cmbdiaruta.Location = New System.Drawing.Point(146, 168)
        Me.cmbdiaruta.Name = "cmbdiaruta"
        Me.cmbdiaruta.Size = New System.Drawing.Size(85, 19)
        Me.cmbdiaruta.TabIndex = 53
        '
        'lstdiaruta
        '
        Me.lstdiaruta.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lstdiaruta.Location = New System.Drawing.Point(277, 48)
        Me.lstdiaruta.Name = "lstdiaruta"
        Me.lstdiaruta.Size = New System.Drawing.Size(32, 90)
        Me.lstdiaruta.TabIndex = 65
        Me.lstdiaruta.TabStop = False
        '
        'clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.lstdiaruta)
        Me.Controls.Add(Me.cmbdiaruta)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtlocalidad)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lstlocalidad)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btneditar)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lstnombre)
        Me.Controls.Add(Me.lstcodigo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtbusqueda)
        Me.Controls.Add(Me.Label1)
        Me.Menu = Me.mainMenu1
        Me.Name = "clientes"
        Me.Text = "Clientes"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtbusqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents btneditar As System.Windows.Forms.Button
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lstnombre As System.Windows.Forms.ListBox
    Friend WithEvents lstcodigo As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents lstlocalidad As System.Windows.Forms.ListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtlocalidad As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbdiaruta As System.Windows.Forms.ComboBox
    Friend WithEvents lstdiaruta As System.Windows.Forms.ListBox
End Class
