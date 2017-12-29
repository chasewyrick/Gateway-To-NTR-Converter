namespace Gateway2NTR
{
    partial class Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Converter));
            this.FI_Timer = new System.Windows.Forms.Timer(this.components);
            this.FO_Timer = new System.Windows.Forms.Timer(this.components);
            this.Restart_Timer = new System.Windows.Forms.Timer(this.components);
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nDSCodetypeReferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.C_Label = new System.Windows.Forms.Label();
            this.C_Textbox = new System.Windows.Forms.TextBox();
            this.Optimize_Button = new System.Windows.Forms.Button();
            this.Build_Button = new System.Windows.Forms.Button();
            this.Copy_Button = new System.Windows.Forms.Button();
            this.Gateway_Textbox = new System.Windows.Forms.TextBox();
            this.P_Textbox = new System.Windows.Forms.TextBox();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
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
            // Restart_Timer
            // 
            this.Restart_Timer.Interval = 25;
            this.Restart_Timer.Tick += new System.EventHandler(this.Restart_Timer_Tick);
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.Crimson;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.restartToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(600, 24);
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
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // C_Label
            // 
            this.C_Label.AutoSize = true;
            this.C_Label.BackColor = System.Drawing.Color.Transparent;
            this.C_Label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_Label.ForeColor = System.Drawing.Color.Crimson;
            this.C_Label.Location = new System.Drawing.Point(226, 34);
            this.C_Label.Name = "C_Label";
            this.C_Label.Size = new System.Drawing.Size(148, 25);
            this.C_Label.TabIndex = 2;
            this.C_Label.Text = "Converted Code";
            // 
            // C_Textbox
            // 
            this.C_Textbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.C_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.C_Textbox.ForeColor = System.Drawing.Color.Crimson;
            this.C_Textbox.Location = new System.Drawing.Point(62, 62);
            this.C_Textbox.Multiline = true;
            this.C_Textbox.Name = "C_Textbox";
            this.C_Textbox.ReadOnly = true;
            this.C_Textbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.C_Textbox.Size = new System.Drawing.Size(477, 286);
            this.C_Textbox.TabIndex = 3;
            // 
            // Optimize_Button
            // 
            this.Optimize_Button.BackColor = System.Drawing.Color.Gainsboro;
            this.Optimize_Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Optimize_Button.ForeColor = System.Drawing.Color.Crimson;
            this.Optimize_Button.Location = new System.Drawing.Point(62, 354);
            this.Optimize_Button.Name = "Optimize_Button";
            this.Optimize_Button.Size = new System.Drawing.Size(135, 34);
            this.Optimize_Button.TabIndex = 4;
            this.Optimize_Button.Text = "Optimize Code";
            this.Optimize_Button.UseVisualStyleBackColor = false;
            this.Optimize_Button.Click += new System.EventHandler(this.Optimize_Button_Click);
            // 
            // Build_Button
            // 
            this.Build_Button.BackColor = System.Drawing.Color.Gainsboro;
            this.Build_Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Build_Button.ForeColor = System.Drawing.Color.Crimson;
            this.Build_Button.Location = new System.Drawing.Point(233, 354);
            this.Build_Button.Name = "Build_Button";
            this.Build_Button.Size = new System.Drawing.Size(135, 34);
            this.Build_Button.TabIndex = 4;
            this.Build_Button.Text = "Build Cheat Plugin";
            this.Build_Button.UseVisualStyleBackColor = false;
            this.Build_Button.Click += new System.EventHandler(this.Build_Button_Click);
            // 
            // Copy_Button
            // 
            this.Copy_Button.BackColor = System.Drawing.Color.Gainsboro;
            this.Copy_Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Copy_Button.ForeColor = System.Drawing.Color.Crimson;
            this.Copy_Button.Location = new System.Drawing.Point(404, 354);
            this.Copy_Button.Name = "Copy_Button";
            this.Copy_Button.Size = new System.Drawing.Size(135, 34);
            this.Copy_Button.TabIndex = 4;
            this.Copy_Button.Text = "Copy To Clipboard";
            this.Copy_Button.UseVisualStyleBackColor = false;
            this.Copy_Button.Click += new System.EventHandler(this.Copy_Button_Click);
            // 
            // Gateway_Textbox
            // 
            this.Gateway_Textbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Gateway_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Gateway_Textbox.ForeColor = System.Drawing.Color.Crimson;
            this.Gateway_Textbox.Location = new System.Drawing.Point(541, 27);
            this.Gateway_Textbox.Multiline = true;
            this.Gateway_Textbox.Name = "Gateway_Textbox";
            this.Gateway_Textbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Gateway_Textbox.Size = new System.Drawing.Size(59, 29);
            this.Gateway_Textbox.TabIndex = 3;
            this.Gateway_Textbox.Visible = false;
            // 
            // P_Textbox
            // 
            this.P_Textbox.BackColor = System.Drawing.Color.Gainsboro;
            this.P_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.P_Textbox.ForeColor = System.Drawing.Color.Crimson;
            this.P_Textbox.Location = new System.Drawing.Point(233, 402);
            this.P_Textbox.Name = "P_Textbox";
            this.P_Textbox.Size = new System.Drawing.Size(135, 15);
            this.P_Textbox.TabIndex = 5;
            this.P_Textbox.Text = "Plugin";
            this.P_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 448);
            this.Controls.Add(this.P_Textbox);
            this.Controls.Add(this.Copy_Button);
            this.Controls.Add(this.Build_Button);
            this.Controls.Add(this.Optimize_Button);
            this.Controls.Add(this.Gateway_Textbox);
            this.Controls.Add(this.C_Textbox);
            this.Controls.Add(this.C_Label);
            this.Controls.Add(this.MenuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Converter";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gateway2NTR | Converted Code";
            this.Load += new System.EventHandler(this.Converter_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer FI_Timer;
        private System.Windows.Forms.Timer FO_Timer;
        private System.Windows.Forms.Timer Restart_Timer;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nDSCodetypeReferenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.Label C_Label;
        private System.Windows.Forms.TextBox C_Textbox;
        private System.Windows.Forms.Button Optimize_Button;
        private System.Windows.Forms.Button Build_Button;
        private System.Windows.Forms.Button Copy_Button;
        private System.Windows.Forms.TextBox Gateway_Textbox;
        private System.Windows.Forms.TextBox P_Textbox;
    }
}