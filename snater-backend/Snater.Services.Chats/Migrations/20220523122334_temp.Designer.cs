﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Snater.Services.Chats.Data;

#nullable disable

namespace Snater.Services.Chats.Migrations
{
    [DbContext(typeof(ChatContext))]
    [Migration("20220523122334_temp")]
    partial class temp
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Snater.Services.Chats.Models.Chat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastMessageTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("Snater.Services.Chats.Models.DTO.ChatUser", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ChatId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId");

                    b.HasIndex("ChatId");

                    b.ToTable("ChatUsers");
                });

            modelBuilder.Entity("Snater.Services.Chats.Models.Message", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ChatId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ChatId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ReadTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ReceiveTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("SendTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("SenderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.HasIndex("ChatId1")
                        .IsUnique()
                        .HasFilter("[ChatId1] IS NOT NULL");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Snater.Services.Chats.Models.DTO.ChatUser", b =>
                {
                    b.HasOne("Snater.Services.Chats.Models.Chat", "Chat")
                        .WithMany("ChatUsers")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chat");
                });

            modelBuilder.Entity("Snater.Services.Chats.Models.Message", b =>
                {
                    b.HasOne("Snater.Services.Chats.Models.Chat", "Chat")
                        .WithMany("Messages")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Snater.Services.Chats.Models.Chat", null)
                        .WithOne("LastMessage")
                        .HasForeignKey("Snater.Services.Chats.Models.Message", "ChatId1");

                    b.Navigation("Chat");
                });

            modelBuilder.Entity("Snater.Services.Chats.Models.Chat", b =>
                {
                    b.Navigation("ChatUsers");

                    b.Navigation("LastMessage");

                    b.Navigation("Messages");
                });
#pragma warning restore 612, 618
        }
    }
}
