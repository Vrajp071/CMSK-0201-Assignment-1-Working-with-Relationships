using System;
using System.Collections.Generic;
using System.Linq;
using Vraj_P_Patel_3154641_Assignment_1;
using Microsoft.EntityFrameworkCore;

var dbcontext = new BloggingContext();

var user1 = new User
{
    Name = "User1",
    EmailAddress = "User1@example.com",
    PhoneNumber = "1234785996"
};

var user2 = new User
{
    Name = "User2",
    EmailAddress = "User2@example.com",
    PhoneNumber = "987564123"
};
dbcontext.Users.Add(user1);
dbcontext.Users.Add(user2);
dbcontext.SaveChanges();

var blogType = new BlogType
{
    Name = "Blog1",
    Description = "A blog Description"
};

var postType = new PostType
{
    Name = "Post Type Name",
    Description = "Post Type Description",
    Status = "Active"
};

dbcontext.BlogTypes.Add(blogType);
dbcontext.PostTypes.Add(postType);
dbcontext.SaveChanges();

var blog = new Blog
{
    Url = "http://example.com",
    IsPublic = true,
    BlogTypeId = blogType.BlogTypeId
};
dbcontext.Blogs.Add(blog);
dbcontext.SaveChanges();

List<User> users;
List<Blog> blogs;
List<PostType> postTypes;

users = dbcontext.Users.ToList();
var UserId = users.First().UserId;

blogs = dbcontext.Blogs.ToList();
var BlogId = blogs.First().BlogId;

postTypes = dbcontext.PostTypes.ToList();
var postTypeId = postTypes.First().PostTypeId;

var newPost = new Post
{
    Title = "New Post Title",
    Content = "This is the content of the new post",
    UserId = UserId,
    BlogId = BlogId,
    PostTypeId = postTypeId
};

dbcontext.Posts.Add(newPost);
dbcontext.SaveChanges();

List<Post> Posts;
Posts = dbcontext.Posts.ToList();

foreach (var p in Posts)
{
    Console.WriteLine($"ID : {p.PostId}, Title : {p.Title}, Content : {p.Content}, User Name : {p.User.Name}, Post Type Name : {p.PostType.Name}");
}
