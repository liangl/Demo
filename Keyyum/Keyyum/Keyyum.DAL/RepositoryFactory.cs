using Keyyum.IDAL;

namespace Keyyum.DAL
{
    public static class RepositoryFactory
    {
        public static InterfaceUserRepository UserRepository { get { return new UserRepository(); } }
    }
}
