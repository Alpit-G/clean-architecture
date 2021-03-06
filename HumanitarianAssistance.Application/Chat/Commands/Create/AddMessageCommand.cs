﻿using MediatR;
using HumanitarianAssistance.Application.Infrastructure;

namespace HumanitarianAssistance.Application.Chat.Commands.Create
{
    public class AddMessageCommand : BaseModel, IRequest<ApiResponse>
    {
        public long? ChatId { get; set; }
        public string Message { get; set; }
        public int ChatSourceEntityId { get; set; }
        public int EntityId { get; set; }
        public long? EntitySourceDocumentId { get; set; }
        public string UserName { get; set; }
    }
}
