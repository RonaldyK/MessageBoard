using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessageBoard.Application.Interfaces;
using MessageBoard.Domain.Entities;
using MessageBoard.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace MessageBoard.Infrastructure.Repositories
{
    public class MessageRepository : IMessageRepository
    {
        private readonly MessageDbContext _context;

        public MessageRepository(IDbContextFactory<MessageDbContext> factory)
        {
            _context = factory.CreateDbContext();
        }
        public async Task AddAsync(Message message)
        {
            _context.Messages.Add(message);
            await _context.SaveChangesAsync();  
        }

    }
}
