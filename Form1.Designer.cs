namespace WindowsFormsApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtuserpassword = new System.Windows.Forms.TextBox();
            this.btnlo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label1.Location = new System.Drawing.Point(211, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(564, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wellcome To My Project";
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(411, 126);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(455, 44);
            this.txtusername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Your Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(340, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter Your Password";
            // 
            // txtuserpassword
            // 
            this.txtuserpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuserpassword.Location = new System.Drawing.Point(411, 200);
            this.txtuserpassword.Name = "txtuserpassword";
            this.txtuserpassword.PasswordChar = '*';
            this.txtuserpassword.Size = new System.Drawing.Size(455, 44);
            this.txtuserpassword.TabIndex = 3;
            // 
            // btnlo
            // 
            this.btnlo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnlo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlo.ForeColor = System.Drawing.Color.Snow;
            this.btnlo.Location = new System.Drawing.Point(373, 308);
            this.btnlo.Name = "btnlo";
            this.btnlo.Size = new System.Drawing.Size(219, 69);
            this.btnlo.TabIndex = 5;
            this.btnlo.Text = "Login";
            this.btnlo.UseVisualStyleBackColor = false;
            this.btnlo.Click += new System.EventHandler(this.btnlo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(621, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 69);
            this.button1.TabIndex = 6;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnlo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnlo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtuserpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Registration Form";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtuserpassword;
        private System.Windows.Forms.Button btnlo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

