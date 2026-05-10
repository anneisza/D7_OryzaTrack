using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OryzaTrack
{
    public partial class FormPenyakit : Form
    {
        private int IDAdmin;
        public FormPenyakit(int idAdmin)
        {
            InitializeComponent();
            IDAdmin = idAdmin;
        }

        private void FormPenyakit_Load(object sender, EventArgs e)
        {

        }
    }
}
