using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web;
using System.Net;
using System.Net.NetworkInformation;
using System;
using System.Security.Authentication;
using Newtonsoft.Json;
using ArticlesAPI.Models;
using ArticlesAPI.Exceptions;
using ArticlesAPI.Contracts;

namespace ArticlesAPI.Services
{
    public class ValidatorService : IValidatorService
    {
        private readonly HttpClient HttpClient;

        public ValidatorService()
        {
            HttpClient = new HttpClient();
        }

        // Set status of each article passed as a paremeter, whether each webURL is online or not.
        public async Task<IEnumerable<Doc>> SetArticlesStatus(IEnumerable<Doc> docs)
        {
            foreach (var doc in docs)
            {
                // If false, it means this article's url is not online, so I set its status to false.
                doc.StatusAvailable = await IsURLAvailable(doc.Web_URL);
            }
            return docs;
        }
        // Check if one URL is available.
        public async Task<bool> IsURLAvailable(string webURL)
        {
            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Head, webURL);
            try
            {
                var response = await this.HttpClient.SendAsync(httpRequestMessage);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool IsURLPingSuccess(string webURL)
        {
            var ping = new System.Net.NetworkInformation.Ping();

            var result = ping.Send(webURL);

            if (result.Status != System.Net.NetworkInformation.IPStatus.Success)
            {
                return false;
            }
            return true;
        }
        public void IsSearchEmpty(string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                throw new BadRequestException("Bad request: search term can't be empty");
            }
        }

        public void EnsureSuccessfulResponse(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                switch ((int)response.StatusCode)
                {
                    case 400:
                        throw new BadRequestException("Bad request: the query could not be validated at server side");
                        break;
                    case 401:
                        throw new AuthenticationException("Not authorized to perform this action.");
                        break;
                    case 500:
                        throw new NotFoundException("We couldn't connect to the server, please contact your system administrator");
                        break;
                    default:
                        throw new NotFoundException("Cannot process the request right now.");
                        break;
                }
            }
        }

        public void IsDateInputValid(DateTime? startDate, DateTime? endDate)
        {
            // Check if dates aren't empty
            if (IsDateEmpty(startDate) || IsDateEmpty(endDate))
            {
                throw new BadRequestException("Bad request: one or both dates are empty");
            }
            else if (IsDateFuture(startDate) || IsDateFuture(endDate))
            {
                throw new BadRequestException("Bad request: one or both dates are greater than today");
            }
            else if (!IsValidDateRange(startDate, endDate))
            {
                throw new BadRequestException("Bad request: start date is greater than end date");
            }
            //Dates are valid
        }
        public bool IsValidDateRange(DateTime? startDate, DateTime? endDate)
        {
            if (startDate > endDate)
            {
                return false;
            }
            return true;
        }
        public bool IsDateFuture(DateTime? date)
        {
            if (date > DateTime.Now)
            {
                return true;
            }
            return false;
        }
        public bool IsDateEmpty(DateTime? date)
        {
            if (!date.HasValue)
            {
                return true;
            }
            return false;
        }

               public void rootObjectIsNotNull(RootObject rootObject)
        {
            if (rootObject == null)
            {
                throw new NotFoundException("Response returned is empty!");
            }
        }

    }
}