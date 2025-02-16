using CSharpEducation301.DataAccessLayer.Abstract;
using CSharpEducatıon301.EntityLayer;
using CSharpEducatıon301.EntityLayer.Concrete;
using System.Collections.Generic;


namespace CSharpEducation.BusinessLayer.Concrete
{

    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        // Constructor, ICategoryDal arayüzü ile çalışacak şekilde düzeltildi
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void TDelete(Category entity)
        {
            _categoryDal.Delete(entity);
        }

        public List<Category> TGetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category TGetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public void TInsert(Category entity)
        {
            _categoryDal.Insert(entity);
        }

        public void TUpdate(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }

}
