using System;

namespace PII_Game_Of_Life
{
    class Program
    {
        void Main(string[] args)
        {
            string urlArchivo = "";
            primerTablero = Generador.LeerArchivo(urlArchivo);
            tablero = new Tablero();
            tablero.ImprimirTablero(bool[,] primerTablero);
        }
    }
}
