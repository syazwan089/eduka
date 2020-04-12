using Eduka.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Eduka.Services
{
    public interface IRestApi
    {
        Task<List<Peta>> GetPeta(string topic_id);

        Task<List<News>> GetNews();

        Task<List<Unit>> GetUnit(string topic_id);

        Task<List<topic>> GetQuiz(string topic_id);

        Task<List<Soalan>> GetQuizSet(string Quiz_Id);

        Task<List<video>> GetVideo(string Topic_id);

        Task<bool> PrestasiSubmit(string studentId, string QuizId, string Markah);

        Task<List<Prestasi>> resultPrestasi(string studentId);

    }
}
