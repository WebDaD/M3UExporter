namespace m3uExporter
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_m3uFile = new System.Windows.Forms.TextBox();
            this.btn_browse_m3u = new System.Windows.Forms.Button();
            this.lb_m3u_items = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_padding_auto = new System.Windows.Forms.CheckBox();
            this.nud_padding = new System.Windows.Forms.NumericUpDown();
            this.nud_starting = new System.Windows.Forms.NumericUpDown();
            this.txt_target_folder = new System.Windows.Forms.TextBox();
            this.btn_browse_target = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.pb_progress = new System.Windows.Forms.ProgressBar();
            this.ofd_m3u = new System.Windows.Forms.OpenFileDialog();
            this.fbd_target = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_padding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_starting)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_m3uFile
            // 
            this.txt_m3uFile.Location = new System.Drawing.Point(13, 13);
            this.txt_m3uFile.Name = "txt_m3uFile";
            this.txt_m3uFile.Size = new System.Drawing.Size(372, 20);
            this.txt_m3uFile.TabIndex = 0;
            this.txt_m3uFile.Text = "m3u-File";
            this.txt_m3uFile.TextChanged += new System.EventHandler(this.txt_m3uFile_TextChanged);
            // 
            // btn_browse_m3u
            // 
            this.btn_browse_m3u.Location = new System.Drawing.Point(391, 11);
            this.btn_browse_m3u.Name = "btn_browse_m3u";
            this.btn_browse_m3u.Size = new System.Drawing.Size(133, 23);
            this.btn_browse_m3u.TabIndex = 1;
            this.btn_browse_m3u.Text = "Browse...";
            this.btn_browse_m3u.UseVisualStyleBackColor = true;
            this.btn_browse_m3u.Click += new System.EventHandler(this.btn_browse_m3u_Click);
            // 
            // lb_m3u_items
            // 
            this.lb_m3u_items.FormattingEnabled = true;
            this.lb_m3u_items.Location = new System.Drawing.Point(13, 40);
            this.lb_m3u_items.Name = "lb_m3u_items";
            this.lb_m3u_items.Size = new System.Drawing.Size(511, 212);
            this.lb_m3u_items.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Padding";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cb_padding_auto, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.nud_padding, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.nud_starting, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 259);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(511, 102);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Auto";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Starting-Number";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "Manual";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_padding_auto
            // 
            this.cb_padding_auto.AutoSize = true;
            this.cb_padding_auto.Checked = true;
            this.cb_padding_auto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_padding_auto.Location = new System.Drawing.Point(343, 3);
            this.cb_padding_auto.Name = "cb_padding_auto";
            this.cb_padding_auto.Size = new System.Drawing.Size(15, 14);
            this.cb_padding_auto.TabIndex = 7;
            this.cb_padding_auto.UseVisualStyleBackColor = true;
            this.cb_padding_auto.CheckedChanged += new System.EventHandler(this.cb_padding_auto_CheckedChanged);
            // 
            // nud_padding
            // 
            this.nud_padding.Enabled = false;
            this.nud_padding.Location = new System.Drawing.Point(343, 37);
            this.nud_padding.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_padding.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_padding.Name = "nud_padding";
            this.nud_padding.Size = new System.Drawing.Size(120, 20);
            this.nud_padding.TabIndex = 8;
            this.nud_padding.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_starting
            // 
            this.nud_starting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.nud_starting, 2);
            this.nud_starting.Location = new System.Drawing.Point(173, 71);
            this.nud_starting.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nud_starting.Name = "nud_starting";
            this.nud_starting.Size = new System.Drawing.Size(335, 20);
            this.nud_starting.TabIndex = 9;
            // 
            // txt_target_folder
            // 
            this.txt_target_folder.Location = new System.Drawing.Point(13, 368);
            this.txt_target_folder.Name = "txt_target_folder";
            this.txt_target_folder.Size = new System.Drawing.Size(372, 20);
            this.txt_target_folder.TabIndex = 5;
            this.txt_target_folder.Text = "Target-Folder";
            this.txt_target_folder.TextChanged += new System.EventHandler(this.txt_target_folder_TextChanged);
            // 
            // btn_browse_target
            // 
            this.btn_browse_target.Location = new System.Drawing.Point(391, 365);
            this.btn_browse_target.Name = "btn_browse_target";
            this.btn_browse_target.Size = new System.Drawing.Size(133, 23);
            this.btn_browse_target.TabIndex = 6;
            this.btn_browse_target.Text = "Browse...";
            this.btn_browse_target.UseVisualStyleBackColor = true;
            this.btn_browse_target.Click += new System.EventHandler(this.btn_browse_target_Click);
            // 
            // btn_export
            // 
            this.btn_export.Enabled = false;
            this.btn_export.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export.Location = new System.Drawing.Point(13, 395);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(511, 64);
            this.btn_export.TabIndex = 7;
            this.btn_export.Text = "Export!";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // pb_progress
            // 
            this.pb_progress.Location = new System.Drawing.Point(13, 466);
            this.pb_progress.Name = "pb_progress";
            this.pb_progress.Size = new System.Drawing.Size(511, 33);
            this.pb_progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pb_progress.TabIndex = 8;
            // 
            // ofd_m3u
            // 
            this.ofd_m3u.FileName = "some.m3u";
            this.ofd_m3u.Filter = "m3u-Files|*.m3u";
            this.ofd_m3u.ShowHelp = true;
            // 
            // fbd_target
            // 
            this.fbd_target.Description = "Please Select the Target Folder to Export the mp3\'s to..";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 510);
            this.Controls.Add(this.pb_progress);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.btn_browse_target);
            this.Controls.Add(this.txt_target_folder);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lb_m3u_items);
            this.Controls.Add(this.btn_browse_m3u);
            this.Controls.Add(this.txt_m3uFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "m3uExporter";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_padding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_starting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_m3uFile;
        private System.Windows.Forms.Button btn_browse_m3u;
        private System.Windows.Forms.ListBox lb_m3u_items;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cb_padding_auto;
        private System.Windows.Forms.NumericUpDown nud_padding;
        private System.Windows.Forms.NumericUpDown nud_starting;
        private System.Windows.Forms.TextBox txt_target_folder;
        private System.Windows.Forms.Button btn_browse_target;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.ProgressBar pb_progress;
        private System.Windows.Forms.OpenFileDialog ofd_m3u;
        private System.Windows.Forms.FolderBrowserDialog fbd_target;
    }
}

