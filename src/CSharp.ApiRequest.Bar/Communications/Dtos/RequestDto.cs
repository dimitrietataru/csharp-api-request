namespace CSharp.ApiRequest.Bar.Communications.Dtos
{
    public sealed class RequestDto
    {
        public RequestDto()
        {
        }

        public RequestDto(string text, double number)
        {
            Text = text;
            Number = number;
        }

        public string Text { get; set; }
        public double Number { get; set; }
    }
}
