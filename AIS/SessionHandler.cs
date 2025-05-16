using Microsoft.AspNetCore.Http;

namespace AIS
    {
    public class SessionHandler
        {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public SessionHandler(IHttpContextAccessor httpContextAccessor)
            {
            _httpContextAccessor = httpContextAccessor;
            }

        private ISession Session => _httpContextAccessor.HttpContext?.Session;

        public void SetString(string key, string value)
            {
            Session?.SetString(key, value);
            }

        public string? GetString(string key)
            {
            return Session?.GetString(key);
            }

        public void Remove(string key)
            {
            Session?.Remove(key);
            }

        public void Clear()
            {
            Session?.Clear();
            }
        }
    }
