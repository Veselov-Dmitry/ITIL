using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ITIL
{
    public partial class FormCon : Form
    {
        public FormCon()
        {
            InitializeComponent();
        }

        private void otmena_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void FormCon_Activated(object sender, EventArgs e)
        {
            label1.Text = "Ожидается запуск Search...\n\t Попытка подключения №"+ Work.connectTry.ToString();

        }
    }
}
