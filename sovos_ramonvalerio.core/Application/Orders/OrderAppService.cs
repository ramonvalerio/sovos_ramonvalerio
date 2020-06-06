using sovos_ramonvalerio.core.Domain.Orders;
using sovos_ramonvalerio.core.Infrastructure;
using System;

namespace sovos_ramonvalerio.core.Application.Orders
{
    public class OrderAppService : IOrderAppService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ICustomerRepository _customerRepository;

        public OrderAppService(IOrderRepository orderRepository,
            ICustomerRepository customerRepository)
        {
            _orderRepository = orderRepository;
            _customerRepository = customerRepository;
        }

        public CustomerAndHisOrdersDTO Return_a_customer_and_his_orders(string email)
        {
            var customer = _customerRepository.GetByEmail(email);

            if (customer == null)
                throw new Exception("Email's Customer invalid or not exist.");

            var orders = _orderRepository.GetByCustomer(customer);

            var customerAndHisOrdersDTO = new CustomerAndHisOrdersDTO();
            customerAndHisOrdersDTO.Customer = customer;
            customerAndHisOrdersDTO.Orders = orders;

            return customerAndHisOrdersDTO;
        }

        public void Add_a_new_Order_and_Order_Item_for_an_existing_Customer(OrderCommand command)
        {
            var customer = _customerRepository.GetByEmail(command.CustomerEmail);
            var order = new Order(customer);

            _orderRepository.Add(order);
        }
    }
}