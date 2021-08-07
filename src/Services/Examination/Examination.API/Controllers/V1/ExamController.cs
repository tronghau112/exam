﻿using Examination.Application.Queries.GetHomeExamList.V1;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Examination.API.Controllers.V1
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class ExamController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ExamController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetExamList()
        {
            var query = new GetHomeExamListQuery();

            var queryResult = await _mediator.Send(query);

            return Ok(queryResult);
        }
    }
}