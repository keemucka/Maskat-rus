using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Максат_Рус.Models;

namespace Максат_Рус
{
    public class MethodClass
    {
        public void CreateOrder(Order order)// Создание заказа
        {
            ApplicationContext context = new ApplicationContext();
            context.Orders.Add(order);
            context.SaveChanges();
        }
        public void AddProduct(User user, Order order, Product product) // Добавление товара в заказ
        {
            ApplicationContext context = new ApplicationContext();
            Order order_current = null;
            // Находим заказы пользователя, которые еще не были отправлены
            var query = context.Users.FirstOrDefault(x => x.Id_User == user.Id_User).Order_User.order.Where(x => x.Date >= DateTime.Today);
            if (query.Count() != 0)
            {
                order_current = query.First();// Берем первый заказ
            }
            else
            {
                order_current = new Order() {
                Id_Order = context.Orders.Last().Id_Order + 1,
                Date = DateTime.Today// Зависит от условия задачи
                };                
                
            }
            Order_Filling order_Filling = new Order_Filling()
            {
                Order_Id = order_current.Id_Order,
                Product_Id = product.Id_Product
            };
            context.SaveChanges();
        }
    }
}
