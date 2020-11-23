using System.Threading.Tasks;

namespace ModernStore.Infra.Transactions
{
    public interface IUow
    {
        Task Commit()
        void Rollback();
    }
}
