using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dia_de_la_semana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EncontrarDia_Click(object sender, EventArgs e)
        {
            
            switch (Fecha.Value.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    MessageBox.Show("Es domingo");
                    break;
                case DayOfWeek.Monday:
                    MessageBox.Show("Es Lunes");
                    break;
                case DayOfWeek.Tuesday:
                    MessageBox.Show("Es Martes");
                    break;
                case DayOfWeek.Wednesday:
                    MessageBox.Show("Es Miercoles");
                    break;
                case DayOfWeek.Thursday:
                    MessageBox.Show("Es Jueves");
                    break;
                case DayOfWeek.Friday:
                    MessageBox.Show("Es viernes");
                    break;
                case DayOfWeek.Saturday:
                    MessageBox.Show("Es sabado");
                    break;
            }
        }
        
    }
}
