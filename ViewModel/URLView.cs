using Navigateur.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigateur.ViewModel
{
    public class URLView : ViewModelBase
    {
        private URL _model;
        public URLView() { 
            _model = new URL();
        }

        public String CurrentURL
        {
            get { return _model.CurrentURL; }
            set
            {
                _model.CurrentURL = value;
                OnPropertyChanged(nameof(CurrentURL));
            }
        }
    }
}
