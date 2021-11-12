
namespace UI.Desktop
{
    partial class ReportePlanes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.planesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tp2_netDataSet1 = new UI.Desktop.tp2_netDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.planesTableAdapter = new UI.Desktop.tp2_netDataSet1TableAdapters.planesTableAdapter();
            this.planesJoinedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planesJoinedTableAdapter = new UI.Desktop.tp2_netDataSet1TableAdapters.planesJoinedTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesJoinedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // planesBindingSource
            // 
            this.planesBindingSource.DataMember = "planes";
            this.planesBindingSource.DataSource = this.tp2_netDataSet1;
            // 
            // tp2_netDataSet1
            // 
            this.tp2_netDataSet1.DataSetName = "tp2_netDataSet1";
            this.tp2_netDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetPlanes";
            reportDataSource1.Value = this.planesBindingSource;
            reportDataSource2.Name = "DataSetPlanesJoined";
            reportDataSource2.Value = this.planesJoinedBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UI.Desktop.elReportePlanes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1168, 600);
            this.reportViewer1.TabIndex = 0;
            // 
            // planesTableAdapter
            // 
            this.planesTableAdapter.ClearBeforeFill = true;
            // 
            // planesJoinedBindingSource
            // 
            this.planesJoinedBindingSource.DataMember = "planesJoined";
            this.planesJoinedBindingSource.DataSource = this.tp2_netDataSet1;
            // 
            // planesJoinedTableAdapter
            // 
            this.planesJoinedTableAdapter.ClearBeforeFill = true;
            // 
            // ReportePlanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 600);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportePlanes";
            this.Text = "ReportePlanes";
            this.Load += new System.EventHandler(this.ReportePlanes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesJoinedBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource planesBindingSource;
        private tp2_netDataSet1 tp2_netDataSet1;
        private tp2_netDataSet1TableAdapters.planesTableAdapter planesTableAdapter;
        private System.Windows.Forms.BindingSource planesJoinedBindingSource;
        private tp2_netDataSet1TableAdapters.planesJoinedTableAdapter planesJoinedTableAdapter;
    }
}