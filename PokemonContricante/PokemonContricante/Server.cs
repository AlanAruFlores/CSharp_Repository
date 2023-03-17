using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace PokemonContricante
{
    class Server
    {
        Socket socketServer;
        Socket socketCliente;
        Trainer trainer;
        Pokemon pokemonCharmander=new Charmander();


        public Server()
        {
            getConnection();
            this.trainer = new Trainer();
            receivePokemon();
        }

        public void getConnection()
        {
            this.socketServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint address = new IPEndPoint(IPAddress.Any, 4044);
            try
            {
                this.socketServer.Bind(address);
                this.socketServer.Listen(1);
                this.socketCliente = socketServer.Accept();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void receivePokemon()
        {
            byte[] arraySprite = new byte[255];
            int cantBytes = socketCliente.Receive(arraySprite,0,arraySprite.Length,0);
            Array.Resize(ref arraySprite, cantBytes);
            string urlSpritePokemon = Encoding.Default.GetString(arraySprite);
            Form1.sprite = urlSpritePokemon;
        }

        public void attackEnemy()
        {
            string attackMessage = "" + pokemonCharmander.doAttack();
            byte[] aBytesTrainer = Encoding.Default.GetBytes(attackMessage);
            socketCliente.Send(aBytesTrainer);

        }

        public void receiveAttack()
        {
            byte[] aBytes = new byte[255];
            int cantBytes = socketCliente.Receive(aBytes, 0, aBytes.Length, 0);
            Array.Resize(ref aBytes, cantBytes);

            string messageReceive = Encoding.Default.GetString(aBytes);
            int attackReceive = int.Parse(messageReceive);
            pokemonCharmander.receiveAttack(attackReceive);
            MessageBox.Show("Vida Restante del charmander: " + pokemonCharmander.CantVida);
        }

        public void closeConnection()
        {
            socketCliente.Close();
            socketServer.Close();
        }


        public Pokemon pokemon
        {
            get => this.pokemonCharmander;
            set => this.pokemonCharmander = value;
        }
    }
}
