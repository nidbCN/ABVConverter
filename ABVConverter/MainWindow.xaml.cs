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
        public Model CodeDataContext { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            CodeDataContext = new Model()
            {
                AvCode = "av22123800",
            };

            VideoCodePanel.DataContext = CodeDataContext;
        }

        private void AvToBv_Click(object sender, RoutedEventArgs e)
        {
            CodeDataContext.ConvertToBv();
            MessageBox.Show(JsonSerializer.Serialize(CodeDataContext));
        }

        private void BvToAv_Click(object sender, RoutedEventArgs e)
        {
            CodeDataContext.ConvertToAv();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {

            Environment.Exit(0);
        }
    }
}
