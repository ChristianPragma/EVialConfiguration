using EVialConfig.Domain.Dtos;
using MediatR;

namespace EVialConfig.Application.Commands
{
    internal class InsertCacheCommand<T> : IRequest<bool> where T : class
    {
        public InsertCacheDto<T> RequestDto { get; set; }
        public InsertCacheCommand(InsertCacheDto<T> requestDto)
        {
            RequestDto = requestDto;
        }
    }
}
