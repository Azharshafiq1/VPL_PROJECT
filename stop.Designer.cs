namespace WindowsFormsApp
{
    partial class lb
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
            this.lbours = new System.Windows.Forms.Label();
            this.lbseconds = new System.Windows.Forms.Label();
            this.lbminutes = new System.Windows.Forms.Label();
            this.btnstart = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbours
            // 
            this.lbours.AutoSize = true;
            this.lbours.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbours.ForeColor = System.Drawing.Color.IndianRed;
            this.lbours.Location = new System.Drawing.Point(57, 138);
            this.lbours.Name = "lbours";
            this.lbours.Size = new System.Drawing.Size(231, 163);
            this.lbours.TabIndex = 0;
            this.lbours.Text = "00";
            // 
            // lbseconds
            // 
            this.lbseconds.AutoSize = true;
            this.lbseconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbseconds.ForeColor = System.Drawing.Color.IndianRed;
            this.lbseconds.Location = new System.Drawing.Point(843, 138);
            this.lbseconds.Name = "lbseconds";
            this.lbseconds.Size = new System.Drawing.Size(231, 163);
            this.lbseconds.TabIndex = 2;
            this.lbseconds.Text = "00";
            // 
            // lbminutes
            // 
            this.lbminutes.AutoSize = true;
            this.lbminutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbminutes.ForeColor = System.Drawing.Color.IndianRed;
            this.lbminutes.Location = new System.Drawing.Point(477, 138);
            this.lbminutes.Name = "lbminutes";
            this.lbminutes.Size = new System.Drawing.Size(231, 163);
            this.lbminutes.TabIndex = 3;
            this.lbminutes.Text = "00";
            // 
            // btnstart
            // 
            this.btnstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart.Location = new System.Drawing.Point(505, 366);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(165, 47);
            this.btnstart.TabIndex = 5;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // btnstop
            // 
            this.btnstop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstop.Location = new System.Drawing.Point(782, 366);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(165, 47);
            this.btnstop.TabIndex = 6;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // lb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 450);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.lbminutes);
            this.Controls.Add(this.lbseconds);
            this.Controls.Add(this.lbours);
            this.Name = "lb";
            this.Text = "stop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbours;
        private System.Windows.Forms.Label lbseconds;
        private System.Windows.Forms.Label lbminutes;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Timer timer1;
    }
}