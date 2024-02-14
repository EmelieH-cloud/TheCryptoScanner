using MyCryptoScanner.Data.DbConnection;
using MyCryptoScanner.Data.Models;

namespace MyCryptoScanner.Logic.Repositories
{
    public class CoinRepository : IRepositoryCoin
    {
        private readonly CoinDbContext _context;

        public CoinRepository(CoinDbContext context) // dependency injection av dbContext. 
        {
            _context = context;
        }

        public async Task AddCoin(CoinDbModel coin)
        {
            _context.Coins.Add(coin);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCoin(int id)
        {
            var coinToDelete = await _context.Coins.FindAsync(id);
            if (coinToDelete != null)
            {
                _context.Coins.Remove(coinToDelete);
                await _context.SaveChangesAsync();
            }
        }
    }
}
