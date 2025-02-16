using CSharpEducation.BusinessLayer.Abstract;
using CSharpEducatıon301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEducation.BusinessLayer.Concrete
{

    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerService _customerDal;

        public CustomerManager(ICustomerService customerDal)
        {
            _customerDal = customerDal;
        }

        public void Delete(Customer entity)
        {
           _customerDal.Delete(entity);
        }

        public void TDelete(Customer entity)
        {
            _customerDal.TDelete(entity);
        }

        public List<Customer> TGetAll()
        {
           return _customerDal.TGetAll();
        }

        public Customer TGetById(int id)
        {
            return _customerDal.TGetById(id);
        }

        public void TInsert(Customer entity)
        {
           if(entity.CustomerName!="" && entity.CustomerName.Length>=3 && entity.CustomerCity !=null&&
                entity.CustomerSurname !=""&& entity.CustomerName.Length<=30)
            {
                _customerDal.TInsert(entity);
            }
            else
            {
                //hata mesajı var
            }
        }

        public void TUpdate(Customer entity)
        {
            if (entity.CustomerId != 0 && entity.CustomerCity.Length >=3)
            {
                _customerDal.TUpdate(entity);
            }
         else 
            {
                //hata mesajı
            }

        }
    }
}
