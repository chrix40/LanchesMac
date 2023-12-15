using LanchesMac.Models;

namespace LanchesMac.ViewModels
{
    public class CategoriaLancheViewModel
    {
        public Categoria Categoria { get; set; }
        public Lanche Lanche { get; set; }
        public List<Categoria> ListaCategorias { get; set; }
        public List<Lanche> ListaLanche { get; set; }
    }
}
