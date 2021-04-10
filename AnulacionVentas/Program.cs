using System;

namespace AnulacionVentas
{
    class Program
    {
        static void Main()
        {
            AnulacionVentas anulacionVentas = new AnulacionVentas();
            try
            {
                anulacionVentas.AnulacionVentasOfisis();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
