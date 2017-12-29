namespace Gateway2NTR
{
    partial class Gateway
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gateway));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nDSCodetypeReferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.G_Label = new System.Windows.Forms.Label();
            this.G_Textbox = new System.Windows.Forms.TextBox();
            this.G_Button = new System.Windows.Forms.Button();
            this.Next_Button = new System.Windows.Forms.Button();
            this.FI_Timer = new System.Windows.Forms.Timer(this.components);
            this.FO_Timer = new System.Windows.Forms.Timer(this.components);
            this.Next_Timer = new System.Windows.Forms.Timer(this.components);
            this.Panel_L = new System.Windows.Forms.Panel();
            this.Panel_B = new System.Windows.Forms.Panel();
            this.Panel_R = new System.Windows.Forms.Panel();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.Crimson;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(360, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "MenuStrip";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nDSCodetypeReferenceToolStripMenuItem,
            this.informationToolStripMenuItem,
            this.creditsToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // nDSCodetypeReferenceToolStripMenuItem
            // 
            this.nDSCodetypeReferenceToolStripMenuItem.BackColor = System.Drawing.Color.Crimson;
            this.nDSCodetypeReferenceToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.nDSCodetypeReferenceToolStripMenuItem.Name = "nDSCodetypeReferenceToolStripMenuItem";
            this.nDSCodetypeReferenceToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.nDSCodetypeReferenceToolStripMenuItem.Text = "NDS Codetype Reference";
            this.nDSCodetypeReferenceToolStripMenuItem.Click += new System.EventHandler(this.nDSCodetypeReferenceToolStripMenuItem_Click);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.BackColor = System.Drawing.Color.Crimson;
            this.informationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.informationToolStripMenuItem.Text = "Information";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.BackColor = System.Drawing.Color.Crimson;
            this.creditsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.creditsToolStripMenuItem.Text = "Credits";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            // 
            // G_Label
            // 
            this.G_Label.AutoSize = true;
            this.G_Label.BackColor = System.Drawing.Color.Transparent;
            this.G_Label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G_Label.ForeColor = System.Drawing.Color.Crimson;
            this.G_Label.Location = new System.Drawing.Point(89, 34);
            this.G_Label.Name = "G_Label";
            this.G_Label.Size = new System.Drawing.Size(182, 25);
            this.G_Label.TabIndex = 1;
            this.G_Label.Text = "Enter Gateway Code";
            // 
            // G_Textbox
            // 
            this.G_Textbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.G_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.G_Textbox.ForeColor = System.Drawing.Color.Crimson;
            this.G_Textbox.Location = new System.Drawing.Point(69, 67);
            this.G_Textbox.Multiline = true;
            this.G_Textbox.Name = "G_Textbox";
            this.G_Textbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.G_Textbox.Size = new System.Drawing.Size(223, 327);
            this.G_Textbox.TabIndex = 2;
            this.G_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // G_Button
            // 
            this.G_Button.BackColor = System.Drawing.Color.Gainsboro;
            this.G_Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.G_Button.ForeColor = System.Drawing.Color.Crimson;
            this.G_Button.Location = new System.Drawing.Point(112, 400);
            this.G_Button.Name = "G_Button";
            this.G_Button.Size = new System.Drawing.Size(135, 34);
            this.G_Button.TabIndex = 3;
            this.G_Button.Text = "Load Cheatlist";
            this.G_Button.UseVisualStyleBackColor = false;
            this.G_Button.Click += new System.EventHandler(this.G_Button_Click);
            // 
            // Next_Button
            // 
            this.Next_Button.BackColor = System.Drawing.Color.White;
            this.Next_Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Next_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next_Button.ForeColor = System.Drawing.Color.Crimson;
            this.Next_Button.Location = new System.Drawing.Point(273, 425);
            this.Next_Button.Name = "Next_Button";
            this.Next_Button.Size = new System.Drawing.Size(75, 23);
            this.Next_Button.TabIndex = 3;
            this.Next_Button.Text = "Next Step";
            this.Next_Button.UseVisualStyleBackColor = false;
            this.Next_Button.Click += new System.EventHandler(this.Next_Button_Click);
            // 
            // FI_Timer
            // 
            this.FI_Timer.Interval = 25;
            this.FI_Timer.Tick += new System.EventHandler(this.FI_Timer_Tick);
            // 
            // FO_Timer
            // 
            this.FO_Timer.Interval = 25;
            this.FO_Timer.Tick += new System.EventHandler(this.FO_Timer_Tick);
            // 
            // Next_Timer
            // 
            this.Next_Timer.Interval = 25;
            this.Next_Timer.Tick += new System.EventHandler(this.Next_Timer_Tick);
            // 
            // Panel_L
            // 
            this.Panel_L.BackColor = System.Drawing.Color.Gainsboro;
            this.Panel_L.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_L.Location = new System.Drawing.Point(0, 24);
            this.Panel_L.Name = "Panel_L";
            this.Panel_L.Size = new System.Drawing.Size(3, 436);
            this.Panel_L.TabIndex = 4;
            // 
            // Panel_B
            // 
            this.Panel_B.BackColor = System.Drawing.Color.Gainsboro;
            this.Panel_B.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_B.Location = new System.Drawing.Point(3, 457);
            this.Panel_B.Name = "Panel_B";
            this.Panel_B.Size = new System.Drawing.Size(357, 3);
            this.Panel_B.TabIndex = 0;
            // 
            // Panel_R
            // 
            this.Panel_R.BackColor = System.Drawing.Color.Gainsboro;
            this.Panel_R.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel_R.Location = new System.Drawing.Point(357, 24);
            this.Panel_R.Name = "Panel_R";
            this.Panel_R.Size = new System.Drawing.Size(3, 433);
            this.Panel_R.TabIndex = 5;
            // 
            // Gateway
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(360, 460);
            this.Controls.Add(this.Panel_R);
            this.Controls.Add(this.Panel_B);
            this.Controls.Add(this.Panel_L);
            this.Controls.Add(this.Next_Button);
            this.Controls.Add(this.G_Button);
            this.Controls.Add(this.G_Textbox);
            this.Controls.Add(this.G_Label);
            this.Controls.Add(this.MenuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Gateway";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gateway2NTR | Enter Gateshark Code";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label G_Label;
        private System.Windows.Forms.Button G_Button;
        private System.Windows.Forms.Button Next_Button;
        private System.Windows.Forms.Timer FI_Timer;
        private System.Windows.Forms.Timer FO_Timer;
        private System.Windows.Forms.ToolStripMenuItem nDSCodetypeReferenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.Timer Next_Timer;
        public System.Windows.Forms.TextBox G_Textbox;
        private System.Windows.Forms.Panel Panel_L;
        private System.Windows.Forms.Panel Panel_B;
        private System.Windows.Forms.Panel Panel_R;
    }
}

