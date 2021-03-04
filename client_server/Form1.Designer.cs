
namespace client_server
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.settings = new System.Windows.Forms.Button();
            this.download = new System.Windows.Forms.Button();
            this.upload = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.name = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.Button();
            this.fullscreen = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(26)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.settings);
            this.panel1.Controls.Add(this.download);
            this.panel1.Controls.Add(this.upload);
            this.panel1.Controls.Add(this.menu);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 681);
            this.panel1.TabIndex = 0;
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(124)))));
            this.settings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.settings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(26)))), ((int)(((byte)(54)))));
            this.settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings.ForeColor = System.Drawing.Color.Snow;
            this.settings.Location = new System.Drawing.Point(0, 633);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(250, 48);
            this.settings.TabIndex = 4;
            this.settings.Text = "Impostazioni";
            this.settings.UseVisualStyleBackColor = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // download
            // 
            this.download.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(124)))));
            this.download.Dock = System.Windows.Forms.DockStyle.Top;
            this.download.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(26)))), ((int)(((byte)(54)))));
            this.download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.download.ForeColor = System.Drawing.Color.Snow;
            this.download.Location = new System.Drawing.Point(0, 264);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(250, 48);
            this.download.TabIndex = 3;
            this.download.Text = "Scarica file";
            this.download.UseVisualStyleBackColor = false;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // upload
            // 
            this.upload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(124)))));
            this.upload.Dock = System.Windows.Forms.DockStyle.Top;
            this.upload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(26)))), ((int)(((byte)(54)))));
            this.upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upload.ForeColor = System.Drawing.Color.Snow;
            this.upload.Location = new System.Drawing.Point(0, 216);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(250, 48);
            this.upload.TabIndex = 2;
            this.upload.Text = "Carica file";
            this.upload.UseVisualStyleBackColor = false;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(124)))));
            this.menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(26)))), ((int)(((byte)(54)))));
            this.menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu.ForeColor = System.Drawing.Color.Snow;
            this.menu.Location = new System.Drawing.Point(0, 168);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(250, 48);
            this.menu.TabIndex = 1;
            this.menu.Text = "Pagina principale";
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(84)))));
            this.panel2.Controls.Add(this.name);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 168);
            this.panel2.TabIndex = 0;
            // 
            // name
            // 
            this.name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name.Font = new System.Drawing.Font("Noto Mono", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.name.Location = new System.Drawing.Point(0, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(250, 168);
            this.name.TabIndex = 0;
            this.name.Text = "CIPCLOUD";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.Snow;
            this.textBox1.Location = new System.Drawing.Point(720, 292);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 13);
            this.textBox1.TabIndex = 1;
            // 
            // label
            // 
            this.label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label.ForeColor = System.Drawing.Color.Snow;
            this.label.Location = new System.Drawing.Point(250, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(974, 681);
            this.label.TabIndex = 2;
            this.label.Text = "Benvenuto!";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.minimize);
            this.panel3.Controls.Add(this.fullscreen);
            this.panel3.Controls.Add(this.exit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(250, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(974, 26);
            this.panel3.TabIndex = 3;
            // 
            // minimize
            // 
            this.minimize.AutoSize = true;
            this.minimize.BackgroundImage = global::client_server.Properties.Resources.minimize;
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.minimize.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.minimize.Location = new System.Drawing.Point(839, 0);
            this.minimize.Name = "minimize";
            this.minimize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.minimize.Size = new System.Drawing.Size(45, 26);
            this.minimize.TabIndex = 2;
            this.minimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // fullscreen
            // 
            this.fullscreen.AutoSize = true;
            this.fullscreen.BackgroundImage = global::client_server.Properties.Resources.maximize;
            this.fullscreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fullscreen.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.fullscreen.Dock = System.Windows.Forms.DockStyle.Right;
            this.fullscreen.FlatAppearance.BorderSize = 0;
            this.fullscreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fullscreen.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.fullscreen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fullscreen.Location = new System.Drawing.Point(884, 0);
            this.fullscreen.Name = "fullscreen";
            this.fullscreen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fullscreen.Size = new System.Drawing.Size(45, 26);
            this.fullscreen.TabIndex = 1;
            this.fullscreen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.fullscreen.UseVisualStyleBackColor = false;
            this.fullscreen.Click += new System.EventHandler(this.fullscreen_Click);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackgroundImage = global::client_server.Properties.Resources.exit;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.ForeColor = System.Drawing.Color.Chartreuse;
            this.exit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exit.Location = new System.Drawing.Point(929, 0);
            this.exit.Name = "exit";
            this.exit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exit.Size = new System.Drawing.Size(45, 26);
            this.exit.TabIndex = 0;
            this.exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseLeave += new System.EventHandler(this.exit_MouseLeave);
            this.exit.MouseHover += new System.EventHandler(this.exit_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1224, 681);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "CIPCLOUD client";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button download;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label name;
        public System.Windows.Forms.Button exit;
        public System.Windows.Forms.Button fullscreen;
        public System.Windows.Forms.Button minimize;
    }
}

