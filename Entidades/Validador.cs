using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validador
    {
        public static bool EsValidaPasswordNumerica(string pass)
        {
            bool esValida = false;
            int largo = pass.Length;

            if (largo == 4)
            {
                esValida = true;
                for (int i = 0; i < largo; i++)
                {
                    if (!Char.IsDigit(pass[i]))
                    {
                        esValida = false;
                        break;
                    }
                }
            }         
            
            return esValida;
        }

        public static bool EsValidoNumeroPasaporte(string nroPasaporte)
        {
            bool esValido = false;
            //RNQ374034
            if (!string.IsNullOrEmpty(nroPasaporte))
            {
                esValido = true;

                for (int i = 0; i < nroPasaporte.Length; i++)
                {
                    if (i >= 0 && i < 3)
                    {
                        if (!Char.IsLetter(nroPasaporte[i]))
                        {
                            esValido = false;
                            break;
                        }
                    }
                    else if (!Char.IsDigit(nroPasaporte[i]))
                    {
                        esValido = false;
                        break;
                    }

                }
            }
            return esValido;
        }

        public static bool EsValidoDni(string dni)
        {
            bool esValido = false;

            if(!string.IsNullOrEmpty(dni))
            {
                esValido = true;

                for(int i = 0; i < dni.Length; i++)
                {
                    if (!Char.IsDigit(dni[i]))
                    {
                        esValido = false;
                        break;
                    }
                }
            }
            return esValido;
        }

        public static bool EsValidoNombre(string nombre)
        {
            bool esValida = false;

            if(!string.IsNullOrEmpty(nombre))
            {
                esValida = true;
                for (int i = 0; i < nombre.Length; i++)
                {
                    if (Char.IsDigit(nombre[i]))
                    {
                        esValida = false;
                    }
                }
            }         
            return esValida;
        }
    }
}
