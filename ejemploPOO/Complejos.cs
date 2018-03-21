using System;
using System.Collections.Generic;
using System.Text;

namespace ejemploPOO
{
    public class Complejos
    {
        public int partR { get; set; }
        public int partI { get; set; }
       

        public Complejos(int partR, int partI)
        { 
        this.partR=partR;
        this.partI=partI;
        }


        /// <summary>
        /// nuevo
        /// </summary>
        /// <param name="sumando"></param>
        /// <returns></returns>
        public Complejos Suma(Complejos sumando)
        {
            var NPR = this.partR + sumando.partR;
            var NPI = this.partI + sumando.partI;

            Complejos devolucion= new Complejos(NPR,NPI);

            return (devolucion);
            
        }

        public Complejos Resta(Complejos restando)
       {
            var NPR = this.partR - restando.partR;
            var NPI= this.partI - restando.partI;

            Complejos devolucion=new Complejos(NPR,NPI);

            return (devolucion);

        }

        public Complejos Multiplicar(Complejos multiplicacion)
        {
            var N1 = this.partR * multiplicacion.partR;
            var N2 = this.partI * multiplicacion.partI;

            var N3 = this.partR * multiplicacion.partI;
            var N4 = this.partI * multiplicacion.partR;

            var NPR = N1 - N2;
            var NPI = N1 + N4;

            Complejos devolucion = new Complejos(NPR,NPI);

            return (devolucion);

        }

        public Complejos Division(Complejos dividir)
        {
            var N1 = this.partR * dividir.partR;
            var N2 = this.partI * dividir.partI;

            var N3 = dividir.partR ^ 2;
            var N4 = dividir.partI ^ 2;

            var N5 = dividir.partR * dividir.partI;
            var N6 = this.partR * dividir.partI;

            var NPR = (N1 + N2) / (N3 + N4);
            var NPI = (N5 - N6) / (N3 + N4);            

            Complejos devolucion = new Complejos(NPR, NPI);

            return (devolucion);

        }


    }
}
