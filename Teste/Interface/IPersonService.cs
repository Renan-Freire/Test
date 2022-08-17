using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Teste.Models;
using Teste.DTO;

namespace Teste.Interface
{
    public interface IPersonService
    {
        public PersonDTO GetById(int id, List<Person> listaPessoas);
        public void AddPerson(PersonDTO person, List<Person> listaPessoas);

    }
}
