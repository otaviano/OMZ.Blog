using OMZ.Blog.Entities;
using OMZ.Blog.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace OMZ.Blog.API
{
  public class PostController : ApiController
  {
    private PostService service = new PostService();

    // GET api/<controller>
    public IEnumerable<string> Get()
    {
      return new string[] { "value1", "value2" };
    }

    // GET api/<controller>/5
    public string Get(int id)
    {
      return "value";
    }

    // POST api/<controller>
    public IHttpActionResult Post([FromBody] Post post)
    {
      try
      {
        service.Create(post);

        return CreatedAtRoute("DefaultApi", new
        {
          id = post.Id
        }, post);
      }
      catch (System.Exception)
      {
        return BadRequest();
      }
    }

    // PUT api/<controller>/5
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE api/<controller>/5
    public void Delete(int id)
    {
    }
  }
}