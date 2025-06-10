using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WPF_Calendar
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

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                DragMove();
            }
        }

        private void addNoteLabel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            addNoteTextbox.Focus();
        }

        private void addNoteTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(addNoteTextbox.Text))
            {
                addNoteLabel.Visibility = Visibility.Collapsed;
            }
            else
            {
                addNoteLabel.Visibility = Visibility.Visible;
            }
        }

        private void timeLabel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            timeTextBox.Focus();
        }

        private void timeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(timeTextBox.Text))
            {
                timeLabel.Visibility = Visibility.Collapsed;
            }
            else
            {
                timeLabel.Visibility = Visibility.Visible;
            }
        }
    }
}