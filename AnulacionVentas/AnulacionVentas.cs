using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnulacionVentas
{
    public class AnulacionVentas
    {
        public void AnulacionVentasOfisis()
        {
            try
            {
                InterfacesDBContext InterfacesDB = new InterfacesDBContext();
                //var param = new SqlParameter("@DocumentoIdentidad", UsuarioTrabajador.EmployeeNumber);
                //var result = new SqlParameter("@result", SqlDbType.Bit) { Direction = ParameterDirection.Output };
                InterfacesDB.Database.ExecuteSqlRaw($"exec USP_REGISTRA_ANULACIONES_VENTAS_OFISIS");
            }
            catch (Exception ex)
            {

                throw;
            }
              
        }
    }
}
