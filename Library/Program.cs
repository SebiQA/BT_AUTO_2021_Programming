using System;

namespace Library
{
    class Library
    {
        static void Main(string[] args)
        {
            Author A = new Author("Camil Petrescu", "camip@yahoo.com");
            Book B = new Book("The last night of love the first night of war", 1930, "Camil Petrescu", 50);
            B.PrintBook();

        }
    }
}
