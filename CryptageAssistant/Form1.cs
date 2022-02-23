using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CryptageAssistant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void eCRIVAINBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eCRIVAINBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.librairieDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'librairieDataSet.ECRIVAIN'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.eCRIVAINTableAdapter.Fill(this.librairieDataSet.ECRIVAIN);

        }
    }
}
