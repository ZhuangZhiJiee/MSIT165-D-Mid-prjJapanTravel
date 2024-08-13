﻿using slnJapanTravel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnJapanTravel.View.Blog
{
    public partial class Frmhashtagedit : Form
    {
        private Chashtag _ht = null;
        public DialogResult isOK { get; set; }

        public Chashtag ht
        {
            get
            {
                if (_ht == null)
                    _ht = new Chashtag();
                _ht.fHashtag = txtfName.Text;
                return _ht;
            }
            set
            {
                _ht = value;
                txtfName.Text = _ht.fHashtag.ToString();
                
            }
        }
        public Frmhashtagedit()
        {
            InitializeComponent();
        }

        private void btncancel(object sender, EventArgs e)
        {
            Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtfName.Text))            
            {
                MessageBox.Show("hashtag名稱必須輸入");
                return;
            }
            this.isOK = DialogResult.OK;
            Close();
        }
    }
}