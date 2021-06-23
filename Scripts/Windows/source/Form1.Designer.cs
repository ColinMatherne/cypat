
namespace cypat
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPassLen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.txtMinPassAge = new System.Windows.Forms.TextBox();
            this.txtMaxPassAge = new System.Windows.Forms.TextBox();
            this.cbPassComp = new System.Windows.Forms.CheckBox();
            this.cbPassEnc = new System.Windows.Forms.CheckBox();
            this.txtPassHist = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(713, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPassLen
            // 
            this.txtPassLen.Location = new System.Drawing.Point(13, 13);
            this.txtPassLen.Name = "txtPassLen";
            this.txtPassLen.Size = new System.Drawing.Size(35, 20);
            this.txtPassLen.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Recommended Password Length: 8";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(632, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(12, 415);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 4;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // txtMinPassAge
            // 
            this.txtMinPassAge.Location = new System.Drawing.Point(13, 39);
            this.txtMinPassAge.Name = "txtMinPassAge";
            this.txtMinPassAge.Size = new System.Drawing.Size(35, 20);
            this.txtMinPassAge.TabIndex = 5;
            // 
            // txtMaxPassAge
            // 
            this.txtMaxPassAge.Location = new System.Drawing.Point(13, 65);
            this.txtMaxPassAge.Name = "txtMaxPassAge";
            this.txtMaxPassAge.Size = new System.Drawing.Size(35, 20);
            this.txtMaxPassAge.TabIndex = 6;
            // 
            // cbPassComp
            // 
            this.cbPassComp.AutoSize = true;
            this.cbPassComp.Location = new System.Drawing.Point(12, 123);
            this.cbPassComp.Name = "cbPassComp";
            this.cbPassComp.Size = new System.Drawing.Size(177, 17);
            this.cbPassComp.TabIndex = 7;
            this.cbPassComp.Text = "Enable Password Complexability";
            this.cbPassComp.UseVisualStyleBackColor = true;
            // 
            // cbPassEnc
            // 
            this.cbPassEnc.AutoSize = true;
            this.cbPassEnc.Location = new System.Drawing.Point(12, 156);
            this.cbPassEnc.Name = "cbPassEnc";
            this.cbPassEnc.Size = new System.Drawing.Size(163, 17);
            this.cbPassEnc.TabIndex = 8;
            this.cbPassEnc.Text = "Disable Password Encryption";
            this.cbPassEnc.UseVisualStyleBackColor = true;
            // 
            // txtPassHist
            // 
            this.txtPassHist.Location = new System.Drawing.Point(13, 92);
            this.txtPassHist.Name = "txtPassHist";
            this.txtPassHist.Size = new System.Drawing.Size(35, 20);
            this.txtPassHist.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Recommended Minimum Password Age: 10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Recommended Maximum Password Age: 30";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Recommended Password History: 5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassHist);
            this.Controls.Add(this.cbPassEnc);
            this.Controls.Add(this.cbPassComp);
            this.Controls.Add(this.txtMaxPassAge);
            this.Controls.Add(this.txtMinPassAge);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassLen);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPassLen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.TextBox txtMinPassAge;
        private System.Windows.Forms.TextBox txtMaxPassAge;
        private System.Windows.Forms.CheckBox cbPassComp;
        private System.Windows.Forms.CheckBox cbPassEnc;
        private System.Windows.Forms.TextBox txtPassHist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

