﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    [DbContext(typeof(CleaningContext))]
    partial class CleaningContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.4");

            modelBuilder.Entity("Core.Entities.CleanerInfo", b =>
                {
                    b.Property<int>("CleanerInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CleanerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Rating")
                        .HasColumnType("INTEGER");

                    b.HasKey("CleanerInfoId");

                    b.ToTable("CleanerInfo");
                });

            modelBuilder.Entity("Core.Entities.CleanerTeamMember", b =>
                {
                    b.Property<int>("CleanerTeamMemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CleanerInfoId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CleaningCommandId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsMain")
                        .HasColumnType("INTEGER");

                    b.HasKey("CleanerTeamMemberId");

                    b.HasIndex("CleanerInfoId");

                    b.HasIndex("CleaningCommandId");

                    b.ToTable("CleanerTeamMember");
                });

            modelBuilder.Entity("Core.Entities.CleaningCommand", b =>
                {
                    b.Property<int>("CleaningCommandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Instruments")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("OrderDescriptionId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Services")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CleaningCommandId");

                    b.HasIndex("OrderDescriptionId");

                    b.ToTable("CleaningCommand");
                });

            modelBuilder.Entity("Core.Entities.CleaningTask", b =>
                {
                    b.Property<int>("CleaningTaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDone")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TaskDescription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CleaningTaskId");

                    b.HasIndex("OrderId");

                    b.ToTable("CleaningTask");
                });

            modelBuilder.Entity("Core.Entities.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Core.Entities.Message", b =>
                {
                    b.Property<int>("MessageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("MessageType")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("OrderDescriptionId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("SendTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("Sender")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserMessageId")
                        .HasColumnType("INTEGER");

                    b.HasKey("MessageID");

                    b.HasIndex("OrderDescriptionId");

                    b.HasIndex("UserMessageId");

                    b.ToTable("Message");
                });

            modelBuilder.Entity("Core.Entities.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CustomerEmail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomerNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("OrderDescriptionId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OrderObjectDetailsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RelatedDataUserMessageId")
                        .HasColumnType("INTEGER");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("OrderDescriptionId");

                    b.HasIndex("OrderObjectDetailsId");

                    b.HasIndex("RelatedDataUserMessageId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Core.Entities.OrderDescription", b =>
                {
                    b.Property<int>("OrderDescriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsApprovedOrder")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("OrderDescriptionId");

                    b.ToTable("OrderDescription");
                });

            modelBuilder.Entity("Core.Entities.OrderObjectDetails", b =>
                {
                    b.Property<int>("OrderObjectDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CleaningArea")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CleaningDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("CleaningType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ObjectAddres")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("OrderObjectDetailsId");

                    b.ToTable("OrderObjectDetails");
                });

            modelBuilder.Entity("Core.Entities.UploadedFile", b =>
                {
                    b.Property<int>("UploadedFileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("UserMessageId")
                        .HasColumnType("INTEGER");

                    b.HasKey("UploadedFileId");

                    b.HasIndex("UserMessageId");

                    b.ToTable("UploadedFile");
                });

            modelBuilder.Entity("Core.Entities.UserMessage", b =>
                {
                    b.Property<int>("UserMessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserMessageId");

                    b.ToTable("UserMessage");
                });

            modelBuilder.Entity("Core.Entities.CleanerTeamMember", b =>
                {
                    b.HasOne("Core.Entities.CleanerInfo", "CleanerInfo")
                        .WithMany()
                        .HasForeignKey("CleanerInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.CleaningCommand", null)
                        .WithMany("MyProperty")
                        .HasForeignKey("CleaningCommandId");

                    b.Navigation("CleanerInfo");
                });

            modelBuilder.Entity("Core.Entities.CleaningCommand", b =>
                {
                    b.HasOne("Core.Entities.OrderDescription", null)
                        .WithMany("CleaningCommand")
                        .HasForeignKey("OrderDescriptionId");
                });

            modelBuilder.Entity("Core.Entities.CleaningTask", b =>
                {
                    b.HasOne("Core.Entities.Order", null)
                        .WithMany("CleaningTasks")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("Core.Entities.Message", b =>
                {
                    b.HasOne("Core.Entities.OrderDescription", null)
                        .WithMany("Messages")
                        .HasForeignKey("OrderDescriptionId");

                    b.HasOne("Core.Entities.UserMessage", "UserMessage")
                        .WithMany()
                        .HasForeignKey("UserMessageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserMessage");
                });

            modelBuilder.Entity("Core.Entities.Order", b =>
                {
                    b.HasOne("Core.Entities.Customer", null)
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId");

                    b.HasOne("Core.Entities.OrderDescription", "OrderDescription")
                        .WithMany()
                        .HasForeignKey("OrderDescriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.OrderObjectDetails", "OrderObjectDetails")
                        .WithMany()
                        .HasForeignKey("OrderObjectDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.UserMessage", "RelatedData")
                        .WithMany()
                        .HasForeignKey("RelatedDataUserMessageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrderDescription");

                    b.Navigation("OrderObjectDetails");

                    b.Navigation("RelatedData");
                });

            modelBuilder.Entity("Core.Entities.UploadedFile", b =>
                {
                    b.HasOne("Core.Entities.UserMessage", null)
                        .WithMany("Files")
                        .HasForeignKey("UserMessageId");
                });

            modelBuilder.Entity("Core.Entities.CleaningCommand", b =>
                {
                    b.Navigation("MyProperty");
                });

            modelBuilder.Entity("Core.Entities.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Core.Entities.Order", b =>
                {
                    b.Navigation("CleaningTasks");
                });

            modelBuilder.Entity("Core.Entities.OrderDescription", b =>
                {
                    b.Navigation("CleaningCommand");

                    b.Navigation("Messages");
                });

            modelBuilder.Entity("Core.Entities.UserMessage", b =>
                {
                    b.Navigation("Files");
                });
#pragma warning restore 612, 618
        }
    }
}
