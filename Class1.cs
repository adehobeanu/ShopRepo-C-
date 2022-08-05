using System;
using System.Collections.Generic;
using System.Text;

namespace StopWatch
{
    class Class1
    {
        public string Title { get; set; }
        public string Description { get; set; }
        private DateTime _postTime;
        private int _voteCount;

        public Class1(string title, string description) 
        {
            this.Title = title;
            this.Description = description;
        }

        public void VoteUp()
        {
            _voteCount++;
        }
        public void VoteDown()
        {
            _voteCount--;

        }
        public int GetVoteCount()
        {
            return _voteCount;
        }
        public DateTime GetDateTime ()
        {
            return _postTime;
        }
  
  



    }
}
