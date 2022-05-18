using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatalogApi.Migrations
{
    public partial class PopulaCategorias : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into \"Categorias\"(\"Nome\", \"ImageUrl\") Values('Bebidas','https://cdn-icons-png.flaticon.com/512/1689/1689254.png')");
            mb.Sql("Insert into \"Categorias\"(\"Nome\", \"ImageUrl\") Values('Lanches','https://cdn-icons.flaticon.com/png/512/3227/premium/3227435.png?token=exp=1652894980~hmac=951c083ddd78d04aa18f3c7b7e0da576')");
            mb.Sql("Insert into \"Categorias\"(\"Nome\", \"ImageUrl\") Values('Doces','https://cdn-icons.flaticon.com/png/512/2515/premium/2515143.png?token=exp=1652895003~hmac=ca10223811c04b7937ea74e27efbbc22')");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from \"Categorias\"");
        }
    }
}
