using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE24
{
    public partial class RepertoireRaces : Form
    {
        private DataSet ds;
        public RepertoireRaces()
        {
            InitializeComponent();
            try
            {
                
            }catch(Exception er) { MessageBox.Show(er.Message);}
        }

        private void RepertoireRaces_Load(object sender, EventArgs e)
        {

        }
    }
}
