﻿using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PlanesFamiliares.Test
{
    public class UnitTestCache : IDistributedCache
    {

        Dictionary<string, byte[]> cache = new Dictionary<string, byte[]>();
        public byte[] Get(string key)
        {
            
            return cache[key];
        }

        public Task<byte[]> GetAsync(string key, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public void Refresh(string key)
        {
            throw new NotImplementedException();
        }

        public Task RefreshAsync(string key, CancellationToken token = default)
        {
            throw new NotImplementedException();
        } 

        public void Remove(string key)
        {
            cache.Remove(key);
        }

        public Task RemoveAsync(string key, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public void Set(string key, byte[] value, DistributedCacheEntryOptions options)
        {
            byte[] valueOut;
            if (!cache.TryGetValue(key, out valueOut))
            {
                cache.Add(key, value);
            }
        }

        public Task SetAsync(string key, byte[] value, DistributedCacheEntryOptions options, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }
    } 
}
