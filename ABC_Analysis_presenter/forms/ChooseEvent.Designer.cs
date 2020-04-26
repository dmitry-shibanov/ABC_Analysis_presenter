namespace ABC_Analysis_presenter.forms
{
    partial class ChooseEvent
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
            this.eventsPannel = new System.Windows.Forms.Panel();
            this.listEvents = new System.Windows.Forms.ListView();
            this.eventParticipants = new System.Windows.Forms.Panel();
            this.listEvenParticipants = new System.Windows.Forms.ListView();
            this.allEmployeesPannel = new System.Windows.Forms.Panel();
            this.listofEmployees = new System.Windows.Forms.ListView();
            this.iconButtonAddEmployees = new FontAwesome.Sharp.IconButton();
            this.header_part_fio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.header_part_work = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerfio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerWork = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButtonAdd = new FontAwesome.Sharp.IconButton();
            this.columnHeaderWork = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eventsPannel.SuspendLayout();
            this.eventParticipants.SuspendLayout();
            this.allEmployeesPannel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventsPannel
            // 
            this.eventsPannel.Controls.Add(this.listEvents);
            this.eventsPannel.Dock = System.Windows.Forms.DockStyle.Left;
            this.eventsPannel.Location = new System.Drawing.Point(0, 0);
            this.eventsPannel.Name = "eventsPannel";
            this.eventsPannel.Size = new System.Drawing.Size(340, 575);
            this.eventsPannel.TabIndex = 0;
            // 
            // listEvents
            // 
            this.listEvents.BackColor = System.Drawing.SystemColors.HotTrack;
            this.listEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderWork});
            this.listEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listEvents.HideSelection = false;
            this.listEvents.Location = new System.Drawing.Point(0, 0);
            this.listEvents.Name = "listEvents";
            this.listEvents.Size = new System.Drawing.Size(340, 575);
            this.listEvents.TabIndex = 0;
            this.listEvents.UseCompatibleStateImageBehavior = false;
            this.listEvents.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listEvents_DrawColumnHeader);
            this.listEvents.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listEvents_DrawItem);
            this.listEvents.SelectedIndexChanged += new System.EventHandler(this.listEvents_SelectedIndexChanged);
            // 
            // eventParticipants
            // 
            this.eventParticipants.Controls.Add(this.listEvenParticipants);
            this.eventParticipants.Dock = System.Windows.Forms.DockStyle.Left;
            this.eventParticipants.Location = new System.Drawing.Point(340, 0);
            this.eventParticipants.Name = "eventParticipants";
            this.eventParticipants.Size = new System.Drawing.Size(325, 575);
            this.eventParticipants.TabIndex = 1;
            // 
            // listEvenParticipants
            // 
            this.listEvenParticipants.BackColor = System.Drawing.SystemColors.HotTrack;
            this.listEvenParticipants.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.header_part_fio,
            this.header_part_work});
            this.listEvenParticipants.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listEvenParticipants.HideSelection = false;
            this.listEvenParticipants.Location = new System.Drawing.Point(0, 0);
            this.listEvenParticipants.Name = "listEvenParticipants";
            this.listEvenParticipants.Size = new System.Drawing.Size(325, 575);
            this.listEvenParticipants.TabIndex = 0;
            this.listEvenParticipants.UseCompatibleStateImageBehavior = false;
            this.listEvenParticipants.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listEvenParticipants_DrawColumnHeader);
            this.listEvenParticipants.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listEvenParticipants_DrawItem);
            // 
            // allEmployeesPannel
            // 
            this.allEmployeesPannel.Controls.Add(this.panel2);
            this.allEmployeesPannel.Controls.Add(this.panel1);
            this.allEmployeesPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allEmployeesPannel.Location = new System.Drawing.Point(665, 0);
            this.allEmployeesPannel.Name = "allEmployeesPannel";
            this.allEmployeesPannel.Size = new System.Drawing.Size(458, 575);
            this.allEmployeesPannel.TabIndex = 2;
            // 
            // listofEmployees
            // 
            this.listofEmployees.BackColor = System.Drawing.SystemColors.HotTrack;
            this.listofEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerfio,
            this.headerWork});
            this.listofEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listofEmployees.HideSelection = false;
            this.listofEmployees.Location = new System.Drawing.Point(0, 0);
            this.listofEmployees.Name = "listofEmployees";
            this.listofEmployees.Size = new System.Drawing.Size(458, 475);
            this.listofEmployees.TabIndex = 1;
            this.listofEmployees.UseCompatibleStateImageBehavior = false;
            this.listofEmployees.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listofEmployees_DrawColumnHeader);
            this.listofEmployees.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listofEmployees_DrawItem);
            // 
            // iconButtonAddEmployees
            // 
            this.iconButtonAddEmployees.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonAddEmployees.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonAddEmployees.IconColor = System.Drawing.Color.Black;
            this.iconButtonAddEmployees.IconSize = 16;
            this.iconButtonAddEmployees.Location = new System.Drawing.Point(623, 21);
            this.iconButtonAddEmployees.Name = "iconButtonAddEmployees";
            this.iconButtonAddEmployees.Rotation = 0D;
            this.iconButtonAddEmployees.Size = new System.Drawing.Size(108, 39);
            this.iconButtonAddEmployees.TabIndex = 0;
            this.iconButtonAddEmployees.Text = "Добавить";
            this.iconButtonAddEmployees.UseVisualStyleBackColor = true;
            // 
            // header_part_fio
            // 
            this.header_part_fio.Text = "ФИО";
            this.header_part_fio.Width = 160;
            // 
            // header_part_work
            // 
            this.header_part_work.Text = "Должность";
            this.header_part_work.Width = 160;
            // 
            // headerfio
            // 
            this.headerfio.Text = "ФИО";
            this.headerfio.Width = 229;
            // 
            // headerWork
            // 
            this.headerWork.Text = "Должность";
            this.headerWork.Width = 220;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconButtonAdd);
            this.panel1.Controls.Add(this.iconButtonAddEmployees);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 475);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 100);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listofEmployees);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(458, 475);
            this.panel2.TabIndex = 3;
            // 
            // iconButtonAdd
            // 
            this.iconButtonAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonAdd.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonAdd.IconColor = System.Drawing.Color.Black;
            this.iconButtonAdd.IconSize = 16;
            this.iconButtonAdd.Location = new System.Drawing.Point(325, 48);
            this.iconButtonAdd.Name = "iconButtonAdd";
            this.iconButtonAdd.Rotation = 0D;
            this.iconButtonAdd.Size = new System.Drawing.Size(121, 40);
            this.iconButtonAdd.TabIndex = 1;
            this.iconButtonAdd.Text = "Добавить";
            this.iconButtonAdd.UseVisualStyleBackColor = true;
            this.iconButtonAdd.Click += new System.EventHandler(this.iconButtonAdd_Click);
            // 
            // columnHeaderWork
            // 
            this.columnHeaderWork.Text = "Задание";
            this.columnHeaderWork.Width = 336;
            // 
            // ChooseEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1123, 575);
            this.Controls.Add(this.allEmployeesPannel);
            this.Controls.Add(this.eventParticipants);
            this.Controls.Add(this.eventsPannel);
            this.Name = "ChooseEvent";
            this.Text = "ChooseEvent";
            this.eventsPannel.ResumeLayout(false);
            this.eventParticipants.ResumeLayout(false);
            this.allEmployeesPannel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel eventsPannel;
        private System.Windows.Forms.ListView listEvents;
        private System.Windows.Forms.Panel eventParticipants;
        private System.Windows.Forms.ListView listEvenParticipants;
        private System.Windows.Forms.Panel allEmployeesPannel;
        private System.Windows.Forms.ListView listofEmployees;
        private FontAwesome.Sharp.IconButton iconButtonAddEmployees;
        private System.Windows.Forms.ColumnHeader header_part_fio;
        private System.Windows.Forms.ColumnHeader header_part_work;
        private System.Windows.Forms.ColumnHeader headerfio;
        private System.Windows.Forms.ColumnHeader headerWork;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButtonAdd;
        private System.Windows.Forms.ColumnHeader columnHeaderWork;
    }
}