using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace VariableGridCollectionView.ViewModel;

public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    int span = 1;

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
