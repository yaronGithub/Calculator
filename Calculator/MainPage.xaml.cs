using System.ComponentModel;

namespace Calculator
{
    public class CalculatorBrain : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
        public CalculatorBrain() 
        {
            ButtonCommand = new Command(() => ChangeOutput(output));
        }
        private string output;
        public string Output
        {
            get { return output; }
            set { output = value; OnPropertyChanged(); }
        }
        public Command ButtonCommand { get; set; }
        private void ChangeOutput(string str)
        {
            this.Output += str;
            ButtonCommand.ChangeCanExecute();
        }
    }
    public partial class MainPage : ContentPage
    {
        CalculatorBrain brain;
        public MainPage()
        {
            InitializeComponent();
            brain = new CalculatorBrain();
            BindingContext = brain;
        }
    }
}