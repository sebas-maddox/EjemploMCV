using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public int GetSuma(int a, int b)
        {
            int suma = a+b;
            //return string.Format("You entered: {0}", value);
            return suma;
        }

        public int GetResta(int a, int b)
        {
            int resta = a - b;
            return resta;
        }

        public int GetMultiplicacion(int a, int b)
        {
            int multi = a * b;
            return multi;
        }

        public float GetDivision(int a, int b)
        {
            float divi = a / b;
            return divi;
        }


        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
