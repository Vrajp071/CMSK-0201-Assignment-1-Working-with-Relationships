using System;

namespace Vraj_P_Patel_3154641_Assignment_1
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
        public bool IsPublic { get; set; }

        public int BlogTypeId { get; set; }
        public BlogType BlogType { get; set; }
    }
}
