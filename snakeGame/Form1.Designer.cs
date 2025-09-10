namespace snakeGame
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblpuan = new System.Windows.Forms.Label();
            this.lblpuangosterge = new System.Windows.Forms.Label();
            this.lblstart = new System.Windows.Forms.Button();
            this.lbldurum = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Location = new System.Drawing.Point(38, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 613);
            this.panel1.TabIndex = 0;
            // 
            // lblpuan
            // 
            this.lblpuan.AutoSize = true;
            this.lblpuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblpuan.Location = new System.Drawing.Point(841, 101);
            this.lblpuan.Name = "lblpuan";
            this.lblpuan.Size = new System.Drawing.Size(122, 42);
            this.lblpuan.TabIndex = 1;
            this.lblpuan.Text = "PUAN";
            // 
            // lblpuangosterge
            // 
            this.lblpuangosterge.AutoSize = true;
            this.lblpuangosterge.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblpuangosterge.Location = new System.Drawing.Point(882, 152);
            this.lblpuangosterge.Name = "lblpuangosterge";
            this.lblpuangosterge.Size = new System.Drawing.Size(42, 46);
            this.lblpuangosterge.TabIndex = 2;
            this.lblpuangosterge.Text = "0";
            // 
            // lblstart
            // 
            this.lblstart.BackColor = System.Drawing.Color.Gold;
            this.lblstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblstart.Location = new System.Drawing.Point(822, 272);
            this.lblstart.Name = "lblstart";
            this.lblstart.Size = new System.Drawing.Size(158, 63);
            this.lblstart.TabIndex = 3;
            this.lblstart.Text = "BAŞLA";
            this.lblstart.UseVisualStyleBackColor = false;
            this.lblstart.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbldurum
            // 
            this.lbldurum.AutoSize = true;
            this.lbldurum.Font = new System.Drawing.Font("MS Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldurum.ForeColor = System.Drawing.Color.Red;
            this.lbldurum.Location = new System.Drawing.Point(804, 455);
            this.lbldurum.Name = "lbldurum";
            this.lbldurum.Size = new System.Drawing.Size(145, 47);
            this.lbldurum.TabIndex = 4;
            this.lbldurum.Text = "DURUM";
            this.lbldurum.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1090, 658);
            this.Controls.Add(this.lbldurum);
            this.Controls.Add(this.lblstart);
            this.Controls.Add(this.lblpuangosterge);
            this.Controls.Add(this.lblpuan);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblpuan;
        private System.Windows.Forms.Label lblpuangosterge;
        private System.Windows.Forms.Button lblstart;
        private System.Windows.Forms.Label lbldurum;
        private System.Windows.Forms.Timer timer1;
    }
}

