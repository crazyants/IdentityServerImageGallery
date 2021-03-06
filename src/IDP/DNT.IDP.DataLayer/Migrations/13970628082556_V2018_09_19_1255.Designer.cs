﻿// <auto-generated />
using DNT.IDP.DataLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DNT.IDP.DataLayer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("13970628082556_V2018_09_19_1255")]
    partial class V2018_09_19_1255
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DNT.IDP.DomainClasses.User", b =>
                {
                    b.Property<string>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<bool>("IsActive");

                    b.Property<string>("Password")
                        .HasMaxLength(100);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("SubjectId");

                    b.ToTable("Users");

                    b.HasData(
                        new { SubjectId = "d860efca-22d9-47fd-8249-791ba61b07c7", IsActive = true, Password = "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", Username = "User 1" },
                        new { SubjectId = "b7539694-97e7-4dfe-84da-b4256e1ff5c7", IsActive = true, Password = "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", Username = "User 2" }
                    );
                });

            modelBuilder.Entity("DNT.IDP.DomainClasses.UserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("ClaimValue")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("SubjectId")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("SubjectId", "ClaimType")
                        .IsUnique();

                    b.ToTable("UserClaims");

                    b.HasData(
                        new { Id = 1, ClaimType = "given_name", ClaimValue = "Vahid", SubjectId = "d860efca-22d9-47fd-8249-791ba61b07c7" },
                        new { Id = 2, ClaimType = "family_name", ClaimValue = "N", SubjectId = "d860efca-22d9-47fd-8249-791ba61b07c7" },
                        new { Id = 3, ClaimType = "address", ClaimValue = "Main Road 1", SubjectId = "d860efca-22d9-47fd-8249-791ba61b07c7" },
                        new { Id = 4, ClaimType = "role", ClaimValue = "PayingUser", SubjectId = "d860efca-22d9-47fd-8249-791ba61b07c7" },
                        new { Id = 5, ClaimType = "subscriptionlevel", ClaimValue = "PayingUser", SubjectId = "d860efca-22d9-47fd-8249-791ba61b07c7" },
                        new { Id = 6, ClaimType = "country", ClaimValue = "ir", SubjectId = "d860efca-22d9-47fd-8249-791ba61b07c7" },
                        new { Id = 7, ClaimType = "given_name", ClaimValue = "User 2", SubjectId = "b7539694-97e7-4dfe-84da-b4256e1ff5c7" },
                        new { Id = 8, ClaimType = "family_name", ClaimValue = "Test", SubjectId = "b7539694-97e7-4dfe-84da-b4256e1ff5c7" },
                        new { Id = 9, ClaimType = "address", ClaimValue = "Big Street 2", SubjectId = "b7539694-97e7-4dfe-84da-b4256e1ff5c7" },
                        new { Id = 10, ClaimType = "role", ClaimValue = "FreeUser", SubjectId = "b7539694-97e7-4dfe-84da-b4256e1ff5c7" },
                        new { Id = 11, ClaimType = "subscriptionlevel", ClaimValue = "FreeUser", SubjectId = "b7539694-97e7-4dfe-84da-b4256e1ff5c7" },
                        new { Id = 12, ClaimType = "country", ClaimValue = "be", SubjectId = "b7539694-97e7-4dfe-84da-b4256e1ff5c7" }
                    );
                });

            modelBuilder.Entity("DNT.IDP.DomainClasses.UserLogin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LoginProvider")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("ProviderKey")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("SubjectId")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("SubjectId", "LoginProvider")
                        .IsUnique();

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("DNT.IDP.DomainClasses.UserClaim", b =>
                {
                    b.HasOne("DNT.IDP.DomainClasses.User", "User")
                        .WithMany("UserClaims")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DNT.IDP.DomainClasses.UserLogin", b =>
                {
                    b.HasOne("DNT.IDP.DomainClasses.User", "User")
                        .WithMany("UserLogins")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
