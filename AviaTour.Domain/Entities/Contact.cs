﻿using AviaTour.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviaTour.Domain.Entities
{
    public class Contact : BaseEntity
    {
        public string PhoneNumber { get; set; }
    }
}
