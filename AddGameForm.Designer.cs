namespace ChessClubManager
{
    partial class AddGameForm
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
            this.whiteList = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.blackList = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.drawRadio = new System.Windows.Forms.RadioButton();
            this.blackWinRadio = new System.Windows.Forms.RadioButton();
            this.whiteWinRadio = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // whiteList
            // 
            this.whiteList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.whiteList.HideSelection = false;
            this.whiteList.Location = new System.Drawing.Point(12, 27);
            this.whiteList.MultiSelect = false;
            this.whiteList.Name = "whiteList";
            this.whiteList.Size = new System.Drawing.Size(121, 244);
            this.whiteList.TabIndex = 0;
            this.whiteList.UseCompatibleStateImageBehavior = false;
            this.whiteList.View = System.Windows.Forms.View.Details;
            this.whiteList.SelectedIndexChanged += new System.EventHandler(this.whiteList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "White";
            // 
            // blackList
            // 
            this.blackList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.blackList.HideSelection = false;
            this.blackList.Location = new System.Drawing.Point(359, 27);
            this.blackList.MultiSelect = false;
            this.blackList.Name = "blackList";
            this.blackList.Size = new System.Drawing.Size(121, 244);
            this.blackList.TabIndex = 2;
            this.blackList.UseCompatibleStateImageBehavior = false;
            this.blackList.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Black";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(139, 27);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(214, 20);
            this.datePicker.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.drawRadio);
            this.groupBox1.Controls.Add(this.blackWinRadio);
            this.groupBox1.Controls.Add(this.whiteWinRadio);
            this.groupBox1.Location = new System.Drawing.Point(160, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // drawRadio
            // 
            this.drawRadio.AutoSize = true;
            this.drawRadio.Location = new System.Drawing.Point(42, 67);
            this.drawRadio.Name = "drawRadio";
            this.drawRadio.Size = new System.Drawing.Size(50, 17);
            this.drawRadio.TabIndex = 2;
            this.drawRadio.TabStop = true;
            this.drawRadio.Text = "Draw";
            this.drawRadio.UseVisualStyleBackColor = true;
            // 
            // blackWinRadio
            // 
            this.blackWinRadio.AutoSize = true;
            this.blackWinRadio.Location = new System.Drawing.Point(42, 43);
            this.blackWinRadio.Name = "blackWinRadio";
            this.blackWinRadio.Size = new System.Drawing.Size(74, 17);
            this.blackWinRadio.TabIndex = 1;
            this.blackWinRadio.TabStop = true;
            this.blackWinRadio.Text = "Black Win";
            this.blackWinRadio.UseVisualStyleBackColor = true;
            // 
            // whiteWinRadio
            // 
            this.whiteWinRadio.AutoSize = true;
            this.whiteWinRadio.Checked = true;
            this.whiteWinRadio.Location = new System.Drawing.Point(42, 19);
            this.whiteWinRadio.Name = "whiteWinRadio";
            this.whiteWinRadio.Size = new System.Drawing.Size(75, 17);
            this.whiteWinRadio.TabIndex = 0;
            this.whiteWinRadio.TabStop = true;
            this.whiteWinRadio.Text = "White Win";
            this.whiteWinRadio.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Player Name";
            this.columnHeader1.Width = 114;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Player Names";
            this.columnHeader2.Width = 113;
            // 
            // AddGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 283);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.blackList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.whiteList);
            this.Name = "AddGameForm";
            this.Text = "AddGameForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView whiteList;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListView blackList;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker datePicker;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton drawRadio;
        public System.Windows.Forms.RadioButton blackWinRadio;
        public System.Windows.Forms.RadioButton whiteWinRadio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}