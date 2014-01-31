using System.Collections.Generic;

namespace Battlemeister.RealmStatus
{
    public interface IRealmStatusApi
    {
        IEnumerable<RealmStatus> GetAll();
    }
}