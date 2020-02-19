using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Esr.Core.Component
{
    // Autor: LEONARDO TEIXEIRA DOS SANTOS SILVA
    // CNPJ: 23.416.009/0001-83
    // 2015 ©LEONARDO TEIXEIRA DOS SANTOS SILVA 43342439831 | Todos os Direitos  Reservados
    public partial class FormVisualisador : Form
    {
        public FormVisualisador(string path, Dictionary<string, object> dataSource, Dictionary<string, object> reportParameters = null)
        {
            InitializeComponent();

            visualizadorReportViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            visualizadorReportViewer.LocalReport.ReportPath = Directory.GetCurrentDirectory() + "/Reports/" + path;

            // dataSources.
            try
            {
                foreach (var reportDataSource in dataSource.Select(o => new Microsoft.Reporting.WinForms.ReportDataSource(o.Key, o.Value)))
                {
                    visualizadorReportViewer.LocalReport.DataSources.Add(reportDataSource);
                }
            }
            catch (Exception)
            {
                // ignored
            }

            // reportParameters.
            if (reportParameters != null)
            {
                var reportParameterCollection = reportParameters.Select(parameter => new Microsoft.Reporting.WinForms.ReportParameter(parameter.Key, parameter.Value.ToString())).ToList();

                visualizadorReportViewer.LocalReport.SetParameters(reportParameterCollection);
            }
            visualizadorReportViewer.RefreshReport();
            visualizadorReportViewer.Refresh();
        }

        private void FormVisualisador_Load(object sender, EventArgs e)
        {

        }
    }
}
