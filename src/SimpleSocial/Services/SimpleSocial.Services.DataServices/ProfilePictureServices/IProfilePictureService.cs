﻿using System.Security.Claims;
using SimpleSocial.Services.Models.Account;

namespace SimpleSocial.Services.DataServices.ProfilePictureServices
{
    public interface IProfilePictureService
    {
        void UploadProfilePictureCloudinary(ClaimsPrincipal user, UploadProfilePictureInputModel inputModel);

        public string GetUserProfilePictureURL(string userId);
    }
}
