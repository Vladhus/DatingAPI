using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingAPI.DTOS
{
    public class CreateMessageDTO
    {
        public string  RecipientUsername { get; set; }
        public string  Content { get; set; }
    }
}
