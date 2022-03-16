namespace Ui.Api.Models
{
    public class CommentVm
    {
        public string Text { get; set; }
        public Guid ProductId { get; set; }
        public Guid UserId { get; set; }
        public string Author { get; set; }
    }
}
