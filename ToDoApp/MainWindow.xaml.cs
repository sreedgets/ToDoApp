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

namespace ToDoApp
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

        private void SubmitTodo(object sender, RoutedEventArgs e)
        {
            string todoText = TodoInput.Text;

            if (!string.IsNullOrEmpty(todoText))
            {
                //One example of how to create a textblock and add
                //the text input
                //TextBlock todoItem = new TextBlock();
                //todoItem.Text = todoText;
                //todoItem.Foreground = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFF5F5F5");
                //todoItem.Foreground = new SolidColorBrush(Colors.White);

                //Second example
                TextBlock todoItem = new TextBlock
                {
                    Text = todoText,
                    Margin = new Thickness(10),
                    Foreground = new SolidColorBrush(Colors.White)
                };

                TodoList.Children.Add(todoItem);

                TodoInput.Clear();
            }
        }
    }
}