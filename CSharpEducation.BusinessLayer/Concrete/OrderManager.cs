using CSharpEducation.BusinessLayer.Abstract;
using CSharpEducation301.DataAccessLayer.Abstract;
using CSharpEducatıon301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEducation.BusinessLayer.Concrete
{
    public class OrderManager : IOrderService
    {
        private readonly IOrderDal orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            this.orderDal = orderDal;
        }

        public void TDelete(Order entity)
        {
            orderDal.Delete(entity);
        }

        public List<Order> TGetAll()
        {
           return orderDal.GetAll();
        }

        public Order TGetById(int id)
        {
            return (orderDal.GetById(id));
        }

        public void TInsert(Order entity)
        {
           orderDal.Insert(entity);
        }

        public void TUpdate(Order entity)
        {
            orderDal.Update(entity);
        }
    }
}
