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
using System.Windows.Shapes;

namespace gam
{
    /// <summary>
    /// Логика взаимодействия для CRUD.xaml
    /// </summary>
    public partial class CRUD : Window
    {
        public CRUD(int x)
        {
            InitializeComponent();
            switch (x)
            {
                case 1:
                    AddData addData = new AddData();
                    MainFrame.Content = addData;
                    break;
                case 2:
                    DeletData deletData = new DeletData();
                    MainFrame.Content = deletData;
                    break;
                case 3:
                    UpdData UpdData = new UpdData();
                    MainFrame.Content = UpdData;
                    break;
            }
        }

        private void MainFrame_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }
    }
}
