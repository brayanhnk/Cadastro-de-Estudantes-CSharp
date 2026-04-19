public class ClienteRepository {
    private readonly AppDbContext _context = new AppDbContext();

    public void Inserir(Cliente c) {
        
        if (c.Email.Contains("@")) {
            _context.Clientes.Add(c);
            _context.SaveChanges();
        }
    }

  
    public Cliente BuscarPorEmail(string email) {
        return _context.Clientes.FirstOrDefault(c => c.Email == email);
    }
}