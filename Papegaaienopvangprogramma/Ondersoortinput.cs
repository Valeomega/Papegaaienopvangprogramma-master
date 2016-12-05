using System;
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
    public partial class Ondersoortinput : Form
    {
        static REPO repolo = new REPO;
        public Ondersoortinput(REPO repo)
        {
            InitializeComponent();
            repolo = repo;
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonToevoegen_Click(object sender, EventArgs e)
        {
            Vogelondersoort vogelond = new Vogelondersoort;
            vogelond.Naam = textBox1.Text;
            repolo.vogelondersoorten.Add(vogelond);

        }
    }
}
