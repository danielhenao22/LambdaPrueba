using Platform.Modeler.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpLambda
{
    public partial class Form1 : Form
    {

        ClsPrueba prueba;

        public Form1()
        {
            InitializeComponent();
            prueba = new ClsPrueba();
        }

        private void jBCondWhere_Click(object sender, EventArgs e)
        {
            //prueba.condicionalWhere
        }
    }
}
