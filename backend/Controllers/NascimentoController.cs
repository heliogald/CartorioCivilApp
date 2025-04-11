using CartorioCivilApi.DTOs;
using CartorioCivilApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Serialization;

namespace CartorioCivilApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NascimentoController : ControllerBase
    {
        private readonly NascimentoService _service;

        public NascimentoController(NascimentoService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Criar([FromBody] NascimentoDTO dto)
        {
            var result = await _service.CriarAsync(dto);
            return Ok(result);
        }

        [HttpGet("relatorio")]
        public async Task<IActionResult> GetRelatorio([FromQuery] DateTime inicio, [FromQuery] DateTime fim)
        {
            var dados = await _service.GetRelatorio(inicio, fim);
            return Ok(dados);
        }

        [HttpGet("relatorio/xml")]
        public async Task<IActionResult> GetRelatorioXml([FromQuery] DateTime inicio, [FromQuery] DateTime fim)
        {
            var dados = await _service.GetRelatorio(inicio, fim);
            var stream = new MemoryStream();
            var serializer = new XmlSerializer(dados.GetType());
            serializer.Serialize(stream, dados);
            stream.Position = 0;
            return File(stream, "application/xml", "relatorio_nascimento.xml");
        }
    }
}
