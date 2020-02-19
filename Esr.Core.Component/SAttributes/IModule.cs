using System.Windows.Controls;

namespace Esr.Core.Component.SAttributes
{
    public interface IModule
    {
        void SetGrid(SGrid sGrid);
        ItemCollection ItemsCollection();
    }
}
