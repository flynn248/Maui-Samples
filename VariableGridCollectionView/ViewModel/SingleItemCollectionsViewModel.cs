using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace VariableGridCollectionView.ViewModel;

public partial class SingleItemCollectionsViewModel : BaseViewModel
{
    public ObservableCollection<int> Numbers { get; } = new() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
}
