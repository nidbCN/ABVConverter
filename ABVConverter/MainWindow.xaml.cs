using System;
using System.Windows;
using System.Windows.Input;

namespace ABVConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
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

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            //if (e.LeftButton == MouseButtonState.Pressed)
            //{
            //    DragMove();
            //}
        }

        private void Main_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            base.OnMouseLeftButtonDown(e);

            // Begin dragging the window
            DragMove();
        }
    }
}
