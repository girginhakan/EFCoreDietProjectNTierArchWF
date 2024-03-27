﻿// <auto-generated />
using System;
using DietProject.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DietProject.DAL.Migrations
{
    [DbContext(typeof(DietProjectDbContext))]
    [Migration("20240327141909_mig22")]
    partial class mig22
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DietProject.DAL.Entities.Kategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EntityStatus")
                        .HasColumnType("int");

                    b.Property<string>("KategoriAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Kategoriler");
                });

            modelBuilder.Entity("DietProject.DAL.Entities.Kullanici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Boy")
                        .HasColumnType("float");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("EntityStatus")
                        .HasColumnType("int");

                    b.Property<string>("Eposta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Kilo")
                        .HasColumnType("float");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserStatus")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Kullanicilar");

                    b.HasData(
                        new
                        {
                            Id = 16,
                            Adi = "Admin Adı",
                            Boy = 175.0,
                            CreatedDate = new DateTime(2024, 3, 27, 17, 19, 9, 569, DateTimeKind.Local).AddTicks(4136),
                            DogumTarihi = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EntityStatus = 0,
                            Eposta = "admin",
                            Kilo = 75.0,
                            Sifre = "03AC674216F3E15C761EE1A5E255F067953623C8B388B4459E13F978D7C846F4",
                            Soyadi = "Admin Soyadı",
                            UserStatus = 2
                        });
                });

            modelBuilder.Entity("DietProject.DAL.Entities.KullaniciOgunYemekPorsiyon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EntityStatus")
                        .HasColumnType("int");

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<int>("OgunId")
                        .HasColumnType("int");

                    b.Property<int>("PorsiyonId")
                        .HasColumnType("int");

                    b.Property<double>("ToplamKalori")
                        .HasColumnType("float");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("YemekId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KullaniciId");

                    b.HasIndex("OgunId");

                    b.HasIndex("PorsiyonId");

                    b.HasIndex("YemekId");

                    b.ToTable("KullaniciOgunYemekPorsiyonlar");
                });

            modelBuilder.Entity("DietProject.DAL.Entities.Ogun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EntityStatus")
                        .HasColumnType("int");

                    b.Property<string>("OgunAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Ogunler");
                });

            modelBuilder.Entity("DietProject.DAL.Entities.Porsiyon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EntityStatus")
                        .HasColumnType("int");

                    b.Property<string>("PorsiyonBirim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Porsiyonlar");
                });

            modelBuilder.Entity("DietProject.DAL.Entities.Yemek", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EntityStatus")
                        .HasColumnType("int");

                    b.Property<int>("Kalori")
                        .HasColumnType("int");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<double>("PorsiyonMiktari")
                        .HasColumnType("float");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("YemekAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.ToTable("Yemekler");
                });

            modelBuilder.Entity("DietProject.DAL.Entities.KullaniciOgunYemekPorsiyon", b =>
                {
                    b.HasOne("DietProject.DAL.Entities.Kullanici", "Kullanici")
                        .WithMany("KullaniciOgunYemekPorsiyonlar")
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DietProject.DAL.Entities.Ogun", "Ogun")
                        .WithMany("KullaniciOgunYemekPorsiyonlar")
                        .HasForeignKey("OgunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DietProject.DAL.Entities.Porsiyon", "Porsiyon")
                        .WithMany("KullaniciOgunYemekPorsiyonlar")
                        .HasForeignKey("PorsiyonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DietProject.DAL.Entities.Yemek", "Yemek")
                        .WithMany("KullaniciOgunYemekPorsiyonlar")
                        .HasForeignKey("YemekId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kullanici");

                    b.Navigation("Ogun");

                    b.Navigation("Porsiyon");

                    b.Navigation("Yemek");
                });

            modelBuilder.Entity("DietProject.DAL.Entities.Yemek", b =>
                {
                    b.HasOne("DietProject.DAL.Entities.Kategori", "Kategori")
                        .WithMany("Yemekler")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("DietProject.DAL.Entities.Kategori", b =>
                {
                    b.Navigation("Yemekler");
                });

            modelBuilder.Entity("DietProject.DAL.Entities.Kullanici", b =>
                {
                    b.Navigation("KullaniciOgunYemekPorsiyonlar");
                });

            modelBuilder.Entity("DietProject.DAL.Entities.Ogun", b =>
                {
                    b.Navigation("KullaniciOgunYemekPorsiyonlar");
                });

            modelBuilder.Entity("DietProject.DAL.Entities.Porsiyon", b =>
                {
                    b.Navigation("KullaniciOgunYemekPorsiyonlar");
                });

            modelBuilder.Entity("DietProject.DAL.Entities.Yemek", b =>
                {
                    b.Navigation("KullaniciOgunYemekPorsiyonlar");
                });
#pragma warning restore 612, 618
        }
    }
}
