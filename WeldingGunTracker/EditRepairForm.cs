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
    public partial class EditRepairForm : Form
    {

        public EditRepairForm(int csvIndexPass, Repair repairPass)
        {
            InitializeComponent();

            //setting repair to repair pass in if the repair is old
            if (csvIndexPass != -1)
            {
                repair = repairPass;

                //load from edit
                serialDropdown.Text = repair.gunSerial;
            }

            csvIndex = csvIndexPass;
        }

        string repairCSV = Path.Combine(System.Windows.Forms.Application.StartupPath, "Data", "repairs.csv");
        string tempRepairCSV = Path.Combine(System.Windows.Forms.Application.StartupPath, "Data", "temp_repairs.csv");
        string dropdownsCSV = Path.Combine(System.Windows.Forms.Application.StartupPath, "Data", "dropdowns.csv");

        string prevParts = "";
        string prevSerial = "";
        string prevProblem = "";
        string prevFix = "";

        //keeps track of a class for changing 
        Repair repair = new Repair();
        int csvIndex;

        private void confirmRepair_Click(object sender, EventArgs e)
        {         
            //add to end if not editing
            if (csvIndex == -1)
            {
                File.AppendAllText(repairCSV, repair.date + "," + repair.gunSerial + "," + repair.repairers + "," + repair.problems + "," + repair.fixes + "," + repair.parts);
                File.AppendAllText(repairCSV, Environment.NewLine);
            }
            else
            {
                //copy all lines to a temporary file
                string[] repairCSVLines = File.ReadAllLines(repairCSV);

                File.Delete(tempRepairCSV);

                for (int i = 0; i < repairCSVLines.Length; i++)
                {
                    if (i == csvIndex)
                    {
                        File.AppendAllText(tempRepairCSV, repair.date + "," + repair.gunSerial + "," + repair.repairers + "," + repair.problems + "," + repair.fixes + "," + repair.parts);
                        File.AppendAllText(tempRepairCSV, Environment.NewLine);
                    }
                    else
                    {
                        File.AppendAllText(tempRepairCSV, repairCSVLines[i]);
                        File.AppendAllText(tempRepairCSV, Environment.NewLine);
                    }
                }

                //copy back
                File.Delete(repairCSV);
                File.Copy(tempRepairCSV, repairCSV);
            }

            //switch window
            this.Hide();
            MainForm nf = new MainForm();
            nf.ShowDialog();
            this.Close();
        }

        private void cancelRepair_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm nf = new MainForm();
            nf.ShowDialog();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //load dropdowns
            string[] dropdownsCSVLines = File.ReadAllLines(dropdownsCSV); //split also works ('\n')

            string[] words;

            //repairer name
            words = dropdownsCSVLines[0].Split(',');
            foreach(string word in words)
            {
                serialDropdown.Items.Add(word);
            }

            //serial
            words = dropdownsCSVLines[1].Split(',');
            foreach (string word in words)
            {
                repairersDropdown.Items.Add(word);
            }

            //problems
            words = dropdownsCSVLines[2].Split(',');
            foreach (string word in words)
            {
                problemDropdown.Items.Add(word);
            }

            //fixes
            words = dropdownsCSVLines[3].Split(',');
            foreach (string word in words)
            {
                fixDropdown.Items.Add(word);
            }

            //fixes
            words = dropdownsCSVLines[5].Split(',');
            foreach (string word in words)
            {
                partsDropdown.Items.Add(word);
            }

            //reset the class if repair is new (not edited)
            if (csvIndex == -1)
            {
                repair.gunSerial = "";
                repair.repairers = "";
                repair.problems = "";
                repair.fixes = "";
                repair.parts = "";
            }

            //update date regardless of edit or not
            repair.date = DateTime.Now.ToString();

            repairPreview.Items[0] = repair.date;
            repairPreview.Items[1] = repair.gunSerial;
            repairPreview.Items[2] = repair.repairers;
            repairPreview.Items[3] = repair.problems;
            repairPreview.Items[4] = repair.fixes;
            repairPreview.Items[5] = repair.parts;
        }

        //when a preset value is chosen
        private void serialDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            repair.gunSerial = serialDropdown.Text;
            repairPreview.Items[1] = repair.gunSerial;
        }

        private void repairersDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (repair.repairers != "")
                repair.repairers += " + ";

            repair.repairers += repairersDropdown.Text;
            repairPreview.Items[2] = repair.repairers;
        }

        private void problemDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (repair.problems != "")
                repair.problems += " + ";

            repair.problems += problemDropdown.Text;
            repairPreview.Items[3] = repair.problems;
        }

        private void fixDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (repair.fixes != "")
                repair.fixes += " + ";

            repair.fixes += fixDropdown.Text;
            repairPreview.Items[4] = repair.fixes;
        }

        //when parts are edited
        private void partsDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (repair.parts != "")
                repair.parts += " + ";

            repair.parts += partsDropdown.Text;
            repairPreview.Items[5] = repair.parts;
        }

        //when custom text is entered
        private void serialDropdown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                repair.gunSerial = serialDropdown.Text;
                repairPreview.Items[1] = repair.gunSerial;
            }
        }

        private void repairersDropdown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                if (repair.repairers != "")
                    repair.repairers += " + ";

                repair.repairers += repairersDropdown.Text;
                repairPreview.Items[2] = repair.repairers;
            }
        }

        private void problemDropdown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                if (repair.problems != "")
                    repair.problems += " + ";

                repair.problems += problemDropdown.Text;
                repairPreview.Items[3] = repair.problems;
            }
        }

        private void fixDropdown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                if (repair.fixes != "")
                    repair.fixes += " + ";

                repair.fixes += fixDropdown.Text;
                repairPreview.Items[4] = repair.fixes;
            }
        }
        private void partsDropdown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                if (repair.parts != "")
                    repair.parts += " + ";

                repair.parts += partsDropdown.Text;
                repairPreview.Items[5] = repair.parts;
            }
        }


        //CLEARS

        private void clearRepairerButton_Click(object sender, EventArgs e)
        {
            repairersDropdown.ResetText();

            repair.repairers = "";
            repairPreview.Items[2] = "";
        }

        private void clearProblemButton_Click(object sender, EventArgs e)
        {
            problemDropdown.ResetText();

            repair.problems = "";
            repairPreview.Items[3] = "";
        }

        private void clearFixButton_Click(object sender, EventArgs e)
        {
            fixDropdown.ResetText();

            repair.fixes = "";
            repairPreview.Items[4] = "";
        }

        private void clearPartsButton_Click(object sender, EventArgs e)
        {
            partsDropdown.ResetText();

            repair.parts = "";
            repairPreview.Items[5] = "";
        }

        private void serialDropdown_TextChanged(object sender, EventArgs e)
        {
            //must not allow entering commas
            try
            {
                if (serialDropdown.Text.Contains(",") || serialDropdown.Text.Contains("\n"))
                {
                    //revert to previous
                    serialDropdown.Text = prevSerial;
                    serialDropdown.Select(serialDropdown.Text.Length, 0);
                }
            }
            catch { }

            //set previous when text is updated
            prevSerial = serialDropdown.Text;
        }

        private void repairersDropdown_TextChanged(object sender, EventArgs e)
        {
            //must not allow entering commas
            try
            {
                if (repairersDropdown.Text.Contains(",") || repairersDropdown.Text.Contains("\n"))
                {
                    //revert to previous
                    repairersDropdown.Text = prevSerial;
                    repairersDropdown.Select(repairersDropdown.Text.Length, 0);
                }
            }
            catch { }

            //set previous when text is updated
            prevSerial = repairersDropdown.Text;
        }

        private void problemDropdown_TextChanged(object sender, EventArgs e)
        {
            //must not allow entering commas
            try
            {
                if (problemDropdown.Text.Contains(",") || problemDropdown.Text.Contains("\n"))
                {
                    //revert to previous
                    problemDropdown.Text = prevProblem;
                    problemDropdown.Select(problemDropdown.Text.Length, 0);
                }
            }
            catch { }

            //set previous when text is updated
            prevProblem = problemDropdown.Text;
        }

        private void fixDropdown_TextChanged(object sender, EventArgs e)
        {
            //must not allow entering commas
            try
            {
                if (fixDropdown.Text.Contains(",") || fixDropdown.Text.Contains("\n"))
                {
                    //revert to previous
                    fixDropdown.Text = prevFix;
                    fixDropdown.Select(fixDropdown.Text.Length, 0);
                }
            }
            catch { }

            //set previous when text is updated
            prevFix = fixDropdown.Text;
        }

        private void partsDropdown_TextChanged(object sender, EventArgs e)
        {
            //must not allow entering commas
            try
            {
                if (partsDropdown.Text.Contains(",") || partsDropdown.Text.Contains("\n"))
                {
                    //revert to previous
                    partsDropdown.Text = prevParts;
                    partsDropdown.Select(partsDropdown.Text.Length, 0);
                }
            }
            catch { }

            //set previous when text is updated
            prevParts = partsDropdown.Text;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(csvIndex == -1) //not editing (new)
            {
                this.Hide();
                MainForm nf = new MainForm();
                nf.ShowDialog();
                this.Close();
            }
            else //editing
            {
                MainForm.DeleteLine(repairCSV, csvIndex);

                this.Hide();
                MainForm nf = new MainForm();
                nf.ShowDialog();
                this.Close();
            }
        }

        public void AddPart(string part)
        {
            if (repair.parts != "")
                repair.parts += " + ";

            repair.parts += part;
            repairPreview.Items[5] = repair.parts;
        }

        //parts buttons
        private void button1_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button28_Click(object sender, EventArgs e)
        {
           AddPart((sender as Button).Text);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);

        }

        private void button43_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button51_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button49_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button53_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button54_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button55_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button56_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button57_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button58_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button59_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button60_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button61_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button62_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button63_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button64_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button65_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button67_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button66_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            AddPart((sender as Button).Text);
        }
    }
}
