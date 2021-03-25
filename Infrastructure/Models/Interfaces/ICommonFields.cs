using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Models.Interfaces
{
    public interface ICommonFields
    {
        DateTime? createdate { get; set; }
        DateTime? updatedate { get; set; }
        string createdby { get; set; }
        string updatedby { get; set; }
    }
}
