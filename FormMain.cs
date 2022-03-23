using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Diccionario_Personal
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            
        }
        XmlDocument doc = new XmlDocument();

        private void bttnGuardar_Click(object sender, EventArgs e)
        {

            /*try
            {

            }
            catch
            {

            }*/
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
