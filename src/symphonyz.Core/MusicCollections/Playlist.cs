﻿using System.Threading;
using System.Threading.Tasks;
using symphonyz.Core.MusicCollections.Base;

namespace symphonyz.Core.MusicCollections;

public class Playlist : MusicCollectionBase
{
    protected override Task SaveChangesAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}