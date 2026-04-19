public class EstoqueRepository {
    private readonly AppDbContext _context = new AppDbContext();

    public void DarBaixa(int id, int qtd) {
        var item = _context.Estoque.Find(id);
        if (item != null) {
            
            if (item.Quantidade >= qtd) {
                item.Quantidade -= qtd;
                _context.SaveChanges();
            }
        }
    }

    public List<ItemEstoque> ListarEstoqueBaixo(int limite) {
        return _context.Estoque.Where(i => i.Quantidade < limite).ToList();
    }
}