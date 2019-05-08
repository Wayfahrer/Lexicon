﻿namespace Lexicon.Models.Database
{
    using Lexicon.Models.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Quiz : IQuiz
    {
        private IDictionary<string, string> data;

        public Quiz()
        {
            this.data = new Dictionary<string, string>();

            this.data.Add("What is your name?", "");
            this.data.Add("What is your quest?", "");
            this.data.Add("What is your favorite color", "");
            this.data.Add("What is your favorite movie?", "");
            this.data.Add("What is your favorite song?", "");
            this.data.Add("What is your dream destination?", "");
            this.data.Add("What would you grab if your house was on fire?", "");
            this.data.Add("Which three items would you take on a desert island?", "");
            this.data.Add("What is the best piece of advice someone has given you?", "");
            this.data.Add("Do you like this quiz?", "");
            this.data.Add("What do you think about the author?", "");
        }

        public IDictionary<string, string> Data { get => data; set => data = value; }
    }
}
