using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TobbbformosPizzaAlkalmazasTobbTabla.model;
using TobbbformosPizzaAlkalmazasTobbTabla.Model;

namespace TobbbformosPizzaAlkalmazasTobbTabla.Repository
{
    class RepositoryOrderItemsView
    {
        /// <summary>
        /// Rendelések tételeit tartalmazza a megjelenítéshez
        /// </summary>
        private List<OrderItemsView> roiv;
        /// <summary>
        /// A fizetendő összeg
        /// </summary>
        private int finalPrice;

        /// <summary>
        /// Konstruktor, amely a rendelés száma alapján feltölti a listát
        /// </summary>
        /// <param name="orderNumber">Rendelés azonosító</param>
        public RepositoryOrderItemsView(int orderNumber, List<Item> items, List<Pizza> pizzas)
        {
            List<Item> iviews = items.FindAll(i=> i.getOrderId() == orderNumber);
            finalPrice = 0;
            foreach (Item i in iviews)
            {
                Pizza pizza = pizzas.Find(p => p.getId() == i.getPizzaId());
                finalPrice = finalPrice + pizza.getPrice() * i.getPiece();
                OrderItemsView oiv = new OrderItemsView(
                    orderNumber,
                    i.getPiece(),
                    pizza.getNeme(),
                    pizza.getPrice()
                    );
                roiv.Add(oiv);
            } 
        }
        public int getFinalPrice()
        {
            return finalPrice;
        }
    }
}
