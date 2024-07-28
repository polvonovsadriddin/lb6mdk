using System.Printing;
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
namespace lab6mdk
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { private List<int> dynamiclist;    
        private List<int> evenNumbers;
        private List<int> oddNumbers;
        Random random;
      
        private Queue<int> queue;

        public MainWindow()
        {
            InitializeComponent();
            dynamiclist = new List<int>();
            evenNumbers = new List<int>();
            oddNumbers= new List<int>();
            random = new Random();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
                for (int i = 0; i < 10; i++)
                {
                    dynamiclist.Add(random.Next(10, 89));
                }

                lbList.ItemsSource = dynamiclist;
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            evenNumbers=dynamiclist.Where(x => x%2==0).ToList();
            oddNumbers = dynamiclist.Where(x => x % 2 != 0).ToList();
            Result.Text = "";
            Result.Text += "Четные числа: " + string.Join(", ", evenNumbers) + "\n";
            Result.Text += "Нечетные числа: " + string.Join(", ", oddNumbers);


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            evenNumbers = dynamiclist.Where(x => x % 2 == 0).ToList();
            oddNumbers = dynamiclist.Where(x => x % 2 != 0).ToList();
            Result.Text = "";
            if (evenNumbers.Count > oddNumbers.Count)
            {
                Result.Text = $"массив четных чисел больше на {evenNumbers.Count - oddNumbers.Count} ";
            }
            else if (evenNumbers.Count < oddNumbers.Count)
            {
                Result.Text = $"массив нечетных чисел больше на {oddNumbers.Count - evenNumbers.Count} ";
            }
            else Result.Text = $"массивы равны:{evenNumbers}={oddNumbers}";
            
          

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)  /*add*/
        {
           Queue<string>myqueue= new Queue<string>();
            if (tbelementqueue.Text != null)
            {
                myqueue.Enqueue(tbelementqueue.Text);
               lbList.ItemsSource = myqueue;
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)  /*remove*/
        {
          
        }

        private void Button_Click_5(object sender, RoutedEventArgs e) /* colculate*/
        {

        }
    }
}