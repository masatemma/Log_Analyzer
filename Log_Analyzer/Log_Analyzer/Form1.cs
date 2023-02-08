using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace Log_Analyzer
{

    
    public partial class Form1 : Form
    {


        //private static string SOURCE_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Log_Source\\";
        private static string SOURCE_FOLDER;

        FileInfo[] allFiles;

        private LogFile logFile;
        string filteredLogs;
        int maxMatchedNum;


        private FilterSet filterSet1 = new FilterSet(0);
        private FilterSet filterSet2 = new FilterSet(0);

        string curFileName = "";
        long curFileSize = 0;

        //file watcher
        public FileSystemWatcher watcher;
        Stopwatch sw = new Stopwatch();

        public Form1()
        {
            try
            {
                UpdateConfig();
                CreateSourceFolder();
                InitializeComponent();
                EnterKeyPressBinding();
                RoundedCorners();
                ComboBoxOp();
                WatchFiles();
               
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: Cannot open the application");
            }
            
            
        }


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        //Method for rounded corners of panels
        public void RoundedCorners()
        {
            try
            {
                ControlsBackground.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ControlsBackground.Width,
                ControlsBackground.Height, 30, 30));

                DisplayLogsBackground.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, DisplayLogsBackground.Width,
                DisplayLogsBackground.Height, 30, 30));

                StatusBackground.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, StatusBackground.Width,
                StatusBackground.Height, 30, 30));

                Filter1APanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Filter1APanel.Width,
                Filter1APanel.Height, 30, 30));

                Filter1BPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Filter1BPanel.Width,
                Filter1BPanel.Height, 30, 30));

                Filter1CPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Filter1CPanel.Width,
                Filter1CPanel.Height, 30, 30));

                Filter2APanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Filter2APanel.Width,
                Filter2APanel.Height, 30, 30));

                Filter2BPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Filter2BPanel.Width,
                Filter2BPanel.Height, 30, 30));

                Filter2CPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Filter2CPanel.Width,
                Filter2CPanel.Height, 30, 30));

                MatchedNumPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, MatchedNumPanel.Width,
                MatchedNumPanel.Height, 30, 30));
                
                panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width,
                panel1.Height, 15, 15));

                panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width,
                panel2.Height, 15, 15));


            }
            catch(Exception ex)
            {
                MessageBox.Show("Couldn't load UI components");
            }
            
        }


        private void UpdateConfig()
        {
            SOURCE_FOLDER = ConfigurationManager.AppSettings.Get("SOURCE_FOLDER");            

            if (SOURCE_FOLDER.Equals("default"))
            {
                SOURCE_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Log_Source";
            }
            SOURCE_FOLDER += "\\";
            
        }
        private void CreateSourceFolder()
        {
            try
            {
                // Determine whether the directory exists.
                if (Directory.Exists(SOURCE_FOLDER))
                {
                    return;
                }

                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(SOURCE_FOLDER);

            }
            catch (Exception e)
            {
                Console.WriteLine("The file path is invalid: Please check if your file path is entered correctly");
            }
        }

        private void EnterKeyPressBinding()
        {
            Filter1A.KeyPress += new KeyPressEventHandler(CheckEnterKeyPress);
            Filter1B.KeyPress += new KeyPressEventHandler(CheckEnterKeyPress);
            Filter1C.KeyPress += new KeyPressEventHandler(CheckEnterKeyPress);
            Filter2A.KeyPress += new KeyPressEventHandler(CheckEnterKeyPress);
            Filter2B.KeyPress += new KeyPressEventHandler(CheckEnterKeyPress);
            Filter2C.KeyPress += new KeyPressEventHandler(CheckEnterKeyPress);

        }


        private void CheckEnterKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                GetMaxMatchedNum();
                FilterOpearation();
            }
        }

        /*
         * Methods for operating a file watcher
         */
        private void WatchFiles()
        {
            if(SOURCE_FOLDER != null)
            {
                watcher = new FileSystemWatcher(SOURCE_FOLDER);
                watcher.NotifyFilter = NotifyFilters.FileName
                                | NotifyFilters.Size;

                watcher.Created += OnCreated;
                watcher.Deleted += OnDeleted;
                watcher.Error += OnError;

                watcher.EnableRaisingEvents = true;
            }
           
           
        }

        /*
        * A callback function passed when a new file is added to the folder
        * Calls the methods for processing the file and the operations for combobox to update the combobox
        */
        public void OnCreated(object sender, FileSystemEventArgs e)
        {
            ComboBoxOp();
            CurFileExists();
        }
        public void OnDeleted(object sender, FileSystemEventArgs e)
        {
            ComboBoxOp();
        }


        private static void OnError(object sender, ErrorEventArgs e) =>
            PrintException(e.GetException());

        private static void PrintException(Exception? ex)
        {
            if (ex != null)
            {
                Debug.WriteLine($"Message: {ex.Message}");
                Debug.WriteLine("Stacktrace:");
                Debug.WriteLine(ex.StackTrace);
                PrintException(ex.InnerException);
            }
        }


        private void FilterButton_Click(object sender, EventArgs e)
        {
            GetMaxMatchedNum();
            FilterOpearation();
        }

        private void FilterOpearation()
        {
            filterSet1.clearFilterSet();
            filterSet2.clearFilterSet();

            int filterNum = 0;
            if (Filter1A.Text.Length > 0)
            {
                filterSet1.filterProperties.ElementAt(0).filterText = Filter1A.Text;
                filterNum++;
            }

            if (Filter1B.Text.Length > 0)
            {
                filterSet1.filterProperties.ElementAt(1).filterText = Filter1B.Text;
                filterNum++;
            }

            if (Filter1C.Text.Length > 0)
            {
                filterSet1.filterProperties.ElementAt(2).filterText = Filter1C.Text;
                filterNum++;
            }
            filterSet1.filterNum = filterNum;


            //reset the number of filter peroperties for set 2
            filterNum = 0;

            if (Filter2A.Text.Length > 0)
            {
                filterSet2.filterProperties.ElementAt(0).filterText = Filter2A.Text;
                filterNum++;
            }

            if (Filter2B.Text.Length > 0)
            {
                filterSet2.filterProperties.ElementAt(1).filterText = Filter2B.Text;
                filterNum++;
            }

            if (Filter2C.Text.Length > 0)
            {
                filterSet2.filterProperties.ElementAt(2).filterText = Filter2C.Text;
                filterNum++;
            }

            filterSet2.filterNum = filterNum;
            ReadFile(curFileName, SOURCE_FOLDER + curFileName);
        }
        


        private void ReadFile(string fileName, string filePath)
        {
            try
            {
                logFile = new LogFile(fileName, filePath);
                logFile.maxMatchedNum = maxMatchedNum;
                logFile.filterSet1 = filterSet1;
                logFile.filterSet2 = filterSet2;       
            }
            catch(Exception ex)
            {
                HideFilteredLogs();
                HideCountTexts();
                MessageBox.Show("No file has been selected or the file does not exist in the folder");               
            }
           
            
            if(logFile != null) {
               
                sw.Reset();
                sw.Start();

                DisplayInFilteredLogs();

                sw.Stop();
                LoadingComplete();              
            }
        
        }
        
        private void DisplayInFilteredLogs()
        {
            int i = 0;

            WaitCursor(true);
            filteredLogs = logFile.FilterLogs();
          

            logFile.reader.Close();

            if (!logFile.matchedLogExists)
            {

                if (curFileSize == 0)
                {
                    FilteredLogs.Text = "Empty File";
                    FilteredCountLabel.Text = $"Matching Logs: NA\nTotal Number of Logs: {logFile.totalLogsNum}";
                }
                else
                {
                    FilteredLogs.Text = "No Matching Logs";
                    FilteredCountLabel.Text = $"Matching Logs: 0\nTotal Number of Logs: {logFile.totalLogsNum}";
                }
            }
            else if (logFile.outofMemory)
            {
                FilteredLogs.Text = "Data too large to be shown";
                FilteredCountLabel.Text = $"Matching Logs: NA\nTotal Number of Logs Read: {logFile.totalLogsNum}";
                ShowPartial.Visible = true;
            }
            else
            {
                FilteredLogs.Lines = filteredLogs.Split("\n");
                FilteredCountLabel.Text = $"Matching Logs: {logFile.matchedNum}\nTotal Number of Logs Read: {logFile.totalLogsNum}";
            }

            WaitCursor(false);
            ShowCountTexts();
            ShowFilteredLogs();

        }

     
        


        //Method to change the contents in the combobox
        //Called whenever there's a change in the source folder
        private void ComboBoxOp()
        {
            if(SOURCE_FOLDER != null)
            {
                DirectoryInfo curFolder = new DirectoryInfo(SOURCE_FOLDER);
                allFiles = curFolder.GetFiles();
                List<string> textFiles = new List<string>();
                if (allFiles.Length > 0)
                {
                    foreach (FileInfo file in allFiles)
                    {
                        textFiles.Add(file.Name);
                    }

                }

                if (IsHandleCreated)
                {
                    comboBox1.BeginInvoke(() =>
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.AddRange(textFiles.ToArray());
                        SetComboBoxText(textFiles.Count <= 0);
                    });

                }
                else
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.AddRange(textFiles.ToArray());
                    SetComboBoxText(textFiles.Count <= 0);
                }

                if (!CurFileExists())
                {
                    HideFilteredLogs();
                    HideCountTexts();
                    LoadingIncomplete();
                }
            }
           

        }

        //Combox selection
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!curFileName.Equals(comboBox1.SelectedItem.ToString())){
                logFile = null;
                curFileName = comboBox1.SelectedItem.ToString();
                if (allFiles.Length > 0)
                {
                    foreach (FileInfo file in allFiles)
                    {
                        if (file.Name.Equals(curFileName))
                        {
                            curFileSize = file.Length;
                        }
                    }

                }
                HideFilteredLogs();
                HideCountTexts();
                LoadingIncomplete();
            }           
        }

        //Check if curFile is still in the folder
        private bool CurFileExists()
        {
            if (allFiles.Length > 0)
            {
                foreach (FileInfo file in allFiles)
                {
                    if (curFileName.Equals(file.Name)){
                        return true;
                    }
                }
            }
            return false;
        }

        //HIde the filteredlogs textbox
        private void HideFilteredLogs()
        {
            if(IsHandleCreated)
            {
                FilteredLogs.BeginInvoke(() =>
                {
                  
                    FilteredLogs.Visible = false;
                    //FilteredLogs.Clear();
            
                });
            }
            else
            {             
                FilteredLogs.Visible = false;
                //FilteredLogs.Clear();

            } 
        }

        //Show the filteredlogs Textbox
        private void ShowFilteredLogs()
        {
            if (IsHandleCreated)
            {
                FilteredLogs.BeginInvoke(() =>
                {
                  
                    FilteredLogs.Visible = true;
                  
                });
            }
            else
            { 
                FilteredLogs.Visible = true;  
            }
        }

        //Showing the number of matched logs displayed 
        private void ShowCountTexts()
        {
            FilteredCountLabel.Visible = true;
        }

        //Hiding the number of matched logs displayed
        private void HideCountTexts()
        {
            if (IsHandleCreated)
            {
                FilteredCountLabel.BeginInvoke(() =>
                {
                    FilteredCountLabel.Visible = false;
                });
            }
            else
            {
                FilteredCountLabel.Visible = false;
            }
        }

        //Change the text shown in the combobox depending on the presence of files in the folder
        private void SetComboBoxText(bool isEmpty)
        {
            if (isEmpty)
            {
                comboBox1.Text = "No files in the source folder";
                FilteredCountLabel.Text = "";
                curFileName = "";
            }
            else if(CurFileExists())
            {
                comboBox1.SelectedItem = curFileName;
            }
            else
            {
                comboBox1.Text = "Select a File";
                curFileName = "";
            }
        }

        //Make the loading label empty
        private void LoadingIncomplete()
        {
            if (IsHandleCreated)
            {
                LoadingLabel.BeginInvoke(() =>
                {
                    LoadingLabel.Visible= false;
                });
            }
            else
            {
                LoadingLabel.Visible = false;
            }
           
        }

        //Showing the loading completed message and the time taken
        private void LoadingComplete()
        {
            if (IsHandleCreated)
            {
                LoadingLabel.BeginInvoke(() =>
                {                    
                    LoadingLabel.Text = $"Loading Completed: {sw.ElapsedMilliseconds.ToString()} ms";
                    LoadingLabel.Visible = true;
                });
            }
            else
            {
                LoadingLabel.Text = $"Loading Completed: {sw.ElapsedMilliseconds.ToString()} ms";
                LoadingLabel.Visible = true;
            }
        }

        //When clicked, partial matched logs are shown 
        private void ShowPartial_Click(object sender, EventArgs e)
        {
            WaitCursor(true);
            sw.Reset();
            sw.Start();
            FilteredLogs.Lines = filteredLogs.Split("\n");
            
            FilteredCountLabel.Text = $"Matching Logs: {logFile.matchedShownNum}\nTotal Number of Logs Read: {logFile.totalLogsNum}";
            sw.Stop();
            ShowPartial.Visible = false;
            LoadingComplete();
            WaitCursor(false);
        }

        //make the cursor at a wating state
        private void WaitCursor(bool waiting)
        {
            if (waiting)
            {
                Cursor.Current = Cursors.WaitCursor;
            }
            else
            {
                Cursor.Current = Cursors.Default;
            }

        }

        //Whenever the content changes in a textbox, the loading label becomes empty in order to avoid confusion
        private void Filter1A_TextChanged(object sender, EventArgs e)
        {
            LoadingIncomplete();
        }

        private void Filter1B_TextChanged(object sender, EventArgs e)
        {
            LoadingIncomplete();
        }

        private void Filter1C_TextChanged(object sender, EventArgs e)
        {
            LoadingIncomplete();
        }

        private void Filter2A_TextChanged(object sender, EventArgs e)
        {
            LoadingIncomplete();
        }

        private void Filter2B_TextChanged(object sender, EventArgs e)
        {
            LoadingIncomplete();
        }

        private void Filter2C_TextChanged(object sender, EventArgs e)
        {
            LoadingIncomplete();
        }

        private void GetMaxMatchedNum()
        {
            int num = 0;
            try
            {
                bool isNumeric = int.TryParse(MatchedNumText.Text.ToString(), out num);
                if (isNumeric)
                {
                    this.maxMatchedNum = num;
                    
                }
                else if(String.IsNullOrEmpty(MatchedNumText.Text.ToString()))
                {
                    this.maxMatchedNum = int.MaxValue;
                }
                else
                {
                    MessageBox.Show("The maximum number of matched logs entered is invalid");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("The maximum number of matched logs entered is invalid");
            }
            
           
        }
    }
}