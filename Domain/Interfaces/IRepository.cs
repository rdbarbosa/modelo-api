﻿using webapicore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace webapicore.Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Insert(T obj);

        void Update(T obj);

        void Delete(int id);

        T Select(int id);

        IList<T> Select();
    }
}

