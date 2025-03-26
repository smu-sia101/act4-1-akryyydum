using Microsoft.AspNetCore.Mvc;
using System;

namespace PetNameGenerator.Controllers
{
    [ApiController]
    [Route("api")]
    public class PetNameController : ControllerBase
    {
        private string[] dogNames = { "Buddy", "Max", "Charlie", "Rocky", "Rex" };
        private string[] catNames = { "Whiskers", "Mittens", "Luna", "Simba", "Tiger" };
        private string[] birdNames = { "Tweety", "Sky", "Chirpy", "Raven", "Sunny" };

        private Random random = new Random();

        public class PetRequest
        {
            public string AnimalType { get; set; }
            public bool? TwoPart { get; set; }
        }

        [HttpPost("generate")]
        public IActionResult GeneratePetName([FromBody] PetRequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.AnimalType))
            {
                return BadRequest(new { error = "Please provide an 'animalType' (dog, cat, or bird)." });
            }

            string animalType = request.AnimalType.Trim().ToLower();
            string[] nameList;

            if (animalType == "dog")
            {
                nameList = dogNames;
            }
            else if (animalType == "cat")
            {
                nameList = catNames;
            }
            else if (animalType == "bird")
            {
                nameList = birdNames;
            }
            else
            {
                return BadRequest(new { error = "Invalid 'animalType'. Choose 'dog', 'cat', or 'bird'." });
            }

            string petName = nameList[random.Next(nameList.Length)];

            if (request.TwoPart == true)
            {
                string secondName = nameList[random.Next(nameList.Length)];
                petName = petName + " " + secondName;
            }

            return Ok(new { petName });
        }
    }
}
