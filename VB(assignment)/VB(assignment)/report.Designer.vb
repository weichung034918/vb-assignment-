<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class report
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.MembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.databaseDataSet = New VB_assignment_.databaseDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MembersTableAdapter = New VB_assignment_.databaseDataSetTableAdapters.MembersTableAdapter()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.databaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MembersBindingSource
        '
        Me.MembersBindingSource.DataMember = "Members"
        Me.MembersBindingSource.DataSource = Me.databaseDataSet
        '
        'databaseDataSet
        '
        Me.databaseDataSet.DataSetName = "databaseDataSet"
        Me.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.MembersBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "VB_assignment_.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(21, 89)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(657, 246)
        Me.ReportViewer1.TabIndex = 0
        '
        'MembersTableAdapter
        '
        Me.MembersTableAdapter.ClearBeforeFill = True
        '
        'report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 360)
        Me.Controls.Add(Me.ReportViewer1)
        Me.MaximumSize = New System.Drawing.Size(703, 360)
        Me.MinimumSize = New System.Drawing.Size(703, 360)
        Me.Name = "report"
        Me.Text = "Member Report"
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.databaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MembersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents databaseDataSet As VB_assignment_.databaseDataSet
    Friend WithEvents MembersTableAdapter As VB_assignment_.databaseDataSetTableAdapters.MembersTableAdapter
End Class
