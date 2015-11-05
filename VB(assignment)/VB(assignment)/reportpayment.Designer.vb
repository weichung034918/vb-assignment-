<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reportpayment
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
        Me.PaymentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.databaseDataSet1 = New VB_assignment_.databaseDataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PaymentTableAdapter = New VB_assignment_.databaseDataSet1TableAdapters.PaymentTableAdapter()
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.databaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PaymentBindingSource
        '
        Me.PaymentBindingSource.DataMember = "Payment"
        Me.PaymentBindingSource.DataSource = Me.databaseDataSet1
        '
        'databaseDataSet1
        '
        Me.databaseDataSet1.DataSetName = "databaseDataSet1"
        Me.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.PaymentBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "VB_assignment_.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(11, 80)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(679, 268)
        Me.ReportViewer1.TabIndex = 0
        '
        'PaymentTableAdapter
        '
        Me.PaymentTableAdapter.ClearBeforeFill = True
        '
        'reportpayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 360)
        Me.Controls.Add(Me.ReportViewer1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(703, 360)
        Me.MinimumSize = New System.Drawing.Size(703, 360)
        Me.Name = "reportpayment"
        Me.Text = "Payment Report"
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.databaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PaymentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents databaseDataSet1 As VB_assignment_.databaseDataSet1
    Friend WithEvents PaymentTableAdapter As VB_assignment_.databaseDataSet1TableAdapters.PaymentTableAdapter
End Class
