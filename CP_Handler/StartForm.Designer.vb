<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartForm))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ЗагрузитьФайлToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.НовоеМенюToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВыбратьФайлToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОбработатьПапкуToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВыходToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.НастройкиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПапкиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВходныеЗаголовкиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПодключениеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПомощьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОПрограммеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ТестированиеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЗапросToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout
        Me.MenuStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ЗагрузитьФайлToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(156, 26)
        '
        'ЗагрузитьФайлToolStripMenuItem
        '
        Me.ЗагрузитьФайлToolStripMenuItem.Name = "ЗагрузитьФайлToolStripMenuItem"
        Me.ЗагрузитьФайлToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ЗагрузитьФайлToolStripMenuItem.Text = "Загрузить файл"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.НовоеМенюToolStripMenuItem, Me.НастройкиToolStripMenuItem, Me.ТестированиеToolStripMenuItem, Me.ПомощьToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(363, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'НовоеМенюToolStripMenuItem
        '
        Me.НовоеМенюToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ВыбратьФайлToolStripMenuItem, Me.ОбработатьПапкуToolStripMenuItem, Me.ВыходToolStripMenuItem})
        Me.НовоеМенюToolStripMenuItem.Name = "НовоеМенюToolStripMenuItem"
        Me.НовоеМенюToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.НовоеМенюToolStripMenuItem.Text = "Файл"
        '
        'ВыбратьФайлToolStripMenuItem
        '
        Me.ВыбратьФайлToolStripMenuItem.Name = "ВыбратьФайлToolStripMenuItem"
        Me.ВыбратьФайлToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ВыбратьФайлToolStripMenuItem.Text = "Выбрать файл"
        '
        'ОбработатьПапкуToolStripMenuItem
        '
        Me.ОбработатьПапкуToolStripMenuItem.Name = "ОбработатьПапкуToolStripMenuItem"
        Me.ОбработатьПапкуToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ОбработатьПапкуToolStripMenuItem.Text = "Обработать папку IN"
        '
        'ВыходToolStripMenuItem
        '
        Me.ВыходToolStripMenuItem.Name = "ВыходToolStripMenuItem"
        Me.ВыходToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ВыходToolStripMenuItem.Text = "Выход"
        '
        'НастройкиToolStripMenuItem
        '
        Me.НастройкиToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ПапкиToolStripMenuItem, Me.ВходныеЗаголовкиToolStripMenuItem, Me.ПодключениеToolStripMenuItem})
        Me.НастройкиToolStripMenuItem.Name = "НастройкиToolStripMenuItem"
        Me.НастройкиToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.НастройкиToolStripMenuItem.Text = "Настройки"
        '
        'ПапкиToolStripMenuItem
        '
        Me.ПапкиToolStripMenuItem.Name = "ПапкиToolStripMenuItem"
        Me.ПапкиToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ПапкиToolStripMenuItem.Text = "Папки"
        '
        'ВходныеЗаголовкиToolStripMenuItem
        '
        Me.ВходныеЗаголовкиToolStripMenuItem.Name = "ВходныеЗаголовкиToolStripMenuItem"
        Me.ВходныеЗаголовкиToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ВходныеЗаголовкиToolStripMenuItem.Text = "Входные заголовки"
        '
        'ПодключениеToolStripMenuItem
        '
        Me.ПодключениеToolStripMenuItem.Name = "ПодключениеToolStripMenuItem"
        Me.ПодключениеToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ПодключениеToolStripMenuItem.Text = "Подключение"
        '
        'ПомощьToolStripMenuItem
        '
        Me.ПомощьToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ОПрограммеToolStripMenuItem})
        Me.ПомощьToolStripMenuItem.Name = "ПомощьToolStripMenuItem"
        Me.ПомощьToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ПомощьToolStripMenuItem.Text = "Помощь"
        '
        'ОПрограммеToolStripMenuItem
        '
        Me.ОПрограммеToolStripMenuItem.Name = "ОПрограммеToolStripMenuItem"
        Me.ОПрограммеToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.ОПрограммеToolStripMenuItem.Text = "О программе"
        '
        'ТестированиеToolStripMenuItem
        '
        Me.ТестированиеToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ЗапросToolStripMenuItem})
        Me.ТестированиеToolStripMenuItem.Name = "ТестированиеToolStripMenuItem"
        Me.ТестированиеToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.ТестированиеToolStripMenuItem.Text = "Тестирование"
        '
        'ЗапросToolStripMenuItem
        '
        Me.ЗапросToolStripMenuItem.Name = "ЗапросToolStripMenuItem"
        Me.ЗапросToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ЗапросToolStripMenuItem.Text = "Входные заголовки"
        '
        'StartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 348)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "StartForm"
        Me.Text = "ПК ""Обработка запросов по КВ"""
        Me.ContextMenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ЗагрузитьФайлToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents НовоеМенюToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ВыбратьФайлToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ВыходToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ПомощьToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents НастройкиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ПапкиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ВходныеЗаголовкиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОПрограммеToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ПодключениеToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОбработатьПапкуToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ТестированиеToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ЗапросToolStripMenuItem As ToolStripMenuItem
End Class
