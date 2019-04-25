using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace degreePlanApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void AddTermButton_Activated(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddTermPage());
        }
    }
}
