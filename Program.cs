using System;
using System.Collections.Generic;
namespace CSS
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
                    baPosts.Sort(posts.CompareByDate());
                    baPosts.Sort((x,y) >= y.PostTime.CompareTo(x.PostTime));
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
