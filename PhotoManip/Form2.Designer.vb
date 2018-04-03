<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrevTagName = New System.Windows.Forms.Label()
        Me.ChangeLabel = New System.Windows.Forms.Label()
        Me.EditTextBox = New System.Windows.Forms.TextBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Edit Exif"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PrevTagName
        '
        Me.PrevTagName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrevTagName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrevTagName.Location = New System.Drawing.Point(0, 37)
        Me.PrevTagName.Name = "PrevTagName"
        Me.PrevTagName.Size = New System.Drawing.Size(316, 15)
        Me.PrevTagName.TabIndex = 2
        Me.PrevTagName.Text = "Previous: "
        Me.PrevTagName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChangeLabel
        '
        Me.ChangeLabel.AutoSize = True
        Me.ChangeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangeLabel.Location = New System.Drawing.Point(21, 72)
        Me.ChangeLabel.Name = "ChangeLabel"
        Me.ChangeLabel.Size = New System.Drawing.Size(66, 15)
        Me.ChangeLabel.TabIndex = 3
        Me.ChangeLabel.Text = "Change to:"
        '
        'EditTextBox
        '
        Me.EditTextBox.Location = New System.Drawing.Point(93, 71)
        Me.EditTextBox.Name = "EditTextBox"
        Me.EditTextBox.Size = New System.Drawing.Size(144, 20)
        Me.EditTextBox.TabIndex = 4
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(127, 106)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 5
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 169)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.EditTextBox)
        Me.Controls.Add(Me.ChangeLabel)
        Me.Controls.Add(Me.PrevTagName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PrevTagName As Label
    Friend WithEvents ChangeLabel As Label
    Friend WithEvents EditTextBox As TextBox
    Friend WithEvents SaveButton As Button
End Class
