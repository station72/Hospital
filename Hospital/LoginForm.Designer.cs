namespace Hospital
{
    partial class LoginForm
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
            System.Windows.Forms.Label UserLabel;
            System.Windows.Forms.Label PassLabel;
            this.EnterButton = new System.Windows.Forms.Button();
            this.UserNameInput = new System.Windows.Forms.TextBox();
            this.PassInput = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            UserLabel = new System.Windows.Forms.Label();
            PassLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Location = new System.Drawing.Point(43, 59);
            UserLabel.Name = "UserLabel";
            UserLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            UserLabel.Size = new System.Drawing.Size(80, 13);
            UserLabel.TabIndex = 0;
            UserLabel.Text = "Пользователь";
            // 
            // PassLabel
            // 
            PassLabel.AutoSize = true;
            PassLabel.Location = new System.Drawing.Point(43, 94);
            PassLabel.Name = "PassLabel";
            PassLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            PassLabel.Size = new System.Drawing.Size(45, 13);
            PassLabel.TabIndex = 5;
            PassLabel.Text = "Пароль";
            // 
            // EnterButton
            // 
            this.EnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterButton.Location = new System.Drawing.Point(138, 134);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(311, 58);
            this.EnterButton.TabIndex = 2;
            this.EnterButton.Text = "ВОЙТИ";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // UserNameInput
            // 
            this.UserNameInput.Location = new System.Drawing.Point(138, 52);
            this.UserNameInput.Name = "UserNameInput";
            this.UserNameInput.Size = new System.Drawing.Size(311, 20);
            this.UserNameInput.TabIndex = 0;
            // 
            // PassInput
            // 
            this.PassInput.Location = new System.Drawing.Point(138, 94);
            this.PassInput.Name = "PassInput";
            this.PassInput.Size = new System.Drawing.Size(311, 20);
            this.PassInput.TabIndex = 1;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 205);
            this.Controls.Add(this.PassInput);
            this.Controls.Add(PassLabel);
            this.Controls.Add(this.UserNameInput);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(UserLabel);
            this.Name = "LoginForm";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox UserNameInput;
        private System.Windows.Forms.TextBox PassInput;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}