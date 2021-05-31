using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfLesson6
{
    class MyColor : INotifyPropertyChanged
    {
        Color myColor ;

        public byte Alpha
        {
            get { return myColor.A; }
            set
            {
                myColor.A = value;
                OnPropertyChanged();
                OnPropertyChanged("MyColor_");
            }
        }
        public MyColor()
        {
            MyColor_ = Color.FromArgb(255, 0, 255, 255);
        }

        public Color MyColor_
        {
            get => myColor;
            set
            {
                myColor = value;
                OnPropertyChanged();


            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
