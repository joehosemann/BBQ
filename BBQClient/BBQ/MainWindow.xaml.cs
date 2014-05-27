using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using BBQ.Model;

namespace BBQ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static DSQueues DSQueuePreferences = new DSQueues();
        public static DataSet DSQueueDetails = new DataSet();
        public static DataSet DSProductDataSet = new DataSet();
        public static DataSet DSProductQueues = new DataSet();

        public SolidColorBrush InactiveQueueBG { get { return Properties.Settings.Default.InactiveQueueBG; } }
        public SolidColorBrush InactiveQueueFG { get { return Properties.Settings.Default.InactiveQueueFG; } }
        public Color InactiveCallTypeBG { get { return Properties.Settings.Default.InactiveCallTypeBG.Color; } }
        public Color InactiveCallTypeFG { get { return Properties.Settings.Default.InactiveCallTypeFG.Color; } }
        public Color ActiveQueueBG { get { return Properties.Settings.Default.ActiveQueueBG.Color; } }
        public Color ActiveQueueFG { get { return Properties.Settings.Default.ActiveQueueFG.Color; } }
        public Color ActiveCallTypeBG { get { return Properties.Settings.Default.ActiveCallTypeBG.Color; } }
        public Color ActiveCallTypeFG { get { return Properties.Settings.Default.ActiveCallTypeFG.Color; } }
        
        private bool _optionsOpened;

        //private int _getHideMainWindowDelay = 1; // Measured in ticks
        //private int _getTimeMainWindowIsHidden = 10; // Measured in ticks
        //private int _setMouseOverInSeconds = 0;
        //private int _setCurrentTimeMainWindowIsHidden = 0;
        

        private readonly DispatcherTimer _dispatchTimer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();

            SetWindow();

            MyWindow.LocationChanged += MyWindow_LocationChanged;

            setColors();

            PopulateQueuePreferencesDataSet();
            PopulateQueryDetailsDataset();
            PopulateProductQueuesDataset();


            lbRoot.DataContext = DSProductQueues;
          

            _dispatchTimer.Interval = TimeSpan.FromSeconds(3);
            _dispatchTimer.Tick += new EventHandler(timer_Tick);

            _dispatchTimer.Start();

            

            var publicKey = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

            switch (Properties.Settings.Default.PublicKey)
            {
                case null:
                    MessageBox.Show("Thank you for installing BBQ.");
                     Properties.Settings.Default.PublicKey = publicKey;
                    Properties.Settings.Default.NewInstall = false;
                        Properties.Settings.Default.Save();
                    OptionsClick();
                    break;
                case "":
                    MessageBox.Show("Thank you for installing BBQ.");
                     Properties.Settings.Default.PublicKey = publicKey;
                    Properties.Settings.Default.NewInstall = false;
                        Properties.Settings.Default.Save();
                    OptionsClick();
                    break;
                default:
                    if (publicKey != Properties.Settings.Default.PublicKey)
                    {
                        MessageBox.Show("Thank you for updating BBQ.");
                        Properties.Settings.Default.PublicKey = publicKey;
                        Properties.Settings.Default.NewInstall = false;
                        Properties.Settings.Default.Save();
                    }
                    break;
            }
        }

        void setColors()
        {
            if (Properties.Settings.Default.InactiveApplicationBackground == null)
            {
                Properties.Settings.Default.InactiveApplicationBackground = new SolidColorBrush(Colors.LightGray);
                Properties.Settings.Default.Save();
            }
            if (Properties.Settings.Default.InactiveQueueBG == null)
            {
                Properties.Settings.Default.InactiveQueueBG = new SolidColorBrush(Colors.LightGray);
                Properties.Settings.Default.Save();
            }
            if (Properties.Settings.Default.InactiveQueueFG == null)
            {
                Properties.Settings.Default.InactiveQueueFG = new SolidColorBrush(Colors.Black);
                Properties.Settings.Default.Save();
            }
            if (Properties.Settings.Default.InactiveCallTypeBG == null)
            {
                Properties.Settings.Default.InactiveCallTypeBG = new SolidColorBrush(Colors.White);
                Properties.Settings.Default.Save();
            }
            if (Properties.Settings.Default.InactiveCallTypeFG == null)
            {
                Properties.Settings.Default.InactiveCallTypeFG = new SolidColorBrush(Colors.Black);
                Properties.Settings.Default.Save();
            }
            if (Properties.Settings.Default.ActiveQueueBG == null)
            {
                Properties.Settings.Default.ActiveQueueBG = new SolidColorBrush(Colors.LightGray);
                Properties.Settings.Default.Save();
            }
            if (Properties.Settings.Default.ActiveQueueFG == null)
            {
                Properties.Settings.Default.ActiveQueueFG = new SolidColorBrush(Colors.Black);
                Properties.Settings.Default.Save();
            }
            if (Properties.Settings.Default.ActiveCallTypeBG == null)
            {
                Properties.Settings.Default.ActiveCallTypeBG = new SolidColorBrush(Colors.Pink);
                Properties.Settings.Default.Save();
            }
            if (Properties.Settings.Default.ActiveCallTypeFG == null)
            {
                Properties.Settings.Default.ActiveCallTypeFG = new SolidColorBrush(Colors.Black);
                Properties.Settings.Default.Save();
            }
            if (Properties.Settings.Default.ExtendedQueueBG == null)
            {
                Properties.Settings.Default.ExtendedQueueBG = new SolidColorBrush(Colors.LightGray);
                Properties.Settings.Default.Save();
            }
            if (Properties.Settings.Default.ExtendedQueueFG == null)
            {
                Properties.Settings.Default.ExtendedQueueFG = new SolidColorBrush(Colors.Black);
                Properties.Settings.Default.Save();
            }
            if (Properties.Settings.Default.ExtendedCallTypeBG == null)
            {
                Properties.Settings.Default.ExtendedCallTypeBG = new SolidColorBrush(Colors.Red);
                Properties.Settings.Default.Save();
            }
            if (Properties.Settings.Default.ExtendedCallTypeFG == null)
            {
                Properties.Settings.Default.ExtendedCallTypeFG = new SolidColorBrush(Colors.Black);
                Properties.Settings.Default.Save();
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {

            // Ensures the window is in the screen.
            Utilities.ensureWindowVisibility(this.MyWindow);

            // This ensures the application is always on top.
            this.Topmost = true;


            /* I'm not including the below unfinished code as its completely unnecessary.
             * The user can simply move the bar if they want to see past it.  Hiding it is stupid.            

           if (Mouse.DirectlyOver == this.FindName("MyRectangle") && Mouse.LeftButton == MouseButtonState.Pressed) //TODO HERE
           {
                   _setMouseOverInSeconds++;               
           }
           else
           {
               if (_setMouseOverInSeconds > _getHideMainWindowDelay && _setCurrentTimeMainWindowIsHidden != _getTimeMainWindowIsHidden && this.MyWindow.Visibility == Visibility.Visible)
               {
                   this.MyWindow.Visibility = Visibility.Collapsed;
                   _setCurrentTimeMainWindowIsHidden++;
               }
               else if (_setMouseOverInSeconds > _getHideMainWindowDelay && _setCurrentTimeMainWindowIsHidden == _getTimeMainWindowIsHidden && this.MyWindow.Visibility != Visibility.Visible)
               {
                   this.MyWindow.Visibility = Visibility.Visible;                   
                   _setMouseOverInSeconds = 0;
                   _setCurrentTimeMainWindowIsHidden = 0;
               }
               else if (_setMouseOverInSeconds > _getHideMainWindowDelay)
               {
                   _setCurrentTimeMainWindowIsHidden++;
               }
               
           }
             */ 
            // Last cause its slow...
           PopulateProductQueuesDataset();

        }


        #region Events



        private void MyWindow_LocationChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.WindowLeft = MyWindow.Left;
            Properties.Settings.Default.WindowTop = MyWindow.Top;
            Properties.Settings.Default.Save();
        }

        private void MenuQuit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void Rectangle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void OptionsClick(object sender, RoutedEventArgs e)
        {
            if (!_optionsOpened)
            {
                _optionsOpened = true;
                var opt = new Options();
                opt.Closed += opt_Closed;
                opt.Show();
            }
        }

        private void OptionsClick()
        {
            if (!_optionsOpened)
            {
                _optionsOpened = true;
                var opt = new Options();
                opt.Closed += opt_Closed;
                opt.Show();
            }
        }

        private void opt_Closed(object sender, EventArgs e)
        {
            _optionsOpened = false;
            PopulateQueuePreferencesDataSet();
        }

        #endregion

        #region deadcode

        // var uniques = ds.Tables[0].AsEnumerable().Distinct(DataRowComparer.Default);

        //  var xml = WebRequest.Create(XmlPath) as HttpWebRequest;
        //  if (xml != null) DSQueuePreferences.CallTypeQueue.ReadXml(xml.GetResponse().GetResponseStream());

        //  DSQueuePreferences.Tables.Add("QueueDetails").ReadXml(xml.GetResponse().GetResponseStream());

        //foreach (var item in new Model.CallTypeNames().ListProductQueues())
        //{
        //    DSQueuePreferences.QueuePreferences.AddQueuePreferencesRow(item.QueueName, 1, 2, false, false, false, false);
        //}

        //DSQueuePreferences.QueuePreferences.WriteXml(@"QueuePreferences.xml");

        //  DSQueuePreferences.QueuePreferences.ReadXml(@"QueuePreferences.xml");

        //  DSQueuePreferences.Tables.Add("QueueDetails").ReadXml(xml.GetResponse().GetResponseStream());

        #endregion

        #region Methods

        private void SetWindow()
        {
            MyWindow.VerticalAlignment = VerticalAlignment.Top;

            if (Properties.Settings.Default.WindowLeft != 0)
                MyWindow.Left = Properties.Settings.Default.WindowLeft;
            if (Properties.Settings.Default.WindowTop != 0)
                MyWindow.Top = Properties.Settings.Default.WindowTop;
        }

        public DataTable DuplicateRowRemove(DataTable dt)
        {
            var hTable = new Hashtable();
            var ArrDupli = new ArrayList();

            foreach (DataRow r in dt.Rows)
            {
                if (hTable.Contains(r))
                    ArrDupli.Add(r);
                else
                    hTable.Add(r, string.Empty);
            }

            foreach (DataRow r in ArrDupli)
                dt.Rows.Remove(r);

            return dt;
        }


        private void PopulateQueuePreferencesDataSet()
        {

            DSQueuePreferences = new DSQueues();
            DSQueuePreferences.ReadXml("QueuePreferences.xml");
            DSQueuePreferences.AcceptChanges();
        }

        private void PopulateQueryDetailsDataset()
        {
            var ds = new DataSet();
            try
            {
//#if DEBUG
//            {
//                ds.ReadXml("QueueDetails.xml", XmlReadMode.InferSchema);
//            }
//#else
                //{
                    var xml = WebRequest.Create(Properties.Settings.Default.QueueDetails) as HttpWebRequest;
                    if (xml != null) ds.ReadXml(xml.GetResponse().GetResponseStream(), XmlReadMode.InferSchema);

//                }
//#endif
                var hTable = new Hashtable();
                var ArrDupli = new ArrayList();

                foreach (DataRow r in ds.Tables["QueueDetails"].Rows)
                {
                    if (hTable.Contains(r["ProductName"]))
                        ArrDupli.Add(r);
                    else
                        hTable.Add(r["ProductName"], string.Empty);
                }

                foreach (DataRow r in ArrDupli)
                    ds.Tables["QueueDetails"].Rows.Remove(r);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            DSQueueDetails = ds;
        }


        private void PopulateProductQueuesDataset()
        {
            DSProductQueues.Clear();
            

           // var ds = new DataSet();
            try
            {


//#if DEBUG
//            {
//                //ds.ReadXml("ProductQueues.xml", XmlReadMode.InferSchema);
//            }
//#else
//                {
                    // Create the web request  
                    HttpWebRequest request = WebRequest.Create(Properties.Settings.Default.ProductPath) as HttpWebRequest;

                    // Get response  
                    using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                    {
                        // Get the response stream  
                        //ds.ReadXml(response.GetResponseStream(),XmlReadMode.InferSchema);
                        DSProductQueues.ReadXml(response.GetResponseStream(),XmlReadMode.InferSchema);
                    }

                  //  var xml = WebRequest.Create(Settings.Default.ProductPath) as HttpWebRequest;
                  //  if (xml != null) ds.ReadXml(xml.GetResponse().GetResponseStream(), XmlReadMode.InferSchema);

                    

//                }
//#endif

                var arrayList = new ArrayList();

                EnumerableRowCollection<string> productNames = DSQueuePreferences.QueuePreferences.Select(x => x.ProductName);

                //foreach (DataRow row in ds.Tables["Product"].Rows)
                foreach (DataRow row in DSProductQueues.Tables["Product"].Rows)
                {
                    if (!productNames.Contains(row["ProductName"]))
                    {
                        arrayList.Add(row);
                    }
                }

                foreach (DataRow r in arrayList)
                 //   ds.Tables["Product"].Rows.Remove(r);
                DSProductQueues.Tables["Product"].Rows.Remove(r);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        #endregion


        


        private void Rectangle_MouseEnter(object sender, MouseEventArgs e)
        {
            
        }
    }
}