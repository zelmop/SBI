using SBIChallenge.Models;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SBIChallenge.Services
{
    public interface IPostsService 
    {
        Task<List<ServerPost>> GetPosts();
    }
}