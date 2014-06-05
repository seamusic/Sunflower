using System;
using System.ComponentModel;

using Sunflower.Core;


namespace Sunflower.Demo.Core.Models.Account
{
    /// <summary>
    ///     实体类——用户扩展信息
    /// </summary>
    [Description("用户扩展信息")]
    public class MemberExtend : EntityBase<Guid>
    {
        /// <summary>
        /// 初始化一个 用户扩展实体类 的新实例
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