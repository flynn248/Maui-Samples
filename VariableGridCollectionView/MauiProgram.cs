using VariableGridCollectionView.Model;
using VariableGridCollectionView.View;
using VariableGridCollectionView.ViewModel;

namespace VariableGridCollectionView;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<SingleItemCollections>();
		builder.Services.AddSingleton<SingleItemCollectionsViewModel>();

		builder.Services.AddSingleton<DessertListings>();
		builder.Services.AddSingleton<DessertViewModel>();

		builder.Services.AddSingleton<Dessert>();
		builder.Services.AddSingleton<DessertGroup>();
		return builder.Build();
	}
}
