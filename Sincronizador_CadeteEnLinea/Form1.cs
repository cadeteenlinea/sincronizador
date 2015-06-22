using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Sincronizador_CadeteEnLinea.Cadetes_Web;
using Sincronizador_CadeteEnLinea.Cadetes_Web_Local;
using Sincronizador_CadeteEnLinea.Class;


namespace Sincronizador_CadeteEnLinea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Cadetes_Web.CadeteControllerPortTypeClient cadete = new CadeteControllerPortTypeClient();
            Cadete cad = new Cadete(11111111, "asd", "asd", "asd", "asd", "asd", "asd", "asd", "asd", "asd", "asd", "asd", "asd", "asd", "asd", "asd", "Gringa", "asd", "asd", "asd");
            string json = JsonConvert.SerializeObject(cad);
            string result = cadete.save(json);*/

            
        }

        private void cadetesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SincronizadorCadetes sinCadete = new SincronizadorCadetes();
            sinCadete.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
