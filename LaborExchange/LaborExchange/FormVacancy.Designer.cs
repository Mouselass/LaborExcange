
namespace LaborExchange
{
    partial class FormVacancy
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
            this.comboBoxEducation = new System.Windows.Forms.ComboBox();
            this.labelEducation = new System.Windows.Forms.Label();
            this.comboBoxEmployer = new System.Windows.Forms.ComboBox();
            this.labelEmployer = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.labelPost = new System.Windows.Forms.Label();
            this.textBoxWorkExperience = new System.Windows.Forms.TextBox();
            this.labelWorkExperience = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxEducation
            // 
            this.comboBoxEducation.FormattingEnabled = true;
            this.comboBoxEducation.Location = new System.Drawing.Point(121, 100);
            this.comboBoxEducation.Name = "comboBoxEducation";
            this.comboBoxEducation.Size = new System.Drawing.Size(158, 21);
            this.comboBoxEducation.TabIndex = 24;
            // 
            // labelEducation
            // 
            this.labelEducation.AutoSize = true;
            this.labelEducation.Location = new System.Drawing.Point(13, 103);
            this.labelEducation.Name = "labelEducation";
            this.labelEducation.Size = new System.Drawing.Size(82, 13);
            this.labelEducation.TabIndex = 23;
            this.labelEducation.Text = "Образование:";
            // 
            // comboBoxEmployer
            // 
            this.comboBoxEmployer.FormattingEnabled = true;
            this.comboBoxEmployer.Location = new System.Drawing.Point(121, 26);
            this.comboBoxEmployer.Name = "comboBoxEmployer";
            this.comboBoxEmployer.Size = new System.Drawing.Size(158, 21);
            this.comboBoxEmployer.TabIndex = 26;
            // 
            // labelEmployer
            // 
            this.labelEmployer.AutoSize = true;
            this.labelEmployer.Location = new System.Drawing.Point(12, 29);
            this.labelEmployer.Name = "labelEmployer";
            this.labelEmployer.Size = new System.Drawing.Size(83, 13);
            this.labelEmployer.TabIndex = 25;
            this.labelEmployer.Text = "Работодатель:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(162, 233);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 29;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(66, 233);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 28;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(121, 175);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(158, 22);
            this.textBoxDescription.TabIndex = 35;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(14, 178);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(63, 13);
            this.labelDescription.TabIndex = 34;
            this.labelDescription.Text = "Описание:";
            // 
            // textBoxPost
            // 
            this.textBoxPost.Location = new System.Drawing.Point(121, 65);
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(158, 22);
            this.textBoxPost.TabIndex = 31;
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Location = new System.Drawing.Point(12, 68);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(70, 13);
            this.labelPost.TabIndex = 30;
            this.labelPost.Text = "Должность:";
            // 
            // textBoxWorkExperience
            // 
            this.textBoxWorkExperience.Location = new System.Drawing.Point(121, 135);
            this.textBoxWorkExperience.Name = "textBoxWorkExperience";
            this.textBoxWorkExperience.Size = new System.Drawing.Size(158, 22);
            this.textBoxWorkExperience.TabIndex = 37;
            // 
            // labelWorkExperience
            // 
            this.labelWorkExperience.AutoSize = true;
            this.labelWorkExperience.Location = new System.Drawing.Point(14, 138);
            this.labelWorkExperience.Name = "labelWorkExperience";
            this.labelWorkExperience.Size = new System.Drawing.Size(81, 13);
            this.labelWorkExperience.TabIndex = 36;
            this.labelWorkExperience.Text = "Опыт работы:";
            // 
            // FormVacancy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 278);
            this.Controls.Add(this.textBoxWorkExperience);
            this.Controls.Add(this.labelWorkExperience);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxPost);
            this.Controls.Add(this.labelPost);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxEmployer);
            this.Controls.Add(this.labelEmployer);
            this.Controls.Add(this.comboBoxEducation);
            this.Controls.Add(this.labelEducation);
            this.Name = "FormVacancy";
            this.Text = "Вакансия";
            this.Load += new System.EventHandler(this.FormVacancy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEducation;
        private System.Windows.Forms.Label labelEducation;
        private System.Windows.Forms.ComboBox comboBoxEmployer;
        private System.Windows.Forms.Label labelEmployer;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.TextBox textBoxWorkExperience;
        private System.Windows.Forms.Label labelWorkExperience;
    }
}