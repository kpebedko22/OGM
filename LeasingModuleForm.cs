using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OGM
{
    public partial class LeasingModuleForm : Form
    {
        public LeasingModuleForm()
        {
            InitializeComponent();

            dataGridView1[4, 0].Value = "Просмотреть";

        }


    }
}
