using System.IO;
using System.Collections.Generic;
using System;
namespace Resources.CSS
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