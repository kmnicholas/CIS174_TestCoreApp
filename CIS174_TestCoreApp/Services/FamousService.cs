using CIS174_TestCoreApp.Models;
using CIS174_TestCoreApp.Models.FamousCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Services
{
    public class FamousService
    {
        readonly FamousContext _context;
        
        public FamousService(FamousContext context)
        {
            _context = context;
        }

        public int CreateFamousPerson (CreateFamousPersonCommand cmd)
        {
            var famousPerson = new FamousPerson
            {
                FirstName = cmd.FirstName,
                LastName = cmd.LastName,
                Birthdate = cmd.Birthdate,
                City = cmd.City,
                State = cmd.State,
                Accomplishments = cmd.Accomplishments?.Select(i =>
                new Accomplishment
                {
                    Name = i.Name,
                    DateOfAccomplishment = i.DateOfAccomplishment,
                }).ToList()
            };

            _context.Add(famousPerson);
            _context.SaveChanges();

            return famousPerson.Id;
        }
    }
}
