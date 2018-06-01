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

            winkel.Items.Clear();
            foreach (var pr in alles)
            {
                winkel.Items.Add(String.Format("{1}, voorraad: {0} - prijs: {2}", pr.CurrentStock, pr.Name, pr.Price));
            }
        }
    }
}
