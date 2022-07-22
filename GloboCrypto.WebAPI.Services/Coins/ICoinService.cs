using GloboCrypto.Models.Data;

namespace GloboCrypto.WebAPI.Services.Coins
{
    public interface ICoinService
    {
        Task<CoinInfo> GetCoinInfo(string coinId);
        Task<IEnumerable<CoinPriceInfo>> GetCoinPriceInfo(string coinIds, string currency, string intervals);
    }
}
