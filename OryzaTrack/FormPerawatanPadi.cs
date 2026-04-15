using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OryzaTrackBLL;    

namespace OryzaTrack
{
    public partial class FormPerawatanPadi : Form
    {
        public FormPerawatanPadi(int idAdmin)
        {
            InitializeComponent();
            _idAdmin = idAdmin;
        }

        private void FormPerawatanPadi_Load(object sender, EventArgs e)
        {

        }
    }
}
