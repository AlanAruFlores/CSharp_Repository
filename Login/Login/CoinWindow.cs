using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class CoinWindow : Form
    {
        static Usuario usuario;
        public CoinWindow()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            const int MONEY = 40;
            ControllerUser controlador = new ControllerUser();
            controlador.insertCoin(new Usuario(usuario.Id, MONEY));
           

        }
    }
}
