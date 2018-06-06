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
using WebService.Models;

namespace Practicum6
{ 

    public partial class Store : Window
    {
        SOAPService.ServiceClient soap = new SOAPService.ServiceClient();
        List<Purchase> purchases = new List<Purchase>();
        List<ProductModel> products;

        public Store()
        {
            InitializeComponent();
            FillListBox();
        }

        public void FillListBox()
        {
            products = soap.GetAllProducts().ToList();
            var gebruiker = soap.GetUserById(MainWindow.gebruiker.Id);

            winkel.Items.Clear();

            moneyLeft.Content = $"Money Left: ${ gebruiker.Funds - purchases.Sum(x => x.TotalPrice)}";

            products.ToList().ForEach(x => {
                winkel.Items.Add(String.Format("{1}, voorraad: {0} - prijs: {2}", x.CurrentStock - purchases.Where(y => y.ProductId == x.Id).Sum(y => y.Amount), x.Name, x.Price));
            });

            winkel.SelectionChanged += Winkel_SelectionChanged;
            itemBox.SelectionChanged += ItemBox_SelectionChanged;
        }

        private void ItemBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (itemBox.SelectedIndex == -1)
            {
                return;
            }

            var selected = purchases[itemBox.SelectedIndex];

            if (selected.Amount - 1 <= 0)
            {
                purchases.RemoveAt(itemBox.SelectedIndex);
            }
            else
            {
                selected.Amount -= 1;
                selected.TotalPrice = selected.Price * selected.Amount;
            }

            FillListBox();
            RefreshInventory();
        }

        private void RefreshInventory()
        {
            itemBox.Items.Clear();

            purchases.ForEach(x => {
                var item = soap.GetProductById(x.ProductId);
                itemBox.Items.Add($"Product: { item.Name } | Aantal: { x.Amount } | Totaalprijs: ${ x.TotalPrice }");
            });
        }

        private void Winkel_SelectionChanged(object sender, EventArgs e)
        {
            if (winkel.SelectedIndex == -1)
            {
                return;
            }

            var itemId = products[winkel.SelectedIndex].Id;
            var selected = purchases.Find(x => x.ProductId == itemId);

            if (selected == null)
            {
                var p = soap.GetProductById(itemId);
                purchases.Add(new Purchase(p.Id, 1, p.Price));
            }
            else
            {
                if (products[winkel.SelectedIndex].CurrentStock - selected.Amount > 0)
                { 
                    selected.Amount += 1;
                    selected.TotalPrice = selected.Price * selected.Amount;
                }
            }

            FillListBox();
            RefreshInventory();
        }

        private void purchase_Click(object sender, RoutedEventArgs e)
        {
            var productIdList = new List<int>();
            var productAmountList = new List<int>();

            purchases.ForEach(x => {
                productIdList.Add(x.ProductId);
                productAmountList.Add(x.Amount);
            });

            var transaction = soap.CreateNewTransaction(MainWindow.gebruiker.Id, productIdList.ToArray(), productAmountList.ToArray());

            if (transaction != null)
            {
                purchases = new List<Purchase>();
                FillListBox();
                RefreshInventory();
            }
            else
            {
                MessageBox.Show("Order gefaalt! Onvoldoende saldo of onvoldoende voorraad");
            }
        }
    }
}
