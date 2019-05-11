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

        protected override void OnAppearing()
        {
            base.OnAppearing();

            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                conn.CreateTable<Term>();

                var books = conn.Table<Term>().ToList();
                termListView.ItemsSource = books;
            }
        }

        private void AddTermButton_Activated(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddTermPage());
        }

        private void EditTermButton_Activated(object sender, EventArgs e)
        {
            if (termListView.SelectedItem != null)
            {
                Navigation.PushAsync(new EditTermPage());
            }
        }

        private void DeleteTermButton_Activated(object sender, EventArgs e)
        {
            if (termListView.SelectedItem != null)
            {
                // TODO Add delete functionality
                DisplayAlert("Delete", "Are you sure you want to delete this term?", "No");
            }
        }

        private void ToolbarItem_Activated(object sender, EventArgs e)
        {

        }

        private void ToolbarItem_Activated_1(object sender, EventArgs e)
        {

        }
    }
}
