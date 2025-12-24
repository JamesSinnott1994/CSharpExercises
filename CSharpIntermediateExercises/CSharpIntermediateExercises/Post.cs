using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediateExercises
{
    class Post
    {
        private string _title;
        private string _description;
        private DateTime _createdAt;

        private int _vote;
        public int Vote
        {
            get { return _vote; } // See current vote value
            set { _vote = value; }
        }

        public Post(string title, string description) {
            _title = title;
            _description = description;
            _createdAt = DateTime.Now;
            _vote = 0;
        }

        public void UpVote() {
            _vote += 1;
        }

        public void DownVote()
        {
            _vote -= 1;
        }

        public void Info() {
            Console.WriteLine("Title: {0}, Description: {1}, Created at: {2}, Vote: {3}", 
                _title, _description, _createdAt, _vote);
        }
    }
}
