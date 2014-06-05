using System;
using System.ComponentModel;

using Sunflower.Core;


namespace Sunflower.Demo.Core.Models.Account
{
    /// <summary>
    ///     ʵ���ࡪ���û���չ��Ϣ
    /// </summary>
    [Description("�û���չ��Ϣ")]
    public class MemberExtend : EntityBase<Guid>
    {
        /// <summary>
        /// ��ʼ��һ�� �û���չʵ���� ����ʵ��
        /// </summary>
        public MemberExtend()
        {
            Id = CombHelper.NewComb();
        }

        public string Tel { get; set; }

        public MemberAddress Address { get; set; }

        public virtual Member Member { get; set; }
    }
}