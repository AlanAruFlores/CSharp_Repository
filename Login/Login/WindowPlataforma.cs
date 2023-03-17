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
    public partial class WindowPlataforma : Form
    {
        static Usuario user;
        static CoinWindow ventanaShop;
        public WindowPlataforma()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void setUser(Usuario usuario)
        {
            user = usuario;
        }
        private void btnCoins_Click(object sender, EventArgs e)
        {

            ventanaShop = new CoinWindow();
            ventanaShop.Show();
        }
    }
}
