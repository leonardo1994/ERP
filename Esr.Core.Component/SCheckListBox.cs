using System.Collections;
using System.Data.Entity;
using System.Windows.Forms;

namespace Esr.Core.Component
{
    public class SCheckListBox : SControl<CheckedListBox>
    {
        public string DisplayMember
        {
            get { return SComponent.DisplayMember; }
            set { SComponent.DisplayMember = value; }
        }

        public string ValueMember { get { return SComponent.ValueMember; } set { SComponent.ValueMember = value; } }

        public override object ValueControl { get { return SComponent.CheckedItems; } }

        public void UpdateDataSource()
        {
            var result = new SReflection().GetListContext(ObjetoApp.TypeController, ObjetoApp.Methods[TypeExecute.SearchAll]);

            SComponent.DataSource = result as IList;
            SComponent.Refresh();
            SComponent.ClearSelected();
        }
    }
}