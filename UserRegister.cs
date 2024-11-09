﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pts
{
    public partial class UserRegister : Form
    {
        public UserRegister()
        {
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserDashboard u=new UserDashboard();
            u.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserLogin u=new UserLogin();
            u.Show();
        }
    }
}