using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace m3uExporter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cb_padding_auto_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_padding_auto.Checked)
            {
                nud_padding.Enabled = false;
            }
            else
            {
                nud_padding.Enabled = true;
            }
        }

        private void txt_m3uFile_TextChanged(object sender, EventArgs e)
        {
            List<string> files = readM3U(txt_m3uFile.Text);
            foreach (string f in files)
            {
                lb_m3u_items.Items.Add(f);
            }
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            copyMP3s(lb_m3u_items.Items, nud_starting.Value, cb_padding_auto.Checked, nud_padding.Value, txt_target_folder.Text, pb_progress);
        }

        private void btn_browse_target_Click(object sender, EventArgs e)
        {
            fbd_target.ShowDialog();
            txt_target_folder.Text = fbd_target.SelectedPath;
        }

        private void btn_browse_m3u_Click(object sender, EventArgs e)
        {
            ofd_m3u.ShowDialog();
            txt_m3uFile.Text = ofd_m3u.FileName;
        }

        private void txt_target_folder_TextChanged(object sender, EventArgs e)
        {
            if (lb_m3u_items.Items.Count > 0)
            {
                btn_export.Enabled = true;
            }
        }
        private List<string> readM3U(string m3ufile)
        {
            List<string> files = new List<string>();
            string m3upath = Path.GetDirectoryName(m3ufile);
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(m3ufile);
            while ((line = file.ReadLine()) != null)
            {
                if (line.StartsWith("#")) continue;
                if (line.Contains("http://")) continue;
                if (line.Contains(":\\")) files.Add(line);
                else
                {
                    files.Add(m3upath+"\\"+line);
                }
            }
            file.Close();
            return files;
        }
        private void copyMP3s(ListBox.ObjectCollection files, decimal starting_number, bool auto_pad, decimal padding, string target_folder, ProgressBar pb_progress)
        {
            if (auto_pad) padding = (decimal)Math.Floor(Math.Log10(files.Count) + 1);
            pb_progress.Maximum = files.Count;
            pb_progress.Step = 1;
            int now = (int)starting_number;
            foreach (var item in files)
            {
                string f = item as string;
                string f_name = Path.GetFileName(f);
                string new_name = target_folder + "\\" + now.ToString().PadLeft((int)padding, '0') + "_" + f_name;
                File.Copy(f, new_name);
                pb_progress.PerformStep();
                now++;
            }
            MessageBox.Show(files.Count + " Files have been copied.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pb_progress.Value = 0;
        }
    }
}
