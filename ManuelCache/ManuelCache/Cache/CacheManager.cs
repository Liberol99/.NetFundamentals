namespace ManuelCache.Cache
{
    public class CacheManager
    {
        public static Dictionary<string, object> CacheStore { get; set; } = new Dictionary<string, object>();

        public object SetCache(string name, object value)
        {
            if (CacheStore.ContainsKey(name))
            {
                return CacheStore[name];
            }
            else
            {
                CacheStore.Add(name, value);
                return value;
            }
        }

        public object? GetCache(string name)
        {
            if (CacheStore!=null && CacheStore.ContainsKey(name) && CacheStore[name]!=null)
            {
                return CacheStore[name];
            }
            else
            {
                return null;
            }
        }

        public void ClearCache(string name)
        {
            if (CacheStore != null && CacheStore.ContainsKey(name) && CacheStore[name] != null)
            {
                CacheStore.Remove(name);
            }
        }

    }
}
