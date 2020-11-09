namespace ImageChecker
{
    partial class ImageChecker
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageChecker));
            this.btnStartRecord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridActionList = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addedInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentAccuracy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPlay = new System.Windows.Forms.Button();
            this.timerActionExecute = new System.Windows.Forms.Timer(this.components);
            this.timerClickInterval = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblExStat = new System.Windows.Forms.Label();
            this.btnEmpty = new System.Windows.Forms.Button();
            this.txtRepeats = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblCurrentRepeat = new System.Windows.Forms.Label();
            this.picScreen1 = new System.Windows.Forms.PictureBox();
            this.picScreen2 = new System.Windows.Forms.PictureBox();
            this.lblCompResult = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnFillArray = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timerKeyCode = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.picScreen3 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnShowInfos = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActionList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScreen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScreen2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScreen3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartRecord
            // 
            this.btnStartRecord.Location = new System.Drawing.Point(12, 34);
            this.btnStartRecord.Name = "btnStartRecord";
            this.btnStartRecord.Size = new System.Drawing.Size(75, 23);
            this.btnStartRecord.TabIndex = 1;
            this.btnStartRecord.Text = "Start Record";
            this.btnStartRecord.UseVisualStyleBackColor = true;
            this.btnStartRecord.Click += new System.EventHandler(this.btnStartRecord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // dataGridActionList
            // 
            this.dataGridActionList.AllowUserToAddRows = false;
            this.dataGridActionList.AllowUserToResizeColumns = false;
            this.dataGridActionList.AllowUserToResizeRows = false;
            this.dataGridActionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridActionList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.mSec,
            this.posX,
            this.posY,
            this.action,
            this.addedInfo,
            this.percentAccuracy,
            this.picID});
            this.dataGridActionList.Location = new System.Drawing.Point(12, 242);
            this.dataGridActionList.Name = "dataGridActionList";
            this.dataGridActionList.RowHeadersVisible = false;
            this.dataGridActionList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridActionList.Size = new System.Drawing.Size(572, 369);
            this.dataGridActionList.TabIndex = 16;
            this.dataGridActionList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridActionList_CellClick);
            this.dataGridActionList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridActionList_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "Nr.";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Width = 50;
            // 
            // mSec
            // 
            this.mSec.HeaderText = "milli second";
            this.mSec.Name = "mSec";
            this.mSec.Width = 60;
            // 
            // posX
            // 
            this.posX.HeaderText = "position X";
            this.posX.Name = "posX";
            this.posX.Width = 60;
            // 
            // posY
            // 
            this.posY.HeaderText = "position Y";
            this.posY.Name = "posY";
            this.posY.Width = 60;
            // 
            // action
            // 
            this.action.HeaderText = "action";
            this.action.Name = "action";
            this.action.ReadOnly = true;
            this.action.Width = 120;
            // 
            // addedInfo
            // 
            this.addedInfo.HeaderText = "Code";
            this.addedInfo.Name = "addedInfo";
            this.addedInfo.ReadOnly = true;
            this.addedInfo.Width = 60;
            // 
            // percentAccuracy
            // 
            this.percentAccuracy.HeaderText = "percent Accuracy";
            this.percentAccuracy.Name = "percentAccuracy";
            this.percentAccuracy.ReadOnly = true;
            this.percentAccuracy.Width = 60;
            // 
            // picID
            // 
            this.picID.HeaderText = "Picture ID";
            this.picID.Name = "picID";
            this.picID.ReadOnly = true;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(93, 34);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 17;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // timerActionExecute
            // 
            this.timerActionExecute.Interval = 300;
            this.timerActionExecute.Tick += new System.EventHandler(this.timerActionExecute_Tick);
            // 
            // timerClickInterval
            // 
            this.timerClickInterval.Interval = 10;
            this.timerClickInterval.Tick += new System.EventHandler(this.timerClickInterval_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Execution status:";
            // 
            // lblExStat
            // 
            this.lblExStat.AutoSize = true;
            this.lblExStat.Location = new System.Drawing.Point(105, 9);
            this.lblExStat.Name = "lblExStat";
            this.lblExStat.Size = new System.Drawing.Size(35, 13);
            this.lblExStat.TabIndex = 19;
            this.lblExStat.Text = "empty";
            // 
            // btnEmpty
            // 
            this.btnEmpty.Enabled = false;
            this.btnEmpty.Location = new System.Drawing.Point(870, 34);
            this.btnEmpty.Name = "btnEmpty";
            this.btnEmpty.Size = new System.Drawing.Size(75, 23);
            this.btnEmpty.TabIndex = 20;
            this.btnEmpty.Text = "Empty";
            this.btnEmpty.UseVisualStyleBackColor = true;
            this.btnEmpty.Visible = false;
            // 
            // txtRepeats
            // 
            this.txtRepeats.Location = new System.Drawing.Point(93, 63);
            this.txtRepeats.Name = "txtRepeats";
            this.txtRepeats.Size = new System.Drawing.Size(75, 20);
            this.txtRepeats.TabIndex = 21;
            this.txtRepeats.Text = "1";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 192);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblCurrentRepeat
            // 
            this.lblCurrentRepeat.AutoSize = true;
            this.lblCurrentRepeat.Location = new System.Drawing.Point(90, 86);
            this.lblCurrentRepeat.Name = "lblCurrentRepeat";
            this.lblCurrentRepeat.Size = new System.Drawing.Size(13, 13);
            this.lblCurrentRepeat.TabIndex = 23;
            this.lblCurrentRepeat.Text = "0";
            // 
            // picScreen1
            // 
            this.picScreen1.Location = new System.Drawing.Point(12, 102);
            this.picScreen1.Name = "picScreen1";
            this.picScreen1.Size = new System.Drawing.Size(100, 50);
            this.picScreen1.TabIndex = 24;
            this.picScreen1.TabStop = false;
            // 
            // picScreen2
            // 
            this.picScreen2.Enabled = false;
            this.picScreen2.Location = new System.Drawing.Point(369, 63);
            this.picScreen2.Name = "picScreen2";
            this.picScreen2.Size = new System.Drawing.Size(100, 50);
            this.picScreen2.TabIndex = 25;
            this.picScreen2.TabStop = false;
            this.picScreen2.Visible = false;
            // 
            // lblCompResult
            // 
            this.lblCompResult.AutoSize = true;
            this.lblCompResult.Enabled = false;
            this.lblCompResult.Location = new System.Drawing.Point(260, 116);
            this.lblCompResult.Name = "lblCompResult";
            this.lblCompResult.Size = new System.Drawing.Size(74, 13);
            this.lblCompResult.TabIndex = 27;
            this.lblCompResult.Text = "lblCompResult";
            this.lblCompResult.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(369, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 28;
            this.textBox1.Text = "0";
            this.textBox1.Visible = false;
            // 
            // btnFillArray
            // 
            this.btnFillArray.Enabled = false;
            this.btnFillArray.Location = new System.Drawing.Point(369, 7);
            this.btnFillArray.Name = "btnFillArray";
            this.btnFillArray.Size = new System.Drawing.Size(75, 23);
            this.btnFillArray.TabIndex = 29;
            this.btnFillArray.Text = "Vergleiche";
            this.btnFillArray.UseVisualStyleBackColor = true;
            this.btnFillArray.Visible = false;
            this.btnFillArray.Click += new System.EventHandler(this.btnFillArray_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(369, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "zeige";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timerKeyCode
            // 
            this.timerKeyCode.Interval = 10;
            this.timerKeyCode.Tick += new System.EventHandler(this.timerKeyCode_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(260, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // picScreen3
            // 
            this.picScreen3.Enabled = false;
            this.picScreen3.Location = new System.Drawing.Point(475, 63);
            this.picScreen3.Name = "picScreen3";
            this.picScreen3.Size = new System.Drawing.Size(100, 50);
            this.picScreen3.TabIndex = 32;
            this.picScreen3.TabStop = false;
            this.picScreen3.Visible = false;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(475, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "zeige";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(475, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 34;
            this.textBox2.Text = "1";
            this.textBox2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(260, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.Enabled = false;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(608, 242);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(337, 225);
            this.listBox1.TabIndex = 36;
            this.listBox1.Visible = false;
            // 
            // btnShowInfos
            // 
            this.btnShowInfos.Enabled = false;
            this.btnShowInfos.Location = new System.Drawing.Point(608, 202);
            this.btnShowInfos.Name = "btnShowInfos";
            this.btnShowInfos.Size = new System.Drawing.Size(75, 23);
            this.btnShowInfos.TabIndex = 37;
            this.btnShowInfos.Text = "show infos";
            this.btnShowInfos.UseVisualStyleBackColor = true;
            this.btnShowInfos.Visible = false;
            this.btnShowInfos.Click += new System.EventHandler(this.btnShowInfos_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(648, 116);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 38;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(729, 116);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 39;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(810, 116);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 40;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "ALT+N: set an image check on mouseposition";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "ALT+C: disablr all prozess";
            // 
            // ImageChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 665);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnShowInfos);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.picScreen3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFillArray);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCompResult);
            this.Controls.Add(this.picScreen2);
            this.Controls.Add(this.picScreen1);
            this.Controls.Add(this.lblCurrentRepeat);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtRepeats);
            this.Controls.Add(this.btnEmpty);
            this.Controls.Add(this.lblExStat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.dataGridActionList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStartRecord);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImageChecker";
            this.Text = "Image Checker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ColorChecker_FormClosed);
            this.Load += new System.EventHandler(this.ColorChecker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActionList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScreen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScreen2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScreen3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStartRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridActionList;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Timer timerActionExecute;
        private System.Windows.Forms.Timer timerClickInterval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblExStat;
        private System.Windows.Forms.Button btnEmpty;
        private System.Windows.Forms.TextBox txtRepeats;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblCurrentRepeat;
        private System.Windows.Forms.PictureBox picScreen1;
        private System.Windows.Forms.PictureBox picScreen2;
        private System.Windows.Forms.Label lblCompResult;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnFillArray;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSec;
        private System.Windows.Forms.DataGridViewTextBoxColumn posX;
        private System.Windows.Forms.DataGridViewTextBoxColumn posY;
        private System.Windows.Forms.DataGridViewTextBoxColumn action;
        private System.Windows.Forms.DataGridViewTextBoxColumn addedInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentAccuracy;
        private System.Windows.Forms.DataGridViewTextBoxColumn picID;
        private System.Windows.Forms.Timer timerKeyCode;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picScreen3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnShowInfos;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

