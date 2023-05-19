using Microsoft.AspNetCore.Mvc;
using Parse;
using UnlimitedSpaceService.ChatSection.Model;

namespace UnlimitedSpaceService.ChatSection.Controllers
{
    [Route("api/chat")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        [HttpGet]
        public async Task<List<ChatMessage>> GetChat()
        {
            var query = new ParseQuery<ParseObject>("ChatMessages");
            var messages = await query.FindAsync();

            List<ChatMessage> resultMessages = new();

            foreach (var message in messages)
            {
                resultMessages.Add(new ChatMessage() 
                { 
                    Added = DateTime.Parse(message["Added"].ToString()),
                    AuthorId = message["AuthorId"].ToString(),
                    AuthorName = message["AuthorName"].ToString(),
                    Id = message.ObjectId,
                    Text = message["Text"].ToString()
                });
            }
            return resultMessages;
        }

        [HttpPost]
        public async Task AddChatMessageAsync(ChatMessage message)
        {
            ParseObject _message = new ParseObject("ChatMessages");
            _message["Text"] = message.Text;
            _message["Added"] = DateTime.UtcNow;
            _message["AuthorId"] = message.AuthorId;
            _message["AuthorName"] = message.AuthorName;
            await _message.SaveAsync();
        }

    }
}
