using System.Linq;
using Sunflower.Core;
using Sunflower.Demo.Core.Data.Repositories;
using Sunflower.Demo.Core.Models;
using Sunflower.Demo.Core.Models.Account;
using Sunflower.Demo.Core.Models.Security;


namespace Sunflower.Demo.Core
{
    /// <summary>
    ///     账户模块核心业务契约
    /// </summary>
    public interface IAccountContract
    {
        #region 属性

        /// <summary>
        /// 获取 用户信息查询数据集
        /// </summary>
        IQueryable<Member> Members { get; }

        /// <summary>
        /// 获取 用户扩展信息查询数据集
        /// </summary>
        IQueryable<MemberExtend> MemberExtends { get; }

        /// <summary>
        /// 获取 登录记录信息查询数据集
        /// </summary>
        IQueryable<LoginLog> LoginLogs { get; }

        /// <summary>
        /// 获取 角色信息查询数据集
        /// </summary>
        IQueryable<Role> Roles { get; }

        #endregion

        #region 公共方法

        /// <summary>
        ///     用户登录
        /// </summary>
        /// <param name="loginInfo">登录信息</param>
        /// <returns>业务操作结果</returns>
        OperationResult Login(LoginInfo loginInfo);

        #endregion
    }
}