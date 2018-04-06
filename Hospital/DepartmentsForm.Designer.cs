namespace Hospital
{
    partial class DepartmentsForm
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
            this.showPersonalButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.objectListView = new BrightIdeasSoftware.ObjectListView();
            this.Название = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Адресс = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.detailsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView)).BeginInit();
            this.SuspendLayout();
            // 
            // showPersonalButton
            // 
            this.showPersonalButton.Location = new System.Drawing.Point(12, 12);
            this.showPersonalButton.Name = "showPersonalButton";
            this.showPersonalButton.Size = new System.Drawing.Size(114, 40);
            this.showPersonalButton.TabIndex = 0;
            this.showPersonalButton.Text = "Мед. персонал";
            this.showPersonalButton.UseVisualStyleBackColor = true;
            this.showPersonalButton.Click += new System.EventHandler(this.showPersonalButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(819, 105);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(114, 40);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
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
            this.objectListView.AllColumns.Add(this.Название);
            this.objectListView.AllColumns.Add(this.Адресс);
            this.objectListView.CellEditUseWholeCell = false;
            this.objectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Название,
            this.Адресс});
            this.objectListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView.Location = new System.Drawing.Point(132, 12);
            this.objectListView.Name = "objectListView";
            this.objectListView.Size = new System.Drawing.Size(681, 464);
            this.objectListView.TabIndex = 5;
            this.objectListView.UseCompatibleStateImageBehavior = false;
            this.objectListView.View = System.Windows.Forms.View.Details;
            // 
            // Название
            // 
            this.Название.AspectName = "Name";
            this.Название.Groupable = false;
            this.Название.IsEditable = false;
            this.Название.Text = "Название";
            this.Название.Width = 333;
            // 
            // Адресс
            // 
            this.Адресс.AspectName = "Address";
            this.Адресс.Groupable = false;
            this.Адресс.IsEditable = false;
            this.Адресс.Text = "Адресс";
            this.Адресс.Width = 346;
            // 
            // detailsButton
            // 
            this.detailsButton.Location = new System.Drawing.Point(12, 59);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(114, 40);
            this.detailsButton.TabIndex = 1;
            this.detailsButton.Text = "Подробнее";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // DepartmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 488);
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.showPersonalButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.objectListView);
            this.Name = "DepartmentsForm";
            this.Text = "Отделения";
            ((System.ComponentModel.ISupportInitialize)(this.objectListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showPersonalButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private BrightIdeasSoftware.ObjectListView objectListView;
        private BrightIdeasSoftware.OLVColumn Название;
        private BrightIdeasSoftware.OLVColumn Адресс;
        private System.Windows.Forms.Button detailsButton;
    }
}