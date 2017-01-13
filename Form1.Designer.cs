namespace Prog3
{
    partial class prog3
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
            this.seniorBtn = new System.Windows.Forms.RadioButton();
            this.jrBtn = new System.Windows.Forms.RadioButton();
            this.sophBtn = new System.Windows.Forms.RadioButton();
            this.freshBtn = new System.Windows.Forms.RadioButton();
            this.lastNameInput = new System.Windows.Forms.TextBox();
            this.regTimeBtn = new System.Windows.Forms.Button();
            this.classLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.directionsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // seniorBtn
            // 
            this.seniorBtn.AutoSize = true;
            this.seniorBtn.Location = new System.Drawing.Point(30, 33);
            this.seniorBtn.Name = "seniorBtn";
            this.seniorBtn.Size = new System.Drawing.Size(55, 17);
            this.seniorBtn.TabIndex = 0;
            this.seniorBtn.TabStop = true;
            this.seniorBtn.Text = "Senior";
            this.seniorBtn.UseVisualStyleBackColor = true;
            // 
            // jrBtn
            // 
            this.jrBtn.AutoSize = true;
            this.jrBtn.Location = new System.Drawing.Point(30, 56);
            this.jrBtn.Name = "jrBtn";
            this.jrBtn.Size = new System.Drawing.Size(53, 17);
            this.jrBtn.TabIndex = 1;
            this.jrBtn.TabStop = true;
            this.jrBtn.Text = "Junior";
            this.jrBtn.UseVisualStyleBackColor = true;
            // 
            // sophBtn
            // 
            this.sophBtn.AutoSize = true;
            this.sophBtn.Location = new System.Drawing.Point(30, 79);
            this.sophBtn.Name = "sophBtn";
            this.sophBtn.Size = new System.Drawing.Size(79, 17);
            this.sophBtn.TabIndex = 2;
            this.sophBtn.TabStop = true;
            this.sophBtn.Text = "Sophomore";
            this.sophBtn.UseVisualStyleBackColor = true;
            // 
            // freshBtn
            // 
            this.freshBtn.AutoSize = true;
            this.freshBtn.Location = new System.Drawing.Point(30, 102);
            this.freshBtn.Name = "freshBtn";
            this.freshBtn.Size = new System.Drawing.Size(71, 17);
            this.freshBtn.TabIndex = 3;
            this.freshBtn.TabStop = true;
            this.freshBtn.Text = "Freshman";
            this.freshBtn.UseVisualStyleBackColor = true;
            // 
            // lastNameInput
            // 
            this.lastNameInput.Location = new System.Drawing.Point(172, 33);
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(100, 20);
            this.lastNameInput.TabIndex = 4;
            // 
            // regTimeBtn
            // 
            this.regTimeBtn.Location = new System.Drawing.Point(93, 151);
            this.regTimeBtn.Name = "regTimeBtn";
            this.regTimeBtn.Size = new System.Drawing.Size(93, 23);
            this.regTimeBtn.TabIndex = 5;
            this.regTimeBtn.Text = "Find Reg. Time";
            this.regTimeBtn.UseVisualStyleBackColor = true;
            this.regTimeBtn.Click += new System.EventHandler(this.regTimeBtn_Click);
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Location = new System.Drawing.Point(27, 17);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(80, 13);
            this.classLabel.TabIndex = 6;
            this.classLabel.Text = "Class Standing:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(169, 17);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(61, 13);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Last Name:";
            // 
            // directionsLabel
            // 
            this.directionsLabel.AutoSize = true;
            this.directionsLabel.Location = new System.Drawing.Point(15, 135);
            this.directionsLabel.Name = "directionsLabel";
            this.directionsLabel.Size = new System.Drawing.Size(257, 13);
            this.directionsLabel.TabIndex = 8;
            this.directionsLabel.Text = "Note that this is the EARLIEST time you may register.";
            // 
            // prog3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 186);
            this.Controls.Add(this.directionsLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.regTimeBtn);
            this.Controls.Add(this.lastNameInput);
            this.Controls.Add(this.freshBtn);
            this.Controls.Add(this.sophBtn);
            this.Controls.Add(this.jrBtn);
            this.Controls.Add(this.seniorBtn);
            this.Name = "prog3";
            this.Text = "Program 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton seniorBtn;
        private System.Windows.Forms.RadioButton jrBtn;
        private System.Windows.Forms.RadioButton sophBtn;
        private System.Windows.Forms.RadioButton freshBtn;
        private System.Windows.Forms.TextBox lastNameInput;
        private System.Windows.Forms.Button regTimeBtn;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label directionsLabel;
    }
}

