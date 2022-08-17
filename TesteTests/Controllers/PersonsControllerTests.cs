using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Teste.Controllers;
using Teste.DTO;
using Teste.Interface;
using Teste.Models;
using Teste.Services;

namespace Teste.Controllers.UnitTests
{
    [TestClass()]
    public class PersonsControllerTests
    {
        List<Person> listPersons = new List<Person>()
        {
            new Person() {Id = 1, FirstName = "Renan", LastName = "Freire"},
            new Person() {Id = 2, FirstName = "Raylan", LastName = "Freire"},
            new Person() {Id = 3, FirstName = "Valdirene", LastName = "Tomaz"},
            new Person() {Id = 4, FirstName = "Wallas", LastName = "Freire"}
        };

        [TestMethod()]
        public void GetPersonTest()
        {
            PersonService personService = new PersonService();
            PersonsController personsController = new PersonsController(personService);

            var person = personsController.GetPerson(3, listPersons);

            Console.WriteLine(person);
        }

        [TestMethod()]
        public void AddPersonTest()
        {
            PersonService personService = new PersonService();
            PersonsController personsController = new PersonsController(personService);

            PersonDTO personDTO = new PersonDTO()
            {
                Id = 5,
                FirstName = "Erivelton",
                LastName = "Elias"
            };

            personsController.AddPerson(personDTO, listPersons);

            foreach (var item in listPersons)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.FirstName);
                Console.WriteLine(item.LastName);
                Console.WriteLine("----------------");
            }
        }
    }
}