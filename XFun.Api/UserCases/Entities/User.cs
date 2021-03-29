using System;

namespace XFun.Api.UserCases.Entities
{
    internal class User
    {
        public string Email { get; set; }
        public int Code { get; set; }
        public string FullName { get; set; }
        public DateTime CreatedDate { get; set; }

        public User()
        {

        }
        public User(string email, int code, string fullName, DateTime createdDate)
        {
            Email = email;
            Code = code;
            FullName = fullName;
            CreatedDate = createdDate;
        }
    }
}