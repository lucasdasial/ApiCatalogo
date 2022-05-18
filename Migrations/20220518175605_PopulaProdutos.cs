using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatalogApi.Migrations
{
    public partial class PopulaProdutos : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO \"Produtos\"" +
                "(\"Nome\",\"Descricao\",\"Preco\",\"ImageUrl\",\"Estoque\",\"DataCadastro\",\"CategoriaId\") " +
                "VALUES('pepsi Diet','Refrigerante do Levy 350 ml', 5.99," +
                " 'https://i.pinimg.com/originals/81/48/a3/8148a3ecc26b0c02e5e27d46dfa8fdd2.png',50, now(),1)");

        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM \"Produtos\" ");
        }
    }
}
