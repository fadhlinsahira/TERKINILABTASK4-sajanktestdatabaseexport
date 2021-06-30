<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edit
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
        Me.btnCancelEdit = New System.Windows.Forms.Button()
        Me.btnSaveEdit = New System.Windows.Forms.Button()
        Me.nudPagesEdit = New System.Windows.Forms.NumericUpDown()
        Me.txtPublisherEdit = New System.Windows.Forms.TextBox()
        Me.txtAuthorEdit = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.nudPagesEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelEdit
        '
        Me.btnCancelEdit.Location = New System.Drawing.Point(164, 211)
        Me.btnCancelEdit.Name = "btnCancelEdit"
        Me.btnCancelEdit.Size = New System.Drawing.Size(83, 23)
        Me.btnCancelEdit.TabIndex = 28
        Me.btnCancelEdit.Text = "CANCEL"
        Me.btnCancelEdit.UseVisualStyleBackColor = True
        '
        'btnSaveEdit
        '
        Me.btnSaveEdit.Location = New System.Drawing.Point(35, 211)
        Me.btnSaveEdit.Name = "btnSaveEdit"
        Me.btnSaveEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveEdit.TabIndex = 27
        Me.btnSaveEdit.Text = "SAVE"
        Me.btnSaveEdit.UseVisualStyleBackColor = True
        '
        'nudPagesEdit
        '
        Me.nudPagesEdit.Location = New System.Drawing.Point(96, 161)
        Me.nudPagesEdit.Name = "nudPagesEdit"
        Me.nudPagesEdit.Size = New System.Drawing.Size(59, 22)
        Me.nudPagesEdit.TabIndex = 26
        '
        'txtPublisherEdit
        '
        Me.txtPublisherEdit.Location = New System.Drawing.Point(96, 113)
        Me.txtPublisherEdit.Name = "txtPublisherEdit"
        Me.txtPublisherEdit.Size = New System.Drawing.Size(100, 22)
        Me.txtPublisherEdit.TabIndex = 25
        '
        'txtAuthorEdit
        '
        Me.txtAuthorEdit.Location = New System.Drawing.Point(96, 71)
        Me.txtAuthorEdit.Name = "txtAuthorEdit"
        Me.txtAuthorEdit.Size = New System.Drawing.Size(100, 22)
        Me.txtAuthorEdit.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 17)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Pages"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 17)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Publisher"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 17)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Author"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 23)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Edit"
        '
        'edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(334, 304)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancelEdit)
        Me.Controls.Add(Me.btnSaveEdit)
        Me.Controls.Add(Me.nudPagesEdit)
        Me.Controls.Add(Me.txtPublisherEdit)
        Me.Controls.Add(Me.txtAuthorEdit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "edit"
        Me.Text = "Books"
        CType(Me.nudPagesEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelEdit As Button
    Friend WithEvents btnSaveEdit As Button
    Friend WithEvents nudPagesEdit As NumericUpDown
    Friend WithEvents txtPublisherEdit As TextBox
    Friend WithEvents txtAuthorEdit As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
