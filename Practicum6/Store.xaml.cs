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
using WcfService;

namespace Practicum6
{ 

    public partial class Store : Window
    {
        SOAPService.ServiceClient soap = new SOAPService.ServiceClient();

        public Store()
        {
            InitializeComponent();
            FillListBox();
        }

        public void FillListBox()
        {
            var alles = soap.GetAllProducts();
            var gebruiker = soap.GetUserById(MainWindow.gebruiker.Id);

            winkel.Items.Clear();

            moneyLeft.Content = $"Money Left: ${ gebruiker.Funds }";

            alles.ToList().ForEach(x => {
                winkel.Items.Add(String.Format("{1}, voorraad: {0} - prijs: {2}", x.CurrentStock, x.Name, x.Price));
            });
        }
    }
}
