﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Articles_2._0
{
    class Article
    {
        public Article(string title,  string content, string author)
        {
            this.Title = title;
            this.Author = author;
            this.Content = content;
        }

        public string Title { get; set; }
       
        public string Content { get; set; }

        public string Author { get; set; }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}