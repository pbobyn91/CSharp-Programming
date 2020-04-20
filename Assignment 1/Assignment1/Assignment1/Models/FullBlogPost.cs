using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class FullBlogPost
    {
        public BlogPost blog { get; set; }

        public List<CommentView> commentView { get; set; }

        public User user { get; set; }
    }

    public class CommentView
    {
        public Comment comment { get; set; }

        public string authorName { get; set; }
        
        public string authorEmail { get; set; }
    }
}
