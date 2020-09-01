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
             //menu
            Console.WriteLine("1. Show Posts \n 2. Add Post \n Delete Post");
            string userInput = Console.ReadLine();
            
            while (userInput != "4") 
            {
                if(userInput == "1")
                {
                    //Show Posts
                    baPosts.Sort(baPosts.CompareByDate);
                    utils.PrintAllPosts(baPosts);

                }
                else if (userInput == "2")
                {
                    AddPost(); 

                }
                else if (userInput == "3")
                {
                    DeletePost();
                    

                }

                userInput = Console.ReadLine();
            }

        }
    }
}
