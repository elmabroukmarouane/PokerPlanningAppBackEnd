using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Models.Interfaces
{
    public interface ICommonFields
    {
        DateTime? createdat { get; set; }
        DateTime? updatedat { get; set; }
        string createdby { get; set; }
        string updatedby { get; set; }
    }
}
