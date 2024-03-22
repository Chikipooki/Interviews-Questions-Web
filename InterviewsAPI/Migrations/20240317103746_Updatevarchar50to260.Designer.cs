﻿// <auto-generated />
using InterviewsAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace InterviewsAPI.Migrations
{
    [DbContext(typeof(InterviewDbContect))]
    [Migration("20240317103746_Updatevarchar50to260")]
    partial class Updatevarchar50to260
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("InterviewsAPI.Models.Participant", b =>
                {
                    b.Property<int>("ParticipantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ParticipantId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Score")
                        .HasColumnType("integer");

                    b.Property<int>("TimeToken")
                        .HasColumnType("integer");

                    b.HasKey("ParticipantId");

                    b.ToTable("Participants");
                });

            modelBuilder.Entity("InterviewsAPI.Models.Questions", b =>
                {
                    b.Property<int>("QnId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("QnId"));

                    b.Property<int>("Answer")
                        .HasColumnType("integer");

                    b.Property<string>("ImageName")
                        .HasColumnType("varchar(260)");

                    b.Property<string>("Option1")
                        .IsRequired()
                        .HasColumnType("varchar(260)");

                    b.Property<string>("Option2")
                        .IsRequired()
                        .HasColumnType("varchar(260)");

                    b.Property<string>("Option3")
                        .IsRequired()
                        .HasColumnType("varchar(260)");

                    b.Property<string>("Option4")
                        .IsRequired()
                        .HasColumnType("varchar(260)");

                    b.Property<string>("QnInWords")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.HasKey("QnId");

                    b.ToTable("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}
