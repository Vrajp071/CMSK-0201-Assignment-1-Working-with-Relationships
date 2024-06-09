using System;

namespace Vraj_P_Patel_3154641_Assignment_1
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }

        public int PostTypeId { get; set; }
        public PostType PostType { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
