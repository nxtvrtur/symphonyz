using System.Threading;
using System.Threading.Tasks;

namespace Symphonyz.Core.Interfaces;

public interface IAudioTag
{ 
    public Task Show(CancellationToken cancellationToken);
}