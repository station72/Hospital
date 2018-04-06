namespace Hospital
{
    partial class CreateEmployeeForm
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.createButton = new System.Windows.Forms.Button();
            this.secondNameInput = new System.Windows.Forms.TextBox();
            this.firstNameInput = new System.Windows.Forms.TextBox();
            this.patronymicInput = new System.Windows.Forms.TextBox();
            this.cabinetInput = new System.Windows.Forms.TextBox();
            this.scheduleInput = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            okpoLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(66, 55);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(56, 13);
            label2.TabIndex = 18;
            label2.Text = "Фамилия";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(93, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(29, 13);
            label1.TabIndex = 16;
            label1.Text = "Имя";
            // 
            // okpoLabel
            // 
            okpoLabel.AutoSize = true;
            okpoLabel.Location = new System.Drawing.Point(66, 91);
            okpoLabel.Name = "okpoLabel";
            okpoLabel.Size = new System.Drawing.Size(54, 13);
            okpoLabel.TabIndex = 14;
            okpoLabel.Text = "Отчество";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(66, 128);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(49, 13);
            label3.TabIndex = 23;
            label3.Text = "Кабинет";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(37, 161);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(85, 13);
            label4.TabIndex = 21;
            label4.Text = "График работы";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(128, 218);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(322, 53);
            this.createButton.TabIndex = 20;
            this.createButton.Text = "Добавить";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // secondNameInput
            // 
            this.secondNameInput.Location = new System.Drawing.Point(128, 52);
            this.secondNameInput.Name = "secondNameInput";
            this.secondNameInput.Size = new System.Drawing.Size(322, 20);
            this.secondNameInput.TabIndex = 19;
            // 
            // firstNameInput
            // 
            this.firstNameInput.Location = new System.Drawing.Point(128, 18);
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(322, 20);
            this.firstNameInput.TabIndex = 17;
            // 
            // patronymicInput
            // 
            this.patronymicInput.Location = new System.Drawing.Point(128, 88);
            this.patronymicInput.Name = "patronymicInput";
            this.patronymicInput.Size = new System.Drawing.Size(322, 20);
            this.patronymicInput.TabIndex = 15;
            // 
            // cabinetInput
            // 
            this.cabinetInput.Location = new System.Drawing.Point(128, 125);
            this.cabinetInput.Name = "cabinetInput";
            this.cabinetInput.Size = new System.Drawing.Size(322, 20);
            this.cabinetInput.TabIndex = 24;
            // 
            // scheduleInput
            // 
            this.scheduleInput.Location = new System.Drawing.Point(128, 161);
            this.scheduleInput.Name = "scheduleInput";
            this.scheduleInput.Size = new System.Drawing.Size(322, 20);
            this.scheduleInput.TabIndex = 22;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // CreateEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 279);
            this.Controls.Add(this.cabinetInput);
            this.Controls.Add(label3);
            this.Controls.Add(this.scheduleInput);
            this.Controls.Add(label4);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.secondNameInput);
            this.Controls.Add(label2);
            this.Controls.Add(this.firstNameInput);
            this.Controls.Add(label1);
            this.Controls.Add(this.patronymicInput);
            this.Controls.Add(okpoLabel);
            this.Name = "CreateEmployeeForm";
            this.Text = "Добавить мед. работника";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox secondNameInput;
        private System.Windows.Forms.TextBox firstNameInput;
        private System.Windows.Forms.TextBox patronymicInput;
        private System.Windows.Forms.TextBox cabinetInput;
        private System.Windows.Forms.TextBox scheduleInput;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}