using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;

using Sunflower.Data;
using Sunflower.Demo.Core.Models;


namespace Sunflower.Demo.Core.Data.Configurations.Security
{
    partial class RoleConfiguration
    {
        partial void RoleConfigurationAppend()
        {
            HasMany(m => m.Members).WithMany(n => n.Roles);
        }
    }
}
