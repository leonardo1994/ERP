using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using Esr.Core.Component.SAttributes;

namespace Esr.Core.Component
{
    // Autor: LEONARDO TEIXEIRA DOS SANTOS SILVA
    // CNPJ: 23.416.009/0001-83
    // 2015 ©LEONARDO TEIXEIRA DOS SANTOS SILVA 43342439831 | Todos os Direitos  Reservados
    public class SPictureBox : SControl<PictureBox>
    {
        #region Atributos do componente
        /// <summary>
        /// Propriedade para abrir explorer do windows
        /// </summary>
        private OpenFileDialog _openFileDialog;
        #endregion
        #region Variáveis utilizadas para controle da camera
        private FilterInfoCollection _videosources;
        private ContextMenuStrip _contextMenuStripFoto;
        private ToolStripMenuItem _toolStripMenuItemCapturarFoto;
        private ToolStripMenuItem _toolStripMenuItemAlterarFoto;
        private ToolStripMenuItem _toolStripMenuItemescolherFoto;
        private ToolStripMenuItem _toolStripMenuItemLimpar;
        private ToolStripMenuItem _toolStripMenuItemSalvar;
        private VideoCaptureDevice _videoSource;
        #endregion

        public SPictureBox()
        {
            InitializeComponent();
            //_videoSource.Start();
        }

        public override object ValueControl
        {
            get { return GetValue(); }
            set { SetValue(value); } }

        private object GetValue()
        {
            var value = SComponent.ImageLocation;
            if (value != string.Empty) return value;
            if (SComponent.Image == null) return value;
            var guid = Guid.NewGuid().ToString();
            value = guid;
            SComponent.Image.Save(guid, System.Drawing.Imaging.ImageFormat.Png);
            return value;
        }

        public override void Clear()
        {
            SComponent.ImageLocation = string.Empty;
            SComponent.Image = null;
            _videoSource?.Stop();
        }

        private void SetValue(object obj)
        {
            SComponent.ImageLocation = (string)obj;
            base.ValueControl = SComponent.ImageLocation;
        }

