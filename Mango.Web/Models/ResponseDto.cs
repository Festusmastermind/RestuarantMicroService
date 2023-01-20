namespace Mango.Web.Models
{
    public class ResponseDto
    {
        public bool IsSuccess { get; set; }

        public object Result { get; set; } //because we don't the kind of data it will be respresenting i.e the dataType is not certain

        public string DisplayMessage { get; set; } = "";

        public List<string> ErrorMessages { get; set; } //list of strings for displaying our error messages..


    }
}
