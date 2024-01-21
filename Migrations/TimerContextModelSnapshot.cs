﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using time_of_your_life.Repositories;

#nullable disable

namespace time_of_your_life.Migrations
{
    [DbContext(typeof(TimerContext))]
    partial class TimerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("time_of_your_life.Entity.TimerEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Time")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TimerEntity");
                });
#pragma warning restore 612, 618
        }
    }
}
