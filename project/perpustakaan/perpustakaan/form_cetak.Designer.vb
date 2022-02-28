<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_cetak
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
        Me.report_peminjamanku = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'report_peminjamanku
        '
        Me.report_peminjamanku.ActiveViewIndex = -1
        Me.report_peminjamanku.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.report_peminjamanku.Cursor = System.Windows.Forms.Cursors.Default
        Me.report_peminjamanku.Dock = System.Windows.Forms.DockStyle.Fill
        Me.report_peminjamanku.Location = New System.Drawing.Point(0, 0)
        Me.report_peminjamanku.Name = "report_peminjamanku"
        Me.report_peminjamanku.Size = New System.Drawing.Size(1370, 749)
        Me.report_peminjamanku.TabIndex = 0
        '
        'Form_cetak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.report_peminjamanku)
        Me.Name = "Form_cetak"
        Me.Text = "Form_cetak"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents report_peminjamanku As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
