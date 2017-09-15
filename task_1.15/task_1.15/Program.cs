using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1._15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<int> mylist = new List<int>();
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddFirst(6);
            linkedList.AddLast(4);
            mylist.Add(5);
            mylist.Add(10);

            Console.WriteLine(mylist.Count);
            Console.WriteLine();

            foreach (int i in mylist)
            {
                Console.WriteLine(i);
            }
            mylist.Remove(10);
            foreach (int i in mylist)
            {
                Console.WriteLine(i);
            }
            mylist.RemoveAt(0);
            foreach (int i in mylist)
            {
                Console.WriteLine(i);*/
            Console.ReadLine();
        }

            
      }
    class Book
    {
        /*variables: public, protected, private.
         * constructors;
         * methods.*/
        protected string _author;
        protected string _title;
        protected int _pagecount;

        public Book()
        {
            _author = "unknown";
            _title = "unknown";
            _pagecount = 0;
        }
        public Book(string author, string title)
        {
            _author = author;
            _title = title;
        }
        public Book(string author, string title, int pagecount)
        {
            _author = author;
            _title = title;
            _pagecount = pagecount;
        }

        public string author
        {
            get
            {
                return _author;
            }
        }
        public string title
        {
            get
            {
                return _title;
            }
        }
        public int pagecount
        {
            get
            {
                return _pagecount;
            }
        }


        public void Print()
        {
            Console.Write("{0}, {1}, {2}", author, title, pagecount);
        }

    }
    class TechnicalBook : Book
    {
        private string _sciencearea;

        public TechnicalBook() :base()
        {
            _sciencearea = "unknownscience";
        }
        public TechnicalBook(string sciencearea) :base ()
        {
            _sciencearea = sciencearea;
        }
        
        public TechnicalBook(string sciencearea, string author, string title) : base(author, title)
        {
            _sciencearea = sciencearea;
        }
        public TechnicalBook(string sciencearea, string author, string title, int pagecount) : base(author, title, pagecount)
        {
            _sciencearea = sciencearea;
        }

        public string sciencearea
        {
            get
            {
                return _sciencearea;
            }
        }
        public void Print()
        {
            Console.Write("{0}, {1}, {2}, {3}", author, title, pagecount, sciencearea);
        }
    }
    class Fiction : Book
    {

    }
    class Library
    {
        private List<Book> mylist = new List<Book>();
        public void Addbook(Book b)
        {
            mylist.Add(b);
        }
        public void PrintAll()
        {
            foreach(Book b in mylist)
            {
                Console.WriteLine(b);
            }
        }
        public void PrintTechnical()
        {
            foreach (Book b in mylist)
            {
                if (b.GetType().Name.Equals("Technicalbook"))
                {
                    Console.WriteLine("Book is" + b);
                }
            }
        }
        public void PrintFiction()
        {
            foreach (Book b in mylist)
            {
                if (b.GetType().Name.Equals("Fiction"))
                {
                    Console.WriteLine("Book is" + b);
                }
            }
        }

    }
}
   
    

