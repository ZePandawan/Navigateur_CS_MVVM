using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigateur.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private readonly ObservableCollection<URLView> _URL;
        private URLView _URLView;

        public MainViewModel()
        {
            _URL = new ObservableCollection<URLView>();
            _URLView = new URLView() {CurrentURL = "https://www.google.com" };
        }

        public URLView NewURLView { 
            get { return _URLView; } 
        }

        public ReadOnlyObservableCollection<URLView> URLS
        {
            get { return new ReadOnlyObservableCollection<URLView>(_URL); }
        }

        public void Ajouter()
        {
            _URL.Add(_URLView);

            _URLView = new URLView();
            OnPropertyChanged(nameof(NewURLView));
        }

    }
}
