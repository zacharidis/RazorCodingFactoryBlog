using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorCodingFactoryBlog.Data;
using RazorCodingFactoryBlog.Models.ViewModels;

namespace RazorCodingFactoryBlog.Pages.Admin.Blogs
{
    public class AddModel : PageModel
    {
        private readonly RCFBDbContext rCFBDbContext;

        [BindProperty]
        public AddBlogPost  AddBlogPostRequest { get; set; }

        // inject the constructor 

        public AddModel(RCFBDbContext rCFBDbContext)
        {
            this.rCFBDbContext = rCFBDbContext;
        }

        public void OnGet()
        {
        }


        public void OnPost()
        {

           




        }



    }
}
