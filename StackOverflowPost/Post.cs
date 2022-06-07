using System;

namespace StackOverflowPost
{
    public class Post
    {
        //Properties
        public string Title { get; private set; }
        public string Description { get; private set; }
        private DateTime _created;
        private int _count;
        public int VoteCount
        { 
            get { return _count; }
        }

        //constructors 
        public Post(string title, string description)
        {
            Title = title;
            Description = description;
            _created = DateTime.Now;
        }


        // methods

        public void UpVote()
        {
            _count++;
        }

        public void DownVote()
        {
            _count--;
        }
    }
}
