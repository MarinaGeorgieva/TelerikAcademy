namespace ChangeTextColor.ViewModels
{
    using System.ComponentModel;

    public class MainPageViewModel : INotifyPropertyChanged
    {
        private string backgroundColor;
        private string foregroundColor;
        
        public string BackgroundColor
        {
            get
            {
                return this.backgroundColor;
            }
            set
            {
                this.backgroundColor = value;
                this.RaisePropertyChanged("BackgroundColor");
            }
        }

        public string ForegroundColor
        {
            get
            {
                return this.foregroundColor;
            }
            set
            {
                this.foregroundColor = value;
                this.RaisePropertyChanged("ForegroundColor");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            if (this.PropertyChanged == null)
            {
                return;
            }

            this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
