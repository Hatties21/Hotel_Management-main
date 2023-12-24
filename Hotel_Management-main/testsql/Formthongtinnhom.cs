using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testsql
{
     public partial class Formthongtinnhom : Form
     {
          public Formthongtinnhom()
          {
               InitializeComponent();
          }
          private void BTDONG_Click_1(object sender, EventArgs e)
          {
               this.Close();
               Formmainmenu.instance.Show();
          }
     }
}
