﻿// <auto-generated />
using System;
using ImageDataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ImageDataBase.Migrations
{
    [DbContext(typeof(ImageDB))]
    partial class ImageDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("ImageRecognitionContract.Image", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImageHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ImagePhotoImageDataId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ImageId");

                    b.HasIndex("ImagePhotoImageDataId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("ImageRecognitionContract.ImageData", b =>
                {
                    b.Property<int>("ImageDataId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("ImageDataArray")
                        .HasColumnType("BLOB");

                    b.HasKey("ImageDataId");

                    b.ToTable("ImageData");
                });

            modelBuilder.Entity("ImageRecognitionContract.ImageObject", b =>
                {
                    b.Property<int>("ImageObjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ImageId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImageObjectName")
                        .HasColumnType("TEXT");

                    b.Property<float>("X1")
                        .HasColumnType("REAL");

                    b.Property<float>("X2")
                        .HasColumnType("REAL");

                    b.Property<float>("Y1")
                        .HasColumnType("REAL");

                    b.Property<float>("Y2")
                        .HasColumnType("REAL");

                    b.HasKey("ImageObjectId");

                    b.HasIndex("ImageId");

                    b.ToTable("ImageObject");
                });

            modelBuilder.Entity("ImageRecognitionContract.Image", b =>
                {
                    b.HasOne("ImageRecognitionContract.ImageData", "ImagePhoto")
                        .WithMany()
                        .HasForeignKey("ImagePhotoImageDataId");

                    b.Navigation("ImagePhoto");
                });

            modelBuilder.Entity("ImageRecognitionContract.ImageObject", b =>
                {
                    b.HasOne("ImageRecognitionContract.Image", null)
                        .WithMany("ImageObjects")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ImageRecognitionContract.Image", b =>
                {
                    b.Navigation("ImageObjects");
                });
#pragma warning restore 612, 618
        }
    }
}
