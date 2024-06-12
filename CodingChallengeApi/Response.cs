using System.Net.NetworkInformation;

namespace CodingChallengeApi
{
    public class Response
    {
        private string _status;
        public string Status 
        {
            get 
            {
                if (_status.ToLower() == "true")
                {
                    return "Success";
                }
                else return "Fail";
            }
            set { _status = value.ToLower(); } 
        }
        public string Message { get; set; }
    }
}
