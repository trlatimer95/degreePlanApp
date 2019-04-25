using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace degreePlanApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddTermPage : ContentPage
	{
		public AddTermPage ()
		{
			InitializeComponent ();
		}

        private void Save_Activated(object sender, EventArgs e)
        {
            Term term = new Term()
            {
                Title = Title.ToString(),


            };
        }
    }
}