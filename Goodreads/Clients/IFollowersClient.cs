﻿using System.Threading.Tasks;
using Goodreads.Models.Response;

namespace Goodreads.Clients
{
    /// <summary>
    /// API client for user followers endpoint.
    /// </summary>
    public interface IFollowersClient
    {
        /// <summary>
        /// Follow a user.
        /// </summary>
        /// <param name="userId">The Goodreads Id for the desired user.</param>
        /// <returns>A Goodreads user following model.</returns>
        Task<UserFollowing> Follow(int userId);

        /// <summary>
        /// Unfollow a user.
        /// </summary>
        /// <param name="userId">The Goodreads Id for the desired user.</param>
        /// <returns>True if the unfollow succeeded, false otherwise.</returns>
        Task<bool> Unfollow(int userId);
    }
}