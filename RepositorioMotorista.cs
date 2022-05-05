using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMotorista
{
    public class RepositorioMotorista
    {
        public static List<Motorista> InicializadorMotorista()
        {
            List<Motorista> motoristas = new List<Motorista>();
            {
                motoristas.Add(new Motorista("João"));
                motoristas.Add(new Motorista("José"));
                motoristas.Add(new Motorista("Caio"));
                motoristas.Add(new Motorista("Ryan"));

                return motoristas;
            }
        }
    }
}
