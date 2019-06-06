using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploMVCContador
{
    public partial class Form1 : Form
    {
        public event Action OnIncrementar;

        public Form1()
        {
            InitializeComponent();
        }

        private void IncrementarButton_Click(object sender, EventArgs e)
        {
            if (OnIncrementar != null)
              OnIncrementar();
        }

        public void SetTexto(string texto)
        {
            label.Text = texto;
        }
    }
}
