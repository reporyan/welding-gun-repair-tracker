
namespace WeldingGunTracker
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.repairs = new System.Windows.Forms.TabPage();
            this.repairsList = new System.Windows.Forms.ListView();
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.serialNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.repairers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.problem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fix = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.notes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.guns = new System.Windows.Forms.TabPage();
            this.gunsList = new System.Windows.Forms.ListView();
            this.serial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.repairCounter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.condition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.note = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateAdded = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.graveyard = new System.Windows.Forms.TabPage();
            this.graveyardList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eraseCSVButton = new System.Windows.Forms.Button();
            this.addGunButton = new System.Windows.Forms.Button();
            this.addRepairButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.RichTextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.filterDropdown = new System.Windows.Forms.ComboBox();
            this.sortDropdown = new System.Windows.Forms.ComboBox();
            this.barGroup = new System.Windows.Forms.GroupBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchIcon = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.printButton = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.mainTabControl.SuspendLayout();
            this.repairs.SuspendLayout();
            this.guns.SuspendLayout();
            this.graveyard.SuspendLayout();
            this.barGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.mainTabControl.Controls.Add(this.repairs);
            this.mainTabControl.Controls.Add(this.guns);
            this.mainTabControl.Controls.Add(this.graveyard);
            this.mainTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTabControl.ItemSize = new System.Drawing.Size(125, 50);
            this.mainTabControl.Location = new System.Drawing.Point(9, 75);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1406, 652);
            this.mainTabControl.TabIndex = 1;
            this.mainTabControl.SelectedIndexChanged += new System.EventHandler(this.mainTabControl_SelectedIndexChanged);
            // 
            // repairs
            // 
            this.repairs.BackColor = System.Drawing.Color.Gray;
            this.repairs.Controls.Add(this.repairsList);
            this.repairs.Location = new System.Drawing.Point(4, 54);
            this.repairs.Margin = new System.Windows.Forms.Padding(2);
            this.repairs.Name = "repairs";
            this.repairs.Padding = new System.Windows.Forms.Padding(2);
            this.repairs.Size = new System.Drawing.Size(1398, 594);
            this.repairs.TabIndex = 0;
            this.repairs.Text = "Repairs";
            // 
            // repairsList
            // 
            this.repairsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.repairsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.date,
            this.serialNum,
            this.repairers,
            this.problem,
            this.fix,
            this.notes});
            this.repairsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairsList.ForeColor = System.Drawing.Color.White;
            this.repairsList.GridLines = true;
            this.repairsList.HideSelection = false;
            this.repairsList.Location = new System.Drawing.Point(4, 4);
            this.repairsList.Margin = new System.Windows.Forms.Padding(2);
            this.repairsList.Name = "repairsList";
            this.repairsList.Size = new System.Drawing.Size(1390, 586);
            this.repairsList.TabIndex = 2;
            this.repairsList.UseCompatibleStateImageBehavior = false;
            this.repairsList.View = System.Windows.Forms.View.Details;
            this.repairsList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.repairsList_MouseClick);
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.Width = 200;
            // 
            // serialNum
            // 
            this.serialNum.Text = "Serial Num";
            this.serialNum.Width = 150;
            // 
            // repairers
            // 
            this.repairers.Text = "Repairers";
            this.repairers.Width = 300;
            // 
            // problem
            // 
            this.problem.Text = "Problem";
            this.problem.Width = 300;
            // 
            // fix
            // 
            this.fix.Text = "Fix";
            this.fix.Width = 300;
            // 
            // notes
            // 
            this.notes.Text = "Parts";
            this.notes.Width = 2000;
            // 
            // guns
            // 
            this.guns.BackColor = System.Drawing.Color.Gray;
            this.guns.Controls.Add(this.gunsList);
            this.guns.Location = new System.Drawing.Point(4, 54);
            this.guns.Margin = new System.Windows.Forms.Padding(2);
            this.guns.Name = "guns";
            this.guns.Padding = new System.Windows.Forms.Padding(2);
            this.guns.Size = new System.Drawing.Size(1398, 594);
            this.guns.TabIndex = 1;
            this.guns.Text = "Guns";
            // 
            // gunsList
            // 
            this.gunsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gunsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.serial,
            this.repairCounter,
            this.condition,
            this.note,
            this.dateAdded});
            this.gunsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunsList.ForeColor = System.Drawing.Color.White;
            this.gunsList.GridLines = true;
            this.gunsList.HideSelection = false;
            this.gunsList.Location = new System.Drawing.Point(4, 4);
            this.gunsList.Margin = new System.Windows.Forms.Padding(2);
            this.gunsList.Name = "gunsList";
            this.gunsList.Size = new System.Drawing.Size(1390, 586);
            this.gunsList.TabIndex = 0;
            this.gunsList.UseCompatibleStateImageBehavior = false;
            this.gunsList.View = System.Windows.Forms.View.Details;
            this.gunsList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gunsList_MouseClick);
            // 
            // serial
            // 
            this.serial.Text = "Serial";
            this.serial.Width = 150;
            // 
            // repairCounter
            // 
            this.repairCounter.Text = "Repair Count";
            this.repairCounter.Width = 250;
            // 
            // condition
            // 
            this.condition.Text = "Condition";
            this.condition.Width = 400;
            // 
            // note
            // 
            this.note.Text = "Notes";
            this.note.Width = 450;
            // 
            // dateAdded
            // 
            this.dateAdded.Text = "Date Added";
            this.dateAdded.Width = 250;
            // 
            // graveyard
            // 
            this.graveyard.BackColor = System.Drawing.Color.Gray;
            this.graveyard.Controls.Add(this.graveyardList);
            this.graveyard.Location = new System.Drawing.Point(4, 54);
            this.graveyard.Margin = new System.Windows.Forms.Padding(2);
            this.graveyard.Name = "graveyard";
            this.graveyard.Padding = new System.Windows.Forms.Padding(2);
            this.graveyard.Size = new System.Drawing.Size(1398, 594);
            this.graveyard.TabIndex = 2;
            this.graveyard.Text = "Graveyard";
            // 
            // graveyardList
            // 
            this.graveyardList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.graveyardList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.graveyardList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graveyardList.ForeColor = System.Drawing.Color.White;
            this.graveyardList.GridLines = true;
            this.graveyardList.HideSelection = false;
            this.graveyardList.Location = new System.Drawing.Point(4, 4);
            this.graveyardList.Margin = new System.Windows.Forms.Padding(2);
            this.graveyardList.Name = "graveyardList";
            this.graveyardList.Size = new System.Drawing.Size(1390, 586);
            this.graveyardList.TabIndex = 1;
            this.graveyardList.UseCompatibleStateImageBehavior = false;
            this.graveyardList.View = System.Windows.Forms.View.Details;
            this.graveyardList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graveyardList_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Serial";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Repair Count";
            this.columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Condition";
            this.columnHeader3.Width = 400;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Notes";
            this.columnHeader4.Width = 450;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Date Added";
            this.columnHeader5.Width = 250;
            // 
            // eraseCSVButton
            // 
            this.eraseCSVButton.Location = new System.Drawing.Point(572, 744);
            this.eraseCSVButton.Margin = new System.Windows.Forms.Padding(2);
            this.eraseCSVButton.Name = "eraseCSVButton";
            this.eraseCSVButton.Size = new System.Drawing.Size(269, 80);
            this.eraseCSVButton.TabIndex = 3;
            this.eraseCSVButton.Text = "Erase CSV";
            this.eraseCSVButton.UseVisualStyleBackColor = true;
            this.eraseCSVButton.Click += new System.EventHandler(this.eraseCSVButton_Click);
            // 
            // addGunButton
            // 
            this.addGunButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addGunButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGunButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.addGunButton.Location = new System.Drawing.Point(326, 744);
            this.addGunButton.Margin = new System.Windows.Forms.Padding(2);
            this.addGunButton.Name = "addGunButton";
            this.addGunButton.Size = new System.Drawing.Size(187, 79);
            this.addGunButton.TabIndex = 1;
            this.addGunButton.Text = "Gun +";
            this.toolTip1.SetToolTip(this.addGunButton, "Click to add a new gun.");
            this.addGunButton.UseVisualStyleBackColor = false;
            this.addGunButton.Click += new System.EventHandler(this.addGunButton_Click);
            // 
            // addRepairButton
            // 
            this.addRepairButton.BackColor = System.Drawing.Color.Green;
            this.addRepairButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRepairButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.addRepairButton.Location = new System.Drawing.Point(9, 744);
            this.addRepairButton.Margin = new System.Windows.Forms.Padding(2);
            this.addRepairButton.Name = "addRepairButton";
            this.addRepairButton.Size = new System.Drawing.Size(301, 79);
            this.addRepairButton.TabIndex = 4;
            this.addRepairButton.Text = "Repair +";
            this.toolTip1.SetToolTip(this.addRepairButton, "Click to create a repair.");
            this.addRepairButton.UseVisualStyleBackColor = false;
            this.addRepairButton.Click += new System.EventHandler(this.addRepairButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchBox.Location = new System.Drawing.Point(424, 14);
            this.searchBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(329, 44);
            this.searchBox.TabIndex = 3;
            this.searchBox.Text = "";
            this.toolTip1.SetToolTip(this.searchBox, "Only shows items with certain text in their data.");
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nameLabel.ForeColor = System.Drawing.Color.Gray;
            this.nameLabel.Location = new System.Drawing.Point(9, 13);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(209, 20);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Welding Gun Repair Tracker";
            // 
            // filterDropdown
            // 
            this.filterDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.filterDropdown.FormattingEnabled = true;
            this.filterDropdown.Items.AddRange(new object[] {
            "No Filter",
            "Sand",
            "Rust",
            "Clean",
            "Replace"});
            this.filterDropdown.Location = new System.Drawing.Point(821, 30);
            this.filterDropdown.Margin = new System.Windows.Forms.Padding(2);
            this.filterDropdown.Name = "filterDropdown";
            this.filterDropdown.Size = new System.Drawing.Size(178, 28);
            this.filterDropdown.TabIndex = 7;
            this.toolTip1.SetToolTip(this.filterDropdown, "Only shows items with certain text in their data.");
            this.filterDropdown.SelectedIndexChanged += new System.EventHandler(this.filterDropdown_SelectedIndexChanged);
            // 
            // sortDropdown
            // 
            this.sortDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sortDropdown.FormattingEnabled = true;
            this.sortDropdown.Items.AddRange(new object[] {
            "No Sorting",
            "Time (Recent at Top)",
            "Time (Recent at Bottom)"});
            this.sortDropdown.Location = new System.Drawing.Point(1002, 30);
            this.sortDropdown.Margin = new System.Windows.Forms.Padding(2);
            this.sortDropdown.Name = "sortDropdown";
            this.sortDropdown.Size = new System.Drawing.Size(178, 28);
            this.sortDropdown.TabIndex = 8;
            this.toolTip1.SetToolTip(this.sortDropdown, "Sorts items of all lists in specified order.");
            this.sortDropdown.SelectedIndexChanged += new System.EventHandler(this.sortDropdown_SelectedIndexChanged);
            // 
            // barGroup
            // 
            this.barGroup.BackColor = System.Drawing.Color.Silver;
            this.barGroup.Controls.Add(this.exitButton);
            this.barGroup.Controls.Add(this.settingsButton);
            this.barGroup.Controls.Add(this.label2);
            this.barGroup.Controls.Add(this.label1);
            this.barGroup.Controls.Add(this.searchIcon);
            this.barGroup.Controls.Add(this.searchBox);
            this.barGroup.Controls.Add(this.sortDropdown);
            this.barGroup.Controls.Add(this.filterDropdown);
            this.barGroup.Controls.Add(this.nameLabel);
            this.barGroup.Location = new System.Drawing.Point(0, 0);
            this.barGroup.Margin = new System.Windows.Forms.Padding(2);
            this.barGroup.Name = "barGroup";
            this.barGroup.Padding = new System.Windows.Forms.Padding(2);
            this.barGroup.Size = new System.Drawing.Size(1440, 71);
            this.barGroup.TabIndex = 11;
            this.barGroup.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Image = global::WeldingGunTracker.Properties.Resources.exit1;
            this.exitButton.Location = new System.Drawing.Point(1352, 11);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(55, 55);
            this.exitButton.TabIndex = 16;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackgroundImage = global::WeldingGunTracker.Properties.Resources.settings;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Location = new System.Drawing.Point(1291, 11);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(55, 55);
            this.settingsButton.TabIndex = 15;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1000, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sort";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(818, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Filter";
            // 
            // searchIcon
            // 
            this.searchIcon.Image = global::WeldingGunTracker.Properties.Resources.search1;
            this.searchIcon.Location = new System.Drawing.Point(756, 14);
            this.searchIcon.Margin = new System.Windows.Forms.Padding(2);
            this.searchIcon.Name = "searchIcon";
            this.searchIcon.Size = new System.Drawing.Size(44, 44);
            this.searchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchIcon.TabIndex = 5;
            this.searchIcon.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1326, 827);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "RW|0FRESHBEAN";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 600;
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(1157, 768);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(249, 54);
            this.printButton.TabIndex = 13;
            this.printButton.Text = "Print Page";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
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
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1426, 839);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.barGroup);
            this.Controls.Add(this.addRepairButton);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.addGunButton);
            this.Controls.Add(this.eraseCSVButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainTabControl.ResumeLayout(false);
            this.repairs.ResumeLayout(false);
            this.guns.ResumeLayout(false);
            this.graveyard.ResumeLayout(false);
            this.barGroup.ResumeLayout(false);
            this.barGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage repairs;
        private System.Windows.Forms.TabPage guns;
        private System.Windows.Forms.TabPage graveyard;
        private System.Windows.Forms.ListView repairsList;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader serialNum;
        private System.Windows.Forms.ColumnHeader repairers;
        private System.Windows.Forms.ColumnHeader problem;
        private System.Windows.Forms.ColumnHeader fix;
        private System.Windows.Forms.ColumnHeader notes;
        private System.Windows.Forms.Button eraseCSVButton;
        private System.Windows.Forms.ListView gunsList;
        private System.Windows.Forms.ColumnHeader serial;
        private System.Windows.Forms.Button addGunButton;
        private System.Windows.Forms.Button addRepairButton;
        private System.Windows.Forms.ColumnHeader repairCounter;
        private System.Windows.Forms.ColumnHeader condition;
        private System.Windows.Forms.ColumnHeader note;
        private System.Windows.Forms.RichTextBox searchBox;
        private System.Windows.Forms.PictureBox searchIcon;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ComboBox filterDropdown;
        private System.Windows.Forms.ComboBox sortDropdown;
        private System.Windows.Forms.GroupBox barGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader dateAdded;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListView graveyardList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

