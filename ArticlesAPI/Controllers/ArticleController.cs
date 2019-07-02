using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web;
using System;
using Newtonsoft.Json;
using ArticlesAPI.Models;
using ArticlesAPI.Services;
using ArticlesAPI.Contracts;

namespace ArticlesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IArticleService _articleService;
        private readonly IValidatorService _validatorService;
        public ArticleController(IArticleService articleService, IValidatorService validatorService)
        {
            _articleService = articleService;
            _validatorService = validatorService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Doc>>> RetrieveArticles(string search, DateTime? startDate, DateTime? endDate)
        {
            // _validatorService.IsSearchEmpty(search);
            // _validatorService.IsDateInputValid(startDate, endDate);

            var response = await this._articleService.RetrieveArticles(search, startDate, endDate);
            return Ok(response);
        }

    }
}
