﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Repository
{
   public partial interface Ibasedal <T> where T:class
    {
        IQueryable<T> LoadAll(Expression<Func<T,bool>> predicate);
    }
}
