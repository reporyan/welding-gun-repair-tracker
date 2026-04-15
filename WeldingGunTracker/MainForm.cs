using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace WeldingGunTracker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            //sets all settings variables before program begins

            settingsCSVLines = File.ReadAllLines(settingsCSV);

            //repair counter indicator
            string[] words = settingsCSVLines[1].Split(',');
            SettingsForm.repairCounterIndicator = Convert.ToInt32(words[0]);

            //font size
            words = settingsCSVLines[2].Split(',');
            SettingsForm.fontSize = Convert.ToInt32(words[0]);

            //initialize
            InitializeComponent();
        }

        string repairCSV = Path.Combine(System.Windows.Forms.Application.StartupPath, "Data", "repairs.csv");
        string[] repairCSVLines;

        string gunCSV = Path.Combine(System.Windows.Forms.Application.StartupPath, "Data", "guns.csv");
        string[] gunCSVLines;

        static string tempRepairCSV = Path.Combine(System.Windows.Forms.Application.StartupPath, "Data", "temp_repairs.csv");
        string[] tempRepairCSVLines;

        string settingsCSV = Path.Combine(System.Windows.Forms.Application.StartupPath, "Data", "settings.csv");
        string[] settingsCSVLines;


        private void addRepairButton_Click(object sender, EventArgs e)
        {
            //switch window
            this.Hide();
            EditRepairForm nf = new EditRepairForm(-1, null);
            nf.ShowDialog();
            this.Close();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            ReloadLists();

            settingsCSVLines = File.ReadAllLines(settingsCSV);

            //saving tab
            string[] words = settingsCSVLines[0].Split(',');
            mainTabControl.SelectedIndex = Convert.ToInt32(words[0]);
        }

        public void ReloadLists()
        {
            //Set font sizes

            Font font = new Font("Microsoft Sans Serif", SettingsForm.fontSize);
            repairsList.Font = font;
            gunsList.Font = font;
            graveyardList.Font = font;

            //Clear lists
            repairsList.Items.Clear();
            gunsList.Items.Clear();
            graveyardList.Items.Clear();

            //Load csv for REPAIRS
            repairCSVLines = File.ReadAllLines(repairCSV);

            foreach (string line in repairCSVLines)
            {
                //filtering
                if (line.Contains(searchBox.Text) && line.Contains(filterDropdown.Text) || (line.Contains(searchBox.Text) && filterDropdown.SelectedIndex == 0))
                {
                    string[] words = line.Split(',');

                    //uses date as name, and displays everything else
                    ListViewItem item = new ListViewItem(words[0]);
                    item.SubItems.Add(words[1]);
                    item.SubItems.Add(words[2]);
                    item.SubItems.Add(words[3]);
                    item.SubItems.Add(words[4]);
                    item.SubItems.Add(words[5]);

                    repairsList.Items.Add(item);
                }
            }

            //Load csv for GUNS
            gunCSVLines = File.ReadAllLines(gunCSV);

            int i = 0;
            foreach (string line in gunCSVLines)
            {
                //filtering
                if (line.Contains(searchBox.Text) && line.Contains(filterDropdown.Text) || (line.Contains(searchBox.Text) && filterDropdown.SelectedIndex == 0))
                {
                    string[] words = line.Split(',');

                    //uses date as name, and displays everything else
                    ListViewItem item = new ListViewItem(words[0]);

                    //iterate through repairs //NOT WORKING
                    int repairCount = 0;

                    foreach (string repLine in repairCSVLines)
                    {
                        string[] repWords = repLine.Split(',');

                        if (repWords[1] == words[0].ToString())
                        {
                            //count repairs
                            repairCount++;
                        }
                    }

                    if (SettingsForm.repairCounterIndicator == 0)
                    {
                        item.SubItems.Add(repairCount.ToString());
                    }
                    else if (SettingsForm.repairCounterIndicator == 1)
                    {
                        string visual = "";
                        for (int j = 0; j < repairCount; j++)
                        {
                            visual += SettingsForm.repairCounterIndicatorIterationSymbol;
                        }

                        item.SubItems.Add(visual);
                    }

                    item.SubItems.Add(words[1]);
                    item.SubItems.Add(words[2]);
                    item.SubItems.Add(words[3]);

                    if (words[1] == "Graveyard")
                    {
                        graveyardList.Items.Add(item);
                    }
                    else
                    {
                        gunsList.Items.Add(item);
                    }
                }

                i++;
            }
        }

        private void repairsList_MouseClick(object sender, MouseEventArgs e)
        {
            //when the list view is clicked
            if(e.Button == MouseButtons.Left)
            {
                if (repairsList.FocusedItem != null && repairsList.FocusedItem.Bounds.Contains(e.Location))
                {
                    //create repair from listviewitem
                    Repair repair = new Repair();
                    repair.date = repairsList.FocusedItem.Text;
                    repair.gunSerial = repairsList.FocusedItem.SubItems[1].Text;
                    repair.repairers = repairsList.FocusedItem.SubItems[2].Text;
                    repair.problems = repairsList.FocusedItem.SubItems[3].Text;
                    repair.fixes = repairsList.FocusedItem.SubItems[4].Text;
                    repair.parts = repairsList.FocusedItem.SubItems[5].Text;

                    //switch window with repair data
                    this.Hide();
                    EditRepairForm nf = new EditRepairForm(repairsList.FocusedItem.Index, repair);
                    nf.ShowDialog();
                    this.Close();
                }
            }
        }

        private void gunsList_MouseClick(object sender, MouseEventArgs e)
        {
            //when the list view is clicked
            if (e.Button == MouseButtons.Left)
            {
                if (gunsList.FocusedItem != null && gunsList.FocusedItem.Bounds.Contains(e.Location))
                {
                    //create repair from listviewitem
                    Gun gun = new Gun();
                    gun.serial = gunsList.FocusedItem.Text;
                    gun.condition = gunsList.FocusedItem.SubItems[2].Text;
                    gun.notes = gunsList.FocusedItem.SubItems[3].Text;
                    gun.dateCreated = gunsList.FocusedItem.SubItems[4].Text;

                    //switch window with repair data
                    this.Hide();
                    EditGunForm nf = new EditGunForm(gunsList.FocusedItem.Index, gun);
                    nf.ShowDialog();
                    this.Close();
                }
            }
        }

        private void graveyardList_MouseClick(object sender, MouseEventArgs e)
        {
            //when the list view is clicked
            if (e.Button == MouseButtons.Left)
            {
                if (graveyardList.FocusedItem != null && graveyardList.FocusedItem.Bounds.Contains(e.Location))
                {
                    //create repair from listviewitem
                    Gun gun = new Gun();
                    gun.serial = graveyardList.FocusedItem.Text;
                    gun.condition = graveyardList.FocusedItem.SubItems[2].Text;
                    gun.notes = graveyardList.FocusedItem.SubItems[3].Text;
                    gun.dateCreated = graveyardList.FocusedItem.SubItems[4].Text;

                    //switch window with repair data
                    this.Hide();
                    EditGunForm nf = new EditGunForm(graveyardList.FocusedItem.Index, gun);
                    nf.ShowDialog();
                    this.Close();
                }
            }
        }


        private void eraseCSVButton_Click(object sender, EventArgs e)
        {
            File.Delete(repairCSV);
            File.Delete(gunCSV);
        }

        private void addGunButton_Click(object sender, EventArgs e)
        {
            //switch window
            this.Hide();
            EditGunForm nf = new EditGunForm(-1, null);
            nf.ShowDialog();
            this.Close();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            ReloadLists();
        }

        private void filterDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadLists();
        }

        private void sortDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(sortDropdown.SelectedIndex == 0)
            {
                repairsList.Sorting = SortOrder.None;
                gunsList.Sorting = SortOrder.None;
            }
            else if(sortDropdown.SelectedIndex == 1)
            {
                repairsList.Sorting = SortOrder.Descending;
                gunsList.Sorting = SortOrder.Descending;
            }
            else if (sortDropdown.SelectedIndex == 2)
            {
                repairsList.Sorting = SortOrder.Ascending;
                gunsList.Sorting = SortOrder.Ascending;
            }

            ReloadLists();
        }

        private void mainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReplaceLine(settingsCSV, 0, mainTabControl.SelectedIndex.ToString());
        }

        public static void ReplaceLine(string file, int index, string text)
        {
            //copy all lines to a temporary file
            string[] lines = File.ReadAllLines(file);

            File.Delete(tempRepairCSV);

            for (int i = 0; i < lines.Length; i++)
            {
                if (i == index)
                {
                    File.AppendAllText(tempRepairCSV, text);
                    File.AppendAllText(tempRepairCSV, Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(tempRepairCSV, lines[i]);
                    File.AppendAllText(tempRepairCSV, Environment.NewLine);
                }
            }

            //copy back
            File.Delete(file);
            File.Copy(tempRepairCSV, file);
        }

        public static void DeleteLine(string file, int index)
        {
            //copy all lines to a temporary file
            string[] lines = File.ReadAllLines(file);

            File.Delete(tempRepairCSV);

            for (int i = 0; i < lines.Length; i++)
            {
                if (i != index)
                {
                    File.AppendAllText(tempRepairCSV, lines[i]);
                    File.AppendAllText(tempRepairCSV, Environment.NewLine);
                }
            }

            //copy back
            File.Delete(file);
            File.Copy(tempRepairCSV, file);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SettingsForm nf = new SettingsForm();
            nf.ShowDialog();
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string print = "";

            repairCSVLines = File.ReadAllLines(repairCSV);

            foreach(string line in repairCSVLines)
            {
                string[] words = line.Split(',');

                foreach(string word in words)
                {
                    print = print + word + Environment.NewLine;
                }

                print = print + Environment.NewLine;
            }

            e.Graphics.DrawString(print, new Font("Times New Romans", 10), Brushes.Black, new PointF(60, 60));
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }

    public class Repair
    {
        public string notes;
        public string date;
        public string repairers;
        public string gunSerial;
        public string problems;
        public string fixes;
        public string parts;
    }

    public class Gun
    {
        public string serial;
        public string condition;
        public string notes;
        public string dateCreated;
        public int repairCount;
    }
}
