﻿// <auto-generated />
using System;
using Local_Alternatives.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Local_Alternatives.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241019083211_CompanyAndNormalUser")]
    partial class CompanyAndNormalUser
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Local_Alternatives.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("character varying(13)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("UserType").HasValue("AppUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Local_Alternatives.Models.Cities", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PrimaryCity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = new Guid("92037cd3-2fa9-4adb-8c59-de32d7e5f56f"),
                            Country = "North Macedonia",
                            Name = "Skopje",
                            PrimaryCity = "Skopje"
                        },
                        new
                        {
                            Id = new Guid("8c074d6b-ba7d-4423-a7f0-b973e6300c5a"),
                            Country = "North Macedonia",
                            Name = "Kumanovo",
                            PrimaryCity = "Kumanovo"
                        },
                        new
                        {
                            Id = new Guid("24801e7d-d200-4b8b-8d3f-35531eba3dcc"),
                            Country = "North Macedonia",
                            Name = "Bitola",
                            PrimaryCity = "Bitola"
                        },
                        new
                        {
                            Id = new Guid("898007e8-fde2-4fb4-85c7-970c91551cfd"),
                            Country = "North Macedonia",
                            Name = "Prilep",
                            PrimaryCity = "Prilep"
                        },
                        new
                        {
                            Id = new Guid("37497bfa-0968-408a-93dd-2712cd75ddb8"),
                            Country = "North Macedonia",
                            Name = "Tetovo",
                            PrimaryCity = "Tetovo"
                        },
                        new
                        {
                            Id = new Guid("cbe5281b-eec3-45c5-9c85-244026105e20"),
                            Country = "North Macedonia",
                            Name = "Štip",
                            PrimaryCity = "Štip"
                        },
                        new
                        {
                            Id = new Guid("c7a5735b-d8b7-4bb7-9b2b-2a86bb6fa7cc"),
                            Country = "North Macedonia",
                            Name = "Veles",
                            PrimaryCity = "Veles"
                        },
                        new
                        {
                            Id = new Guid("314e258c-f0ac-40a8-b734-7b9f7d031b00"),
                            Country = "North Macedonia",
                            Name = "Ohrid",
                            PrimaryCity = "Ohrid"
                        },
                        new
                        {
                            Id = new Guid("2e5bc4be-ba9c-41d3-bbcc-c0627946f495"),
                            Country = "North Macedonia",
                            Name = "Strumica",
                            PrimaryCity = "Strumica"
                        },
                        new
                        {
                            Id = new Guid("931d564f-8a8a-4fb7-9ad1-5e686e8ab1b8"),
                            Country = "North Macedonia",
                            Name = "Gostivar",
                            PrimaryCity = "Gostivar"
                        },
                        new
                        {
                            Id = new Guid("a6065011-bbf6-4d12-baaa-6ab1efa25c8a"),
                            Country = "North Macedonia",
                            Name = "Kočani",
                            PrimaryCity = "Kočani"
                        },
                        new
                        {
                            Id = new Guid("3bb24c0d-b04f-4860-a992-cdc4d8d0cf12"),
                            Country = "North Macedonia",
                            Name = "Dračevo",
                            PrimaryCity = "Skopje"
                        },
                        new
                        {
                            Id = new Guid("e775b527-c852-4d15-a9fc-4d53384fe3ca"),
                            Country = "North Macedonia",
                            Name = "Struga",
                            PrimaryCity = "Struga"
                        },
                        new
                        {
                            Id = new Guid("eeb11fc4-a614-4de4-b5d6-fb28fedb3eb6"),
                            Country = "North Macedonia",
                            Name = "Debar",
                            PrimaryCity = "Debar"
                        },
                        new
                        {
                            Id = new Guid("4713a201-3ea2-424c-8ae2-74cf0071dab8"),
                            Country = "North Macedonia",
                            Name = "Kriva Palanka",
                            PrimaryCity = "Kriva Palanka"
                        },
                        new
                        {
                            Id = new Guid("5ed91275-d77d-4d98-b7f3-a1b220ac3bc3"),
                            Country = "North Macedonia",
                            Name = "Negotino",
                            PrimaryCity = "Negotino"
                        },
                        new
                        {
                            Id = new Guid("dbf1338b-fcde-416f-b9e6-dcf823085f6d"),
                            Country = "North Macedonia",
                            Name = "Sveti Nikole",
                            PrimaryCity = "Sveti Nikole"
                        },
                        new
                        {
                            Id = new Guid("2ce1cd33-8bca-4862-a8fc-f28920be7be1"),
                            Country = "North Macedonia",
                            Name = "Probištip",
                            PrimaryCity = "Probištip"
                        },
                        new
                        {
                            Id = new Guid("8d43ba76-a60f-49eb-84f5-4acd0d7cb84e"),
                            Country = "North Macedonia",
                            Name = "Delčevo",
                            PrimaryCity = "Delčevo"
                        },
                        new
                        {
                            Id = new Guid("81755edb-e898-4b60-8060-a890f3dd13ad"),
                            Country = "North Macedonia",
                            Name = "Vinica",
                            PrimaryCity = "Vinica"
                        },
                        new
                        {
                            Id = new Guid("39359c03-0244-4bd4-8cba-3b46ce62b739"),
                            Country = "North Macedonia",
                            Name = "Aračinovo",
                            PrimaryCity = "Aračinovo"
                        },
                        new
                        {
                            Id = new Guid("f5f648d1-5d7b-4025-8fdf-9f2e025df19b"),
                            Country = "North Macedonia",
                            Name = "Kičevo",
                            PrimaryCity = "Kičevo"
                        },
                        new
                        {
                            Id = new Guid("d125f68d-9835-4de9-873b-660007eb7c6d"),
                            Country = "North Macedonia",
                            Name = "Kavadarci",
                            PrimaryCity = "Kavadarci"
                        },
                        new
                        {
                            Id = new Guid("dc3c3823-2258-46dd-9a82-113e5643eaeb"),
                            Country = "North Macedonia",
                            Name = "Berovo",
                            PrimaryCity = "Berovo"
                        },
                        new
                        {
                            Id = new Guid("22ae938e-b539-405f-ac9d-0add66a5fe63"),
                            Country = "North Macedonia",
                            Name = "Kratovo",
                            PrimaryCity = "Kratovo"
                        },
                        new
                        {
                            Id = new Guid("d268d48b-fe1e-4ad6-a32b-c74b7a4de17e"),
                            Country = "North Macedonia",
                            Name = "Gevgelija",
                            PrimaryCity = "Gevgelija"
                        },
                        new
                        {
                            Id = new Guid("52cca0d5-f2e9-4b49-b43d-7b86f806e3fa"),
                            Country = "North Macedonia",
                            Name = "Vrapčište",
                            PrimaryCity = "Vrapčište"
                        },
                        new
                        {
                            Id = new Guid("69c62b4d-f886-46c1-9bf0-a0cf4c23a70b"),
                            Country = "North Macedonia",
                            Name = "Radoviš",
                            PrimaryCity = "Radoviš"
                        },
                        new
                        {
                            Id = new Guid("67e9d17c-98b2-40ab-837b-e66e1c9488d4"),
                            Country = "North Macedonia",
                            Name = "Kruševo",
                            PrimaryCity = "Kruševo"
                        },
                        new
                        {
                            Id = new Guid("13711bc3-0f27-489d-a811-a69c593540d6"),
                            Country = "North Macedonia",
                            Name = "Čegrane",
                            PrimaryCity = "Gostivar"
                        },
                        new
                        {
                            Id = new Guid("cea77401-2ac4-4671-b850-edf6155f8eec"),
                            Country = "North Macedonia",
                            Name = "Makedonski Brod",
                            PrimaryCity = "Makedonski Brod"
                        },
                        new
                        {
                            Id = new Guid("5f9115f9-f669-4f91-adf7-9c2573f0ab9f"),
                            Country = "North Macedonia",
                            Name = "Demir Kapija",
                            PrimaryCity = "Demir Kapija"
                        },
                        new
                        {
                            Id = new Guid("c003e71d-be82-45e8-80f6-ffa0101ca66a"),
                            Country = "North Macedonia",
                            Name = "Kučevište",
                            PrimaryCity = "Čučer-Sandevo"
                        },
                        new
                        {
                            Id = new Guid("4623f541-7ac7-4566-bd89-7bea86107c41"),
                            Country = "North Macedonia",
                            Name = "Tearce",
                            PrimaryCity = "Tearce"
                        },
                        new
                        {
                            Id = new Guid("97a7dd14-8ec5-4ef1-8f7a-9de65e68964d"),
                            Country = "North Macedonia",
                            Name = "Bogdanci",
                            PrimaryCity = "Bogdanci"
                        },
                        new
                        {
                            Id = new Guid("a149d182-701c-4f22-9f4d-f60ff2c3d8c7"),
                            Country = "North Macedonia",
                            Name = "Forino",
                            PrimaryCity = "Gostivar"
                        },
                        new
                        {
                            Id = new Guid("5bc6ee2a-0bae-4871-8309-196ff8c839f3"),
                            Country = "North Macedonia",
                            Name = "Rašče",
                            PrimaryCity = "Skopje"
                        },
                        new
                        {
                            Id = new Guid("00a5403c-82da-478e-be00-29ba57dc7a0e"),
                            Country = "North Macedonia",
                            Name = "Rosoman",
                            PrimaryCity = "Rosoman"
                        },
                        new
                        {
                            Id = new Guid("c0a19084-66be-47fd-bccf-b58775a0cccb"),
                            Country = "North Macedonia",
                            Name = "Demir Hisar",
                            PrimaryCity = "Demir Hisar"
                        },
                        new
                        {
                            Id = new Guid("b4ac864e-462b-466e-bbe9-5e5b22c51aa2"),
                            Country = "North Macedonia",
                            Name = "Vevčani",
                            PrimaryCity = "Vevčani"
                        },
                        new
                        {
                            Id = new Guid("d091e415-7a93-4977-929d-a941caae041c"),
                            Country = "North Macedonia",
                            Name = "Gradsko",
                            PrimaryCity = "Gradsko"
                        },
                        new
                        {
                            Id = new Guid("d251b938-7336-44e0-95a8-b83bdf775ea1"),
                            Country = "North Macedonia",
                            Name = "Valandovo",
                            PrimaryCity = "Valandovo"
                        },
                        new
                        {
                            Id = new Guid("3eec4e7a-2a29-4e70-9794-459df4f82443"),
                            Country = "North Macedonia",
                            Name = "Krivogaštani",
                            PrimaryCity = "Krivogaštani"
                        },
                        new
                        {
                            Id = new Guid("c7efa8e1-55f1-4ac0-91aa-47b17481567e"),
                            Country = "North Macedonia",
                            Name = "Pehčevo",
                            PrimaryCity = "Pehčevo"
                        },
                        new
                        {
                            Id = new Guid("ac3d9c31-fb81-4aa1-b662-da070299f191"),
                            Country = "North Macedonia",
                            Name = "Plasnica",
                            PrimaryCity = "Plasnica"
                        },
                        new
                        {
                            Id = new Guid("13d2520c-cf21-48a5-a61f-8671dfd9e235"),
                            Country = "North Macedonia",
                            Name = "Zrnovci",
                            PrimaryCity = "Zrnovci"
                        },
                        new
                        {
                            Id = new Guid("1f8bbf9f-e169-415f-9d96-b316e26f3407"),
                            Country = "North Macedonia",
                            Name = "Novaci",
                            PrimaryCity = "Novaci"
                        },
                        new
                        {
                            Id = new Guid("666fe51a-2b3b-41b4-bd4d-a71ee18591c9"),
                            Country = "North Macedonia",
                            Name = "Bosilovo",
                            PrimaryCity = "Bosilovo"
                        },
                        new
                        {
                            Id = new Guid("8a7b113a-ee2a-4bce-bd7d-e08e376c8481"),
                            Country = "North Macedonia",
                            Name = "Mogila",
                            PrimaryCity = "Mogila"
                        },
                        new
                        {
                            Id = new Guid("fa1355c0-4518-47aa-afe8-0011d737cd0c"),
                            Country = "North Macedonia",
                            Name = "Novo Selo",
                            PrimaryCity = "Novo Selo"
                        },
                        new
                        {
                            Id = new Guid("f1e06dbe-b719-4130-bc1b-1d2560451111"),
                            Country = "North Macedonia",
                            Name = "Konče",
                            PrimaryCity = "Konče"
                        },
                        new
                        {
                            Id = new Guid("5c4f618b-f60f-48f4-b9ec-a55aa57afc25"),
                            Country = "North Macedonia",
                            Name = "Rostuša",
                            PrimaryCity = "Mavrovo i Rostuše"
                        },
                        new
                        {
                            Id = new Guid("18164d53-8c80-448c-a128-9c8860d643c6"),
                            Country = "North Macedonia",
                            Name = "Jegunovce",
                            PrimaryCity = "Jegunovce"
                        },
                        new
                        {
                            Id = new Guid("14d74723-6690-489f-9842-b9d184cb74e8"),
                            Country = "North Macedonia",
                            Name = "Rankovce",
                            PrimaryCity = "Rankovce"
                        },
                        new
                        {
                            Id = new Guid("39b610e9-ae48-4ff3-acc0-a37bad1c3aa7"),
                            Country = "North Macedonia",
                            Name = "Sopište",
                            PrimaryCity = "Sopište"
                        },
                        new
                        {
                            Id = new Guid("04939540-5330-4ec8-8d5d-ba96bf79cd74"),
                            Country = "North Macedonia",
                            Name = "Obleševo",
                            PrimaryCity = "Češinovo-Obleševo"
                        },
                        new
                        {
                            Id = new Guid("0e66387a-8c9d-4849-9d25-0b978941c4aa"),
                            Country = "North Macedonia",
                            Name = "Vasilevo",
                            PrimaryCity = "Vasilevo"
                        },
                        new
                        {
                            Id = new Guid("767d9532-8989-4787-a389-ab78bf78f22f"),
                            Country = "North Macedonia",
                            Name = "Karbinci",
                            PrimaryCity = "Karbinci"
                        },
                        new
                        {
                            Id = new Guid("318638e5-e022-48f4-aee8-bbc066ba3483"),
                            Country = "North Macedonia",
                            Name = "Lozovo",
                            PrimaryCity = "Lozovo"
                        },
                        new
                        {
                            Id = new Guid("502a46e0-af35-4c22-8481-1dd2864265f3"),
                            Country = "North Macedonia",
                            Name = "Staro Nagoričane",
                            PrimaryCity = "Staro Nagoričane"
                        },
                        new
                        {
                            Id = new Guid("3fd6749e-07f4-4a26-be07-187eee5eb342"),
                            Country = "North Macedonia",
                            Name = "Brvenica",
                            PrimaryCity = "Brvenica"
                        },
                        new
                        {
                            Id = new Guid("2bc55da8-a438-4abf-b202-273743a32501"),
                            Country = "North Macedonia",
                            Name = "Centar Župa",
                            PrimaryCity = "Centar Župa"
                        },
                        new
                        {
                            Id = new Guid("bbeb80cd-6cb9-4a0a-9c87-ec090e095e2f"),
                            Country = "North Macedonia",
                            Name = "Dolneni",
                            PrimaryCity = "Dolneni"
                        },
                        new
                        {
                            Id = new Guid("3eb033f0-7799-43e7-96ef-15305a0373f6"),
                            Country = "North Macedonia",
                            Name = "Belčišta",
                            PrimaryCity = "Debarca"
                        },
                        new
                        {
                            Id = new Guid("558277cd-8994-4676-a023-f9bcbfc1aa7e"),
                            Country = "North Macedonia",
                            Name = "Čučer-Sandevo",
                            PrimaryCity = "Čučer-Sandevo"
                        },
                        new
                        {
                            Id = new Guid("65b9662d-1dab-42cb-a0e8-a085ee59e201"),
                            Country = "North Macedonia",
                            Name = "Zelenikovo",
                            PrimaryCity = "Zelenikovo"
                        },
                        new
                        {
                            Id = new Guid("ccf62cb0-07b7-4faf-aceb-3d06123d6a6b"),
                            Country = "North Macedonia",
                            Name = "Petrovec",
                            PrimaryCity = "Petrovec"
                        },
                        new
                        {
                            Id = new Guid("8683e1dd-4979-49b3-a319-0b33b2d610e3"),
                            Country = "North Macedonia",
                            Name = "Želino",
                            PrimaryCity = "Želino"
                        },
                        new
                        {
                            Id = new Guid("0ffe85a6-9b60-46bb-b963-e180ea322138"),
                            Country = "North Macedonia",
                            Name = "Star Dojran",
                            PrimaryCity = "Dojran"
                        },
                        new
                        {
                            Id = new Guid("992c987a-6816-4d62-9823-4e22b82fc100"),
                            Country = "North Macedonia",
                            Name = "Studeničani",
                            PrimaryCity = "Studeničani"
                        },
                        new
                        {
                            Id = new Guid("3c1ba78c-38de-4de2-8431-15ba434cdf01"),
                            Country = "North Macedonia",
                            Name = "Bogovinje",
                            PrimaryCity = "Bogovinje"
                        },
                        new
                        {
                            Id = new Guid("2974f1e7-ccbf-47f9-9e08-ac8fc9d6c1cc"),
                            Country = "North Macedonia",
                            Name = "Ilinden",
                            PrimaryCity = "Ilinden"
                        },
                        new
                        {
                            Id = new Guid("f13b1941-d7da-41c7-b933-bfe30471166f"),
                            Country = "North Macedonia",
                            Name = "Lipkovo",
                            PrimaryCity = "Lipkovo"
                        },
                        new
                        {
                            Id = new Guid("ad33a066-b51a-4592-8f4b-4d1893b2511c"),
                            Country = "North Macedonia",
                            Name = "Makedonska Kamenica",
                            PrimaryCity = "Makedonska Kamenica"
                        },
                        new
                        {
                            Id = new Guid("bcdca797-0f34-49f3-b152-cf6bd3519944"),
                            Country = "North Macedonia",
                            Name = "Resen",
                            PrimaryCity = "Resen"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "c9134910-8497-4516-9c71-0d3588ff5650",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "d7ebf2d2-986c-49e6-8de3-951a7ec62255",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Local_Alternatives.Models.Company", b =>
                {
                    b.HasBaseType("Local_Alternatives.Models.AppUser");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("CityId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasIndex("CityId");

                    b.HasDiscriminator().HasValue("Company");
                });

            modelBuilder.Entity("Local_Alternatives.Models.NormalUser", b =>
                {
                    b.HasBaseType("Local_Alternatives.Models.AppUser");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("CityId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasIndex("CityId");

                    b.ToTable("AspNetUsers", t =>
                        {
                            t.Property("Address")
                                .HasColumnName("NormalUser_Address");

                            t.Property("CityId")
                                .HasColumnName("NormalUser_CityId");

                            t.Property("CreatedAt")
                                .HasColumnName("NormalUser_CreatedAt");

                            t.Property("Name")
                                .HasColumnName("NormalUser_Name");

                            t.Property("UpdatedAt")
                                .HasColumnName("NormalUser_UpdatedAt");
                        });

                    b.HasDiscriminator().HasValue("NormalUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Local_Alternatives.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Local_Alternatives.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Local_Alternatives.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Local_Alternatives.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Local_Alternatives.Models.Company", b =>
                {
                    b.HasOne("Local_Alternatives.Models.Cities", "City")
                        .WithMany("Companies")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Local_Alternatives.Models.NormalUser", b =>
                {
                    b.HasOne("Local_Alternatives.Models.Cities", "City")
                        .WithMany("NormalUsers")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Local_Alternatives.Models.Cities", b =>
                {
                    b.Navigation("Companies");

                    b.Navigation("NormalUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
