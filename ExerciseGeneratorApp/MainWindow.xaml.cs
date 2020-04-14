using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace Math2ndGrade
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string SelectedExerciseType { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new AppViewModel();
        }

        private void OnExerciseTypeSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedExerciseType = ((ComboBox)sender).SelectedItem.ToString();
        }

        private void OnGenerateExerciseClicked(object sender, RoutedEventArgs e)
        {
            int.TryParse(ExerciseNumberTextBox.Text, out int exerNum);

            if (exerNum<0 || exerNum > 300)
            {
                MessageBox.Show("Please select a number between 0 and 300");
                return;
            }
            IExercise exercise = ExerGeneratorFactory.GetInstance().GetExerciseGenerator(SelectedExerciseType);

            if (exercise == null)
            {
                return;
            }

            string exers = exercise.GenerateExercises(exerNum);
            ResultTextBlock.Text = exers;
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
