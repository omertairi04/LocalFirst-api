using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Local_Alternatives.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAdminNameInCities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7312d943-52da-4df3-a261-78cee3dcbf25");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "909e1479-6647-41b4-a2d4-9609c2f7e7be");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("010ae911-76cc-4a31-87ef-c819229ee63a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("082a33af-a382-443a-9f01-4ce63b2fa710"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("086dffb8-a20d-456b-aee6-c2176114313a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0ada7797-e3df-44d8-bbc0-4a2072e9deab"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0f42bb35-f91e-48c7-a2d0-cf5ea9440400"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1ba0d928-df63-444e-86cf-d1cf059b6c47"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1df573ff-f90e-49c0-b5e4-0d4dc2852602"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1e00175d-5895-4a23-ba7c-66bba2896945"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1f7f84f2-6d76-4fbf-b1c4-95cc31102ff4"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1fe0cbc3-aaab-4831-8193-e326417e1148"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("24f2c1e9-b27c-40cf-bd97-f393892084ce"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2844b5a5-936f-4529-8e5a-290667eb7605"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2a19595a-7cb4-422d-a42d-26606239b092"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2daa1cd1-7b7f-4117-b536-d6354deb6323"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2dfef260-7d99-46f4-889c-b09cbbac5d58"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2e6609cc-175b-402c-92ca-3e6f1e6c46d6"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3985f289-6e24-4098-a1f7-dbe9171bc851"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("427e07a7-1fae-4d53-9df1-378203702fe8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("42ca0f48-ef57-48da-8e0a-14e6960631c2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("43b2ee40-2bdc-475f-b1d3-b0a65c58383a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("45bca370-7f3e-4558-8e95-01c587dd162f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("463be817-becc-4b79-a4db-7ca59826e1ee"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("51caef44-9e0c-438b-8ea6-aab3064eb9b2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5c81bfde-5a1f-4e81-92aa-897e088c2bc3"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("60aebab1-6f79-4815-a1b0-5d95214e6fb2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6325ac96-9e7f-4229-b537-3e4ce02e4d8b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("644ac88a-4cbb-4247-8c89-c695c3c0a8c6"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("64b86782-6fe2-4c02-9ad8-5449d341e106"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("661530ee-fb6f-4ae0-8a78-757e53a9d5e9"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6783123e-1891-4479-a1bd-c6fe09ad41f2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6aa71a8a-5b3b-4612-a051-ff8f3e77bf64"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("74430888-fb99-4084-81e0-0a8dd34bb63a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("74cb8d50-cd9f-4cb7-9f00-cdb896e0dbcf"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("74f2301d-6d65-4731-975a-1d759a5006d4"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("78c5c972-7281-4d57-aee2-90c51e0e594d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7dcfbb59-bbe7-4b00-b447-babdb67abbd6"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7f72204c-12e3-4dd8-9905-3448b5febede"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("82016235-d96d-407b-b8e4-c52bf2a9c86a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("847a3192-0eaa-49d8-a304-18b8224ce530"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("869e1af5-2b61-4ceb-828a-6772220cbf6e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("87e574a1-fb00-4da7-973a-deeb77035295"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8aa82800-a354-4c21-b83d-2bf12afade88"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8ccd2fc0-f051-4be4-97b8-7a96799287f2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("968cf7cc-216e-40ed-a3a9-6848b63f8c32"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9b849891-1ad0-42f9-b707-4c381029a63d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9ba57083-de70-4f6e-ab42-64819ab2f48e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a7c4cdb3-9a5d-4344-8e55-98d383096590"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("aefc1c66-aae8-499a-928f-78fc5ec72a75"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("afce181a-e86f-4676-9cd8-c419b61c19be"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b3b2dae5-ebc4-4f09-b04c-13a3e3f23c70"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b3fcaadd-dcec-4d07-9f75-7a8c7a19329b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b7338e89-daea-4670-a66f-0a44f67ce510"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b9b5c873-1c00-4d08-b69b-4ed2d5674315"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("bb5782a2-3848-498e-ba76-61d8f2b1b0b8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("bcea6451-7a6a-4bb5-90c8-5679999ce523"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("bd177857-efd3-4467-9f6e-eeeda6fa90ee"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c1bac992-7051-4174-9231-a6ebf52ed203"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c214be37-25ed-471d-8e5f-3bf6f04abee4"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c3cd95a0-d19a-4b23-a0f5-1129af5cd6a1"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c4caf395-d8b0-4cbc-b482-49086f81784e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c883a79b-bc7f-470a-b07b-0cd0c9d5a244"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("cef45d47-f9ef-4d84-a2d0-e520d76b7488"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d23c6091-f981-4499-8aaf-39d31612f753"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d393ce95-d04e-42c2-b045-a721e5da3116"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d4447a29-7efa-4fa5-9f92-9b775f2f794b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d5d8b778-7440-40f2-bf62-ba5e781a1c34"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d8616eb7-e68f-42c8-aa6f-c22f84a3697f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e16e12b0-a266-45fc-bf66-b024dd0316d0"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e8645d63-f73f-471e-b93d-a066c8b0ec27"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ef649b44-173f-450c-a469-dd67ea1ec4ae"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f194df50-539e-4c94-add0-a47f416a429e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f6392c82-e8b6-4716-8cfd-a7cdd21401f0"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fa7e44d6-fc9f-48fc-84c7-c6a08243e927"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fd0e6f7f-e395-4c31-b4e7-0d72564e2a97"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fd43a4c7-30b5-417d-930e-51de641ec69c"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b1f7bddc-6261-43a6-b1da-41639c3adb40", null, "Admin", "ADMIN" },
                    { "ec3761e4-3a56-4c78-b1f4-468e16b78671", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Country", "Name", "PrimaryCity" },
                values: new object[,]
                {
                    { new Guid("01db6b2b-4ead-45a2-841e-fa8500e0b91f"), "North Macedonia", "Debar", "Debar" },
                    { new Guid("06058a45-1488-4bc1-a2b9-348d5bba91fc"), "North Macedonia", "Rosoman", "Rosoman" },
                    { new Guid("08e312b6-aa3b-4275-9e07-4702b9dbfe39"), "North Macedonia", "Rostuša", "Mavrovo i Rostuše" },
                    { new Guid("094bc8d9-42ad-47a5-ade9-4c1af694c8e3"), "North Macedonia", "Staro Nagoričane", "Staro Nagoričane" },
                    { new Guid("0ca81654-bba1-4e4f-9a88-13d316e0612d"), "North Macedonia", "Sveti Nikole", "Sveti Nikole" },
                    { new Guid("0cef0a7a-9d3b-436c-bbd9-aff0db9f8622"), "North Macedonia", "Brvenica", "Brvenica" },
                    { new Guid("1136558d-7147-4f80-99fb-9b4ffa5bc4af"), "North Macedonia", "Karbinci", "Karbinci" },
                    { new Guid("1200cb15-e01e-4f79-916c-54c635de3b8f"), "North Macedonia", "Vinica", "Vinica" },
                    { new Guid("15c0a99e-991f-4eae-a6ae-2c14ffaef6a0"), "North Macedonia", "Zelenikovo", "Zelenikovo" },
                    { new Guid("16c03c78-5bee-486f-a64e-00413bd0032f"), "North Macedonia", "Obleševo", "Češinovo-Obleševo" },
                    { new Guid("1757bea2-9a46-4a35-8bb7-07a0b0c466da"), "North Macedonia", "Plasnica", "Plasnica" },
                    { new Guid("18dca5c1-217d-4e59-9b68-c585a7383a36"), "North Macedonia", "Studeničani", "Studeničani" },
                    { new Guid("2d1cb5fb-10c3-4cbd-87ca-002f8bb6b6ec"), "North Macedonia", "Aračinovo", "Aračinovo" },
                    { new Guid("323249c1-076d-41b0-849c-1beab37ad93b"), "North Macedonia", "Bosilovo", "Bosilovo" },
                    { new Guid("35b42f88-9578-4bf2-88d1-8eb034e1625b"), "North Macedonia", "Strumica", "Strumica" },
                    { new Guid("36929aac-831a-4b5a-ab89-4d5c800e5ce5"), "North Macedonia", "Skopje", "Skopje" },
                    { new Guid("3f21d57d-79e3-4a71-af13-1accbadbd72c"), "North Macedonia", "Bitola", "Bitola" },
                    { new Guid("44265aaa-f0ca-430c-a78a-3363e3c6b536"), "North Macedonia", "Probištip", "Probištip" },
                    { new Guid("445f42c4-5b4d-4ba4-b92e-5d51ccae1b3b"), "North Macedonia", "Sopište", "Sopište" },
                    { new Guid("4957ad68-2074-437f-a6c8-77af0a498b22"), "North Macedonia", "Kučevište", "Čučer-Sandevo" },
                    { new Guid("504d335b-05fc-415a-9704-0507ba84f096"), "North Macedonia", "Centar Župa", "Centar Župa" },
                    { new Guid("545e22d9-8a1f-4698-b86a-c8cec600072b"), "North Macedonia", "Demir Hisar", "Demir Hisar" },
                    { new Guid("54b7ea13-a74e-405e-b49e-f3751567cf1c"), "North Macedonia", "Bogovinje", "Bogovinje" },
                    { new Guid("57478d12-1ab0-4e0f-b9f0-109ea9522c57"), "North Macedonia", "Tearce", "Tearce" },
                    { new Guid("5d511c7d-2d65-459d-b2e5-86413659cf8b"), "North Macedonia", "Dolneni", "Dolneni" },
                    { new Guid("6381ff9a-0589-438a-b465-2226e96adb9c"), "North Macedonia", "Jegunovce", "Jegunovce" },
                    { new Guid("64cc4012-5303-4ea0-b181-ba3390de4efb"), "North Macedonia", "Gostivar", "Gostivar" },
                    { new Guid("6a9e0f35-c8a5-455a-a0e5-19e5523c3446"), "North Macedonia", "Struga", "Struga" },
                    { new Guid("6ab504a5-dc28-4623-82a1-12228f8558c8"), "North Macedonia", "Kriva Palanka", "Kriva Palanka" },
                    { new Guid("71639434-30a7-4891-a9c5-1ca09f01fadf"), "North Macedonia", "Rankovce", "Rankovce" },
                    { new Guid("74ec7029-2b38-4915-80b7-6eaadbb4001b"), "North Macedonia", "Kičevo", "Kičevo" },
                    { new Guid("75127b32-4fd6-4b65-903e-9e2a208c77bc"), "North Macedonia", "Kratovo", "Kratovo" },
                    { new Guid("7ab1d1e4-a48d-4102-b7ac-510d79081bc2"), "North Macedonia", "Bogdanci", "Bogdanci" },
                    { new Guid("7e1f7eb0-5e73-4cf4-bd5b-49d57ebf4d2c"), "North Macedonia", "Ilinden", "Ilinden" },
                    { new Guid("7f918679-2d71-4ee6-9097-372b9f5565c7"), "North Macedonia", "Forino", "Gostivar" },
                    { new Guid("80eeef6a-84d1-4778-919f-a2f0f64396f8"), "North Macedonia", "Novo Selo", "Novo Selo" },
                    { new Guid("826ad9fd-7160-4095-a6f6-5ae938a737a2"), "North Macedonia", "Demir Kapija", "Demir Kapija" },
                    { new Guid("82cd13d7-2f9b-49a4-8e5a-36903ddf19fe"), "North Macedonia", "Pehčevo", "Pehčevo" },
                    { new Guid("83499b53-0745-40cd-9b71-1f431e7eaafa"), "North Macedonia", "Želino", "Želino" },
                    { new Guid("89774a08-2224-4e9a-9dfc-063ff8246dca"), "North Macedonia", "Gevgelija", "Gevgelija" },
                    { new Guid("8b4c5fe3-e058-4cb5-a3ea-b3fd8b7d27d5"), "North Macedonia", "Belčišta", "Debarca" },
                    { new Guid("8cacabdb-0d68-4f3e-8e84-e2d21b0da027"), "North Macedonia", "Krivogaštani", "Krivogaštani" },
                    { new Guid("9008eccc-3cc4-4a64-8d52-4219df6597f0"), "North Macedonia", "Lipkovo", "Lipkovo" },
                    { new Guid("935a69b3-5642-4b08-9071-b7de075af2d2"), "North Macedonia", "Valandovo", "Valandovo" },
                    { new Guid("952dc4ed-dff2-48d9-9566-f98655dbef6d"), "North Macedonia", "Novaci", "Novaci" },
                    { new Guid("95e35184-9ca2-4b7c-ad67-6a894af2325a"), "North Macedonia", "Star Dojran", "Dojran" },
                    { new Guid("a4fcca59-bc22-4f0e-9afd-59445d76e16a"), "North Macedonia", "Tetovo", "Tetovo" },
                    { new Guid("b29c1368-2309-4e5f-9905-aa47ca33cbf9"), "North Macedonia", "Vasilevo", "Vasilevo" },
                    { new Guid("b2bd7f48-fbbb-415f-957c-0655df069dda"), "North Macedonia", "Makedonska Kamenica", "Makedonska Kamenica" },
                    { new Guid("b40d8953-ac6e-4bb3-b596-a4588e10f5fd"), "North Macedonia", "Čegrane", "Gostivar" },
                    { new Guid("b921f368-75f1-40a2-b871-6c1987d9e7f8"), "North Macedonia", "Radoviš", "Radoviš" },
                    { new Guid("c0133bb6-f555-4f81-9380-0e5d3b8bddda"), "North Macedonia", "Prilep", "Prilep" },
                    { new Guid("c018cc3f-4039-4fb9-a01a-1c535da20ad8"), "North Macedonia", "Delčevo", "Delčevo" },
                    { new Guid("c36d8b9a-13aa-4d04-b012-3819893e4c6a"), "North Macedonia", "Berovo", "Berovo" },
                    { new Guid("ce30546f-f7c7-43aa-bf30-be90ca48e9bb"), "North Macedonia", "Mogila", "Mogila" },
                    { new Guid("d0641764-c25c-4ad4-a413-a28410540ac3"), "North Macedonia", "Ohrid", "Ohrid" },
                    { new Guid("d17609c5-cdd4-4ada-92c6-82f8e496fd69"), "North Macedonia", "Veles", "Veles" },
                    { new Guid("d2374a19-0fe3-4c99-89ae-dfa4188d8ddd"), "North Macedonia", "Lozovo", "Lozovo" },
                    { new Guid("d2ef6263-250e-47d4-b936-6965b454c488"), "North Macedonia", "Negotino", "Negotino" },
                    { new Guid("d37e0327-5d4c-4593-97fd-c60ad6fcdc9d"), "North Macedonia", "Štip", "Štip" },
                    { new Guid("d4bb3161-5142-49cf-be4c-2bbeb0785513"), "North Macedonia", "Rašče", "Skopje" },
                    { new Guid("d5d5fcb4-81e2-49ef-9053-b9dbc4d14cfa"), "North Macedonia", "Kumanovo", "Kumanovo" },
                    { new Guid("d7f8341a-f4ef-4e18-81ee-bbd17bff8f20"), "North Macedonia", "Čučer-Sandevo", "Čučer-Sandevo" },
                    { new Guid("d8b82464-7905-43e8-bac4-e8fe9e1f3426"), "North Macedonia", "Resen", "Resen" },
                    { new Guid("dec7b1a6-6743-4594-ab88-c96c4c9424d0"), "North Macedonia", "Konče", "Konče" },
                    { new Guid("df9a92cd-a462-48ef-9fcc-05e4684b98a2"), "North Macedonia", "Gradsko", "Gradsko" },
                    { new Guid("e9e2d2ed-6f5e-4943-8122-011abbc9afc2"), "North Macedonia", "Vevčani", "Vevčani" },
                    { new Guid("ea809681-337c-492e-a687-f0ebb83a98d5"), "North Macedonia", "Kruševo", "Kruševo" },
                    { new Guid("ef027b8b-643f-4997-bfa0-9254f137d6f2"), "North Macedonia", "Makedonski Brod", "Makedonski Brod" },
                    { new Guid("f0ce2eea-0575-40cc-a0a6-dcad98834dea"), "North Macedonia", "Vrapčište", "Vrapčište" },
                    { new Guid("f6499c67-c0ff-4787-8310-f1b25367a2ef"), "North Macedonia", "Kočani", "Kočani" },
                    { new Guid("f6c8c45a-6354-450e-8188-135135abc7b3"), "North Macedonia", "Petrovec", "Petrovec" },
                    { new Guid("fc74677f-f619-4af6-b531-c1f019b9382c"), "North Macedonia", "Dračevo", "Skopje" },
                    { new Guid("fe88c448-2cb8-4189-a733-8ba487447dcb"), "North Macedonia", "Kavadarci", "Kavadarci" },
                    { new Guid("ffe04b48-da69-4b88-a3bf-7af1d82da5a9"), "North Macedonia", "Zrnovci", "Zrnovci" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1f7bddc-6261-43a6-b1da-41639c3adb40");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec3761e4-3a56-4c78-b1f4-468e16b78671");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("01db6b2b-4ead-45a2-841e-fa8500e0b91f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("06058a45-1488-4bc1-a2b9-348d5bba91fc"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("08e312b6-aa3b-4275-9e07-4702b9dbfe39"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("094bc8d9-42ad-47a5-ade9-4c1af694c8e3"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0ca81654-bba1-4e4f-9a88-13d316e0612d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0cef0a7a-9d3b-436c-bbd9-aff0db9f8622"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1136558d-7147-4f80-99fb-9b4ffa5bc4af"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1200cb15-e01e-4f79-916c-54c635de3b8f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("15c0a99e-991f-4eae-a6ae-2c14ffaef6a0"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("16c03c78-5bee-486f-a64e-00413bd0032f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1757bea2-9a46-4a35-8bb7-07a0b0c466da"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("18dca5c1-217d-4e59-9b68-c585a7383a36"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2d1cb5fb-10c3-4cbd-87ca-002f8bb6b6ec"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("323249c1-076d-41b0-849c-1beab37ad93b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("35b42f88-9578-4bf2-88d1-8eb034e1625b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("36929aac-831a-4b5a-ab89-4d5c800e5ce5"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3f21d57d-79e3-4a71-af13-1accbadbd72c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("44265aaa-f0ca-430c-a78a-3363e3c6b536"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("445f42c4-5b4d-4ba4-b92e-5d51ccae1b3b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4957ad68-2074-437f-a6c8-77af0a498b22"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("504d335b-05fc-415a-9704-0507ba84f096"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("545e22d9-8a1f-4698-b86a-c8cec600072b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("54b7ea13-a74e-405e-b49e-f3751567cf1c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("57478d12-1ab0-4e0f-b9f0-109ea9522c57"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5d511c7d-2d65-459d-b2e5-86413659cf8b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6381ff9a-0589-438a-b465-2226e96adb9c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("64cc4012-5303-4ea0-b181-ba3390de4efb"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6a9e0f35-c8a5-455a-a0e5-19e5523c3446"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6ab504a5-dc28-4623-82a1-12228f8558c8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("71639434-30a7-4891-a9c5-1ca09f01fadf"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("74ec7029-2b38-4915-80b7-6eaadbb4001b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("75127b32-4fd6-4b65-903e-9e2a208c77bc"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7ab1d1e4-a48d-4102-b7ac-510d79081bc2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7e1f7eb0-5e73-4cf4-bd5b-49d57ebf4d2c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7f918679-2d71-4ee6-9097-372b9f5565c7"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("80eeef6a-84d1-4778-919f-a2f0f64396f8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("826ad9fd-7160-4095-a6f6-5ae938a737a2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("82cd13d7-2f9b-49a4-8e5a-36903ddf19fe"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("83499b53-0745-40cd-9b71-1f431e7eaafa"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("89774a08-2224-4e9a-9dfc-063ff8246dca"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8b4c5fe3-e058-4cb5-a3ea-b3fd8b7d27d5"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8cacabdb-0d68-4f3e-8e84-e2d21b0da027"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9008eccc-3cc4-4a64-8d52-4219df6597f0"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("935a69b3-5642-4b08-9071-b7de075af2d2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("952dc4ed-dff2-48d9-9566-f98655dbef6d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("95e35184-9ca2-4b7c-ad67-6a894af2325a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a4fcca59-bc22-4f0e-9afd-59445d76e16a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b29c1368-2309-4e5f-9905-aa47ca33cbf9"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b2bd7f48-fbbb-415f-957c-0655df069dda"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b40d8953-ac6e-4bb3-b596-a4588e10f5fd"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b921f368-75f1-40a2-b871-6c1987d9e7f8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c0133bb6-f555-4f81-9380-0e5d3b8bddda"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c018cc3f-4039-4fb9-a01a-1c535da20ad8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c36d8b9a-13aa-4d04-b012-3819893e4c6a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ce30546f-f7c7-43aa-bf30-be90ca48e9bb"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d0641764-c25c-4ad4-a413-a28410540ac3"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d17609c5-cdd4-4ada-92c6-82f8e496fd69"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d2374a19-0fe3-4c99-89ae-dfa4188d8ddd"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d2ef6263-250e-47d4-b936-6965b454c488"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d37e0327-5d4c-4593-97fd-c60ad6fcdc9d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d4bb3161-5142-49cf-be4c-2bbeb0785513"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d5d5fcb4-81e2-49ef-9053-b9dbc4d14cfa"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d7f8341a-f4ef-4e18-81ee-bbd17bff8f20"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d8b82464-7905-43e8-bac4-e8fe9e1f3426"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("dec7b1a6-6743-4594-ab88-c96c4c9424d0"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("df9a92cd-a462-48ef-9fcc-05e4684b98a2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e9e2d2ed-6f5e-4943-8122-011abbc9afc2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ea809681-337c-492e-a687-f0ebb83a98d5"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ef027b8b-643f-4997-bfa0-9254f137d6f2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f0ce2eea-0575-40cc-a0a6-dcad98834dea"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f6499c67-c0ff-4787-8310-f1b25367a2ef"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f6c8c45a-6354-450e-8188-135135abc7b3"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fc74677f-f619-4af6-b531-c1f019b9382c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fe88c448-2cb8-4189-a733-8ba487447dcb"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ffe04b48-da69-4b88-a3bf-7af1d82da5a9"));

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
    }
}
