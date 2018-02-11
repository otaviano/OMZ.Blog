using OMZ.Blog.Entities;
using OMZ.Blog.Service.Repositories;
using System;

namespace OMZ.Blog.Services
{
  public class PostService
  {
    BlogDBContext context = new BlogDBContext();

    public void Create(Post post)
    {
      context.Posts.Add(post);
      context.SaveChanges();
    }
  }
}