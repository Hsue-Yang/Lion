using Microsoft.Extensions.Caching.Memory;

namespace Work1.Service
{
    
    public class MemoryCacheService : IMemoryCacheService
    {
        private readonly IMemoryCache _cache;
        private static readonly TimeSpan _defaultDuration = TimeSpan.FromSeconds(30);

        public MemoryCacheService(IMemoryCache cache)
        {
            _cache = cache;
        }


    }
}
