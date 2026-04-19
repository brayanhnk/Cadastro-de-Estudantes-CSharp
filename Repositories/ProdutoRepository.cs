public class ProdutoRepository {
    private readonly AppDbContext _context = new AppDbContext();

    public void Inserir(Produto p) { _context.Produtos.Add(p); _context.SaveChanges(); }
    
    public List<Produto> Listar() => _context.Produtos.ToList();

    
    public List<Produto> ListarAcimaDe(double precoMinimo) {
        return _context.Produtos.Where(p => p.Preco > precoMinimo).ToList();
    }
}