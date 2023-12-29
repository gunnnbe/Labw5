using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Labw5
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
    }
}
public partial class MainWindow : Window
{
    public ObservableCollection<Task> Tasks { get; set; }
    public Task SelectedTask { get; set; }

    public MainWindow()
    {
        InitializeComponent();
        Tasks = new ObservableCollection<Task>();
        taskListView.ItemsSource = Tasks;
        DataContext = this;
    }

    private void AddTask_Click(object sender, RoutedEventArgs e)
    {
        // Реализуйте логику добавления задачи
    }

    private void EditTask_Click(object sender, RoutedEventArgs e)
    {
        // Реализуйте логику редактирования задачи
    }

    private void DeleteTask_Click(object sender, RoutedEventArgs e)
    {
        // Реализуйте логику удаления задачи
    }
}
