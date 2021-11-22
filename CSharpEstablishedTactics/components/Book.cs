﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEstablishedTactics.components
{
    internal class Book
    {
        public string Title { get; set; } = String.Empty;
        public int Price { get; set; }
        public int Pages { get; set; }

        internal static List<Book> Books() => new List<Book>()
            {
                new Book{Title = "こころ",Price = 400,Pages = 378},
                new Book{Title = "人間失格",Price = 281,Pages = 212},
                new Book{Title = "伊豆の踊り子",Price = 389,Pages = 201},
                new Book{Title = "若草物語",Price = 637,Pages = 464},
                new Book{Title = "銀河鉄道の夜",Price = 411,Pages = 276},
                new Book{Title = "二都物語",Price = 961,Pages = 666},
                new Book{Title = "遠野物語",Price = 514,Pages = 268},
            };
    }


}
