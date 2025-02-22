﻿// CYPCore by Matthew Hellyer is licensed under CC BY-NC-ND 4.0.
// To view a copy of this license, visit https://creativecommons.org/licenses/by-nc-nd/4.0

using System.Collections.Generic;
using System.Threading.Tasks;

using CYPCore.Models;

namespace CYPCore.Persistence
{
    public interface IStagingRepository : IRepository<StagingProto>
    {
        Task SaveOrUpdateAllCompletedAsync(IEnumerable<byte[]> hashes);

        string Table { get; }
    }
}
