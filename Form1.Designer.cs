
namespace DominZadanie2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocníkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbTrieda = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIPAdresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMask = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BroadcastLabel = new System.Windows.Forms.Label();
            this.NetIDLabel = new System.Windows.Forms.Label();
            this.HostsAmmountLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SubnetAmmountLabel = new System.Windows.Forms.Label();
            this.IPRangeLabel = new System.Windows.Forms.Label();
            this.BitMaskLabel = new System.Windows.Forms.Label();
            this.NetRangeLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autorToolStripMenuItem,
            this.pomocníkToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.autorToolStripMenuItem.Text = "Autor";
            this.autorToolStripMenuItem.Click += new System.EventHandler(this.autorToolStripMenuItem_Click);
            // 
            // pomocníkToolStripMenuItem
            // 
            this.pomocníkToolStripMenuItem.Name = "pomocníkToolStripMenuItem";
            this.pomocníkToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.pomocníkToolStripMenuItem.Text = "Pomocník";
            this.pomocníkToolStripMenuItem.Click += new System.EventHandler(this.pomocníkToolStripMenuItem_Click);
            // 
            // cbTrieda
            // 
            this.cbTrieda.FormattingEnabled = true;
            this.cbTrieda.Items.AddRange(new object[] {
            "Trieda A",
            "Trieda B",
            "Trieda C"});
            this.cbTrieda.Location = new System.Drawing.Point(80, 44);
            this.cbTrieda.Name = "cbTrieda";
            this.cbTrieda.Size = new System.Drawing.Size(121, 21);
            this.cbTrieda.TabIndex = 1;
            this.cbTrieda.SelectedIndexChanged += new System.EventHandler(this.cbTrieda_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Treida siete";
            // 
            // tbIPAdresa
            // 
            this.tbIPAdresa.Location = new System.Drawing.Point(80, 71);
            this.tbIPAdresa.Name = "tbIPAdresa";
            this.tbIPAdresa.Size = new System.Drawing.Size(275, 20);
            this.tbIPAdresa.TabIndex = 3;
            this.tbIPAdresa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbIPAdresa_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "IP Adresa";
            // 
            // cbMask
            // 
            this.cbMask.FormattingEnabled = true;
            this.cbMask.Items.AddRange(new object[] {
            "Trieda A",
            "Trieda B",
            "Trieda C"});
            this.cbMask.Location = new System.Drawing.Point(80, 97);
            this.cbMask.Name = "cbMask";
            this.cbMask.Size = new System.Drawing.Size(275, 21);
            this.cbMask.TabIndex = 5;
            this.cbMask.SelectedIndexChanged += new System.EventHandler(this.cbMask_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Subnet Mask";
            // 
            // BroadcastLabel
            // 
            this.BroadcastLabel.AutoSize = true;
            this.BroadcastLabel.Location = new System.Drawing.Point(586, 78);
            this.BroadcastLabel.Name = "BroadcastLabel";
            this.BroadcastLabel.Size = new System.Drawing.Size(76, 13);
            this.BroadcastLabel.TabIndex = 7;
            this.BroadcastLabel.Text = "192.168.1.255";
            // 
            // NetIDLabel
            // 
            this.NetIDLabel.AutoSize = true;
            this.NetIDLabel.Location = new System.Drawing.Point(586, 65);
            this.NetIDLabel.Name = "NetIDLabel";
            this.NetIDLabel.Size = new System.Drawing.Size(64, 13);
            this.NetIDLabel.TabIndex = 8;
            this.NetIDLabel.Text = "192.168.1.0";
            // 
            // HostsAmmountLabel
            // 
            this.HostsAmmountLabel.AutoSize = true;
            this.HostsAmmountLabel.Location = new System.Drawing.Point(586, 91);
            this.HostsAmmountLabel.Name = "HostsAmmountLabel";
            this.HostsAmmountLabel.Size = new System.Drawing.Size(25, 13);
            this.HostsAmmountLabel.TabIndex = 9;
            this.HostsAmmountLabel.Text = "254";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Maximalny pocet uzivatelov";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(443, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Broadcast";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(443, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID siete";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(443, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "pocet podsieti";
            // 
            // SubnetAmmountLabel
            // 
            this.SubnetAmmountLabel.AutoSize = true;
            this.SubnetAmmountLabel.Location = new System.Drawing.Point(586, 52);
            this.SubnetAmmountLabel.Name = "SubnetAmmountLabel";
            this.SubnetAmmountLabel.Size = new System.Drawing.Size(13, 13);
            this.SubnetAmmountLabel.TabIndex = 15;
            this.SubnetAmmountLabel.Text = "1";
            // 
            // IPRangeLabel
            // 
            this.IPRangeLabel.AutoSize = true;
            this.IPRangeLabel.Location = new System.Drawing.Point(586, 113);
            this.IPRangeLabel.Name = "IPRangeLabel";
            this.IPRangeLabel.Size = new System.Drawing.Size(142, 13);
            this.IPRangeLabel.TabIndex = 17;
            this.IPRangeLabel.Text = "192.0.0.1 - 223.255.255.254";
            // 
            // BitMaskLabel
            // 
            this.BitMaskLabel.AutoSize = true;
            this.BitMaskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BitMaskLabel.Location = new System.Drawing.Point(586, 100);
            this.BitMaskLabel.Name = "BitMaskLabel";
            this.BitMaskLabel.Size = new System.Drawing.Size(200, 13);
            this.BitMaskLabel.TabIndex = 18;
            this.BitMaskLabel.Text = "110nnnnn.nnnnnnnn.nnnnnnnn.ssssssss";
            // 
            // NetRangeLabel
            // 
            this.NetRangeLabel.AutoSize = true;
            this.NetRangeLabel.Location = new System.Drawing.Point(586, 131);
            this.NetRangeLabel.Name = "NetRangeLabel";
            this.NetRangeLabel.Size = new System.Drawing.Size(64, 13);
            this.NetRangeLabel.TabIndex = 19;
            this.NetRangeLabel.Text = "192.168.1.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 206);
            this.Controls.Add(this.NetRangeLabel);
            this.Controls.Add(this.BitMaskLabel);
            this.Controls.Add(this.IPRangeLabel);
            this.Controls.Add(this.SubnetAmmountLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HostsAmmountLabel);
            this.Controls.Add(this.NetIDLabel);
            this.Controls.Add(this.BroadcastLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbMask);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbIPAdresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTrieda);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Kalkulacka podsieti";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocníkToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbTrieda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIPAdresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label BroadcastLabel;
        private System.Windows.Forms.Label NetIDLabel;
        private System.Windows.Forms.Label HostsAmmountLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label SubnetAmmountLabel;
        private System.Windows.Forms.Label IPRangeLabel;
        private System.Windows.Forms.Label BitMaskLabel;
        private System.Windows.Forms.Label NetRangeLabel;
    }
}

