using System.ComponentModel.DataAnnotations;

namespace CSharp.ApiRequest.Foo.Dtos
{
    public sealed class RequestDto
    {
        [Required]
        public string Text { get; set; }

        [Required]
        public double Number { get; set; }
    }
}
