<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Button1 = New Button()
        Button2 = New Button()
        tfirstname = New TextBox()
        tage = New TextBox()
        tlastname = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        bibilhin = New ListBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Window
        Button1.ForeColor = SystemColors.ControlText
        Button1.Location = New Point(580, 311)
        Button1.Name = "Button1"
        Button1.Size = New Size(136, 54)
        Button1.TabIndex = 0
        Button1.Text = "BAKITTTT"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.Window
        Button2.Location = New Point(93, 99)
        Button2.Name = "Button2"
        Button2.Size = New Size(98, 25)
        Button2.TabIndex = 1
        Button2.Text = "Binangkal"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' tfirstname
        ' 
        tfirstname.Location = New Point(93, 12)
        tfirstname.Name = "tfirstname"
        tfirstname.Size = New Size(157, 23)
        tfirstname.TabIndex = 2
        ' 
        ' tage
        ' 
        tage.Location = New Point(93, 70)
        tage.Name = "tage"
        tage.Size = New Size(28, 23)
        tage.TabIndex = 4
        ' 
        ' tlastname
        ' 
        tlastname.Location = New Point(93, 41)
        tlastname.Name = "tlastname"
        tlastname.Size = New Size(157, 23)
        tlastname.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(23, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 15)
        Label1.TabIndex = 5
        Label1.Text = "First Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(27, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 15)
        Label2.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(24, 44)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 15)
        Label3.TabIndex = 7
        Label3.Text = "Last Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(59, 73)
        Label4.Name = "Label4"
        Label4.Size = New Size(28, 15)
        Label4.TabIndex = 8
        Label4.Text = "Age"
        ' 
        ' bibilhin
        ' 
        bibilhin.FormattingEnabled = True
        bibilhin.ItemHeight = 15
        bibilhin.Items.AddRange(New Object() {"Sinigang mix", "Paminta ", "luya ", "bawang ", "sibuyas ", "Kamatis", "Suka ", "Orayt"})
        bibilhin.Location = New Point(271, 12)
        bibilhin.Name = "bibilhin"
        bibilhin.Size = New Size(142, 109)
        bibilhin.TabIndex = 9
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(748, 392)
        Controls.Add(bibilhin)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(tlastname)
        Controls.Add(tage)
        Controls.Add(tfirstname)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        Tag = "button"
        Text = "Sheesh"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As Button
    Friend WithEvents tfirstname As TextBox
    Friend WithEvents tage As TextBox
    Friend WithEvents tlastname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents bibilhin As ListBox

End Class
