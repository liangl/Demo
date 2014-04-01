using System;
using System.Linq;
using System.Linq.Expressions;


namespace Keyyum.IDAL
{
    /// <summary>
    /// 接口基类
    /// <remarks >
    /// 创建：2014.03.17<br/>
    /// 修改：
    /// </remarks>
    /// </summary>
    /// <typeparam name="T">类型</typeparam>
    public interface InterfaceBaseRepository<T>
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entity">数据实体</param>
        /// <returns>添加后的数据实体</returns>
        T Add(T entity);

        /// <summary>
        /// 查询记录数
        /// </summary>
        /// <param name="predicate">条件表达式</param>
        /// <returns>记录数</returns>
        int Count(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="entity">数据实体</param>
        /// <returns>是否成功</returns>
        bool Update(T entity);

        bool Delete(T entity);

        bool Exist(Expression<Func<T,bool>> anyLambda);

        T Find(Expression<Func<T, bool>> whereLambda);

        IQueryable<T> FindList(Expression<Func<T, bool>> whereLamdba,string orderName, bool isAsc);

        IQueryable<T> FindPageList(int pageIndex, int pageSize, out int totalRecord, Expression<Func<T, bool>> whereLamdba,string orderName, bool isAsc);

    }
}
