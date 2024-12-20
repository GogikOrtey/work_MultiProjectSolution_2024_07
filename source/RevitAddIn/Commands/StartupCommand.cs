using Autodesk.Revit.Attributes;
using Module.ViewModels;
using Module.Views;
using Nice3point.Revit.Toolkit.External;

namespace RevitAddIn.Commands
{
    /// <summary>
    ///     External command entry point invoked from the Revit interface
    /// </summary>
    [UsedImplicitly]
    [Transaction(TransactionMode.Manual)]
    public class StartupCommand : ExternalCommand
    {
        public override void Execute()
        {
            var viewModel = new ModuleViewModel();
            var view = new ModuleView(viewModel);
            view.ShowDialog();
        }
    }
}