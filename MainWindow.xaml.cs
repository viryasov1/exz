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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] A;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            A = new int[10];

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rnd.Next(1, 101);
            }

            ArrayLabel.Content = string.Join(", ", A);
            FindMaxButton.IsEnabled = true;
        }

        private void FindMaxButton_Click(object sender, RoutedEventArgs e)
        {
            int maxElement = A[0];
            int maxIndex = 0;

            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] > maxElement)
                {
                    maxElement = A[i];
                    maxIndex = i;
                }
            }

            ResultLabel.Content = "Максимальный элемент: " + maxElement;
            IndexLabel.Content = "Его порядковый номер: " + (maxIndex + 0);
        }
    }
}
