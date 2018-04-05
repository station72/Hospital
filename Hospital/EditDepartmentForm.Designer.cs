namespace Hospital
{
    partial class EditDepartmentForm
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label okpoLabel;
            this.editButton = new System.Windows.Forms.Button();
            this.addressInput = new System.Windows.Forms.TextBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.profileInput = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cancelButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.suggestInstitutionInput = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            okpoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(84, 54);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(38, 13);
            label2.TabIndex = 18;
            label2.Text = "Адрес";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(65, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(57, 13);
            label1.TabIndex = 16;
            label1.Text = "Название";
            // 
            // okpoLabel
            // 
            okpoLabel.AutoSize = true;
            okpoLabel.Location = new System.Drawing.Point(69, 90);
            okpoLabel.Name = "okpoLabel";
            okpoLabel.Size = new System.Drawing.Size(53, 13);
            okpoLabel.TabIndex = 14;
            okpoLabel.Text = "Профиль";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(128, 175);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(142, 53);
            this.editButton.TabIndex = 20;
            this.editButton.Text = "Сохранить";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addressInput
            // 
            this.addressInput.Location = new System.Drawing.Point(128, 51);
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(322, 20);
            this.addressInput.TabIndex = 19;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(128, 17);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(322, 20);
            this.nameInput.TabIndex = 17;
            // 
            // profileInput
            // 
            this.profileInput.Location = new System.Drawing.Point(128, 87);
            this.profileInput.Name = "profileInput";
            this.profileInput.Size = new System.Drawing.Size(322, 20);
            this.profileInput.TabIndex = 15;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(308, 175);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(142, 53);
            this.cancelButton.TabIndex = 21;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Учреждение";
            // 
            // suggestInstitutionInput
            // 
            this.suggestInstitutionInput.FormattingEnabled = true;
            this.suggestInstitutionInput.Location = new System.Drawing.Point(128, 126);
            this.suggestInstitutionInput.Name = "suggestInstitutionInput";
            this.suggestInstitutionInput.Size = new System.Drawing.Size(322, 21);
            this.suggestInstitutionInput.TabIndex = 24;
            // 
            // EditDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 245);
            this.Controls.Add(this.suggestInstitutionInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addressInput);
            this.Controls.Add(label2);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(label1);
            this.Controls.Add(this.profileInput);
            this.Controls.Add(okpoLabel);
            this.Name = "EditDepartmentForm";
            this.Text = "EditDepartmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox addressInput;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox profileInput;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox suggestInstitutionInput;
    }
}