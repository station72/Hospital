﻿namespace Hospital
{
    partial class EditInstitutionForm
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
            this.okpoInput = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            okpoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(84, 89);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(38, 13);
            label2.TabIndex = 11;
            label2.Text = "Адрес";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(65, 55);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(57, 13);
            label1.TabIndex = 9;
            label1.Text = "Название";
            // 
            // okpoLabel
            // 
            okpoLabel.AutoSize = true;
            okpoLabel.Location = new System.Drawing.Point(84, 24);
            okpoLabel.Name = "okpoLabel";
            okpoLabel.Size = new System.Drawing.Size(38, 13);
            okpoLabel.TabIndex = 7;
            okpoLabel.Text = "ОКПО";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(110, 170);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(147, 53);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "Сохранить";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addressInput
            // 
            this.addressInput.Location = new System.Drawing.Point(128, 86);
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(322, 20);
            this.addressInput.TabIndex = 2;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(128, 52);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(322, 20);
            this.nameInput.TabIndex = 1;
            // 
            // okpoInput
            // 
            this.okpoInput.Location = new System.Drawing.Point(128, 21);
            this.okpoInput.Name = "okpoInput";
            this.okpoInput.Size = new System.Drawing.Size(322, 20);
            this.okpoInput.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(303, 170);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(147, 53);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // EditInstitutionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 245);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addressInput);
            this.Controls.Add(label2);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(label1);
            this.Controls.Add(this.okpoInput);
            this.Controls.Add(okpoLabel);
            this.Name = "EditInstitutionForm";
            this.Text = "Редактировать лечебное учреждение";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox addressInput;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox okpoInput;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}