using Entidades;
using MailKit.Security;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using Services;
using MailKit.Net.Smtp;

namespace MyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingOrdersController : ControllerBase
    {
        private readonly IShoppingOrder _svShoppingOrder;
        public ShoppingOrdersController(IShoppingOrder svShoppingOrder)
        {
            _svShoppingOrder = svShoppingOrder;
        }
        
        [HttpGet("ShoppingOrder")]
        public IEnumerable<ShoppingOrder> Get()
        {
            return _svShoppingOrder.ListShoppingOrders();
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost("ShoppingOrder")]
        public void Post([FromBody] ShoppingOrder shoppingOrder)
        {
            _svShoppingOrder.Add(shoppingOrder);
        }


        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ShoppingOrder shoppingOrder)
        {
         
        }
        [HttpPost]
        public IActionResult CreateOrder(ShoppingOrder shoppingOrder)
        {
            try
            {
                _svShoppingOrder.CreateOrder(shoppingOrder);
                SendConfirmationEmail(shoppingOrder);

                return Ok("Order created successfully and email sent");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred while creating the order: {ex.Message}");
            }
        }

        private void SendConfirmationEmail(ShoppingOrder shoppingOrder)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Hezron", "hezroncastaneda@gmail.com"));
            message.To.Add(new MailboxAddress("", shoppingOrder.Address));
            message.Subject = "Confirmación de pedido";

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = $"Gracias por tu compra. " +
                $"Tu número de pedido es {shoppingOrder.Id} y el total a pagar es {shoppingOrder.Total} colones ." +
                $"Su metodo de pago fue por medio de: {shoppingOrder.PaymentMethod},";
            message.Body = bodyBuilder.ToMessageBody();

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                client.Authenticate("hezroncastaneda@gmail.com", "vbpfwcecrcmteyuv");
                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
 }