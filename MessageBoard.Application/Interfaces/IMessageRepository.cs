using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessageBoard.Domain.Entities;

// Defines the functionality of the application.
namespace MessageBoard.Application.Interfaces
{
    public interface IMessageRepository
    {
        Task AddAsync(Message message);
    }
}
