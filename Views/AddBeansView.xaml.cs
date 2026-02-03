using BrewNotes.ViewModels;

namespace BrewNotes.Views;

public partial class AddBeansView : ContentPage
{
	public AddBeansView(AddBeansViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}