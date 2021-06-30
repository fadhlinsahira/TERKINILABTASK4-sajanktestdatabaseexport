<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class detail
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAuthorDetail = New System.Windows.Forms.TextBox()
        Me.txtPublisherDetail = New System.Windows.Forms.TextBox()
        Me.nudPagesDetail = New System.Windows.Forms.NumericUpDown()
        Me.btnEditDetail = New System.Windows.Forms.Button()
        Me.btnDeleteDetail = New System.Windows.Forms.Button()
        Me.btnCloseDetail = New System.Windows.Forms.Button()
        CType(Me.nudPagesDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Detail"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Author"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Publisher"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Pages"
        '
        'txtAuthorDetail
        '
        Me.txtAuthorDetail.Location = New System.Drawing.Point(97, 68)
        Me.txtAuthorDetail.Name = "txtAuthorDetail"
        Me.txtAuthorDetail.Size = New System.Drawing.Size(100, 22)
        Me.txtAuthorDetail.TabIndex = 4
        '
        'txtPublisherDetail
        '
        Me.txtPublisherDetail.Location = New System.Drawing.Point(97, 110)
        Me.txtPublisherDetail.Name = "txtPublisherDetail"
        Me.txtPublisherDetail.Size = New System.Drawing.Size(100, 22)
        Me.txtPublisherDetail.TabIndex = 5
        '
        'nudPagesDetail
        '
        Me.nudPagesDetail.Location = New System.Drawing.Point(97, 158)
        Me.nudPagesDetail.Name = "nudPagesDetail"
        Me.nudPagesDetail.Size = New System.Drawing.Size(62, 22)
        Me.nudPagesDetail.TabIndex = 6
        '
        'btnEditDetail
        '
        Me.btnEditDetail.Location = New System.Drawing.Point(19, 208)
        Me.btnEditDetail.Name = "btnEditDetail"
        Me.btnEditDetail.Size = New System.Drawing.Size(75, 23)
        Me.btnEditDetail.TabIndex = 7
        Me.btnEditDetail.Text = "EDIT"
        Me.btnEditDetail.UseVisualStyleBackColor = True
        '
        'btnDeleteDetail
        '
        Me.btnDeleteDetail.Location = New System.Drawing.Point(111, 208)
        Me.btnDeleteDetail.Name = "btnDeleteDetail"
        Me.btnDeleteDetail.Size = New System.Drawing.Size(95, 23)
        Me.btnDeleteDetail.TabIndex = 8
        Me.btnDeleteDetail.Text = "DELETE"
        Me.btnDeleteDetail.UseVisualStyleBackColor = True
        '
        'btnCloseDetail
        '
        Me.btnCloseDetail.Location = New System.Drawing.Point(224, 208)
        Me.btnCloseDetail.Name = "btnCloseDetail"
        Me.btnCloseDetail.Size = New System.Drawing.Size(75, 23)
        Me.btnCloseDetail.TabIndex = 9
        Me.btnCloseDetail.Text = "CLOSE"
        Me.btnCloseDetail.UseVisualStyleBackColor = True
        '
        'detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(386, 292)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCloseDetail)
        Me.Controls.Add(Me.btnDeleteDetail)
        Me.Controls.Add(Me.btnEditDetail)
        Me.Controls.Add(Me.nudPagesDetail)
        Me.Controls.Add(Me.txtPublisherDetail)
        Me.Controls.Add(Me.txtAuthorDetail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "detail"
        Me.Text = "Books"
        CType(Me.nudPagesDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAuthorDetail As TextBox
    Friend WithEvents txtPublisherDetail As TextBox
    Friend WithEvents nudPagesDetail As NumericUpDown
    Friend WithEvents btnEditDetail As Button
    Friend WithEvents btnDeleteDetail As Button
    Friend WithEvents btnCloseDetail As Button
End Class
