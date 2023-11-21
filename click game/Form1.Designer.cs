namespace click_game
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
            this.harf = new System.Windows.Forms.Label();
            this.sure = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Skor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hatalitus = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // harf
            // 
            this.harf.AutoSize = true;
            this.harf.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harf.ForeColor = System.Drawing.Color.Maroon;
            this.harf.Location = new System.Drawing.Point(79, 65);
            this.harf.Name = "harf";
            this.harf.Size = new System.Drawing.Size(109, 108);
            this.harf.TabIndex = 0;
            this.harf.Text = "A";
            this.harf.Click += new System.EventHandler(this.harf_Click);
            // 
            // sure
            // 
            this.sure.AutoSize = true;
            this.sure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sure.ForeColor = System.Drawing.SystemColors.Control;
            this.sure.Location = new System.Drawing.Point(210, 9);
            this.sure.Name = "sure";
            this.sure.Size = new System.Drawing.Size(30, 24);
            this.sure.TabIndex = 1;
            this.sure.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Skor:";
            // 
            // Skor
            // 
            this.Skor.AutoSize = true;
            this.Skor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Skor.ForeColor = System.Drawing.SystemColors.Control;
            this.Skor.Location = new System.Drawing.Point(58, 9);
            this.Skor.Name = "Skor";
            this.Skor.Size = new System.Drawing.Size(20, 24);
            this.Skor.TabIndex = 3;
            this.Skor.Text = "0";
            this.Skor.Click += new System.EventHandler(this.Skor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hatalı Basılan Tuş Sayısı:";
            // 
            // hatalitus
            // 
            this.hatalitus.AutoSize = true;
            this.hatalitus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hatalitus.ForeColor = System.Drawing.SystemColors.Control;
            this.hatalitus.Location = new System.Drawing.Point(228, 214);
            this.hatalitus.Name = "hatalitus";
            this.hatalitus.Size = new System.Drawing.Size(20, 24);
            this.hatalitus.TabIndex = 5;
            this.hatalitus.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(260, 261);
            this.Controls.Add(this.hatalitus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Skor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sure);
            this.Controls.Add(this.harf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BasKazan!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label harf;
        private System.Windows.Forms.Label sure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Skor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hatalitus;
        private System.Windows.Forms.Timer timer1;
    }
}

