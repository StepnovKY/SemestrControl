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

namespace SemestrControl.Pages
{
    /// <summary>
    /// Логика взаимодействия для StartTestPage.xaml
    /// </summary>
    public partial class StartTestPage : Page
    {
        public string LastName => txtLastName.Text;
        public string FirstName => txtFirstName.Text;

        public StartTestPage()
        {
            InitializeComponent();
        }
    }
}
