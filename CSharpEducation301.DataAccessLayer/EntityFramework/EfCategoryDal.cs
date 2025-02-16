using CSharpEducation301.DataAccessLayer.Abstract;
using CSharpEducation301.DataAccessLayer.Repositores;
using CSharpEducatıon301.EntityLayer.Concrete;
using CSharpEducation301.DataAccessLayer.EntityFramework;  // EfCategoryDal için
using CSharpEducation301.DataAccessLayer;  // ICategoryDal için


namespace CSharpEducation301.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal: GenericRepository<Category>, ICategoryDal
    {

    }
}
