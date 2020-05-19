using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peti_šesti_i_sedmi_zadatci
{
    class Program
    {
        static void Main(string[] args)
        {
            //Peti zadatak
            Book book = new Book("1984", 149.99);
            VHS vhs = new VHS("2001: A Space Odyssey", 69.99);
            BuyVisitor buyVisitor = new BuyVisitor();
            Console.WriteLine("Ispis metode Accept() za knjigu: " + book.Accept(buyVisitor));
            Console.WriteLine("Ispis metode Accept() za VHS: " + vhs.Accept(buyVisitor));

            //Šesti zadatak
            RentVisitor rentVisitor = new RentVisitor();
            DVD movieDVD = new DVD("Iron man", DVDType.MOVIE, 80);
            DVD softwareDVD = new DVD("Visual Studio 2021", DVDType.SOFTWARE, 300);
            Console.WriteLine("Ispis metode Accept() za film: " + movieDVD.Accept(rentVisitor));
            Console.WriteLine("Ispis metode Accept() za programsku podršku: " + softwareDVD.Accept(rentVisitor));

            //Sedmi zadatak
            Cart cart = new Cart();
            cart.AddItem(book);
            cart.AddItem(vhs);
            cart.AddItem(movieDVD);
            cart.AddItem(softwareDVD);
            Console.WriteLine("Ukupna cijena iznajmljivanja svih artikala: " + cart.Accept(rentVisitor));
        }
    }
}
