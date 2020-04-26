namespace ABC_Analysis_presenter.forms
{
    partial class NavigationForm
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButtonChooseVector = new FontAwesome.Sharp.IconButton();
            this.iconButtonAction = new FontAwesome.Sharp.IconButton();
            this.iconButtonServices = new FontAwesome.Sharp.IconButton();
            this.iconButtonGraphs = new FontAwesome.Sharp.IconButton();
            this.signButton = new FontAwesome.Sharp.IconButton();
            this.iconButtonMain = new FontAwesome.Sharp.IconButton();
            this.panelHead = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.titleChild = new System.Windows.Forms.Label();
            this.iconButtonChat = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panelHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMenu.Controls.Add(this.iconButtonChat);
            this.panelMenu.Controls.Add(this.iconButtonChooseVector);
            this.panelMenu.Controls.Add(this.iconButtonAction);
            this.panelMenu.Controls.Add(this.iconButtonServices);
            this.panelMenu.Controls.Add(this.iconButtonGraphs);
            this.panelMenu.Controls.Add(this.signButton);
            this.panelMenu.Controls.Add(this.iconButtonMain);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 779);
            this.panelMenu.TabIndex = 0;
            // 
            // iconButtonChooseVector
            // 
            this.iconButtonChooseVector.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonChooseVector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonChooseVector.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonChooseVector.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButtonChooseVector.IconChar = FontAwesome.Sharp.IconChar.StickyNote;
            this.iconButtonChooseVector.IconColor = System.Drawing.Color.White;
            this.iconButtonChooseVector.IconSize = 32;
            this.iconButtonChooseVector.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonChooseVector.Location = new System.Drawing.Point(0, 200);
            this.iconButtonChooseVector.Name = "iconButtonChooseVector";
            this.iconButtonChooseVector.Rotation = 0D;
            this.iconButtonChooseVector.Size = new System.Drawing.Size(246, 50);
            this.iconButtonChooseVector.TabIndex = 4;
            this.iconButtonChooseVector.Text = "Отбор направлений";
            this.iconButtonChooseVector.UseVisualStyleBackColor = true;
            this.iconButtonChooseVector.Click += new System.EventHandler(this.iconButtonChooseVector_Click);
            // 
            // iconButtonAction
            // 
            this.iconButtonAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAction.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonAction.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButtonAction.IconChar = FontAwesome.Sharp.IconChar.IdBadge;
            this.iconButtonAction.IconColor = System.Drawing.Color.White;
            this.iconButtonAction.IconSize = 32;
            this.iconButtonAction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAction.Location = new System.Drawing.Point(0, 150);
            this.iconButtonAction.Name = "iconButtonAction";
            this.iconButtonAction.Rotation = 0D;
            this.iconButtonAction.Size = new System.Drawing.Size(246, 50);
            this.iconButtonAction.TabIndex = 3;
            this.iconButtonAction.Text = "Деятельность";
            this.iconButtonAction.UseVisualStyleBackColor = true;
            this.iconButtonAction.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // iconButtonServices
            // 
            this.iconButtonServices.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonServices.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonServices.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButtonServices.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.iconButtonServices.IconColor = System.Drawing.Color.White;
            this.iconButtonServices.IconSize = 32;
            this.iconButtonServices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonServices.Location = new System.Drawing.Point(0, 100);
            this.iconButtonServices.Name = "iconButtonServices";
            this.iconButtonServices.Rotation = 0D;
            this.iconButtonServices.Size = new System.Drawing.Size(246, 50);
            this.iconButtonServices.TabIndex = 2;
            this.iconButtonServices.Text = "Услуги";
            this.iconButtonServices.UseVisualStyleBackColor = true;
            this.iconButtonServices.Click += new System.EventHandler(this.iconButtonServices_Click);
            // 
            // iconButtonGraphs
            // 
            this.iconButtonGraphs.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonGraphs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonGraphs.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonGraphs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButtonGraphs.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.iconButtonGraphs.IconColor = System.Drawing.Color.White;
            this.iconButtonGraphs.IconSize = 32;
            this.iconButtonGraphs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonGraphs.Location = new System.Drawing.Point(0, 50);
            this.iconButtonGraphs.Name = "iconButtonGraphs";
            this.iconButtonGraphs.Rotation = 0D;
            this.iconButtonGraphs.Size = new System.Drawing.Size(246, 50);
            this.iconButtonGraphs.TabIndex = 1;
            this.iconButtonGraphs.Text = "Графики";
            this.iconButtonGraphs.UseVisualStyleBackColor = true;
            this.iconButtonGraphs.Click += new System.EventHandler(this.iconButtonGraphs_Click);
            // 
            // signButton
            // 
            this.signButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.signButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.signButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.signButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.signButton.IconColor = System.Drawing.Color.Black;
            this.signButton.IconSize = 16;
            this.signButton.Location = new System.Drawing.Point(0, 725);
            this.signButton.Name = "signButton";
            this.signButton.Rotation = 0D;
            this.signButton.Size = new System.Drawing.Size(246, 50);
            this.signButton.TabIndex = 1;
            this.signButton.Text = "Выход";
            this.signButton.UseVisualStyleBackColor = true;
            this.signButton.Click += new System.EventHandler(this.signButton_Click);
            // 
            // iconButtonMain
            // 
            this.iconButtonMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMain.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonMain.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButtonMain.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconButtonMain.IconColor = System.Drawing.Color.White;
            this.iconButtonMain.IconSize = 32;
            this.iconButtonMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMain.Location = new System.Drawing.Point(0, 0);
            this.iconButtonMain.Name = "iconButtonMain";
            this.iconButtonMain.Rotation = 0D;
            this.iconButtonMain.Size = new System.Drawing.Size(246, 50);
            this.iconButtonMain.TabIndex = 0;
            this.iconButtonMain.Text = "Главная";
            this.iconButtonMain.UseVisualStyleBackColor = true;
            this.iconButtonMain.Click += new System.EventHandler(this.iconButtonMain_Click);
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelHead.Controls.Add(this.titleChild);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(250, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(1112, 100);
            this.panelHead.TabIndex = 1;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 100);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1112, 679);
            this.panelChildForm.TabIndex = 2;
            // 
            // titleChild
            // 
            this.titleChild.AutoSize = true;
            this.titleChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleChild.Location = new System.Drawing.Point(17, 19);
            this.titleChild.Name = "titleChild";
            this.titleChild.Size = new System.Drawing.Size(207, 31);
            this.titleChild.TabIndex = 0;
            this.titleChild.Text = "Вход в систему";
            // 
            // iconButtonChat
            // 
            this.iconButtonChat.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonChat.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonChat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButtonChat.IconChar = FontAwesome.Sharp.IconChar.EnvelopeSquare;
            this.iconButtonChat.IconColor = System.Drawing.Color.White;
            this.iconButtonChat.IconSize = 32;
            this.iconButtonChat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonChat.Location = new System.Drawing.Point(0, 250);
            this.iconButtonChat.Name = "iconButtonChat";
            this.iconButtonChat.Rotation = 0D;
            this.iconButtonChat.Size = new System.Drawing.Size(246, 50);
            this.iconButtonChat.TabIndex = 5;
            this.iconButtonChat.Text = "Чат";
            this.iconButtonChat.UseVisualStyleBackColor = true;
            this.iconButtonChat.Click += new System.EventHandler(this.iconButtonChat_Click);
            // 
            // NavigationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 779);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelHead);
            this.Controls.Add(this.panelMenu);
            this.Name = "NavigationForm";
            this.Text = "NavigationForm";
            this.panelMenu.ResumeLayout(false);
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButtonMain;
        private FontAwesome.Sharp.IconButton iconButtonGraphs;
        private FontAwesome.Sharp.IconButton signButton;
        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Panel panelChildForm;
        private FontAwesome.Sharp.IconButton iconButtonServices;
        private FontAwesome.Sharp.IconButton iconButtonChooseVector;
        private FontAwesome.Sharp.IconButton iconButtonAction;
        private System.Windows.Forms.Label titleChild;
        private FontAwesome.Sharp.IconButton iconButtonChat;
    }
}