using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    /// <inheritdoc />
    public partial class PopularLanches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferido, Nome, Preco) VALUES(1, 'Pão, Hambúrguer, ovo, presunto, queijo e batata palha', 'Delicioso pão de hambúrguer com ovo frito; presunto e queijo de primeira qualidade acompanhado com batata palha',1, 'https://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg', 'https://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg', 0, 'Cheese Salada', 12.50)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferido, Nome, Preco) VALUES(1, 'Pão, Hambúrguer, ovo, presunto, queijo e batata palha', 'Delicioso pão francês; presunto e queijo de primeira qualidade acompanhado com batata palha',1, 'https://www.macoratti.net/Imagens/lanches/mistoquente4.jpg', 'https://www.macoratti.net/Imagens/lanches/mistoquente4.jpg', 0, 'Misto quente', 8.00)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferido, Nome, Preco) VALUES(1, 'Pão, Hambúrguer, ovo, presunto, queijo e batata palha', 'Delicioso pão de hambúrguer com ovo frito; presunto e queijo de primeira qualidade acompanhado com batata palha',1, 'https://www.macoratti.net/Imagens/lanches/cheeseburger1.jpg', 'https://www.macoratti.net/Imagens/lanches/cheeseburger1.jpg', 0, 'Cheese Burguer', 11.00)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferido, Nome, Preco) VALUES(1, 'Pão, Hambúrguer, ovo, presunto, queijo e batata palha', 'Delicioso pão integral; queijo branco, peito de peru e cenoura ralada com alface',1, 'https://www.macoratti.net/Imagens/lanches/lanchenatural.jpg', 'https://www.macoratti.net/Imagens/lanches/lanchenatural.jpg', 1, 'Lanche Natural Peito Peru', 15.00)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
