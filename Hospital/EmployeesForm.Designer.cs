namespace Hospital
{
    partial class EmployeesForm
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
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.objectListView = new BrightIdeasSoftware.ObjectListView();
            this.Имя = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Фамилия = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.detailsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(819, 105);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(114, 40);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_ClickAsync);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(819, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(113, 41);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(819, 59);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(114, 40);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "Редактировать";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // objectListView
            // 
            this.objectListView.AllColumns.Add(this.Имя);
            this.objectListView.AllColumns.Add(this.Фамилия);
            this.objectListView.CellEditUseWholeCell = false;
            this.objectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Имя,
            this.Фамилия});
            this.objectListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView.Location = new System.Drawing.Point(131, 12);
            this.objectListView.Name = "objectListView";
            this.objectListView.Size = new System.Drawing.Size(682, 464);
            this.objectListView.TabIndex = 5;
            this.objectListView.UseCompatibleStateImageBehavior = false;
            this.objectListView.View = System.Windows.Forms.View.Details;
            // 
            // Имя
            // 
            this.Имя.AspectName = "FirstName";
            this.Имя.DisplayIndex = 1;
            this.Имя.Groupable = false;
            this.Имя.IsEditable = false;
            this.Имя.Text = "Имя";
            this.Имя.Width = 346;
            // 
            // Фамилия
            // 
            this.Фамилия.AspectName = "LastName";
            this.Фамилия.DisplayIndex = 0;
            this.Фамилия.Groupable = false;
            this.Фамилия.IsEditable = false;
            this.Фамилия.Text = "Фамилия";
            this.Фамилия.Width = 333;
            // 
            // detailsButton
            // 
            this.detailsButton.Location = new System.Drawing.Point(12, 12);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(113, 41);
            this.detailsButton.TabIndex = 0;
            this.detailsButton.Text = "Подробнее";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 488);
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.objectListView);
            this.Name = "EmployeesForm";
            this.Text = "Мед. персонал";
            ((System.ComponentModel.ISupportInitialize)(this.objectListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private BrightIdeasSoftware.ObjectListView objectListView;
        private BrightIdeasSoftware.OLVColumn Фамилия;
        private BrightIdeasSoftware.OLVColumn Имя;
        private System.Windows.Forms.Button detailsButton;
    }
}