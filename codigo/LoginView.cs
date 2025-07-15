using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfAppHamburgueseria.ViewModels;

namespace WpfAppHamburgueseria
{
    namespace WpfAppHamburgueseria.Views
    {
        public partial class LoginView : Window
        {
            public LoginView()
            {
                InitializeComponent();
            }

            private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
            {
                if (DataContext is LoginViewModel vm)
                {
                    vm.Contraseña = ((PasswordBox)sender).Password;
                }
            }
        }
    }
}