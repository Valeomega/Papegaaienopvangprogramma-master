﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using papegaaiencostumclasses;

namespace Papegaaienopvangprogramma
{
    public partial class Hoofdsoorttoevoegen : Form
    {
       static REPO repoload = new REPO();
        public Hoofdsoorttoevoegen(REPO repo)
        {
            InitializeComponent();
            repoload = repo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ondersoortinput form = new Ondersoortinput(repoload);
            form.Show();
        }
    }
}
