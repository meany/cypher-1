﻿// CYPCore by Matthew Hellyer is licensed under CC BY-NC-ND 4.0.
// To view a copy of this license, visit https://creativecommons.org/licenses/by-nc-nd/4.0

using CYPCore.Models;

namespace CYPCore.Persistence
{
    public interface IDeliveredRepository : IRepository<BlockHeaderProto>
    {
        string Table { get; }
        BlockHeaderProto ToTrie(BlockHeaderProto blockHeader);
        byte[] MrklRoot { get; }
        void ResetTrie();

    }
}