using OpenWeatherAPI;
using System.Windows;
using WeatherApp.ViewModels;
using System.Reflection.Emit;

namespace WeatherApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TemperatureViewModel vm;
        public MainWindow()
        {
            InitializeComponent();

            /// TODO : Faire les appels de configuration ici ainsi que l'initialisation
            ApiHelper.InitializeClient();
            ITemperatureService ItempService = new OpenWeatherService(AppConfiguration.GetValue("apiKey"));
            vm = new TemperatureViewModel();
            vm.SetTemperatureService(ItempService);

            DataContext = vm;

        }
    }
}
