using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Domain.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Calculadora.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculadoraController : ControllerBase
    {
        private readonly ICalculadoraService _calculadoraService;
        public CalculadoraController(ICalculadoraService calculadoraService)
        {
            _calculadoraService = calculadoraService;
        }

        [HttpPost]
        public void Sum(double firstNumber, double secondNumber)
        {
            _calculadoraService.Sum(firstNumber, secondNumber);
        }
    }
}