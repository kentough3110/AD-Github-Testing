namespace ADW02_TAKE_HOME
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
            this.label_nama = new System.Windows.Forms.Label();
            this.label_age = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_phoneNum = new System.Windows.Forms.Label();
            this.button_submit = new System.Windows.Forms.Button();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_age = new System.Windows.Forms.TextBox();
            this.textBox_phoneNum = new System.Windows.Forms.TextBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nama = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_nama
            // 
            this.label_nama.AutoSize = true;
            this.label_nama.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nama.Location = new System.Drawing.Point(118, 112);
            this.label_nama.Name = "label_nama";
            this.label_nama.Size = new System.Drawing.Size(67, 19);
            this.label_nama.TabIndex = 0;
            this.label_nama.Text = "Name :";
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_age.Location = new System.Drawing.Point(118, 235);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(55, 19);
            this.label_age.TabIndex = 1;
            this.label_age.Text = "Age : ";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(118, 172);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(68, 19);
            this.label_email.TabIndex = 2;
            this.label_email.Text = "Email : ";
            // 
            // label_phoneNum
            // 
            this.label_phoneNum.AutoSize = true;
            this.label_phoneNum.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phoneNum.Location = new System.Drawing.Point(118, 288);
            this.label_phoneNum.Name = "label_phoneNum";
            this.label_phoneNum.Size = new System.Drawing.Size(144, 19);
            this.label_phoneNum.TabIndex = 3;
            this.label_phoneNum.Text = "Phone Number : ";
            this.label_phoneNum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_submit
            // 
            this.button_submit.BackColor = System.Drawing.Color.ForestGreen;
            this.button_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_submit.ForeColor = System.Drawing.Color.White;
            this.button_submit.Location = new System.Drawing.Point(626, 392);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(149, 46);
            this.button_submit.TabIndex = 4;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = false;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(204, 169);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(232, 26);
            this.textBox_email.TabIndex = 6;
            // 
            // textBox_age
            // 
            this.textBox_age.Location = new System.Drawing.Point(204, 232);
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.Size = new System.Drawing.Size(232, 26);
            this.textBox_age.TabIndex = 7;
            // 
            // textBox_phoneNum
            // 
            this.textBox_phoneNum.Location = new System.Drawing.Point(291, 284);
            this.textBox_phoneNum.Name = "textBox_phoneNum";
            this.textBox_phoneNum.Size = new System.Drawing.Size(232, 26);
            this.textBox_phoneNum.TabIndex = 8;
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.Color.Red;
            this.button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clear.ForeColor = System.Drawing.Color.White;
            this.button_Clear.Location = new System.Drawing.Point(19, 392);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(149, 46);
            this.button_Clear.TabIndex = 9;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 44);
            this.label1.TabIndex = 10;
            this.label1.Text = "Biodata";
            // 
            // textBox_nama
            // 
            this.textBox_nama.Location = new System.Drawing.Point(204, 108);
            this.textBox_nama.Name = "textBox_nama";
            this.textBox_nama.Size = new System.Drawing.Size(232, 26);
            this.textBox_nama.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_nama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.textBox_phoneNum);
            this.Controls.Add(this.textBox_age);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.label_phoneNum);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_age);
            this.Controls.Add(this.label_nama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nama;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_phoneNum;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_age;
        private System.Windows.Forms.TextBox textBox_phoneNum;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nama;
    }
}

