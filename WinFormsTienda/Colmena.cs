using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WinFormsTienda
{
    public class Colmena
    {
        int id;
        string nomcompleto;
        string cuenta;
        string password;
        int monto;
        string modo;

        public Colmena(int id, string nomcompleto, string cuenta,  string password, int monto, string modo)
        {
            this.Id = id;
            this.Nomcompleto = nomcompleto; 
            this.Cuenta = cuenta;
            this.Password = password;
            this.Monto = monto;
            this.Modo = modo;
        }

        public int Id { get => id; set => id = value; }
        public string Nomcompleto { get => nomcompleto; set => nomcompleto = value; }
        public string Cuenta {  get => cuenta; set => cuenta = value; }
        public string Password { get => password; set => password = value; }
        public int Monto { get => monto; set => monto = value; }
        public string Modo { get => modo; set => modo = value; }


    }
}
