using MaitlandCodes.Timesheets.App.ViewModels;
using MaitlandCodes.Timesheets.App.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MaitlandCodes.Timesheets.App
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
