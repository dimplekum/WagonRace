namespace WagonRace
{
    partial class Form1
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
            this.TrackLengthPanel = new System.Windows.Forms.Panel();
            this.wagon_yellow = new System.Windows.Forms.PictureBox();
            this.wagon_blue = new System.Windows.Forms.PictureBox();
            this.wagon_red = new System.Windows.Forms.PictureBox();
            this.wagon_black = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.PlaceBet = new System.Windows.Forms.Button();
            this.StartRace = new System.Windows.Forms.Button();
            this.TickingTimer = new System.Windows.Forms.Timer(this.components);
            this.TrackLengthPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wagon_yellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wagon_blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wagon_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wagon_black)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // TrackLengthPanel
            // 
            this.TrackLengthPanel.Controls.Add(this.wagon_yellow);
            this.TrackLengthPanel.Controls.Add(this.wagon_blue);
            this.TrackLengthPanel.Controls.Add(this.wagon_red);
            this.TrackLengthPanel.Controls.Add(this.wagon_black);
            this.TrackLengthPanel.Location = new System.Drawing.Point(17, 16);
            this.TrackLengthPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TrackLengthPanel.Name = "TrackLengthPanel";
            this.TrackLengthPanel.Size = new System.Drawing.Size(1652, 512);
            this.TrackLengthPanel.TabIndex = 0;
            this.TrackLengthPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TrackLengthPanel_Paint);
            // 
            // wagon_yellow
            // 
            this.wagon_yellow.Image = global::WagonRace.Properties.Resources.coal__3_;
            this.wagon_yellow.Location = new System.Drawing.Point(5, 404);
            this.wagon_yellow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wagon_yellow.Name = "wagon_yellow";
            this.wagon_yellow.Size = new System.Drawing.Size(113, 105);
            this.wagon_yellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wagon_yellow.TabIndex = 3;
            this.wagon_yellow.TabStop = false;
            // 
            // wagon_blue
            // 
            this.wagon_blue.Image = global::WagonRace.Properties.Resources.coal;
            this.wagon_blue.Location = new System.Drawing.Point(5, 270);
            this.wagon_blue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wagon_blue.Name = "wagon_blue";
            this.wagon_blue.Size = new System.Drawing.Size(113, 105);
            this.wagon_blue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wagon_blue.TabIndex = 2;
            this.wagon_blue.TabStop = false;
            // 
            // wagon_red
            // 
            this.wagon_red.Image = global::WagonRace.Properties.Resources.coal__2_;
            this.wagon_red.Location = new System.Drawing.Point(5, 132);
            this.wagon_red.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wagon_red.Name = "wagon_red";
            this.wagon_red.Size = new System.Drawing.Size(113, 105);
            this.wagon_red.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wagon_red.TabIndex = 1;
            this.wagon_red.TabStop = false;
            // 
            // wagon_black
            // 
            this.wagon_black.Image = global::WagonRace.Properties.Resources.coal__1_;
            this.wagon_black.Location = new System.Drawing.Point(5, 5);
            this.wagon_black.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wagon_black.Name = "wagon_black";
            this.wagon_black.Size = new System.Drawing.Size(113, 105);
            this.wagon_black.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wagon_black.TabIndex = 0;
            this.wagon_black.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(23, 537);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(110, 21);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(23, 566);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(110, 21);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(23, 596);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(110, 21);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(567, 537);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(567, 566);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(567, 596);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 716);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bet Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 751);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Betting Wagon";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(232, 714);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            995,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(160, 22);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(232, 748);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(160, 22);
            this.numericUpDown2.TabIndex = 10;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PlaceBet
            // 
            this.PlaceBet.Location = new System.Drawing.Point(471, 710);
            this.PlaceBet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PlaceBet.Name = "PlaceBet";
            this.PlaceBet.Size = new System.Drawing.Size(269, 63);
            this.PlaceBet.TabIndex = 11;
            this.PlaceBet.Text = "Place Bet";
            this.PlaceBet.UseVisualStyleBackColor = true;
            this.PlaceBet.Click += new System.EventHandler(this.PlaceBet_Click);
            // 
            // StartRace
            // 
            this.StartRace.Location = new System.Drawing.Point(880, 710);
            this.StartRace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartRace.Name = "StartRace";
            this.StartRace.Size = new System.Drawing.Size(280, 63);
            this.StartRace.TabIndex = 12;
            this.StartRace.Text = "Start Race";
            this.StartRace.UseVisualStyleBackColor = true;
            this.StartRace.Click += new System.EventHandler(this.StartRace_Click);
            // 
            // TickingTimer
            // 
            this.TickingTimer.Tick += new System.EventHandler(this.TickingTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.StartRace);
            this.Controls.Add(this.PlaceBet);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.TrackLengthPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TrackLengthPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wagon_yellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wagon_blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wagon_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wagon_black)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TrackLengthPanel;
        private System.Windows.Forms.PictureBox wagon_yellow;
        private System.Windows.Forms.PictureBox wagon_blue;
        private System.Windows.Forms.PictureBox wagon_red;
        private System.Windows.Forms.PictureBox wagon_black;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button PlaceBet;
        private System.Windows.Forms.Button StartRace;
        private System.Windows.Forms.Timer TickingTimer;
    }
}

