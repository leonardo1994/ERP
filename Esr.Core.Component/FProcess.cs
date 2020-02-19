using Esr.Core.Domain.ClassBase;
using System.Collections;
using System.Linq;
using System.Windows.Controls.Ribbon;
using System.Windows.Forms;

namespace Esr.Core.Component
{
    public partial class FProcess : FBase
    {

        public override object ObjectControl
        {
            get { return bindingSource?.DataSource; }
            set
            {
                if (value == null) return;
                if (((IList)value).Count == 0)
                {
                    try
                    {
                        bindingSource.DataSource = value;
                        bindingSource?.AddNew();
                    }
                    catch
                    {
                        return;
                    }

                    return;
                }
                bindingSource.DataSource = value;
            }
        }

        public override IEntityBase CurrentControl
        {
            get
            {
                // Retorna o registro atual posicionado.
                return bindingSource?.Current as IEntityBase;
            }
            set
            {
                // Quando adicionado registro, e removido o atual, sabendo que o mesmo não pode ser substituido.
                bindingSource.RemoveCurrent();
                // Passado um novo para contexto.
                bindingSource.Add(value);
                // Procuro o index no qual o novo registro foi adicionado.
                var indexOf = bindingSource.IndexOf(value);
                // Pesquisa a posição que se encontra e posiciono novamente.
                for (var i = 0; i < indexOf; i++)
                {
                    bindingSource.MoveNext();
                }
            }
        }

        public FProcess()
        {
            try
            {
                InitializeComponent();
                sMenuProcess1.Tag = this;
                sMenuProcess1.ButtonActive.Click += ButtonActive_Click;
                sMenuProcess1.ButtonCancel.Click += ButtonCancel_Click;
            }
            catch (System.Exception)
            {

            }
        }

        public virtual void ButtonActive_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (!IsValid()) return;

            var nameMethod = InvokeMethod.Methods.FirstOrDefault(c => c.Key == TypeExecute.InsertOrUpdate).Value;
            if (string.IsNullOrEmpty(nameMethod))
            {
                MessageBox.Show("Método InsertOrUpdate não configurado\nController: " + InvokeMethod.TypeController.Name,
                        "ESR Softwares", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
                
            var obj = CurrentControl;

            // Via reflexão executa método crud, passando o registro atual.
            if (!SReflection.ExecuteContext(InvokeMethod.TypeController, nameMethod, obj))
            {
                MessageBox.Show("Não foi possível executar a função.",
                        "ESR Softwares", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                MessageBox.Show("Processo concluído.",
                        "ESR Softwares", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public virtual void ButtonCancel_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Responsável em passar para menu, qual form será acrescentado na aba
        /// </summary>
        /// <param name="form">Form que será referenciado</param>
        /// <param name="sender">Component que solicitou a adição da aba.</param>
        /// <returns>Retorna a aba adicionada, para proprio component que a chamou finalize sua solicitação, quando necessário.</returns>
        public override RibbonTab AddTab(FBase form, object sender)
        {
            return sMenuProcess1.AddTab(form, sender);
        }

        /// <summary>
        /// Remove a aba adicionada.
        /// </summary>
        /// <param name="ribbonTab">Recebe como parametro a aba que deseja remover.</param>
        public override void RemoveAba(RibbonTab ribbonTab)
        {
            if (ribbonTab != null)
                sMenuProcess1.Ribbon.Items.Remove(ribbonTab);
        }
    }
}