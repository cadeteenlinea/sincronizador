using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Odbc;

namespace Sincronizador_CadeteEnLinea.Class
{
    class Cadete
    {
        public int rut;
        public string nCadete;
        public string apellidoPaterno;
        public string apellidoMaterno;
        public string nombres;
        public string direccion;
        public string comuna;
        public string ciudad;
        public string region;
        public string curso;
        public string especialidad;
        public string division;
        public string anoIngreso;
        public string anoNacimiento;
        public string mesNacimiento;
        public string diaNacimiento;
        public string lugarNacimiento;
        public string nacionalidad;
        public string seleccion;
        public string nivel;
        public string circulo;

        public Cadete(int rut, string nCadete, string apellidoPaterno, string apellidoMaterno, string nombres, 
            string direccion, string comuna, string ciudad, string region,
            string curso,string especialidad, string division, string anoIngreso, string anoNacimiento, string mesNacimiento, 
            string diaNacimiento, string lugarNacimiento, string nacionalidad, string seleccion, 
            string nivel, string circulo)
        {
            this.rut = rut;
            this.nCadete = nCadete;
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno;
            this.nombres = nombres;
            this.direccion = direccion;
            this.comuna = comuna;
            this.ciudad = ciudad;
            this.region = region;
            this.curso = curso;
            this.especialidad = especialidad;
            this.division = division;
            this.anoIngreso = anoIngreso;
            this.anoNacimiento = anoNacimiento;
            this.mesNacimiento = mesNacimiento;
            this.diaNacimiento = diaNacimiento;
            this.lugarNacimiento = lugarNacimiento;
            this.nacionalidad = nacionalidad;
            this.seleccion = seleccion;
            this.nivel = nivel;
            this.circulo = circulo;
        }

        public static List<Cadete> cadetes()
        {
            List<Cadete> cadetesList = new List<Cadete>();
            Conexion conexion = new Conexion();
            conexion.connect();
            OdbcDataReader cadetes = conexion.execute("select * from cadetes");
            

            while (cadetes.Read())
            {
                int rut = cadetes.GetInt32(1);
                String nCadete = Convert.ToString(cadetes.GetDecimal(0));
                String apellidoPaterno = cadetes.GetString(4);
                String apellidoMaterno = cadetes.GetString(5);
                String nombres = cadetes.GetString(6);
                String anoNac = Convert.ToString(cadetes.GetDecimal(7));
                String mes = Convert.ToString(cadetes.GetDecimal(8));
                String dia = Convert.ToString(cadetes.GetDecimal(9));

                String curso = cadetes.GetString(13) + cadetes.GetString(14);

                String division = String.Empty;
                if (!cadetes.IsDBNull(12))
                {
                    division = Convert.ToString(cadetes.GetString(12));
                    if (division.Length == 2) {
                        division = Convert.ToInt32(division).ToString();
                    }
                }
                
                
                String anoIngreso = Convert.ToString(cadetes.GetDecimal(3));

                String lugarNacimiento = String.Empty;
                if(!cadetes.IsDBNull(10))
                    lugarNacimiento = cadetes.GetString(10);


                String seleccion = String.Empty;
                if(!cadetes.IsDBNull(23))
                    seleccion = cadetes.GetString(23);
                
                String nivel = String.Empty;
                if (!cadetes.IsDBNull(24))
                    nivel = cadetes.GetString(24);

                String especialidad = String.Empty;
                if (!cadetes.IsDBNull(11))
                    especialidad = cadetes.GetString(11);

                cadetesList.Add(new Cadete(rut, nCadete,
                    apellidoPaterno, apellidoMaterno, nombres,
                    "", "", "", "", curso, especialidad,
                    division, anoIngreso, anoNac,
                    mes, dia, lugarNacimiento, "Chilena",
                    seleccion, nivel, ""));
            }
            conexion.disconnect();

            return cadetesList;
        }


        /*public Cadete[] getCadetesXml()
        {
            Cadete[] cadetes = new Cadete[]{
            
            };
            return cadetes;
        }*/

    }
}
