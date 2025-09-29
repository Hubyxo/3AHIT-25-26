using System.IO;
using System.Windows;
using System;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Data;
using ToDoList.Classes;

namespace ToDoList
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<TaskIsDone> Tasks { get; set; }
        private CollectionViewSource viewSource;

        public MainWindow()
        {
            InitializeComponent();
            Tasks = new ObservableCollection<TaskIsDone>();

            // ViewSource für Filter
            viewSource = new CollectionViewSource { Source = Tasks };
            TodoList.ItemsSource = viewSource.View;
        }

        private void AddTodo(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TodoInput.Text))
            {
                Tasks.Add(new TaskIsDone { Title = TodoInput.Text, IsDone = false });
                TodoInput.Clear();
                viewSource.View.Refresh(); // neu filtern
            }
        }
        private void DltTodo(object sender, RoutedEventArgs e)
        {
            if (TodoList.SelectedItem is TaskIsDone selectedTask)
            {
                Tasks.Remove(selectedTask);
            }
            else
            {
                MessageBox.Show("Bitte ein Element auswählen, das entfernt werden soll.");
            }
        }

        // Speichert den Text der TextBox in die Datei Code.txt
        private void SaveToFile(object sender, RoutedEventArgs e)
        {
            try
            {
                string path = @".\Code.txt";
                string folder = Path.GetDirectoryName(path);
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLine(TodoInput.Text);
                }

                MessageBox.Show("Text erfolgreich in Code.txt gespeichert!", "Erfolg",
                                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Fehler beim Speichern der Datei.", "Fehler",
                                MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Event-Handler für Filter
        private void FilterChanged(object sender, RoutedEventArgs e)
        {
            if (viewSource == null) return;

            if (rbAll.IsChecked == true)
            {
                viewSource.View.Filter = null; // alles anzeigen
            }
            else if (rbDone.IsChecked == true)
            {
                viewSource.View.Filter = task => (task as TaskIsDone)?.IsDone == true;
            }
            else if (rbUndone.IsChecked == true)
            {
                viewSource.View.Filter = task => (task as TaskIsDone)?.IsDone == false;
            }

            viewSource.View.Refresh();
        }
    }
}
