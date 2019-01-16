using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SyZero.Domain.Interface;
using SyZero.Domain.Model;
using SyZero.Infrastructure.Repository;

namespace SZCMSApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IBaseRepository<Article> _articleRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ValuesController(IBaseRepository<Article> articleRepository, IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
            this._articleRepository = articleRepository;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IEnumerable<Article> Get(int id)
        {
            return _articleRepository.GetAll();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
