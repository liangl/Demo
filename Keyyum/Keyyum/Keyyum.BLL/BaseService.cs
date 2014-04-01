using Keyyum.IBLL;
using Keyyum.IDAL;

namespace Keyyum.BLL
{
    public abstract class BaseService<T>:InterfaceBaseService<T> where T:class 
    {
       // private IDAL.InterfaceUserRepository interfaceUserRepository;

        protected InterfaceBaseRepository<T> CurrentRepository { get; set; }

        public BaseService(InterfaceBaseRepository<T> currentRepository) { CurrentRepository = currentRepository; }

        //public BaseService(IDAL.InterfaceUserRepository interfaceUserRepository)
        //{
        //    // TODO: Complete member initialization
        //    this.interfaceUserRepository = interfaceUserRepository;
        //}
        public T Add(T entity)
        {
            return CurrentRepository.Add(entity);
        }

        public bool Update(T entity)
        {
            return CurrentRepository.Update(entity);
        }

        public bool Delete(T entity)
        {
           return  CurrentRepository.Delete(entity);
        }
    }
}
