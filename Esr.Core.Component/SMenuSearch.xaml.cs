using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows;
using Esr.Core.Repository;
using System.Data.SqlClient;
using Microsoft.CSharp;
using TypeFilter = Esr.Core.Domain.Queries.TypeFilter;
using System.IO;
using System.Windows.Media.Imaging;

namespace Esr.Core.Component
{
    /// <summary>
    /// Interaction logic for SMenu.xaml
    /// </summary>
    public partial class SMenuSearch
    {
        private readonly DbContextConnection _connection = new DbContextConnection();
        public SReflection SReflection { get; set; } = new SReflection();

        private FSearch SForm => (FSearch)Tag;

        public SMenuSearch()
        {
            InitializeComponent();
            Loaded += SMenuSearch_Loaded;
        }

        private void SMenuSearch_Loaded(object sender, RoutedEventArgs e)
        {
            // Pego o caminho temporário do usuário no sistema.
            var path = Path.GetTempPath();
            // Savo a imagem temporária. 
            var guid = Guid.NewGuid().ToString();

            if (SForm.TypeSearch == TypeSearch.Consult)
            {
                Properties.Resources.icon_search_40.Save(path + $"\\{guid}.bmp");
            }
            else
            {
                Properties.Resources.icon_printer_40.Save(path + $"\\{guid}.bmp");
            }

            MenuButtonSearch.LargeImageSource = new BitmapImage(new Uri(path + $"\\{guid}.bmp"));
        }

        private void MenuButtonSearch_OnClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(SForm.CurrentQuery))
            {
                MessageBox.Show((SForm.TypeSearch == TypeSearch.Consult ? "Nenhuma consulta selecionada" : "Nenhum relatório selecionado"), "ESR SOFTWARES");
                return;
            };
            var query = SForm.CurrentQuery;

            using (var conn = new SqlConnection())
            {
                conn.ConnectionString = _connection.Database.Connection.ConnectionString;
                var command = new SqlCommand(query, conn);
                SForm.RunSearch();

                try
                {
                    conn.Open();

                    command.CommandText = SForm.CurrentQuery;

                    using (var reader = command.ExecuteReader())
                    {
                        var dt = new DataTable();
                        dt.Load(reader);

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Nenhum resultado encontrado");

                        }
                        else
                        {
                            if (SForm.TypeSearch == TypeSearch.Consult)
                            {
                                if ((SForm.Tag as SGrid)?.Name == "GridMain")
                                {
                                    SForm.DataSource = dt;
                                    SForm.Hide();
                                }
                                else
                                {
                                    var fResult = new FResult();
                                    fResult.GridResult.FormType = (SForm.Tag as SGrid)?.FormType;
                                    fResult.GridResult.ObjetoApp = (SForm.Tag as SGrid)?.ObjetoApp;
                                    fResult.SetDataSource(dt);
                                    fResult.GridResult.SComponent.Refresh();
                                    fResult.ShowDialog();

                                    SForm.DataSource = fResult.GridResult.SComponent.DataSource;
                                    SForm.GetSelected = fResult.GridResult.GetListSelected();
                                    SForm.Hide();
                                }
                            }
                            else
                            {
                                var fReport = new FormVisualisador(SForm.Report.ReportName, new Dictionary<string, object>()
                            {
                                { SForm.Report.Code, dt }
                            }).ShowDialog();
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public interface IConsoleWriter
        {
            void WriteToConsole(string message);
        }

        const string code = @"using System;
                                  using System.Windows.Forms;
                                  using Esr.Core.Component;
                            namespace LoadXmlTestConsole
                            {
                                public class ConsoleWriter : SForm
                                {
                                    public ConsoleWriter()
                                    {
                                        
                                    }
                                }
                            }";

        public static bool CompileExecutable(string sourceName)
        {
            try
            {
                CodeDomProvider codeCompiler =
                    new CSharpCodeProvider(new Dictionary<string, string> { { "CompilerVersion", "v4.0" } });
                // Create the optional compiler parameters
                CompilerParameters compilerParameters = new CompilerParameters
                {
                    GenerateExecutable = false,
                    GenerateInMemory = true,
                    WarningLevel = 3,
                    TreatWarningsAsErrors = false,
                    CompilerOptions = "/optimize"
                };

                compilerParameters.ReferencedAssemblies.Add(
                    @"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.1\System.dll");
                compilerParameters.ReferencedAssemblies.Add(
                    @"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.1\System.Windows.Forms.dll");
                compilerParameters.ReferencedAssemblies.Add(
                    @"C:\Users\Leo\Desktop\Projeto ESR\ESR Softwares\Esr.Core.Component\bin\Debug\Esr.Core.Component.dll");

                // Compile the string containing the code, using the provided set of parameters
                CompilerResults compilerResults = codeCompiler.CompileAssemblyFromSource(compilerParameters,
                                                                                            code);
                //Display any compiler errors in the console window
                if (compilerResults.Errors.HasErrors)
                    foreach (string line in compilerResults.Output)
                    {
                        MessageBox.Show(line);
                    }

                // Get the required type out of the assembly
                Type consoleWriterType =
                    compilerResults.CompiledAssembly.GetTypes().Single();

                // create an instance of the type
                var instance = (FForm)Activator.CreateInstance(consoleWriterType);
                instance.ShowDialog();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}