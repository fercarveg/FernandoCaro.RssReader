using rssDTO;
using rssLibrary;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel.Syndication;
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
using System.Xml;

namespace WpfRss
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.PopulateRssFeed();          
        }
        private void PopulateRssFeed()
        {
            ReaderRss reader = new ReaderRss();
            listFeeds.ItemsSource = reader.PopulateRssFeed();            
        }
    }
}
