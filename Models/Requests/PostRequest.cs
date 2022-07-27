using SBIChallenge.Models;

using System;

using MediatR;

namespace SBIChallenge.Models.Requests
{
    public class PostsRequest : IRequest<Salida>
    {
        public int Id { get; private set; }
        
        public PostsRequest(int id) 
        {
            Id = id;
        }
    }
}