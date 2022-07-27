using SBIChallenge.Models;
using SBIChallenge.Models.Requests;

using SBIChallenge.Services;

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using AutoMapper;

using MediatR;

namespace SBIChallenge.Handlers
{
    public class PostsRequestHandler : IRequestHandler<PostsRequest, Salida>
    {
        private readonly IPostsService postsService;
        private readonly IMapper mapper;

        public PostsRequestHandler(
            IPostsService postsService,
            IMapper mapper) 
        {
            this.postsService = postsService;
            this.mapper = mapper;
        }

        public async Task<Salida> Handle(PostsRequest request, CancellationToken cancellationToken) 
        {
            var posts = await postsService.GetPosts();

            if (posts != null) 
            {
                var post = posts.Where(p => p.Id == request.Id).FirstOrDefault();

                var salida = mapper.Map<Salida>(post);

                return salida;
            }
            else 
            {
                return null;
            }
        }
    }
}