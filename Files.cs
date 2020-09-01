using System;
using System.IO;
using System.Collections.Generic;


namespace Resources.CSS
{
    public class Files
    {
        public static List <Posts> GetPosts()
        {
            List<Posts> baPosts = new List<Posts>();

             //Read File
            StreamReader inFile = new StreamReader("posts.txt");
            string line =inFile.ReadLine();
            try 
            {
                inFile = new StreamReader("post.txt");
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine("Something went wrong...Returning blank list{0}",e );
                 

            }
             
            while(line != null)
             {
                string[] temp= line.Split("#");
                 int PostID =int.Parse(temp[0]);
                
                baPosts.Add(new posts {PostID = PostID, PostMessage = temp[1], PostTime = DateTime.Parse(temp[2])});
               

                line=inFile.ReadLine();


             }
             inFile.Close();

             return baPosts;
        
        }
        public static List<Posts> SavePosts(List<Posts> baPosts)
        {
            StreamWriter outPostFile= new StreamWriter("posts.txt", true);
            foreach(var post in baPosts)
            {
                outPostFile.WriteLine(post.ToFile());
            }
            outPostFile.Close();
            return baPosts;
        }
    }

}