using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            string elemento = texteNombre.Text;
            lvElementos.Items.Add(elemento);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxColorFav.Items.Add("Rojo");
            comboBoxColorFav.Items.Add("Verde");
            comboBoxColorFav.Items.Add("Negro");
            comboBoxColorFav.Items.Add("Azul");
        }

        
        private void buttonVerPerfil_Click(object sender, EventArgs e)
        {
             string nombre = texteNombre.Text;
             DateTime fecha = dateTimePickerFechaNac.Value;
            //operador Ternario
            string chocolate = checkBoxChocolate.Checked == true ? "Le gusta el chocolate" : "No le gusta el chocolate";
            string tipo;
            if (radioButton2.Checked)
                tipo = "Muggle";
            else if (radioButton1.Checked)
                tipo = "Wizzard";
            else
                tipo = "Squibs";
            string colorFav = comboBoxColorFav.SelectedItem.ToString();
            string numeroFav = numericUpDown1.Value.ToString();

            string mensaje = chocolate + ", es: " + tipo + ", su color favorito es" + colorFav + ", su Nuemero Fav es: " + numeroFav;
            MessageBox.Show("Nombre: " + nombre + ", Fecha nacimiento: " + fecha + ", " + mensaje);


            


        }

        
    }
}
