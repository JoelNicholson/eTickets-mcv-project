using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class ProducersService:IProducersService
    {
        private readonly AppDBContext _context;
        public ProducersService(AppDBContext context)
        {
            _context = context;
        }

        public void Add(Producer producer)
        {
            _context.Producers.Add(producer);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Producer>> GetAll()
        {
            var result = await _context.Producers.ToListAsync();
            return result;
        }

        public Producer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Producer Update(int id, Producer newProducer)
        {
            throw new NotImplementedException();
        }
    }
}
