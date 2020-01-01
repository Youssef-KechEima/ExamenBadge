using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenBadge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.groupeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.badgeDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'badgeDataSet.Stagiaire'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
      //      this.stagiaireTableAdapter.Fill(this.badgeDataSet.Stagiaire);
            // TODO: cette ligne de code charge les données dans la table 'badgeDataSet.Groupe'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
       //     this.groupeTableAdapter.Fill(this.badgeDataSet.Groupe);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrystalBadge1 cb = new CrystalBadge1();
            cb.SetDataSource(badgeDataSet);
            cb.SetParameterValue("ch", Application.StartupPath);
            string filter = "{Groupe.IdGroupe} = "+(groupeComboBox.SelectedIndex+1);
            Imprimer i = new Imprimer(cb, filter);
            i.ShowDialog();
        }

        private void btnInvocation_Click(object sender, EventArgs e)
        {
            CrystalConvocation cc = new CrystalConvocation();
            cc.SetDataSource(badgeDataSet);
           cc.SetParameterValue("ch2", Application.StartupPath);
            string filter = "{Groupe.IdGroupe} = " + (groupeComboBox.SelectedIndex + 1);
            Imprimer i = new Imprimer(cc, filter);
            i.ShowDialog();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            
        }
    }
}
