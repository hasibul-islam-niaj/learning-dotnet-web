﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using learning_dotnet_web.Data;

#nullable disable

namespace learning_dotnet_web.Migrations
{
    [DbContext(typeof(LearningContext))]
    [Migration("20220804081830_InitDb1")]
    partial class InitDb1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("learning_dotnet_web.Data.Entities.User", b =>
                {
                    b.Property<int>("Id1")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id1"));

                    b.Property<string>("Email1")
                        .HasColumnType("text");

                    b.Property<string>("Name1")
                        .HasColumnType("text");

                    b.Property<string>("Pphone1")
                        .HasColumnType("text");

                    b.HasKey("Id1");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
