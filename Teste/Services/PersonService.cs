using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Teste.Models;
using Teste.Interface;
using Teste.DTO;

namespace Teste.Services
{
    public class PersonService : IPersonService
    {
        public PersonDTO GetById(int id, List<Person> listaPessoas)
        {
            var person = (from p in listaPessoas
                         where p.Id == id
                         select new PersonDTO()
                         {
                             Id = p.Id,
                             FirstName = p.FirstName,
                             LastName = p.LastName
                         }).FirstOrDefault();

            return person;
        }

        public void AddPerson(PersonDTO person, List<Person> listaPessoas)
        {
            Person newPerson = new Person()
            {
                Id = person.Id,
                FirstName = person.FirstName,
                LastName = person.LastName
            };

            listaPessoas.Add(newPerson);
        }
    }
}
