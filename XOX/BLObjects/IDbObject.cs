﻿using FluentResults;
using System;
using System.Threading.Tasks;

namespace XOX.BLObjects
{
    //TODO: move somewhere out of BL
    public interface IDbObject<T,F, K>
    {
        public Task<Result<T>> Get(K id);

        public Task<Result<T>> Save();

        public F ChangeModel(F model);

        public bool IsEqualByData(F model);
    }
}