using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Esr.Core.Component
{
    public class SButton : SControl<Button>
    {
        public override ImageLayout BackgroundImageLayout { get; set; } = ImageLayout.Stretch;

        public ContentAlignment ImageAlignment
        {
            get { return SComponent.ImageAlign; }
            set { SComponent.ImageAlign = value; }
        }

        public ContentAlignment TextAlignment
        {
            get { return SComponent.TextAlign; }
            set { SComponent.TextAlign = value; }
        }

        private bool _openFileDialog;

        /// <summary>
        /// Propriedade para identificar se botão servirá para selecionar um arquivo.
        /// </summary>
        public bool OpenFileDialog { get { return _openFileDialog; } set { _openFileDialog = value;
            DesignerButtonFileDialog();
        } }

        /// <summary>
        /// Nome da pasta que será armazenada.
        /// </summary>
        public string NameFolder { get; set; }

        /// <summary>
        /// Nome do objeto que será retornado o caminho do arquivo.
        /// </summary>
        public IComponent ObjectName { get; set; }

        public SButton()
        {
            SComponent.Click += OpenFileDialog_Click;
        }

        private void OpenFileDialog_Click(object sender, EventArgs eventArgs)
        {
            if (!OpenFileDialog) return;
            var openFileDialog = new OpenFileDialog
            {
                CheckFileExists = true,
                AddExtension = true
            };

            //openFileDialog.Filter = "PDF files (*.pdf)|*.pdf";

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            var strAppDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
            if (strAppDir == null) return;
            strAppDir = strAppDir.Replace("\\bin\\Debug", "\\" + GetSForm().Module + "\\" + GetSForm().Text + "\\").Replace("file:\\", "");
            var strCaminhoFinal = strAppDir + NameFolder;
            var nomeArquivo = openFileDialog.SafeFileName;
            var caminhoArquivo = openFileDialog.FileName;
            var strCaminhoArquivo = strCaminhoFinal + "\\" + nomeArquivo;

            //Se o diretório não existir...
            if (!Directory.Exists(strCaminhoFinal))
            {
                //Criamos um com o nome folder
                Directory.CreateDirectory(strCaminhoFinal);
                File.Copy(caminhoArquivo, strCaminhoArquivo);
            }
            else
            {
                File.Delete(strCaminhoArquivo);
                File.Copy(caminhoArquivo, strCaminhoArquivo);
            }

            ObjectName.ValueControl = strCaminhoArquivo;
        }

        public override string Caption
        {
            get { return SComponent.Text; }
            set { SComponent.Text = value; }
        }

        public override Image BackgroundImage
        {
            get { return SComponent.Image; }
            set { SComponent.Image = value; }
        }

        protected override void InitLayout()
        {
            base.InitLayout();
            SComponent.BackgroundImageLayout = BackgroundImageLayout;
            SComponent.FlatAppearance.BorderSize = 0;
            SComponent.FlatStyle = FlatStyle.Flat;
            FlowLayoutPanel.AutoSize = false;
            FlowLayoutPanel.Width = 0;
            FlowLayoutPanel.Height = 0;
        }

        private void DesignerButtonFileDialog()
        {
            if (OpenFileDialog)
            {
                BackgroundImage = Properties.Resources.folder_file;
                BackgroundImageLayout = ImageLayout.Stretch;
                ImageAlignment = ContentAlignment.MiddleRight;
                Caption = "Selecione o Arquivo";
                CaptionAlign = CaptionAlign.Top;
                ComponentBackColor = Color.White;
                Cursor = Cursors.Hand;
                Font = new Font("Segoe UI", 12F);
                Size = new Size(187, 34);
                TextAlignment = ContentAlignment.MiddleLeft;
            }
            else
            {
                BackgroundImage = null;
                Caption = "";
                Cursor = DefaultCursor;
            }
        }
    }
}
