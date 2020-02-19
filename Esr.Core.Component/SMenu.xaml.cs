using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls.Ribbon;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;
using Esr.Core.Domain.EnumBase;
using KeyEventArgs = System.Windows.Input.KeyEventArgs;
using MessageBox = System.Windows.Forms.MessageBox;
using System.Collections;

namespace Esr.Core.Component
{
    /// <summary>
    /// Interaction logic for SMenu.xaml
    /// </summary>
    public partial class SMenu
    {
        private FForm SForm => (FForm)Tag;

        public SMenu()
        {
            InitializeComponent();
            Ribbon.KeyDown += RibbonOnKeyDown;
        }

        private void RibbonOnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.LeftCtrl)
            {
                switch (e.Key)
                {
                    case Key.S:
                        if (MenuButtonSave.IsEnabled)
                            MenuButtonSave_OnClick(this, null);
                        return;
                    case Key.E:
                        if (MenuButtonEdit.IsEnabled)
                            MenuButtonEdit_OnClick(this, null);
                        return;
                    case Key.P:
                        if (MenuButtonSearch.IsEnabled)
                            MenuButtonSearch_OnClick(this, null);
                        return;
                    case Key.Delete:
                        if (MenuButtonRemove.IsEnabled)
                            MenuButtonRemove_OnClick(this, null);
                        return;
                    case Key.Back:
                        if (MenuButtonCancel.IsEnabled)
                            MenuButtonCancel_OnClick(this, null);
                        return;
                }
            }

