using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OryzaTrackBLL;

namespace OryzaTrack
{
   
    public partial class FormPerawatanPadi : Form
    {
        private int IDAdmin;
        public FormPerawatanPadi(int idAdmin)
        {
            InitializeComponent();
            IDAdmin = idAdmin;
        }
    }
}
