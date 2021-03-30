using System;
using XFun.App.Entities;
using XFun.App.Interfaces;

namespace XFun.App.UserCases
{
    public class SaveEmail
    {
        private readonly IUserRepository repository;
        private readonly IGenerator generator;

        public SaveEmail(IUserRepository repository, IGenerator generate)
        {
            this.repository = repository;
            this.generator = generate;
        }

        public int Execute(SaveEmailCommand command)
        {
            var user = new User(command.Email, generator.Generate(5), null, command.CreatedDate);
            repository.Add(user);
            return user.Code;
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