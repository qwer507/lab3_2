using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Change_color(object sender, RoutedEventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex == 0)
                paint_place.DefaultDrawingAttributes.Color = Colors.Red;
            if (((ComboBox)sender).SelectedIndex == 1)
                paint_place.DefaultDrawingAttributes.Color = Colors.Green;
            if (((ComboBox)sender).SelectedIndex == 2)
                paint_place.DefaultDrawingAttributes.Color = Colors.Blue;
        }
        private void Change_size(object sender, RoutedEventArgs e)
        {
            paint_place.DefaultDrawingAttributes.Width = ((Slider)sender).Value;
            paint_place.DefaultDrawingAttributes.Height = ((Slider)sender).Value;
        }
        private void Change_edit(object sender, RoutedEventArgs e)
        {
            if (((FrameworkElement)sender).Tag.ToString() == "paint")
                paint_place.EditingMode = InkCanvasEditingMode.Ink;
            if (((FrameworkElement)sender).Tag.ToString() == "edit")
                paint_place.EditingMode = InkCanvasEditingMode.EraseByPoint;
            if (((FrameworkElement)sender).Tag.ToString() == "delete")
                paint_place.EditingMode = InkCanvasEditingMode.EraseByStroke;
        }
    }
}