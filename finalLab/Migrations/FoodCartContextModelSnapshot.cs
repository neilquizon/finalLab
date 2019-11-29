﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using finalLab;

namespace finalLab.Migrations
{
    [DbContext(typeof(FoodCartContext))]
    partial class FoodCartContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("finalLab.FoodCart", b =>
                {
                    b.Property<string>("key")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("business_name");

                    b.Property<string>("description");

                    b.Property<string>("geo_localarea");

                    b.Property<float>("latitude");

                    b.Property<string>("location");

                    b.Property<float>("longitude");

                    b.Property<string>("status");

                    b.Property<string>("vendor_type");

                    b.HasKey("key");

                    b.ToTable("FoodCarts");
                });
#pragma warning restore 612, 618
        }
    }
}
