﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace RandomActs.Models
{ 
    public interface IRandomActActorRepository
    {
        IQueryable<RandomActActor> All { get; }
        IQueryable<RandomActActor> AllIncluding(params Expression<Func<RandomActActor, object>>[] includeProperties);
        RandomActActor Find(int id);
        IQueryable<RandomActActor> FilterByActId(int actId);
        bool IsActorRegisteredAlready(int RandomActId, int RandomActorId);
        void InsertOrUpdate(RandomActActor randomactactor);
        void Delete(int id);
        void Save();
    }
}