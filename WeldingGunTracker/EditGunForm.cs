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

namespace WeldingGunTracker
{
    public partial class EditGunForm : Form
    {
        public EditGunForm(int csvIndexPass, Gun gunPass)
        {
            InitializeComponent();

            //setting repair to repair pass in if the repair is old
            if (csvIndexPass != -1)
            {
                gun = gunPass;

                //load dropdown from edit2
                serialBox.Text = gun.serial;
                conditionDropdown.Text = gun.condition;

                gunCalender.SelectionStart = Convert.ToDateTime(gun.dateCreated);
                gunCalender.SelectionEnd = Convert.ToDateTime(gun.dateCreated);

                notesBox.Text = gun.notes;

                //displaying repair count after repar calculation is done
            }
            else
            {
                //new
                gunCalender.SelectionStart = DateTime.Now;
                gunCalender.SelectionEnd = DateTime.Now;

                repairCountLabel.Text = "0"; //may change later
            }

            csvIndex = csvIndexPass;

            //LOAD HISTORY

            string[] repairCSVLines = File.ReadAllLines(repairCSV);

            gun.repairCount = 0;

            foreach (string line in repairCSVLines)
            {
                string[] words = line.Split(',');

                if(words[1] == gun.serial)
                {
                    //uses date as name, and displays everything else
                    ListViewItem item = new ListViewItem(words[0]);
                    //item.SubItems.Add(words[1]); //we don't need repair serial
                    item.SubItems.Add(words[2]);
                    item.SubItems.Add(words[3]);
                    item.SubItems.Add(words[4]);
                    item.SubItems.Add(words[5]);

                    gunRepairsList.Items.Add(item);

                    //count repairs
                    gun.repairCount++;
                }        
            }

            repairCountLabel.Text = gun.repairCount.ToString();

            //load dropdowns
            string[] dropdownsCSVLines = File.ReadAllLines(dropdownsCSV); //split also works ('\n')

            //condition
            string[] dropWords = dropdownsCSVLines[4].Split(',');

            foreach (string word in dropWords)
            {
                conditionDropdown.Items.Add(word);
            }
        }

        string gunsCSV = Path.Combine(System.Windows.Forms.Application.StartupPath, "Data", "guns.csv");
        string repairCSV = Path.Combine(System.Windows.Forms.Application.StartupPath, "Data", "repairs.csv");
        string tempRepairCSV = Path.Combine(System.Windows.Forms.Application.StartupPath, "Data", "temp_repairs.csv");
        string dropdownsCSV = Path.Combine(System.Windows.Forms.Application.StartupPath, "Data", "dropdowns.csv");

        string prevSerial = "";
        string prevCondition = "";
        string prevNotes = "";

        //keeps track of a class for changing 
        Gun gun = new Gun();
        int csvIndex;

        private void confirmGun_Click(object sender, EventArgs e)
        {
            //add to end if not editing
            if (csvIndex == -1)
            {
                File.AppendAllText(gunsCSV, serialBox.Text + "," + conditionDropdown.Text + "," + notesBox.Text + "," + gunCalender.SelectionStart.ToShortDateString() + "," + gun.repairCount); //parsing straight from inputs
                File.AppendAllText(gunsCSV, Environment.NewLine);
            }
            else
            {
                //copy all lines to a temporary file
                string[] gunsCSVLines = File.ReadAllLines(gunsCSV);

                File.Delete(tempRepairCSV);

                for (int i = 0; i < gunsCSVLines.Length; i++)
                {
                    if (i == csvIndex)
                    {
                        File.AppendAllText(tempRepairCSV, serialBox.Text + "," + conditionDropdown.Text + "," + notesBox.Text + "," + gunCalender.SelectionStart.ToShortDateString() + "," + gun.repairCount); //use gun.repairCount because it works differently (can't be altered by user)
                        File.AppendAllText(tempRepairCSV, Environment.NewLine);
                    }
                    else
                    {
                        File.AppendAllText(tempRepairCSV, gunsCSVLines[i]);
                        File.AppendAllText(tempRepairCSV, Environment.NewLine);
                    }
                }

                //copy back
                File.Delete(gunsCSV);
                File.Copy(tempRepairCSV, gunsCSV);
            }

            //switch window
            this.Hide();
            MainForm nf = new MainForm();
            nf.ShowDialog();
            this.Close();
        }

        private void cancelGun_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm nf = new MainForm();
            nf.ShowDialog();
            this.Close();
        }

        private void serialBox_TextChanged(object sender, EventArgs e)
        {
            //must not allow entering commas
            try
            {
                if (serialBox.Text.Contains(",") || serialBox.Text.Contains("\n"))
                {
                    //revert to previous
                    serialBox.Text = prevSerial;
                    serialBox.Select(serialBox.Text.Length, 0);
                }
            }
            catch { }

            //set previous when text is updated
            prevSerial = serialBox.Text;
        }

        private void conditionDropdown_TextChanged(object sender, EventArgs e)
        {
            //must not allow entering commas
            try
            {
                if (conditionDropdown.Text.Contains(",") || conditionDropdown.Text.Contains("\n"))
                {
                    //revert to previous
                    conditionDropdown.Text = prevCondition;
                    conditionDropdown.Select(conditionDropdown.Text.Length, 0);
                }
            }
            catch { }

            //set previous when text is updated
            prevCondition = conditionDropdown.Text;
        }

        private void notesBox_TextChanged(object sender, EventArgs e)
        {
            //must not allow entering commas
            try
            {
                if (notesBox.Text.Contains(",") || notesBox.Text.Contains("\n"))
                {
                    //revert to previous
                    notesBox.Text = prevNotes;
                    notesBox.Select(notesBox.Text.Length, 0);
                }
            }
            catch { }

            //set previous when text is updated
            prevNotes = notesBox.Text;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            MainForm.DeleteLine(gunsCSV, csvIndex);

            this.Hide();
            MainForm nf = new MainForm();
            nf.ShowDialog();
            this.Close();
        }
    }
}
