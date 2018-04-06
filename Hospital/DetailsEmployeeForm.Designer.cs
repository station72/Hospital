namespace Hospital
{
    partial class DetailsEmployeeForm
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
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            okpoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(57, 119);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(49, 13);
            label3.TabIndex = 44;
            label3.Text = "Кабинет";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(23, 155);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(85, 13);
            label4.TabIndex = 42;
            label4.Text = "График работы";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(52, 49);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(56, 13);
            label2.TabIndex = 40;
            label2.Text = "Фамилия";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(79, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(29, 13);
            label1.TabIndex = 38;
            label1.Text = "Имя";
            // 
            // okpoLabel
            // 
            okpoLabel.AutoSize = true;
            okpoLabel.Location = new System.Drawing.Point(54, 85);
            okpoLabel.Name = "okpoLabel";
            okpoLabel.Size = new System.Drawing.Size(54, 13);
            okpoLabel.TabIndex = 36;
            okpoLabel.Text = "Отчество";
            // 
            // cabinetInput
            // 
            this.cabinetInput.Location = new System.Drawing.Point(114, 119);
            this.cabinetInput.Name = "cabinetInput";
            this.cabinetInput.Size = new System.Drawing.Size(322, 20);
            this.cabinetInput.TabIndex = 45;
            // 
            // scheduleInput
            // 
            this.scheduleInput.Location = new System.Drawing.Point(114, 155);
            this.scheduleInput.Name = "scheduleInput";
            this.scheduleInput.Size = new System.Drawing.Size(322, 20);
            this.scheduleInput.TabIndex = 43;
            // 
            // secondNameInput
            // 
            this.secondNameInput.Location = new System.Drawing.Point(114, 46);
            this.secondNameInput.Name = "secondNameInput";
            this.secondNameInput.Size = new System.Drawing.Size(322, 20);
            this.secondNameInput.TabIndex = 41;
            // 
            // firstNameInput
            // 
            this.firstNameInput.Location = new System.Drawing.Point(114, 12);
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(322, 20);
            this.firstNameInput.TabIndex = 39;
            // 
            // patronymicInput
            // 
            this.patronymicInput.Location = new System.Drawing.Point(114, 82);
            this.patronymicInput.Name = "patronymicInput";
            this.patronymicInput.Size = new System.Drawing.Size(322, 20);
            this.patronymicInput.TabIndex = 37;
            // 
            // DetailsEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 209);
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
            this.Name = "DetailsEmployeeForm";
            this.Text = "Инфо мед. работника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cabinetInput;
        private System.Windows.Forms.TextBox scheduleInput;
        private System.Windows.Forms.TextBox secondNameInput;
        private System.Windows.Forms.TextBox firstNameInput;
        private System.Windows.Forms.TextBox patronymicInput;
    }
}