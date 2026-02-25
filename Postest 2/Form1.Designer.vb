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
        InputIP = New TextBox()
        Label1 = New Label()
        Tambah = New Button()
        Reset = New Button()
        IPkumu = New TextBox()
        Label2 = New Label()
        Keterangan = New Label()
        SuspendLayout()
        ' 
        ' InputIP
        ' 
        InputIP.Location = New Point(376, 159)
        InputIP.Name = "InputIP"
        InputIP.Size = New Size(125, 27)
        InputIP.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveBorder
        Label1.Font = New Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(241, 163)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 18)
        Label1.TabIndex = 1
        Label1.Text = "IP Semester"
        ' 
        ' Tambah
        ' 
        Tambah.Location = New Point(338, 221)
        Tambah.Name = "Tambah"
        Tambah.Size = New Size(94, 29)
        Tambah.TabIndex = 2
        Tambah.Text = "Tambah"
        Tambah.UseVisualStyleBackColor = True
        ' 
        ' Reset
        ' 
        Reset.Location = New Point(455, 221)
        Reset.Name = "Reset"
        Reset.Size = New Size(94, 29)
        Reset.TabIndex = 3
        Reset.Text = "Reset"
        Reset.UseVisualStyleBackColor = True
        ' 
        ' IPkumu
        ' 
        IPkumu.Location = New Point(376, 292)
        IPkumu.Name = "IPkumu"
        IPkumu.Size = New Size(125, 27)
        IPkumu.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ActiveBorder
        Label2.Font = New Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(241, 295)
        Label2.Name = "Label2"
        Label2.Size = New Size(111, 18)
        Label2.TabIndex = 5
        Label2.Text = "IP Kumulatif"
        ' 
        ' Keterangan
        ' 
        Keterangan.AutoSize = True
        Keterangan.Location = New Point(405, 360)
        Keterangan.Name = "Keterangan"
        Keterangan.Size = New Size(0, 20)
        Keterangan.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SlateBlue
        BackgroundImage = My.Resources.Resources.Background_IWT_2025
        ClientSize = New Size(840, 463)
        Controls.Add(Keterangan)
        Controls.Add(Label2)
        Controls.Add(IPkumu)
        Controls.Add(Reset)
        Controls.Add(Tambah)
        Controls.Add(Label1)
        Controls.Add(InputIP)
        Name = "Form1"
        Text = "Kalkulator IP"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents InputIP As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Tambah As Button
    Friend WithEvents Reset As Button
    Friend WithEvents IPkumu As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Keterangan As Label

End Class
