using CommunityToolkit.Mvvm.Input;
using VariableGridCollectionView.Model;

namespace VariableGridCollectionView.ViewModel;

public class DessertViewModel : BaseViewModel
{
    public List<DessertGroup> Desserts { get; private set; } = new()
    {
        new DessertGroup("Pie", new List<Dessert>
        {
          new Dessert
          {
              Name = "Red Velvet"
          },
          new Dessert
          {
              Name = "French"
          }
        }),
        new DessertGroup("Ice Cream", new List<Dessert>
        {
            new Dessert
            {
                Name = "Dark Chocolate"
            },
            new Dessert
            {
                Name = "Superman"
            },
            new Dessert
            {
                Name = "Blue Moon"
            }
        })
    };
}
