using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Local_Alternatives.Migrations
{
    /// <inheritdoc />
    public partial class ReturnProductHowItWas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "6230b6c8-f6eb-4a58-aaa6-6e25f34541fc", null, "Admin", "ADMIN" },
                    { "77ff9c52-c74d-478b-bbd1-44781a746d18", null, "Company", "COMPANY" },
                    { "8a2f2b92-f31e-4639-98fc-38ef6a2984d8", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Country", "Name", "PrimaryCity" },
                values: new object[,]
                {
                    { new Guid("02417e54-4e5c-4c30-8749-a7421670a0a0"), "North Macedonia", "Petrovec", "Petrovec" },
                    { new Guid("0becfe4a-048a-4230-bd3d-a2620f1ce537"), "North Macedonia", "Plasnica", "Plasnica" },
                    { new Guid("10f34136-6c8d-4110-b4c4-6f56f00c62a2"), "North Macedonia", "Ohrid", "Ohrid" },
                    { new Guid("1845b229-848b-40bd-9c48-3ff8f9a0ea53"), "North Macedonia", "Veles", "Veles" },
                    { new Guid("1ab428e7-55be-4552-8b17-87bf7595b5bd"), "North Macedonia", "Tetovo", "Tetovo" },
                    { new Guid("1ac61cc7-3657-4785-96af-26002df6ce48"), "North Macedonia", "Dračevo", "Skopje" },
                    { new Guid("2010d95e-3171-444c-ad27-dcde1f8c5e4c"), "North Macedonia", "Bitola", "Bitola" },
                    { new Guid("209b4be0-7e5a-409e-a5f0-c9de200983d7"), "North Macedonia", "Debar", "Debar" },
                    { new Guid("2301af82-668d-4864-a7e4-056b73d37254"), "North Macedonia", "Zelenikovo", "Zelenikovo" },
                    { new Guid("254206b0-e9e6-41ea-bb3f-1600f68a6bca"), "North Macedonia", "Skopje", "Skopje" },
                    { new Guid("2721a9c2-93d3-4cdc-869f-3ad96f0a788e"), "North Macedonia", "Vrapčište", "Vrapčište" },
                    { new Guid("285e2d08-3d0e-4823-9630-1e45098fd781"), "North Macedonia", "Makedonski Brod", "Makedonski Brod" },
                    { new Guid("2bd99321-295f-4c09-9325-b37f4c9503a3"), "North Macedonia", "Delčevo", "Delčevo" },
                    { new Guid("2c6d70e3-af1e-4056-acec-19a68f12d5ff"), "North Macedonia", "Kumanovo", "Kumanovo" },
                    { new Guid("2cde82aa-bdc7-40a2-ab54-4bfc79d1db65"), "North Macedonia", "Makedonska Kamenica", "Makedonska Kamenica" },
                    { new Guid("2e7a0ff0-b6aa-47ed-9ee5-5c1c8bc5f7b4"), "North Macedonia", "Mogila", "Mogila" },
                    { new Guid("322c30ab-cf67-4220-b042-b5d013b8c41a"), "North Macedonia", "Gevgelija", "Gevgelija" },
                    { new Guid("3262a072-c07a-4ac3-b012-2dbdaff1c810"), "North Macedonia", "Star Dojran", "Dojran" },
                    { new Guid("32fee302-d847-44ce-862a-47876b54770b"), "North Macedonia", "Konče", "Konče" },
                    { new Guid("3a4e4f4e-fdc3-4ae4-bfa7-62737454aad3"), "North Macedonia", "Kriva Palanka", "Kriva Palanka" },
                    { new Guid("3b94f5c5-cfc7-420b-93c5-4b77961b6f5e"), "North Macedonia", "Valandovo", "Valandovo" },
                    { new Guid("3bc3a162-ef8f-4d7c-8c8c-e9a209d942bc"), "North Macedonia", "Tearce", "Tearce" },
                    { new Guid("45a80f61-8637-4764-9185-d318c92ba116"), "North Macedonia", "Sopište", "Sopište" },
                    { new Guid("47b68a9d-0ad2-43c9-bfa8-99fd1d44b1d1"), "North Macedonia", "Novo Selo", "Novo Selo" },
                    { new Guid("49377475-f76e-4a47-a917-1b2a243157ad"), "North Macedonia", "Bosilovo", "Bosilovo" },
                    { new Guid("49c7b320-56f6-49e3-b9ac-1e8e050247d2"), "North Macedonia", "Novaci", "Novaci" },
                    { new Guid("4dae656c-d39e-4202-b7d8-bcf5300b84dc"), "North Macedonia", "Probištip", "Probištip" },
                    { new Guid("4edeebac-4a78-48c6-b519-34f0e4cadc88"), "North Macedonia", "Sveti Nikole", "Sveti Nikole" },
                    { new Guid("5124b36a-54ad-478d-9c35-98269580c9a2"), "North Macedonia", "Belčišta", "Debarca" },
                    { new Guid("579b4e4c-825d-4720-957e-1ce164b290c1"), "North Macedonia", "Aračinovo", "Aračinovo" },
                    { new Guid("5b56c27f-4d29-4a66-b61b-6155ca2acbe1"), "North Macedonia", "Gradsko", "Gradsko" },
                    { new Guid("5e901c61-9c43-489b-ba8e-d34c24850250"), "North Macedonia", "Berovo", "Berovo" },
                    { new Guid("61381547-93cb-4bbf-b25b-abc629a07ad3"), "North Macedonia", "Struga", "Struga" },
                    { new Guid("633cdd96-a7d2-4f77-be78-57481933820a"), "North Macedonia", "Kavadarci", "Kavadarci" },
                    { new Guid("67991323-9cfd-4bfe-a49c-27bde6bdf3da"), "North Macedonia", "Forino", "Gostivar" },
                    { new Guid("83fd615d-e837-4d12-a141-efb6c96c473a"), "North Macedonia", "Želino", "Želino" },
                    { new Guid("877efe8d-0486-4fbf-b5b3-1d4fa9abf7d6"), "North Macedonia", "Kičevo", "Kičevo" },
                    { new Guid("89644846-8e41-4046-98ac-9e368522234e"), "North Macedonia", "Kruševo", "Kruševo" },
                    { new Guid("8bfac742-3f46-4f8a-a73f-9bdd50fcc8c0"), "North Macedonia", "Kočani", "Kočani" },
                    { new Guid("979250ce-85d7-4511-be28-5950526e39e2"), "North Macedonia", "Gostivar", "Gostivar" },
                    { new Guid("99e09222-0ac4-4ec7-9aa0-aab628064587"), "North Macedonia", "Centar Župa", "Centar Župa" },
                    { new Guid("9a5f6153-b234-4a05-aaeb-b5460e8baca4"), "North Macedonia", "Pehčevo", "Pehčevo" },
                    { new Guid("9ca4e646-dc7c-4cef-9910-9c41d2d24472"), "North Macedonia", "Vevčani", "Vevčani" },
                    { new Guid("9d0e0bd8-180d-4368-a7b8-3f3875397418"), "North Macedonia", "Jegunovce", "Jegunovce" },
                    { new Guid("9eea8438-bc0b-4249-8ba6-2ceb79684f96"), "North Macedonia", "Čučer-Sandevo", "Čučer-Sandevo" },
                    { new Guid("9f4b6684-dcb1-4fac-ad54-c5db8a648c7b"), "North Macedonia", "Čegrane", "Gostivar" },
                    { new Guid("a70b15e8-28f2-49d8-8285-0525d76fe5d5"), "North Macedonia", "Studeničani", "Studeničani" },
                    { new Guid("a775acdd-5ff8-4d49-aa35-5dc2cf28395f"), "North Macedonia", "Radoviš", "Radoviš" },
                    { new Guid("a818d228-90b6-4693-a270-a695864fe13d"), "North Macedonia", "Demir Kapija", "Demir Kapija" },
                    { new Guid("ac2829bf-2fc3-4fef-bcae-e115011bbe65"), "North Macedonia", "Brvenica", "Brvenica" },
                    { new Guid("ae84596b-ef67-437e-a047-25f1ed3e635f"), "North Macedonia", "Bogdanci", "Bogdanci" },
                    { new Guid("aec9b76d-bbd8-450a-b045-01e0b01def94"), "North Macedonia", "Negotino", "Negotino" },
                    { new Guid("b082744b-0d44-44ba-ad00-05a60085ba95"), "North Macedonia", "Resen", "Resen" },
                    { new Guid("b1d1b067-46d4-44b8-a31e-e094335cf81b"), "North Macedonia", "Zrnovci", "Zrnovci" },
                    { new Guid("b9becd7d-90dc-4896-b483-9b24d3d73c22"), "North Macedonia", "Rankovce", "Rankovce" },
                    { new Guid("bea5860e-241a-490e-be46-1c430f89b8b6"), "North Macedonia", "Karbinci", "Karbinci" },
                    { new Guid("c08159f1-9f24-4906-b0a6-cbc7c5df3127"), "North Macedonia", "Rostuša", "Mavrovo i Rostuše" },
                    { new Guid("c13f55e6-b0b4-46fc-a40e-71bda2def15b"), "North Macedonia", "Demir Hisar", "Demir Hisar" },
                    { new Guid("c20ca113-c854-4375-b7a1-ca6919258c74"), "North Macedonia", "Strumica", "Strumica" },
                    { new Guid("c9532d3f-e9a6-4451-878f-3e70d5d1fdbf"), "North Macedonia", "Kratovo", "Kratovo" },
                    { new Guid("c9785c79-cc9d-468a-8358-b94b667f67ff"), "North Macedonia", "Štip", "Štip" },
                    { new Guid("cafc1dfe-34ed-4e56-8c81-732ade27b789"), "North Macedonia", "Rosoman", "Rosoman" },
                    { new Guid("ce9194d2-ab84-4258-8308-0a1807deb563"), "North Macedonia", "Staro Nagoričane", "Staro Nagoričane" },
                    { new Guid("ceab29e5-8d96-4c8c-b8e6-7e4d6e858ae8"), "North Macedonia", "Krivogaštani", "Krivogaštani" },
                    { new Guid("cf5593e6-99dc-4c60-a957-db69b1ee3bbc"), "North Macedonia", "Vinica", "Vinica" },
                    { new Guid("d7b3ae9b-a304-410b-abd1-3a0618e29a92"), "North Macedonia", "Bogovinje", "Bogovinje" },
                    { new Guid("eb54ccd9-4d24-49ef-a09a-ee4f4f711526"), "North Macedonia", "Kučevište", "Čučer-Sandevo" },
                    { new Guid("ebd6581a-1986-4115-a5e2-c87d74442bec"), "North Macedonia", "Lozovo", "Lozovo" },
                    { new Guid("ec643da7-8b9d-4b6a-a086-4ec0cef219be"), "North Macedonia", "Obleševo", "Češinovo-Obleševo" },
                    { new Guid("ed37e295-3822-4171-958b-fe7c8d47c318"), "North Macedonia", "Rašče", "Skopje" },
                    { new Guid("ef05b341-6d07-4954-b089-ab4105fc3162"), "North Macedonia", "Vasilevo", "Vasilevo" },
                    { new Guid("ef4b3589-a2b5-4249-82f6-fa2807cdddd0"), "North Macedonia", "Dolneni", "Dolneni" },
                    { new Guid("ef958888-1d32-4540-a07a-5fff550a50be"), "North Macedonia", "Ilinden", "Ilinden" },
                    { new Guid("f0aeb83b-0085-4e02-8785-819d042d56f7"), "North Macedonia", "Prilep", "Prilep" },
                    { new Guid("fdbab9f0-4f38-4cb4-803f-308ace101a5a"), "North Macedonia", "Lipkovo", "Lipkovo" }
                });

            migrationBuilder.InsertData(
                table: "MainCategories",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("4e0e028f-76a3-4e7a-9846-5bce87c42005"), new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(2416), "Electronics", "Electronics", new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(2425) },
                    { new Guid("52153771-a213-4fa8-bff2-bd2a5a821f98"), new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(2453), "Donate your books or medias.", "Books and Media", new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(2467) },
                    { new Guid("60cbe962-b534-4737-9b35-cecac8c30b2c"), new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(2496), "Donate your Toys and Games.", "Toys and Games", new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(2510) },
                    { new Guid("6f322fcc-dc55-4f70-9f94-41f5e54f930e"), new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(2330), "Apparel and accessories", "Clothing", new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(2344) },
                    { new Guid("9afb2eb0-8e33-44e2-945a-700b2400de6b"), new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(2577), "Donate your food and groceries.", "Food and Groceries", new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(2591) },
                    { new Guid("ccd53bd1-3a29-4d0f-9912-98ea9788446b"), new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(2539), "Donate your sport or fitness equipment.", "Sports of Fitness Equipment", new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(2548) },
                    { new Guid("dcec7825-bd7c-485b-93d2-c266b5813543"), new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(2373), "Every day house hold items", "Household Items", new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(2382) }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CreatedAt", "Description", "MainCategoryId", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("02e5b7a1-16ef-4272-9e61-d4d8248cec4d"), new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3196), "Computers and laptops", new Guid("4e0e028f-76a3-4e7a-9846-5bce87c42005"), "Computers & Laptops", new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3211) },
                    { new Guid("057a9d66-69b2-41fb-874d-95e5408e1d80"), new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3651), "Equipment for gym workouts", new Guid("ccd53bd1-3a29-4d0f-9912-98ea9788446b"), "Gym Equipment", new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3665) },
                    { new Guid("0ac827d5-6092-47a5-9b3c-30111d141723"), new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3445), "Media collection", new Guid("52153771-a213-4fa8-bff2-bd2a5a821f98"), "CDs, DVDs, Blu-rays", new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3455) },
                    { new Guid("142f605d-fa83-40f0-ae5b-d9de5819165b"), new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3030), "Utensils and appliances for the kitchen", new Guid("dcec7825-bd7c-485b-93d2-c266b5813543"), "Kitchenware", new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3040) },
                    { new Guid("28847399-0e9b-4395-9ef4-b23627542993"), new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3402), "Various magazines", new Guid("52153771-a213-4fa8-bff2-bd2a5a821f98"), "Magazines", new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3416) },
                    { new Guid("3110ba90-e11e-4195-a18a-10c16b229cf6"), new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3154), "Decorative items for the home", new Guid("dcec7825-bd7c-485b-93d2-c266b5813543"), "Home Décor", new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3168) },
                    { new Guid("33c1d9cf-11b3-4bbb-9bf3-bde6e3a0f6f8"), new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3364), "Fiction, non-fiction, educational", new Guid("52153771-a213-4fa8-bff2-bd2a5a821f98"), "Books", new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3373) },
                    { new Guid("3d81e9ed-89c1-4d00-bb57-01c73d43b54e"), new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3526), "Toys for young children", new Guid("60cbe962-b534-4737-9b35-cecac8c30b2c"), "Baby & Toddler Toys", new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3540) },
                    { new Guid("3f4e0fc2-9287-4c9e-be60-70ab7bbed3d9"), new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(2820), "Apparel for women", new Guid("6f322fcc-dc55-4f70-9f94-41f5e54f930e"), "Women's Clothing", new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(2834) },
                    { new Guid("44a3b7e9-5d08-4edd-987e-b15fb98b19c9"), new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3736), "Bicycles and scooters for all ages", new Guid("ccd53bd1-3a29-4d0f-9912-98ea9788446b"), "Bicycles & Scooters", new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3745) },
                    { new Guid("4e9e6d5c-b04b-4cb4-b67d-260b1fd15ef2"), new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3488), "Games for fun and challenges", new Guid("60cbe962-b534-4737-9b35-cecac8c30b2c"), "Board Games & Puzzles", new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3497) },
                    { new Guid("5506cfdc-06db-48d0-b857-b381a4eea1d0"), new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3899), "Food and formula for infants", new Guid("9afb2eb0-8e33-44e2-945a-700b2400de6b"), "Baby Food & Formula", new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3914) },
                    { new Guid("58b56466-2bdd-4bee-83fd-230c9f79cd7c"), new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(2778), "Apparel for men", new Guid("6f322fcc-dc55-4f70-9f94-41f5e54f930e"), "Men's Clothing", new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(2792) },
                    { new Guid("637d7a7d-3d17-431a-ae21-6b126adba02f"), new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3240), "Smartphones and tablets", new Guid("4e0e028f-76a3-4e7a-9846-5bce87c42005"), "Mobile Phones & Tablets", new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3250) },
                    { new Guid("76942a32-cc42-4f05-84b6-d1ef35c57b9c"), new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3322), "Televisions and audio equipment", new Guid("4e0e028f-76a3-4e7a-9846-5bce87c42005"), "TVs & Audio Systems", new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3331) },
                    { new Guid("779d35c4-6285-4860-bd62-e4d59bf43f18"), new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3817), "Canned food items", new Guid("9afb2eb0-8e33-44e2-945a-700b2400de6b"), "Canned Goods", new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3831) },
                    { new Guid("7ba079c2-e674-4760-aeb2-6a59af78c2e5"), new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3569), "Toys that promote learning", new Guid("60cbe962-b534-4737-9b35-cecac8c30b2c"), "Educational Toys", new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3579) },
                    { new Guid("7be3e644-0c23-4e64-ba6c-0196481b0b98"), new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3111), "Cleaning essentials", new Guid("dcec7825-bd7c-485b-93d2-c266b5813543"), "Cleaning Supplies", new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3125) },
                    { new Guid("90d562c8-20b9-4441-8646-7bea3d5af4d4"), new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3613), "Gaming systems and games", new Guid("60cbe962-b534-4737-9b35-cecac8c30b2c"), "Video Games & Consoles", new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3622) },
                    { new Guid("952f13b5-e5d8-4eb1-abb4-554bb4e65789"), new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3279), "Appliances for home use", new Guid("4e0e028f-76a3-4e7a-9846-5bce87c42005"), "Home Appliances", new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3294) },
                    { new Guid("a4e326ad-62b2-4df1-a1a9-65177d0b8c1d"), new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(2945), "Hats, scarves, belts, etc.", new Guid("6f322fcc-dc55-4f70-9f94-41f5e54f930e"), "Accessories", new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(2960) },
                    { new Guid("aa46b6f2-a4d4-4a61-8435-582b93600798"), new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3860), "Non-perishable food products", new Guid("9afb2eb0-8e33-44e2-945a-700b2400de6b"), "Non-Perishable Items", new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3870) },
                    { new Guid("b4c88688-5d4f-444c-845a-c6aee6504d4a"), new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(2988), "Household furniture", new Guid("dcec7825-bd7c-485b-93d2-c266b5813543"), "Furniture", new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(2997) },
                    { new Guid("bacb661b-fc3a-422b-b80f-a5b48d3db413"), new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3774), "Equipment for outdoor activities", new Guid("ccd53bd1-3a29-4d0f-9912-98ea9788446b"), "Camping & Outdoor Gear", new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3789) },
                    { new Guid("baea09f4-141e-4b5e-ac15-2c007d2e251d"), new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3069), "Bedding essentials", new Guid("dcec7825-bd7c-485b-93d2-c266b5813543"), "Bedding & Linens", new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3083) },
                    { new Guid("c28de2f0-043f-467a-9fde-1acb92668b15"), new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(2906), "Footwear for all", new Guid("6f322fcc-dc55-4f70-9f94-41f5e54f930e"), "Shoes & Footwear", new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(2916) },
                    { new Guid("caa4adaa-fa5a-49b7-ae15-999f37ec6e0a"), new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(2863), "Apparel for children", new Guid("6f322fcc-dc55-4f70-9f94-41f5e54f930e"), "Children's Clothing", new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(2872) },
                    { new Guid("f05b7ce7-ee34-4638-a006-7fd320257895"), new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3693), "Gear for various sports", new Guid("ccd53bd1-3a29-4d0f-9912-98ea9788446b"), "Sports Gear", new DateTime(2024, 10, 19, 19, 41, 30, 512, DateTimeKind.Utc).AddTicks(3707) }
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: "6230b6c8-f6eb-4a58-aaa6-6e25f34541fc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77ff9c52-c74d-478b-bbd1-44781a746d18");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a2f2b92-f31e-4639-98fc-38ef6a2984d8");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("02417e54-4e5c-4c30-8749-a7421670a0a0"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0becfe4a-048a-4230-bd3d-a2620f1ce537"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("10f34136-6c8d-4110-b4c4-6f56f00c62a2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1845b229-848b-40bd-9c48-3ff8f9a0ea53"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1ab428e7-55be-4552-8b17-87bf7595b5bd"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1ac61cc7-3657-4785-96af-26002df6ce48"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2010d95e-3171-444c-ad27-dcde1f8c5e4c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("209b4be0-7e5a-409e-a5f0-c9de200983d7"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2301af82-668d-4864-a7e4-056b73d37254"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("254206b0-e9e6-41ea-bb3f-1600f68a6bca"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2721a9c2-93d3-4cdc-869f-3ad96f0a788e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("285e2d08-3d0e-4823-9630-1e45098fd781"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2bd99321-295f-4c09-9325-b37f4c9503a3"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2c6d70e3-af1e-4056-acec-19a68f12d5ff"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2cde82aa-bdc7-40a2-ab54-4bfc79d1db65"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2e7a0ff0-b6aa-47ed-9ee5-5c1c8bc5f7b4"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("322c30ab-cf67-4220-b042-b5d013b8c41a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3262a072-c07a-4ac3-b012-2dbdaff1c810"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("32fee302-d847-44ce-862a-47876b54770b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3a4e4f4e-fdc3-4ae4-bfa7-62737454aad3"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3b94f5c5-cfc7-420b-93c5-4b77961b6f5e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3bc3a162-ef8f-4d7c-8c8c-e9a209d942bc"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("45a80f61-8637-4764-9185-d318c92ba116"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("47b68a9d-0ad2-43c9-bfa8-99fd1d44b1d1"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("49377475-f76e-4a47-a917-1b2a243157ad"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("49c7b320-56f6-49e3-b9ac-1e8e050247d2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4dae656c-d39e-4202-b7d8-bcf5300b84dc"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4edeebac-4a78-48c6-b519-34f0e4cadc88"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5124b36a-54ad-478d-9c35-98269580c9a2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("579b4e4c-825d-4720-957e-1ce164b290c1"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5b56c27f-4d29-4a66-b61b-6155ca2acbe1"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5e901c61-9c43-489b-ba8e-d34c24850250"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("61381547-93cb-4bbf-b25b-abc629a07ad3"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("633cdd96-a7d2-4f77-be78-57481933820a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("67991323-9cfd-4bfe-a49c-27bde6bdf3da"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("83fd615d-e837-4d12-a141-efb6c96c473a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("877efe8d-0486-4fbf-b5b3-1d4fa9abf7d6"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("89644846-8e41-4046-98ac-9e368522234e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8bfac742-3f46-4f8a-a73f-9bdd50fcc8c0"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("979250ce-85d7-4511-be28-5950526e39e2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("99e09222-0ac4-4ec7-9aa0-aab628064587"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9a5f6153-b234-4a05-aaeb-b5460e8baca4"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9ca4e646-dc7c-4cef-9910-9c41d2d24472"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9d0e0bd8-180d-4368-a7b8-3f3875397418"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9eea8438-bc0b-4249-8ba6-2ceb79684f96"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9f4b6684-dcb1-4fac-ad54-c5db8a648c7b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a70b15e8-28f2-49d8-8285-0525d76fe5d5"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a775acdd-5ff8-4d49-aa35-5dc2cf28395f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a818d228-90b6-4693-a270-a695864fe13d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ac2829bf-2fc3-4fef-bcae-e115011bbe65"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ae84596b-ef67-437e-a047-25f1ed3e635f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("aec9b76d-bbd8-450a-b045-01e0b01def94"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b082744b-0d44-44ba-ad00-05a60085ba95"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b1d1b067-46d4-44b8-a31e-e094335cf81b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b9becd7d-90dc-4896-b483-9b24d3d73c22"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("bea5860e-241a-490e-be46-1c430f89b8b6"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c08159f1-9f24-4906-b0a6-cbc7c5df3127"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c13f55e6-b0b4-46fc-a40e-71bda2def15b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c20ca113-c854-4375-b7a1-ca6919258c74"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c9532d3f-e9a6-4451-878f-3e70d5d1fdbf"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c9785c79-cc9d-468a-8358-b94b667f67ff"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("cafc1dfe-34ed-4e56-8c81-732ade27b789"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ce9194d2-ab84-4258-8308-0a1807deb563"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ceab29e5-8d96-4c8c-b8e6-7e4d6e858ae8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("cf5593e6-99dc-4c60-a957-db69b1ee3bbc"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d7b3ae9b-a304-410b-abd1-3a0618e29a92"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("eb54ccd9-4d24-49ef-a09a-ee4f4f711526"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ebd6581a-1986-4115-a5e2-c87d74442bec"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ec643da7-8b9d-4b6a-a086-4ec0cef219be"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ed37e295-3822-4171-958b-fe7c8d47c318"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ef05b341-6d07-4954-b089-ab4105fc3162"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ef4b3589-a2b5-4249-82f6-fa2807cdddd0"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ef958888-1d32-4540-a07a-5fff550a50be"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f0aeb83b-0085-4e02-8785-819d042d56f7"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fdbab9f0-4f38-4cb4-803f-308ace101a5a"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("02e5b7a1-16ef-4272-9e61-d4d8248cec4d"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("057a9d66-69b2-41fb-874d-95e5408e1d80"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("0ac827d5-6092-47a5-9b3c-30111d141723"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("142f605d-fa83-40f0-ae5b-d9de5819165b"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("28847399-0e9b-4395-9ef4-b23627542993"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("3110ba90-e11e-4195-a18a-10c16b229cf6"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("33c1d9cf-11b3-4bbb-9bf3-bde6e3a0f6f8"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("3d81e9ed-89c1-4d00-bb57-01c73d43b54e"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("3f4e0fc2-9287-4c9e-be60-70ab7bbed3d9"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("44a3b7e9-5d08-4edd-987e-b15fb98b19c9"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("4e9e6d5c-b04b-4cb4-b67d-260b1fd15ef2"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("5506cfdc-06db-48d0-b857-b381a4eea1d0"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("58b56466-2bdd-4bee-83fd-230c9f79cd7c"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("637d7a7d-3d17-431a-ae21-6b126adba02f"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("76942a32-cc42-4f05-84b6-d1ef35c57b9c"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("779d35c4-6285-4860-bd62-e4d59bf43f18"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("7ba079c2-e674-4760-aeb2-6a59af78c2e5"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("7be3e644-0c23-4e64-ba6c-0196481b0b98"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("90d562c8-20b9-4441-8646-7bea3d5af4d4"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("952f13b5-e5d8-4eb1-abb4-554bb4e65789"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("a4e326ad-62b2-4df1-a1a9-65177d0b8c1d"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("aa46b6f2-a4d4-4a61-8435-582b93600798"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("b4c88688-5d4f-444c-845a-c6aee6504d4a"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("bacb661b-fc3a-422b-b80f-a5b48d3db413"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("baea09f4-141e-4b5e-ac15-2c007d2e251d"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("c28de2f0-043f-467a-9fde-1acb92668b15"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("caa4adaa-fa5a-49b7-ae15-999f37ec6e0a"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("f05b7ce7-ee34-4638-a006-7fd320257895"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("4e0e028f-76a3-4e7a-9846-5bce87c42005"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("52153771-a213-4fa8-bff2-bd2a5a821f98"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("60cbe962-b534-4737-9b35-cecac8c30b2c"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("6f322fcc-dc55-4f70-9f94-41f5e54f930e"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("9afb2eb0-8e33-44e2-945a-700b2400de6b"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("ccd53bd1-3a29-4d0f-9912-98ea9788446b"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("dcec7825-bd7c-485b-93d2-c266b5813543"));

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
    }
}
