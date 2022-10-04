using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorCodingFactoryBlog.Data;
using RazorCodingFactoryBlog.Models.Domain;
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


        public IActionResult OnPost()
        {

            var blogPost = new BlogPost()
            {
                Heading = AddBlogPostRequest.Heading,
                PageTitle = AddBlogPostRequest.PageTitle,
                Content = AddBlogPostRequest.Content,
                ShortDescription = AddBlogPostRequest.ShortDescription,
                FeaturedImageUrl = AddBlogPostRequest.FeaturedImageUrl,
                UrlHandle = AddBlogPostRequest.UrlHandle,
                PulishDate = AddBlogPostRequest.PulishDate,
                Author = AddBlogPostRequest.Author,
                Visible = AddBlogPostRequest.Visible
            };

            rCFBDbContext.BlogPosts.Add(blogPost);
            rCFBDbContext.SaveChanges();

            return RedirectToPage("/admin/blogs/list");



        }



    }
}
