using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal:IGenericDal<Blog>
    {
        //Kategorilerin hepsini getir
        //List<Blog> ListAllBlog();
        //void AddBlog(Blog blog);
        //void DeleteBlog(Blog blog);
        //void UpdateBlog(Blog blog);
        //Blog GetByID(int id);
    }
}
