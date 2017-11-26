using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.AbmFactura
{
    public class Item
    {
        private Int64 numFact;
        private Decimal monto = 0;
        private Int16 cantidad = 0;

        public Item(Decimal monto, Int16 cantidad)
        {
            this.monto = monto;
            this.cantidad = cantidad;
        }

        public Decimal NumFact { get { return numFact; } set { this.numFact = Convert.ToInt64(value); } }
        public Decimal Monto { get { return monto; } set { this.monto = value; } }
        public Int32 Cantidad { get { return cantidad; } set { this.cantidad = Convert.ToInt16(value); } }
        public Decimal Importe { get { return monto * cantidad; } }


    }
}
