using CSharpEducatıon301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEducation.BusinessLayer.Abstract
{
    public interface ICustomerService : IGenericService<Customer>
    {
        void Delete(Customer entity);
    }
}
