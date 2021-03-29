using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XFun.Api.UserCases
{
    public class SaveEmail
    {
        private readonly SaveEmailCommand command;

        public SaveEmail(SaveEmailCommand command)
        {
            this.command = command;
        }

        public int Execute()
        {
            throw new NotImplementedException();
        }
    }

    public class SaveEmailCommand
    {
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }

        public SaveEmailCommand()
        {
            CreatedDate = DateTime.Now;
        }

        public SaveEmailCommand(string email):this()
        {
            Email = email;
        }
    }
}