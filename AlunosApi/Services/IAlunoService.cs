using AlunosApi.Models;

namespace AlunosApi.Services
{
    public interface IAlunoService
    {
        public Task<IEnumerable<Aluno>> GetAlunos();
        public Task<Aluno> GetAluno(int id);
        public Task<IEnumerable<Aluno>> GetAlunosPorNome(string nome);
        public Task CreateAluno(Aluno aluno);
        public Task UpdateAluno(int id, Aluno aluno);
        public Task DeleteAluno(int id);

    }
}
