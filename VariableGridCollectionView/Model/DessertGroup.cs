using AndroidX.Annotations;

namespace VariableGridCollectionView.Model;

public class DessertGroup : List<Dessert>
{
    public string Name { get; set; }

    public DessertGroup(string name, List<Dessert> models) : base(models)
    {
        Name = name;
    }
}
