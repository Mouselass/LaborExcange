
namespace LaborExchange
{
    partial class FormApplicant
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxMiddlename = new System.Windows.Forms.TextBox();
            this.labelMiddlename = new System.Windows.Forms.Label();
            this.labelBirthdayDate = new System.Windows.Forms.Label();
            this.textBoxWorkExperience = new System.Windows.Forms.TextBox();
            this.labelWorkExperience = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelEducation = new System.Windows.Forms.Label();
            this.comboBoxEducation = new System.Windows.Forms.ComboBox();
            this.dateTimePickerBirthdayDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(204, 309);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(108, 309);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(121, 23);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(158, 20);
            this.textBoxName.TabIndex = 8;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 26);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(32, 13);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Имя:";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(121, 65);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(158, 20);
            this.textBoxSurname.TabIndex = 12;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(12, 68);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(59, 13);
            this.labelSurname.TabIndex = 11;
            this.labelSurname.Text = "Фамилия:";
            // 
            // textBoxMiddlename
            // 
            this.textBoxMiddlename.Location = new System.Drawing.Point(121, 105);
            this.textBoxMiddlename.Name = "textBoxMiddlename";
            this.textBoxMiddlename.Size = new System.Drawing.Size(158, 20);
            this.textBoxMiddlename.TabIndex = 14;
            // 
            // labelMiddlename
            // 
            this.labelMiddlename.AutoSize = true;
            this.labelMiddlename.Location = new System.Drawing.Point(12, 108);
            this.labelMiddlename.Name = "labelMiddlename";
            this.labelMiddlename.Size = new System.Drawing.Size(57, 13);
            this.labelMiddlename.TabIndex = 13;
            this.labelMiddlename.Text = "Отчество:";
            // 
            // labelBirthdayDate
            // 
            this.labelBirthdayDate.AutoSize = true;
            this.labelBirthdayDate.Location = new System.Drawing.Point(12, 173);
            this.labelBirthdayDate.Name = "labelBirthdayDate";
            this.labelBirthdayDate.Size = new System.Drawing.Size(89, 13);
            this.labelBirthdayDate.TabIndex = 15;
            this.labelBirthdayDate.Text = "Дата рождения:";
            // 
            // textBoxWorkExperience
            // 
            this.textBoxWorkExperience.Location = new System.Drawing.Point(121, 211);
            this.textBoxWorkExperience.Name = "textBoxWorkExperience";
            this.textBoxWorkExperience.Size = new System.Drawing.Size(158, 20);
            this.textBoxWorkExperience.TabIndex = 18;
            // 
            // labelWorkExperience
            // 
            this.labelWorkExperience.AutoSize = true;
            this.labelWorkExperience.Location = new System.Drawing.Point(12, 214);
            this.labelWorkExperience.Name = "labelWorkExperience";
            this.labelWorkExperience.Size = new System.Drawing.Size(77, 13);
            this.labelWorkExperience.TabIndex = 17;
            this.labelWorkExperience.Text = "Опыт работы:";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(12, 250);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(55, 13);
            this.labelPhone.TabIndex = 19;
            this.labelPhone.Text = "Телефон:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(121, 247);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(158, 20);
            this.textBoxPhone.TabIndex = 20;
            // 
            // labelEducation
            // 
            this.labelEducation.AutoSize = true;
            this.labelEducation.Location = new System.Drawing.Point(12, 142);
            this.labelEducation.Name = "labelEducation";
            this.labelEducation.Size = new System.Drawing.Size(78, 13);
            this.labelEducation.TabIndex = 21;
            this.labelEducation.Text = "Образование:";
            // 
            // comboBoxEducation
            // 
            this.comboBoxEducation.FormattingEnabled = true;
            this.comboBoxEducation.Location = new System.Drawing.Point(121, 139);
            this.comboBoxEducation.Name = "comboBoxEducation";
            this.comboBoxEducation.Size = new System.Drawing.Size(158, 21);
            this.comboBoxEducation.TabIndex = 22;
            // 
            // dateTimePickerBirthdayDate
            // 
            this.dateTimePickerBirthdayDate.Location = new System.Drawing.Point(121, 173);
            this.dateTimePickerBirthdayDate.Name = "dateTimePickerBirthdayDate";
            this.dateTimePickerBirthdayDate.Size = new System.Drawing.Size(158, 20);
            this.dateTimePickerBirthdayDate.TabIndex = 23;
            // 
            // FormApplicant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 344);
            this.Controls.Add(this.dateTimePickerBirthdayDate);
            this.Controls.Add(this.comboBoxEducation);
            this.Controls.Add(this.labelEducation);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textBoxWorkExperience);
            this.Controls.Add(this.labelWorkExperience);
            this.Controls.Add(this.labelBirthdayDate);
            this.Controls.Add(this.textBoxMiddlename);
            this.Controls.Add(this.labelMiddlename);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Name = "FormApplicant";
            this.Text = "Соискатель";
            this.Load += new System.EventHandler(this.FormApplicant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxMiddlename;
        private System.Windows.Forms.Label labelMiddlename;
        private System.Windows.Forms.Label labelBirthdayDate;
        private System.Windows.Forms.TextBox textBoxWorkExperience;
        private System.Windows.Forms.Label labelWorkExperience;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelEducation;
        private System.Windows.Forms.ComboBox comboBoxEducation;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthdayDate;
    }
}