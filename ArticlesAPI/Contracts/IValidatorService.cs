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


namespace ArticlesAPI.Contracts
{
    public interface IValidatorService
    {
        Task<IEnumerable<Doc>> SetArticlesStatus(IEnumerable<Doc> docs);
        Task<bool> IsURLAvailable(string webURL);
        bool IsURLPingSuccess(string webURL);
        void IsSearchEmpty(string search);
        void EnsureSuccessfulResponse(HttpResponseMessage response);
        void IsDateInputValid(DateTime? startDate, DateTime? endDate);
        void rootObjectIsNotNull(RootObject rootObject);
        bool IsValidDateRange(DateTime? startDate, DateTime? endDate);
        bool IsDateFuture(DateTime? date);
        bool IsDateEmpty(DateTime? date);
    }
}