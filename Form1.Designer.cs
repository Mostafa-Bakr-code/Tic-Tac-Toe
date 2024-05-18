namespace Tic_Tac_Toe_Game
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.lbwinner = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbactiveplayer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbscorep2 = new System.Windows.Forms.Label();
            this.lbscorep1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pb9 = new System.Windows.Forms.PictureBox();
            this.pb8 = new System.Windows.Forms.PictureBox();
            this.pb7 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnreset);
            this.groupBox1.Controls.Add(this.lbwinner);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbactiveplayer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(37, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 364);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.Red;
            this.btnreset.Location = new System.Drawing.Point(33, 300);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(140, 49);
            this.btnreset.TabIndex = 4;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // lbwinner
            // 
            this.lbwinner.AutoSize = true;
            this.lbwinner.ForeColor = System.Drawing.Color.Yellow;
            this.lbwinner.Location = new System.Drawing.Point(15, 212);
            this.lbwinner.Name = "lbwinner";
            this.lbwinner.Size = new System.Drawing.Size(73, 42);
            this.lbwinner.TabIndex = 3;
            this.lbwinner.Text = "Tie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Winner";
            // 
            // lbactiveplayer
            // 
            this.lbactiveplayer.AutoSize = true;
            this.lbactiveplayer.ForeColor = System.Drawing.Color.Yellow;
            this.lbactiveplayer.Location = new System.Drawing.Point(15, 88);
            this.lbactiveplayer.Name = "lbactiveplayer";
            this.lbactiveplayer.Size = new System.Drawing.Size(0, 42);
            this.lbactiveplayer.TabIndex = 1;
            this.lbactiveplayer.Tag = "Player 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Turn";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.lbscorep2);
            this.groupBox3.Controls.Add(this.lbscorep1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(30, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 59);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // lbscorep2
            // 
            this.lbscorep2.AutoSize = true;
            this.lbscorep2.Location = new System.Drawing.Point(167, 36);
            this.lbscorep2.Name = "lbscorep2";
            this.lbscorep2.Size = new System.Drawing.Size(19, 20);
            this.lbscorep2.TabIndex = 3;
            this.lbscorep2.Tag = "0";
            this.lbscorep2.Text = "0";
            // 
            // lbscorep1
            // 
            this.lbscorep1.AutoSize = true;
            this.lbscorep1.Location = new System.Drawing.Point(25, 36);
            this.lbscorep1.Name = "lbscorep1";
            this.lbscorep1.Size = new System.Drawing.Size(19, 20);
            this.lbscorep1.TabIndex = 2;
            this.lbscorep1.Tag = "0";
            this.lbscorep1.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Player-2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Player-1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pb9);
            this.groupBox2.Controls.Add(this.pb8);
            this.groupBox2.Controls.Add(this.pb7);
            this.groupBox2.Controls.Add(this.pb6);
            this.groupBox2.Controls.Add(this.pb5);
            this.groupBox2.Controls.Add(this.pb4);
            this.groupBox2.Controls.Add(this.pb3);
            this.groupBox2.Controls.Add(this.pb2);
            this.groupBox2.Controls.Add(this.pb1);
            this.groupBox2.Location = new System.Drawing.Point(299, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 419);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // pb9
            // 
            this.pb9.Image = global::Tic_Tac_Toe_Game.Properties.Resources.questionmark;
            this.pb9.Location = new System.Drawing.Point(336, 298);
            this.pb9.Name = "pb9";
            this.pb9.Size = new System.Drawing.Size(124, 112);
            this.pb9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb9.TabIndex = 11;
            this.pb9.TabStop = false;
            this.pb9.Tag = "9";
            this.pb9.Click += new System.EventHandler(this.pb9_Click);
            // 
            // pb8
            // 
            this.pb8.Image = global::Tic_Tac_Toe_Game.Properties.Resources.questionmark;
            this.pb8.Location = new System.Drawing.Point(180, 298);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(124, 112);
            this.pb8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb8.TabIndex = 10;
            this.pb8.TabStop = false;
            this.pb8.Tag = "8";
            this.pb8.Click += new System.EventHandler(this.pb8_Click);
            // 
            // pb7
            // 
            this.pb7.Image = global::Tic_Tac_Toe_Game.Properties.Resources.questionmark;
            this.pb7.Location = new System.Drawing.Point(24, 298);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(124, 112);
            this.pb7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb7.TabIndex = 9;
            this.pb7.TabStop = false;
            this.pb7.Tag = "7";
            this.pb7.Click += new System.EventHandler(this.pb7_Click);
            // 
            // pb6
            // 
            this.pb6.Image = global::Tic_Tac_Toe_Game.Properties.Resources.questionmark;
            this.pb6.Location = new System.Drawing.Point(336, 160);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(124, 112);
            this.pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb6.TabIndex = 8;
            this.pb6.TabStop = false;
            this.pb6.Tag = "6";
            this.pb6.Click += new System.EventHandler(this.pb6_Click);
            // 
            // pb5
            // 
            this.pb5.Image = global::Tic_Tac_Toe_Game.Properties.Resources.questionmark;
            this.pb5.Location = new System.Drawing.Point(180, 160);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(124, 112);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb5.TabIndex = 7;
            this.pb5.TabStop = false;
            this.pb5.Tag = "5";
            this.pb5.Click += new System.EventHandler(this.pb5_Click);
            // 
            // pb4
            // 
            this.pb4.Image = global::Tic_Tac_Toe_Game.Properties.Resources.questionmark;
            this.pb4.Location = new System.Drawing.Point(24, 160);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(124, 112);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb4.TabIndex = 6;
            this.pb4.TabStop = false;
            this.pb4.Tag = "4";
            this.pb4.Click += new System.EventHandler(this.pb4_Click);
            // 
            // pb3
            // 
            this.pb3.Image = global::Tic_Tac_Toe_Game.Properties.Resources.questionmark;
            this.pb3.Location = new System.Drawing.Point(336, 21);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(124, 112);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb3.TabIndex = 5;
            this.pb3.TabStop = false;
            this.pb3.Tag = "3";
            this.pb3.Click += new System.EventHandler(this.pb3_Click);
            // 
            // pb2
            // 
            this.pb2.Image = global::Tic_Tac_Toe_Game.Properties.Resources.questionmark;
            this.pb2.InitialImage = global::Tic_Tac_Toe_Game.Properties.Resources.questionmark;
            this.pb2.Location = new System.Drawing.Point(180, 21);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(124, 112);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 4;
            this.pb2.TabStop = false;
            this.pb2.Tag = "2";
            this.pb2.Click += new System.EventHandler(this.pb2_Click);
            // 
            // pb1
            // 
            this.pb1.Image = global::Tic_Tac_Toe_Game.Properties.Resources.questionmark;
            this.pb1.Location = new System.Drawing.Point(24, 21);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(124, 112);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 3;
            this.pb1.TabStop = false;
            this.pb1.Tag = "1";
            this.pb1.Click += new System.EventHandler(this.pb1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbwinner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbactiveplayer;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbscorep2;
        private System.Windows.Forms.Label lbscorep1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.PictureBox pb7;
        private System.Windows.Forms.PictureBox pb8;
        private System.Windows.Forms.PictureBox pb9;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

