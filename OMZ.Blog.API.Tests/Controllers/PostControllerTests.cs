using Microsoft.VisualStudio.TestTools.UnitTesting;
using OMZ.Blog.API;
using OMZ.Blog.Entities;
using OMZ.Blog.Service.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;

namespace OMZ.Blog.API.Tests
{
  [TestClass()]
  public class PostControllerTests
  {
    [TestMethod()]
    public void GetTest()
    {
      Assert.Fail();
    }

    [TestMethod()]
    public void PostNewTest()
    {
      //var testProducts = GetTestProducts();
      var controller = new PostController();
      var post = GetNewPost();

      // Act  
      IHttpActionResult actionResult = controller.Post(post);
      var createdResult = actionResult as CreatedAtRouteNegotiatedContentResult<Post>;

      // Assert  
      Assert.IsNotNull(createdResult);
      Assert.AreEqual("DefaultApi", createdResult.RouteName);
      Assert.IsNotNull(createdResult.RouteValues["id"]);
    }

    [TestMethod()]
    public void PutTest()
    {
      Assert.Fail();
    }

    [TestMethod()]
    public void DeleteTest()
    {
      Assert.Fail();
    }

    // TODO extract methods to a factoryClass
    private Post GetNewPost()
    {
      return new Post
      {
        Title = "Hello World",
        ShortDescription = "Who i am?",
        Description = "My first post, to say who i am, what i do, my job, my hobbies and my life",
        PostedOn = DateTime.Now,
        Category = new Category
        {
          Name = "Travel",
          Description = "Use this category to posts about your trips around the world"
        },
        Tags = new [] { new Tag { Name = "FirstPost",  }, new Tag { Name = "beginning", } }
      };
    }

    private Post GetPostWithExistingCategory()
    {
      var context = new BlogDBContext();

      return new Post
      {
        Title = "Hello World",
        ShortDescription = "Who i am?",
        Description = "My first post, to say who i am, what i do, my job, my hobbies and my life",
        PostedOn = DateTime.Now,
        Category = new Category
        {
          Id = 1,
          Name = "Travel",
          Description = "Use this category to posts about your trips around the world"
        },
        Tags = new[] { new Tag { Name = "FirstPost", }, new Tag { Name = "beginning", } }
      };
    }
  }
}