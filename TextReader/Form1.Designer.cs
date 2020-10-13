namespace TextReader
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GoButton = new System.Windows.Forms.Button();
            this.InPutText = new System.Windows.Forms.TextBox();
            this.OutPutText = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PathMenu = new System.Windows.Forms.MenuStrip();
            this.PathMenu_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PathMenu_1_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PathMenu_1_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.SwitchTheme = new System.Windows.Forms.Button();
            this.Tools_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_3 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.PathMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GoButton
            // 
            this.GoButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.GoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.GoButton.ForeColor = System.Drawing.SystemColors.Window;
            this.GoButton.Location = new System.Drawing.Point(240, 186);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(440, 50);
            this.GoButton.TabIndex = 1;
            this.GoButton.Text = "Запомнить данные";
            this.GoButton.UseVisualStyleBackColor = false;
            this.GoButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // InPutText
            // 
            this.InPutText.BackColor = System.Drawing.SystemColors.Desktop;
            this.InPutText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InPutText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.InPutText.ForeColor = System.Drawing.SystemColors.Window;
            this.InPutText.Location = new System.Drawing.Point(0, 0);
            this.InPutText.Multiline = true;
            this.InPutText.Name = "InPutText";
            this.InPutText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InPutText.Size = new System.Drawing.Size(680, 180);
            this.InPutText.TabIndex = 3;
            this.InPutText.TextChanged += new System.EventHandler(this.InPutText_TextChanged);
            // 
            // OutPutText
            // 
            this.OutPutText.BackColor = System.Drawing.SystemColors.Desktop;
            this.OutPutText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutPutText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.OutPutText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.OutPutText.ForeColor = System.Drawing.SystemColors.Window;
            this.OutPutText.Location = new System.Drawing.Point(0, 257);
            this.OutPutText.Multiline = true;
            this.OutPutText.Name = "OutPutText";
            this.OutPutText.ReadOnly = true;
            this.OutPutText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutPutText.Size = new System.Drawing.Size(680, 220);
            this.OutPutText.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PathMenu);
            this.panel1.Controls.Add(this.OutPutText);
            this.panel1.Controls.Add(this.InPutText);
            this.panel1.Controls.Add(this.GoButton);
            this.panel1.Controls.Add(this.SwitchTheme);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 477);
            this.panel1.TabIndex = 2;
            // 
            // PathMenu
            // 
            this.PathMenu.AutoSize = false;
            this.PathMenu.BackColor = System.Drawing.SystemColors.Desktop;
            this.PathMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.PathMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PathMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PathMenu_1,
            this.Tools_1});
            this.PathMenu.Location = new System.Drawing.Point(33, 186);
            this.PathMenu.Name = "PathMenu";
            this.PathMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.PathMenu.Size = new System.Drawing.Size(204, 30);
            this.PathMenu.TabIndex = 0;
            this.PathMenu.Text = "Path";
            this.PathMenu.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            this.PathMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // PathMenu_1
            // 
            this.PathMenu_1.AutoSize = false;
            this.PathMenu_1.BackColor = System.Drawing.SystemColors.Desktop;
            this.PathMenu_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PathMenu_1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.PathMenu_1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PathMenu_1_1,
            this.PathMenu_1_2});
            this.PathMenu_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PathMenu_1.ForeColor = System.Drawing.SystemColors.Window;
            this.PathMenu_1.ImageTransparentColor = System.Drawing.SystemColors.WindowText;
            this.PathMenu_1.Name = "PathMenu_1";
            this.PathMenu_1.ShowShortcutKeys = false;
            this.PathMenu_1.Size = new System.Drawing.Size(95, 25);
            this.PathMenu_1.Text = "Paths";
            this.PathMenu_1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.PathMenu_1.Click += new System.EventHandler(this.path1ToolStripMenuItem_Click);
            // 
            // PathMenu_1_1
            // 
            this.PathMenu_1_1.AutoSize = false;
            this.PathMenu_1_1.BackColor = System.Drawing.SystemColors.Desktop;
            this.PathMenu_1_1.ForeColor = System.Drawing.SystemColors.Window;
            this.PathMenu_1_1.Name = "PathMenu_1_1";
            this.PathMenu_1_1.Size = new System.Drawing.Size(180, 30);
            this.PathMenu_1_1.Text = "DeskTop";
            this.PathMenu_1_1.Click += new System.EventHandler(this.appDataToolStripMenuItem_Click);
            // 
            // PathMenu_1_2
            // 
            this.PathMenu_1_2.AutoSize = false;
            this.PathMenu_1_2.BackColor = System.Drawing.SystemColors.Desktop;
            this.PathMenu_1_2.ForeColor = System.Drawing.SystemColors.Window;
            this.PathMenu_1_2.Name = "PathMenu_1_2";
            this.PathMenu_1_2.ShowShortcutKeys = false;
            this.PathMenu_1_2.Size = new System.Drawing.Size(180, 30);
            this.PathMenu_1_2.Text = "AppData";
            this.PathMenu_1_2.Click += new System.EventHandler(this.appDataRoamingToolStripMenuItem_Click);
            // 
            // SwitchTheme
            // 
            this.SwitchTheme.BackColor = System.Drawing.SystemColors.Desktop;
            this.SwitchTheme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SwitchTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SwitchTheme.ForeColor = System.Drawing.SystemColors.Window;
            this.SwitchTheme.Location = new System.Drawing.Point(0, 186);
            this.SwitchTheme.Name = "SwitchTheme";
            this.SwitchTheme.Size = new System.Drawing.Size(30, 50);
            this.SwitchTheme.TabIndex = 1;
            this.SwitchTheme.UseVisualStyleBackColor = false;
            this.SwitchTheme.Click += new System.EventHandler(this.button2_Click);
            // 
            // Tools_1
            // 
            this.Tools_1.AutoSize = false;
            this.Tools_1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_1,
            this.Tool_2,
            this.Tool_3});
            this.Tools_1.ForeColor = System.Drawing.SystemColors.Window;
            this.Tools_1.Name = "Tools_1";
            this.Tools_1.Size = new System.Drawing.Size(95, 25);
            this.Tools_1.Text = "Tools";
            this.Tools_1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // Tool_1
            // 
            this.Tool_1.BackColor = System.Drawing.SystemColors.Desktop;
            this.Tool_1.ForeColor = System.Drawing.SystemColors.Window;
            this.Tool_1.Name = "Tool_1";
            this.Tool_1.Size = new System.Drawing.Size(195, 28);
            this.Tool_1.Text = "Clear history";
            this.Tool_1.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // Tool_2
            // 
            this.Tool_2.BackColor = System.Drawing.SystemColors.Desktop;
            this.Tool_2.ForeColor = System.Drawing.SystemColors.Window;
            this.Tool_2.Name = "Tool_2";
            this.Tool_2.Size = new System.Drawing.Size(195, 28);
            this.Tool_2.Text = "Anim (On/Off)";
            this.Tool_2.Click += new System.EventHandler(this.Tool_2_Click);
            // 
            // Tool_3
            // 
            this.Tool_3.BackColor = System.Drawing.SystemColors.Desktop;
            this.Tool_3.ForeColor = System.Drawing.SystemColors.Window;
            this.Tool_3.Name = "Tool_3";
            this.Tool_3.Size = new System.Drawing.Size(195, 28);
            this.Tool_3.Text = "Information";
            this.Tool_3.Click += new System.EventHandler(this.Tool_3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(704, 501);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "TextReader";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PathMenu.ResumeLayout(false);
            this.PathMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.TextBox InPutText;
        private System.Windows.Forms.TextBox OutPutText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SwitchTheme;
        private System.Windows.Forms.MenuStrip PathMenu;
        private System.Windows.Forms.ToolStripMenuItem PathMenu_1;
        private System.Windows.Forms.ToolStripMenuItem PathMenu_1_2;
        private System.Windows.Forms.ToolStripMenuItem PathMenu_1_1;
        private System.Windows.Forms.ToolStripMenuItem Tools_1;
        private System.Windows.Forms.ToolStripMenuItem Tool_1;
        private System.Windows.Forms.ToolStripMenuItem Tool_2;
        private System.Windows.Forms.ToolStripMenuItem Tool_3;
    }
}

