using System;
using System.Collections.Generic;
namespace PA1
{
    public class Utils
    {
        public static void PrintAllPosts(List<Posts> baPosts)
        {
            foreach(Posts posts in baPosts)
            {
                Console.WriteLine(posts.ToString());
            }

        }
        
    }
}