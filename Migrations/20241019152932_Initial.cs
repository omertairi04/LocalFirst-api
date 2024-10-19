using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Local_Alternatives.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "MainCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    UserType = table.Column<string>(type: "character varying(13)", maxLength: 13, nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CityId = table.Column<Guid>(type: "uuid", nullable: true),
                    NormalUser_Name = table.Column<string>(type: "text", nullable: true),
                    NormalUser_Address = table.Column<string>(type: "text", nullable: true),
                    NormalUser_CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    NormalUser_UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    NormalUser_CityId = table.Column<Guid>(type: "uuid", nullable: true),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Cities_NormalUser_CityId",
                        column: x => x.NormalUser_CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    MainCategoryId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategories_MainCategories_MainCategoryId",
                        column: x => x.MainCategoryId,
                        principalTable: "MainCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    CompanyId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_AspNetUsers_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductSubCategories",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    SubCategoryId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSubCategories", x => new { x.ProductId, x.SubCategoryId });
                    table.ForeignKey(
                        name: "FK_ProductSubCategories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSubCategories_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CityId",
                table: "AspNetUsers",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_NormalUser_CityId",
                table: "AspNetUsers",
                column: "NormalUser_CityId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CompanyId",
                table: "Products",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSubCategories_SubCategoryId",
                table: "ProductSubCategories",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_MainCategoryId",
                table: "SubCategories",
                column: "MainCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ProductSubCategories");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "MainCategories");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
