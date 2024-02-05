using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R20A1_FranGV
{
    public class Cuenta
    {


        // MIEMBROS

        private string _titular;
        private double _cantidad;

        // CONSTRUCTORES

        public Cuenta(string titular)
        {
            Titular = titular;
            _cantidad = 0;
        }

        public Cuenta(string titular, double cantidad)
        {
            Titular = titular;
            _cantidad = cantidad;
        }

        // PROPIEDADES

        public string Titular
        {
            get 
            { 
                return _titular; 
            }
            set 
            { 
                _titular = value; 
            }
        }

        public double Cantidad
        {
            get
            {
                return _cantidad; // Solo lectura
            }
        }


        // METODOS

        public override string ToString()
        {
            string cadena = "";

            cadena = $"Titular: {Titular}\n";
            cadena += $"Cantidad: {Cantidad}\n";

            return cadena;
        }


    }
}
