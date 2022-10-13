using VariableGridCollectionView.ViewModel;
namespace VariableGridCollectionView.View;

public partial class MainPage : ContentPage
{
	public MainPage(MyViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}

