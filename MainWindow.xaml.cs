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

namespace Prog_122_L5_Notes_Week3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Creates and instance of an amazon order
            AmazonOrder order1 = new AmazonOrder("12345", "Charles Milender", .1m);

            //add 3 products
            //listName.Add(Prodcut)
            order1.Products.Add(new Product("Eternal Sunshine of a Spotless Mind", "Mechele Gondry", 10, 14.00m));
            order1.Products.Add(new Product("El Dordado", "Howard Hawks", 10, 17.00m));
            order1.Products.Add(new Product("Robcop", "Paul Verrhoven", 10, 13.00m));
            rtbDisplay.Text = "";
            foreach (Product product in order1.Products)
            {
                rtbDisplay.Text += $"ID Number: {product.UId}\n" + $"Title: {product.Title}" +
                    $"\nDirector: {product.Director}\n\n";
            }
            for(int i = 0; order1.Products.Count > i; i++)
            {
                
                Product product = order1.Products[i];
                if(product.Title.Contains("El Dordado"))
                {
                    order1.Products.Remove(product);
                }
            }
            foreach (Product product in order1.Products)
            {
                rtbDisplay.Text += $"ID Number: {product.UId}\n" + $"Title: {product.Title}" +
                    $"\nDirector: {product.Director}\n\n";
            }
            for(int i = 0; order1.Products.Count > i; i++)
            {
                if (order1.Products[i].Title.Contains("Robcop"))
                {
                    order1.Products.Remove(order1.Products[i]);
                }
            }
            foreach (Product product in order1.Products)
            {
                rtbDisplay.Text += $"ID Number: {product.UId}\n" + $"Title: {product.Title}" +
                    $"\nDirector: {product.Director}\n\n";
            }

            //display the final price with a single method call

            MessageBox.Show(order1.TotalPrice().ToString("c"));
        }
        public void ProdcutExaple()
        {
            Product charlesMovie = new Product("El Darado", "Howard Hawks");
            charlesMovie.Title = "Mallrats";
            try
            {
                charlesMovie.Price = -5;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}