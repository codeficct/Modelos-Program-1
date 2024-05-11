using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Modelos_Program_1
{
    public partial class Form1 : Form
    {
        classVector objVec1, objVec2, objVec3, objVec4;

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = objVec1.descargar();
        }

        private void cargarEleXEleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idx, cantidad;
            objVec1 = new classVector();
            cantidad = int.Parse(Interaction.InputBox("Ingrese la cantidad: "));
            for(idx = 1; idx <= cantidad; idx++)
            {
                objVec1.cargarElexEl(int.Parse(Interaction.InputBox("Ingrese el numero: " + idx)));
            }
        }

        private void pregunta1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objVec1.elemFrecuFibo(int.Parse(textBox1.Text), int.Parse(textBox2.Text), ref objVec2, ref objVec3);
            textBox5.Text = objVec2.descargar();
            textBox6.Text = objVec3.descargar();
        }

        private void cargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            objVec2.cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
        }

        private void cargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            objVec3.cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
        }

        private void descargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox5.Text = objVec2.descargar();
        }

        private void descargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox6.Text = objVec3.descargar();
        }

        private void cargarEleXEleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int idx, cantidad;
            objVec2 = new classVector();
            cantidad = int.Parse(Interaction.InputBox("Ingrese la cantidad: "));
            for (idx = 1; idx <= cantidad; idx++)
            {
                objVec2.cargarElexEl(int.Parse(Interaction.InputBox("Ingrese el numero: " + idx)));
            }
        }

        private void cargarEleXEleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int idx, cantidad;
            objVec3 = new classVector();
            cantidad = int.Parse(Interaction.InputBox("Ingrese la cantidad: "));
            for (idx = 1; idx <= cantidad; idx++)
            {
                objVec3.cargarElexEl(int.Parse(Interaction.InputBox("Ingrese el numero: " + idx)));
            }
        }

        private void pregunta2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objVec1.cargarSinRepetir(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            textBox4.Text = objVec1.descargar();
        }

        private void pregunta3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objVec1.elimPosiMultiplos(int.Parse(textBox1.Text));
            textBox5.Text = objVec1.descargar();
        }

        private void pregunta4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objVec1.segmentarRepetNoRepet();
            textBox5.Text = objVec1.descargar();
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objVec1.cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            objVec1 = new classVector();
            objVec2 = new classVector();
            objVec3 = new classVector();
            objVec4 = new classVector();
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
