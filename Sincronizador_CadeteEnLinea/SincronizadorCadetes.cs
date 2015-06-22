using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sincronizador_CadeteEnLinea.Cadetes_Web;
using Sincronizador_CadeteEnLinea.Cadetes_Web_Local;
using Sincronizador_CadeteEnLinea.Class;
using System.Threading;
using Newtonsoft.Json;

namespace Sincronizador_CadeteEnLinea
{
    public partial class SincronizadorCadetes : Form
    {
        public SincronizadorCadetes()
        {
            InitializeComponent();
            
        }

        private void SincronizadorCadetes_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(WorkThreadFunction));
            thread.Start();
        }

        public void WorkThreadFunction() {
            Cadetes_Web_Local.CadeteControllerPortTypeClient cadete = new Cadetes_Web_Local.CadeteControllerPortTypeClient();
            List<Cadete> cadetesList = Cadete.cadetes();
            string json = JsonConvert.SerializeObject(cadetesList);
            string result = cadete.save(json);

            //MessageBox.Show(result);

            /*List<object> results = JsonConvert.DeserializeObject<List<object>>(result);

            foreach (object obj in results)
            {
                foreach (string o in (Array)obj)
                {

                }
            }*/
            MessageBox.Show(result);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
