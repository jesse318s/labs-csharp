﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JesseSites4D
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader(@"name.txt");

            while (!sr.EndOfStream)
            {
                lbxNames.Items.Add(sr.ReadLine());
            }
            sr.Close();
        }
    }
}
