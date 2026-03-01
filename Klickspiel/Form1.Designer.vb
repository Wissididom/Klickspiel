<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Button1 = New System.Windows.Forms.Button()
        ToolStrip1 = New System.Windows.Forms.ToolStrip()
        ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Timer1 = New System.Windows.Forms.Timer(components)
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New System.Drawing.Point(268, 241)
        Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Button1.Name = "Button1"
        Button1.Size = New System.Drawing.Size(88, 27)
        Button1.TabIndex = 0
        Button1.Text = "Klick mich!!!"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {ToolStripLabel1, ToolStripLabel2})
        ToolStrip1.Location = New System.Drawing.Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New System.Drawing.Size(687, 25)
        ToolStrip1.TabIndex = 1
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' ToolStripLabel1
        ' 
        ToolStripLabel1.Name = "ToolStripLabel1"
        ToolStripLabel1.Size = New System.Drawing.Size(13, 22)
        ToolStripLabel1.Text = "0"
        ' 
        ' ToolStripLabel2
        ' 
        ToolStripLabel2.Name = "ToolStripLabel2"
        ToolStripLabel2.Size = New System.Drawing.Size(31, 22)
        ToolStripLabel2.Text = "2000"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(7F, 15F)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(687, 512)
        Controls.Add(Button1)
        Controls.Add(ToolStrip1)
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        MaximizeBox = False
        Name = "Form1"
        ShowIcon = False
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Text = "Klickspiel"
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
