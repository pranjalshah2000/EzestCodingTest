

using EzestCodingTest.DAL.Repositories;
using Unity;

namespace EzestCodingTest.API.DI
{
    public static class InjectUnityOfWork
    {
        public static void InjectRepositories(ref UnityContainer container)
        {
            container.RegisterType<IUserRepository, UserRepository>();
        }
    }
}
