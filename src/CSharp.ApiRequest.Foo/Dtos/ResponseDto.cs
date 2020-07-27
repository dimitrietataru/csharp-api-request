namespace CSharp.ApiRequest.Foo.Dtos
{
    public sealed class ResponseDto
    {
        public ResponseDto()
        {
        }

        public ResponseDto(string httpVerb, string text)
        {
            HttpVerb = httpVerb;
            Text = text;
        }

        public string HttpVerb { get; set; }
        public string Text { get; set; }
    }
}
