using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace XamarinRazor.Sample.ViewModels
{
    public class HomePageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public int Count { get; set; }
        public Color Color { get; set; }
        public IEnumerable<string> Data = new string[] { "A", "B", "C" };
    }
}
