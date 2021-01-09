using MaitlandCodes.Timesheets.App.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MaitlandCodes.Timesheets.App.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}