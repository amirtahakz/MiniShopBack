using Microsoft.AspNetCore.Mvc;
using Ui.Api.Models;
using Ui.Core.Repositories;
using Ui.Data.Entities;

namespace Ui.Api.Controllers
{
    [ApiController]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet]
        [Route("GetCommentsProduct")]
        public async Task<IActionResult> GetCommentsProduct(Guid id)
        {
            return Ok(await _commentService.GetCommentsProduct(id));
        }


        [HttpPost]
        [Route("PostComment")]
        public async Task<IActionResult> PostComment([FromBody]CommentVm model)
        {
            var newComment = new Comment()
            {
                Author = model.Author,
                UserId = model.UserId,
                ProductId = model.ProductId,
                Text = model.Text,
            };
            await _commentService.PostComment(newComment);

            return Ok();
        }
    }
}
