namespace ABC_Analysis_presenter.forms
{
    partial class ChartWindow
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.listSolutions = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.enterMesasge = new System.Windows.Forms.TextBox();
            this.listMessages = new System.Windows.Forms.ListView();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.listSolutions);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(604, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(196, 450);
            this.panel3.TabIndex = 2;
            // 
            // listSolutions
            // 
            this.listSolutions.BackColor = System.Drawing.SystemColors.HotTrack;
            this.listSolutions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSolutions.HideSelection = false;
            this.listSolutions.Location = new System.Drawing.Point(0, 25);
            this.listSolutions.Name = "listSolutions";
            this.listSolutions.Size = new System.Drawing.Size(196, 425);
            this.listSolutions.TabIndex = 1;
            this.listSolutions.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Варианты решений";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.enterMesasge);
            this.panel2.Controls.Add(this.listMessages);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(604, 450);
            this.panel2.TabIndex = 3;
            // 
            // enterMesasge
            // 
            this.enterMesasge.BackColor = System.Drawing.SystemColors.Window;
            this.enterMesasge.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.enterMesasge.Location = new System.Drawing.Point(0, 385);
            this.enterMesasge.Multiline = true;
            this.enterMesasge.Name = "enterMesasge";
            this.enterMesasge.Size = new System.Drawing.Size(604, 65);
            this.enterMesasge.TabIndex = 1;
            // 
            // listMessages
            // 
            this.listMessages.BackColor = System.Drawing.SystemColors.HotTrack;
            this.listMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listMessages.HideSelection = false;
            this.listMessages.Location = new System.Drawing.Point(0, 0);
            this.listMessages.Name = "listMessages";
            this.listMessages.Size = new System.Drawing.Size(604, 450);
            this.listMessages.TabIndex = 0;
            this.listMessages.UseCompatibleStateImageBehavior = false;
            // 
            // ChartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "ChartWindow";
            this.Text = "ChartWindow";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView listSolutions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox enterMesasge;
        private System.Windows.Forms.ListView listMessages;
    }
}