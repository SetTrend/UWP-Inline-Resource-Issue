using Windows.UI.Xaml.Controls;

// Die Elementvorlage "Leere Seite" wird unter https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x407 dokumentiert.

namespace TemplateTest
{
	/// <summary>
	/// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
	/// </summary>
	public sealed partial class MainPage : Page
	{
		internal MyModel[] Values = { new MyModel(1635, "Axel Dahmen"), new MyModel(6254, "Birgit Schmitz") };



		public MainPage() => InitializeComponent();
	}
}
