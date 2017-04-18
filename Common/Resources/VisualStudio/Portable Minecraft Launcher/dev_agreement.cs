﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portable_Minecraft_Launcher
{
    public partial class dev_agreement : Form
    {
        public dev_agreement()
        {
            InitializeComponent();
        }

        private void btn_disagree_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_agree_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.dev_agree = "1";
            Properties.Settings.Default.Save();
            Form fm = new Main();
            fm.Show();
            this.Hide();
        }

        private void dev_agreement_Load(object sender, EventArgs e)
        {
            txt_agreement.SelectAll();
            txt_agreement.SelectionAlignment = HorizontalAlignment.Center;
            lbl_ver.Text = "You're using version: " + Application.ProductVersion;
        }
    }
}