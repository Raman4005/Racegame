
namespace RacingGame
{
    partial class GamePlay
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
            this.Race_btn = new System.Windows.Forms.Button();
            this.moneyselect = new System.Windows.Forms.NumericUpDown();
            this.label_bucks = new System.Windows.Forms.Label();
            this.Bettorselect = new System.Windows.Forms.NumericUpDown();
            this.bet_btn = new System.Windows.Forms.Button();
            this.Bettor_name = new System.Windows.Forms.Label();
            this.labelMinBet = new System.Windows.Forms.Label();
            this.betrd3 = new System.Windows.Forms.RadioButton();
            this.Betrd2 = new System.Windows.Forms.RadioButton();
            this.betrd1 = new System.Windows.Forms.RadioButton();
            this.labelbettor3 = new System.Windows.Forms.Label();
            this.labelbettor2 = new System.Windows.Forms.Label();
            this.labelBettor1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.racerpb1 = new System.Windows.Forms.PictureBox();
            this.racerpb4 = new System.Windows.Forms.PictureBox();
            this.racerpb3 = new System.Windows.Forms.PictureBox();
            this.racerpb2 = new System.Windows.Forms.PictureBox();
            this.tp_pb5 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.moneyselect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bettorselect)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racerpb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racerpb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racerpb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racerpb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp_pb5)).BeginInit();
            this.SuspendLayout();
            // 
            // Race_btn
            // 
            this.Race_btn.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.Race_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Race_btn.Font = new System.Drawing.Font("Nirmala UI Semilight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Race_btn.ForeColor = System.Drawing.Color.Snow;
            this.Race_btn.Location = new System.Drawing.Point(652, 141);
            this.Race_btn.Name = "Race_btn";
            this.Race_btn.Size = new System.Drawing.Size(208, 59);
            this.Race_btn.TabIndex = 24;
            this.Race_btn.Text = "RACE";
            this.Race_btn.UseVisualStyleBackColor = false;
            this.Race_btn.Click += new System.EventHandler(this.Race_btn_Click);
            // 
            // moneyselect
            // 
            this.moneyselect.BackColor = System.Drawing.SystemColors.WindowText;
            this.moneyselect.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.moneyselect.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyselect.ForeColor = System.Drawing.Color.Peru;
            this.moneyselect.Location = new System.Drawing.Point(398, 169);
            this.moneyselect.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.moneyselect.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.moneyselect.Name = "moneyselect";
            this.moneyselect.Size = new System.Drawing.Size(117, 35);
            this.moneyselect.TabIndex = 23;
            this.moneyselect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.moneyselect.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_bucks
            // 
            this.label_bucks.AutoSize = true;
            this.label_bucks.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bucks.ForeColor = System.Drawing.Color.Peru;
            this.label_bucks.Location = new System.Drawing.Point(395, 149);
            this.label_bucks.Name = "label_bucks";
            this.label_bucks.Size = new System.Drawing.Size(85, 17);
            this.label_bucks.TabIndex = 22;
            this.label_bucks.Text = "Dog Number";
            // 
            // Bettorselect
            // 
            this.Bettorselect.BackColor = System.Drawing.SystemColors.InfoText;
            this.Bettorselect.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Bettorselect.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bettorselect.ForeColor = System.Drawing.Color.Peru;
            this.Bettorselect.Location = new System.Drawing.Point(398, 93);
            this.Bettorselect.Name = "Bettorselect";
            this.Bettorselect.Size = new System.Drawing.Size(113, 35);
            this.Bettorselect.TabIndex = 21;
            this.Bettorselect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Bettorselect.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // bet_btn
            // 
            this.bet_btn.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.bet_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bet_btn.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bet_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.bet_btn.Location = new System.Drawing.Point(598, 58);
            this.bet_btn.Name = "bet_btn";
            this.bet_btn.Size = new System.Drawing.Size(299, 43);
            this.bet_btn.TabIndex = 20;
            this.bet_btn.Text = "Bets";
            this.bet_btn.UseVisualStyleBackColor = false;
            this.bet_btn.Click += new System.EventHandler(this.bet_btn_Click);
            // 
            // Bettor_name
            // 
            this.Bettor_name.AutoSize = true;
            this.Bettor_name.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bettor_name.ForeColor = System.Drawing.Color.Peru;
            this.Bettor_name.Location = new System.Drawing.Point(395, 73);
            this.Bettor_name.Name = "Bettor_name";
            this.Bettor_name.Size = new System.Drawing.Size(75, 17);
            this.Bettor_name.TabIndex = 19;
            this.Bettor_name.Text = "Bet Amount";
            // 
            // labelMinBet
            // 
            this.labelMinBet.AutoSize = true;
            this.labelMinBet.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinBet.ForeColor = System.Drawing.Color.Peru;
            this.labelMinBet.Location = new System.Drawing.Point(-7, 22);
            this.labelMinBet.Name = "labelMinBet";
            this.labelMinBet.Size = new System.Drawing.Size(94, 25);
            this.labelMinBet.TabIndex = 18;
            this.labelMinBet.Text = "BET HERE";
            this.labelMinBet.Click += new System.EventHandler(this.labelMinBet_Click);
            // 
            // betrd3
            // 
            this.betrd3.AutoSize = true;
            this.betrd3.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betrd3.ForeColor = System.Drawing.Color.Peru;
            this.betrd3.Location = new System.Drawing.Point(22, 165);
            this.betrd3.Name = "betrd3";
            this.betrd3.Size = new System.Drawing.Size(71, 21);
            this.betrd3.TabIndex = 15;
            this.betrd3.Text = "Better 3";
            this.betrd3.UseVisualStyleBackColor = true;
            this.betrd3.CheckedChanged += new System.EventHandler(this.betrd3_CheckedChanged);
            // 
            // Betrd2
            // 
            this.Betrd2.AutoSize = true;
            this.Betrd2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Betrd2.ForeColor = System.Drawing.Color.Peru;
            this.Betrd2.Location = new System.Drawing.Point(22, 105);
            this.Betrd2.Name = "Betrd2";
            this.Betrd2.Size = new System.Drawing.Size(67, 21);
            this.Betrd2.TabIndex = 16;
            this.Betrd2.Text = "Better2";
            this.Betrd2.UseVisualStyleBackColor = true;
            this.Betrd2.CheckedChanged += new System.EventHandler(this.Betrd2_CheckedChanged);
            // 
            // betrd1
            // 
            this.betrd1.AutoSize = true;
            this.betrd1.BackColor = System.Drawing.Color.Transparent;
            this.betrd1.Checked = true;
            this.betrd1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betrd1.ForeColor = System.Drawing.Color.Peru;
            this.betrd1.Location = new System.Drawing.Point(22, 49);
            this.betrd1.Name = "betrd1";
            this.betrd1.Size = new System.Drawing.Size(71, 21);
            this.betrd1.TabIndex = 17;
            this.betrd1.TabStop = true;
            this.betrd1.Text = "Better1";
            this.betrd1.UseVisualStyleBackColor = false;
            this.betrd1.CheckedChanged += new System.EventHandler(this.betrd1_CheckedChanged);
            // 
            // labelbettor3
            // 
            this.labelbettor3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelbettor3.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbettor3.ForeColor = System.Drawing.Color.Peru;
            this.labelbettor3.Location = new System.Drawing.Point(22, 189);
            this.labelbettor3.Name = "labelbettor3";
            this.labelbettor3.Size = new System.Drawing.Size(313, 23);
            this.labelbettor3.TabIndex = 12;
            this.labelbettor3.Text = "Third Bettor Here";
            this.labelbettor3.Click += new System.EventHandler(this.labelbettor3_Click);
            // 
            // labelbettor2
            // 
            this.labelbettor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelbettor2.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbettor2.ForeColor = System.Drawing.Color.Peru;
            this.labelbettor2.Location = new System.Drawing.Point(24, 129);
            this.labelbettor2.Name = "labelbettor2";
            this.labelbettor2.Size = new System.Drawing.Size(311, 23);
            this.labelbettor2.TabIndex = 13;
            this.labelbettor2.Text = "Second Bettor Here";
            this.labelbettor2.Click += new System.EventHandler(this.labelbettor2_Click);
            // 
            // labelBettor1
            // 
            this.labelBettor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBettor1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBettor1.ForeColor = System.Drawing.Color.Peru;
            this.labelBettor1.Location = new System.Drawing.Point(24, 73);
            this.labelBettor1.Name = "labelBettor1";
            this.labelBettor1.Size = new System.Drawing.Size(311, 23);
            this.labelBettor1.TabIndex = 14;
            this.labelBettor1.Text = "First Better Here";
            this.labelBettor1.Click += new System.EventHandler(this.labelBettor1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Race_btn);
            this.groupBox1.Controls.Add(this.labelBettor1);
            this.groupBox1.Controls.Add(this.moneyselect);
            this.groupBox1.Controls.Add(this.labelbettor2);
            this.groupBox1.Controls.Add(this.label_bucks);
            this.groupBox1.Controls.Add(this.labelbettor3);
            this.groupBox1.Controls.Add(this.Bettorselect);
            this.groupBox1.Controls.Add(this.betrd1);
            this.groupBox1.Controls.Add(this.bet_btn);
            this.groupBox1.Controls.Add(this.Betrd2);
            this.groupBox1.Controls.Add(this.Bettor_name);
            this.groupBox1.Controls.Add(this.betrd3);
            this.groupBox1.Controls.Add(this.labelMinBet);
            this.groupBox1.Location = new System.Drawing.Point(12, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(917, 221);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // racerpb1
            // 
            this.racerpb1.BackColor = System.Drawing.Color.Transparent;
            this.racerpb1.Image = global::RacingGame.Properties.Resources.p1;
            this.racerpb1.Location = new System.Drawing.Point(10, 20);
            this.racerpb1.Name = "racerpb1";
            this.racerpb1.Size = new System.Drawing.Size(124, 57);
            this.racerpb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racerpb1.TabIndex = 26;
            this.racerpb1.TabStop = false;
            // 
            // racerpb4
            // 
            this.racerpb4.BackColor = System.Drawing.Color.Transparent;
            this.racerpb4.Image = global::RacingGame.Properties.Resources.p4;
            this.racerpb4.Location = new System.Drawing.Point(12, 210);
            this.racerpb4.Name = "racerpb4";
            this.racerpb4.Size = new System.Drawing.Size(122, 57);
            this.racerpb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racerpb4.TabIndex = 27;
            this.racerpb4.TabStop = false;
            // 
            // racerpb3
            // 
            this.racerpb3.BackColor = System.Drawing.Color.Transparent;
            this.racerpb3.Image = global::RacingGame.Properties.Resources.p3;
            this.racerpb3.Location = new System.Drawing.Point(12, 144);
            this.racerpb3.Name = "racerpb3";
            this.racerpb3.Size = new System.Drawing.Size(122, 57);
            this.racerpb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racerpb3.TabIndex = 28;
            this.racerpb3.TabStop = false;
            // 
            // racerpb2
            // 
            this.racerpb2.BackColor = System.Drawing.Color.Transparent;
            this.racerpb2.Image = global::RacingGame.Properties.Resources.p2;
            this.racerpb2.Location = new System.Drawing.Point(10, 81);
            this.racerpb2.Name = "racerpb2";
            this.racerpb2.Size = new System.Drawing.Size(124, 57);
            this.racerpb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racerpb2.TabIndex = 29;
            this.racerpb2.TabStop = false;
            // 
            // tp_pb5
            // 
            this.tp_pb5.BackColor = System.Drawing.SystemColors.Control;
            this.tp_pb5.Location = new System.Drawing.Point(10, 16);
            this.tp_pb5.Name = "tp_pb5";
            this.tp_pb5.Size = new System.Drawing.Size(862, 268);
            this.tp_pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tp_pb5.TabIndex = 30;
            this.tp_pb5.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // GamePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 523);
            this.Controls.Add(this.racerpb1);
            this.Controls.Add(this.racerpb4);
            this.Controls.Add(this.racerpb3);
            this.Controls.Add(this.racerpb2);
            this.Controls.Add(this.tp_pb5);
            this.Controls.Add(this.groupBox1);
            this.Name = "GamePlay";
            this.Text = "GamePlay";
            this.Load += new System.EventHandler(this.GamePlay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moneyselect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bettorselect)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racerpb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racerpb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racerpb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racerpb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp_pb5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Race_btn;
        private System.Windows.Forms.NumericUpDown moneyselect;
        private System.Windows.Forms.Label label_bucks;
        private System.Windows.Forms.NumericUpDown Bettorselect;
        private System.Windows.Forms.Button bet_btn;
        private System.Windows.Forms.Label Bettor_name;
        private System.Windows.Forms.Label labelMinBet;
        private System.Windows.Forms.RadioButton betrd3;
        private System.Windows.Forms.RadioButton Betrd2;
        private System.Windows.Forms.RadioButton betrd1;
        private System.Windows.Forms.Label labelbettor3;
        private System.Windows.Forms.Label labelbettor2;
        private System.Windows.Forms.Label labelBettor1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox racerpb1;
        private System.Windows.Forms.PictureBox racerpb4;
        private System.Windows.Forms.PictureBox racerpb3;
        private System.Windows.Forms.PictureBox racerpb2;
        private System.Windows.Forms.PictureBox tp_pb5;
        private System.Windows.Forms.Timer timer;
    }
}