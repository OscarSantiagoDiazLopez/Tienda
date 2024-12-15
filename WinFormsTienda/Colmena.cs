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
        //cuentas
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

         //productos
         int idP;
         string imagen;
         string descripcion;
         int precio;
         int existencias;

        public Colmena(int idp, string imagen,  string descripcion, int precio, int existencias)
        {
            this.IdP = idp;
            this.Imagen = imagen;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Existencias = existencias;
        }

        public int IdP { get => idP; set => idP = value; }
        public string Imagen { get => imagen; set => imagen = value; }  
        public string Descripcion { get => descripcion; set => descripcion = value; }   
        public int Precio { get => precio;  set => precio = value; }    
        public int Existencias { get => existencias;    set => existencias = value; }   
    }
    
}
