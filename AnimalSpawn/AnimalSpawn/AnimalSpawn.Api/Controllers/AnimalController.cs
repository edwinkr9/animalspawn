﻿using System.Threading.Tasks;
using AnimalSpawn.Domain.Interface;
using AnimalSpawn.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AnimalSpawn.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private readonly IAnimalRepository _repository;
        public AnimalController(IAnimalRepository repository)
        {
            this._repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var animals = await _repository.GetAnimals();
            return Ok(animals);
        }


    }
}
