namespace ABC_Analysis_presenter
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.earn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitBtn = new System.Windows.Forms.Button();
            this.calcBtn = new System.Windows.Forms.Button();
            this.btnServiceChose = new FontAwesome.Sharp.IconButton();
            this.btnChangeRelevance = new FontAwesome.Sharp.IconButton();
            this.btnChoseExcel = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToOrderColumns = true;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.count,
            this.cost,
            this.earn});
            this.dataGrid.Location = new System.Drawing.Point(13, 13);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(775, 353);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGrid.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGrid_EditingControlShowing);
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Название услуги";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // count
            // 
            this.count.HeaderText = "Кол-во продаж";
            this.count.MinimumWidth = 6;
            this.count.Name = "count";
            this.count.Width = 125;
            // 
            // cost
            // 
            this.cost.HeaderText = "Цена услуги";
            this.cost.MinimumWidth = 6;
            this.cost.Name = "cost";
            this.cost.Width = 125;
            // 
            // earn
            // 
            this.earn.HeaderText = "Выручка";
            this.earn.MinimumWidth = 6;
            this.earn.Name = "earn";
            this.earn.ReadOnly = true;
            this.earn.Width = 125;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(13, 372);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(260, 66);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Выход";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(528, 372);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(260, 66);
            this.calcBtn.TabIndex = 2;
            this.calcBtn.Text = "Рассчитать";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // btnServiceChose
            // 
            this.btnServiceChose.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnServiceChose.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnServiceChose.IconColor = System.Drawing.Color.Black;
            this.btnServiceChose.IconSize = 16;
            this.btnServiceChose.Location = new System.Drawing.Point(811, 13);
            this.btnServiceChose.Name = "btnServiceChose";
            this.btnServiceChose.Rotation = 0D;
            this.btnServiceChose.Size = new System.Drawing.Size(145, 55);
            this.btnServiceChose.TabIndex = 3;
            this.btnServiceChose.Text = "Выбо проблемной услуги";
            this.btnServiceChose.UseVisualStyleBackColor = true;
            this.btnServiceChose.Click += new System.EventHandler(this.btnServiceChose_Click);
            // 
            // btnChangeRelevance
            // 
            this.btnChangeRelevance.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnChangeRelevance.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnChangeRelevance.IconColor = System.Drawing.Color.Black;
            this.btnChangeRelevance.IconSize = 16;
            this.btnChangeRelevance.Location = new System.Drawing.Point(811, 99);
            this.btnChangeRelevance.Name = "btnChangeRelevance";
            this.btnChangeRelevance.Rotation = 0D;
            this.btnChangeRelevance.Size = new System.Drawing.Size(145, 55);
            this.btnChangeRelevance.TabIndex = 4;
            this.btnChangeRelevance.Text = "Перевод услуги";
            this.btnChangeRelevance.UseVisualStyleBackColor = true;
            this.btnChangeRelevance.Click += new System.EventHandler(this.btnChangeRelevance_Click);
            // 
            // btnChoseExcel
            // 
            this.btnChoseExcel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnChoseExcel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnChoseExcel.IconColor = System.Drawing.Color.Black;
            this.btnChoseExcel.IconSize = 16;
            this.btnChoseExcel.Location = new System.Drawing.Point(811, 194);
            this.btnChoseExcel.Name = "btnChoseExcel";
            this.btnChoseExcel.Rotation = 0D;
            this.btnChoseExcel.Size = new System.Drawing.Size(145, 51);
            this.btnChoseExcel.TabIndex = 5;
            this.btnChoseExcel.Text = "Выбрать excel файл";
            this.btnChoseExcel.UseVisualStyleBackColor = true;
            this.btnChoseExcel.Click += new System.EventHandler(this.btnChoseExcel_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(998, 450);
            this.Controls.Add(this.btnChoseExcel);
            this.Controls.Add(this.btnChangeRelevance);
            this.Controls.Add(this.btnServiceChose);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.dataGrid);
            this.Name = "MainWindow";
            this.Text = "Окно данных";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn earn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button calcBtn;
        public System.Windows.Forms.DataGridView dataGrid;
        private FontAwesome.Sharp.IconButton btnServiceChose;
        private FontAwesome.Sharp.IconButton btnChangeRelevance;
        private FontAwesome.Sharp.IconButton btnChoseExcel;
    }
}

