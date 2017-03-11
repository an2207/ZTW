using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Model.Models;

namespace Model.Migrations
{
    [DbContext(typeof(MarketContext))]
    [Migration("20170311195327_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Model.Models.Favorite", b =>
                {
                    b.Property<int>("FavoriteId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("OfferId");

                    b.Property<int?>("UserId");

                    b.HasKey("FavoriteId");

                    b.HasIndex("OfferId");

                    b.HasIndex("UserId");

                    b.ToTable("Favorites");
                });

            modelBuilder.Entity("Model.Models.Offer", b =>
                {
                    b.Property<int>("OfferId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("ABS");

                    b.Property<bool>("AirCond");

                    b.Property<bool>("Airbags");

                    b.Property<string>("Category");

                    b.Property<bool>("CentralLock");

                    b.Property<string>("Color");

                    b.Property<bool>("Damaged");

                    b.Property<string>("Description");

                    b.Property<int>("Displacement");

                    b.Property<int>("DoorsNb");

                    b.Property<string>("Drive");

                    b.Property<DateTime>("EndTime");

                    b.Property<string>("Fuel");

                    b.Property<string>("Gearbox");

                    b.Property<int>("Mileage");

                    b.Property<string>("Model");

                    b.Property<double>("Price");

                    b.Property<int>("SeatsNb");

                    b.Property<DateTime>("StartTime");

                    b.Property<string>("Status");

                    b.Property<int?>("UserId");

                    b.Property<int>("Year");

                    b.HasKey("OfferId");

                    b.HasIndex("UserId");

                    b.ToTable("Offers");
                });

            modelBuilder.Entity("Model.Models.PhotoPath", b =>
                {
                    b.Property<int>("PhotoPathId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsMain");

                    b.Property<int?>("OfferId");

                    b.Property<string>("Path");

                    b.HasKey("PhotoPathId");

                    b.HasIndex("OfferId");

                    b.ToTable("PhotosPaths");
                });

            modelBuilder.Entity("Model.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessLevel");

                    b.Property<string>("Name");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Model.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("PhoneNb");

                    b.Property<int?>("RoleId");

                    b.Property<string>("Salt");

                    b.Property<string>("Surname");

                    b.Property<string>("Username");

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Model.Models.View", b =>
                {
                    b.Property<int>("ViewId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("IP");

                    b.Property<int?>("OfferId");

                    b.Property<DateTime>("Time");

                    b.HasKey("ViewId");

                    b.HasIndex("OfferId");

                    b.ToTable("Views");
                });

            modelBuilder.Entity("Model.Models.Favorite", b =>
                {
                    b.HasOne("Model.Models.Offer", "Offer")
                        .WithMany()
                        .HasForeignKey("OfferId");

                    b.HasOne("Model.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Model.Models.Offer", b =>
                {
                    b.HasOne("Model.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Model.Models.PhotoPath", b =>
                {
                    b.HasOne("Model.Models.Offer", "Offer")
                        .WithMany()
                        .HasForeignKey("OfferId");
                });

            modelBuilder.Entity("Model.Models.User", b =>
                {
                    b.HasOne("Model.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("Model.Models.View", b =>
                {
                    b.HasOne("Model.Models.Offer", "Offer")
                        .WithMany()
                        .HasForeignKey("OfferId");
                });
        }
    }
}
