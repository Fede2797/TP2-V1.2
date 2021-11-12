
namespace UI.Desktop
{
    partial class ReporteCursos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.CursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rvCursos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tp2_netDataSet1 = new UI.Desktop.tp2_netDataSet1();
            this.planesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planesTableAdapter = new UI.Desktop.tp2_netDataSet1TableAdapters.planesTableAdapter();
            this.cursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tp2_netDataSet = new UI.Desktop.tp2_netDataSet();
            this.cursosJoinedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursosTableAdapter = new UI.Desktop.tp2_netDataSetTableAdapters.cursosTableAdapter();
            this.cursosJoinedTableAdapter = new UI.Desktop.tp2_netDataSetTableAdapters.cursosJoinedTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosJoinedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CursoBindingSource
            // 
            this.CursoBindingSource.DataSource = typeof(Business.Entities.Curso);
            // 
            // rvCursos
            // 
            this.rvCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "CursosSet";
            reportDataSource1.Value = this.CursoBindingSource;
            reportDataSource2.Name = "DataSetCurso";
            reportDataSource2.Value = this.cursosBindingSource;
            reportDataSource3.Name = "DataSetCursosJoined";
            reportDataSource3.Value = this.cursosJoinedBindingSource;
            this.rvCursos.LocalReport.DataSources.Add(reportDataSource1);
            this.rvCursos.LocalReport.DataSources.Add(reportDataSource2);
            this.rvCursos.LocalReport.DataSources.Add(reportDataSource3);
            this.rvCursos.LocalReport.ReportEmbeddedResource = "UI.Desktop.elReporteCursosJoined.rdlc";
            this.rvCursos.Location = new System.Drawing.Point(0, 0);
            this.rvCursos.Name = "rvCursos";
            this.rvCursos.ServerReport.BearerToken = null;
            this.rvCursos.Size = new System.Drawing.Size(1152, 587);
            this.rvCursos.TabIndex = 0;
            this.rvCursos.Load += new System.EventHandler(this.rvCursos_Load);
            // 
            // tp2_netDataSet1
            // 
            this.tp2_netDataSet1.DataSetName = "tp2_netDataSet1";
            this.tp2_netDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // planesBindingSource
            // 
            this.planesBindingSource.DataMember = "planes";
            this.planesBindingSource.DataSource = this.tp2_netDataSet1;
            // 
            // planesTableAdapter
            // 
            this.planesTableAdapter.ClearBeforeFill = true;
            // 
            // cursosBindingSource
            // 
            this.cursosBindingSource.DataMember = "cursos";
            this.cursosBindingSource.DataSource = this.tp2_netDataSet;
            // 
            // tp2_netDataSet
            // 
            this.tp2_netDataSet.DataSetName = "tp2_netDataSet";
            this.tp2_netDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cursosJoinedBindingSource
            // 
            this.cursosJoinedBindingSource.DataMember = "cursosJoined";
            this.cursosJoinedBindingSource.DataSource = this.tp2_netDataSet;
            // 
            // cursosTableAdapter
            // 
            this.cursosTableAdapter.ClearBeforeFill = true;
            // 
            // cursosJoinedTableAdapter
            // 
            this.cursosJoinedTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 587);
            this.Controls.Add(this.rvCursos);
            this.Name = "ReporteCursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Cursos";
            this.Load += new System.EventHandler(this.ReporteCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosJoinedBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvCursos;
        private System.Windows.Forms.BindingSource CursoBindingSource;
        private System.Windows.Forms.BindingSource cursosBindingSource;
        private tp2_netDataSet tp2_netDataSet;
        private tp2_netDataSetTableAdapters.cursosTableAdapter cursosTableAdapter;
        private System.Windows.Forms.BindingSource planesBindingSource;
        private tp2_netDataSet1 tp2_netDataSet1;
        private tp2_netDataSet1TableAdapters.planesTableAdapter planesTableAdapter;
        private System.Windows.Forms.BindingSource cursosJoinedBindingSource;
        private tp2_netDataSetTableAdapters.cursosJoinedTableAdapter cursosJoinedTableAdapter;
    }
}