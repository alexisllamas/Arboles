using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arboles
{
    public partial class Form1 : Form
    {
        Arbol arbol;
        public Form1()
        {
            InitializeComponent();
            arbol = new Arbol();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            arbol.agregar(new Nodo(20));
            arbol.agregar(new Nodo(15));
            arbol.agregar(new Nodo(14));
            arbol.agregar(new Nodo(10));
            arbol.agregar(new Nodo(18));
            arbol.agregar(new Nodo(16));
            arbol.agregar(new Nodo(19));
            arbol.agregar(new Nodo(25));
            arbol.agregar(new Nodo(23));
            arbol.agregar(new Nodo(22));
            arbol.agregar(new Nodo(24));
            arbol.agregar(new Nodo(27));
            arbol.agregar(new Nodo(26));
            arbol.agregar(new Nodo(30));
            arbol.agregar(new Nodo(50));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arbol.preOrder(), "Pre order");
            MessageBox.Show(arbol.inOrder(), "In order");
            MessageBox.Show(arbol.postOrder(), "Post order");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nodo hola = arbol.buscar(Convert.ToInt16(textBox1.Text));

            if (hola != null)
            {
                if (hola.hIzq != null && hola.hDer != null)
                    MessageBox.Show("Se encontró, su hijo izquierdo es " + hola.hIzq.ToString() + " y su hijo derecho es " + hola.hDer.ToString());
                else if (hola.hIzq == null && hola.hDer != null)
                    MessageBox.Show("Se encontró, no tiene hijo izquierdo y su hijo derecho es " + hola.hDer.ToString());
                else if (hola.hIzq != null && hola.hDer == null)
                    MessageBox.Show("Se encontró, no tiene hijo derecho y su hijo izquierdo es " + hola.hIzq.ToString());
                else
                    MessageBox.Show("Se encontró y es hoja");
                    
            }
            else
                MessageBox.Show("No se encontró");
        }
    }
}
