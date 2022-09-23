using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Bussola {
    public partial class MainPage : ContentPage {
        public MainPage()
        {
            InitializeComponent();

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (!DesignMode.IsDesignModeEnabled)
                ((BussolaViewModel)BindingContext).StartCommand.Execute(null);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            if (!DesignMode.IsDesignModeEnabled)
                ((BussolaViewModel)BindingContext).StopCommand.Execute(null);
        }
    }
}
