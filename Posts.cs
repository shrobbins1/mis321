using System;
using System.IO;
using System.Collections.Generic;
namespace PA1
{
    public class Posts: IComparable<Posts>
    {
        public  int PostID { get; set; }
        public static int numPost{get; set;}
        public string PostMessage { get; set; }
        public DateTime PostTime { get; set; }
        public int Count { get; set; }
        public  int CompareByID(Posts temp)
        {
            return this.PostID.CompareTo(temp.PostID);

        }
        public int CompareByDate(Posts temp)
        {
            return this.PostTime.CompareTo(temp.PostTime);
        }


        public override string ToString()
        {
            return this.PostID + this.PostMessage + this.PostTime;
        }

        public string ToFile()
        {
            return PostID + "#" + PostMessage + "#" + PostTime;
        }

        public void AddPost( List<Posts> baPosts)
        {
            
            
            
                numPost ++;
                Console.WriteLine("post ID: " + numPost);
                Console.WriteLine("Enter Message: ");
                string message = Console.ReadLine();
                Console.WriteLine("Enter timestamp of message:");
                DateTime postTime = DateTime.Parse(Console.ReadLine());
                Posts newPost = new Posts{PostID = numPost, PostMessage = message, PostTime = postTime};
                baPosts.Add(newPost);
                
                
               

            

        }
        public static void DeletePost()
        {
            Console.WriteLine("Enter ID of Post to Delete: ");
            int deleteID = int.Parse(Console.ReadLine());
            List<Posts> baPosts = Files.GetPosts();
            int foundIndex = baPosts.FindIndex(tempPost => tempPost.PostID == deleteID);
            if (foundIndex != -1)
            {
                baPosts.RemoveAt(foundIndex);
            }

        }

    }
}