            switch (e.Key)
            {
                case Key.PageDown:
                    if (MenuButtonDown.IsEnabled)
                        MenuButtonDown_OnClick(this, null);
                    return;
                case Key.PageUp:
                    if (MenuButtonUp.IsEnabled)
                        MenuButtonUp_OnClick(this, null);
                    return;
                case Key.Escape:
                    SForm.Close();
                    return;
            }
        }

        public void MenuButtonSearch_OnClick(object sender, RoutedEventArgs e)
        {
            IList selected;
            var formSearch = new FSearch(SForm.Name, TypeSearch.Consult, sender);
            if (formSearch.TreeView.Nodes[0].Nodes.Count > 0)
            {
                formSearch.ShowDialog();
                SForm.ResultSearch = formSearch.DataSource;
                selected = formSearch.GetSelected as IList;
            }
            else
            {
                var fResult = new FResult()
                {
                    GridResult =
                {
                    ObjetoApp = SForm.InvokeMethod,
                    ValueControl = SForm.ObjectControl,
                    FormType = SForm.GetType(),
                    IsSearch = true
                }
                };
                fResult.GridResult.Refresh();
                fResult.ShowDialog();
                SForm.ResultSearch = fResult.GridResult.SComponent.DataSource;
                selected = fResult.GridResult.GetListSelected();
            }

            if (!SForm.Visible && !(sender is SGrid)) return;

            if ((sender is RibbonButton) || ((sender is SGrid) && (sender as SGrid).ScreenSecondary))
            {
                SForm.ObjectControl = selected;

                SForm.RefreshControls();
                if (selected?.Count > 0)
                    SForm.StateForm = StateForm.Viewing;
            }
        }

        public void MenuButtonDown_OnClick(object sender, RoutedEventArgs e)
        {
            SForm.bindingSource.MoveNext();
            SForm.RefreshControls();
            ControlUpDown();
        }

        public void MenuButtonUp_OnClick(object sender, RoutedEventArgs e)
        {
            SForm.bindingSource.MovePrevious();
            SForm.RefreshControls();
            ControlUpDown();
        }

        public void MenuButtonNew_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                SForm.bindingSource.AddNew();
                SForm.StateForm = StateForm.Inserting;
                SForm.RefreshControls();
            }
            catch (Exception)
            {
                //
            }
        }

        public void MenuButtonSave_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!SForm.Salvar()) return;
                //Removido SForm.IsDialog Verificação por este para não fechar a tela ao salvar apenas se estiver forçado na Variável
                //ClosedAfterSave 
                if (SForm.ClosedAfterSave)
                    SForm.Hide();
                SForm.StateForm = StateForm.Viewing;
                SForm.RefreshControls();
            }
            catch (Exception)
            {
                //
            }
        }

        public void MenuButtonEdit_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (SForm.CurrentControl.Integration)
                {
                    MessageBox.Show(@"Este documento é proveniente de integração e não pode ser alterado", @"ESR SOFTWARES");
                }
                else
                {
                    SForm.StateForm = StateForm.Editing;
                }
            }
            catch (Exception)
            {
                // Ignore
            }
        }

        public void MenuButtonRemove_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (SForm.CurrentControl.Integration)
                {
                    MessageBox.Show(@"Este documento é proveniente de integração e não pode ser excluído", @"ESR SOFTWARES");
                }
                else
                {
                    if (!SForm.Excluir()) return;
                    SForm.bindingSource.RemoveCurrent();
                    SForm.StateForm = (SForm.bindingSource.Count > 0) ? StateForm.Viewing : StateForm.Waiting;

                    SForm.RefreshControls();
                }
            }
            catch (Exception)
            {
                //
            }
        }

        public void MenuButtonCancel_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var resultMessage = MessageBox.Show(@"Deseja realmente cancelar ?", @"Cancelar Operação",
                    MessageBoxButtons.YesNo);
                if (resultMessage != DialogResult.Yes) return;
                switch (SForm.StateForm)
                {
                    case StateForm.Inserting:
                        if (SForm.CurrentControl != null && SForm.CurrentControl.Id != 0)
                            SForm.StateForm = StateForm.Viewing;
                        else if (SForm.bindingSource.Count > 0)
                        {
                            SForm.bindingSource.RemoveCurrent();
                            SForm.StateForm = SForm.bindingSource.Count == 0 ? StateForm.Waiting : StateForm.Viewing;
                        }
                        else
                        {
                            SForm.StateForm = StateForm.Waiting;
                        }
                        SForm.RefreshControls();
                        break;
                    case StateForm.Editing:
                        SForm.CurrentControl = (IEntityBase)SForm.SReflection.FindIdContext(SForm.InvokeMethod.TypeController, SForm.InvokeMethod.Methods[TypeExecute.FindId], SForm.CurrentControl?.Id);
                        SForm.RefreshControls();
                        SForm.StateForm = StateForm.Viewing;
                        break;
                    case StateForm.Viewing:
                        SForm.bindingSource.RemoveCurrent();
                        if (SForm.bindingSource.Count >= 1)
                        {
                            MenuButtonUp_OnClick(sender, e);
                            SForm.StateForm = StateForm.Viewing;
                            SForm.RefreshControls();
                            return;
                        }
                        SForm.StateForm = StateForm.Waiting;
                        SForm.RefreshControls();
                        break;
                    case StateForm.Waiting:
                        break;
                    case StateForm.NoConfirmed:
                        SForm.Excluir();
                        SForm.StateForm = StateForm.Waiting;
                        break;
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }

        public void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var item = sender as RibbonButton;
                if (item == null) return;

                var lista = new List<int>() { SForm.CurrentControl.Id };

                var dataSources = item.Tag as Dictionary<string, SInvokeMethod>;
                var data = new Dictionary<string, object>();

                if (dataSources != null)
                    foreach (var dataSource in dataSources)
                    {
                        var invokeMethod = dataSource.Value;
                        if (invokeMethod == null) return;
                        var expression = SForm.GetExpressionItemsSelected(lista as List<int>);
                        var returnMethod = SForm.SReflection.GetListContext(invokeMethod.TypeClass, invokeMethod.NameMethod, expression);
                        data.Add(dataSource.Key, returnMethod);
                    }

                new FormVisualisador(
                    item.ToolTip.ToString(),
                    data).ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível executar o relatório \n" + ex.Message);
            }
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

        private static void RibbonButtonOnClick(object sender, RoutedEventArgs routedEventArgs)
        {
            try
            {
                var context = ((RibbonButton)sender).Tag as object[];
                var sForm = context?[0] as FBase;
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

        #region Métodos de controle SMenu
        public void ControlMenu(StateForm stateForm)
        {
            try
            {
                switch (stateForm)
                {
                    case StateForm.Inserting:
                        NewState();
                        break;
                    case StateForm.Editing:
                        EditState();
                        break;
                    case StateForm.Viewing:
                        ViewState();
                        break;
                    case StateForm.Waiting:
                        WaitState();
                        break;
                    case StateForm.NoConfirmed:
                        NewState();
                        break;
                }
            }
            catch (Exception)
            {
                // ignored
            }
            if (GlobalUser.User == null) return;
            foreach (var groupUser in GlobalUser.User.GroupUsers)
                foreach (
                    var groupPermission in
                        groupUser
                        .GroupAccess
                        .GroupPermissions
                        .Where(
                            c =>
                                c.Permission.TypeComponent == TypeComponent.Screen &&
                                c.Permission.NamePermission == SForm.Name))
                {
                    if (MenuButtonNew.IsEnabled)
                        MenuButtonNew.Visibility = (groupPermission.Permission.Insert
                            ? Visibility.Visible
                            : Visibility.Collapsed);
                    if (MenuButtonEdit.IsEnabled)
                        MenuButtonEdit.Visibility = (groupPermission.Permission.Update ? Visibility.Visible : Visibility.Collapsed);
                    if (MenuButtonRemove.IsEnabled)
                        MenuButtonRemove.Visibility = (groupPermission.Permission.Delete ? Visibility.Visible : Visibility.Collapsed);
                    MenuButtonSave.Visibility = ((groupPermission.Permission.Insert || groupPermission.Permission.Update) ? Visibility.Visible : Visibility.Collapsed);
                    if (MenuButtonSave.IsEnabled) continue;
                    SForm.ControlReadOnly(StateForm.Waiting);
                }
        }
        public void NewState()
        {
            try
            {
                MenuButtonNew.IsEnabled = false;
                MenuButtonSave.IsEnabled = true;
                MenuButtonEdit.IsEnabled = false;
                MenuButtonRemove.IsEnabled = false;
                MenuButtonCancel.IsEnabled = true;
                MenuButtonSearch.IsEnabled = false;
                MenuButtonDown.IsEnabled = false;
                MenuButtonUp.IsEnabled = false;

                SForm.PropertyDependecyUkey?.SetValue(SForm.CurrentControl, SForm.DependecyUkey);
                var fieldKey = SForm.GetListControls().FirstOrDefault(c => c.Name == SForm.PropertyDependecyUkey?.Name);
                if (fieldKey == null) return;
                fieldKey.Disable = false;
                ((SComboBox)fieldKey).SComponent.Enabled = false;
                ((SComboBox)fieldKey).DefaultValue = true;
                ((SComboBox)fieldKey).StandardValue = SForm.DependecyUkey;
            }
            catch (Exception)
            {
                // ignored
            }
        }
        public void EditState()
        {
            // Recarrega objeto na tela.
            var id = SForm.CurrentControl.Id;
            var method = SForm.InvokeMethod.Methods.FirstOrDefault(c => c.Key == TypeExecute.FindId).Value;
            SForm.CurrentControl = SForm.SReflection.GetContext(SForm.InvokeMethod.TypeController, method, id);

            try
            {
                MenuButtonNew.IsEnabled = false;
                MenuButtonSave.IsEnabled = true;
                MenuButtonEdit.IsEnabled = false;
                MenuButtonRemove.IsEnabled = false;
                MenuButtonCancel.IsEnabled = true;
                MenuButtonSearch.IsEnabled = false;
                MenuButtonDown.IsEnabled = false;
                MenuButtonUp.IsEnabled = false;
            }
            catch (Exception)
            {
                // ignored
            }
        }
        public void ViewState()
        {
            try
            {
                MenuButtonNew.IsEnabled = true;
                MenuButtonSave.IsEnabled = false;
                MenuButtonEdit.IsEnabled = true;
                MenuButtonRemove.IsEnabled = true;
                MenuButtonCancel.IsEnabled = true;
                if (SForm.PropertyDependecyUkey != null)
                    MenuButtonSearch.IsEnabled = false;
                else
                    MenuButtonSearch.IsEnabled = true;
                ControlUpDown();
            }
            catch (Exception)
            {
                // ignored
            }
        }
        public void WaitState()
        {
            try
            {
                MenuButtonNew.IsEnabled = true;
                MenuButtonSave.IsEnabled = false;
                MenuButtonEdit.IsEnabled = false;
                MenuButtonRemove.IsEnabled = false;
                MenuButtonCancel.IsEnabled = false;
                if (SForm.PropertyDependecyUkey != null)
                    MenuButtonSearch.IsEnabled = false;
                else
                    MenuButtonSearch.IsEnabled = true;
                ControlUpDown();
            }
            catch (Exception)
            {
                //Igonre
            }
        }
        public void ControlUpDown()
        {
            MenuButtonDown.IsEnabled = true;
            MenuButtonUp.IsEnabled = true;

            if (SForm.bindingSource.Count == 0 || SForm.bindingSource.Count == 1)
            {
                MenuButtonDown.IsEnabled = false;
                MenuButtonUp.IsEnabled = false;
                return;
            }

            if (SForm.bindingSource.Count == SForm.bindingSource.IndexOf(SForm.CurrentControl) + 1)
            {
                MenuButtonDown.IsEnabled = false;
                return;
            }
            MenuButtonUp.IsEnabled = true;

            if (SForm.bindingSource.IndexOf(SForm.CurrentControl) == 0)
            {
                MenuButtonUp.IsEnabled = false;
                return;
            }
            MenuButtonDown.IsEnabled = true;
        }
        #endregion
    }
}