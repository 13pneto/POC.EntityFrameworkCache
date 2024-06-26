﻿// <auto-generated />
using System;
using Ef_Cache.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ef_Cache.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240620182454_1")]
    partial class _1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("CategoryStore", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StoresId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CategoriesId", "StoresId");

                    b.HasIndex("StoresId");

                    b.ToTable("CategoryStore");
                });

            modelBuilder.Entity("Ef_Cache.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param1")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param10")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param11")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param12")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param13")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param14")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param15")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param16")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param17")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param18")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param19")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param2")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param20")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param3")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param4")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param5")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param6")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param7")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param8")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param9")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Ef_Cache.Entities.Option", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("OptionGroupId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Param1")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param10")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param11")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param12")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param13")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param14")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param15")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param16")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param17")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param18")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param19")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param2")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param20")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param3")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param4")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param5")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param6")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param7")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param8")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param9")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("OptionGroupId");

                    b.ToTable("Option");
                });

            modelBuilder.Entity("Ef_Cache.Entities.OptionGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("Max")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Min")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param1")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param10")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param11")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param12")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param13")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param14")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param15")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param16")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param17")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param18")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param19")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param2")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param20")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param3")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param4")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param5")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param6")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param7")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param8")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param9")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("ProductId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("OptionGroups");
                });

            modelBuilder.Entity("Ef_Cache.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param1")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param10")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param11")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param12")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param13")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param14")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param15")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param16")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param17")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param18")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param19")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param2")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param20")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param3")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param4")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param5")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param6")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param7")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param8")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param9")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Ef_Cache.Entities.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param1")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param10")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param11")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param12")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param13")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param14")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param15")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param16")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param17")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param18")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param19")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param2")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param20")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param3")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param4")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param5")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param6")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param7")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param8")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Param9")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Store");
                });

            modelBuilder.Entity("CategoryStore", b =>
                {
                    b.HasOne("Ef_Cache.Entities.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ef_Cache.Entities.Store", null)
                        .WithMany()
                        .HasForeignKey("StoresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Ef_Cache.Entities.Option", b =>
                {
                    b.HasOne("Ef_Cache.Entities.OptionGroup", null)
                        .WithMany("Options")
                        .HasForeignKey("OptionGroupId");
                });

            modelBuilder.Entity("Ef_Cache.Entities.OptionGroup", b =>
                {
                    b.HasOne("Ef_Cache.Entities.Product", null)
                        .WithMany("OptionGroups")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("Ef_Cache.Entities.Product", b =>
                {
                    b.HasOne("Ef_Cache.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Ef_Cache.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Ef_Cache.Entities.OptionGroup", b =>
                {
                    b.Navigation("Options");
                });

            modelBuilder.Entity("Ef_Cache.Entities.Product", b =>
                {
                    b.Navigation("OptionGroups");
                });
#pragma warning restore 612, 618
        }
    }
}
