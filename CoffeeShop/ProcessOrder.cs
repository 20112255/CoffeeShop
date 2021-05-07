using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    class ProcessOrder
    {

        public delegate void ProcessOrderDelegate(orderOBJ o);

        public event ProcessOrderDelegate orderSubmitted;

        public void ProcessTheOrder(orderOBJ o)
        {

            PaymentService ps = new PaymentService();

            BaristaService bs = new BaristaService();

            DonuteerService ds = new DonuteerService();

            orderSubmitted += ps.collectCash;
            orderSubmitted += bs.makeCoffee;
            orderSubmitted += ds.packDonuts;

            OnOrderSubmitted(o);

            MessageBox.Show(o.Name + " you have ordered: \n" +
                o.Coffee + " Coffees \n" +
                o.Donuts + " Donuts");
        }

        protected virtual void OnOrderSubmitted(orderOBJ o)
        {
            if (orderSubmitted != null)
            {
                orderSubmitted(o);
            }
        }
    }
}
