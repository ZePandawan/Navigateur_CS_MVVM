using Microsoft.Web.WebView2.Core;
using Navigateur.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Navigateur
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>


    /*
        public partial class MainWindow : Window
        {
            private readonly ModelViewURL _c;

        private List<string> visitedPages = new List<string>();
        private int currentIndex = 0;
        public MainWindow()
        {
            InitializeComponent();
            _c = new ModelViewURL();
            DataContext = _c;
        }

        private void ComboBoxcurrentURLHistorique_SelectionChanged(object sender, RoutedEventArgs e)
        {
            string selectedUrl = ComboBoxcurrentURLHistorique.SelectedItem as string;
            if (!string.IsNullOrEmpty(selectedUrl))
            {
                webView.CoreWebView2.Navigate(selectedUrl);
                currentIndex = visitedPages.IndexOf(selectedUrl);
            }
        }

        private void ButtonGo_Click(object sender, RoutedEventArgs e)
        {
            if (webView != null && webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.Navigate(_c.CurrentURL); // Recupère ce qui est tapé dans la barre d'adresse et s'y rend
                currentIndex += 1;
            }
        }
        private void webView_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e) // Appel via .xaml : NavigationCompleted = "blabalba";
        {
            _c.CurrentURL = webView.Source.ToString(); // Va dans element webView et recupère l'element Source. (Et on le met dans la variable affichée dans ComboBox)
            if(!visitedPages.Contains(_c.CurrentURL))
            {
                visitedPages.Add(_c.CurrentURL);
                ComboBoxcurrentURLHistorique.Items.Add(_c.CurrentURL);
            }
        }

        private void PreviousButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentIndex > 0 && currentIndex <= visitedPages.Count)
            {
                currentIndex--;
                string previousUrl = visitedPages[currentIndex];
                ComboBoxcurrentURLHistorique.SelectedItem = previousUrl;
                webView.CoreWebView2.Navigate(previousUrl);
            }
        }
    }

    */




    public partial class MainWindow : Window
    {
        private readonly MainViewModel _vm;
        public MainWindow()
        {
            InitializeComponent();

            _vm = new MainViewModel();

            DataContext = _vm;
        }

        private void AjouterButton_Click(object sender, RoutedEventArgs e)
        {
            _vm.Ajouter();
        }


    }

        

}
