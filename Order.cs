using System.Collections.Generic;
using Model;

namespace BusinessLogic
{
    public class MenuService
    {
        public double CalculateTotalPrice(List<Models> selectedItems)
        {
            double totalPrice = 0;

            foreach (var item in selectedItems)
            {
                totalPrice += item.prize;
            }

            return totalPrice;
        }
    }
}
