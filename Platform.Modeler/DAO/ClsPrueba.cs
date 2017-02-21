
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Platform.Modeler.Entity;


namespace Platform.Modeler.DAO
{
    

    public class ClsPrueba
    {
        DataClasses1DataContext dbMapeo;

        public ClsPrueba()
        {
            dbMapeo = new DataClasses1DataContext();
        }

        public void condicionalWhere(String codigo)
        {
            var consulta =
                from x in dbMapeo.estudiante
                where x.codigo == codigo
                select x;

            //var consulta = dbMapeo.estudiante.Where(p => p.codigo == codigo);

            consulta.First();

            foreach (estudiante est in consulta)
            {
                Console.WriteLine(est.codigo + "" +
                    est.nombre + "" +
                    est.apellido + "" +
                    est.carrera + "" +
                    est.edad);
            }
        }
    }

}
