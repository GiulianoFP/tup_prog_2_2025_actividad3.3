using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Estancia
    {
        public string Nombre { get; set; }  
        public Casco Casco { get; set; }
        ArrayList puestos=new ArrayList();

        ArrayList campos = new ArrayList();


        public Estancia(string nombre,string idCampo,double sup)
        {
            this.Nombre = nombre;
            this.Casco = new Casco();
            this.Casco.Administrador = "Sin asignar";

            //Una Forma de hacerlo

            //Puesto puesto = new Puesto();
            //puestos.Add(puesto);
            //puesto.Responsable = "Sin asignar";

            //Otra Forma, casteando

            puestos.Add(new Puesto());
            ((Puesto)puestos[0]).Responsable = "Sin asignar";

            Campo campo=new Campo(idCampo, sup);

        }


        ArrayList campo=new ArrayList();
        public Campo AgregarCampos(string Identificador,double sup)
        {
            Campo nuevo=new Campo(Identificador, sup);
            campos.Add(nuevo);
            return nuevo;
        }
        public Campo VerCampo(int idx)
        {
            if(campos !=null && idx >=0 && idx < campos.Count)

            {
                //otra manera de castear "campos[idx] as Campo"
                return campos[idx] as Campo;
            }
            return null;
        }

        public int VerCantidadCampos()
        {
            if (campos != null)
            {
                return campos.Count;
            }
             return 0;
        }

    }
}
