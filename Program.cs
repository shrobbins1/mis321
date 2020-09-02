using System;
using System.IO;
using System.Collections.Generic;

namespace PA1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Posts> baPosts = Files.GetPosts(); 
            //Menu
            Console.WriteLine("1. Show Posts \n 2. Add Post \n 3. Delete Post \n Exit");
            string userInput = Console.ReadLine();
            
            while (userInput != "4") 
            {
                if(userInput == "1")
                {
                    //Sorts by Date
                    baPosts.Sort();
                    //Show Posts 
                    Utils.PrintAllPosts(baPosts);

                }
                else if (userInput == "2")
                {
                    Posts.AddPost(baPosts); 

                }
                else if (userInput == "3")
                {
                    Posts.DeletePost( baPosts);
                    

                }
                Console.WriteLine("1. Show Posts \n 2. Add Post \n 3. Delete Post");

                userInput = Console.ReadLine();
            }

        }
    }
}
