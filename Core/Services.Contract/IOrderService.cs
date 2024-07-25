﻿using Core.Entities.Order.Aggregate;
using Core.Specifications.OrderSpeicifcations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Contract
{
    public interface IOrderService
    {
        Task<Order> CreateOrderAsync(string buyerEmail, List<OrderItem> orderItems, PaymentMethod paymentMethod, OrderStatus status);
        Task<IEnumerable<Order>> GetAllOrdersForUserAsync(string customerId);
        Task<IEnumerable<Order>> GetAllAsync();
        Task<IEnumerable<Order>> GetAllWithSpecAsync(OrderWithItemsSpeicifcations spec);
        Task<Order> GetByIdAsync(int id);
        Task<Order> GetWithSpecAsync(OrderWithItemsSpeicifcations spec);
        Task<Order> UpdateStatusAsync(int orderId, OrderStatus status);
    }
}
