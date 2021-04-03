using System;
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
            BvCodeText.Text = CodeDataContext.BvCode;
        }

        private void BvToAv_Click(object sender, RoutedEventArgs e)
        {
            CodeDataContext.ConvertToAv();
            AvCodeText.Text = CodeDataContext.AvCode;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
