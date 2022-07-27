using System;
using System.Threading.Tasks;

namespace SBIChallenge.Services
{
    public interface IApiHelper 
    {
        Task<T> Get<T>(string url);
    }
}