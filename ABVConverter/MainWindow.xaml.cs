using System;
using System.Text.Json;
using System.Windows;

namespace ABVConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Model DataContext { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new Model()
            {
                AvCode = "av22123800",
            };
            VideoCodePanel.DataContext = DataContext;
        }

        private void AvToBv_Click(object sender, RoutedEventArgs e)
        {
            DataContext.ConvertToBv();
            MessageBox.Show(JsonSerializer.Serialize(DataContext));
        }

        private void BvToAv_Click(object sender, RoutedEventArgs e)
        {
            DataContext.ConvertToAv();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {

            Environment.Exit(0);
        }
    }
}
