using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Estancia estancia = new Estancia("La ana", "AB12",3000.0);
            estancia.Casco.Administrador = "Jorge";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            estancia.AgregarCampo("AC12", 234);
        }
    }
}
