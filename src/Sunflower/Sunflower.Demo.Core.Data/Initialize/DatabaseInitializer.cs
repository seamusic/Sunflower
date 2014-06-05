using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

using Sunflower.Data;
using Sunflower.Demo.Core.Data.Migrations;


namespace Sunflower.Demo.Core.Data.Initialize
{
    /// <summary>
    /// 数据库初始化操作类
    /// </summary>
    public static class DatabaseInitializer
    {
        /// <summary>
        /// 数据库初始化
        /// </summary>
        public static void Initialize( )
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<EFDbContext, Configuration>());
        }
    }
}
