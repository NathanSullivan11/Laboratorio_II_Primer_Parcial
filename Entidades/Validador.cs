using System;

namespace Entidades
{
    public static class Validador
    {
        /// <summary>
        /// Valida password, respetando que tenga 4 dígitos únicamente
        /// </summary>
        /// <param name="pass"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Valida pasaporte, respetando el formato "AAA1234"
        /// </summary>
        /// <param name="nroPasaporte"></param>
        /// <returns></returns>
        public static bool EsValidoNumeroPasaporte(string nroPasaporte)
        {
            bool esValido = false;
            
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
                    else
                    {
                        if (!Char.IsDigit(nroPasaporte[i]))
                        {
                            esValido = false;
                            break;
                        }
                    }


                }
            }
            return esValido;
        }
        /// <summary>
        /// Valida dni, respetando que tenga solo dígitos
        /// </summary>
        /// <param name="dni"></param>
        /// <returns></returns>
        public static bool EsValidoDni(string dni)
        {
            bool esValido = false;

            if (!string.IsNullOrEmpty(dni))
            {
                esValido = true;

                for (int i = 0; i < dni.Length; i++)
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

        /// <summary>
        /// Valida nombre, respetando que tenga solo letras
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public static bool EsValidoNombre(string nombre)
        {
            bool esValida = false;

            if (!string.IsNullOrEmpty(nombre))
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
