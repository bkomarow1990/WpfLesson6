using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace WpfLesson6
{
    public class ViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<MyColor> colorsCollection { get; set; }
        private Command addColorCommand;
        private Command removeColorCommand;
        public ViewModel()
        {
            colorsCollection = new ObservableCollection<MyColor>
            {
                new MyColor()
            };
            PropertyChanged += (s, a) =>
            {
                if (a.PropertyName == nameof(MyColor_))
                {
                    addColorCommand.RaiseCanExecuteChanged();
                    removeColorCommand.RaiseCanExecuteChanged();
                }
            };
            addColorCommand = new DelegateCommand(AddColor, () => MyColor_  != null);
            removeColorCommand = new DelegateCommand(RemoveColor, () => MyColor_  != null && colorsCollection.Count != 1);
        }
        private void AddColor()
        {
            if (MyColor_ != null)
            {
                colorsCollection.Add((MyColor)MyColor_.Clone());
            }
        }
        private void RemoveColor()
        {
            if (MyColor_ != null)
            {
                colorsCollection.Remove(MyColor_);
            }
        }

        private MyColor myColor = new MyColor();
        public ICommand AddColorCommand => addColorCommand;
        public ICommand RemoveColorCommand => removeColorCommand;
        public event PropertyChangedEventHandler PropertyChanged;
        public IEnumerable<MyColor> ColorNumarable => colorsCollection;
        public MyColor MyColor_
        {
            get { return myColor; }
            set { myColor = value; OnPropertyChanged(); }
        }
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
