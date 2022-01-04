using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KnittersCompanion.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CounterPage : ContentPage
    {
        public CounterPage()
        {
            InitializeComponent();
        }

        private void Button_IncreaseRow(object sender, EventArgs e)
        {
            string currentText = RowCount.Text;
            int newCount = Convert.ToInt32(currentText) + 1;
            RowCount.Text = Convert.ToString(newCount);
        }

        private void Button_DecreaseRow(object sender, EventArgs e)
        {
            if (Convert.ToInt32(RowCount.Text) == 0)    // If the value is already at 0, we don't want to go negative
            {
                RowCount.Text = RowCount.Text;
            }
            else
            {
                string currentText = RowCount.Text;
                int newCount = Convert.ToInt32(currentText) - 1;
                RowCount.Text = Convert.ToString(newCount);
            }
        }

        private void Button_IncreaseStitch(object sender, EventArgs e)
        {
            string currentText = StitchCount.Text;
            int newCount = Convert.ToInt32(currentText) + 1;
            StitchCount.Text = Convert.ToString(newCount);
        }

        private void Button_DecreaseStitch(object sender, EventArgs e)
        {
            if (Convert.ToInt32(StitchCount.Text) == 0) // If the value is already at 0, we don't want to go negative
            {
                StitchCount.Text = StitchCount.Text;
            }
            else
            {
                string currentText = StitchCount.Text;
                int newCount = Convert.ToInt32(currentText) - 1;
                StitchCount.Text = Convert.ToString(newCount);
            }
        }

    }
}