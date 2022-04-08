using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sensei
{
    public partial class Main : Form
    {
        // this is just initializing, ignore
        public Main() { InitializeComponent(); }

        // build version, used for display
        public static string softwareVersion = "2";

        // ### imported windows functions
        // this can minimize or show window, used for loading queues
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        // vector used for keeping locations and for calculative functions 
        [StructLayout(LayoutKind.Sequential)]
        public struct Vector2 { public int x; public int y; }

        // gets x/y location into a Vector2 object
        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hwnd, ref Vector2 rectangle);

        // used for changing position of a window
        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);

        // used for ShowWindow function as second argument
        const int SW_SHOWMINIMIZED = 2;
        const int SW_SHOWNORMAL = 1;

        // default window size, used to reset window easier
        Size defaultWindowSize = new Size(286, 182);

        // global process list, it's global because some functions need
        // this and they are externall callers that I can't pass arguments to
        Process[] processList;

        // path where all INF files are stored
        string configFilesPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
            "\\fl-wer\\Sensei\\";

        // information file names, these are files that store all
        // kind of information and are saved in software default folder in variable below
        // all those files will have "INF" at the end so you know these
        public static string alwaysOnTopINF = "p44gz4";
        public static string lastProcessNameINF = "5gf1mv";
        public static string windowsLocationINF = "cwxife";

        // running on startup
        private void Form1_Load(object sender, EventArgs e)
        {
            // disable north korean thread control
            CheckForIllegalCrossThreadCalls = false;

            // make sure config files (INF) folder exists, if not make it
            if (!Directory.Exists(configFilesPath))
                Directory.CreateDirectory(configFilesPath);

            // load all saved settings
            loadSettings();
        }

        // adjust window height based on calculated queue quantity
        private void calculateQueues_Click(object sender, EventArgs e)
        {
            // get all processes
            processList = Process.GetProcessesByName(processNameTextBox.Text);

            // calculate queue quantity
            int queueQuantity = getQueueQuantity();

            // do some process validation checks
            if (processList.Length == 0) ShowError("Process not running.");
            else if (processList.Length < 2) ShowError("At least two process instances required.");
            else if (queueQuantity < 1) ShowError("At least 1 queue required, change your settings.");
            else if (queueQuantity > 8) ShowError("Queue limit of 8 reached, change your settings.");

            // validation passed, adjusting windows height
            else Size = calculateWindowSize(queueQuantity);

            // save last used process to INF (settings)
            File.WriteAllText(configFilesPath + lastProcessNameINF, processNameTextBox.Text);
        }

        // hide all windows and show only selected queue
        void loadQueue(object sender, EventArgs e)
        {
            // getting button object that was used to invoke this
            Button clickedButton = sender as Button;

            // parsing button text for shortening code, they all have number as text
            // with this we don't have to use 8 ifs
            int parseQueueNumber = Convert.ToInt32(clickedButton.Text);

            // minimize all windows, clear the view before doing anything
            foreach (Process proc in processList)
                ShowWindow(proc.MainWindowHandle, SW_SHOWMINIMIZED);

            // converting numeric value from control for performance / readability
            int perQueue = (int)perQueueNumeric.Value;

            // we start from the queue we clicked on, queue number * items per queue
            for (int i = perQueue * (parseQueueNumber - 1); i < perQueue * parseQueueNumber; i++)
                // making sure we're not exceeding process array, eg would be someone
                // closing the process and then trying to load the queue, break if so
                if (i < processList.Length) ShowWindow(processList[i].MainWindowHandle, SW_SHOWNORMAL);
                else break;
        }

        // this returns windows size with changed height to reveal hidden
        // queue buttons, based on how many process and per queue are set
        Size calculateWindowSize(int queueQuantity)
        {
            // ### calculate window size
            // if one queue only we can then used preset size
            if (queueQuantity == 1) return new Size(286, 246); // 294 = 2 queues

            // if more than 1 queue we need to calculate, 47 is based on controls location
            // which was set when I was designing the form
            else if (queueQuantity > 1) return new Size(286, 246 + ((queueQuantity - 1) * 47));

            // if queue quantity == 0 we're returning default window size
            else return defaultWindowSize;
        }

        // calculated amount of queues
        int getQueueQuantity()
        {
            // diving per queue 
            int queueQuantity = (processList.Length / (int)perQueueNumeric.Value);

            // if there are more process it means that the number wasn't integer
            // and also wasn't rounded up, eg processes = 7, per queue = 3, meaning
            // there will be 1 process left (7/2 = 6, 7-6 = 1) so 3 queues are required, not 2
            if (queueQuantity * (int)perQueueNumeric.Value < processList.Length) queueQuantity += 1;

            // return final result
            return queueQuantity;
        }

        // load saved configuration files (options and settings)
        void loadSettings()
        {
            // always on top
            if (File.Exists(configFilesPath + alwaysOnTopINF))
            {
                // not doing anything if True because True is default
                if (File.ReadAllText(configFilesPath + alwaysOnTopINF) == "False")
                {
                    // changing window property
                    TopMost = false;

                    // adjusting checkbox on context menu strip item for Always On Top
                    ((ToolStripMenuItem)quickSupport.Items[0]).Checked = false;
                }
            }

            // last process name
            if (File.Exists(configFilesPath + lastProcessNameINF))
                processNameTextBox.Text = File.ReadAllText(configFilesPath + lastProcessNameINF);
        }

        // make the window always visiblle, won't minimize if clicked somewhere else
        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // disable / enable TopMost property of the window
            TopMost = !TopMost;

            // based on if TopMost is enabled or not change checkbox accordingly
            ((ToolStripMenuItem)quickSupport.Items[0]).Checked = TopMost;

            // save button to INF (settings), True or False (in text)
            File.WriteAllText(configFilesPath + alwaysOnTopINF, TopMost.ToString());
        }

        // kill all instances of the process
        private void killAllSessionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // go through list of all processess and use Kill function to kill all
            foreach (Process proc in Process.GetProcessesByName(processNameTextBox.Text))
                proc.Kill();
        }

        // minimize all windows for the process
        private void minimizeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // go through list of all processess and use ShowWindow function to minimize all
            foreach (Process proc in Process.GetProcessesByName(processNameTextBox.Text))
                ShowWindow(proc.MainWindowHandle, SW_SHOWMINIMIZED);
        }

        // saves locations of all windows for the used process even when minimized
        private void savePositionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (processList != null && processList.Length != 0)
            {
                // show all windows as function for getting location doesn't work
                // when the window is minimized, it then returns trash number
                foreach (Process proc in processList)
                    ShowWindow(proc.MainWindowHandle, SW_SHOWNORMAL);

                // object that holds x and y
                Vector2 vector = new Vector2();

                // checking if at least one process available
                if (processList.Length != 0)
                {
                    // full string holding all positions line by line
                    string positions = "";

                    // go through all processes and get all windows position
                    foreach (Process proc in processList)
                    {
                        // this saves window x/y location and puts in Vector2 class object
                        GetWindowRect(proc.MainWindowHandle, ref vector);

                        // saving each position with single lines
                        positions += vector.x + " " + vector.y + "\n";
                    }

                    // saving x + y of windows to config file
                    File.WriteAllText(configFilesPath + windowsLocationINF, positions);

                    // minimize all windows for comfort
                    foreach (Process proc in processList)
                        ShowWindow(proc.MainWindowHandle, SW_SHOWMINIMIZED);
                }
                else ShowError("Process not running.");
            }
            else ShowError("Calculate queues first and make sure process is running.");
        }

        // loading positions into open windows in order, if too many positions
        // it will stop on last window, if too many windows it will stop on last position
        private void loadPositionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // making sure queues vere calculated once and there is at least one process running
            if (processList != null && processList.Length != 0)
            {
                // show all windows as function for setting location doesn't work otherwise
                foreach (Process proc in processList)
                    ShowWindow(proc.MainWindowHandle, SW_SHOWNORMAL);

                // making sure config file exists
                if (File.Exists(configFilesPath + windowsLocationINF))
                {
                    // lines that each one of them holds one window location
                    string[] lines = File.ReadAllLines(configFilesPath + windowsLocationINF);

                    // using counter to go through processes, sometimes there might be more positions saved
                    // that there is processes open so we need to make sure we don't go too far with the process array
                    int counter = 0;

                    // check comment above
                    foreach (string line in lines)
                    {
                        // making sure we're not breaching process list array
                        if (counter < processList.Length)
                        {
                            // holders for parsing below
                            int posX, posY;

                            // parsing both position x and position y and checking if went through
                            if (int.TryParse(line.Remove(line.IndexOf(" "), line.Length - line.IndexOf(" ")), out posX) &&
                            int.TryParse(line.Remove(0, line.IndexOf(" ") + 1), out posY))
                                SetWindowPos(processList[counter].MainWindowHandle, 0, posX, posY, 0, 0, 0x0004 | 0x0001 | 0x0040);
                        }
                        else break;

                        // adding 1 to counter for array use
                        counter += 1;
                    }

                    // minimizing windows for user's comfort
                    foreach (Process proc in processList)
                        ShowWindow(proc.MainWindowHandle, SW_SHOWMINIMIZED);

                }
                else ShowError("There's nothing to load.");
            }
            else ShowError("Calculate queues first and make sure process is running.");
        }

        // pre-created message boxes for showing errors or info
        void ShowError(string message) { MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        void ShowInfo(string message) { MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
    }
}
