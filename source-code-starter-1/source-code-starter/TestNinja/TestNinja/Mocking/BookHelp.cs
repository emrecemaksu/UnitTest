using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Mocking
{
    public interface IBookHelp
    {
        IQueryable<Booking> Query<T>();
    }

    class BookHelp : IBookHelp
    {
        public IQueryable<Booking> Query<T>()
        {
            return new List<Booking>().AsQueryable();
        }
    }
}
