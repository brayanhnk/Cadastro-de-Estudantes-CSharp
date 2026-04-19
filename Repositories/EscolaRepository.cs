public class EscolaRepository {
    private readonly AppDbContext _context = new AppDbContext();

    public void InserirProfessorComCursos(Professor p) {
        _context.Professores.Add(p);
        _context.SaveChanges();
    }

    public List<Professor> ListarTudo() {

        return _context.Professores.Include(p => p.Cursos).ToList();
    }
}