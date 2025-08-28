using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    abstract public class Actividad
    {
        public int Periodo { get; set; }
        public string Descripcion { get; set; }
        protected List<Parcela> lotesAsignados=new List<Parcela>();
        abstract public double CalcularProduccion();
        abstract public double CalcularRendimiento();

        public Actividad(int periodo,string descripcion,Parcela p)
        {
            this.Periodo = periodo;
            this.Descripcion = descripcion;
        }
    }
}
