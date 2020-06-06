using System.Collections.Generic;

namespace sovos_ramonvalerio.core.Application.Orders
{
    public interface IOrderAppService
    {
        CustomerAndHisOrdersDTO Return_a_customer_and_his_orders(string email);
        void Add_a_new_Order_and_Order_Item_for_an_existing_Customer(OrderCommand command);
    }
}