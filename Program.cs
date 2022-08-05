using System;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //StopWatch stopWatch = new StopWatch();
            //stopWatch.Start();
            //Thread.Sleep(5000); // will sleep 3 sec
            //stopWatch.Stop();


            var post = new Class1("About Birds", "Herons");

            post.VoteUp();
            post.VoteUp();
            post.VoteDown();
            Console.WriteLine($"Title: {post.Title}");
            Console.WriteLine($"Description: {post.Description}");
            Console.WriteLine($"Votes: {post.GetVoteCount()}");



        }
    }
}
