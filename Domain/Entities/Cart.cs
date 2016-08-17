using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();

        //позволяет обратиться к содержимому корзины
        public IEnumerable<CartLine> Lines { get { return lineCollection; } } 

        //метод добавления элемента в корзину
        public void AddItem(Book book, int quantity)
        {
            CartLine line = lineCollection
                .Where(b => b.Book.BookId == book.BookId)
                .FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(new CartLine {Book = book, Quantity = quantity});
            }

            else
            {
                line.Quantity += quantity;
            }
        }

        //метод удаления элемента из корзины
        public void RemoveAll(Book book)
        {
            lineCollection.RemoveAll(l => l.Book.BookId == book.BookId);
        }

        //метод вычисления общей стоимости товаров
        public decimal ComputeTotalValue()
        {
            return lineCollection.Sum(e => e.Book.Price * e.Quantity);
        }

        //метод очистки корзины, путем удаления всех элементов
        public void Clear()
        {
            lineCollection.Clear();
        }
    }

    public class CartLine
    {
        public Book Book { get; set; }
        public int Quantity { get; set; }
    }
}
