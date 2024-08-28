using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDSN2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbForma_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbForma.Text)
            {
                case "Circunferência":
                    ExibirRaio(true);
                    ExibirLado(false);
                    break;
                case "Quadrado":
                    ExibirRaio(false);
                    ExibirLado(true);
                    break;
                case "Triângulo":
                    ExibirRaio(true);
                    ExibirLado(false);
                    cmbTriangulo.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void ExibirLado(bool visivel)
        {
            lblLado.Visible = txtLado.Visible = visivel;
        }

        private void ExibirRaio(bool visivel)
        {
            lblRaio.Visible = txtRaio.Visible = visivel;
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            switch (cmbForma.Text)
            {
                case "Quadrado":
                    FormaGeometrica objeto;
                    objeto = new Quadrado() { Lado = Convert.ToDouble(txtLado.Text) };
                    cmbObjetos.Items.Add(objeto);
                    txtLado.Clear();
                    break;
                default:
                    break;
            }
        }

        private void cmbObjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormaGeometrica objeto = cmbObjetos.SelectedItem as FormaGeometrica;

            txtArea.Text = objeto.CalcularArea().ToString();
            txtPerimetro.Text = objeto.CalcularPerimetro().ToString();
        }
    }
}
