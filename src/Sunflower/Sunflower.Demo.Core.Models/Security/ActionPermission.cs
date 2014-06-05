using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sunflower.Core;

namespace Sunflower.Demo.Core.Models.Security
{
    [Description("动作权限")]
    public class ActionPermission : EntityBase<Guid>
    {
        public ActionPermission()
        {
            Id = CombHelper.NewComb();
        }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Description { get; set; }
    }
}