        private void toolStripMenuItemLimpar_click(object sender, EventArgs e)
        {
            _videoSource?.Stop();
            SComponent.ImageLocation = "";
            SComponent.Image = null;
        }
        private void SPictureBox_DoubleClick(object sender, EventArgs e)
        {
            var result = _openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                SComponent.ImageLocation = _openFileDialog.FileName;
            }
            _videoSource?.Stop();
            ValueControl = GetValue();
        }
        /// <summary>
        /// Captura a foto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemCapturarFoto_Click(object sender, EventArgs e)
        {
            try
            {
                _videoSource.Stop();
                SComponent.ImageLocation = "";
                ValueControl = GetValue();
            }
            catch (Exception)
            {
                //Ignore
            }

        }
        /// <summary>
        /// Habilita a camera novamente, para tirar outra foto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemAlterarFoto_Click(object sender, EventArgs e)
        {
            try
            {
                _videosources = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                _videoSource = new VideoCaptureDevice(_videosources[0].MonikerString);
                _videoSource.NewFrame += (s, f) => SComponent.Image = (Bitmap)f.Frame.Clone();
                _videoSource.Start();
            }
            catch (Exception)
            {
                // Ignore
            }
        }
        /// <summary>
        /// Permite a escolha de uma foto no sistema.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemescolherFoto_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            var result = ofd.ShowDialog();
            if (result != DialogResult.OK) return;
            SComponent.ImageLocation = ofd.FileName;
            _videoSource?.Stop();
            ValueControl = GetValue();
        }
        private void _toolStripMenuItemSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var value = SComponent.ImageLocation;
                var nomeArquivo = value.Split('\\').Last();
                if (value == string.Empty)
                {
                    var guid = Guid.NewGuid().ToString();
                    nomeArquivo = guid;
                }
                SComponent.Image.Save(nomeArquivo, System.Drawing.Imaging.ImageFormat.Png);
                ValueControl = nomeArquivo;
            }
            catch (Exception)
            {
                // Ignore
            }
        }

        private void InitializeComponent()
        {
            _openFileDialog = new OpenFileDialog();
            _contextMenuStripFoto = new ContextMenuStrip(Components);
            _toolStripMenuItemCapturarFoto = new ToolStripMenuItem();
            _toolStripMenuItemAlterarFoto = new ToolStripMenuItem();
            _toolStripMenuItemescolherFoto = new ToolStripMenuItem();
            _toolStripMenuItemLimpar = new ToolStripMenuItem();
            _toolStripMenuItemSalvar = new ToolStripMenuItem();
            // 
            // _openFileDialog
            // 
            _openFileDialog.FileName = "Imagens";
            _openFileDialog.InitialDirectory = "Pictures";
            _openFileDialog.Title = "Selecione a imagem";
            // 
            // _contextMenuStripFoto
            // 
            _contextMenuStripFoto.Items.AddRange(new ToolStripItem[] {
            _toolStripMenuItemCapturarFoto,
            _toolStripMenuItemAlterarFoto,
            _toolStripMenuItemescolherFoto,
            _toolStripMenuItemLimpar,
            _toolStripMenuItemSalvar});
            _contextMenuStripFoto.Name = "_contextMenuStripFoto";
            _contextMenuStripFoto.Size = new Size(156, 114);
            // 
            // _toolStripMenuItemCapturarFoto
            // 
            _toolStripMenuItemCapturarFoto.Name = "_toolStripMenuItemCapturarFoto";
            _toolStripMenuItemCapturarFoto.Size = new Size(155, 22);
            _toolStripMenuItemCapturarFoto.Text = "Capturar";
            _toolStripMenuItemCapturarFoto.Click += toolStripMenuItemCapturarFoto_Click;
            // 
            // _toolStripMenuItemAlterarFoto
            // 
            _toolStripMenuItemAlterarFoto.Name = "_toolStripMenuItemAlterarFoto";
            _toolStripMenuItemAlterarFoto.Size = new Size(155, 22);
            _toolStripMenuItemAlterarFoto.Text = "Alterar";
            _toolStripMenuItemAlterarFoto.Click += toolStripMenuItemAlterarFoto_Click;
            // 
            // _toolStripMenuItemescolherFoto
            // 
            _toolStripMenuItemescolherFoto.Name = "_toolStripMenuItemescolherFoto";
            _toolStripMenuItemescolherFoto.Size = new Size(155, 22);
            _toolStripMenuItemescolherFoto.Text = "Selecionar Foto";
            _toolStripMenuItemescolherFoto.Click += ToolStripMenuItemescolherFoto_Click;
            // 
            // _toolStripMenuItemLimpar
            // 
            _toolStripMenuItemLimpar.Name = "_toolStripMenuItemLimpar";
            _toolStripMenuItemLimpar.Size = new Size(155, 22);
            _toolStripMenuItemLimpar.Text = "Limpar";
            _toolStripMenuItemLimpar.Click += toolStripMenuItemLimpar_click;
            // 
            // _toolStripMenuItemSalvar
            // 
            _toolStripMenuItemSalvar.Name = "_toolStripMenuItemSalvar";
            _toolStripMenuItemSalvar.Size = new Size(155, 22);
            _toolStripMenuItemSalvar.Text = "Salvar";
            _toolStripMenuItemSalvar.Click += _toolStripMenuItemSalvar_Click;
            // 
            // SPictureBox
            // 
            SComponent.BackColor = Color.Blue;
            SComponent.BackgroundImageLayout = ImageLayout.Stretch;
            SComponent.ContextMenuStrip = _contextMenuStripFoto;
            SComponent.SizeMode = PictureBoxSizeMode.Zoom;
            SComponent.DoubleClick += SPictureBox_DoubleClick;
        }
    }

}
