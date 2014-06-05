using System.Linq;
using Sunflower.Core;
using Sunflower.Demo.Core.Data.Repositories;
using Sunflower.Demo.Core.Models;
using Sunflower.Demo.Core.Models.Account;
using Sunflower.Demo.Core.Models.Security;


namespace Sunflower.Demo.Core
{
    /// <summary>
    ///     �˻�ģ�����ҵ����Լ
    /// </summary>
    public interface IAccountContract
    {
        #region ����

        /// <summary>
        /// ��ȡ �û���Ϣ��ѯ���ݼ�
        /// </summary>
        IQueryable<Member> Members { get; }

        /// <summary>
        /// ��ȡ �û���չ��Ϣ��ѯ���ݼ�
        /// </summary>
        IQueryable<MemberExtend> MemberExtends { get; }

        /// <summary>
        /// ��ȡ ��¼��¼��Ϣ��ѯ���ݼ�
        /// </summary>
        IQueryable<LoginLog> LoginLogs { get; }

        /// <summary>
        /// ��ȡ ��ɫ��Ϣ��ѯ���ݼ�
        /// </summary>
        IQueryable<Role> Roles { get; }

        #endregion

        #region ��������

        /// <summary>
        ///     �û���¼
        /// </summary>
        /// <param name="loginInfo">��¼��Ϣ</param>
        /// <returns>ҵ��������</returns>
        OperationResult Login(LoginInfo loginInfo);

        #endregion
    }
}