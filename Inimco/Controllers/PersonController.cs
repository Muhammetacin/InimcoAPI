using Inimco.Data;
using Inimco.Migrations;
using Inimco.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic;
using System.Text.Json;

namespace Inimco.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public PersonController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpPost]
        public async Task<ActionResult<Person>> PostPerson(Person person)
        {
            /*var person = await _dataContext.Persons.FirstAsync();*/
            var personx = new Person()
            {
                FirstName = "John",
                LastName = "Doe",
                SocialAccounts = new List<SocialAccount>(),
                SocialSkills = new List<SocialSkill>(),
            };

            Console.WriteLine("The number of VOWELS: " + VowelsAndConstenantsPerson(person)[0]);
            Console.WriteLine("The number of CONSTENANTS: " + VowelsAndConstenantsPerson(person)[1]);

            Console.WriteLine("The firstname + last name entered: " + person.FirstName + " " + person.LastName);

            Console.WriteLine("The reverse version of the firstname and lastname: " + ReverseNamePerson(person).LastName + " " + ReverseNamePerson(person).FirstName);

            Console.WriteLine("The JSON format of the entire object: ");
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            Console.Write(JsonSerializer.Serialize(person, options));


            _dataContext.Persons.Add(person);
            await _dataContext.SaveChangesAsync();

            /*return Ok(await _dataContext.Persons.FirstAsync());*/
            return Ok(person);
        }

        private Person ReverseNamePerson(Person person)
        {
            Person newPerson = new Person();

            // reverse first name and last name
            char[] charFNArray = person.FirstName.ToCharArray();
            Array.Reverse(charFNArray);
            string reversedFirstName = new string(charFNArray);

            char[] charLNArray = person.LastName.ToCharArray();
            Array.Reverse(charLNArray);
            string reversedLastName = new string(charLNArray);

            newPerson.FirstName = reversedFirstName;
            newPerson.LastName = reversedLastName;

            return newPerson;
        }

        private int[] VowelsAndConstenantsPerson(Person person)
        {
            // count letters in first and last name
            int vowels = 0;
            int constenants = 0;
            string inputstring = person.FirstName + person.LastName;
            int length = inputstring.Length;

            for (int i = 0; i < length; i++)
            {

                // Check if the character is a vowel
                if (inputstring[i] == 'a' || inputstring[i] == 'e' ||
                    inputstring[i] == 'i' || inputstring[i] == 'o' ||
                    inputstring[i] == 'u' || inputstring[i] == 'A' ||
                    inputstring[i] == 'E' || inputstring[i] == 'I' ||
                    inputstring[i] == 'O' || inputstring[i] == 'U')
                {

                    // Increment the vowels
                    vowels++;
                }

                // Check if the character is a alphabet
                // other than vowels
                else if ((inputstring[i] >= 'a' && inputstring[i] <= 'z') ||
                         (inputstring[i] >= 'A' && inputstring[i] <= 'Z'))
                {

                    // Increment the constenants
                    constenants++;
                }
            }

            return new int[] { vowels, constenants };
        }
    }
}
