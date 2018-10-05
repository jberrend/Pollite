﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PolliteBackend.Models;

namespace PolliteBackend.Migrations
{
    [DbContext(typeof(PollContext))]
    partial class PollContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PolliteBackend.Models.Poll", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Hash");

                    b.Property<string>("Prompt");

                    b.HasKey("Id");

                    b.ToTable("Polls");
                });

            modelBuilder.Entity("PolliteBackend.Models.Voter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Hash");

                    b.Property<int?>("PollId");

                    b.HasKey("Id");

                    b.HasIndex("PollId");

                    b.ToTable("Voters");
                });

            modelBuilder.Entity("PolliteBackend.Models.Voter", b =>
                {
                    b.HasOne("PolliteBackend.Models.Poll")
                        .WithMany("Voters")
                        .HasForeignKey("PollId");
                });
#pragma warning restore 612, 618
        }
    }
}
