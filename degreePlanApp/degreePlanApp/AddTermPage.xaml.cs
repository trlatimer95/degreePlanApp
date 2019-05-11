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
                Name = name.Text,
                StartDate = start.Date.ToShortDateString(),
                EndDate = end.Date.ToShortDateString(),
                FullDate = start.Date.ToShortDateString() + " - " + end.Date.ToShortDateString()
            };

            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                conn.CreateTable<Term>();
                var numberOfRows = conn.Insert(term);

                if (numberOfRows > 0)
                {
                    DisplayAlert("Success", "Term inserted", "Okay");
                }
            }
        }
    }
}