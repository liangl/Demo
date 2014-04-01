using Keyyum.IBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyyum.BLL
{
    public abstract class BaseService<T>:InterfaceBaseService<T> where T:class 
    {
        private IDAL.InterfaceUserRepository interfaceUserRepository;

        protected InterfaceBaseService<T> CurrentRepository { get; set; }

        public BaseService(InterfaceBaseService<T> currentRepository) { CurrentRepository = currentRepository; }

        public BaseService(IDAL.InterfaceUserRepository interfaceUserRepository)
        {
            // TODO: Complete member initialization
            this.interfaceUserRepository = interfaceUserRepository;
        }
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
