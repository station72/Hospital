namespace Hospital
{
    partial class EditEmployeeForm
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label okpoLabel;
            this.cabinetInput = new System.Windows.Forms.TextBox();
            this.scheduleInput = new System.Windows.Forms.TextBox();
            this.secondNameInput = new System.Windows.Forms.TextBox();
            this.firstNameInput = new System.Windows.Forms.TextBox();
            this.patronymicInput = new System.Windows.Forms.TextBox();
            this.suggestDepartmentInput = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            okpoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(52, 121);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(49, 13);
            label3.TabIndex = 34;
            label3.Text = "Кабинет";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(18, 157);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(85, 13);
            label4.TabIndex = 32;
            label4.Text = "График работы";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(47, 51);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(56, 13);
            label2.TabIndex = 29;
            label2.Text = "Фамилия";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(74, 17);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(29, 13);
            label1.TabIndex = 27;
            label1.Text = "Имя";
            // 
            // okpoLabel
            // 
            okpoLabel.AutoSize = true;
            okpoLabel.Location = new System.Drawing.Point(49, 87);
            okpoLabel.Name = "okpoLabel";
            okpoLabel.Size = new System.Drawing.Size(54, 13);
            okpoLabel.TabIndex = 25;
            okpoLabel.Text = "Отчество";
            // 
            // cabinetInput
            // 
            this.cabinetInput.Location = new System.Drawing.Point(109, 121);
            this.cabinetInput.Name = "cabinetInput";
            this.cabinetInput.Size = new System.Drawing.Size(322, 20);
            this.cabinetInput.TabIndex = 3;
            // 
            // scheduleInput
            // 
            this.scheduleInput.Location = new System.Drawing.Point(109, 157);
            this.scheduleInput.Name = "scheduleInput";
            this.scheduleInput.Size = new System.Drawing.Size(322, 20);
            this.scheduleInput.TabIndex = 4;
            // 
            // secondNameInput
            // 
            this.secondNameInput.Location = new System.Drawing.Point(109, 48);
            this.secondNameInput.Name = "secondNameInput";
            this.secondNameInput.Size = new System.Drawing.Size(322, 20);
            this.secondNameInput.TabIndex = 1;
            // 
            // firstNameInput
            // 
            this.firstNameInput.Location = new System.Drawing.Point(109, 14);
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(322, 20);
            this.firstNameInput.TabIndex = 0;
            // 
            // patronymicInput
            // 
            this.patronymicInput.Location = new System.Drawing.Point(109, 84);
            this.patronymicInput.Name = "patronymicInput";
            this.patronymicInput.Size = new System.Drawing.Size(322, 20);
            this.patronymicInput.TabIndex = 2;
            // 
            // suggestDepartmentInput
            // 
            this.suggestDepartmentInput.FormattingEnabled = true;
            this.suggestDepartmentInput.Location = new System.Drawing.Point(109, 194);
            this.suggestDepartmentInput.Name = "suggestDepartmentInput";
            this.suggestDepartmentInput.Size = new System.Drawing.Size(322, 21);
            this.suggestDepartmentInput.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Отделение";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(289, 235);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(142, 53);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(109, 235);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(142, 53);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "Сохранить";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // EditEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 300);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.suggestDepartmentInput);
            this.Controls.Add(this.cabinetInput);
            this.Controls.Add(label3);
            this.Controls.Add(this.scheduleInput);
            this.Controls.Add(label4);
            this.Controls.Add(this.secondNameInput);
            this.Controls.Add(label2);
            this.Controls.Add(this.firstNameInput);
            this.Controls.Add(label1);
            this.Controls.Add(this.patronymicInput);
            this.Controls.Add(okpoLabel);
            this.Name = "EditEmployeeForm";
            this.Text = "EditEmployeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cabinetInput;
        private System.Windows.Forms.TextBox scheduleInput;
        private System.Windows.Forms.TextBox secondNameInput;
        private System.Windows.Forms.TextBox firstNameInput;
        private System.Windows.Forms.TextBox patronymicInput;
        private System.Windows.Forms.ComboBox suggestDepartmentInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}