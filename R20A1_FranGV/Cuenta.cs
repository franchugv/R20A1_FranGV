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

            if (Cantidad > 0) 
            { 

                cadena = $"La cuenta del titular Titular: {Titular}\n";
                cadena += $"Cantidad: {Cantidad}\n";
            }

            else
            {
                cadena = $"La cuenta del Titular {Titular} no tiene saldo.";
            }
            return cadena;
        }


        // ESPECIALES SEGÚN LA PRACTICA

        public void Ingresar()
        {
            if (Cantidad < 0) throw new Exception("La cantidad no puede ser negativa");
        }

        public void Retirar()
        {
            if (Cantidad == 0) throw new Exception("Has sacado todo el dinero");
        }


    }
}
