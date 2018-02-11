using OMZ.Blog.Entities;
using OMZ.Blog.Service.Repositories;

namespace OMZ.Blog.Services
{
  public class TagService
  {
    BlogDBContext context = new BlogDBContext();

    public void Create(Tag tag)
    {
      context.Tags.Add(tag);
      context.SaveChanges();
    }
  }
}
