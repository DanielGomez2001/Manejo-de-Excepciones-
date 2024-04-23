using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejo_de_Excepciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int txt1, txt2,R;
            try
            {
                txt1 = int.Parse(txtbox1.Text);
                txt2 = int.Parse(txtbox2.Text);
                R = txt1 + txt2;
                MessageBox.Show("El resultado es " + R);
            }
            // EXCEPCIÓN GENERICA
            //catch (Exception Ex) {
            //    MessageBox.Show(Ex.ToString());
            //}
            // FIJO UN FORMATO
            catch (FormatException Ex)
            {
                MessageBox.Show("Solo se pueden ingresar Números");
            }
            // CREO OTRA EXCEPCIÓN
            catch (DivideByZeroException Ex)
            {
                MessageBox.Show("No se puede Dividir por Cero");
            }

          

        }
    }
}
