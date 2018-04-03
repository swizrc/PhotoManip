<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AxImageBox1 = New AxcsXImageTrial.AxImageBox()
        Me.loadButton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.SaveImageButton = New System.Windows.Forms.Button()
        CType(Me.AxImageBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxImageBox1
        '
        Me.AxImageBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AxImageBox1.Location = New System.Drawing.Point(12, 12)
        Me.AxImageBox1.Name = "AxImageBox1"
        Me.AxImageBox1.OcxState = CType(resources.GetObject("AxImageBox1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxImageBox1.Size = New System.Drawing.Size(405, 464)
        Me.AxImageBox1.TabIndex = 0
        '
        'loadButton
        '
        Me.loadButton.Location = New System.Drawing.Point(468, 52)
        Me.loadButton.Name = "loadButton"
        Me.loadButton.Size = New System.Drawing.Size(75, 23)
        Me.loadButton.TabIndex = 1
        Me.loadButton.Text = "Load Image"
        Me.loadButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(468, 15)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(406, 20)
        Me.TextBox1.TabIndex = 2
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 18
        Me.ListBox1.Location = New System.Drawing.Point(469, 82)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(405, 382)
        Me.ListBox1.Sorted = True
        Me.ListBox1.TabIndex = 4
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(549, 52)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(75, 23)
        Me.EditButton.TabIndex = 5
        Me.EditButton.Text = "Edit Data"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'SaveImageButton
        '
        Me.SaveImageButton.Location = New System.Drawing.Point(799, 52)
        Me.SaveImageButton.Name = "SaveImageButton"
        Me.SaveImageButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveImageButton.TabIndex = 6
        Me.SaveImageButton.Text = "Save Image"
        Me.SaveImageButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 488)
        Me.Controls.Add(Me.SaveImageButton)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.loadButton)
        Me.Controls.Add(Me.AxImageBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.AxImageBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AxImageBox1 As AxcsXImageTrial.AxImageBox
    Friend WithEvents loadButton As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents EditButton As Button
    Friend WithEvents SaveImageButton As Button
End Class
