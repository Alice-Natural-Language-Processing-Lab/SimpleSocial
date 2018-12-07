﻿using System.Threading.Tasks;
using SimpleSocia.Services.Models.Account;
using SimpleSocial.Data.Common;
using SimpleSocial.Data.Models;

namespace SimpleSocial.Services.DataServices
{
    public class PostServices : IPostServices
    {
        private readonly IRepository<Post> postRepository;

        public PostServices(IRepository<Post> postRepository)
        {
            this.postRepository = postRepository;
        }

        public async Task CreatePost(MyProfileViewModel viewModel)
        {
            var post = new Post()
            {
                UserId = viewModel.CreatePost.UserId,
                Title = viewModel.CreatePost.Title,
                WallId = viewModel.CreatePost.WallId,
                Content = viewModel.CreatePost.Content,
            };


            await postRepository.AddAsync(post);
            await postRepository.SaveChangesAsync();
        }
    }
}