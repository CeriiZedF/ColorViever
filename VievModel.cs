using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace ColorViever
{
    internal class VievModel : INotifyPropertyChanged
    {
        public Colors MyColor;
       
        public VievModel() 
        {
            MyColor = new Colors();
            UpdateBackground();
        }

        public byte Alpha
        {
            get => MyColor.alpha;
            set
            {
                MyColor.alpha = value;
                OnPropertyChanged("Alpha");
            }
        }
        public byte Red
        {
            get => MyColor.red;
            set
            {
                MyColor.red = value;
                OnPropertyChanged("Red");
            }
        }

        public byte Green
        { 
            get => MyColor.green;
            set
            {
                MyColor.green = value;
                OnPropertyChanged("Green");
            }
        }
        public byte Blue
        {
            get => MyColor.blue;
            set
            {
                MyColor.blue = value;
                OnPropertyChanged("Blue");
            }
        }
        public SolidColorBrush UpdateBackground()
        {
            return new SolidColorBrush(System.Windows.Media.Color.FromArgb(Alpha, Red, Green, Blue));
            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                this.PropertyChanged(this, e);
            }
        }
    }
}
