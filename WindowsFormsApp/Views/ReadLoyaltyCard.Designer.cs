
namespace WindowsFormsApp.Views
{
    partial class ReadLoyaltyCard
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.phoneNo = new System.Windows.Forms.TextBox();
            this.textChangeValue = new System.Windows.Forms.TextBox();
            this.value = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cardNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCamera2 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TextError = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.AccessibleName = "txtPhoneNo";
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnSave.Location = new System.Drawing.Point(676, 312);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 93);
            this.btnSave.TabIndex = 211;
            this.btnSave.Text = " Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnClear.Location = new System.Drawing.Point(684, 45);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(56, 76);
            this.btnClear.TabIndex = 210;
            this.btnClear.Text = "Clear";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(536, 168);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(224, 20);
            this.name.TabIndex = 205;
            // 
            // phoneNo
            // 
            this.phoneNo.Location = new System.Drawing.Point(536, 196);
            this.phoneNo.Name = "phoneNo";
            this.phoneNo.Size = new System.Drawing.Size(224, 20);
            this.phoneNo.TabIndex = 206;
            // 
            // textChangeValue
            // 
            this.textChangeValue.Location = new System.Drawing.Point(536, 278);
            this.textChangeValue.Name = "textChangeValue";
            this.textChangeValue.Size = new System.Drawing.Size(224, 20);
            this.textChangeValue.TabIndex = 207;
            // 
            // value
            // 
            this.value.Location = new System.Drawing.Point(536, 222);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(224, 20);
            this.value.TabIndex = 208;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(420, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 199;
            this.label6.Text = "New Value :";
            // 
            // cardNo
            // 
            this.cardNo.Location = new System.Drawing.Point(536, 140);
            this.cardNo.Name = "cardNo";
            this.cardNo.Size = new System.Drawing.Size(224, 20);
            this.cardNo.TabIndex = 209;
            this.cardNo.Text = " ";
            this.cardNo.TextChanged += new System.EventHandler(this.cardNo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 200;
            this.label5.Text = "Value :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 201;
            this.label3.Text = "Phene Number :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 202;
            this.label2.Text = "Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 203;
            this.label4.Text = "Loyalty Card Number :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 204;
            this.label1.Text = "Camera :";
            // 
            // cboCamera2
            // 
            this.cboCamera2.FormattingEnabled = true;
            this.cboCamera2.Location = new System.Drawing.Point(153, 56);
            this.cboCamera2.Name = "cboCamera2";
            this.cboCamera2.Size = new System.Drawing.Size(216, 21);
            this.cboCamera2.TabIndex = 198;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(43, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 252);
            this.pictureBox1.TabIndex = 197;
            this.pictureBox1.TabStop = false;
            // 
            // TextError
            // 
            this.TextError.Location = new System.Drawing.Point(167, 100);
            this.TextError.Name = "TextError";
            this.TextError.Size = new System.Drawing.Size(348, 20);
            this.TextError.TabIndex = 212;
            this.TextError.Text = "Error";
            // 
            // ReadLoyaltyCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextError);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.name);
            this.Controls.Add(this.phoneNo);
            this.Controls.Add(this.textChangeValue);
            this.Controls.Add(this.value);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cardNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCamera2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ReadLoyaltyCard";
            this.Text = "ReadLoyaltyCard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReadLoyaltyCard_FormClosing);
            this.Load += new System.EventHandler(this.ReadLoyaltyCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox phoneNo;
        private System.Windows.Forms.TextBox textChangeValue;
        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cardNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCamera2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TextError;
    }
}