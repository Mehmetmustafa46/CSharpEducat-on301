using CSharpEducation301.DataAccessLayer.Abstract;
using CSharpEducation301.DataAccessLayer.Repositores;
using CSharpEducatıon301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEducation301.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal: GenericRepository<Category>, ICategoryDal
    {
    }
}
