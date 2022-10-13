using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace VariableGridCollectionView.ViewModel;

public partial class MyViewModel : ObservableObject
{
    [ObservableProperty]
    int span = 1;

    public ObservableCollection<int> Numbers { get; } = new() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

    [RelayCommand]
    void ChangeSpan(int byAmount)
    {
        if (Span + byAmount <= 0)   //Prevent span from being <= 0.
        {
            Span = 1;
            return;
        }

        Span += byAmount;
    }
}
