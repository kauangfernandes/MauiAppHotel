using MauiAppHotel.Helpers;
namespace MauiAppHotel
{
    public partial class App : Application
    {
        static SQLiteDataBaseHelper database;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);
            window.Width = 400;
            window.Height = 700;

            return window;
        }

        public static SQLiteDataBaseHelper Database
        {
            get
            {
                if (database == null)
                {
                    string path = Path.Combine(
                        Environment.GetFolderPath(
                            Environment.SpecialFolder.LocalApplicationData
                        ), "slqite.db3"
                    );

                    database = new SQLiteDataBaseHelper(path);
                }

                return database;
            }
        }
    }
}
