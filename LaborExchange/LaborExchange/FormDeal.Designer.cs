
namespace LaborExchange
{
    partial class FormDeal
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
            this.labelApplicant = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxVacancy = new System.Windows.Forms.ComboBox();
            this.labelVacancy = new System.Windows.Forms.Label();
            this.comboBoxApplicant = new System.Windows.Forms.ComboBox();
            this.labelExchangeEmployee = new System.Windows.Forms.Label();
            this.comboBoxExchangeEmployee = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelApplicant
            // 
            this.labelApplicant.AutoSize = true;
            this.labelApplicant.Location = new System.Drawing.Point(12, 62);
            this.labelApplicant.Name = "labelApplicant";
            this.labelApplicant.Size = new System.Drawing.Size(71, 13);
            this.labelApplicant.TabIndex = 44;
            this.labelApplicant.Text = "Соискатель:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(163, 134);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 43;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(67, 134);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 42;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // comboBoxVacancy
            // 
            this.comboBoxVacancy.FormattingEnabled = true;
            this.comboBoxVacancy.Location = new System.Drawing.Point(121, 20);
            this.comboBoxVacancy.Name = "comboBoxVacancy";
            this.comboBoxVacancy.Size = new System.Drawing.Size(158, 21);
            this.comboBoxVacancy.TabIndex = 41;
            // 
            // labelVacancy
            // 
            this.labelVacancy.AutoSize = true;
            this.labelVacancy.Location = new System.Drawing.Point(12, 23);
            this.labelVacancy.Name = "labelVacancy";
            this.labelVacancy.Size = new System.Drawing.Size(60, 13);
            this.labelVacancy.TabIndex = 40;
            this.labelVacancy.Text = "Вакансия:";
            // 
            // comboBoxApplicant
            // 
            this.comboBoxApplicant.FormattingEnabled = true;
            this.comboBoxApplicant.Location = new System.Drawing.Point(120, 59);
            this.comboBoxApplicant.Name = "comboBoxApplicant";
            this.comboBoxApplicant.Size = new System.Drawing.Size(158, 21);
            this.comboBoxApplicant.TabIndex = 39;
            // 
            // labelExchangeEmployee
            // 
            this.labelExchangeEmployee.AutoSize = true;
            this.labelExchangeEmployee.Location = new System.Drawing.Point(13, 97);
            this.labelExchangeEmployee.Name = "labelExchangeEmployee";
            this.labelExchangeEmployee.Size = new System.Drawing.Size(101, 13);
            this.labelExchangeEmployee.TabIndex = 38;
            this.labelExchangeEmployee.Text = "Работник биржи:";
            // 
            // comboBoxExchangeEmployee
            // 
            this.comboBoxExchangeEmployee.FormattingEnabled = true;
            this.comboBoxExchangeEmployee.Location = new System.Drawing.Point(120, 94);
            this.comboBoxExchangeEmployee.Name = "comboBoxExchangeEmployee";
            this.comboBoxExchangeEmployee.Size = new System.Drawing.Size(158, 21);
            this.comboBoxExchangeEmployee.TabIndex = 50;
            // 
            // FormDeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 170);
            this.Controls.Add(this.comboBoxExchangeEmployee);
            this.Controls.Add(this.labelApplicant);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxVacancy);
            this.Controls.Add(this.labelVacancy);
            this.Controls.Add(this.comboBoxApplicant);
            this.Controls.Add(this.labelExchangeEmployee);
            this.Name = "FormDeal";
            this.Text = "Сделка";
            this.Load += new System.EventHandler(this.FormDeal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelApplicant;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBoxVacancy;
        private System.Windows.Forms.Label labelVacancy;
        private System.Windows.Forms.ComboBox comboBoxApplicant;
        private System.Windows.Forms.Label labelExchangeEmployee;
        private System.Windows.Forms.ComboBox comboBoxExchangeEmployee;
    }
}