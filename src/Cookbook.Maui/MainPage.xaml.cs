using Cookbook.Infrastructure.DataAccess;
using Microsoft.Maui.Controls;

namespace Cookbook.Maui
{
    public partial class MainPage : ContentPage
    {
        public MainPage(IDatabaseInitializer databaseInitializer)
        {
            InitializeComponent();
            databaseInitializer.Initialize();
        }
    }
}
