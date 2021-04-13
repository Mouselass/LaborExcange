
namespace LaborExchange
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.соискателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работодателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работникиБиржиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.образованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вакансииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сделкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.входToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регистрацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.соискателиToolStripMenuItem,
            this.работодателиToolStripMenuItem,
            this.работникиБиржиToolStripMenuItem,
            this.образованиеToolStripMenuItem,
            this.вакансииToolStripMenuItem,
            this.сделкиToolStripMenuItem,
            this.входToolStripMenuItem,
            this.регистрацияToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // соискателиToolStripMenuItem
            // 
            this.соискателиToolStripMenuItem.Name = "соискателиToolStripMenuItem";
            this.соискателиToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.соискателиToolStripMenuItem.Text = "Соискатели";
            this.соискателиToolStripMenuItem.Click += new System.EventHandler(this.соискателиToolStripMenuItem_Click);
            // 
            // работодателиToolStripMenuItem
            // 
            this.работодателиToolStripMenuItem.Name = "работодателиToolStripMenuItem";
            this.работодателиToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.работодателиToolStripMenuItem.Text = "Работодатели";
            this.работодателиToolStripMenuItem.Click += new System.EventHandler(this.работодателиToolStripMenuItem_Click);
            // 
            // работникиБиржиToolStripMenuItem
            // 
            this.работникиБиржиToolStripMenuItem.Name = "работникиБиржиToolStripMenuItem";
            this.работникиБиржиToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.работникиБиржиToolStripMenuItem.Text = "Работники биржи";
            this.работникиБиржиToolStripMenuItem.Click += new System.EventHandler(this.работникиБиржиToolStripMenuItem_Click);
            // 
            // образованиеToolStripMenuItem
            // 
            this.образованиеToolStripMenuItem.Name = "образованиеToolStripMenuItem";
            this.образованиеToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.образованиеToolStripMenuItem.Text = "Образование";
            this.образованиеToolStripMenuItem.Click += new System.EventHandler(this.образованиеToolStripMenuItem_Click);
            // 
            // вакансииToolStripMenuItem
            // 
            this.вакансииToolStripMenuItem.Name = "вакансииToolStripMenuItem";
            this.вакансииToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.вакансииToolStripMenuItem.Text = "Вакансии";
            this.вакансииToolStripMenuItem.Click += new System.EventHandler(this.вакансииToolStripMenuItem_Click);
            // 
            // сделкиToolStripMenuItem
            // 
            this.сделкиToolStripMenuItem.Name = "сделкиToolStripMenuItem";
            this.сделкиToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.сделкиToolStripMenuItem.Text = "Сделки";
            this.сделкиToolStripMenuItem.Click += new System.EventHandler(this.сделкиToolStripMenuItem_Click);
            // 
            // входToolStripMenuItem
            // 
            this.входToolStripMenuItem.Name = "входToolStripMenuItem";
            this.входToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.входToolStripMenuItem.Text = "Вход";
            this.входToolStripMenuItem.Click += new System.EventHandler(this.входToolStripMenuItem_Click);
            // 
            // регистрацияToolStripMenuItem
            // 
            this.регистрацияToolStripMenuItem.Name = "регистрацияToolStripMenuItem";
            this.регистрацияToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.регистрацияToolStripMenuItem.Text = "Регистрация";
            this.регистрацияToolStripMenuItem.Click += new System.EventHandler(this.регистрацияToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.Text = "Главная форма";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem соискателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работодателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работникиБиржиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem образованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вакансииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сделкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem входToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem регистрацияToolStripMenuItem;
    }
}

