namespace Hospital
{
    partial class CreateInstitutionForm
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
            System.Windows.Forms.Label okpoLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.okpoInput = new System.Windows.Forms.TextBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.addressInput = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            okpoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // okpoLabel
            // 
            okpoLabel.AutoSize = true;
            okpoLabel.Location = new System.Drawing.Point(61, 12);
            okpoLabel.Name = "okpoLabel";
            okpoLabel.Size = new System.Drawing.Size(38, 13);
            okpoLabel.TabIndex = 0;
            okpoLabel.Text = "ОКПО";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(42, 43);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(57, 13);
            label1.TabIndex = 2;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(61, 77);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(38, 13);
            label2.TabIndex = 4;
            label2.Text = "Адрес";
            // 
            // okpoInput
            // 
            this.okpoInput.Location = new System.Drawing.Point(105, 9);
            this.okpoInput.Name = "okpoInput";
            this.okpoInput.Size = new System.Drawing.Size(322, 20);
            this.okpoInput.TabIndex = 0;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(105, 40);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(322, 20);
            this.nameInput.TabIndex = 1;
            // 
            // addressInput
            // 
            this.addressInput.Location = new System.Drawing.Point(105, 74);
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(322, 20);
            this.addressInput.TabIndex = 2;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(105, 119);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(322, 53);
            this.createButton.TabIndex = 6;
            this.createButton.Text = "Добавить";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // CreateInstitutionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 190);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.addressInput);
            this.Controls.Add(label2);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(label1);
            this.Controls.Add(this.okpoInput);
            this.Controls.Add(okpoLabel);
            this.Name = "CreateInstitutionForm";
            this.Text = "Добавить учреждение";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox okpoInput;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox addressInput;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}