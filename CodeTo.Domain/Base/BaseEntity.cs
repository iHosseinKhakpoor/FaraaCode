﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTo.Domain.Base
{
   public  class BaseEntity<T> where T : struct
    {
        [Key]
        public T Id { get; set; }
        public bool IsDeleted { get; set; }
    }
    
    
}
