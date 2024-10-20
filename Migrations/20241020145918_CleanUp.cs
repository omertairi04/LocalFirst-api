using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Local_Alternatives.Migrations
{
    /// <inheritdoc />
    public partial class CleanUp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_AspNetUsers_CompanyId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "569a6003-4d9a-4ed4-b3ee-63825510f630");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba5a5462-b652-4e42-aa0a-fab249726f07");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f98ca047-8223-45a9-8b13-e3039a3116cd");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0013bbf3-9f0c-4e8b-9e4a-022587ab7283"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("00b49928-6f8c-4a01-879d-6cdbc604227d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("01b08def-a699-4675-b8f1-e22545e33a7f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("03cd3b2b-ab40-4ed6-b6ba-77900997b59a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0b991aeb-949e-453d-8caa-82c8ec40190a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0cffc736-d211-4370-9ff3-de68bec3d4f0"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0d932ae8-8381-476d-85d0-735b31f319c3"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("16b71c93-31e0-4da6-a8ea-7e513c2b3d29"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1a63cd62-f1f7-4a18-a64a-4a25b52421a2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1c7615aa-9af3-4c1e-a100-06ea15edbd83"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1e40aeba-25ab-4665-bb79-30fe1fc51188"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1fe74dc7-76c4-412c-81df-fd7e4d45d5b3"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("289fd7f8-4012-41c0-9b77-d79a8bf6752e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("29a7acbe-80e7-4595-865f-0d5bc76ec8f3"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2b6e0ac2-1c39-47bc-ae37-c3a6fd78c825"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2bf91ed5-61b3-4977-b008-25e0c0c30749"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3d10c667-1468-4efd-bd0d-e5eec9c50e96"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3d115946-7611-43eb-8151-073f424b89dd"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3de95a7b-6bc8-4f1c-bdc1-e5146eefcc44"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4163c41d-2dc9-4d6b-bc46-440ff617ae93"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4a6698a1-62fe-477a-aea9-89cc9939ad2e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4a70b3e0-5bb7-4896-b686-201b19c3c3c6"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4aeed20a-b72b-4289-960a-334333d87a53"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4fd05833-61bb-4ee4-88cc-a36dd98dfb95"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("53facb02-381c-4581-b415-0684fa23c166"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("54f028d6-84c1-42a8-867a-6cfd3b7ea67a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5614cf41-8f25-4868-ade4-ba3d64d3577f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5811e4b5-bf53-4460-ab11-a90a60e905ab"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5aa41822-3f4e-4791-b75a-6114017b6f5c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5c2c8855-b781-40d9-81be-854fc8253164"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("604ed3c8-9d74-45ad-844e-510126629ee1"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("63a705b3-0946-421c-a027-6673d468c236"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("64f02006-6c4b-4673-a6cd-fb828cfda698"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("65281569-35cb-42dc-b55d-b9dde9f6a444"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("654eaad8-4e4c-4bfb-a005-9ad97fa7202e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6b14999e-99ed-4040-9601-fc2d5abbc884"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("70c3429f-8a59-4432-83d3-09934af7bd3e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7292e215-2c9c-4fd3-9bd5-aea18b30c9ff"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7a7d659e-c079-49b6-9a34-460b449eb7ea"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7e807b32-5dcc-49d4-a7c5-ed3b76aa7755"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("82f736da-905d-4f93-bcce-3f0bfbbff617"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("832139c2-4d94-48a5-8703-ffedb5652e90"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8f38af96-656c-42d6-83f0-58fb07037cbd"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("90be8940-56ca-4cd7-9f0e-8a8de208c677"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("90f7a44d-7565-451e-86e5-9ac56308b28c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("943f1425-9b6e-4ec4-86d6-0149b1f12587"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9764f16a-591c-47bc-b087-99e9dceb6851"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("97f1e18e-1bf0-46e4-a1b9-e1b8917a62df"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9d092d11-415b-420d-b8ae-bbab3b96e715"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("aa52b573-ee45-4ef7-8fd7-1855355e6df6"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ab15dcaa-9669-46ac-a81f-45bbfd041626"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("af1968bf-5ba6-4aa7-b19b-08c73326c364"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b1b83b85-4ffa-4b68-a155-5e1e3512f8d7"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b5388323-7c85-4a06-bfa9-a7b5e655ab73"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b6ece68d-9e6d-4733-9225-e6a220136947"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("bc8c23e3-ffb5-43f2-bbee-65909ba82391"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c1acca7c-d010-446c-b441-ff96c4e52d4c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c2a6a7e4-678a-4acc-a802-c56752c762e5"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c37e7e45-8e49-41b5-a4c7-b53c99da4399"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c7481a87-c89a-4cee-869a-faa24aaf2d07"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ca8998fe-ff94-44dd-834a-5b4316099eb2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("cb83a589-391a-48f6-b961-eded0604b2c0"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("cef42d2b-0e74-46f3-8132-800a970ca833"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d1e8e798-cc81-4013-8314-8c68f63aefc8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("da824f55-da47-40eb-beb3-b3364e163181"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("dbc56cfb-0520-4976-87ac-9de4f39086c5"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("dc887b63-6d9b-4814-b1dc-0a23c4afa0c2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e41188b1-28a7-4b77-a14c-b8700b7937e8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e888032d-cada-473d-9092-ef3e722bf16e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f64bb176-1443-420f-ae02-1fcb2f957ed1"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f87bc813-399c-4f9d-a9e0-7afe9017e681"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("faa20f22-aaf9-455c-b706-a026a4b8c46c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fb2ef433-9b6c-4da5-a88a-925db7a770d7"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fd2ddc08-65c3-4337-a45a-de72a6b84a7e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fe51dce7-51ea-482c-8566-b7a699caacc0"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("045348a0-1da3-4e25-a810-4d69cfc5d6d6"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("0c062b2f-1feb-4bc0-90c5-4ddd42d17b61"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("0f767cb3-9809-451e-a849-5fc8dea1f780"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("0f976dd8-dda7-474b-a9e3-8a474fa0b659"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("2ce1a55b-898a-473c-900c-7a8930085d45"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("2d911134-3d08-4819-b4fe-591741966754"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("3842b568-4208-44e7-a283-4fbe17785b00"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("3f27f640-6950-4d5b-a9f9-cc954753a509"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("4501be0d-a8c5-4e48-8f27-d1c18d41d5c8"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("4d4c9af7-d6c7-4f84-b5d8-57c94f87f668"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("4df02e6b-cef8-4b0f-8e3c-459ce7bf2290"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("5c10478e-3e33-40a5-9b76-3ab76e520926"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("604e69c5-b384-4795-902f-69f44a4d2a2d"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("64c28549-cbc5-4736-8e61-4fb655498145"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("6aad5578-712d-448d-9a64-69346bd36808"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("7d0cba1f-39c9-4211-9621-56ac0975e905"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("7e45a56d-8438-403d-a6b0-69e5491c0268"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("8b343a6d-e64f-4244-8126-7d1e022326a7"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("8df451b6-6e8d-4700-80c6-50a4db4657b8"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("8e81f7b7-413e-41c6-b543-44daa77ee80a"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("9669e61f-0032-4f69-8ca5-26c6d6727d25"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("9fb637ca-3f75-46a6-90e0-2192509acc9f"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("b86af2b6-9f78-484f-8dba-38b877c52eda"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("d6af5fb9-8c5d-4e84-ba1c-966c6fbe6765"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("dc690059-62e7-4dd4-9334-31bfd740896e"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("dcbeb935-42d9-4155-a7a9-cb0569abef8e"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("e4221336-7336-481c-9415-1c844cdeb0a7"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("e98b5af5-f12a-4091-81dc-825acfb27bf1"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("0d0dc453-ba0c-4432-8b07-3988c0beb653"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("30201f35-f99f-4422-adc5-4713af8c7a89"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("3c043b1b-3947-470d-8ddc-2c127de2f7b1"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("4976ca98-cb1e-4aed-b64c-8c4d42ee5bfb"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("57fcd2f6-e796-4f24-865b-d85fc43ced2e"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("b6fb6e82-9c28-48f9-aa6c-2af5c29c649f"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("ecc60cac-1ffb-4aa4-b8f7-773f0ec6a389"));

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Country", "Name", "PrimaryCity" },
                values: new object[,]
                {
                    { new Guid("00374ec8-93f0-43b6-a398-b6b56b37cc4f"), "North Macedonia", "Ohrid", "Ohrid" },
                    { new Guid("074d0772-fe70-4250-aba1-c8be9a4bec0d"), "North Macedonia", "Gostivar", "Gostivar" },
                    { new Guid("09d769d9-f2ed-4ae7-9eb0-356efaba78b5"), "North Macedonia", "Belčišta", "Debarca" },
                    { new Guid("0a06ff79-9120-47d0-bcf4-d75c690b7098"), "North Macedonia", "Vasilevo", "Vasilevo" },
                    { new Guid("0c5a6c6b-ac4d-427b-996e-c2339ebdb233"), "North Macedonia", "Bogovinje", "Bogovinje" },
                    { new Guid("0c64a7a9-1ae3-40a6-97bb-566c0cae02ca"), "North Macedonia", "Brvenica", "Brvenica" },
                    { new Guid("12f68cd4-909e-4c99-b19d-1140585d433f"), "North Macedonia", "Demir Kapija", "Demir Kapija" },
                    { new Guid("16038a7c-62b4-4b10-8ba9-eaa9353aa7ac"), "North Macedonia", "Staro Nagoričane", "Staro Nagoričane" },
                    { new Guid("162efc63-3827-4465-bec3-dc99bf4449f7"), "North Macedonia", "Dolneni", "Dolneni" },
                    { new Guid("17850ae9-8c60-4709-a904-a569447a83a0"), "North Macedonia", "Novo Selo", "Novo Selo" },
                    { new Guid("1e457d82-8cae-41b7-b47e-4f3e45a04d5b"), "North Macedonia", "Makedonska Kamenica", "Makedonska Kamenica" },
                    { new Guid("1fa2e29c-f936-476c-aac5-68b97620463f"), "North Macedonia", "Lipkovo", "Lipkovo" },
                    { new Guid("2242485b-67a6-4132-8297-27cf92d8760d"), "North Macedonia", "Novaci", "Novaci" },
                    { new Guid("23823a8b-2188-4e56-9c08-e519c79eb5a2"), "North Macedonia", "Kruševo", "Kruševo" },
                    { new Guid("242038a8-60ae-4aa4-a420-86b37329fa34"), "North Macedonia", "Rašče", "Skopje" },
                    { new Guid("27b5977c-812b-4d59-ae64-4246e84ae4ee"), "North Macedonia", "Tetovo", "Tetovo" },
                    { new Guid("2bbce22c-154f-4390-b26d-088ec107b967"), "North Macedonia", "Kriva Palanka", "Kriva Palanka" },
                    { new Guid("31785a65-39d6-424a-bb82-4370d7d04d34"), "North Macedonia", "Kavadarci", "Kavadarci" },
                    { new Guid("33da739c-4b05-4c0c-ac31-025aae7a9f55"), "North Macedonia", "Sveti Nikole", "Sveti Nikole" },
                    { new Guid("3565962c-de4c-4334-82d4-fa7fcc59d1df"), "North Macedonia", "Skopje", "Skopje" },
                    { new Guid("3bdef7aa-fcf8-44ba-887f-fb2a850fad2c"), "North Macedonia", "Delčevo", "Delčevo" },
                    { new Guid("3c4d4698-9e75-4f0e-af08-07ad96a0fadb"), "North Macedonia", "Pehčevo", "Pehčevo" },
                    { new Guid("40f015f4-7065-4053-bf2e-2c07555096e5"), "North Macedonia", "Resen", "Resen" },
                    { new Guid("43adffde-9c85-4333-b19f-436ea36dd793"), "North Macedonia", "Plasnica", "Plasnica" },
                    { new Guid("4d5ce21b-b1ae-41e1-bf94-dcbcc1da19c8"), "North Macedonia", "Aračinovo", "Aračinovo" },
                    { new Guid("561b519e-5412-422e-b518-451ecb36abd3"), "North Macedonia", "Forino", "Gostivar" },
                    { new Guid("5b22942d-51da-45fb-9c0c-898b938f9b1f"), "North Macedonia", "Radoviš", "Radoviš" },
                    { new Guid("672adc6c-d9e4-45da-8ef3-35ec0205e0e6"), "North Macedonia", "Probištip", "Probištip" },
                    { new Guid("673c91dd-153c-48f0-945e-a6a961cf0375"), "North Macedonia", "Čegrane", "Gostivar" },
                    { new Guid("6c1cc393-7da4-467f-98be-71154e0069aa"), "North Macedonia", "Lozovo", "Lozovo" },
                    { new Guid("6eb42caa-63ff-4fa2-9af8-40958c4572ea"), "North Macedonia", "Debar", "Debar" },
                    { new Guid("7ae2eacc-543a-44bb-ab7a-f031fe791533"), "North Macedonia", "Čučer-Sandevo", "Čučer-Sandevo" },
                    { new Guid("821db04e-f03d-4676-a249-2a78cb5c323b"), "North Macedonia", "Obleševo", "Češinovo-Obleševo" },
                    { new Guid("82f4c35f-5741-438e-9284-694d7364c11e"), "North Macedonia", "Kratovo", "Kratovo" },
                    { new Guid("86766fa7-93d0-4be5-adaf-586226dca823"), "North Macedonia", "Bitola", "Bitola" },
                    { new Guid("8965a620-c7e3-4076-b870-290f5d6809c6"), "North Macedonia", "Ilinden", "Ilinden" },
                    { new Guid("8e64aa7d-96dc-471d-9c44-d2afe4f5e81e"), "North Macedonia", "Valandovo", "Valandovo" },
                    { new Guid("903147b9-98fa-4267-9f73-53a82699f1c2"), "North Macedonia", "Demir Hisar", "Demir Hisar" },
                    { new Guid("91958e2b-0077-489d-a649-3e1848f1bde9"), "North Macedonia", "Prilep", "Prilep" },
                    { new Guid("93e9248d-9632-4d91-b91f-054698c6ccde"), "North Macedonia", "Bosilovo", "Bosilovo" },
                    { new Guid("978f98eb-c4fd-4a56-a454-23029d99aee5"), "North Macedonia", "Kučevište", "Čučer-Sandevo" },
                    { new Guid("9880a1bf-9881-4d18-8581-71452c3e0dfb"), "North Macedonia", "Dračevo", "Skopje" },
                    { new Guid("9ad82352-b8d6-436a-acd5-2917cd8ef22b"), "North Macedonia", "Veles", "Veles" },
                    { new Guid("9e24dec6-ac1c-41ec-856f-1008a436ea3b"), "North Macedonia", "Negotino", "Negotino" },
                    { new Guid("9effc946-a7f5-4a93-9b83-2e78151eccec"), "North Macedonia", "Mogila", "Mogila" },
                    { new Guid("a40068a2-d583-4c93-b840-30d0ca555d0a"), "North Macedonia", "Star Dojran", "Dojran" },
                    { new Guid("aa2ce173-f29d-4724-9d60-74d3a8718bf0"), "North Macedonia", "Vevčani", "Vevčani" },
                    { new Guid("aac79267-1914-4ad3-9f0d-a8358e5ea859"), "North Macedonia", "Gevgelija", "Gevgelija" },
                    { new Guid("b258d598-7447-46a3-9c54-bb784b14d2ea"), "North Macedonia", "Sopište", "Sopište" },
                    { new Guid("b4cec4d8-0967-4620-b850-b4465e3db7b6"), "North Macedonia", "Bogdanci", "Bogdanci" },
                    { new Guid("b9975e82-ec51-4292-aaed-8f8955d6b8a3"), "North Macedonia", "Želino", "Želino" },
                    { new Guid("b9ea3ef7-0632-4076-9f64-c99e985bbd7c"), "North Macedonia", "Konče", "Konče" },
                    { new Guid("babd51d8-13e0-4339-a01a-21f37f575be4"), "North Macedonia", "Rankovce", "Rankovce" },
                    { new Guid("c1553cd5-b1c6-435f-8107-d4ad8bccb1e7"), "North Macedonia", "Struga", "Struga" },
                    { new Guid("c1f7848c-faea-41c6-98e0-352c8f97b3ce"), "North Macedonia", "Strumica", "Strumica" },
                    { new Guid("c408dadf-1931-4085-9807-c4cb652054c9"), "North Macedonia", "Kičevo", "Kičevo" },
                    { new Guid("c46a07a6-f739-4c04-9c0a-fee028566f23"), "North Macedonia", "Berovo", "Berovo" },
                    { new Guid("c5929778-8fe8-48bd-bd3b-9e81fa3565d5"), "North Macedonia", "Zelenikovo", "Zelenikovo" },
                    { new Guid("c7aa4afd-99cd-46d8-92e4-429261102291"), "North Macedonia", "Jegunovce", "Jegunovce" },
                    { new Guid("cdec545e-31ef-44d4-ac6b-a6e699f5281b"), "North Macedonia", "Studeničani", "Studeničani" },
                    { new Guid("ce2fdc66-4140-47d2-a264-5f34be08e33b"), "North Macedonia", "Zrnovci", "Zrnovci" },
                    { new Guid("d0888be8-c45b-4e6a-be0f-7e8917de3330"), "North Macedonia", "Rostuša", "Mavrovo i Rostuše" },
                    { new Guid("d90ea2b7-90a1-42d8-8b80-0f26c196d01f"), "North Macedonia", "Vinica", "Vinica" },
                    { new Guid("da5acf58-0390-48e5-8efd-6b4ad20c5d59"), "North Macedonia", "Gradsko", "Gradsko" },
                    { new Guid("df587988-acfa-4ebb-a17b-f761bc3240b4"), "North Macedonia", "Tearce", "Tearce" },
                    { new Guid("e0423028-ed1c-435c-b8f2-f8f938b51e0b"), "North Macedonia", "Vrapčište", "Vrapčište" },
                    { new Guid("e1492641-8a21-42f9-b3b4-2f23a3c76042"), "North Macedonia", "Kumanovo", "Kumanovo" },
                    { new Guid("e528e837-cc2c-40db-b237-8493f8db192c"), "North Macedonia", "Makedonski Brod", "Makedonski Brod" },
                    { new Guid("e5847324-21a5-45d7-9d63-f3d5e1035936"), "North Macedonia", "Rosoman", "Rosoman" },
                    { new Guid("e743d008-c814-465e-b64b-9600eb50ec28"), "North Macedonia", "Štip", "Štip" },
                    { new Guid("e937f74b-3f08-4133-b15e-d9dc7f2f1c32"), "North Macedonia", "Karbinci", "Karbinci" },
                    { new Guid("eea89624-29b4-498b-96d2-21d9bef29728"), "North Macedonia", "Krivogaštani", "Krivogaštani" },
                    { new Guid("ef784190-2f7b-4e62-9c12-e0100a7df0f9"), "North Macedonia", "Kočani", "Kočani" },
                    { new Guid("f5072ea4-5ccc-4e92-a082-fd52e884d9da"), "North Macedonia", "Centar Župa", "Centar Župa" },
                    { new Guid("f8519b5e-ab3e-4a8d-a9ae-98e699262cd6"), "North Macedonia", "Petrovec", "Petrovec" }
                });

            migrationBuilder.InsertData(
                table: "MainCategories",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("272455ea-647e-4fdd-95a4-f3fec2cd084d"), new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(513), "Donate your Toys and Games.", "Toys and Games", new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(527) },
                    { new Guid("37b09986-d114-4e68-9c63-b7f4a2973991"), new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(470), "Donate your books or medias.", "Books and Media", new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(485) },
                    { new Guid("64955880-6e01-4007-8dab-f80807028d3a"), new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(346), "Apparel and accessories", "Clothing", new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(360) },
                    { new Guid("64aff739-64a4-4887-81a3-2c030a037674"), new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(555), "Donate your sport or fitness equipment.", "Sports of Fitness Equipment", new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(569) },
                    { new Guid("801d1492-d167-4072-aab3-bea94438edfd"), new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(598), "Donate your food and groceries.", "Food and Groceries", new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(608) },
                    { new Guid("ad25175c-a5d3-40da-abad-5ee366df7056"), new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(432), "Electronics", "Electronics", new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(441) },
                    { new Guid("b2ac13a6-fc0b-4329-96d6-effcf4aa4208"), new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(389), "Every day house hold items", "Household Items", new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(399) }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CreatedAt", "Description", "MainCategoryId", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("0059ebbf-8b1c-47af-8d95-8641ad63414d"), new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(884), "Apparel for women", new Guid("64955880-6e01-4007-8dab-f80807028d3a"), "Women's Clothing", new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(898) },
                    { new Guid("0c45941b-27a9-4e3d-86a8-1193ea218e1c"), new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1973), "Food and formula for infants", new Guid("801d1492-d167-4072-aab3-bea94438edfd"), "Baby Food & Formula", new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1982) },
                    { new Guid("1624a33f-ba23-4460-b05f-943827af8dd5"), new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1595), "Toys for young children", new Guid("272455ea-647e-4fdd-95a4-f3fec2cd084d"), "Baby & Toddler Toys", new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1610) },
                    { new Guid("22b2f2da-778c-41bd-b07b-160c8d27fcbc"), new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1009), "Hats, scarves, belts, etc.", new Guid("64955880-6e01-4007-8dab-f80807028d3a"), "Accessories", new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1023) },
                    { new Guid("2bbc664a-0643-453c-9225-8f49ea431186"), new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1305), "Smartphones and tablets", new Guid("ad25175c-a5d3-40da-abad-5ee366df7056"), "Mobile Phones & Tablets", new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1314) },
                    { new Guid("34f9e904-20a0-4977-b0d4-6ad1ab87f435"), new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1513), "Media collection", new Guid("37b09986-d114-4e68-9c63-b7f4a2973991"), "CDs, DVDs, Blu-rays", new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1523) },
                    { new Guid("350f6479-bb66-426d-9e6d-ead934704a86"), new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(971), "Footwear for all", new Guid("64955880-6e01-4007-8dab-f80807028d3a"), "Shoes & Footwear", new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(981) },
                    { new Guid("3b7638fb-27cb-4e23-9da1-52be699d581c"), new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(927), "Apparel for children", new Guid("64955880-6e01-4007-8dab-f80807028d3a"), "Children's Clothing", new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(937) },
                    { new Guid("5334ca3f-fda1-465e-ad2c-3f876d71adba"), new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1804), "Bicycles and scooters for all ages", new Guid("64aff739-64a4-4887-81a3-2c030a037674"), "Bicycles & Scooters", new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1819) },
                    { new Guid("5be4f0dd-8345-4463-85d0-1d6f135e0396"), new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1052), "Household furniture", new Guid("b2ac13a6-fc0b-4329-96d6-effcf4aa4208"), "Furniture", new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1062) },
                    { new Guid("5c330489-afe7-4c48-8e9d-443b70d7a404"), new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1682), "Gaming systems and games", new Guid("272455ea-647e-4fdd-95a4-f3fec2cd084d"), "Video Games & Consoles", new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1691) },
                    { new Guid("6508c016-9303-465e-a8be-d9c8ab8bb328"), new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1724), "Equipment for gym workouts", new Guid("64aff739-64a4-4887-81a3-2c030a037674"), "Gym Equipment", new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1733) },
                    { new Guid("76dff71a-ab52-4a52-b2f3-aafbd5abc1d2"), new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1132), "Bedding essentials", new Guid("b2ac13a6-fc0b-4329-96d6-effcf4aa4208"), "Bedding & Linens", new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1147) },
                    { new Guid("7701bf29-e676-4973-92f6-20f74488d3e1"), new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1847), "Equipment for outdoor activities", new Guid("64aff739-64a4-4887-81a3-2c030a037674"), "Camping & Outdoor Gear", new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1857) },
                    { new Guid("81d8f317-049e-44dc-b4b8-3891d165c3ed"), new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1930), "Non-perishable food products", new Guid("801d1492-d167-4072-aab3-bea94438edfd"), "Non-Perishable Items", new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1944) },
                    { new Guid("8575689d-e61b-471b-a328-adee7609f4b4"), new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1175), "Cleaning essentials", new Guid("b2ac13a6-fc0b-4329-96d6-effcf4aa4208"), "Cleaning Supplies", new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1189) },
                    { new Guid("8fb303ad-3922-478b-ae05-f4fd32a07082"), new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1094), "Utensils and appliances for the kitchen", new Guid("b2ac13a6-fc0b-4329-96d6-effcf4aa4208"), "Kitchenware", new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1104) },
                    { new Guid("9cf8a091-502b-4737-958b-8fa8968a4b07"), new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1428), "Fiction, non-fiction, educational", new Guid("37b09986-d114-4e68-9c63-b7f4a2973991"), "Books", new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1442) },
                    { new Guid("a0c0d132-5d13-4773-bf3e-8d8342c593dc"), new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1261), "Computers and laptops", new Guid("ad25175c-a5d3-40da-abad-5ee366df7056"), "Computers & Laptops", new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1270) },
                    { new Guid("b512dda2-b4f7-4f6f-8b8d-5ae66aadee3b"), new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(842), "Apparel for men", new Guid("64955880-6e01-4007-8dab-f80807028d3a"), "Men's Clothing", new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(856) },
                    { new Guid("c91534ad-ffab-4d90-976c-9fb3f3248025"), new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1557), "Games for fun and challenges", new Guid("272455ea-647e-4fdd-95a4-f3fec2cd084d"), "Board Games & Puzzles", new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1566) },
                    { new Guid("d1856b31-fda8-4beb-8662-71b1fba4c755"), new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1639), "Toys that promote learning", new Guid("272455ea-647e-4fdd-95a4-f3fec2cd084d"), "Educational Toys", new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1653) },
                    { new Guid("d69cda60-3312-4622-a4d3-47812474f73b"), new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1218), "Decorative items for the home", new Guid("b2ac13a6-fc0b-4329-96d6-effcf4aa4208"), "Home Décor", new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1232) },
                    { new Guid("df8130f1-f42b-4b52-82dc-83c22c6fc7de"), new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1766), "Gear for various sports", new Guid("64aff739-64a4-4887-81a3-2c030a037674"), "Sports Gear", new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1775) },
                    { new Guid("e0d9fdfc-0d70-4cc8-9d7e-74414db18ad4"), new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1891), "Canned food items", new Guid("801d1492-d167-4072-aab3-bea94438edfd"), "Canned Goods", new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1900) },
                    { new Guid("e2dcf768-2347-404b-a919-bab16280fc9f"), new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1386), "Televisions and audio equipment", new Guid("ad25175c-a5d3-40da-abad-5ee366df7056"), "TVs & Audio Systems", new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1400) },
                    { new Guid("f1daf3d3-5efc-405a-b34d-263fe37451e4"), new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1343), "Appliances for home use", new Guid("ad25175c-a5d3-40da-abad-5ee366df7056"), "Home Appliances", new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1357) },
                    { new Guid("f366ba27-effb-43b9-a114-c0fe57b9ac25"), new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1471), "Various magazines", new Guid("37b09986-d114-4e68-9c63-b7f4a2973991"), "Magazines", new DateTime(2024, 10, 20, 14, 59, 17, 545, DateTimeKind.Utc).AddTicks(1486) }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_AspNetUsers_CompanyId",
                table: "Products",
                column: "CompanyId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_AspNetUsers_CompanyId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("00374ec8-93f0-43b6-a398-b6b56b37cc4f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("074d0772-fe70-4250-aba1-c8be9a4bec0d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("09d769d9-f2ed-4ae7-9eb0-356efaba78b5"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0a06ff79-9120-47d0-bcf4-d75c690b7098"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0c5a6c6b-ac4d-427b-996e-c2339ebdb233"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0c64a7a9-1ae3-40a6-97bb-566c0cae02ca"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("12f68cd4-909e-4c99-b19d-1140585d433f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("16038a7c-62b4-4b10-8ba9-eaa9353aa7ac"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("162efc63-3827-4465-bec3-dc99bf4449f7"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("17850ae9-8c60-4709-a904-a569447a83a0"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1e457d82-8cae-41b7-b47e-4f3e45a04d5b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1fa2e29c-f936-476c-aac5-68b97620463f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2242485b-67a6-4132-8297-27cf92d8760d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("23823a8b-2188-4e56-9c08-e519c79eb5a2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("242038a8-60ae-4aa4-a420-86b37329fa34"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("27b5977c-812b-4d59-ae64-4246e84ae4ee"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2bbce22c-154f-4390-b26d-088ec107b967"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("31785a65-39d6-424a-bb82-4370d7d04d34"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("33da739c-4b05-4c0c-ac31-025aae7a9f55"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3565962c-de4c-4334-82d4-fa7fcc59d1df"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3bdef7aa-fcf8-44ba-887f-fb2a850fad2c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3c4d4698-9e75-4f0e-af08-07ad96a0fadb"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("40f015f4-7065-4053-bf2e-2c07555096e5"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("43adffde-9c85-4333-b19f-436ea36dd793"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4d5ce21b-b1ae-41e1-bf94-dcbcc1da19c8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("561b519e-5412-422e-b518-451ecb36abd3"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5b22942d-51da-45fb-9c0c-898b938f9b1f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("672adc6c-d9e4-45da-8ef3-35ec0205e0e6"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("673c91dd-153c-48f0-945e-a6a961cf0375"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6c1cc393-7da4-467f-98be-71154e0069aa"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6eb42caa-63ff-4fa2-9af8-40958c4572ea"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7ae2eacc-543a-44bb-ab7a-f031fe791533"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("821db04e-f03d-4676-a249-2a78cb5c323b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("82f4c35f-5741-438e-9284-694d7364c11e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("86766fa7-93d0-4be5-adaf-586226dca823"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8965a620-c7e3-4076-b870-290f5d6809c6"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8e64aa7d-96dc-471d-9c44-d2afe4f5e81e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("903147b9-98fa-4267-9f73-53a82699f1c2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("91958e2b-0077-489d-a649-3e1848f1bde9"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("93e9248d-9632-4d91-b91f-054698c6ccde"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("978f98eb-c4fd-4a56-a454-23029d99aee5"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9880a1bf-9881-4d18-8581-71452c3e0dfb"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9ad82352-b8d6-436a-acd5-2917cd8ef22b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9e24dec6-ac1c-41ec-856f-1008a436ea3b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9effc946-a7f5-4a93-9b83-2e78151eccec"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a40068a2-d583-4c93-b840-30d0ca555d0a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("aa2ce173-f29d-4724-9d60-74d3a8718bf0"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("aac79267-1914-4ad3-9f0d-a8358e5ea859"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b258d598-7447-46a3-9c54-bb784b14d2ea"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b4cec4d8-0967-4620-b850-b4465e3db7b6"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b9975e82-ec51-4292-aaed-8f8955d6b8a3"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b9ea3ef7-0632-4076-9f64-c99e985bbd7c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("babd51d8-13e0-4339-a01a-21f37f575be4"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c1553cd5-b1c6-435f-8107-d4ad8bccb1e7"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c1f7848c-faea-41c6-98e0-352c8f97b3ce"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c408dadf-1931-4085-9807-c4cb652054c9"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c46a07a6-f739-4c04-9c0a-fee028566f23"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c5929778-8fe8-48bd-bd3b-9e81fa3565d5"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c7aa4afd-99cd-46d8-92e4-429261102291"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("cdec545e-31ef-44d4-ac6b-a6e699f5281b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ce2fdc66-4140-47d2-a264-5f34be08e33b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d0888be8-c45b-4e6a-be0f-7e8917de3330"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d90ea2b7-90a1-42d8-8b80-0f26c196d01f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("da5acf58-0390-48e5-8efd-6b4ad20c5d59"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("df587988-acfa-4ebb-a17b-f761bc3240b4"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e0423028-ed1c-435c-b8f2-f8f938b51e0b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e1492641-8a21-42f9-b3b4-2f23a3c76042"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e528e837-cc2c-40db-b237-8493f8db192c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e5847324-21a5-45d7-9d63-f3d5e1035936"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e743d008-c814-465e-b64b-9600eb50ec28"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e937f74b-3f08-4133-b15e-d9dc7f2f1c32"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("eea89624-29b4-498b-96d2-21d9bef29728"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ef784190-2f7b-4e62-9c12-e0100a7df0f9"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f5072ea4-5ccc-4e92-a082-fd52e884d9da"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f8519b5e-ab3e-4a8d-a9ae-98e699262cd6"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("0059ebbf-8b1c-47af-8d95-8641ad63414d"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("0c45941b-27a9-4e3d-86a8-1193ea218e1c"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("1624a33f-ba23-4460-b05f-943827af8dd5"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("22b2f2da-778c-41bd-b07b-160c8d27fcbc"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("2bbc664a-0643-453c-9225-8f49ea431186"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("34f9e904-20a0-4977-b0d4-6ad1ab87f435"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("350f6479-bb66-426d-9e6d-ead934704a86"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("3b7638fb-27cb-4e23-9da1-52be699d581c"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("5334ca3f-fda1-465e-ad2c-3f876d71adba"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("5be4f0dd-8345-4463-85d0-1d6f135e0396"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("5c330489-afe7-4c48-8e9d-443b70d7a404"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("6508c016-9303-465e-a8be-d9c8ab8bb328"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("76dff71a-ab52-4a52-b2f3-aafbd5abc1d2"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("7701bf29-e676-4973-92f6-20f74488d3e1"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("81d8f317-049e-44dc-b4b8-3891d165c3ed"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("8575689d-e61b-471b-a328-adee7609f4b4"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("8fb303ad-3922-478b-ae05-f4fd32a07082"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("9cf8a091-502b-4737-958b-8fa8968a4b07"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("a0c0d132-5d13-4773-bf3e-8d8342c593dc"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("b512dda2-b4f7-4f6f-8b8d-5ae66aadee3b"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("c91534ad-ffab-4d90-976c-9fb3f3248025"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("d1856b31-fda8-4beb-8662-71b1fba4c755"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("d69cda60-3312-4622-a4d3-47812474f73b"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("df8130f1-f42b-4b52-82dc-83c22c6fc7de"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("e0d9fdfc-0d70-4cc8-9d7e-74414db18ad4"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("e2dcf768-2347-404b-a919-bab16280fc9f"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("f1daf3d3-5efc-405a-b34d-263fe37451e4"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("f366ba27-effb-43b9-a114-c0fe57b9ac25"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("272455ea-647e-4fdd-95a4-f3fec2cd084d"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("37b09986-d114-4e68-9c63-b7f4a2973991"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("64955880-6e01-4007-8dab-f80807028d3a"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("64aff739-64a4-4887-81a3-2c030a037674"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("801d1492-d167-4072-aab3-bea94438edfd"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("ad25175c-a5d3-40da-abad-5ee366df7056"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("b2ac13a6-fc0b-4329-96d6-effcf4aa4208"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "569a6003-4d9a-4ed4-b3ee-63825510f630", null, "Admin", "ADMIN" },
                    { "ba5a5462-b652-4e42-aa0a-fab249726f07", null, "Company", "COMPANY" },
                    { "f98ca047-8223-45a9-8b13-e3039a3116cd", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Country", "Name", "PrimaryCity" },
                values: new object[,]
                {
                    { new Guid("0013bbf3-9f0c-4e8b-9e4a-022587ab7283"), "North Macedonia", "Star Dojran", "Dojran" },
                    { new Guid("00b49928-6f8c-4a01-879d-6cdbc604227d"), "North Macedonia", "Štip", "Štip" },
                    { new Guid("01b08def-a699-4675-b8f1-e22545e33a7f"), "North Macedonia", "Struga", "Struga" },
                    { new Guid("03cd3b2b-ab40-4ed6-b6ba-77900997b59a"), "North Macedonia", "Berovo", "Berovo" },
                    { new Guid("0b991aeb-949e-453d-8caa-82c8ec40190a"), "North Macedonia", "Debar", "Debar" },
                    { new Guid("0cffc736-d211-4370-9ff3-de68bec3d4f0"), "North Macedonia", "Plasnica", "Plasnica" },
                    { new Guid("0d932ae8-8381-476d-85d0-735b31f319c3"), "North Macedonia", "Negotino", "Negotino" },
                    { new Guid("16b71c93-31e0-4da6-a8ea-7e513c2b3d29"), "North Macedonia", "Novaci", "Novaci" },
                    { new Guid("1a63cd62-f1f7-4a18-a64a-4a25b52421a2"), "North Macedonia", "Kičevo", "Kičevo" },
                    { new Guid("1c7615aa-9af3-4c1e-a100-06ea15edbd83"), "North Macedonia", "Karbinci", "Karbinci" },
                    { new Guid("1e40aeba-25ab-4665-bb79-30fe1fc51188"), "North Macedonia", "Rankovce", "Rankovce" },
                    { new Guid("1fe74dc7-76c4-412c-81df-fd7e4d45d5b3"), "North Macedonia", "Bitola", "Bitola" },
                    { new Guid("289fd7f8-4012-41c0-9b77-d79a8bf6752e"), "North Macedonia", "Demir Hisar", "Demir Hisar" },
                    { new Guid("29a7acbe-80e7-4595-865f-0d5bc76ec8f3"), "North Macedonia", "Resen", "Resen" },
                    { new Guid("2b6e0ac2-1c39-47bc-ae37-c3a6fd78c825"), "North Macedonia", "Vevčani", "Vevčani" },
                    { new Guid("2bf91ed5-61b3-4977-b008-25e0c0c30749"), "North Macedonia", "Bogovinje", "Bogovinje" },
                    { new Guid("3d10c667-1468-4efd-bd0d-e5eec9c50e96"), "North Macedonia", "Krivogaštani", "Krivogaštani" },
                    { new Guid("3d115946-7611-43eb-8151-073f424b89dd"), "North Macedonia", "Petrovec", "Petrovec" },
                    { new Guid("3de95a7b-6bc8-4f1c-bdc1-e5146eefcc44"), "North Macedonia", "Kučevište", "Čučer-Sandevo" },
                    { new Guid("4163c41d-2dc9-4d6b-bc46-440ff617ae93"), "North Macedonia", "Čegrane", "Gostivar" },
                    { new Guid("4a6698a1-62fe-477a-aea9-89cc9939ad2e"), "North Macedonia", "Gradsko", "Gradsko" },
                    { new Guid("4a70b3e0-5bb7-4896-b686-201b19c3c3c6"), "North Macedonia", "Staro Nagoričane", "Staro Nagoričane" },
                    { new Guid("4aeed20a-b72b-4289-960a-334333d87a53"), "North Macedonia", "Tearce", "Tearce" },
                    { new Guid("4fd05833-61bb-4ee4-88cc-a36dd98dfb95"), "North Macedonia", "Kriva Palanka", "Kriva Palanka" },
                    { new Guid("53facb02-381c-4581-b415-0684fa23c166"), "North Macedonia", "Bogdanci", "Bogdanci" },
                    { new Guid("54f028d6-84c1-42a8-867a-6cfd3b7ea67a"), "North Macedonia", "Makedonski Brod", "Makedonski Brod" },
                    { new Guid("5614cf41-8f25-4868-ade4-ba3d64d3577f"), "North Macedonia", "Vasilevo", "Vasilevo" },
                    { new Guid("5811e4b5-bf53-4460-ab11-a90a60e905ab"), "North Macedonia", "Kočani", "Kočani" },
                    { new Guid("5aa41822-3f4e-4791-b75a-6114017b6f5c"), "North Macedonia", "Lozovo", "Lozovo" },
                    { new Guid("5c2c8855-b781-40d9-81be-854fc8253164"), "North Macedonia", "Strumica", "Strumica" },
                    { new Guid("604ed3c8-9d74-45ad-844e-510126629ee1"), "North Macedonia", "Centar Župa", "Centar Župa" },
                    { new Guid("63a705b3-0946-421c-a027-6673d468c236"), "North Macedonia", "Sopište", "Sopište" },
                    { new Guid("64f02006-6c4b-4673-a6cd-fb828cfda698"), "North Macedonia", "Mogila", "Mogila" },
                    { new Guid("65281569-35cb-42dc-b55d-b9dde9f6a444"), "North Macedonia", "Radoviš", "Radoviš" },
                    { new Guid("654eaad8-4e4c-4bfb-a005-9ad97fa7202e"), "North Macedonia", "Kratovo", "Kratovo" },
                    { new Guid("6b14999e-99ed-4040-9601-fc2d5abbc884"), "North Macedonia", "Konče", "Konče" },
                    { new Guid("70c3429f-8a59-4432-83d3-09934af7bd3e"), "North Macedonia", "Obleševo", "Češinovo-Obleševo" },
                    { new Guid("7292e215-2c9c-4fd3-9bd5-aea18b30c9ff"), "North Macedonia", "Belčišta", "Debarca" },
                    { new Guid("7a7d659e-c079-49b6-9a34-460b449eb7ea"), "North Macedonia", "Gevgelija", "Gevgelija" },
                    { new Guid("7e807b32-5dcc-49d4-a7c5-ed3b76aa7755"), "North Macedonia", "Zelenikovo", "Zelenikovo" },
                    { new Guid("82f736da-905d-4f93-bcce-3f0bfbbff617"), "North Macedonia", "Aračinovo", "Aračinovo" },
                    { new Guid("832139c2-4d94-48a5-8703-ffedb5652e90"), "North Macedonia", "Zrnovci", "Zrnovci" },
                    { new Guid("8f38af96-656c-42d6-83f0-58fb07037cbd"), "North Macedonia", "Kavadarci", "Kavadarci" },
                    { new Guid("90be8940-56ca-4cd7-9f0e-8a8de208c677"), "North Macedonia", "Čučer-Sandevo", "Čučer-Sandevo" },
                    { new Guid("90f7a44d-7565-451e-86e5-9ac56308b28c"), "North Macedonia", "Tetovo", "Tetovo" },
                    { new Guid("943f1425-9b6e-4ec4-86d6-0149b1f12587"), "North Macedonia", "Makedonska Kamenica", "Makedonska Kamenica" },
                    { new Guid("9764f16a-591c-47bc-b087-99e9dceb6851"), "North Macedonia", "Vrapčište", "Vrapčište" },
                    { new Guid("97f1e18e-1bf0-46e4-a1b9-e1b8917a62df"), "North Macedonia", "Rosoman", "Rosoman" },
                    { new Guid("9d092d11-415b-420d-b8ae-bbab3b96e715"), "North Macedonia", "Forino", "Gostivar" },
                    { new Guid("aa52b573-ee45-4ef7-8fd7-1855355e6df6"), "North Macedonia", "Delčevo", "Delčevo" },
                    { new Guid("ab15dcaa-9669-46ac-a81f-45bbfd041626"), "North Macedonia", "Dračevo", "Skopje" },
                    { new Guid("af1968bf-5ba6-4aa7-b19b-08c73326c364"), "North Macedonia", "Rostuša", "Mavrovo i Rostuše" },
                    { new Guid("b1b83b85-4ffa-4b68-a155-5e1e3512f8d7"), "North Macedonia", "Pehčevo", "Pehčevo" },
                    { new Guid("b5388323-7c85-4a06-bfa9-a7b5e655ab73"), "North Macedonia", "Sveti Nikole", "Sveti Nikole" },
                    { new Guid("b6ece68d-9e6d-4733-9225-e6a220136947"), "North Macedonia", "Dolneni", "Dolneni" },
                    { new Guid("bc8c23e3-ffb5-43f2-bbee-65909ba82391"), "North Macedonia", "Kumanovo", "Kumanovo" },
                    { new Guid("c1acca7c-d010-446c-b441-ff96c4e52d4c"), "North Macedonia", "Vinica", "Vinica" },
                    { new Guid("c2a6a7e4-678a-4acc-a802-c56752c762e5"), "North Macedonia", "Kruševo", "Kruševo" },
                    { new Guid("c37e7e45-8e49-41b5-a4c7-b53c99da4399"), "North Macedonia", "Ilinden", "Ilinden" },
                    { new Guid("c7481a87-c89a-4cee-869a-faa24aaf2d07"), "North Macedonia", "Lipkovo", "Lipkovo" },
                    { new Guid("ca8998fe-ff94-44dd-834a-5b4316099eb2"), "North Macedonia", "Studeničani", "Studeničani" },
                    { new Guid("cb83a589-391a-48f6-b961-eded0604b2c0"), "North Macedonia", "Prilep", "Prilep" },
                    { new Guid("cef42d2b-0e74-46f3-8132-800a970ca833"), "North Macedonia", "Želino", "Želino" },
                    { new Guid("d1e8e798-cc81-4013-8314-8c68f63aefc8"), "North Macedonia", "Probištip", "Probištip" },
                    { new Guid("da824f55-da47-40eb-beb3-b3364e163181"), "North Macedonia", "Brvenica", "Brvenica" },
                    { new Guid("dbc56cfb-0520-4976-87ac-9de4f39086c5"), "North Macedonia", "Valandovo", "Valandovo" },
                    { new Guid("dc887b63-6d9b-4814-b1dc-0a23c4afa0c2"), "North Macedonia", "Rašče", "Skopje" },
                    { new Guid("e41188b1-28a7-4b77-a14c-b8700b7937e8"), "North Macedonia", "Ohrid", "Ohrid" },
                    { new Guid("e888032d-cada-473d-9092-ef3e722bf16e"), "North Macedonia", "Veles", "Veles" },
                    { new Guid("f64bb176-1443-420f-ae02-1fcb2f957ed1"), "North Macedonia", "Bosilovo", "Bosilovo" },
                    { new Guid("f87bc813-399c-4f9d-a9e0-7afe9017e681"), "North Macedonia", "Novo Selo", "Novo Selo" },
                    { new Guid("faa20f22-aaf9-455c-b706-a026a4b8c46c"), "North Macedonia", "Jegunovce", "Jegunovce" },
                    { new Guid("fb2ef433-9b6c-4da5-a88a-925db7a770d7"), "North Macedonia", "Demir Kapija", "Demir Kapija" },
                    { new Guid("fd2ddc08-65c3-4337-a45a-de72a6b84a7e"), "North Macedonia", "Gostivar", "Gostivar" },
                    { new Guid("fe51dce7-51ea-482c-8566-b7a699caacc0"), "North Macedonia", "Skopje", "Skopje" }
                });

            migrationBuilder.InsertData(
                table: "MainCategories",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("0d0dc453-ba0c-4432-8b07-3988c0beb653"), new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(55), "Donate your food and groceries.", "Food and Groceries", new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(70) },
                    { new Guid("30201f35-f99f-4422-adc5-4713af8c7a89"), new DateTime(2024, 10, 20, 14, 9, 58, 371, DateTimeKind.Utc).AddTicks(9889), "Electronics", "Electronics", new DateTime(2024, 10, 20, 14, 9, 58, 371, DateTimeKind.Utc).AddTicks(9903) },
                    { new Guid("3c043b1b-3947-470d-8ddc-2c127de2f7b1"), new DateTime(2024, 10, 20, 14, 9, 58, 371, DateTimeKind.Utc).AddTicks(9808), "Apparel and accessories", "Clothing", new DateTime(2024, 10, 20, 14, 9, 58, 371, DateTimeKind.Utc).AddTicks(9817) },
                    { new Guid("4976ca98-cb1e-4aed-b64c-8c4d42ee5bfb"), new DateTime(2024, 10, 20, 14, 9, 58, 371, DateTimeKind.Utc).AddTicks(9975), "Donate your Toys and Games.", "Toys and Games", new DateTime(2024, 10, 20, 14, 9, 58, 371, DateTimeKind.Utc).AddTicks(9984) },
                    { new Guid("57fcd2f6-e796-4f24-865b-d85fc43ced2e"), new DateTime(2024, 10, 20, 14, 9, 58, 371, DateTimeKind.Utc).AddTicks(9852), "Every day house hold items", "Household Items", new DateTime(2024, 10, 20, 14, 9, 58, 371, DateTimeKind.Utc).AddTicks(9861) },
                    { new Guid("b6fb6e82-9c28-48f9-aa6c-2af5c29c649f"), new DateTime(2024, 10, 20, 14, 9, 58, 371, DateTimeKind.Utc).AddTicks(9932), "Donate your books or medias.", "Books and Media", new DateTime(2024, 10, 20, 14, 9, 58, 371, DateTimeKind.Utc).AddTicks(9947) },
                    { new Guid("ecc60cac-1ffb-4aa4-b8f7-773f0ec6a389"), new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(12), "Donate your sport or fitness equipment.", "Sports of Fitness Equipment", new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(26) }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CreatedAt", "Description", "MainCategoryId", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("045348a0-1da3-4e25-a810-4d69cfc5d6d6"), new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(1162), "Gear for various sports", new Guid("ecc60cac-1ffb-4aa4-b8f7-773f0ec6a389"), "Sports Gear", new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(1172) },
                    { new Guid("0c062b2f-1feb-4bc0-90c5-4ddd42d17b61"), new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(370), "Footwear for all", new Guid("3c043b1b-3947-470d-8ddc-2c127de2f7b1"), "Shoes & Footwear", new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(380) },
                    { new Guid("0f767cb3-9809-451e-a849-5fc8dea1f780"), new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(791), "Televisions and audio equipment", new Guid("30201f35-f99f-4422-adc5-4713af8c7a89"), "TVs & Audio Systems", new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(801) },
                    { new Guid("0f976dd8-dda7-474b-a9e3-8a474fa0b659"), new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(704), "Smartphones and tablets", new Guid("30201f35-f99f-4422-adc5-4713af8c7a89"), "Mobile Phones & Tablets", new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(718) },
                    { new Guid("2ce1a55b-898a-473c-900c-7a8930085d45"), new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(452), "Household furniture", new Guid("57fcd2f6-e796-4f24-865b-d85fc43ced2e"), "Furniture", new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(466) },
                    { new Guid("2d911134-3d08-4819-b4fe-591741966754"), new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(1324), "Non-perishable food products", new Guid("0d0dc453-ba0c-4432-8b07-3988c0beb653"), "Non-Perishable Items", new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(1338) },
                    { new Guid("3842b568-4208-44e7-a283-4fbe17785b00"), new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(1081), "Gaming systems and games", new Guid("4976ca98-cb1e-4aed-b64c-8c4d42ee5bfb"), "Video Games & Consoles", new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(1091) },
                    { new Guid("3f27f640-6950-4d5b-a9f9-cc954753a509"), new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(747), "Appliances for home use", new Guid("30201f35-f99f-4422-adc5-4713af8c7a89"), "Home Appliances", new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(757) },
                    { new Guid("4501be0d-a8c5-4e48-8f27-d1c18d41d5c8"), new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(871), "Various magazines", new Guid("b6fb6e82-9c28-48f9-aa6c-2af5c29c649f"), "Magazines", new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(885) },
                    { new Guid("4d4c9af7-d6c7-4f84-b5d8-57c94f87f668"), new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(496), "Utensils and appliances for the kitchen", new Guid("57fcd2f6-e796-4f24-865b-d85fc43ced2e"), "Kitchenware", new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(505) },
                    { new Guid("4df02e6b-cef8-4b0f-8e3c-459ce7bf2290"), new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(1285), "Canned food items", new Guid("0d0dc453-ba0c-4432-8b07-3988c0beb653"), "Canned Goods", new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(1295) },
                    { new Guid("5c10478e-3e33-40a5-9b76-3ab76e520926"), new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(995), "Toys for young children", new Guid("4976ca98-cb1e-4aed-b64c-8c4d42ee5bfb"), "Baby & Toddler Toys", new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(1009) },
                    { new Guid("604e69c5-b384-4795-902f-69f44a4d2a2d"), new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(914), "Media collection", new Guid("b6fb6e82-9c28-48f9-aa6c-2af5c29c649f"), "CDs, DVDs, Blu-rays", new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(928) },
                    { new Guid("64c28549-cbc5-4736-8e61-4fb655498145"), new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(1037), "Toys that promote learning", new Guid("4976ca98-cb1e-4aed-b64c-8c4d42ee5bfb"), "Educational Toys", new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(1052) },
                    { new Guid("6aad5578-712d-448d-9a64-69346bd36808"), new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(580), "Cleaning essentials", new Guid("57fcd2f6-e796-4f24-865b-d85fc43ced2e"), "Cleaning Supplies", new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(589) },
                    { new Guid("7d0cba1f-39c9-4211-9621-56ac0975e905"), new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(618), "Decorative items for the home", new Guid("57fcd2f6-e796-4f24-865b-d85fc43ced2e"), "Home Décor", new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(632) },
                    { new Guid("7e45a56d-8438-403d-a6b0-69e5491c0268"), new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(1120), "Equipment for gym workouts", new Guid("ecc60cac-1ffb-4aa4-b8f7-773f0ec6a389"), "Gym Equipment", new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(1135) },
                    { new Guid("8b343a6d-e64f-4244-8126-7d1e022326a7"), new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(246), "Apparel for men", new Guid("3c043b1b-3947-470d-8ddc-2c127de2f7b1"), "Men's Clothing", new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(256) },
                    { new Guid("8df451b6-6e8d-4700-80c6-50a4db4657b8"), new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(1205), "Bicycles and scooters for all ages", new Guid("ecc60cac-1ffb-4aa4-b8f7-773f0ec6a389"), "Bicycles & Scooters", new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(1219) },
                    { new Guid("8e81f7b7-413e-41c6-b543-44daa77ee80a"), new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(1367), "Food and formula for infants", new Guid("0d0dc453-ba0c-4432-8b07-3988c0beb653"), "Baby Food & Formula", new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(1382) },
                    { new Guid("9669e61f-0032-4f69-8ca5-26c6d6727d25"), new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(537), "Bedding essentials", new Guid("57fcd2f6-e796-4f24-865b-d85fc43ced2e"), "Bedding & Linens", new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(547) },
                    { new Guid("9fb637ca-3f75-46a6-90e0-2192509acc9f"), new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(285), "Apparel for women", new Guid("3c043b1b-3947-470d-8ddc-2c127de2f7b1"), "Women's Clothing", new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(299) },
                    { new Guid("b86af2b6-9f78-484f-8dba-38b877c52eda"), new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(327), "Apparel for children", new Guid("3c043b1b-3947-470d-8ddc-2c127de2f7b1"), "Children's Clothing", new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(341) },
                    { new Guid("d6af5fb9-8c5d-4e84-ba1c-966c6fbe6765"), new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(661), "Computers and laptops", new Guid("30201f35-f99f-4422-adc5-4713af8c7a89"), "Computers & Laptops", new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(675) },
                    { new Guid("dc690059-62e7-4dd4-9334-31bfd740896e"), new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(413), "Hats, scarves, belts, etc.", new Guid("3c043b1b-3947-470d-8ddc-2c127de2f7b1"), "Accessories", new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(423) },
                    { new Guid("dcbeb935-42d9-4155-a7a9-cb0569abef8e"), new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(1242), "Equipment for outdoor activities", new Guid("ecc60cac-1ffb-4aa4-b8f7-773f0ec6a389"), "Camping & Outdoor Gear", new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(1257) },
                    { new Guid("e4221336-7336-481c-9415-1c844cdeb0a7"), new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(829), "Fiction, non-fiction, educational", new Guid("b6fb6e82-9c28-48f9-aa6c-2af5c29c649f"), "Books", new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(843) },
                    { new Guid("e98b5af5-f12a-4091-81dc-825acfb27bf1"), new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(956), "Games for fun and challenges", new Guid("4976ca98-cb1e-4aed-b64c-8c4d42ee5bfb"), "Board Games & Puzzles", new DateTime(2024, 10, 20, 14, 9, 58, 372, DateTimeKind.Utc).AddTicks(966) }
                });

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
