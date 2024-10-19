using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Local_Alternatives.Migrations
{
    /// <inheritdoc />
    public partial class CityModelAndSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74fe2370-df95-4916-a90d-a0445dfcd726");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dee699f8-5b19-43fe-98c5-dc001de2517c");

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    PrimaryCity = table.Column<string>(type: "text", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7312d943-52da-4df3-a261-78cee3dcbf25", null, "User", "USER" },
                    { "909e1479-6647-41b4-a2d4-9609c2f7e7be", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Country", "Name", "PrimaryCity" },
                values: new object[,]
                {
                    { new Guid("010ae911-76cc-4a31-87ef-c819229ee63a"), "North Macedonia", "Jegunovce", "Unknown" },
                    { new Guid("082a33af-a382-443a-9f01-4ce63b2fa710"), "North Macedonia", "Dolneni", "Unknown" },
                    { new Guid("086dffb8-a20d-456b-aee6-c2176114313a"), "North Macedonia", "Studeničani", "Unknown" },
                    { new Guid("0ada7797-e3df-44d8-bbc0-4a2072e9deab"), "North Macedonia", "Brvenica", "Unknown" },
                    { new Guid("0f42bb35-f91e-48c7-a2d0-cf5ea9440400"), "North Macedonia", "Petrovec", "Unknown" },
                    { new Guid("1ba0d928-df63-444e-86cf-d1cf059b6c47"), "North Macedonia", "Forino", "Unknown" },
                    { new Guid("1df573ff-f90e-49c0-b5e4-0d4dc2852602"), "North Macedonia", "Kičevo", "Unknown" },
                    { new Guid("1e00175d-5895-4a23-ba7c-66bba2896945"), "North Macedonia", "Probištip", "Unknown" },
                    { new Guid("1f7f84f2-6d76-4fbf-b1c4-95cc31102ff4"), "North Macedonia", "Centar Župa", "Unknown" },
                    { new Guid("1fe0cbc3-aaab-4831-8193-e326417e1148"), "North Macedonia", "Čegrane", "Unknown" },
                    { new Guid("24f2c1e9-b27c-40cf-bd97-f393892084ce"), "North Macedonia", "Gradsko", "Unknown" },
                    { new Guid("2844b5a5-936f-4529-8e5a-290667eb7605"), "North Macedonia", "Makedonska Kamenica", "Unknown" },
                    { new Guid("2a19595a-7cb4-422d-a42d-26606239b092"), "North Macedonia", "Demir Kapija", "Unknown" },
                    { new Guid("2daa1cd1-7b7f-4117-b536-d6354deb6323"), "North Macedonia", "Struga", "Unknown" },
                    { new Guid("2dfef260-7d99-46f4-889c-b09cbbac5d58"), "North Macedonia", "Staro Nagoričane", "Unknown" },
                    { new Guid("2e6609cc-175b-402c-92ca-3e6f1e6c46d6"), "North Macedonia", "Aračinovo", "Unknown" },
                    { new Guid("3985f289-6e24-4098-a1f7-dbe9171bc851"), "North Macedonia", "Pehčevo", "Unknown" },
                    { new Guid("427e07a7-1fae-4d53-9df1-378203702fe8"), "North Macedonia", "Rašče", "Unknown" },
                    { new Guid("42ca0f48-ef57-48da-8e0a-14e6960631c2"), "North Macedonia", "Novaci", "Unknown" },
                    { new Guid("43b2ee40-2bdc-475f-b1d3-b0a65c58383a"), "North Macedonia", "Star Dojran", "Unknown" },
                    { new Guid("45bca370-7f3e-4558-8e95-01c587dd162f"), "North Macedonia", "Negotino", "Unknown" },
                    { new Guid("463be817-becc-4b79-a4db-7ca59826e1ee"), "North Macedonia", "Valandovo", "Unknown" },
                    { new Guid("51caef44-9e0c-438b-8ea6-aab3064eb9b2"), "North Macedonia", "Vrapčište", "Unknown" },
                    { new Guid("5c81bfde-5a1f-4e81-92aa-897e088c2bc3"), "North Macedonia", "Rosoman", "Unknown" },
                    { new Guid("60aebab1-6f79-4815-a1b0-5d95214e6fb2"), "North Macedonia", "Makedonski Brod", "Unknown" },
                    { new Guid("6325ac96-9e7f-4229-b537-3e4ce02e4d8b"), "North Macedonia", "Bogovinje", "Unknown" },
                    { new Guid("644ac88a-4cbb-4247-8c89-c695c3c0a8c6"), "North Macedonia", "Radoviš", "Unknown" },
                    { new Guid("64b86782-6fe2-4c02-9ad8-5449d341e106"), "North Macedonia", "Novo Selo", "Unknown" },
                    { new Guid("661530ee-fb6f-4ae0-8a78-757e53a9d5e9"), "North Macedonia", "Bogdanci", "Unknown" },
                    { new Guid("6783123e-1891-4479-a1bd-c6fe09ad41f2"), "North Macedonia", "Zrnovci", "Unknown" },
                    { new Guid("6aa71a8a-5b3b-4612-a051-ff8f3e77bf64"), "North Macedonia", "Rankovce", "Unknown" },
                    { new Guid("74430888-fb99-4084-81e0-0a8dd34bb63a"), "North Macedonia", "Bitola", "Unknown" },
                    { new Guid("74cb8d50-cd9f-4cb7-9f00-cdb896e0dbcf"), "North Macedonia", "Mogila", "Unknown" },
                    { new Guid("74f2301d-6d65-4731-975a-1d759a5006d4"), "North Macedonia", "Sopište", "Unknown" },
                    { new Guid("78c5c972-7281-4d57-aee2-90c51e0e594d"), "North Macedonia", "Prilep", "Unknown" },
                    { new Guid("7dcfbb59-bbe7-4b00-b447-babdb67abbd6"), "North Macedonia", "Vinica", "Unknown" },
                    { new Guid("7f72204c-12e3-4dd8-9905-3448b5febede"), "North Macedonia", "Sveti Nikole", "Unknown" },
                    { new Guid("82016235-d96d-407b-b8e4-c52bf2a9c86a"), "North Macedonia", "Čučer-Sandevo", "Unknown" },
                    { new Guid("847a3192-0eaa-49d8-a304-18b8224ce530"), "North Macedonia", "Belčišta", "Unknown" },
                    { new Guid("869e1af5-2b61-4ceb-828a-6772220cbf6e"), "North Macedonia", "Želino", "Unknown" },
                    { new Guid("87e574a1-fb00-4da7-973a-deeb77035295"), "North Macedonia", "Kučevište", "Unknown" },
                    { new Guid("8aa82800-a354-4c21-b83d-2bf12afade88"), "North Macedonia", "Vasilevo", "Unknown" },
                    { new Guid("8ccd2fc0-f051-4be4-97b8-7a96799287f2"), "North Macedonia", "Zelenikovo", "Unknown" },
                    { new Guid("968cf7cc-216e-40ed-a3a9-6848b63f8c32"), "North Macedonia", "Vevčani", "Unknown" },
                    { new Guid("9b849891-1ad0-42f9-b707-4c381029a63d"), "North Macedonia", "Kruševo", "Unknown" },
                    { new Guid("9ba57083-de70-4f6e-ab42-64819ab2f48e"), "North Macedonia", "Debar", "Unknown" },
                    { new Guid("a7c4cdb3-9a5d-4344-8e55-98d383096590"), "North Macedonia", "Rostuša", "Unknown" },
                    { new Guid("aefc1c66-aae8-499a-928f-78fc5ec72a75"), "North Macedonia", "Veles", "Unknown" },
                    { new Guid("afce181a-e86f-4676-9cd8-c419b61c19be"), "North Macedonia", "Gostivar", "Unknown" },
                    { new Guid("b3b2dae5-ebc4-4f09-b04c-13a3e3f23c70"), "North Macedonia", "Kočani", "Unknown" },
                    { new Guid("b3fcaadd-dcec-4d07-9f75-7a8c7a19329b"), "North Macedonia", "Lipkovo", "Unknown" },
                    { new Guid("b7338e89-daea-4670-a66f-0a44f67ce510"), "North Macedonia", "Karbinci", "Unknown" },
                    { new Guid("b9b5c873-1c00-4d08-b69b-4ed2d5674315"), "North Macedonia", "Bosilovo", "Unknown" },
                    { new Guid("bb5782a2-3848-498e-ba76-61d8f2b1b0b8"), "North Macedonia", "Kratovo", "Unknown" },
                    { new Guid("bcea6451-7a6a-4bb5-90c8-5679999ce523"), "North Macedonia", "Obleševo", "Unknown" },
                    { new Guid("bd177857-efd3-4467-9f6e-eeeda6fa90ee"), "North Macedonia", "Lozovo", "Unknown" },
                    { new Guid("c1bac992-7051-4174-9231-a6ebf52ed203"), "North Macedonia", "Demir Hisar", "Unknown" },
                    { new Guid("c214be37-25ed-471d-8e5f-3bf6f04abee4"), "North Macedonia", "Berovo", "Unknown" },
                    { new Guid("c3cd95a0-d19a-4b23-a0f5-1129af5cd6a1"), "North Macedonia", "Delčevo", "Unknown" },
                    { new Guid("c4caf395-d8b0-4cbc-b482-49086f81784e"), "North Macedonia", "Resen", "Unknown" },
                    { new Guid("c883a79b-bc7f-470a-b07b-0cd0c9d5a244"), "North Macedonia", "Plasnica", "Unknown" },
                    { new Guid("cef45d47-f9ef-4d84-a2d0-e520d76b7488"), "North Macedonia", "Krivogaštani", "Unknown" },
                    { new Guid("d23c6091-f981-4499-8aaf-39d31612f753"), "North Macedonia", "Tearce", "Unknown" },
                    { new Guid("d393ce95-d04e-42c2-b045-a721e5da3116"), "North Macedonia", "Konče", "Unknown" },
                    { new Guid("d4447a29-7efa-4fa5-9f92-9b775f2f794b"), "North Macedonia", "Gevgelija", "Unknown" },
                    { new Guid("d5d8b778-7440-40f2-bf62-ba5e781a1c34"), "North Macedonia", "Kavadarci", "Unknown" },
                    { new Guid("d8616eb7-e68f-42c8-aa6f-c22f84a3697f"), "North Macedonia", "Ohrid", "Unknown" },
                    { new Guid("e16e12b0-a266-45fc-bf66-b024dd0316d0"), "North Macedonia", "Štip", "Unknown" },
                    { new Guid("e8645d63-f73f-471e-b93d-a066c8b0ec27"), "North Macedonia", "Ilinden", "Unknown" },
                    { new Guid("ef649b44-173f-450c-a469-dd67ea1ec4ae"), "North Macedonia", "Skopje", "Unknown" },
                    { new Guid("f194df50-539e-4c94-add0-a47f416a429e"), "North Macedonia", "Dračevo", "Unknown" },
                    { new Guid("f6392c82-e8b6-4716-8cfd-a7cdd21401f0"), "North Macedonia", "Kriva Palanka", "Unknown" },
                    { new Guid("fa7e44d6-fc9f-48fc-84c7-c6a08243e927"), "North Macedonia", "Tetovo", "Unknown" },
                    { new Guid("fd0e6f7f-e395-4c31-b4e7-0d72564e2a97"), "North Macedonia", "Strumica", "Unknown" },
                    { new Guid("fd43a4c7-30b5-417d-930e-51de641ec69c"), "North Macedonia", "Kumanovo", "Unknown" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7312d943-52da-4df3-a261-78cee3dcbf25");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "909e1479-6647-41b4-a2d4-9609c2f7e7be");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "74fe2370-df95-4916-a90d-a0445dfcd726", null, "Admin", "ADMIN" },
                    { "dee699f8-5b19-43fe-98c5-dc001de2517c", null, "User", "USER" }
                });
        }
    }
}
