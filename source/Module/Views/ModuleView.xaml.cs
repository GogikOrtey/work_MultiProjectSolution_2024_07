using Module.ViewModels;

namespace Module.Views
{
    public sealed partial class ModuleView
    {
        public ModuleView(ModuleViewModel viewModel)
        {
            DataContext = viewModel;
            InitializeComponent();
        }
    }
}