namespace CVEFind
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.search = new System.Windows.Forms.Button();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.labelcat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.container_cve = new System.Windows.Forms.Panel();
            this.severityvalue = new System.Windows.Forms.Label();
            this.savefile = new System.Windows.Forms.Button();
            this.buttondetails = new System.Windows.Forms.Button();
            this.ccvid = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.saveccv = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.container_cve.SuspendLayout();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(1016, 12);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(95, 23);
            this.search.TabIndex = 0;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // searchbox
            // 
            this.searchbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchbox.Location = new System.Drawing.Point(12, 12);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(998, 23);
            this.searchbox.TabIndex = 1;
            this.searchbox.TextChanged += new System.EventHandler(this.searchbox_TextChanged);
            // 
            // labelcat
            // 
            this.labelcat.AutoSize = true;
            this.labelcat.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelcat.Location = new System.Drawing.Point(12, 54);
            this.labelcat.Name = "labelcat";
            this.labelcat.Size = new System.Drawing.Size(331, 37);
            this.labelcat.TabIndex = 2;
            this.labelcat.Text = "Please enter a search term.";
            this.labelcat.Click += new System.EventHandler(this.labelcat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 3;
            // 
            // container_cve
            // 
            this.container_cve.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.container_cve.Controls.Add(this.severityvalue);
            this.container_cve.Controls.Add(this.savefile);
            this.container_cve.Controls.Add(this.buttondetails);
            this.container_cve.Controls.Add(this.ccvid);
            this.container_cve.Location = new System.Drawing.Point(18, 109);
            this.container_cve.Name = "container_cve";
            this.container_cve.Size = new System.Drawing.Size(1093, 83);
            this.container_cve.TabIndex = 4;
            this.container_cve.Visible = false;
            // 
            // severityvalue
            // 
            this.severityvalue.AutoSize = true;
            this.severityvalue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.severityvalue.Location = new System.Drawing.Point(335, 23);
            this.severityvalue.Name = "severityvalue";
            this.severityvalue.Size = new System.Drawing.Size(213, 37);
            this.severityvalue.TabIndex = 3;
            this.severityvalue.Text = "Severity Value :";
            // 
            // savefile
            // 
            this.savefile.Location = new System.Drawing.Point(817, 27);
            this.savefile.Name = "savefile";
            this.savefile.Size = new System.Drawing.Size(122, 33);
            this.savefile.TabIndex = 2;
            this.savefile.Text = "Save File";
            this.savefile.UseVisualStyleBackColor = true;
            this.savefile.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttondetails
            // 
            this.buttondetails.Location = new System.Drawing.Point(958, 27);
            this.buttondetails.Name = "buttondetails";
            this.buttondetails.Size = new System.Drawing.Size(122, 33);
            this.buttondetails.TabIndex = 1;
            this.buttondetails.Text = "Show More Details";
            this.buttondetails.UseVisualStyleBackColor = true;
            this.buttondetails.Visible = false;
            this.buttondetails.Click += new System.EventHandler(this.buttondetails_Click);
            // 
            // ccvid
            // 
            this.ccvid.AutoSize = true;
            this.ccvid.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ccvid.Location = new System.Drawing.Point(15, 23);
            this.ccvid.Name = "ccvid";
            this.ccvid.Size = new System.Drawing.Size(83, 37);
            this.ccvid.TabIndex = 0;
            this.ccvid.Text = "ccvid";
            this.ccvid.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(0, 304);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1125, 145);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "Vulnerability Information Will Be Displayed Here.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.container_cve);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelcat);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.search);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CVE Finder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.container_cve.ResumeLayout(false);
            this.container_cve.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button search;
        private TextBox searchbox;
        private Label labelcat;
        private Label label1;
        private Panel container_cve;
        private Button buttondetails;
        private Label ccvid;
        private RichTextBox richTextBox1;
        private Button savefile;
        private SaveFileDialog saveccv;
        private SaveFileDialog saveFileDialog1;
        private Label severityvalue;
    }
}