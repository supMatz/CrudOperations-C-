using System;
using System.Linq;
using System.Windows.Forms;

namespace CRUD
{
    public partial class FrmStruct : Form
    {
        //var globali
        bool IsModifica;
        int Num;

        #region Costruttori
        public FrmStruct(int index) //per modifiche
        {
            InitializeComponent();
            IsModifica = true;
            Num = index;
        }

        public FrmStruct() //per inserimenti
        {
            InitializeComponent();
            IsModifica = false;
        }
        #endregion

        private void btSalva_Click(object sender, EventArgs e)
        {
            string Content = tbContent.Text;
            AggiornamentoLista(Content, IsModifica);
        }

        private void AggiornamentoLista(string Content, bool IsModifica)
        {
            if(IsModifica)
            {
                var temp = Program.list[Num];
                temp.Content = Content;
                Program.list[Num] = temp;
            }
            else
            {
                Program.sStruct element = new Program.sStruct();
                element.Content = Content;
                Program.list.Add(element);
                element.Index = Program.list.Count();
            }
            
        }

        private void btAnnulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
