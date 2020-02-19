using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls.Ribbon;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Esr.Core.Component
{
    /// <summary>
    /// Interaction logic for SMenu.xaml
    /// </summary>
    public partial class SMenuProcess
    {
        public SReflection SReflection { get; set; } = new SReflection();

        private FProcess SForm => (FProcess)Tag;

        public SMenuProcess()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método responsável em adicionar nova tab de acordo com objeto respectivo.
        /// </summary>
        /// <param name="form">Form que será referenciado para exibição do contexto.</param>
        /// <param name="value">Valor que será transportado para form</param>
        /// <param name="sender">Objeto que chamou o comando</param>
        /// <returns>Retorno a tab para objeto da chamado poder encerrar o mesmo.</returns>
        public RibbonTab AddTab(FBase form, object sender)
        {
            // Pego o caminho temporário do usuário no sistema.
            var path = Path.GetTempPath();
            // Savo a imagem temporária. 
            var guid = Guid.NewGuid().ToString();
            form.ImageSource?.Save(path + $"\\{guid}.bmp");

            var context = new[]
            {
                form,
                sender
            };

            // Crio o botão da ribon, passando nome do form, e a imagem.
            var ribbonButton = new RibbonButton
            {
                Label = form.Text ?? form.Name,
                LargeImageSource = new BitmapImage(new Uri(path + $"\\{guid}.bmp")),
                Tag = context
            };
            ribbonButton.Click += RibbonButtonOnClick;

            // Cria um grupo opções, onde conterá o botão.
            var ribbonGroup = new RibbonGroup
            {
                Header = "Opções",
                Items = { ribbonButton }
            };

            var nameModule = form.Module;

            // Finalmente gera a tab que representará o objeto passado no contexto.
            var tab = new RibbonTab
            {
                Header = ribbonButton.Label,
                Items = { ribbonGroup },
                ContextualTabGroupHeader = nameModule
            };

            var tabGroup = new RibbonContextualTabGroup
            {
                Header = nameModule,
                Background = new SolidColorBrush(Color.FromRgb(254, 92, 1)),
                Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0)),
                Visibility = Visibility.Visible,
                Margin = new Thickness(0, -25, 0, 0),
                Width = 150
            };

            Ribbon.ContextualTabGroups.Add(tabGroup);

            // Adiciona a tab no menu atual.
            Ribbon.Items.Add(tab);

            return tab;
        }

        private void RibbonButtonOnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var context = ((RibbonButton)sender).Tag as object[];
                var sForm = context?[0] as FForm;
                if (sForm == null) return;
                var sCombobox = context[1] as SComboBox;
                if (sCombobox == null) return;
                var id = sCombobox.SComponent.SelectedValue ?? 0;
                sForm.SetUkey(new List<int> { (int)(id) });
                sForm.StateForm = sForm.CurrentControl?.Id == 0 || sForm.CurrentControl == null ? StateForm.Inserting : StateForm.Viewing;
                sForm.ShowDialog();
                sCombobox.Refresh();
                if (sCombobox.SComponent.Items.Count <= 0) return;
                if (sForm.CurrentControl != null)
                    sCombobox.SComponent.SelectedValue = sForm.CurrentControl.Id;
                sCombobox.ValueControl = sCombobox.SComponent.SelectedValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível abrir a tela.\n" + ex.Message);
            }
        }
    }
}