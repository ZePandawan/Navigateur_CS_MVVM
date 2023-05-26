using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigateur.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        private static readonly Dictionary<string, PropertyChangedEventArgs> _cache;

        static ViewModelBase()
        {
            _cache = new Dictionary<string, PropertyChangedEventArgs>();
        }

        private PropertyChangedEventArgs GetPropertyChangedEventArgs(string propertyName)
        {
            if(!_cache.TryGetValue(propertyName, out PropertyChangedEventArgs? e)) {
                e = new PropertyChangedEventArgs(propertyName);
                _cache.Add(propertyName, e);
            }
            return e;
        }



        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, GetPropertyChangedEventArgs(propertyName));
            }
        }

        protected void OnPropertyChanged(params string[] propertyNames)
        {
            if(PropertyChanged != null)
            {
                foreach(string p in propertyNames)
                {
                    PropertyChanged(this, GetPropertyChangedEventArgs(p));
                }
            }
        }
    }
}
