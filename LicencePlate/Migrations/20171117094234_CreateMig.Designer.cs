using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using LicencePlate.Entities;

namespace LicencePlate.Migrations
{
    [DbContext(typeof(LicencePlateContext))]
    [Migration("20171117094234_CreateMig")]
    partial class CreateMig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LicencePlate.Models.LicencePlateClass", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("car_brand");

                    b.Property<string>("car_model");

                    b.Property<string>("color");

                    b.Property<string>("plate");

                    b.Property<int>("year");

                    b.HasKey("Id");

                    b.ToTable("licence_plates");
                });
        }
    }
}
