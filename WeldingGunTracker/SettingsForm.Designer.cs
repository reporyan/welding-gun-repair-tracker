namespace WeldingGunTracker
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Sample123!");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.label2 = new System.Windows.Forms.Label();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.accessibility = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.repairCounterIterationDropdown = new System.Windows.Forms.ComboBox();
            this.sampleList = new System.Windows.Forms.ListView();
            this.sample = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.textSizeDropdown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.repairCounterIndicatorDropdown = new System.Windows.Forms.ComboBox();
            this.defaultsButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.inputs = new System.Windows.Forms.TabPage();
            this.statistics = new System.Windows.Forms.TabPage();
            this.gunCountLabel = new System.Windows.Forms.Label();
            this.repairCountLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.costPerRepairNumeric = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dropdowns = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.setDropdownButton = new System.Windows.Forms.Button();
            this.dropdownsBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dropdownsDropdown = new System.Windows.Forms.ComboBox();
            this.backButton = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.mainTabControl.SuspendLayout();
            this.accessibility.SuspendLayout();
            this.statistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.costPerRepairNumeric)).BeginInit();
            this.dropdowns.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(652, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Settings";
            // 
            // mainTabControl
            // 
            this.mainTabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.mainTabControl.Controls.Add(this.accessibility);
            this.mainTabControl.Controls.Add(this.inputs);
            this.mainTabControl.Controls.Add(this.statistics);
            this.mainTabControl.Controls.Add(this.dropdowns);
            this.mainTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTabControl.ItemSize = new System.Drawing.Size(125, 50);
            this.mainTabControl.Location = new System.Drawing.Point(11, 93);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1404, 652);
            this.mainTabControl.TabIndex = 11;
            this.mainTabControl.SelectedIndexChanged += new System.EventHandler(this.mainTabControl_SelectedIndexChanged);
            // 
            // accessibility
            // 
            this.accessibility.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.accessibility.Controls.Add(this.label4);
            this.accessibility.Controls.Add(this.repairCounterIterationDropdown);
            this.accessibility.Controls.Add(this.sampleList);
            this.accessibility.Controls.Add(this.label3);
            this.accessibility.Controls.Add(this.textSizeDropdown);
            this.accessibility.Controls.Add(this.label1);
            this.accessibility.Controls.Add(this.repairCounterIndicatorDropdown);
            this.accessibility.Controls.Add(this.defaultsButton);
            this.accessibility.Controls.Add(this.confirmButton);
            this.accessibility.Location = new System.Drawing.Point(4, 54);
            this.accessibility.Margin = new System.Windows.Forms.Padding(2);
            this.accessibility.Name = "accessibility";
            this.accessibility.Padding = new System.Windows.Forms.Padding(2);
            this.accessibility.Size = new System.Drawing.Size(1396, 594);
            this.accessibility.TabIndex = 0;
            this.accessibility.Text = "Accessibility";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Repair Counter Iteration";
            // 
            // repairCounterIterationDropdown
            // 
            this.repairCounterIterationDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.repairCounterIterationDropdown.FormattingEnabled = true;
            this.repairCounterIterationDropdown.Items.AddRange(new object[] {
            "[] ",
            "* ",
            "| ",
            "X ",
            "() ",
            "- ",
            "_ ",
            "R "});
            this.repairCounterIterationDropdown.Location = new System.Drawing.Point(31, 166);
            this.repairCounterIterationDropdown.Name = "repairCounterIterationDropdown";
            this.repairCounterIterationDropdown.Size = new System.Drawing.Size(216, 28);
            this.repairCounterIterationDropdown.TabIndex = 9;
            // 
            // sampleList
            // 
            this.sampleList.BackColor = System.Drawing.Color.Black;
            this.sampleList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sample});
            this.sampleList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sampleList.ForeColor = System.Drawing.Color.White;
            this.sampleList.GridLines = true;
            this.sampleList.HideSelection = false;
            this.sampleList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.sampleList.Location = new System.Drawing.Point(31, 300);
            this.sampleList.Margin = new System.Windows.Forms.Padding(2);
            this.sampleList.Name = "sampleList";
            this.sampleList.Size = new System.Drawing.Size(216, 87);
            this.sampleList.TabIndex = 8;
            this.sampleList.UseCompatibleStateImageBehavior = false;
            this.sampleList.View = System.Windows.Forms.View.Details;
            // 
            // sample
            // 
            this.sample.Text = "Sample123!";
            this.sample.Width = 200;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Text Size";
            // 
            // textSizeDropdown
            // 
            this.textSizeDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textSizeDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textSizeDropdown.FormattingEnabled = true;
            this.textSizeDropdown.Items.AddRange(new object[] {
            "6",
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "20",
            "24",
            "28",
            "32"});
            this.textSizeDropdown.Location = new System.Drawing.Point(31, 267);
            this.textSizeDropdown.Name = "textSizeDropdown";
            this.textSizeDropdown.Size = new System.Drawing.Size(216, 28);
            this.textSizeDropdown.TabIndex = 4;
            this.textSizeDropdown.SelectedIndexChanged += new System.EventHandler(this.textSizeDropdown_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Repair Counter Indicator";
            // 
            // repairCounterIndicatorDropdown
            // 
            this.repairCounterIndicatorDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.repairCounterIndicatorDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.repairCounterIndicatorDropdown.FormattingEnabled = true;
            this.repairCounterIndicatorDropdown.Items.AddRange(new object[] {
            "Number",
            "Visual"});
            this.repairCounterIndicatorDropdown.Location = new System.Drawing.Point(31, 57);
            this.repairCounterIndicatorDropdown.Name = "repairCounterIndicatorDropdown";
            this.repairCounterIndicatorDropdown.Size = new System.Drawing.Size(216, 28);
            this.repairCounterIndicatorDropdown.TabIndex = 2;
            // 
            // defaultsButton
            // 
            this.defaultsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.defaultsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.defaultsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.defaultsButton.Location = new System.Drawing.Point(442, 542);
            this.defaultsButton.Name = "defaultsButton";
            this.defaultsButton.Size = new System.Drawing.Size(236, 36);
            this.defaultsButton.TabIndex = 1;
            this.defaultsButton.Text = "Reset To Defaults";
            this.defaultsButton.UseVisualStyleBackColor = false;
            this.defaultsButton.Click += new System.EventHandler(this.defaultsButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.Aqua;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.confirmButton.Location = new System.Drawing.Point(694, 542);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(236, 36);
            this.confirmButton.TabIndex = 0;
            this.confirmButton.Text = "Confirm Changes";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // inputs
            // 
            this.inputs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputs.Location = new System.Drawing.Point(4, 54);
            this.inputs.Margin = new System.Windows.Forms.Padding(2);
            this.inputs.Name = "inputs";
            this.inputs.Padding = new System.Windows.Forms.Padding(2);
            this.inputs.Size = new System.Drawing.Size(1396, 594);
            this.inputs.TabIndex = 1;
            this.inputs.Text = "Inputs";
            // 
            // statistics
            // 
            this.statistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.statistics.Controls.Add(this.gunCountLabel);
            this.statistics.Controls.Add(this.repairCountLabel);
            this.statistics.Controls.Add(this.totalCostLabel);
            this.statistics.Controls.Add(this.costPerRepairNumeric);
            this.statistics.Controls.Add(this.label10);
            this.statistics.Controls.Add(this.label9);
            this.statistics.Controls.Add(this.label8);
            this.statistics.Controls.Add(this.label7);
            this.statistics.Location = new System.Drawing.Point(4, 54);
            this.statistics.Margin = new System.Windows.Forms.Padding(2);
            this.statistics.Name = "statistics";
            this.statistics.Padding = new System.Windows.Forms.Padding(2);
            this.statistics.Size = new System.Drawing.Size(1396, 594);
            this.statistics.TabIndex = 2;
            this.statistics.Text = "Statistics";
            // 
            // gunCountLabel
            // 
            this.gunCountLabel.AutoSize = true;
            this.gunCountLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunCountLabel.ForeColor = System.Drawing.Color.White;
            this.gunCountLabel.Location = new System.Drawing.Point(34, 174);
            this.gunCountLabel.Name = "gunCountLabel";
            this.gunCountLabel.Size = new System.Drawing.Size(97, 29);
            this.gunCountLabel.TabIndex = 7;
            this.gunCountLabel.Text = "999999";
            // 
            // repairCountLabel
            // 
            this.repairCountLabel.AutoSize = true;
            this.repairCountLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.repairCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairCountLabel.ForeColor = System.Drawing.Color.White;
            this.repairCountLabel.Location = new System.Drawing.Point(34, 74);
            this.repairCountLabel.Name = "repairCountLabel";
            this.repairCountLabel.Size = new System.Drawing.Size(97, 29);
            this.repairCountLabel.TabIndex = 6;
            this.repairCountLabel.Text = "999999";
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.totalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostLabel.ForeColor = System.Drawing.Color.White;
            this.totalCostLabel.Location = new System.Drawing.Point(231, 280);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(111, 29);
            this.totalCostLabel.TabIndex = 5;
            this.totalCostLabel.Text = "$999999";
            // 
            // costPerRepairNumeric
            // 
            this.costPerRepairNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.costPerRepairNumeric.Location = new System.Drawing.Point(38, 283);
            this.costPerRepairNumeric.Margin = new System.Windows.Forms.Padding(2);
            this.costPerRepairNumeric.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.costPerRepairNumeric.Name = "costPerRepairNumeric";
            this.costPerRepairNumeric.Size = new System.Drawing.Size(140, 35);
            this.costPerRepairNumeric.TabIndex = 4;
            this.costPerRepairNumeric.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(232, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 24);
            this.label10.TabIndex = 3;
            this.label10.Text = "Total Cost:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(36, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 24);
            this.label9.TabIndex = 2;
            this.label9.Text = "Cost Per Repair:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(34, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "Gun Count:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(34, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Repair Count:";
            // 
            // dropdowns
            // 
            this.dropdowns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dropdowns.Controls.Add(this.label6);
            this.dropdowns.Controls.Add(this.setDropdownButton);
            this.dropdowns.Controls.Add(this.dropdownsBox);
            this.dropdowns.Controls.Add(this.label5);
            this.dropdowns.Controls.Add(this.dropdownsDropdown);
            this.dropdowns.Location = new System.Drawing.Point(4, 54);
            this.dropdowns.Name = "dropdowns";
            this.dropdowns.Size = new System.Drawing.Size(1396, 594);
            this.dropdowns.TabIndex = 3;
            this.dropdowns.Text = "Dropdowns";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(26, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(300, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Elements of dropdown, seperated by a comma";
            // 
            // setDropdownButton
            // 
            this.setDropdownButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.setDropdownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setDropdownButton.Location = new System.Drawing.Point(29, 346);
            this.setDropdownButton.Name = "setDropdownButton";
            this.setDropdownButton.Size = new System.Drawing.Size(246, 47);
            this.setDropdownButton.TabIndex = 18;
            this.setDropdownButton.Text = "Confirm Changes";
            this.setDropdownButton.UseVisualStyleBackColor = false;
            this.setDropdownButton.Click += new System.EventHandler(this.setDropdownButton_Click);
            // 
            // dropdownsBox
            // 
            this.dropdownsBox.Location = new System.Drawing.Point(29, 185);
            this.dropdownsBox.Margin = new System.Windows.Forms.Padding(2);
            this.dropdownsBox.Name = "dropdownsBox";
            this.dropdownsBox.Size = new System.Drawing.Size(1324, 105);
            this.dropdownsBox.TabIndex = 17;
            this.dropdownsBox.Text = "";
            this.dropdownsBox.TextChanged += new System.EventHandler(this.dropdownsBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(26, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Dropdown Being Altered";
            // 
            // dropdownsDropdown
            // 
            this.dropdownsDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dropdownsDropdown.FormattingEnabled = true;
            this.dropdownsDropdown.Items.AddRange(new object[] {
            "Repair - Serial Number",
            "Repair - Repairer Name",
            "Repair - Issue",
            "Repair - Fix",
            "Gun - Condition"});
            this.dropdownsDropdown.Location = new System.Drawing.Point(29, 63);
            this.dropdownsDropdown.Margin = new System.Windows.Forms.Padding(2);
            this.dropdownsDropdown.Name = "dropdownsDropdown";
            this.dropdownsDropdown.Size = new System.Drawing.Size(216, 28);
            this.dropdownsDropdown.TabIndex = 15;
            this.dropdownsDropdown.SelectedIndexChanged += new System.EventHandler(this.dropdownsDropdown_SelectedIndexChanged);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.backButton.Location = new System.Drawing.Point(1312, 32);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(81, 37);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1426, 839);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.label2);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainTabControl.ResumeLayout(false);
            this.accessibility.ResumeLayout(false);
            this.accessibility.PerformLayout();
            this.statistics.ResumeLayout(false);
            this.statistics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.costPerRepairNumeric)).EndInit();
            this.dropdowns.ResumeLayout(false);
            this.dropdowns.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage accessibility;
        private System.Windows.Forms.TabPage inputs;
        private System.Windows.Forms.TabPage statistics;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button defaultsButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox repairCounterIndicatorDropdown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox textSizeDropdown;
        private System.Windows.Forms.ListView sampleList;
        private System.Windows.Forms.ColumnHeader sample;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox repairCounterIterationDropdown;
        private System.Windows.Forms.TabPage dropdowns;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button setDropdownButton;
        private System.Windows.Forms.RichTextBox dropdownsBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox dropdownsDropdown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown costPerRepairNumeric;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label repairCountLabel;
        private System.Windows.Forms.Label gunCountLabel;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}