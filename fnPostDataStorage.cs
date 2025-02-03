using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace CatalogoFlix
{
    public class fnPostDataStorage
    {
        private readonly ILogger<fnPostDataStorage> _logger;

        public fnPostDataStorage(ILogger<fnPostDataStorage> logger)
        {
            _logger = logger;
        }

        [Function("dataStorage")]
        public async Task <IActionResult> Run([HttpTrigger(AuthorizationLevel.Anonymous, "post")] HttpRequest req)
        {
            _logger.LogInformation("Imagem no Storage");

            try
            {
                if(!req.Headers.TryGetValue("file-type", out var fileTypeHeader))
                {
                    return new BadRequestObjectResult("o Cabeçalho 'file-type' é obrigatório");
                }

                var fileType = fileTypeHeader.ToString();
                var form = await req.ReadFormAsync();
                var file = form.Files["file"];

                if (file == null || file.Lenght == 0)
                {
                    return new BadRequestObjectResult("o arquivo não foi enviado");
                    
                }
                string connectionString = Environment.GetEnvironmentVariable("AzureWebJobsStorage");
                string containerName = fileType;

                

            }
            catch (Exception)
            {
                throw;
            }



            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
