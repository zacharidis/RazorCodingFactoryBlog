using Microsoft.AspNetCore.Components.Web;

namespace RazorCodingFactoryBlog.Models.Domain
{
    public class BlogPost
    {// all non nullable
        public Guid Id { get; set; }    
        public string Heading { get; set; }

        public  string PageTitle { get; set; }

        public string Content   { get; set; }
        public string ShortDescription { get; set; }    

        public string FeaturedImageUrl { get; set; }

        public string UrlHandle { get; set; }

        public DateTime PulishDate { get; set; }

        public string Author { get; set; }  

        public bool Visible { get; set; }


    }
}
