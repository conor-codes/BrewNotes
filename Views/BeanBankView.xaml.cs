using BrewNotes.ViewModels;

namespace BrewNotes.Views;

public partial class BeanBankView : ContentPage
{
	public BeanBankView(BeanBankViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}