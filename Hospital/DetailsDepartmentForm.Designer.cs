namespace Hospital
{
    partial class DetailsDepartmentForm
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label okpoLabel;
            this.addressInput = new System.Windows.Forms.TextBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.profileInput = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            okpoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(81, 49);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(38, 13);
            label2.TabIndex = 29;
            label2.Text = "Адрес";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(62, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(57, 13);
            label1.TabIndex = 27;
            label1.Text = "Название";
            // 
            // okpoLabel
            // 
            okpoLabel.AutoSize = true;
            okpoLabel.Location = new System.Drawing.Point(66, 85);
            okpoLabel.Name = "okpoLabel";
            okpoLabel.Size = new System.Drawing.Size(53, 13);
            okpoLabel.TabIndex = 25;
            okpoLabel.Text = "Профиль";
            // 
            // addressInput
            // 
            this.addressInput.Location = new System.Drawing.Point(125, 46);
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(322, 20);
            this.addressInput.TabIndex = 30;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(125, 12);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(322, 20);
            this.nameInput.TabIndex = 28;
            // 
            // profileInput
            // 
            this.profileInput.Location = new System.Drawing.Point(125, 82);
            this.profileInput.Name = "profileInput";
            this.profileInput.Size = new System.Drawing.Size(322, 20);
            this.profileInput.TabIndex = 26;
            // 
            // DetailsDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 116);
            this.Controls.Add(this.addressInput);
            this.Controls.Add(label2);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(label1);
            this.Controls.Add(this.profileInput);
            this.Controls.Add(okpoLabel);
            this.Name = "DetailsDepartmentForm";
            this.Text = "DetailsDepartmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox addressInput;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox profileInput;
    }
}