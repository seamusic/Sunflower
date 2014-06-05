using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;

using Sunflower.Data;
using Sunflower.Demo.Core.Models;


namespace Sunflower.Demo.Core.Data.Configurations.Account
{
    partial class LoginLogConfiguration
    {
        partial void LoginLogConfigurationAppend()
        {
            HasRequired(m => m.Member).WithMany(n => n.LoginLogs);
        }
    }
}