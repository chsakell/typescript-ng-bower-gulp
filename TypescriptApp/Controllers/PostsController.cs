using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TypescriptApp.App_Start;
using TypescriptApp.Models;

namespace TypescriptApp.Controllers
{
    public class PostsController : ApiController
    { 
        // GET api/posts
        public IHttpActionResult Get()
        {
            var posts = DataRepository.Posts;
            return Ok(posts);
        }

        // GET api/posts/5
        public IHttpActionResult Get(int id)
        {
            var post = DataRepository.Posts.FirstOrDefault(p => p.Id == id);

            if (post != null)
            {
                return Ok(post);
            }
            else
            {
                return NotFound();
            }
        }

        // POST api/posts
        public IHttpActionResult Post([FromBody]Post post)
        {
            var max = DataRepository.Posts.Max(p => p.Id);
            post.Id = max + 1;

            DataRepository.Posts.Add(post);
            return Ok(post);
        }

        // PUT api/posts/5
        public IHttpActionResult Put(int id, [FromBody]Post post)
        {
            Post _post = DataRepository.Posts.FirstOrDefault(p => p.Id == post.Id);

            if (_post != null)
            {
                for (int index = 0; index < DataRepository.Posts.Count; index++)
                {
                    if (DataRepository.Posts[index].Id == id)
                    {
                        DataRepository.Posts[index] = post;
                        return Ok();
                    }
                }
            }

            return NotFound();
        }

        // DELETE api/posts/5
        public IHttpActionResult Delete(int id)
        {
            if(DataRepository.Posts.Any(p => p.Id == id))
            {
                Post _post = DataRepository.Posts.First(p => p.Id == id);
                DataRepository.Posts.Remove(_post);

                return Ok();
            }

            return NotFound();
        }
    }
}
