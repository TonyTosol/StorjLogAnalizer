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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RG = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Succsesfull = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Faild = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FaildCritical = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KPD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.RG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(842, 34)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(161, 22)
        Me.TextBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(842, 72)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RG
        '
        Me.RG.AllowUserToAddRows = False
        Me.RG.AllowUserToDeleteRows = False
        Me.RG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OName, Me.Succsesfull, Me.Faild, Me.FaildCritical, Me.Total, Me.KPD})
        Me.RG.Location = New System.Drawing.Point(0, 0)
        Me.RG.Name = "RG"
        Me.RG.ReadOnly = True
        Me.RG.RowHeadersWidth = 51
        Me.RG.RowTemplate.Height = 24
        Me.RG.Size = New System.Drawing.Size(822, 526)
        Me.RG.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(842, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Log rows analized"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(842, 171)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(101, 22)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.Text = "0"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(839, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 60)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "sleep in ms, to lower processorutilization, recomended 0-10"
        '
        'OName
        '
        Me.OName.HeaderText = "OpName"
        Me.OName.MinimumWidth = 6
        Me.OName.Name = "OName"
        Me.OName.ReadOnly = True
        Me.OName.Width = 125
        '
        'Succsesfull
        '
        Me.Succsesfull.HeaderText = "Succsesfull"
        Me.Succsesfull.MinimumWidth = 6
        Me.Succsesfull.Name = "Succsesfull"
        Me.Succsesfull.ReadOnly = True
        '
        'Faild
        '
        Me.Faild.HeaderText = "Faild"
        Me.Faild.MinimumWidth = 6
        Me.Faild.Name = "Faild"
        Me.Faild.ReadOnly = True
        Me.Faild.Width = 75
        '
        'FaildCritical
        '
        Me.FaildCritical.HeaderText = "Faild Critical"
        Me.FaildCritical.MinimumWidth = 6
        Me.FaildCritical.Name = "FaildCritical"
        Me.FaildCritical.ReadOnly = True
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.MinimumWidth = 6
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 75
        '
        'KPD
        '
        Me.KPD.HeaderText = "KPD"
        Me.KPD.MinimumWidth = 6
        Me.KPD.Name = "KPD"
        Me.KPD.ReadOnly = True
        Me.KPD.Width = 50
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 534)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RG)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.RG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents RG As DataGridView
    Friend WithEvents OPName As DataGridViewTextBoxColumn

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents OName As DataGridViewTextBoxColumn
    Friend WithEvents Succsesfull As DataGridViewTextBoxColumn
    Friend WithEvents Faild As DataGridViewTextBoxColumn
    Friend WithEvents FaildCritical As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents KPD As DataGridViewTextBoxColumn
End Class
