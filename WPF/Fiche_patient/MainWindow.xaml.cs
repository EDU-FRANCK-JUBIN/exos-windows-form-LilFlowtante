using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Fiche_patient
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_delete_Click(object sender, RoutedEventArgs e)
        {
            textbox_name.Text = "";
            textbox_firstname.Text = "";
            datepicker_birthday.SelectedDate = null;
            textbox_place.Text = "";
            textbox_adress.Text = "";
            textbox_city.Text = "";
            textbox_cp.Text = "";
            textbox_tel_fix.Text = "";
            textbox_tel_portable.Text = "";
            textbox_observation.Text = "";
        }

        private void button_save_Click(object sender, RoutedEventArgs e)
        {
            fiche fc = new fiche();
            fc.firstname_fc.Content = textbox_firstname.Text;
            fc.birthday_fc.Content = datepicker_birthday.SelectedDate.Value.ToString("dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            fc.place_fc.Content = textbox_place.Text;
            fc.adress_fc.Content = textbox_adress.Text;
            fc.city_fc.Content = textbox_city.Text;
            fc.cp_fc.Content = textbox_cp.Text;
            fc.portable_fc.Content = textbox_tel_portable.Text;
            fc.fix_fc.Content = textbox_tel_fix.Text;
            fc.observation_fc.Content = textbox_observation.Text;

            fc.Show();
        }

        private void button_exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
