using SBIChallenge.Models;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SBIChallenge.Services.Implementation
{
    public class PostsService : IPostsService
    {
        private readonly string BaseUrl = "https://jsonplaceholder.typicode.com/posts";

        private readonly IApiHelper apiHelper;

        public PostsService(IApiHelper apiHelper) 
        {
            this.apiHelper = apiHelper;
        }

        public async Task<List<ServerPost>> GetPosts() 
        {
            return await apiHelper.Get<List<ServerPost>>(BaseUrl);
        }
    }
}