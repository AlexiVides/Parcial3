using CentralTaxisWF.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentralTaxisWF
{
    public partial class Central : Form
    {
        public Central()
        {
            InitializeComponent();
        }

        private void Taxis_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            using(centralTaxiEntities db = new centralTaxiEntities())
            {
                Taxis taxis = new Taxis();

                taxis.nombreTaxista = txtNombre.Text;
                taxis.matricula = txtMatricula.Text;
                taxis.numChasis = txtChasis.Text;
                taxis.numVIN = txtVIN.Text;

                db.Taxis.Add(taxis);
                db.SaveChanges();

                MessageBox.Show("Guardado con exito");


            }
        }
    }
}
