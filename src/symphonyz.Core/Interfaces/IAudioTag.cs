using System.Threading;
using System.Threading.Tasks;

namespace symphonyz.Core.Interfaces;

public interface IAudioTag
{ 
    public Task Show(CancellationToken cancellationToken);
}