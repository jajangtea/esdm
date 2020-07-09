<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FLaporan_wiup
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.DataTableWiupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.sigDataSet = New esdm.sigDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReportViewer3 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataTableWiupTableAdapter = New esdm.sigDataSetTableAdapters.DataTableWiupTableAdapter()
        CType(Me.DataTableWiupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sigDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataTableWiupBindingSource
        '
        Me.DataTableWiupBindingSource.DataMember = "DataTableWiup"
        Me.DataTableWiupBindingSource.DataSource = Me.sigDataSet
        '
        'sigDataSet
        '
        Me.sigDataSet.DataSetName = "sigDataSet"
        Me.sigDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(396, 246)
        Me.ReportViewer1.TabIndex = 0
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.ServerReport.BearerToken = Nothing
        Me.ReportViewer2.Size = New System.Drawing.Size(396, 246)
        Me.ReportViewer2.TabIndex = 0
        '
        'ReportViewer3
        '
        Me.ReportViewer3.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetLaporan"
        ReportDataSource1.Value = Me.DataTableWiupBindingSource
        Me.ReportViewer3.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer3.LocalReport.ReportEmbeddedResource = "esdm.ReportWiup.rdlc"
        Me.ReportViewer3.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer3.Name = "ReportViewer3"
        Me.ReportViewer3.ServerReport.BearerToken = Nothing
        Me.ReportViewer3.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer3.TabIndex = 0
        '
        'DataTableWiupTableAdapter
        '
        Me.DataTableWiupTableAdapter.ClearBeforeFill = True
        '
        'FLaporan_wiup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FLaporan_wiup"
        Me.Text = "Laporan_wiup"
        CType(Me.DataTableWiupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sigDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportViewer3 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DataTableWiupBindingSource As BindingSource
    Friend WithEvents sigDataSet As sigDataSet
    Friend WithEvents DataTableWiupTableAdapter As sigDataSetTableAdapters.DataTableWiupTableAdapter
End Class
