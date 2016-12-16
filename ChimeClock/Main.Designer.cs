namespace ChimeClock
{
    partial class Main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_Time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Chime = new System.Windows.Forms.DataGridView();
            this.button_Read = new System.Windows.Forms.Button();
            this.button_New = new System.Windows.Forms.Button();
            this.button_ON = new System.Windows.Forms.Button();
            this.button_OFF = new System.Windows.Forms.Button();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Chime)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_Date);
            this.groupBox1.Controls.Add(this.label_Time);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 304);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "現在時刻";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_Date.Location = new System.Drawing.Point(252, 234);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(305, 37);
            this.label_Date.TabIndex = 1;
            this.label_Date.Text = "2000/01/01 (Mon)";
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.Font = new System.Drawing.Font("MS UI Gothic", 144F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_Time.Location = new System.Drawing.Point(37, 36);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(734, 192);
            this.label_Time.TabIndex = 0;
            this.label_Time.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_Chime);
            this.groupBox2.Location = new System.Drawing.Point(13, 324);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 225);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "チャイム設定一覧";
            // 
            // dataGridView_Chime
            // 
            this.dataGridView_Chime.AllowUserToAddRows = false;
            this.dataGridView_Chime.AllowUserToDeleteRows = false;
            this.dataGridView_Chime.AllowUserToResizeColumns = false;
            this.dataGridView_Chime.AllowUserToResizeRows = false;
            this.dataGridView_Chime.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Chime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_Chime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3});
            this.dataGridView_Chime.Location = new System.Drawing.Point(7, 19);
            this.dataGridView_Chime.MultiSelect = false;
            this.dataGridView_Chime.Name = "dataGridView_Chime";
            this.dataGridView_Chime.ReadOnly = true;
            this.dataGridView_Chime.RowHeadersVisible = false;
            this.dataGridView_Chime.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_Chime.RowTemplate.Height = 21;
            this.dataGridView_Chime.Size = new System.Drawing.Size(387, 200);
            this.dataGridView_Chime.TabIndex = 0;
            // 
            // button_Read
            // 
            this.button_Read.Location = new System.Drawing.Point(419, 343);
            this.button_Read.Name = "button_Read";
            this.button_Read.Size = new System.Drawing.Size(402, 23);
            this.button_Read.TabIndex = 2;
            this.button_Read.Text = "設定ファイルの読み込み";
            this.button_Read.UseVisualStyleBackColor = true;
            this.button_Read.Click += new System.EventHandler(this.button_Read_Click);
            // 
            // button_New
            // 
            this.button_New.Location = new System.Drawing.Point(419, 431);
            this.button_New.Name = "button_New";
            this.button_New.Size = new System.Drawing.Size(402, 23);
            this.button_New.TabIndex = 3;
            this.button_New.Text = "設定ファイルの新規作成";
            this.button_New.UseVisualStyleBackColor = true;
            this.button_New.Click += new System.EventHandler(this.button_New_Click);
            // 
            // button_ON
            // 
            this.button_ON.Location = new System.Drawing.Point(419, 519);
            this.button_ON.Name = "button_ON";
            this.button_ON.Size = new System.Drawing.Size(180, 23);
            this.button_ON.TabIndex = 4;
            this.button_ON.Text = "チャイムON";
            this.button_ON.UseVisualStyleBackColor = true;
            this.button_ON.Click += new System.EventHandler(this.button_ON_Click);
            // 
            // button_OFF
            // 
            this.button_OFF.Enabled = false;
            this.button_OFF.Location = new System.Drawing.Point(641, 519);
            this.button_OFF.Name = "button_OFF";
            this.button_OFF.Size = new System.Drawing.Size(180, 23);
            this.button_OFF.TabIndex = 5;
            this.button_OFF.Text = "チャイムOFF";
            this.button_OFF.UseVisualStyleBackColor = true;
            this.button_OFF.Click += new System.EventHandler(this.button_OFF_Click);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "時間";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "使用チャイム";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 561);
            this.Controls.Add(this.button_OFF);
            this.Controls.Add(this.button_ON);
            this.Controls.Add(this.button_New);
            this.Controls.Add(this.button_Read);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "チャイム設定なし - ChimeClock";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Chime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_Chime;
        private System.Windows.Forms.Button button_Read;
        private System.Windows.Forms.Button button_New;
        private System.Windows.Forms.Button button_ON;
        private System.Windows.Forms.Button button_OFF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

