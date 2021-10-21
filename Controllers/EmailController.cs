using ApiSendEmail.Entity;
using ApiSendEmail.Helpers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSendEmail.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmailController : Controller
    {
        [HttpPost("OneSendMailQuery")]
        public bool OneSendMailQuery([FromQuery] string email, [FromQuery] string message, [FromQuery] string subject)
        {

            return new SendEmail().OneSendEmail(email, message, subject);

        }

        [HttpPost("OneSendMailBody")]
        public bool OneSendMailBody([FromBody] DadosEnvioEntity dados)
        {

            return new SendEmail().OneSendEmail(dados.To, dados.Message, dados.Subject);

        }


    }
}
