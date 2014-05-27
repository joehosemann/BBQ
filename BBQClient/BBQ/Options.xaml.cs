using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows;
using BBQ.Properties;

namespace BBQ
{
    /// <summary>
    /// Interaction logic for Options.xaml
    /// </summary>
    public partial class Options : Window
    {
        private readonly string _productQueuesPath;
        private readonly string _queueDetailsPath;

        public Options()
        {
            InitializeComponent();

            _productQueuesPath = Settings.Default.ProductPath;
            _queueDetailsPath = Settings.Default.QueueDetails;

            tbProductPath.Text = _productQueuesPath;
            tbQueueDetailsPath.Text = _queueDetailsPath;

            MainWindow.DSQueuePreferences = new DSQueues();
            if (!File.Exists("QueuePreferences.xml"))
                File.Create("QueuePreferences.xml");
            MainWindow.DSQueuePreferences.QueuePreferences.ReadXml("QueuePreferences.xml");
            MainWindow.DSQueuePreferences.QueuePreferences.AcceptChanges();

            lbProductQueues.DataContext = MainWindow.DSQueueDetails;
            lbMyProductQueues.DataContext = MainWindow.DSQueuePreferences;
            
        }

        private void AddClick(object sender, RoutedEventArgs e)
        {
            if (lbProductQueues.SelectedItem != null)
            {
                var row = (DataRowView) lbProductQueues.SelectedItem;
                MainWindow.DSQueuePreferences.QueuePreferences.AddQueuePreferencesRow(row["ProductName"].ToString(), "");
            }
        }

        private void RemoveClick(object sender, RoutedEventArgs e)
        {
            if (lbMyProductQueues.SelectedItem != null)
            {
                var row = (DataRowView) lbMyProductQueues.SelectedItem;
                MainWindow.DSQueuePreferences.QueuePreferences.RemoveQueuePreferencesRow(
                    (DSQueues.QueuePreferencesRow) row.Row);
            }
        }

        private void OkClick(object sender, RoutedEventArgs e)
        {
            if (_productQueuesPath != tbProductPath.Text)
            {
                Settings.Default.ProductQueues = tbProductPath.Text;
                Settings.Default.Save();
            }
            if (_queueDetailsPath != tbQueueDetailsPath.Text)
            {
                Settings.Default.QueueDetails = tbQueueDetailsPath.Text;
                Settings.Default.Save();
            }

            MainWindow.DSQueuePreferences.QueuePreferences.AcceptChanges();
            MainWindow.DSQueuePreferences.QueuePreferences.WriteXml("QueuePreferences.xml");
            Close();
        }

        private void CancelClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            MainWindow.DSQueuePreferences.QueuePreferences.RejectChanges();
        }


        #region Colors Window

        private bool _colorsOpened;

        private void opt_Closed(object sender, EventArgs e)
        {
            _colorsOpened = false;
        }
        private void Colors_Click(object sender, RoutedEventArgs e)
        {
            if (!_colorsOpened)
            {
                _colorsOpened = true;
                var opt = new ColorSelectNew();
                opt.Closed += opt_Closed;
                opt.Show();
            }
        }

        #endregion
    }
}