using System.IO;
using System;
using System.Collections.Generic;


namespace Resources.CSS
{

    public class Posts : IComparable<Posts> 
    {
        //void IComparable.CompareTo(Posts x, Posts y){}
        public int PostID { get; set; }
        public string PostMessage { get; set; }
        public DateTime PostTime { get; set; }
        public int Count { get; set; }

        public  int CompareTo(this Posts x)
        {
            
            return posts.PostID.CompareTo(x.PostID);
        }
        public static int CompareByID(Posts x, Posts y)
        {
            return x.PostID.CompareTo(y.PostID);

        }
        public static int CompareByDate(Posts x, Posts y)
        {
            return y.PostTime.CompareTo(x.PostTime);
        }


        public override string ToString()
        {
            return this.PostID + this.PostMessage + "\n   " + this.PostTime;
        }

        public string ToFile()
        {
            return PostID + "#" + PostMessage + "#" + PostTime;
        }

        public void AddPost()
        {
            List<Posts> baPosts = Files.GetPosts();
            SetCount(baPosts[baPosts.Count - 1].GetPostID());
            Count++;
            string stop = Console.ReadLine();
            while (stop != "-1")
            {
                int postId = GetCount();
                Console.WriteLine("post ID: " + postId);
                Console.WriteLine("Enter Message: ");
                string message = Console.ReadLine();
                Console.WriteLine("Enter timestamp of message:");
                DateTime postTime = Console.ReadLine();
                Posts newPost = new Posts(PostID = postId, PostMessage = message, PostTime = postTime);
                baPosts.Add(newPost);
                IncCount();
                Files.SavePosts(baPosts);
                Console.WriteLine("Enter -1 to stop");
                stop = Console.ReadLine();

            }

        }
        public static void DeletePost()
        {
            Console.WriteLine("Enter ID of Post to Delete: ");
            int deleteID = Console.ReadLine();
            List<Posts> baPosts = Files.GetPosts();
            int foundIndex = baPosts.FindIndex(tempPost => tempPost.PostID == deleteID);
            if (foundIndex != -1)
            {
                baPosts.RemoveAt(foundIndex);
            }

        }




    }


}