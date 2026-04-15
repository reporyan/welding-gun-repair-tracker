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
    public partial class SettingsForm : Form
    {     
        public SettingsForm()
        {
            InitializeComponent();

            SetSettings();

            settingsCSVLines = File.ReadAllLines(settingsCSV);

            //saving tab
            string[] words = settingsCSVLines[5].Split(',');
            mainTabControl.SelectedIndex = Convert.ToInt32(words[0]);
        }

        string settingsCSV = Path.Combine(System.Windows.Forms.Application.StartupPath, "Data", "settings.csv");
        string[] settingsCSVLines;

        string dropdownsCSV = Path.Combine(System.Windows.Forms.Application.StartupPath, "Data", "dropdowns.csv");
        string[] dropdownsCSVLines;

        string defaultSettingsCSV = Path.Combine(System.Windows.Forms.Application.StartupPath, "Data", "default_settings.csv");
        string[] defaultSettingsCSVLines;


        string repairsCSV = Path.Combine(System.Windows.Forms.Application.StartupPath, "Data", "repairs.csv");
        string[] repairsCSVLines;

        string gunsCSV = Path.Combine(System.Windows.Forms.Application.StartupPath, "Data", "guns.csv");
        string[] gunsCSVLines;


        public static int repairCounterIndicator; // I dont like defining it like this, might change later
        public static int fontSize = 12;
        public static string repairCounterIndicatorIterationSymbol = "[] ";

        string prevDropdowns = "";

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm nf = new MainForm();
            nf.ShowDialog();
            this.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            repairCounterIndicator = repairCounterIndicatorDropdown.SelectedIndex;
            MainForm.ReplaceLine(settingsCSV, 1, repairCounterIndicator.ToString());

            fontSize = Convert.ToInt32(textSizeDropdown.Text);
            MainForm.ReplaceLine(settingsCSV, 2, fontSize.ToString());

            repairCounterIndicatorIterationSymbol = repairCounterIterationDropdown.Text;
            MainForm.ReplaceLine(settingsCSV, 3, repairCounterIndicatorIterationSymbol);

            this.Hide();
            MainForm nf = new MainForm();
            nf.ShowDialog();
            this.Close();
        }

        private void defaultsButton_Click(object sender, EventArgs e)
        {
            File.Delete(settingsCSV);
            File.Copy(defaultSettingsCSV, settingsCSV);

            SetSettings();
        }

        private void textSizeDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            //only have a function on this because of the sample
            Font font = new Font("Microsoft Sans Serif", Convert.ToInt32(textSizeDropdown.Text));
            sampleList.Font = font;
        }

        public void SetSettings()
        {
            settingsCSVLines = File.ReadAllLines(settingsCSV);

            //set dropdown selected indexes

            //repair counter indicator
            string[] words = settingsCSVLines[1].Split(',');
            repairCounterIndicatorDropdown.SelectedIndex = Convert.ToInt32(words[0]);
            repairCounterIndicator = Convert.ToInt32(words[0]);

            //font size
            words = settingsCSVLines[2].Split(',');
            textSizeDropdown.Text = words[0];
            fontSize = Convert.ToInt32(words[0]);

            //rci iteration
            words = settingsCSVLines[3].Split(',');
            repairCounterIterationDropdown.Text = words[0];
            repairCounterIndicatorIterationSymbol = words[0];

            //statistics

            repairCountLabel.Text = File.ReadAllLines(repairsCSV).Count().ToString();
            gunCountLabel.Text = File.ReadAllLines(gunsCSV).Count().ToString();

            words = settingsCSVLines[4].Split(',');
            costPerRepairNumeric.Value = Convert.ToDecimal(words[0]);
            totalCostLabel.Text = Math.Round(Convert.ToInt32(repairCountLabel.Text) * costPerRepairNumeric.Value, 2).ToString();
        }

        private void dropdownsDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            dropdownsCSVLines = File.ReadAllLines(dropdownsCSV);
            dropdownsBox.Text = dropdownsCSVLines[dropdownsDropdown.SelectedIndex];
        }

        private void setDropdownButton_Click(object sender, EventArgs e)
        {
            MainForm.ReplaceLine(dropdownsCSV, dropdownsDropdown.SelectedIndex, dropdownsBox.Text);

            MessageBox.Show("Change Successful");
        }

        private void dropdownsBox_TextChanged(object sender, EventArgs e)
        {
            //must not allow entering commas
            try
            {
                if (dropdownsBox.Text.Contains("\n"))
                {
                    //revert to previous
                    dropdownsBox.Text = prevDropdowns;
                    dropdownsBox.Select(dropdownsBox.Text.Length, 0);
                }
            }
            catch { }

            //set previous when text is updated
            prevDropdowns = dropdownsBox.Text;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            totalCostLabel.Text = Math.Round(Convert.ToInt32(repairCountLabel.Text) * costPerRepairNumeric.Value, 2).ToString();
            MainForm.ReplaceLine(settingsCSV, 4, costPerRepairNumeric.Value.ToString());
        }

        private void mainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainForm.ReplaceLine(settingsCSV, 5, mainTabControl.SelectedIndex.ToString());
        }
    }
}
