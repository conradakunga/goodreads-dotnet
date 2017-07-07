﻿using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Goodreads.Http;
using RestSharp;

namespace Goodreads.Clients
{
    /// <summary>
    /// The client class for the Group endpoint of the Goodreads API.
    /// </summary>
    public class GroupClient : IGroupClient
    {
        private readonly IConnection Connection;

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupClient"/> class.
        /// </summary>
        /// <param name="connection">A RestClient connection to the Goodreads API.</param>
        public GroupClient(IConnection connection)
        {
            Connection = connection;
        }

        /// <summary>
        /// Join the current user to a given group.
        /// </summary>
        /// <param name="groupId">The Goodreads Id for the desired group.</param>
        /// <returns>True if joining succeeded, false otherwise.</returns>
        public async Task<bool> Join(int groupId)
        {
            var parameters = new List<Parameter>
            {
                new Parameter { Name = "id", Value = groupId, Type = ParameterType.QueryString }
            };

            var response = await Connection.ExecuteRaw("group/join", parameters, Method.POST);

            return response.StatusCode == HttpStatusCode.OK;
        }
    }
}