using VariableGridCollectionView.ViewModel;

namespace VariableGridCollectionView.View;

public partial class DessertListings : ContentPage
{
	public DessertListings(DessertViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}