using VariableGridCollectionView.ViewModel;
namespace VariableGridCollectionView.View;

public partial class SingleItemCollections : ContentPage
{
	public SingleItemCollections(SingleItemCollectionsViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}

