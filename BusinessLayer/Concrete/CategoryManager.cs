using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategorySevice
    {
        //GenericRepository<Category> repo = new GenericRepository<Category>();
        //CategoryRepository categoryRepository = new CategoryRepository();

        EfCategoryRepository efCategoryRepository;

        public CategoryManager()
        {
            efCategoryRepository = new EfCategoryRepository();

        }

        public void CategoryAdd(Category category)
        {
            //if (category.CategoryName != "" && category.CategoryDescription != "" && category.CategoryName.Length >= 5 && category.CategoryStatus == true)
            //{
            //    categoryRepository.AddCategory(category);
            //}
            //else
            //{
            //    //Fluent Validation Kullanılacak
            //}
            efCategoryRepository.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            //if (category.CategoryID!=0)
            //{
            //    repo.Delete(category);
            //}
            efCategoryRepository.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            efCategoryRepository.Update(category);
        }

        public Category GetByIDCategory(int id)
        {
            return efCategoryRepository.GetByID(id);
        }

        public List<Category> GetListCategory()
        {
            return efCategoryRepository.GetListAll();
        }
    }
}
