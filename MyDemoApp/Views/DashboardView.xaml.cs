using MyDemoApp.ViewModels;
namespace MyDemoApp.Views;

public partial class DashboardView : ContentPage
{
	private DashboardViewModel _viewModel;
	public DashboardView(DashboardViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
		_viewModel = viewModel;
	}
}