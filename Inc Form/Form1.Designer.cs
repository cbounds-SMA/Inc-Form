namespace Inc_Form
{
    partial class incForm
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.computerNameLabel = new System.Windows.Forms.Label();
            this.incidentTitleLabel = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.computerName = new System.Windows.Forms.TextBox();
            this.incidentTitle = new System.Windows.Forms.TextBox();
            this.category = new System.Windows.Forms.ComboBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.subcategory1 = new System.Windows.Forms.ComboBox();
            this.subCategory1Label = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.RichTextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.resolved = new System.Windows.Forms.CheckBox();
            this.resolutionText = new System.Windows.Forms.RichTextBox();
            this.resolvedLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.subcategory2Label = new System.Windows.Forms.Label();
            this.subcategory2 = new System.Windows.Forms.ComboBox();
            this.resolvedCategory = new System.Windows.Forms.ComboBox();
            this.resolvedCategoryLabel = new System.Windows.Forms.Label();
            this.resolvedByLabel = new System.Windows.Forms.Label();
            this.resolvedByInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(6, 12);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(108, 13);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Create ticket for user:";
            // 
            // computerNameLabel
            // 
            this.computerNameLabel.AutoSize = true;
            this.computerNameLabel.Location = new System.Drawing.Point(6, 41);
            this.computerNameLabel.Name = "computerNameLabel";
            this.computerNameLabel.Size = new System.Drawing.Size(86, 13);
            this.computerNameLabel.TabIndex = 1;
            this.computerNameLabel.Text = "Computer Name:";
            // 
            // incidentTitleLabel
            // 
            this.incidentTitleLabel.AutoSize = true;
            this.incidentTitleLabel.Location = new System.Drawing.Point(9, 70);
            this.incidentTitleLabel.Name = "incidentTitleLabel";
            this.incidentTitleLabel.Size = new System.Drawing.Size(71, 13);
            this.incidentTitleLabel.TabIndex = 2;
            this.incidentTitleLabel.Text = "Incident Title:";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(127, 9);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(316, 20);
            this.username.TabIndex = 3;
            // 
            // computerName
            // 
            this.computerName.Location = new System.Drawing.Point(127, 38);
            this.computerName.Name = "computerName";
            this.computerName.Size = new System.Drawing.Size(316, 20);
            this.computerName.TabIndex = 4;
            // 
            // incidentTitle
            // 
            this.incidentTitle.Location = new System.Drawing.Point(127, 70);
            this.incidentTitle.Name = "incidentTitle";
            this.incidentTitle.Size = new System.Drawing.Size(316, 20);
            this.incidentTitle.TabIndex = 5;
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Items.AddRange(new object[] {
            "Application",
            "DataCenter",
            "Hardware",
            "Messaging",
            "Network",
            "Security Management",
            "Server Management",
            "Service Desk",
            "Telephony",
            "Tools",
            "User Management",
            "Workplace"});
            this.category.Location = new System.Drawing.Point(127, 106);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(121, 21);
            this.category.TabIndex = 6;
            this.category.SelectedIndexChanged += new System.EventHandler(this.Category_SelectedIndexChanged);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(9, 109);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(52, 13);
            this.categoryLabel.TabIndex = 7;
            this.categoryLabel.Text = "Category:";
            // 
            // subcategory1
            // 
            this.subcategory1.FormattingEnabled = true;
            this.subcategory1.Location = new System.Drawing.Point(127, 146);
            this.subcategory1.Name = "subcategory1";
            this.subcategory1.Size = new System.Drawing.Size(148, 21);
            this.subcategory1.TabIndex = 8;
            this.subcategory1.SelectedIndexChanged += new System.EventHandler(this.Subcategory1_SelectedIndexChanged);
            // 
            // subCategory1Label
            // 
            this.subCategory1Label.AutoSize = true;
            this.subCategory1Label.Location = new System.Drawing.Point(9, 146);
            this.subCategory1Label.Name = "subCategory1Label";
            this.subCategory1Label.Size = new System.Drawing.Size(83, 13);
            this.subCategory1Label.TabIndex = 9;
            this.subCategory1Label.Text = "Sub-Category 1:";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(16, 256);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(507, 148);
            this.description.TabIndex = 10;
            this.description.Text = "";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(13, 224);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.descriptionLabel.TabIndex = 11;
            this.descriptionLabel.Text = "Description:";
            // 
            // resolved
            // 
            this.resolved.AutoSize = true;
            this.resolved.Location = new System.Drawing.Point(15, 430);
            this.resolved.Name = "resolved";
            this.resolved.Size = new System.Drawing.Size(66, 17);
            this.resolved.TabIndex = 12;
            this.resolved.Text = "resolved";
            this.resolved.UseVisualStyleBackColor = true;
            // 
            // resolutionText
            // 
            this.resolutionText.Location = new System.Drawing.Point(12, 477);
            this.resolutionText.Name = "resolutionText";
            this.resolutionText.Size = new System.Drawing.Size(507, 237);
            this.resolutionText.TabIndex = 13;
            this.resolutionText.Text = "";
            //
            // resolvedCategoryLabel
            //
            this.resolvedCategoryLabel.AutoSize = true;
            this.resolvedCategoryLabel.Location = new System.Drawing.Point(12, 735);
            this.resolvedCategoryLabel.Name = "resolvedCategoryLabel";
            this.resolvedCategoryLabel.Size = new System.Drawing.Size(91, 13);
            this.resolvedCategoryLabel.TabIndex = 14;
            this.resolvedCategoryLabel.Text = "Resolution Category:";
            // resolutionCategory
            //
            this.resolvedCategory.FormattingEnabled = true;
            this.resolvedCategory.Location = new System.Drawing.Point(12, 750);
            this.resolvedCategory.Items.AddRange(new object[] {
                "Information/advice given",
                "Application repaired",
                "Account Settings updated",
                "Unable to find fault",
                "Hardware failure"
            });
            this.resolvedCategory.Name = "resolvedCategory";
            this.resolvedCategory.Size = new System.Drawing.Size(148, 21);
            this.resolvedCategory.TabIndex = 18;

            // 
            // resolvedLabel
            // 
            this.resolvedLabel.AutoSize = true;
            this.resolvedLabel.Location = new System.Drawing.Point(13, 450);
            this.resolvedLabel.Name = "resolvedLabel";
            this.resolvedLabel.Size = new System.Drawing.Size(91, 13);
            this.resolvedLabel.TabIndex = 14;
            this.resolvedLabel.Text = "Resolution Notes:";
            //
            // resolvedByLabel
            // 
            this.resolvedByLabel.AutoSize = true;
            this.resolvedByLabel.Location = new System.Drawing.Point(325, 735);
            this.resolvedByLabel.Name = "resolvedByLabel";
            this.resolvedByLabel.Size = new System.Drawing.Size(83, 13);
            this.resolvedByLabel.TabIndex = 16;
            this.resolvedByLabel.Text = "Resolved By:";
            //
            // resolvedByInput
            //
            this.resolvedByInput.Location = new System.Drawing.Point(325, 750);
            this.resolvedByInput.Name = "resolvedByInput";
            this.resolvedByInput.Size = new System.Drawing.Size(200, 20);
            this.resolvedByInput.TabIndex = 3;
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(460, 800);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // subcategory2Label
            // 
            this.subcategory2Label.AutoSize = true;
            this.subcategory2Label.Location = new System.Drawing.Point(9, 186);
            this.subcategory2Label.Name = "subcategory2Label";
            this.subcategory2Label.Size = new System.Drawing.Size(83, 13);
            this.subcategory2Label.TabIndex = 16;
            this.subcategory2Label.Text = "Sub-Category 2:";
            // 
            // subcategory2
            // 
            this.subcategory2.FormattingEnabled = true;
            this.subcategory2.Location = new System.Drawing.Point(127, 186);
            this.subcategory2.Name = "subcategory2";
            this.subcategory2.Size = new System.Drawing.Size(148, 21);
            this.subcategory2.TabIndex = 17;
            // 
            // incForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 850);
            this.Controls.Add(this.subcategory2);
            this.Controls.Add(this.subcategory2Label);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.resolvedLabel);
            this.Controls.Add(this.resolutionText);
            this.Controls.Add(this.resolved);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.description);
            this.Controls.Add(this.subCategory1Label);
            this.Controls.Add(this.subcategory1);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.category);
            this.Controls.Add(this.incidentTitle);
            this.Controls.Add(this.computerName);
            this.Controls.Add(this.username);
            this.Controls.Add(this.incidentTitleLabel);
            this.Controls.Add(this.computerNameLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.resolvedCategory);
            this.Controls.Add(this.resolvedCategoryLabel);
            this.Controls.Add(this.resolvedByLabel);
            this.Controls.Add(this.resolvedByInput);
            this.Name = "incForm";
            this.Text = "Incident Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label computerNameLabel;
        private System.Windows.Forms.Label incidentTitleLabel;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox computerName;
        private System.Windows.Forms.TextBox incidentTitle;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ComboBox subcategory1;
        private System.Windows.Forms.Label subCategory1Label;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.CheckBox resolved;
        private System.Windows.Forms.ComboBox resolvedCategory;
        private System.Windows.Forms.RichTextBox resolutionText;
        private System.Windows.Forms.Label resolvedLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label subcategory2Label;
        private System.Windows.Forms.ComboBox subcategory2;
        private System.Windows.Forms.Label resolvedCategoryLabel;
        private System.Windows.Forms.Label resolvedByLabel;
        private System.Windows.Forms.TextBox resolvedByInput;
    }
}

