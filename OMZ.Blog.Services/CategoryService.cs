using OMZ.Blog.Entities;
using OMZ.Blog.Service.Repositories;
using System;

namespace OMZ.Blog.Services
{
  public class CategoryService
  {
    BlogDBContext context = new BlogDBContext();

    public void Create(Category category)
    {
      context.Categories.Add(category);
      context.SaveChanges();
    }
  }
}
