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
        Label1 = New Label()
        Label2 = New Label()
        InputIP = New TextBox()
        IPkumu = New TextBox()
        Keterangan = New Label()
        Tambah = New Button()
        Reset = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(241, 160)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 20)
        Label1.TabIndex = 0
        Label1.Text = "IP Semester"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(241, 299)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 20)
        Label2.TabIndex = 1
        Label2.Text = "IP Kumulatif"
        ' 
        ' InputIP
        ' 
        InputIP.Location = New Point(401, 157)
        InputIP.Name = "InputIP"
        InputIP.Size = New Size(125, 27)
        InputIP.TabIndex = 2
        ' 
        ' IPkumu
        ' 
        IPkumu.Location = New Point(401, 296)
        IPkumu.Name = "IPkumu"
        IPkumu.Size = New Size(125, 27)
        IPkumu.TabIndex = 3
        ' 
        ' Keterangan
        ' 
        Keterangan.AutoSize = True
        Keterangan.Location = New Point(376, 376)
        Keterangan.Name = "Keterangan"
        Keterangan.Size = New Size(15, 20)
        Keterangan.TabIndex = 4
        Keterangan.Text = "-"
        ' 
        ' Tambah
        ' 
        Tambah.Location = New Point(352, 227)
        Tambah.Name = "Tambah"
        Tambah.Size = New Size(94, 29)
        Tambah.TabIndex = 5
        Tambah.Text = "Tambah"
        Tambah.UseVisualStyleBackColor = True
        ' 
        ' Reset
        ' 
        Reset.Location = New Point(478, 227)
        Reset.Name = "Reset"
        Reset.Size = New Size(94, 29)
        Reset.TabIndex = 6
        Reset.Text = "Reset"
        Reset.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Background_IWT_2025
        ClientSize = New Size(800, 450)
        Controls.Add(Reset)
        Controls.Add(Tambah)
        Controls.Add(Keterangan)
        Controls.Add(IPkumu)
        Controls.Add(InputIP)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Kalkulator IP"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents InputIP As TextBox
    Friend WithEvents IPkumu As TextBox
    Friend WithEvents Keterangan As Label
    Friend WithEvents Tambah As Button
    Friend WithEvents Reset As Button

End Class
