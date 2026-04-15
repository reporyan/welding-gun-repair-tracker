
namespace WeldingGunTracker
{
    partial class EditGunForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.confirmGun = new System.Windows.Forms.Button();
            this.cancelGun = new System.Windows.Forms.Button();
            this.serialBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.conditionDropdown = new System.Windows.Forms.ComboBox();
            this.gunCalender = new System.Windows.Forms.MonthCalendar();
            this.gunRepairsList = new System.Windows.Forms.ListView();
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.repairers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.problem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fix = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.parts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.notesBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.repairCountLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(550, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Gun Menu";
            // 
            // confirmGun
            // 
            this.confirmGun.BackColor = System.Drawing.Color.Aqua;
            this.confirmGun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmGun.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmGun.Location = new System.Drawing.Point(100, 658);
            this.confirmGun.Margin = new System.Windows.Forms.Padding(2);
            this.confirmGun.Name = "confirmGun";
            this.confirmGun.Size = new System.Drawing.Size(352, 36);
            this.confirmGun.TabIndex = 11;
            this.confirmGun.Text = "Confirm";
            this.confirmGun.UseVisualStyleBackColor = false;
            this.confirmGun.Click += new System.EventHandler(this.confirmGun_Click);
            // 
            // cancelGun
            // 
            this.cancelGun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cancelGun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelGun.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelGun.Location = new System.Drawing.Point(100, 698);
            this.cancelGun.Margin = new System.Windows.Forms.Padding(2);
            this.cancelGun.Name = "cancelGun";
            this.cancelGun.Size = new System.Drawing.Size(352, 36);
            this.cancelGun.TabIndex = 12;
            this.cancelGun.Text = "Cancel";
            this.cancelGun.UseVisualStyleBackColor = false;
            this.cancelGun.Click += new System.EventHandler(this.cancelGun_Click);
            // 
            // serialBox
            // 
            this.serialBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialBox.Location = new System.Drawing.Point(98, 105);
            this.serialBox.Margin = new System.Windows.Forms.Padding(2);
            this.serialBox.Name = "serialBox";
            this.serialBox.Size = new System.Drawing.Size(354, 36);
            this.serialBox.TabIndex = 13;
            this.serialBox.Text = "";
            this.serialBox.TextChanged += new System.EventHandler(this.serialBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(95, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Serial Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(97, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Condition:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(95, 413);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Date Created:";
            // 
            // conditionDropdown
            // 
            this.conditionDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.conditionDropdown.FormattingEnabled = true;
            this.conditionDropdown.Location = new System.Drawing.Point(100, 205);
            this.conditionDropdown.Margin = new System.Windows.Forms.Padding(2);
            this.conditionDropdown.Name = "conditionDropdown";
            this.conditionDropdown.Size = new System.Drawing.Size(351, 28);
            this.conditionDropdown.TabIndex = 19;
            this.conditionDropdown.TextChanged += new System.EventHandler(this.conditionDropdown_TextChanged);
            // 
            // gunCalender
            // 
            this.gunCalender.Location = new System.Drawing.Point(100, 437);
            this.gunCalender.Margin = new System.Windows.Forms.Padding(7);
            this.gunCalender.Name = "gunCalender";
            this.gunCalender.TabIndex = 20;
            // 
            // gunRepairsList
            // 
            this.gunRepairsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunRepairsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.date,
            this.repairers,
            this.problem,
            this.fix,
            this.parts});
            this.gunRepairsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunRepairsList.ForeColor = System.Drawing.Color.White;
            this.gunRepairsList.GridLines = true;
            this.gunRepairsList.HideSelection = false;
            this.gunRepairsList.Location = new System.Drawing.Point(484, 121);
            this.gunRepairsList.Margin = new System.Windows.Forms.Padding(2);
            this.gunRepairsList.Name = "gunRepairsList";
            this.gunRepairsList.Size = new System.Drawing.Size(796, 662);
            this.gunRepairsList.TabIndex = 21;
            this.gunRepairsList.UseCompatibleStateImageBehavior = false;
            this.gunRepairsList.View = System.Windows.Forms.View.Details;
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.Width = 200;
            // 
            // repairers
            // 
            this.repairers.Text = "Repairers";
            this.repairers.Width = 250;
            // 
            // problem
            // 
            this.problem.Text = "Problem";
            this.problem.Width = 250;
            // 
            // fix
            // 
            this.fix.Text = "Fix";
            this.fix.Width = 250;
            // 
            // parts
            // 
            this.parts.Text = "Parts";
            this.parts.Width = 1500;
            // 
            // notesBox
            // 
            this.notesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesBox.Location = new System.Drawing.Point(100, 283);
            this.notesBox.Margin = new System.Windows.Forms.Padding(2);
            this.notesBox.Name = "notesBox";
            this.notesBox.Size = new System.Drawing.Size(351, 119);
            this.notesBox.TabIndex = 22;
            this.notesBox.Text = "";
            this.notesBox.TextChanged += new System.EventHandler(this.notesBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(97, 615);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Times Repaired:";
            // 
            // repairCountLabel
            // 
            this.repairCountLabel.AutoSize = true;
            this.repairCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.repairCountLabel.Location = new System.Drawing.Point(96, 632);
            this.repairCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.repairCountLabel.Name = "repairCountLabel";
            this.repairCountLabel.Size = new System.Drawing.Size(43, 24);
            this.repairCountLabel.TabIndex = 24;
            this.repairCountLabel.Text = "999";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(97, 143);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(331, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Warning: Renaming gun will disassociate its repairs";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(97, 264);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Notes:";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Red;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(100, 738);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(352, 36);
            this.deleteButton.TabIndex = 27;
            this.deleteButton.Text = "Delete Gun";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // EditGunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1426, 839);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.repairCountLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.notesBox);
            this.Controls.Add(this.gunRepairsList);
            this.Controls.Add(this.gunCalender);
            this.Controls.Add(this.conditionDropdown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serialBox);
            this.Controls.Add(this.confirmGun);
            this.Controls.Add(this.cancelGun);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditGunForm";
            this.Text = "EditGunForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button confirmGun;
        private System.Windows.Forms.Button cancelGun;
        private System.Windows.Forms.RichTextBox serialBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox conditionDropdown;
        private System.Windows.Forms.MonthCalendar gunCalender;
        private System.Windows.Forms.ListView gunRepairsList;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader repairers;
        private System.Windows.Forms.ColumnHeader problem;
        private System.Windows.Forms.ColumnHeader fix;
        private System.Windows.Forms.ColumnHeader parts;
        private System.Windows.Forms.RichTextBox notesBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label repairCountLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button deleteButton;
    }
}