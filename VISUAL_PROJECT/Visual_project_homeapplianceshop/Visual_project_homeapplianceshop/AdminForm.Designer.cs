namespace Visual_project_homeapplianceshop
{
    partial class AdminForm
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
            Guna.UI2.WinForms.Guna2Button guna2Button3;
            this.AdminIdtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.AdminNametxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.Passtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.AdminId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AdminName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AdminPass = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2Button3
            // 
            guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            guna2Button3.ForeColor = System.Drawing.Color.White;
            guna2Button3.Location = new System.Drawing.Point(217, 348);
            guna2Button3.Name = "guna2Button3";
            guna2Button3.Size = new System.Drawing.Size(106, 30);
            guna2Button3.TabIndex = 5;
            guna2Button3.Text = "Güncelle";
            guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // AdminIdtxt
            // 
            this.AdminIdtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AdminIdtxt.DefaultText = "Kullanıcı ID";
            this.AdminIdtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AdminIdtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AdminIdtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AdminIdtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AdminIdtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AdminIdtxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AdminIdtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AdminIdtxt.Location = new System.Drawing.Point(146, 132);
            this.AdminIdtxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AdminIdtxt.Name = "AdminIdtxt";
            this.AdminIdtxt.PasswordChar = '\0';
            this.AdminIdtxt.PlaceholderText = "";
            this.AdminIdtxt.SelectedText = "";
            this.AdminIdtxt.Size = new System.Drawing.Size(177, 30);
            this.AdminIdtxt.TabIndex = 0;
            // 
            // AdminNametxt
            // 
            this.AdminNametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AdminNametxt.DefaultText = "Kullanıcı Adı";
            this.AdminNametxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AdminNametxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AdminNametxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AdminNametxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AdminNametxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AdminNametxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AdminNametxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AdminNametxt.Location = new System.Drawing.Point(146, 183);
            this.AdminNametxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AdminNametxt.Name = "AdminNametxt";
            this.AdminNametxt.PasswordChar = '\0';
            this.AdminNametxt.PlaceholderText = "";
            this.AdminNametxt.SelectedText = "";
            this.AdminNametxt.Size = new System.Drawing.Size(177, 30);
            this.AdminNametxt.TabIndex = 1;
            // 
            // Passtxt
            // 
            this.Passtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Passtxt.DefaultText = "Şifre";
            this.Passtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Passtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Passtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Passtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Passtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Passtxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Passtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Passtxt.Location = new System.Drawing.Point(146, 236);
            this.Passtxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Passtxt.Name = "Passtxt";
            this.Passtxt.PasswordChar = '\0';
            this.Passtxt.PlaceholderText = "";
            this.Passtxt.SelectedText = "";
            this.Passtxt.Size = new System.Drawing.Size(177, 30);
            this.Passtxt.TabIndex = 2;
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(146, 312);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(106, 30);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Text = "Ekle";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(284, 312);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(106, 30);
            this.guna2Button2.TabIndex = 4;
            this.guna2Button2.Text = "Sil";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button5
            // 
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Location = new System.Drawing.Point(217, 435);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(106, 30);
            this.guna2Button5.TabIndex = 7;
            this.guna2Button5.Text = "Anasayfa";
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AdminId,
            this.AdminName,
            this.AdminPass});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(442, 169);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(702, 213);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // AdminId
            // 
            this.AdminId.Text = "AdminId";
            this.AdminId.Width = 126;
            // 
            // AdminName
            // 
            this.AdminName.Text = "AdminName";
            this.AdminName.Width = 244;
            // 
            // AdminPass
            // 
            this.AdminPass.Text = "AdminPass";
            this.AdminPass.Width = 258;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(1177, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1220, 607);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.guna2Button5);
            this.Controls.Add(guna2Button3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.Passtxt);
            this.Controls.Add(this.AdminNametxt);
            this.Controls.Add(this.AdminIdtxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox AdminIdtxt;
        private Guna.UI2.WinForms.Guna2TextBox AdminNametxt;
        private Guna.UI2.WinForms.Guna2TextBox Passtxt;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader AdminId;
        private System.Windows.Forms.ColumnHeader AdminName;
        private System.Windows.Forms.ColumnHeader AdminPass;
        private System.Windows.Forms.Label label1;
    }
}