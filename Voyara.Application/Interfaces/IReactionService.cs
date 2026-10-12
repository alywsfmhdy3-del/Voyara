using Voyara.Application.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Voyara.Application.Interfaces
{
    public interface IReactionService
    {
        Task<bool> ReactToPostAsync(string userId, int postId, ReactToPostDto dto);
        Task<bool> ReactToCommentAsync(string userId, int commentId, ReactToCommentDto dto);
    }
}
