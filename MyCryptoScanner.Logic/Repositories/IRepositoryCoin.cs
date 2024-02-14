using MyCryptoScanner.Data.Models;

namespace MyCryptoScanner.Logic.Repositories
{
    public interface IRepositoryCoin
    {
        Task AddCoin(CoinDbModel pokemon);
        Task DeleteCoin(int id);
    }
}