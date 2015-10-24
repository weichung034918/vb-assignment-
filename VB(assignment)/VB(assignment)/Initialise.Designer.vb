<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Initialise
    Inherits MaterialSkin.Controls.MaterialForm

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
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.mdb_btn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.accdb_btn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.SuspendLayout()
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(13, 80)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(108, 19)
        Me.MaterialLabel1.TabIndex = 2
        Me.MaterialLabel1.Text = "MaterialLabel1"
        '
        'mdb_btn
        '
        Me.mdb_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mdb_btn.Depth = 0
        Me.mdb_btn.Location = New System.Drawing.Point(12, 148)
        Me.mdb_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.mdb_btn.Name = "mdb_btn"
        Me.mdb_btn.Primary = True
        Me.mdb_btn.Size = New System.Drawing.Size(193, 35)
        Me.mdb_btn.TabIndex = 3
        Me.mdb_btn.Text = "Create MDB Database"
        Me.mdb_btn.UseVisualStyleBackColor = True
        '
        'accdb_btn
        '
        Me.accdb_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.accdb_btn.Depth = 0
        Me.accdb_btn.Location = New System.Drawing.Point(12, 201)
        Me.accdb_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.accdb_btn.Name = "accdb_btn"
        Me.accdb_btn.Primary = True
        Me.accdb_btn.Size = New System.Drawing.Size(193, 33)
        Me.accdb_btn.TabIndex = 4
        Me.accdb_btn.Text = "Create ACCDB Database"
        Me.accdb_btn.UseVisualStyleBackColor = True
        '
        'Initialise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(251, 264)
        Me.Controls.Add(Me.accdb_btn)
        Me.Controls.Add(Me.mdb_btn)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Name = "Initialise"
        Me.Text = "Initial Setup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents mdb_btn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents accdb_btn As MaterialSkin.Controls.MaterialRaisedButton
End Class
