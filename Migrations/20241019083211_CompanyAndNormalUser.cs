using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Local_Alternatives.Migrations
{
    /// <inheritdoc />
    public partial class CompanyAndNormalUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CityId",
                table: "AspNetUsers",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "AspNetUsers",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalUser_Address",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "NormalUser_CityId",
                table: "AspNetUsers",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NormalUser_CreatedAt",
                table: "AspNetUsers",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalUser_Name",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NormalUser_UpdatedAt",
                table: "AspNetUsers",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "AspNetUsers",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserType",
                table: "AspNetUsers",
                type: "character varying(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c9134910-8497-4516-9c71-0d3588ff5650", null, "Admin", "ADMIN" },
                    { "d7ebf2d2-986c-49e6-8de3-951a7ec62255", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Country", "Name", "PrimaryCity" },
                values: new object[,]
                {
                    { new Guid("00a5403c-82da-478e-be00-29ba57dc7a0e"), "North Macedonia", "Rosoman", "Rosoman" },
                    { new Guid("04939540-5330-4ec8-8d5d-ba96bf79cd74"), "North Macedonia", "Obleševo", "Češinovo-Obleševo" },
                    { new Guid("0e66387a-8c9d-4849-9d25-0b978941c4aa"), "North Macedonia", "Vasilevo", "Vasilevo" },
                    { new Guid("0ffe85a6-9b60-46bb-b963-e180ea322138"), "North Macedonia", "Star Dojran", "Dojran" },
                    { new Guid("13711bc3-0f27-489d-a811-a69c593540d6"), "North Macedonia", "Čegrane", "Gostivar" },
                    { new Guid("13d2520c-cf21-48a5-a61f-8671dfd9e235"), "North Macedonia", "Zrnovci", "Zrnovci" },
                    { new Guid("14d74723-6690-489f-9842-b9d184cb74e8"), "North Macedonia", "Rankovce", "Rankovce" },
                    { new Guid("18164d53-8c80-448c-a128-9c8860d643c6"), "North Macedonia", "Jegunovce", "Jegunovce" },
                    { new Guid("1f8bbf9f-e169-415f-9d96-b316e26f3407"), "North Macedonia", "Novaci", "Novaci" },
                    { new Guid("22ae938e-b539-405f-ac9d-0add66a5fe63"), "North Macedonia", "Kratovo", "Kratovo" },
                    { new Guid("24801e7d-d200-4b8b-8d3f-35531eba3dcc"), "North Macedonia", "Bitola", "Bitola" },
                    { new Guid("2974f1e7-ccbf-47f9-9e08-ac8fc9d6c1cc"), "North Macedonia", "Ilinden", "Ilinden" },
                    { new Guid("2bc55da8-a438-4abf-b202-273743a32501"), "North Macedonia", "Centar Župa", "Centar Župa" },
                    { new Guid("2ce1cd33-8bca-4862-a8fc-f28920be7be1"), "North Macedonia", "Probištip", "Probištip" },
                    { new Guid("2e5bc4be-ba9c-41d3-bbcc-c0627946f495"), "North Macedonia", "Strumica", "Strumica" },
                    { new Guid("314e258c-f0ac-40a8-b734-7b9f7d031b00"), "North Macedonia", "Ohrid", "Ohrid" },
                    { new Guid("318638e5-e022-48f4-aee8-bbc066ba3483"), "North Macedonia", "Lozovo", "Lozovo" },
                    { new Guid("37497bfa-0968-408a-93dd-2712cd75ddb8"), "North Macedonia", "Tetovo", "Tetovo" },
                    { new Guid("39359c03-0244-4bd4-8cba-3b46ce62b739"), "North Macedonia", "Aračinovo", "Aračinovo" },
                    { new Guid("39b610e9-ae48-4ff3-acc0-a37bad1c3aa7"), "North Macedonia", "Sopište", "Sopište" },
                    { new Guid("3bb24c0d-b04f-4860-a992-cdc4d8d0cf12"), "North Macedonia", "Dračevo", "Skopje" },
                    { new Guid("3c1ba78c-38de-4de2-8431-15ba434cdf01"), "North Macedonia", "Bogovinje", "Bogovinje" },
                    { new Guid("3eb033f0-7799-43e7-96ef-15305a0373f6"), "North Macedonia", "Belčišta", "Debarca" },
                    { new Guid("3eec4e7a-2a29-4e70-9794-459df4f82443"), "North Macedonia", "Krivogaštani", "Krivogaštani" },
                    { new Guid("3fd6749e-07f4-4a26-be07-187eee5eb342"), "North Macedonia", "Brvenica", "Brvenica" },
                    { new Guid("4623f541-7ac7-4566-bd89-7bea86107c41"), "North Macedonia", "Tearce", "Tearce" },
                    { new Guid("4713a201-3ea2-424c-8ae2-74cf0071dab8"), "North Macedonia", "Kriva Palanka", "Kriva Palanka" },
                    { new Guid("502a46e0-af35-4c22-8481-1dd2864265f3"), "North Macedonia", "Staro Nagoričane", "Staro Nagoričane" },
                    { new Guid("52cca0d5-f2e9-4b49-b43d-7b86f806e3fa"), "North Macedonia", "Vrapčište", "Vrapčište" },
                    { new Guid("558277cd-8994-4676-a023-f9bcbfc1aa7e"), "North Macedonia", "Čučer-Sandevo", "Čučer-Sandevo" },
                    { new Guid("5bc6ee2a-0bae-4871-8309-196ff8c839f3"), "North Macedonia", "Rašče", "Skopje" },
                    { new Guid("5c4f618b-f60f-48f4-b9ec-a55aa57afc25"), "North Macedonia", "Rostuša", "Mavrovo i Rostuše" },
                    { new Guid("5ed91275-d77d-4d98-b7f3-a1b220ac3bc3"), "North Macedonia", "Negotino", "Negotino" },
                    { new Guid("5f9115f9-f669-4f91-adf7-9c2573f0ab9f"), "North Macedonia", "Demir Kapija", "Demir Kapija" },
                    { new Guid("65b9662d-1dab-42cb-a0e8-a085ee59e201"), "North Macedonia", "Zelenikovo", "Zelenikovo" },
                    { new Guid("666fe51a-2b3b-41b4-bd4d-a71ee18591c9"), "North Macedonia", "Bosilovo", "Bosilovo" },
                    { new Guid("67e9d17c-98b2-40ab-837b-e66e1c9488d4"), "North Macedonia", "Kruševo", "Kruševo" },
                    { new Guid("69c62b4d-f886-46c1-9bf0-a0cf4c23a70b"), "North Macedonia", "Radoviš", "Radoviš" },
                    { new Guid("767d9532-8989-4787-a389-ab78bf78f22f"), "North Macedonia", "Karbinci", "Karbinci" },
                    { new Guid("81755edb-e898-4b60-8060-a890f3dd13ad"), "North Macedonia", "Vinica", "Vinica" },
                    { new Guid("8683e1dd-4979-49b3-a319-0b33b2d610e3"), "North Macedonia", "Želino", "Želino" },
                    { new Guid("898007e8-fde2-4fb4-85c7-970c91551cfd"), "North Macedonia", "Prilep", "Prilep" },
                    { new Guid("8a7b113a-ee2a-4bce-bd7d-e08e376c8481"), "North Macedonia", "Mogila", "Mogila" },
                    { new Guid("8c074d6b-ba7d-4423-a7f0-b973e6300c5a"), "North Macedonia", "Kumanovo", "Kumanovo" },
                    { new Guid("8d43ba76-a60f-49eb-84f5-4acd0d7cb84e"), "North Macedonia", "Delčevo", "Delčevo" },
                    { new Guid("92037cd3-2fa9-4adb-8c59-de32d7e5f56f"), "North Macedonia", "Skopje", "Skopje" },
                    { new Guid("931d564f-8a8a-4fb7-9ad1-5e686e8ab1b8"), "North Macedonia", "Gostivar", "Gostivar" },
                    { new Guid("97a7dd14-8ec5-4ef1-8f7a-9de65e68964d"), "North Macedonia", "Bogdanci", "Bogdanci" },
                    { new Guid("992c987a-6816-4d62-9823-4e22b82fc100"), "North Macedonia", "Studeničani", "Studeničani" },
                    { new Guid("a149d182-701c-4f22-9f4d-f60ff2c3d8c7"), "North Macedonia", "Forino", "Gostivar" },
                    { new Guid("a6065011-bbf6-4d12-baaa-6ab1efa25c8a"), "North Macedonia", "Kočani", "Kočani" },
                    { new Guid("ac3d9c31-fb81-4aa1-b662-da070299f191"), "North Macedonia", "Plasnica", "Plasnica" },
                    { new Guid("ad33a066-b51a-4592-8f4b-4d1893b2511c"), "North Macedonia", "Makedonska Kamenica", "Makedonska Kamenica" },
                    { new Guid("b4ac864e-462b-466e-bbe9-5e5b22c51aa2"), "North Macedonia", "Vevčani", "Vevčani" },
                    { new Guid("bbeb80cd-6cb9-4a0a-9c87-ec090e095e2f"), "North Macedonia", "Dolneni", "Dolneni" },
                    { new Guid("bcdca797-0f34-49f3-b152-cf6bd3519944"), "North Macedonia", "Resen", "Resen" },
                    { new Guid("c003e71d-be82-45e8-80f6-ffa0101ca66a"), "North Macedonia", "Kučevište", "Čučer-Sandevo" },
                    { new Guid("c0a19084-66be-47fd-bccf-b58775a0cccb"), "North Macedonia", "Demir Hisar", "Demir Hisar" },
                    { new Guid("c7a5735b-d8b7-4bb7-9b2b-2a86bb6fa7cc"), "North Macedonia", "Veles", "Veles" },
                    { new Guid("c7efa8e1-55f1-4ac0-91aa-47b17481567e"), "North Macedonia", "Pehčevo", "Pehčevo" },
                    { new Guid("cbe5281b-eec3-45c5-9c85-244026105e20"), "North Macedonia", "Štip", "Štip" },
                    { new Guid("ccf62cb0-07b7-4faf-aceb-3d06123d6a6b"), "North Macedonia", "Petrovec", "Petrovec" },
                    { new Guid("cea77401-2ac4-4671-b850-edf6155f8eec"), "North Macedonia", "Makedonski Brod", "Makedonski Brod" },
                    { new Guid("d091e415-7a93-4977-929d-a941caae041c"), "North Macedonia", "Gradsko", "Gradsko" },
                    { new Guid("d125f68d-9835-4de9-873b-660007eb7c6d"), "North Macedonia", "Kavadarci", "Kavadarci" },
                    { new Guid("d251b938-7336-44e0-95a8-b83bdf775ea1"), "North Macedonia", "Valandovo", "Valandovo" },
                    { new Guid("d268d48b-fe1e-4ad6-a32b-c74b7a4de17e"), "North Macedonia", "Gevgelija", "Gevgelija" },
                    { new Guid("dbf1338b-fcde-416f-b9e6-dcf823085f6d"), "North Macedonia", "Sveti Nikole", "Sveti Nikole" },
                    { new Guid("dc3c3823-2258-46dd-9a82-113e5643eaeb"), "North Macedonia", "Berovo", "Berovo" },
                    { new Guid("e775b527-c852-4d15-a9fc-4d53384fe3ca"), "North Macedonia", "Struga", "Struga" },
                    { new Guid("eeb11fc4-a614-4de4-b5d6-fb28fedb3eb6"), "North Macedonia", "Debar", "Debar" },
                    { new Guid("f13b1941-d7da-41c7-b933-bfe30471166f"), "North Macedonia", "Lipkovo", "Lipkovo" },
                    { new Guid("f1e06dbe-b719-4130-bc1b-1d2560451111"), "North Macedonia", "Konče", "Konče" },
                    { new Guid("f5f648d1-5d7b-4025-8fdf-9f2e025df19b"), "North Macedonia", "Kičevo", "Kičevo" },
                    { new Guid("fa1355c0-4518-47aa-afe8-0011d737cd0c"), "North Macedonia", "Novo Selo", "Novo Selo" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CityId",
                table: "AspNetUsers",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_NormalUser_CityId",
                table: "AspNetUsers",
                column: "NormalUser_CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Cities_CityId",
                table: "AspNetUsers",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Cities_NormalUser_CityId",
                table: "AspNetUsers",
                column: "NormalUser_CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Cities_CityId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Cities_NormalUser_CityId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CityId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_NormalUser_CityId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9134910-8497-4516-9c71-0d3588ff5650");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d7ebf2d2-986c-49e6-8de3-951a7ec62255");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("00a5403c-82da-478e-be00-29ba57dc7a0e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("04939540-5330-4ec8-8d5d-ba96bf79cd74"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0e66387a-8c9d-4849-9d25-0b978941c4aa"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0ffe85a6-9b60-46bb-b963-e180ea322138"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("13711bc3-0f27-489d-a811-a69c593540d6"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("13d2520c-cf21-48a5-a61f-8671dfd9e235"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("14d74723-6690-489f-9842-b9d184cb74e8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("18164d53-8c80-448c-a128-9c8860d643c6"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1f8bbf9f-e169-415f-9d96-b316e26f3407"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("22ae938e-b539-405f-ac9d-0add66a5fe63"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("24801e7d-d200-4b8b-8d3f-35531eba3dcc"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2974f1e7-ccbf-47f9-9e08-ac8fc9d6c1cc"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2bc55da8-a438-4abf-b202-273743a32501"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2ce1cd33-8bca-4862-a8fc-f28920be7be1"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2e5bc4be-ba9c-41d3-bbcc-c0627946f495"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("314e258c-f0ac-40a8-b734-7b9f7d031b00"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("318638e5-e022-48f4-aee8-bbc066ba3483"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("37497bfa-0968-408a-93dd-2712cd75ddb8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("39359c03-0244-4bd4-8cba-3b46ce62b739"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("39b610e9-ae48-4ff3-acc0-a37bad1c3aa7"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3bb24c0d-b04f-4860-a992-cdc4d8d0cf12"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3c1ba78c-38de-4de2-8431-15ba434cdf01"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3eb033f0-7799-43e7-96ef-15305a0373f6"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3eec4e7a-2a29-4e70-9794-459df4f82443"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3fd6749e-07f4-4a26-be07-187eee5eb342"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4623f541-7ac7-4566-bd89-7bea86107c41"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4713a201-3ea2-424c-8ae2-74cf0071dab8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("502a46e0-af35-4c22-8481-1dd2864265f3"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("52cca0d5-f2e9-4b49-b43d-7b86f806e3fa"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("558277cd-8994-4676-a023-f9bcbfc1aa7e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5bc6ee2a-0bae-4871-8309-196ff8c839f3"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5c4f618b-f60f-48f4-b9ec-a55aa57afc25"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5ed91275-d77d-4d98-b7f3-a1b220ac3bc3"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5f9115f9-f669-4f91-adf7-9c2573f0ab9f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("65b9662d-1dab-42cb-a0e8-a085ee59e201"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("666fe51a-2b3b-41b4-bd4d-a71ee18591c9"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("67e9d17c-98b2-40ab-837b-e66e1c9488d4"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("69c62b4d-f886-46c1-9bf0-a0cf4c23a70b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("767d9532-8989-4787-a389-ab78bf78f22f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("81755edb-e898-4b60-8060-a890f3dd13ad"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8683e1dd-4979-49b3-a319-0b33b2d610e3"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("898007e8-fde2-4fb4-85c7-970c91551cfd"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8a7b113a-ee2a-4bce-bd7d-e08e376c8481"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8c074d6b-ba7d-4423-a7f0-b973e6300c5a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8d43ba76-a60f-49eb-84f5-4acd0d7cb84e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("92037cd3-2fa9-4adb-8c59-de32d7e5f56f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("931d564f-8a8a-4fb7-9ad1-5e686e8ab1b8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("97a7dd14-8ec5-4ef1-8f7a-9de65e68964d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("992c987a-6816-4d62-9823-4e22b82fc100"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a149d182-701c-4f22-9f4d-f60ff2c3d8c7"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a6065011-bbf6-4d12-baaa-6ab1efa25c8a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ac3d9c31-fb81-4aa1-b662-da070299f191"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ad33a066-b51a-4592-8f4b-4d1893b2511c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b4ac864e-462b-466e-bbe9-5e5b22c51aa2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("bbeb80cd-6cb9-4a0a-9c87-ec090e095e2f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("bcdca797-0f34-49f3-b152-cf6bd3519944"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c003e71d-be82-45e8-80f6-ffa0101ca66a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c0a19084-66be-47fd-bccf-b58775a0cccb"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c7a5735b-d8b7-4bb7-9b2b-2a86bb6fa7cc"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c7efa8e1-55f1-4ac0-91aa-47b17481567e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("cbe5281b-eec3-45c5-9c85-244026105e20"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ccf62cb0-07b7-4faf-aceb-3d06123d6a6b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("cea77401-2ac4-4671-b850-edf6155f8eec"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d091e415-7a93-4977-929d-a941caae041c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d125f68d-9835-4de9-873b-660007eb7c6d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d251b938-7336-44e0-95a8-b83bdf775ea1"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d268d48b-fe1e-4ad6-a32b-c74b7a4de17e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("dbf1338b-fcde-416f-b9e6-dcf823085f6d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("dc3c3823-2258-46dd-9a82-113e5643eaeb"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e775b527-c852-4d15-a9fc-4d53384fe3ca"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("eeb11fc4-a614-4de4-b5d6-fb28fedb3eb6"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f13b1941-d7da-41c7-b933-bfe30471166f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f1e06dbe-b719-4130-bc1b-1d2560451111"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f5f648d1-5d7b-4025-8fdf-9f2e025df19b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fa1355c0-4518-47aa-afe8-0011d737cd0c"));

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NormalUser_Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NormalUser_CityId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NormalUser_CreatedAt",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NormalUser_Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NormalUser_UpdatedAt",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserType",
                table: "AspNetUsers");

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
    }
}
