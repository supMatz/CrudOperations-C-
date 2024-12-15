using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace CRUD
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            pnlButtons.Enabled = false;
            btRicerca.Enabled = false;
        }

        #region File
        private void btSalvaFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog(); //uso della finestra di dialogo salva file
            sfd.FileName = "Classifica_Struct.csv";
            sfd.Filter = "File di testo (*.csv)|*.txt|Tutti i file (*.*)|*.*";
            sfd.FilterIndex = 1;
            sfd.OverwritePrompt = true; //chiedo all'utente di sovrascrivere il file
            sfd.CheckFileExists = false;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Thread trd = new Thread(() => ScriviSuFile(sfd, Program.list));
                trd.Start();
            }
        }
        
        private void ScriviSuFile(SaveFileDialog sfd, List<Program.sStruct> list)
        {
            StreamWriter sw = new StreamWriter(sfd.FileName, false);

            //scrittura sul file
            for (int i = 0; i < list.Count; i++)
            {
                sw.WriteLine(list[i].Index.ToString() + ", " + list[i].Content);
            }

            sw.Close(); //chiusura del file obbligatoria
        }
        #endregion

        #region CRUD

        private void btModifica_Click(object sender, EventArgs e)
        {
            string item = LvStruct.SelectedItems[0].Text;
            int index = Convert.ToInt16(item);
            FrmStruct frmStruct = new FrmStruct(index);
            if (frmStruct.ShowDialog() == DialogResult.OK)
                AggiornaListView();
        }

        private void btInserisci_Click(object sender, EventArgs e)
        {
            FrmStruct frmStruct = new FrmStruct();
            if (frmStruct.ShowDialog() == DialogResult.OK)
                AggiornaListView();
        }

        private void btElimina_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = LvStruct.SelectedItems[0];
            string valueAsString = selectedItem.SubItems[0].Text;
            int index = Convert.ToInt16(valueAsString);
            Program.list.RemoveAt(index);
            AggiornaListView();
        }

        private void btRicerca_Click(object sender, EventArgs e)
        {
            string ContentToSearch = tbParolaDaCercare.Text;

            LvStruct.Items.Clear();

            foreach(Program.sStruct s in Program.list)
            {
                if (s.Content == ContentToSearch)
                    CreaListViewItem(LvStruct, s);
            }

        }

        #endregion

        #region Eventi Secondari Form

        /// <summary>
        /// Cambio di visibilità al pannello dei bottoni CRUD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LvStruct_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlButtons.Enabled = true;
        }

        private void tbParolaDaCercare_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbParolaDaCercare.Text))
                btRicerca.Enabled = false;
            else
                btRicerca.Enabled = true;
        }

        #endregion

        #region Subroutine

        private void AggiornaListView()
        {
            LvStruct.Items.Clear();

            foreach(Program.sStruct s in Program.list)
            {
                CreaListViewItem(LvStruct, s);
            }
        }

        private void CreaListViewItem(ListView lv, Program.sStruct s)
        {
            ListViewItem lvi = new ListViewItem(s.Index.ToString());
            lvi.SubItems.Add(s.Content);
            lv.Items.Add(lvi);
        }


        #endregion
    }
}
