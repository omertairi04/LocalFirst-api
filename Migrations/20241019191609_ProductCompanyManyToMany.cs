using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Local_Alternatives.Migrations
{
    /// <inheritdoc />
    public partial class ProductCompanyManyToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_AspNetUsers_CompanyId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CompanyId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15ff443a-63e3-4f4f-b755-238686524df9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cdcbe847-27c3-4597-a218-fbc5d942fa8a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d389196b-6db1-4e30-9abd-a9d94f3ea59b");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("012b18fd-9cc5-4a97-b873-aed693f33729"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("038f94c3-deeb-4361-9c14-9a9d9cbd49a3"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("06af3211-3260-4aee-bbf9-3e6b090c60b1"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0a6e9ecd-af14-4a33-ade3-627e95cf22b3"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0c208426-defb-47f5-8db4-9ff092533f7b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0c71935c-dfb0-4a37-959d-fc67c53627a4"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("10b6eacd-16c4-454b-97bf-1ecf105064e6"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1299904c-5e69-453c-8456-be25e77951cf"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("13d70324-a63b-4dec-9482-21f44434aad7"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1950c9f0-8d68-4e88-8ce1-04b631c8131e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1c583e8a-f6bd-4724-94c6-5bed2b64d135"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1c82dd21-c83e-4e05-a6fb-abcb774d26d6"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1c8d1422-b005-4309-83d8-5cdaef75db1f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1dac3a79-ed4d-4611-933a-df86106b7b5a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1dff2c02-2621-4c33-9ae0-295f07c626f4"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2616f44f-8957-447b-8ccc-507747ecb21e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("281ea15b-379a-4644-8a14-4ede52b9e76f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2e568f34-769b-469c-ad25-a6262f6e2175"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("30f08233-bf0c-470a-ab28-1c549894c186"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("357fd985-fccb-4038-8095-cef670e06874"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3ad7e606-0abe-4859-a13b-5604fefacbe7"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3b517a22-6be1-44a2-beba-69b9482057d5"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3c79e233-8fb3-4f8c-9785-30a7951e8819"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3df94642-ea49-4f50-9379-eecf233b8822"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5241b43e-db08-4857-bea5-d5a2ba6b901b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5510631a-2301-4a29-8622-2d9d84da18e3"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("58dae023-8cfb-4870-8e64-1b7119520d3b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5d153229-87cd-41b8-b206-1fc7d99a1ac6"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5e539e6e-8ec3-44ba-aa1a-2e29d829132f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6a9a73f3-17bd-425d-ac2f-82b24e5a0977"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6b62eb47-15de-48bd-9d0b-42fa439b8522"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6bbf616c-19b5-45e7-aac0-88fd7d071338"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6ed87d88-25b3-4d28-91cf-a8706be9e26a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("71e6ed3f-1324-4dff-8586-4145ef916f9e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7fa38cfc-10fd-4f46-a829-3fa825fa0b88"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8a4641a4-5512-492b-a7a5-5b5657e04fcc"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8a89a979-7c71-40be-bee6-d454038d7d46"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8bfeb7a7-3642-4418-aff5-42beeaf381cb"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("925bdb90-1222-46ce-ab36-d00836c508da"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("932d71c5-d7dc-4973-9925-ba8b0d2e2b51"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("95be4309-1a08-495a-a0fa-45c2bb5b5779"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("98e7b36e-f174-4f67-8144-36dacbef5d99"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9a8fbfa6-facf-40b7-82fe-c1725692c16e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a2950902-dcf1-47ae-a5ee-95be7aceb94a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a4db7d57-6e83-4bcb-8c9c-b0a2eef7ff40"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a5f2917a-1419-45e8-ba8f-2776914e88f6"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a703041c-26c5-4923-b2b2-a3a46b4e1e35"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("aa37e904-eea2-4d1b-8273-b700c849e1a5"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("adc4f992-120c-4ad3-9695-07019105b186"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ae667675-aaee-4df4-8ca1-9f3d0e7c3eb9"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b620ece8-4129-4d23-aacf-9e0340538e9d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("bc7af0f4-49a0-4087-a9d0-6b99726b58f8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("bd256804-c174-4971-bd1f-f1bb96acf1a6"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("bd581613-ea4f-48c4-944f-e8c1b0718432"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("be6a3c60-32b9-4eaf-a3b9-d9a5b26d740f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c1ae4f2b-c2b7-49e1-ac70-cb7e30cb94ba"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c7c2ad0d-9661-4627-8ca3-2c2cc8dd759a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c807d7d0-040d-4e31-87dc-d6fe0b262138"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("caac63b1-9c88-43df-860e-a9cdda34e3a7"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("cdd4d7f4-5181-4272-b05f-77bf4917b496"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d0205a40-4af6-425a-adbe-d2fc7daff490"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d6f81670-ffe7-47f8-ae98-7f95a2735713"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("da6ff731-bf58-430e-a592-2b65993db473"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("daacb903-6984-43be-af93-017e5d1a9f34"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e0187308-cc24-4404-8797-d2b51dde7fb4"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e064fb92-abf6-4e18-8db0-7083921a78b0"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e5509ad9-1e35-4645-b372-a26d0c70cd03"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e72c0ae0-7f89-4994-8d12-1d3ee3678281"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e78392b5-f5c7-4e3c-aa61-7c8b150a59f0"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("eedad813-290b-448e-86bc-091479fd158d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ef8cc750-a2a7-4ef7-96c2-cd7bdcef4dba"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f211b2b4-7f15-4780-98eb-269fb946857f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f649b744-f4c1-4fa7-9259-c9c986c42c29"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f7cbc05d-df42-4198-9433-fdceb917fcd5"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fdf5316f-81c3-4ae6-bccb-d7039a057732"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("00b4ee81-5f7a-47ff-b57f-5fe3ae658876"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("00dc6bee-81e9-4d98-ab90-b40147faa2cd"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("02f7883d-9707-4173-91be-c22febecd8ff"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("07c1d1fe-acca-41ec-8128-8691b92deaf9"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("106d1157-a862-46c0-9636-67c1f688d64b"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("142adc7e-fdfa-4cb1-aa75-4969bc847865"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("1bb5950a-f26f-45dd-b72d-b969c3b91701"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("1d791d54-1193-42d1-9024-260609571c3b"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("212c48c4-03df-4db6-acdc-57fcfb250bfa"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("33613632-944f-4c7c-bf0e-0401dbc04bf3"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("3e62c841-339f-4082-b42d-dfaf3e17b854"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("44f9e04d-1a3e-4ca7-af23-ac01ace8dc42"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("47c272be-1f80-44b2-aa02-43ac04337be1"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("5ded9fec-334e-4211-a346-5f33c3970a71"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("629868b9-e4a0-418b-9208-56cd46683391"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("6e5325f1-496b-4f39-997a-5922221dc1f8"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("7d110101-4778-4e77-af2e-aad3c9dd9002"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("8e4bc54f-4643-432d-8fd9-36c06d408c71"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("900158a2-a0a2-41ed-b2a2-9e073b52eef9"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("9727ffb5-b514-4cfa-96e4-f48a9c29eccf"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("a13f6a58-724c-45df-9936-b9a49579c15e"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("abd0e4f2-e6fd-4940-850d-1916b3df97f1"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("b08facfb-014f-4eb2-a572-04fc24b4d412"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("dc5cecb0-98ad-4bb9-a1ed-c987f7ccd9e4"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("e25ef894-41d3-4aae-9ca5-1a31d2f20d78"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("e59a720e-df32-4443-9d0d-872d3f716da6"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("fa3d2cb2-f35d-4993-9ad5-9f697facb898"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("fe6274ef-5496-4682-b57e-6eccbe332e60"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("35f5aaa1-4210-4c8b-bc70-ff9fba96596d"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("4737b25e-a35b-4dc6-8a0f-49f1fc244a06"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("7ab2dd32-b776-4b9d-b358-84ed5fc3785e"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("addc83f6-d401-4840-91c1-fc83d3b71111"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("ba7fd734-fc6e-4274-a6d2-7c434a8a21bf"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("eb1cf234-91e0-4b1c-9b76-a8fde5aa1032"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("fc958eb1-e547-4895-a8e3-8076c22f4b0b"));

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "ProductCompanies",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCompanies", x => new { x.ProductId, x.CompanyId });
                    table.ForeignKey(
                        name: "FK_ProductCompanies_AspNetUsers_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCompanies_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1199aed2-9165-4967-8460-d8cfd3063f14", null, "Company", "COMPANY" },
                    { "30de0ac3-53c0-4db9-a75b-802b4a1e04e1", null, "User", "USER" },
                    { "a408b5f0-8a13-458e-897c-310ad60ac20a", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Country", "Name", "PrimaryCity" },
                values: new object[,]
                {
                    { new Guid("00ffb322-9cd0-49ba-95e2-8ed4fa3615f9"), "North Macedonia", "Bitola", "Bitola" },
                    { new Guid("0282fca5-da2f-42d6-bd6c-e88a32c0c02e"), "North Macedonia", "Star Dojran", "Dojran" },
                    { new Guid("034943a4-6d95-4f7a-a339-60895ca53fb0"), "North Macedonia", "Kučevište", "Čučer-Sandevo" },
                    { new Guid("051399f6-2318-4abe-a14f-4c728d16e244"), "North Macedonia", "Rankovce", "Rankovce" },
                    { new Guid("05445886-41b0-4c73-b140-d9e21661f799"), "North Macedonia", "Sveti Nikole", "Sveti Nikole" },
                    { new Guid("08029745-75ab-486b-9531-83a5b0f56f24"), "North Macedonia", "Lozovo", "Lozovo" },
                    { new Guid("0865607d-4139-4128-8234-c1eb9fcaa89d"), "North Macedonia", "Mogila", "Mogila" },
                    { new Guid("173ecca3-08da-463c-8488-8af653697e23"), "North Macedonia", "Demir Kapija", "Demir Kapija" },
                    { new Guid("1820561d-9bba-4350-b733-5368091df97b"), "North Macedonia", "Plasnica", "Plasnica" },
                    { new Guid("1b083b22-e089-46eb-b8ee-d3ace57a098d"), "North Macedonia", "Konče", "Konče" },
                    { new Guid("1e7312f4-bb44-4a4f-a4b8-263abe942dc0"), "North Macedonia", "Dračevo", "Skopje" },
                    { new Guid("1fe86a56-355c-40a8-876e-4e2fdad77f39"), "North Macedonia", "Kavadarci", "Kavadarci" },
                    { new Guid("28beea88-dfe1-431d-8d0a-f2c7fa4ed8b5"), "North Macedonia", "Čegrane", "Gostivar" },
                    { new Guid("2cc2082d-f8e6-4950-b919-c65c99e9179e"), "North Macedonia", "Petrovec", "Petrovec" },
                    { new Guid("2d22f2ca-9ccc-4dfe-b2c0-14c96655e700"), "North Macedonia", "Negotino", "Negotino" },
                    { new Guid("2d9ea9f3-2450-4b71-9750-7f218fb6acda"), "North Macedonia", "Rašče", "Skopje" },
                    { new Guid("2e0916a6-8132-4663-afc3-5e82cf859b6b"), "North Macedonia", "Makedonska Kamenica", "Makedonska Kamenica" },
                    { new Guid("35bb88b3-cc41-4ead-ab18-94bf0dd7299d"), "North Macedonia", "Kočani", "Kočani" },
                    { new Guid("3801ec5f-0cd5-4b59-8b86-e4835fed223b"), "North Macedonia", "Delčevo", "Delčevo" },
                    { new Guid("3cbe18fd-d27e-459e-97ad-89b058d630ad"), "North Macedonia", "Radoviš", "Radoviš" },
                    { new Guid("45a947a7-5e43-44bd-9a5c-ba742adea69a"), "North Macedonia", "Ohrid", "Ohrid" },
                    { new Guid("47ce2e9f-b015-4294-81ca-94e3953c914b"), "North Macedonia", "Demir Hisar", "Demir Hisar" },
                    { new Guid("4850c224-29d1-4473-b9fd-9b83dae354fd"), "North Macedonia", "Valandovo", "Valandovo" },
                    { new Guid("4b53dbcb-4db2-4605-8506-1e88a602f694"), "North Macedonia", "Štip", "Štip" },
                    { new Guid("5070ef43-4f96-4805-8af1-6d820ffe3b42"), "North Macedonia", "Karbinci", "Karbinci" },
                    { new Guid("50a2532f-e434-46aa-9ad6-a3dfc65f4873"), "North Macedonia", "Brvenica", "Brvenica" },
                    { new Guid("516755a5-5b52-44ad-813f-597b85586676"), "North Macedonia", "Kruševo", "Kruševo" },
                    { new Guid("53914794-fdfe-454e-8084-97cfa582a623"), "North Macedonia", "Centar Župa", "Centar Župa" },
                    { new Guid("55745538-d40c-486a-b2d4-ae06bef25082"), "North Macedonia", "Gradsko", "Gradsko" },
                    { new Guid("573b49d9-76b3-4c58-a69a-f8b471b6cdab"), "North Macedonia", "Zrnovci", "Zrnovci" },
                    { new Guid("5a593281-2a73-4e6f-91a0-7220b8ab6af1"), "North Macedonia", "Staro Nagoričane", "Staro Nagoričane" },
                    { new Guid("705ed7ff-0de9-42b9-a5d8-8679e94ff5b9"), "North Macedonia", "Strumica", "Strumica" },
                    { new Guid("70ba8c54-aae5-4da1-a2ef-ca9a659e2b54"), "North Macedonia", "Tearce", "Tearce" },
                    { new Guid("71b3fa6a-11c4-4d79-bb8d-9f4a4cf78027"), "North Macedonia", "Prilep", "Prilep" },
                    { new Guid("7693ec9a-7fb8-4877-8176-f94400acd89e"), "North Macedonia", "Novo Selo", "Novo Selo" },
                    { new Guid("7990e5aa-07c1-4d3a-87b7-30aab10fa5b7"), "North Macedonia", "Jegunovce", "Jegunovce" },
                    { new Guid("7dc38565-d5c3-4f3c-9d6b-e8de395e3ff0"), "North Macedonia", "Želino", "Želino" },
                    { new Guid("7f24eb38-c1c3-4ee2-bb2b-fdd9a92b2b83"), "North Macedonia", "Studeničani", "Studeničani" },
                    { new Guid("7fb50c61-bb51-48c1-8253-38b7d72a977b"), "North Macedonia", "Belčišta", "Debarca" },
                    { new Guid("82ded2de-3cdc-4fec-8bd3-c2681c9e1721"), "North Macedonia", "Kriva Palanka", "Kriva Palanka" },
                    { new Guid("844fb9ed-e9f2-4c10-a8d1-2a373b888c06"), "North Macedonia", "Bogdanci", "Bogdanci" },
                    { new Guid("91bb85e1-e6a5-4401-a892-4902ba487641"), "North Macedonia", "Gostivar", "Gostivar" },
                    { new Guid("923f1fc7-eda4-4c80-bd41-c614e76345da"), "North Macedonia", "Resen", "Resen" },
                    { new Guid("9486af81-2b9f-4a3d-a858-a358b8839ffa"), "North Macedonia", "Kratovo", "Kratovo" },
                    { new Guid("96ea4045-76a7-4856-bdf2-fc96d4e02c27"), "North Macedonia", "Pehčevo", "Pehčevo" },
                    { new Guid("96f62f04-edb7-445c-9626-452b757ecb2b"), "North Macedonia", "Veles", "Veles" },
                    { new Guid("9df3006a-3971-4025-a2a5-c1082b313973"), "North Macedonia", "Tetovo", "Tetovo" },
                    { new Guid("a1c7a556-45ab-482d-921c-6a6d225704f3"), "North Macedonia", "Lipkovo", "Lipkovo" },
                    { new Guid("adb86f24-420c-4bd6-a937-5b28afca2d96"), "North Macedonia", "Forino", "Gostivar" },
                    { new Guid("b4b937f5-9685-461a-9324-f5decfd00bb4"), "North Macedonia", "Kičevo", "Kičevo" },
                    { new Guid("b7fcfbbe-7c6d-4d6f-a0f7-155cfbef39bf"), "North Macedonia", "Vinica", "Vinica" },
                    { new Guid("bbce200c-4270-451d-8952-7859e91e3830"), "North Macedonia", "Rosoman", "Rosoman" },
                    { new Guid("c7925be7-0f4b-4fa7-ab4e-99a4e4e1fb38"), "North Macedonia", "Vrapčište", "Vrapčište" },
                    { new Guid("cb10d3cc-c89b-4703-aec8-dbec5c1be065"), "North Macedonia", "Gevgelija", "Gevgelija" },
                    { new Guid("cba9160f-98b5-431d-a8ae-9bb557969bae"), "North Macedonia", "Bogovinje", "Bogovinje" },
                    { new Guid("cd13711c-19a5-44fc-bb78-40603518fc6a"), "North Macedonia", "Ilinden", "Ilinden" },
                    { new Guid("d4a48abd-7c76-48d2-bd44-a3671e58ab4d"), "North Macedonia", "Probištip", "Probištip" },
                    { new Guid("d7a6f4d2-7bba-43aa-920a-f1c4574f8757"), "North Macedonia", "Skopje", "Skopje" },
                    { new Guid("dc1fc6c6-73c2-48b2-b7cf-f52c874eed76"), "North Macedonia", "Makedonski Brod", "Makedonski Brod" },
                    { new Guid("dd7d0571-ca79-4069-91ea-6ec036b3dee5"), "North Macedonia", "Debar", "Debar" },
                    { new Guid("e016ed9f-009f-4b62-be5d-a0d4f0c62602"), "North Macedonia", "Aračinovo", "Aračinovo" },
                    { new Guid("e26d8362-1a32-44d9-b077-68f20d14dea6"), "North Macedonia", "Rostuša", "Mavrovo i Rostuše" },
                    { new Guid("e40c38df-69bb-4e5d-8ee9-6e334f1a09d9"), "North Macedonia", "Dolneni", "Dolneni" },
                    { new Guid("e70a866c-3da3-4f4b-b805-77f01c61284c"), "North Macedonia", "Zelenikovo", "Zelenikovo" },
                    { new Guid("e7446a18-9d7f-4d32-8a24-33df209e6555"), "North Macedonia", "Krivogaštani", "Krivogaštani" },
                    { new Guid("eb1df49a-a720-45c8-8202-9a87446527ab"), "North Macedonia", "Novaci", "Novaci" },
                    { new Guid("eb7ddb40-c0b2-4ca5-a0ce-ff9450619e1e"), "North Macedonia", "Obleševo", "Češinovo-Obleševo" },
                    { new Guid("eccdc33c-84ea-447b-953c-5f2b92c20271"), "North Macedonia", "Sopište", "Sopište" },
                    { new Guid("edcef169-f32e-4f25-96dc-ab10945b253d"), "North Macedonia", "Vasilevo", "Vasilevo" },
                    { new Guid("eef107b6-442a-4d54-acc1-d4297c3452aa"), "North Macedonia", "Berovo", "Berovo" },
                    { new Guid("f545fa14-56d0-4fed-9498-29697032bd8d"), "North Macedonia", "Vevčani", "Vevčani" },
                    { new Guid("f6003682-8132-4707-9bd5-06f6d533409c"), "North Macedonia", "Bosilovo", "Bosilovo" },
                    { new Guid("f66ca15a-2f0a-45e1-8950-fdf58a25f1bd"), "North Macedonia", "Struga", "Struga" },
                    { new Guid("f8681d08-f9c9-4553-8d7e-f7d082f9148d"), "North Macedonia", "Kumanovo", "Kumanovo" },
                    { new Guid("fc021cfe-1a5a-4920-a2db-bd37d8c2b42f"), "North Macedonia", "Čučer-Sandevo", "Čučer-Sandevo" }
                });

            migrationBuilder.InsertData(
                table: "MainCategories",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("113e3004-76b3-4a28-a4e2-c6135914eb11"), new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(5062), "Donate your books or medias.", "Books and Media", new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(5072) },
                    { new Guid("25cf611a-119a-4cc7-9d60-82710db2c73c"), new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(5148), "Donate your sport or fitness equipment.", "Sports of Fitness Equipment", new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(5163) },
                    { new Guid("748520d8-f493-460c-874d-ef0503d5106b"), new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(5192), "Donate your food and groceries.", "Food and Groceries", new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(5207) },
                    { new Guid("8c2dd92a-03d6-4d8c-af45-3346ddb8f8fe"), new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(4963), "Every day house hold items", "Household Items", new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(4977) },
                    { new Guid("91eda985-20ca-4b8c-a815-1b94be9eed38"), new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(4921), "Apparel and accessories", "Clothing", new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(4935) },
                    { new Guid("a46a2c92-a386-4e8f-b47d-8abecd242914"), new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(5014), "Electronics", "Electronics", new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(5028) },
                    { new Guid("d1bf02fc-ee77-4993-bb0d-51cd0041f8d5"), new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(5105), "Donate your Toys and Games.", "Toys and Games", new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(5115) }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CreatedAt", "Description", "MainCategoryId", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("00d97da3-5013-4842-aa9e-d3d344671f19"), new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(6127), "Smartphones and tablets", new Guid("a46a2c92-a386-4e8f-b47d-8abecd242914"), "Mobile Phones & Tablets", new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(6137) },
                    { new Guid("07cd265c-4220-4444-b35f-decd5b0d6619"), new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(5984), "Decorative items for the home", new Guid("8c2dd92a-03d6-4d8c-af45-3346ddb8f8fe"), "Home Décor", new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(5998) },
                    { new Guid("0d27b32c-50b7-4e84-ad02-512dab3326e0"), new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(6170), "Appliances for home use", new Guid("a46a2c92-a386-4e8f-b47d-8abecd242914"), "Home Appliances", new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(6185) },
                    { new Guid("2377552c-b0c6-4542-9ac4-71b0851683d4"), new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(5712), "Footwear for all", new Guid("91eda985-20ca-4b8c-a815-1b94be9eed38"), "Shoes & Footwear", new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(5722) },
                    { new Guid("3bb0b472-7c5c-4280-8954-4adc22b2fb76"), new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(6294), "Various magazines", new Guid("113e3004-76b3-4a28-a4e2-c6135914eb11"), "Magazines", new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(6308) },
                    { new Guid("42fe690f-dff1-4727-804b-257eb2efa4b2"), new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(5665), "Apparel for children", new Guid("91eda985-20ca-4b8c-a815-1b94be9eed38"), "Children's Clothing", new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(5679) },
                    { new Guid("45cc336f-dcb3-470a-9001-c9fbaabea208"), new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(6432), "Toys for young children", new Guid("d1bf02fc-ee77-4993-bb0d-51cd0041f8d5"), "Baby & Toddler Toys", new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(6447) },
                    { new Guid("58972642-a610-483b-ac1e-e6e641eba440"), new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(5803), "Household furniture", new Guid("8c2dd92a-03d6-4d8c-af45-3346ddb8f8fe"), "Furniture", new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(5817) },
                    { new Guid("6fccb3bd-b9e9-424f-99c8-5cc152776831"), new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(6785), "Non-perishable food products", new Guid("748520d8-f493-460c-874d-ef0503d5106b"), "Non-Perishable Items", new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(6800) },
                    { new Guid("74320894-bf4d-4843-a6f0-5fbcd6f50067"), new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(5618), "Apparel for women", new Guid("91eda985-20ca-4b8c-a815-1b94be9eed38"), "Women's Clothing", new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(5632) },
                    { new Guid("74a28754-887f-41c2-bb66-d508411d5d43"), new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(6834), "Food and formula for infants", new Guid("748520d8-f493-460c-874d-ef0503d5106b"), "Baby Food & Formula", new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(6843) },
                    { new Guid("7a14684a-2a1f-44a3-8a76-f65b468f408e"), new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(5851), "Utensils and appliances for the kitchen", new Guid("8c2dd92a-03d6-4d8c-af45-3346ddb8f8fe"), "Kitchenware", new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(5865) },
                    { new Guid("85666865-f177-4d11-8e38-ad3a50700037"), new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(6252), "Fiction, non-fiction, educational", new Guid("113e3004-76b3-4a28-a4e2-c6135914eb11"), "Books", new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(6266) },
                    { new Guid("8821909d-343c-4052-aa76-3fdfe6d265b9"), new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(5572), "Apparel for men", new Guid("91eda985-20ca-4b8c-a815-1b94be9eed38"), "Men's Clothing", new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(5586) },
                    { new Guid("886df892-eee1-4aca-946f-2873de3c1b51"), new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(6651), "Bicycles and scooters for all ages", new Guid("25cf611a-119a-4cc7-9d60-82710db2c73c"), "Bicycles & Scooters", new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(6666) },
                    { new Guid("9583b492-16b1-43fb-85f3-0b77c98abf1c"), new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(6480), "Toys that promote learning", new Guid("d1bf02fc-ee77-4993-bb0d-51cd0041f8d5"), "Educational Toys", new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(6490) },
                    { new Guid("966a451a-1d4c-40e0-84d1-c81f275396d2"), new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(6609), "Gear for various sports", new Guid("25cf611a-119a-4cc7-9d60-82710db2c73c"), "Sports Gear", new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(6623) },
                    { new Guid("9a078370-4ed4-4800-aaa6-45a1a7584291"), new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(6524), "Gaming systems and games", new Guid("d1bf02fc-ee77-4993-bb0d-51cd0041f8d5"), "Video Games & Consoles", new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(6538) },
                    { new Guid("9cd724ca-95c4-409b-ac90-78c3fc76c47e"), new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(5898), "Bedding essentials", new Guid("8c2dd92a-03d6-4d8c-af45-3346ddb8f8fe"), "Bedding & Linens", new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(5908) },
                    { new Guid("9eb4cdeb-5b75-4ac0-b2b6-1445fbdb3bcf"), new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(6571), "Equipment for gym workouts", new Guid("25cf611a-119a-4cc7-9d60-82710db2c73c"), "Gym Equipment", new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(6580) },
                    { new Guid("a39ca185-896e-4204-a0fc-ecda89042796"), new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(6209), "Televisions and audio equipment", new Guid("a46a2c92-a386-4e8f-b47d-8abecd242914"), "TVs & Audio Systems", new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(6223) },
                    { new Guid("a795010f-438a-44a2-aeec-d4697947753e"), new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(5942), "Cleaning essentials", new Guid("8c2dd92a-03d6-4d8c-af45-3346ddb8f8fe"), "Cleaning Supplies", new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(5961) },
                    { new Guid("af812318-d220-40a7-8301-89b67df2586f"), new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(6742), "Canned food items", new Guid("748520d8-f493-460c-874d-ef0503d5106b"), "Canned Goods", new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(6756) },
                    { new Guid("bca83898-9333-4991-ad77-488fe45f7f1e"), new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(6341), "Media collection", new Guid("113e3004-76b3-4a28-a4e2-c6135914eb11"), "CDs, DVDs, Blu-rays", new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(6356) },
                    { new Guid("cfef1b6e-b90e-439d-8e4d-08d8135ccf36"), new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(6699), "Equipment for outdoor activities", new Guid("25cf611a-119a-4cc7-9d60-82710db2c73c"), "Camping & Outdoor Gear", new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(6709) },
                    { new Guid("d2805996-9e87-496b-b3cb-235aa026de3f"), new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(6389), "Games for fun and challenges", new Guid("d1bf02fc-ee77-4993-bb0d-51cd0041f8d5"), "Board Games & Puzzles", new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(6403) },
                    { new Guid("e885b356-abab-4127-9145-d0342af77c1e"), new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(5755), "Hats, scarves, belts, etc.", new Guid("91eda985-20ca-4b8c-a815-1b94be9eed38"), "Accessories", new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(5769) },
                    { new Guid("f313068d-6212-4602-8d13-2dcee7348db1"), new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(6027), "Computers and laptops", new Guid("a46a2c92-a386-4e8f-b47d-8abecd242914"), "Computers & Laptops", new DateTime(2024, 10, 19, 19, 16, 8, 654, DateTimeKind.Utc).AddTicks(6041) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductCompanies_CompanyId",
                table: "ProductCompanies",
                column: "CompanyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductCompanies");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1199aed2-9165-4967-8460-d8cfd3063f14");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "30de0ac3-53c0-4db9-a75b-802b4a1e04e1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a408b5f0-8a13-458e-897c-310ad60ac20a");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("00ffb322-9cd0-49ba-95e2-8ed4fa3615f9"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0282fca5-da2f-42d6-bd6c-e88a32c0c02e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("034943a4-6d95-4f7a-a339-60895ca53fb0"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("051399f6-2318-4abe-a14f-4c728d16e244"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("05445886-41b0-4c73-b140-d9e21661f799"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("08029745-75ab-486b-9531-83a5b0f56f24"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0865607d-4139-4128-8234-c1eb9fcaa89d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("173ecca3-08da-463c-8488-8af653697e23"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1820561d-9bba-4350-b733-5368091df97b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1b083b22-e089-46eb-b8ee-d3ace57a098d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1e7312f4-bb44-4a4f-a4b8-263abe942dc0"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1fe86a56-355c-40a8-876e-4e2fdad77f39"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("28beea88-dfe1-431d-8d0a-f2c7fa4ed8b5"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2cc2082d-f8e6-4950-b919-c65c99e9179e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2d22f2ca-9ccc-4dfe-b2c0-14c96655e700"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2d9ea9f3-2450-4b71-9750-7f218fb6acda"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2e0916a6-8132-4663-afc3-5e82cf859b6b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("35bb88b3-cc41-4ead-ab18-94bf0dd7299d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3801ec5f-0cd5-4b59-8b86-e4835fed223b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3cbe18fd-d27e-459e-97ad-89b058d630ad"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("45a947a7-5e43-44bd-9a5c-ba742adea69a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("47ce2e9f-b015-4294-81ca-94e3953c914b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4850c224-29d1-4473-b9fd-9b83dae354fd"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4b53dbcb-4db2-4605-8506-1e88a602f694"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5070ef43-4f96-4805-8af1-6d820ffe3b42"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("50a2532f-e434-46aa-9ad6-a3dfc65f4873"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("516755a5-5b52-44ad-813f-597b85586676"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("53914794-fdfe-454e-8084-97cfa582a623"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("55745538-d40c-486a-b2d4-ae06bef25082"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("573b49d9-76b3-4c58-a69a-f8b471b6cdab"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5a593281-2a73-4e6f-91a0-7220b8ab6af1"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("705ed7ff-0de9-42b9-a5d8-8679e94ff5b9"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("70ba8c54-aae5-4da1-a2ef-ca9a659e2b54"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("71b3fa6a-11c4-4d79-bb8d-9f4a4cf78027"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7693ec9a-7fb8-4877-8176-f94400acd89e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7990e5aa-07c1-4d3a-87b7-30aab10fa5b7"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7dc38565-d5c3-4f3c-9d6b-e8de395e3ff0"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7f24eb38-c1c3-4ee2-bb2b-fdd9a92b2b83"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7fb50c61-bb51-48c1-8253-38b7d72a977b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("82ded2de-3cdc-4fec-8bd3-c2681c9e1721"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("844fb9ed-e9f2-4c10-a8d1-2a373b888c06"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("91bb85e1-e6a5-4401-a892-4902ba487641"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("923f1fc7-eda4-4c80-bd41-c614e76345da"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9486af81-2b9f-4a3d-a858-a358b8839ffa"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("96ea4045-76a7-4856-bdf2-fc96d4e02c27"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("96f62f04-edb7-445c-9626-452b757ecb2b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9df3006a-3971-4025-a2a5-c1082b313973"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a1c7a556-45ab-482d-921c-6a6d225704f3"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("adb86f24-420c-4bd6-a937-5b28afca2d96"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b4b937f5-9685-461a-9324-f5decfd00bb4"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b7fcfbbe-7c6d-4d6f-a0f7-155cfbef39bf"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("bbce200c-4270-451d-8952-7859e91e3830"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c7925be7-0f4b-4fa7-ab4e-99a4e4e1fb38"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("cb10d3cc-c89b-4703-aec8-dbec5c1be065"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("cba9160f-98b5-431d-a8ae-9bb557969bae"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("cd13711c-19a5-44fc-bb78-40603518fc6a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d4a48abd-7c76-48d2-bd44-a3671e58ab4d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d7a6f4d2-7bba-43aa-920a-f1c4574f8757"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("dc1fc6c6-73c2-48b2-b7cf-f52c874eed76"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("dd7d0571-ca79-4069-91ea-6ec036b3dee5"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e016ed9f-009f-4b62-be5d-a0d4f0c62602"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e26d8362-1a32-44d9-b077-68f20d14dea6"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e40c38df-69bb-4e5d-8ee9-6e334f1a09d9"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e70a866c-3da3-4f4b-b805-77f01c61284c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e7446a18-9d7f-4d32-8a24-33df209e6555"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("eb1df49a-a720-45c8-8202-9a87446527ab"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("eb7ddb40-c0b2-4ca5-a0ce-ff9450619e1e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("eccdc33c-84ea-447b-953c-5f2b92c20271"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("edcef169-f32e-4f25-96dc-ab10945b253d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("eef107b6-442a-4d54-acc1-d4297c3452aa"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f545fa14-56d0-4fed-9498-29697032bd8d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f6003682-8132-4707-9bd5-06f6d533409c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f66ca15a-2f0a-45e1-8950-fdf58a25f1bd"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f8681d08-f9c9-4553-8d7e-f7d082f9148d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fc021cfe-1a5a-4920-a2db-bd37d8c2b42f"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("00d97da3-5013-4842-aa9e-d3d344671f19"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("07cd265c-4220-4444-b35f-decd5b0d6619"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("0d27b32c-50b7-4e84-ad02-512dab3326e0"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("2377552c-b0c6-4542-9ac4-71b0851683d4"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("3bb0b472-7c5c-4280-8954-4adc22b2fb76"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("42fe690f-dff1-4727-804b-257eb2efa4b2"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("45cc336f-dcb3-470a-9001-c9fbaabea208"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("58972642-a610-483b-ac1e-e6e641eba440"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("6fccb3bd-b9e9-424f-99c8-5cc152776831"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("74320894-bf4d-4843-a6f0-5fbcd6f50067"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("74a28754-887f-41c2-bb66-d508411d5d43"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("7a14684a-2a1f-44a3-8a76-f65b468f408e"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("85666865-f177-4d11-8e38-ad3a50700037"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("8821909d-343c-4052-aa76-3fdfe6d265b9"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("886df892-eee1-4aca-946f-2873de3c1b51"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("9583b492-16b1-43fb-85f3-0b77c98abf1c"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("966a451a-1d4c-40e0-84d1-c81f275396d2"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("9a078370-4ed4-4800-aaa6-45a1a7584291"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("9cd724ca-95c4-409b-ac90-78c3fc76c47e"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("9eb4cdeb-5b75-4ac0-b2b6-1445fbdb3bcf"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("a39ca185-896e-4204-a0fc-ecda89042796"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("a795010f-438a-44a2-aeec-d4697947753e"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("af812318-d220-40a7-8301-89b67df2586f"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("bca83898-9333-4991-ad77-488fe45f7f1e"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("cfef1b6e-b90e-439d-8e4d-08d8135ccf36"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("d2805996-9e87-496b-b3cb-235aa026de3f"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("e885b356-abab-4127-9145-d0342af77c1e"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("f313068d-6212-4602-8d13-2dcee7348db1"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("113e3004-76b3-4a28-a4e2-c6135914eb11"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("25cf611a-119a-4cc7-9d60-82710db2c73c"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("748520d8-f493-460c-874d-ef0503d5106b"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("8c2dd92a-03d6-4d8c-af45-3346ddb8f8fe"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("91eda985-20ca-4b8c-a815-1b94be9eed38"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("a46a2c92-a386-4e8f-b47d-8abecd242914"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("d1bf02fc-ee77-4993-bb0d-51cd0041f8d5"));

            migrationBuilder.AddColumn<string>(
                name: "CompanyId",
                table: "Products",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "15ff443a-63e3-4f4f-b755-238686524df9", null, "Company", "COMPANY" },
                    { "cdcbe847-27c3-4597-a218-fbc5d942fa8a", null, "Admin", "ADMIN" },
                    { "d389196b-6db1-4e30-9abd-a9d94f3ea59b", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Country", "Name", "PrimaryCity" },
                values: new object[,]
                {
                    { new Guid("012b18fd-9cc5-4a97-b873-aed693f33729"), "North Macedonia", "Čučer-Sandevo", "Čučer-Sandevo" },
                    { new Guid("038f94c3-deeb-4361-9c14-9a9d9cbd49a3"), "North Macedonia", "Zrnovci", "Zrnovci" },
                    { new Guid("06af3211-3260-4aee-bbf9-3e6b090c60b1"), "North Macedonia", "Sveti Nikole", "Sveti Nikole" },
                    { new Guid("0a6e9ecd-af14-4a33-ade3-627e95cf22b3"), "North Macedonia", "Skopje", "Skopje" },
                    { new Guid("0c208426-defb-47f5-8db4-9ff092533f7b"), "North Macedonia", "Rostuša", "Mavrovo i Rostuše" },
                    { new Guid("0c71935c-dfb0-4a37-959d-fc67c53627a4"), "North Macedonia", "Centar Župa", "Centar Župa" },
                    { new Guid("10b6eacd-16c4-454b-97bf-1ecf105064e6"), "North Macedonia", "Star Dojran", "Dojran" },
                    { new Guid("1299904c-5e69-453c-8456-be25e77951cf"), "North Macedonia", "Aračinovo", "Aračinovo" },
                    { new Guid("13d70324-a63b-4dec-9482-21f44434aad7"), "North Macedonia", "Tetovo", "Tetovo" },
                    { new Guid("1950c9f0-8d68-4e88-8ce1-04b631c8131e"), "North Macedonia", "Ohrid", "Ohrid" },
                    { new Guid("1c583e8a-f6bd-4724-94c6-5bed2b64d135"), "North Macedonia", "Zelenikovo", "Zelenikovo" },
                    { new Guid("1c82dd21-c83e-4e05-a6fb-abcb774d26d6"), "North Macedonia", "Vrapčište", "Vrapčište" },
                    { new Guid("1c8d1422-b005-4309-83d8-5cdaef75db1f"), "North Macedonia", "Kumanovo", "Kumanovo" },
                    { new Guid("1dac3a79-ed4d-4611-933a-df86106b7b5a"), "North Macedonia", "Debar", "Debar" },
                    { new Guid("1dff2c02-2621-4c33-9ae0-295f07c626f4"), "North Macedonia", "Gevgelija", "Gevgelija" },
                    { new Guid("2616f44f-8957-447b-8ccc-507747ecb21e"), "North Macedonia", "Veles", "Veles" },
                    { new Guid("281ea15b-379a-4644-8a14-4ede52b9e76f"), "North Macedonia", "Rašče", "Skopje" },
                    { new Guid("2e568f34-769b-469c-ad25-a6262f6e2175"), "North Macedonia", "Strumica", "Strumica" },
                    { new Guid("30f08233-bf0c-470a-ab28-1c549894c186"), "North Macedonia", "Dolneni", "Dolneni" },
                    { new Guid("357fd985-fccb-4038-8095-cef670e06874"), "North Macedonia", "Kočani", "Kočani" },
                    { new Guid("3ad7e606-0abe-4859-a13b-5604fefacbe7"), "North Macedonia", "Berovo", "Berovo" },
                    { new Guid("3b517a22-6be1-44a2-beba-69b9482057d5"), "North Macedonia", "Vasilevo", "Vasilevo" },
                    { new Guid("3c79e233-8fb3-4f8c-9785-30a7951e8819"), "North Macedonia", "Resen", "Resen" },
                    { new Guid("3df94642-ea49-4f50-9379-eecf233b8822"), "North Macedonia", "Radoviš", "Radoviš" },
                    { new Guid("5241b43e-db08-4857-bea5-d5a2ba6b901b"), "North Macedonia", "Želino", "Želino" },
                    { new Guid("5510631a-2301-4a29-8622-2d9d84da18e3"), "North Macedonia", "Probištip", "Probištip" },
                    { new Guid("58dae023-8cfb-4870-8e64-1b7119520d3b"), "North Macedonia", "Rankovce", "Rankovce" },
                    { new Guid("5d153229-87cd-41b8-b206-1fc7d99a1ac6"), "North Macedonia", "Staro Nagoričane", "Staro Nagoričane" },
                    { new Guid("5e539e6e-8ec3-44ba-aa1a-2e29d829132f"), "North Macedonia", "Obleševo", "Češinovo-Obleševo" },
                    { new Guid("6a9a73f3-17bd-425d-ac2f-82b24e5a0977"), "North Macedonia", "Demir Hisar", "Demir Hisar" },
                    { new Guid("6b62eb47-15de-48bd-9d0b-42fa439b8522"), "North Macedonia", "Kičevo", "Kičevo" },
                    { new Guid("6bbf616c-19b5-45e7-aac0-88fd7d071338"), "North Macedonia", "Ilinden", "Ilinden" },
                    { new Guid("6ed87d88-25b3-4d28-91cf-a8706be9e26a"), "North Macedonia", "Bosilovo", "Bosilovo" },
                    { new Guid("71e6ed3f-1324-4dff-8586-4145ef916f9e"), "North Macedonia", "Brvenica", "Brvenica" },
                    { new Guid("7fa38cfc-10fd-4f46-a829-3fa825fa0b88"), "North Macedonia", "Bitola", "Bitola" },
                    { new Guid("8a4641a4-5512-492b-a7a5-5b5657e04fcc"), "North Macedonia", "Belčišta", "Debarca" },
                    { new Guid("8a89a979-7c71-40be-bee6-d454038d7d46"), "North Macedonia", "Lipkovo", "Lipkovo" },
                    { new Guid("8bfeb7a7-3642-4418-aff5-42beeaf381cb"), "North Macedonia", "Štip", "Štip" },
                    { new Guid("925bdb90-1222-46ce-ab36-d00836c508da"), "North Macedonia", "Mogila", "Mogila" },
                    { new Guid("932d71c5-d7dc-4973-9925-ba8b0d2e2b51"), "North Macedonia", "Konče", "Konče" },
                    { new Guid("95be4309-1a08-495a-a0fa-45c2bb5b5779"), "North Macedonia", "Demir Kapija", "Demir Kapija" },
                    { new Guid("98e7b36e-f174-4f67-8144-36dacbef5d99"), "North Macedonia", "Pehčevo", "Pehčevo" },
                    { new Guid("9a8fbfa6-facf-40b7-82fe-c1725692c16e"), "North Macedonia", "Krivogaštani", "Krivogaštani" },
                    { new Guid("a2950902-dcf1-47ae-a5ee-95be7aceb94a"), "North Macedonia", "Kavadarci", "Kavadarci" },
                    { new Guid("a4db7d57-6e83-4bcb-8c9c-b0a2eef7ff40"), "North Macedonia", "Lozovo", "Lozovo" },
                    { new Guid("a5f2917a-1419-45e8-ba8f-2776914e88f6"), "North Macedonia", "Kratovo", "Kratovo" },
                    { new Guid("a703041c-26c5-4923-b2b2-a3a46b4e1e35"), "North Macedonia", "Novo Selo", "Novo Selo" },
                    { new Guid("aa37e904-eea2-4d1b-8273-b700c849e1a5"), "North Macedonia", "Kriva Palanka", "Kriva Palanka" },
                    { new Guid("adc4f992-120c-4ad3-9695-07019105b186"), "North Macedonia", "Gostivar", "Gostivar" },
                    { new Guid("ae667675-aaee-4df4-8ca1-9f3d0e7c3eb9"), "North Macedonia", "Rosoman", "Rosoman" },
                    { new Guid("b620ece8-4129-4d23-aacf-9e0340538e9d"), "North Macedonia", "Kučevište", "Čučer-Sandevo" },
                    { new Guid("bc7af0f4-49a0-4087-a9d0-6b99726b58f8"), "North Macedonia", "Struga", "Struga" },
                    { new Guid("bd256804-c174-4971-bd1f-f1bb96acf1a6"), "North Macedonia", "Sopište", "Sopište" },
                    { new Guid("bd581613-ea4f-48c4-944f-e8c1b0718432"), "North Macedonia", "Makedonski Brod", "Makedonski Brod" },
                    { new Guid("be6a3c60-32b9-4eaf-a3b9-d9a5b26d740f"), "North Macedonia", "Valandovo", "Valandovo" },
                    { new Guid("c1ae4f2b-c2b7-49e1-ac70-cb7e30cb94ba"), "North Macedonia", "Dračevo", "Skopje" },
                    { new Guid("c7c2ad0d-9661-4627-8ca3-2c2cc8dd759a"), "North Macedonia", "Petrovec", "Petrovec" },
                    { new Guid("c807d7d0-040d-4e31-87dc-d6fe0b262138"), "North Macedonia", "Delčevo", "Delčevo" },
                    { new Guid("caac63b1-9c88-43df-860e-a9cdda34e3a7"), "North Macedonia", "Tearce", "Tearce" },
                    { new Guid("cdd4d7f4-5181-4272-b05f-77bf4917b496"), "North Macedonia", "Karbinci", "Karbinci" },
                    { new Guid("d0205a40-4af6-425a-adbe-d2fc7daff490"), "North Macedonia", "Kruševo", "Kruševo" },
                    { new Guid("d6f81670-ffe7-47f8-ae98-7f95a2735713"), "North Macedonia", "Plasnica", "Plasnica" },
                    { new Guid("da6ff731-bf58-430e-a592-2b65993db473"), "North Macedonia", "Vinica", "Vinica" },
                    { new Guid("daacb903-6984-43be-af93-017e5d1a9f34"), "North Macedonia", "Čegrane", "Gostivar" },
                    { new Guid("e0187308-cc24-4404-8797-d2b51dde7fb4"), "North Macedonia", "Prilep", "Prilep" },
                    { new Guid("e064fb92-abf6-4e18-8db0-7083921a78b0"), "North Macedonia", "Gradsko", "Gradsko" },
                    { new Guid("e5509ad9-1e35-4645-b372-a26d0c70cd03"), "North Macedonia", "Jegunovce", "Jegunovce" },
                    { new Guid("e72c0ae0-7f89-4994-8d12-1d3ee3678281"), "North Macedonia", "Makedonska Kamenica", "Makedonska Kamenica" },
                    { new Guid("e78392b5-f5c7-4e3c-aa61-7c8b150a59f0"), "North Macedonia", "Novaci", "Novaci" },
                    { new Guid("eedad813-290b-448e-86bc-091479fd158d"), "North Macedonia", "Vevčani", "Vevčani" },
                    { new Guid("ef8cc750-a2a7-4ef7-96c2-cd7bdcef4dba"), "North Macedonia", "Forino", "Gostivar" },
                    { new Guid("f211b2b4-7f15-4780-98eb-269fb946857f"), "North Macedonia", "Studeničani", "Studeničani" },
                    { new Guid("f649b744-f4c1-4fa7-9259-c9c986c42c29"), "North Macedonia", "Bogovinje", "Bogovinje" },
                    { new Guid("f7cbc05d-df42-4198-9433-fdceb917fcd5"), "North Macedonia", "Negotino", "Negotino" },
                    { new Guid("fdf5316f-81c3-4ae6-bccb-d7039a057732"), "North Macedonia", "Bogdanci", "Bogdanci" }
                });

            migrationBuilder.InsertData(
                table: "MainCategories",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("35f5aaa1-4210-4c8b-bc70-ff9fba96596d"), new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(1332), "Electronics", "Electronics", new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(1346) },
                    { new Guid("4737b25e-a35b-4dc6-8a0f-49f1fc244a06"), new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(1285), "Every day house hold items", "Household Items", new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(1300) },
                    { new Guid("7ab2dd32-b776-4b9d-b358-84ed5fc3785e"), new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(1494), "Donate your food and groceries.", "Food and Groceries", new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(1504) },
                    { new Guid("addc83f6-d401-4840-91c1-fc83d3b71111"), new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(1451), "Donate your sport or fitness equipment.", "Sports of Fitness Equipment", new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(1460) },
                    { new Guid("ba7fd734-fc6e-4274-a6d2-7c434a8a21bf"), new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(1238), "Apparel and accessories", "Clothing", new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(1252) },
                    { new Guid("eb1cf234-91e0-4b1c-9b76-a8fde5aa1032"), new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(1413), "Donate your Toys and Games.", "Toys and Games", new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(1428) },
                    { new Guid("fc958eb1-e547-4895-a8e3-8076c22f4b0b"), new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(1370), "Donate your books or medias.", "Books and Media", new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(1384) }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CreatedAt", "Description", "MainCategoryId", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("00b4ee81-5f7a-47ff-b57f-5fe3ae658876"), new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(2896), "Equipment for outdoor activities", new Guid("addc83f6-d401-4840-91c1-fc83d3b71111"), "Camping & Outdoor Gear", new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(2905) },
                    { new Guid("00dc6bee-81e9-4d98-ab90-b40147faa2cd"), new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(2977), "Non-perishable food products", new Guid("7ab2dd32-b776-4b9d-b358-84ed5fc3785e"), "Non-Perishable Items", new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(2986) },
                    { new Guid("02f7883d-9707-4173-91be-c22febecd8ff"), new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(1823), "Apparel for children", new Guid("ba7fd734-fc6e-4274-a6d2-7c434a8a21bf"), "Children's Clothing", new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(1833) },
                    { new Guid("07c1d1fe-acca-41ec-8128-8691b92deaf9"), new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(2852), "Bicycles and scooters for all ages", new Guid("addc83f6-d401-4840-91c1-fc83d3b71111"), "Bicycles & Scooters", new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(2872) },
                    { new Guid("106d1157-a862-46c0-9636-67c1f688d64b"), new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(2933), "Canned food items", new Guid("7ab2dd32-b776-4b9d-b358-84ed5fc3785e"), "Canned Goods", new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(2947) },
                    { new Guid("142adc7e-fdfa-4cb1-aa75-4969bc847865"), new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(2037), "Bedding essentials", new Guid("4737b25e-a35b-4dc6-8a0f-49f1fc244a06"), "Bedding & Linens", new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(2046) },
                    { new Guid("1bb5950a-f26f-45dd-b72d-b969c3b91701"), new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(1785), "Apparel for women", new Guid("ba7fd734-fc6e-4274-a6d2-7c434a8a21bf"), "Women's Clothing", new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(1794) },
                    { new Guid("1d791d54-1193-42d1-9024-260609571c3b"), new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(1857), "Footwear for all", new Guid("ba7fd734-fc6e-4274-a6d2-7c434a8a21bf"), "Shoes & Footwear", new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(1867) },
                    { new Guid("212c48c4-03df-4db6-acdc-57fcfb250bfa"), new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(2315), "Televisions and audio equipment", new Guid("35f5aaa1-4210-4c8b-bc70-ff9fba96596d"), "TVs & Audio Systems", new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(2328) },
                    { new Guid("33613632-944f-4c7c-bf0e-0401dbc04bf3"), new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(2394), "Various magazines", new Guid("fc958eb1-e547-4895-a8e3-8076c22f4b0b"), "Magazines", new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(2408) },
                    { new Guid("3e62c841-339f-4082-b42d-dfaf3e17b854"), new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(2076), "Cleaning essentials", new Guid("4737b25e-a35b-4dc6-8a0f-49f1fc244a06"), "Cleaning Supplies", new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(2095) },
                    { new Guid("44f9e04d-1a3e-4ca7-af23-ac01ace8dc42"), new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(1747), "Apparel for men", new Guid("ba7fd734-fc6e-4274-a6d2-7c434a8a21bf"), "Men's Clothing", new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(1757) },
                    { new Guid("47c272be-1f80-44b2-aa02-43ac04337be1"), new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(2809), "Gear for various sports", new Guid("addc83f6-d401-4840-91c1-fc83d3b71111"), "Sports Gear", new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(2824) },
                    { new Guid("5ded9fec-334e-4211-a346-5f33c3970a71"), new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(1944), "Household furniture", new Guid("4737b25e-a35b-4dc6-8a0f-49f1fc244a06"), "Furniture", new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(1953) },
                    { new Guid("629868b9-e4a0-418b-9208-56cd46683391"), new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(2277), "Appliances for home use", new Guid("35f5aaa1-4210-4c8b-bc70-ff9fba96596d"), "Home Appliances", new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(2291) },
                    { new Guid("6e5325f1-496b-4f39-997a-5922221dc1f8"), new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(2162), "Computers and laptops", new Guid("35f5aaa1-4210-4c8b-bc70-ff9fba96596d"), "Computers & Laptops", new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(2167) },
                    { new Guid("7d110101-4778-4e77-af2e-aad3c9dd9002"), new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(2356), "Fiction, non-fiction, educational", new Guid("fc958eb1-e547-4895-a8e3-8076c22f4b0b"), "Books", new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(2370) },
                    { new Guid("8e4bc54f-4643-432d-8fd9-36c06d408c71"), new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(2514), "Toys for young children", new Guid("eb1cf234-91e0-4b1c-9b76-a8fde5aa1032"), "Baby & Toddler Toys", new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(2528) },
                    { new Guid("900158a2-a0a2-41ed-b2a2-9e073b52eef9"), new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(1995), "Utensils and appliances for the kitchen", new Guid("4737b25e-a35b-4dc6-8a0f-49f1fc244a06"), "Kitchenware", new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(2004) },
                    { new Guid("9727ffb5-b514-4cfa-96e4-f48a9c29eccf"), new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(2556), "Toys that promote learning", new Guid("eb1cf234-91e0-4b1c-9b76-a8fde5aa1032"), "Educational Toys", new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(2694) },
                    { new Guid("a13f6a58-724c-45df-9936-b9a49579c15e"), new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(2771), "Equipment for gym workouts", new Guid("addc83f6-d401-4840-91c1-fc83d3b71111"), "Gym Equipment", new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(2785) },
                    { new Guid("abd0e4f2-e6fd-4940-850d-1916b3df97f1"), new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(1900), "Hats, scarves, belts, etc.", new Guid("ba7fd734-fc6e-4274-a6d2-7c434a8a21bf"), "Accessories", new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(1915) },
                    { new Guid("b08facfb-014f-4eb2-a572-04fc24b4d412"), new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(2437), "Media collection", new Guid("fc958eb1-e547-4895-a8e3-8076c22f4b0b"), "CDs, DVDs, Blu-rays", new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(2446) },
                    { new Guid("dc5cecb0-98ad-4bb9-a1ed-c987f7ccd9e4"), new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(2114), "Decorative items for the home", new Guid("4737b25e-a35b-4dc6-8a0f-49f1fc244a06"), "Home Décor", new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(2128) },
                    { new Guid("e25ef894-41d3-4aae-9ca5-1a31d2f20d78"), new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(2239), "Smartphones and tablets", new Guid("35f5aaa1-4210-4c8b-bc70-ff9fba96596d"), "Mobile Phones & Tablets", new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(2249) },
                    { new Guid("e59a720e-df32-4443-9d0d-872d3f716da6"), new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(3014), "Food and formula for infants", new Guid("7ab2dd32-b776-4b9d-b358-84ed5fc3785e"), "Baby Food & Formula", new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(3028) },
                    { new Guid("fa3d2cb2-f35d-4993-9ad5-9f697facb898"), new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(2732), "Gaming systems and games", new Guid("eb1cf234-91e0-4b1c-9b76-a8fde5aa1032"), "Video Games & Consoles", new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(2747) },
                    { new Guid("fe6274ef-5496-4682-b57e-6eccbe332e60"), new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(2474), "Games for fun and challenges", new Guid("eb1cf234-91e0-4b1c-9b76-a8fde5aa1032"), "Board Games & Puzzles", new DateTime(2024, 10, 19, 15, 29, 31, 718, DateTimeKind.Utc).AddTicks(2484) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CompanyId",
                table: "Products",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_AspNetUsers_CompanyId",
                table: "Products",
                column: "CompanyId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
