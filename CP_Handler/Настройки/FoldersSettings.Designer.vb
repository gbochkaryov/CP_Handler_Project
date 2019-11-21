Namespace Настройки
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FoldersDialog
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
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.OK_Button = New System.Windows.Forms.Button()
            Me.Cancel_Button = New System.Windows.Forms.Button()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Button3 = New System.Windows.Forms.Button()
            Me.Button4 = New System.Windows.Forms.Button()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.TableLayoutPanel1.SuspendLayout
            Me.SuspendLayout
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
            Me.TableLayoutPanel1.ColumnCount = 2
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
            Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
            Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(370, 285)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 1
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
            Me.TableLayoutPanel1.TabIndex = 0
            '
            'OK_Button
            '
            Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.OK_Button.Location = New System.Drawing.Point(3, 3)
            Me.OK_Button.Name = "OK_Button"
            Me.OK_Button.Size = New System.Drawing.Size(67, 23)
            Me.OK_Button.TabIndex = 0
            Me.OK_Button.Text = "OK"
            '
            'Cancel_Button
            '
            Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
            Me.Cancel_Button.Name = "Cancel_Button"
            Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
            Me.Cancel_Button.TabIndex = 1
            Me.Cancel_Button.Text = "Cancel"
            '
            'Label1
            '
            Me.Label1.AutoSize = true
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
            Me.Label1.Location = New System.Drawing.Point(12, 19)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(192, 13)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Путь ко входящим файлам (IN)"
            '
            'Label2
            '
            Me.Label2.AutoSize = true
            Me.Label2.Location = New System.Drawing.Point(242, 19)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(39, 13)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "Label2"
            '
            'Button1
            '
            Me.Button1.Location = New System.Drawing.Point(245, 35)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(75, 23)
            Me.Button1.TabIndex = 3
            Me.Button1.Text = "Изменить"
            Me.Button1.UseVisualStyleBackColor = true
            '
            'Label3
            '
            Me.Label3.AutoSize = true
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
            Me.Label3.Location = New System.Drawing.Point(12, 83)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(225, 13)
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "Путь к обработанным файлам (OUT)"
            '
            'Label4
            '
            Me.Label4.AutoSize = true
            Me.Label4.Location = New System.Drawing.Point(245, 83)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(39, 13)
            Me.Label4.TabIndex = 5
            Me.Label4.Text = "Label4"
            '
            'Button2
            '
            Me.Button2.Location = New System.Drawing.Point(245, 99)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(75, 23)
            Me.Button2.TabIndex = 6
            Me.Button2.Text = "Изменить"
            Me.Button2.UseVisualStyleBackColor = true
            '
            'Label5
            '
            Me.Label5.AutoSize = true
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
            Me.Label5.Location = New System.Drawing.Point(12, 153)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(196, 13)
            Me.Label5.TabIndex = 7
            Me.Label5.Text = "Путь к архивным файлам (ARC)"
            '
            'Label6
            '
            Me.Label6.AutoSize = true
            Me.Label6.Location = New System.Drawing.Point(245, 153)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(39, 13)
            Me.Label6.TabIndex = 8
            Me.Label6.Text = "Label6"
            '
            'Button3
            '
            Me.Button3.Location = New System.Drawing.Point(248, 169)
            Me.Button3.Name = "Button3"
            Me.Button3.Size = New System.Drawing.Size(75, 23)
            Me.Button3.TabIndex = 9
            Me.Button3.Text = "Изменить"
            Me.Button3.UseVisualStyleBackColor = true
            '
            'Button4
            '
            Me.Button4.Location = New System.Drawing.Point(250, 241)
            Me.Button4.Name = "Button4"
            Me.Button4.Size = New System.Drawing.Size(75, 23)
            Me.Button4.TabIndex = 12
            Me.Button4.Text = "Изменить"
            Me.Button4.UseVisualStyleBackColor = true
            '
            'Label7
            '
            Me.Label7.AutoSize = true
            Me.Label7.Location = New System.Drawing.Point(247, 225)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(39, 13)
            Me.Label7.TabIndex = 11
            Me.Label7.Text = "Label7"
            '
            'Label8
            '
            Me.Label8.AutoSize = true
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
            Me.Label8.Location = New System.Drawing.Point(14, 225)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(164, 13)
            Me.Label8.TabIndex = 10
            Me.Label8.Text = "Путь к файлам лога (LOG)"
            '
            'FoldersDialog
            '
            Me.AcceptButton = Me.OK_Button
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.Cancel_Button
            Me.ClientSize = New System.Drawing.Size(528, 326)
            Me.Controls.Add(Me.Button4)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.Button3)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.Button2)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = false
            Me.MinimizeBox = false
            Me.Name = "FoldersDialog"
            Me.ShowInTaskbar = false
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Настройка папок программы"
            Me.TableLayoutPanel1.ResumeLayout(false)
            Me.ResumeLayout(false)
            Me.PerformLayout

        End Sub
        Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents OK_Button As System.Windows.Forms.Button
        Friend WithEvents Cancel_Button As System.Windows.Forms.Button
        Friend WithEvents Label1 As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
        Friend WithEvents Button1 As Button
        Friend WithEvents Label3 As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents Button2 As Button
        Friend WithEvents Label5 As Label
        Friend WithEvents Label6 As Label
        Friend WithEvents Button3 As Button
        Friend WithEvents Button4 As Button
        Friend WithEvents Label7 As Label
        Friend WithEvents Label8 As Label
    End Class
End NameSpace