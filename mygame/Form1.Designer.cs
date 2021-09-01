
namespace mygame
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
            this.txtammo = new System.Windows.Forms.Label();
            this.txtscore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.Player = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // txtammo
            // 
            this.txtammo.AutoSize = true;
            this.txtammo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtammo.ForeColor = System.Drawing.Color.White;
            this.txtammo.Location = new System.Drawing.Point(16, 33);
            this.txtammo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtammo.Name = "txtammo";
            this.txtammo.Size = new System.Drawing.Size(121, 31);
            this.txtammo.TabIndex = 0;
            this.txtammo.Text = "Ammo: 0";
            // 
            // txtscore
            // 
            this.txtscore.AutoSize = true;
            this.txtscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtscore.ForeColor = System.Drawing.Color.White;
            this.txtscore.Location = new System.Drawing.Point(492, 33);
            this.txtscore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtscore.Name = "txtscore";
            this.txtscore.Size = new System.Drawing.Size(94, 31);
            this.txtscore.TabIndex = 1;
            this.txtscore.Text = "Kills: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(883, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Health: ";
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(989, 36);
            this.healthBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(227, 28);
            this.healthBar.TabIndex = 3;
            this.healthBar.Value = 80;
            // 
            // Player
            // 
            this.Player.Image = global::mygame.Properties.Resources.up;
            this.Player.Location = new System.Drawing.Point(389, 170);
            this.Player.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(71, 100);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player.TabIndex = 4;
            this.Player.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(1232, 814);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtscore);
            this.Controls.Add(this.txtammo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "zombieshooter";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtammo;
        private System.Windows.Forms.Label txtscore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer GameTimer;
    }
}

