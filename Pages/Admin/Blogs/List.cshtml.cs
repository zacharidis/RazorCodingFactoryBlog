using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorCodingFactoryBlog.Data;
using RazorCodingFactoryBlog.Models.Domain;

namespace RazorCodingFactoryBlog.Pages.Admin.Blogs
{
    public class ListModel : PageModel
    {
        private readonly RCFBDbContext rCFBDbContext;

        public List<BlogPost> BlogPosts { get; set; }

        public ListModel(RCFBDbContext rCFBDbContext)
        {
            this.rCFBDbContext = rCFBDbContext;
        }
        public void OnGet()
        {

           BlogPosts = rCFBDbContext.BlogPosts.ToList();



        }
    }
}
