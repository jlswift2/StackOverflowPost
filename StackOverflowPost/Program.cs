using System;
using System.Collections.Generic;

namespace StackOverflowPost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post = new Post("Title", "We are testing here.");
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();

            Console.WriteLine(post.Title);
            Console.WriteLine(post.Description);
            Console.WriteLine($"The total number of likes is {post.VoteCount}");
        }
    }
}
