﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieBaseApi.Data;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MovieBaseApi.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MovieBaseApi.Models.Actor", b =>
                {
                    b.Property<int>("ActorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("actor_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ActorId"));

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("birth_date");

                    b.Property<string>("FirstName")
                        .HasColumnType("text")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .HasColumnType("text")
                        .HasColumnName("last_name");

                    b.Property<int>("MovieId")
                        .HasColumnType("integer")
                        .HasColumnName("movie_id");

                    b.Property<string>("Nationality")
                        .HasColumnType("text")
                        .HasColumnName("Nationality");

                    b.HasKey("ActorId");

                    b.ToTable("actors", "moviebase");
                });

            modelBuilder.Entity("MovieBaseApi.Models.ActorMovie", b =>
                {
                    b.Property<int>("ActorId")
                        .HasColumnType("integer");

                    b.Property<int>("MovieId")
                        .HasColumnType("integer");

                    b.HasKey("ActorId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("ActorMovie");
                });

            modelBuilder.Entity("MovieBaseApi.Models.ActorRating", b =>
                {
                    b.Property<int>("ActorRatingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("actor_rating_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ActorRatingId"));

                    b.Property<int>("ActorId")
                        .HasColumnType("integer")
                        .HasColumnName("actor_id");

                    b.Property<DateTime>("RatingDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("rating_date");

                    b.Property<int>("RatingValue")
                        .HasColumnType("integer")
                        .HasColumnName("rating_value");

                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    b.HasKey("ActorRatingId");

                    b.HasIndex("ActorId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("actor_ratings", "moviebase");
                });

            modelBuilder.Entity("MovieBaseApi.Models.Director", b =>
                {
                    b.Property<int>("DirectorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("director_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("DirectorId"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("birth_date");

                    b.Property<string>("FirstName")
                        .HasColumnType("text")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .HasColumnType("text")
                        .HasColumnName("last_name");

                    b.Property<string>("Nationality")
                        .HasColumnType("text")
                        .HasColumnName("nationality");

                    b.HasKey("DirectorId");

                    b.ToTable("directors", "moviebase");
                });

            modelBuilder.Entity("MovieBaseApi.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("movie_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("MovieId"));

                    b.Property<string>("Category")
                        .HasColumnType("text")
                        .HasColumnName("category");

                    b.Property<int>("DirectorId")
                        .HasColumnType("integer")
                        .HasColumnName("Director_id");

                    b.Property<DateTime>("RelaseDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("release_date");

                    b.Property<int>("ScreenWriterId")
                        .HasColumnType("integer")
                        .HasColumnName("ScreenWriterId");

                    b.Property<string>("Title")
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.HasKey("MovieId");

                    b.HasIndex("DirectorId");

                    b.HasIndex("ScreenWriterId");

                    b.ToTable("movies", "moviebase");
                });

            modelBuilder.Entity("MovieBaseApi.Models.MovieRating", b =>
                {
                    b.Property<int>("MovieRatingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("movie_rating_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("MovieRatingId"));

                    b.Property<int>("MovieId")
                        .HasColumnType("integer")
                        .HasColumnName("movie_id");

                    b.Property<DateTime>("RatingDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("rating_date");

                    b.Property<int>("RatingValue")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    b.HasKey("MovieRatingId");

                    b.HasIndex("MovieId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("movie_ratings", "moviebase");
                });

            modelBuilder.Entity("MovieBaseApi.Models.ScreenWriter", b =>
                {
                    b.Property<int>("ScreenWriterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("screen_writer_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ScreenWriterId"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("birth_date");

                    b.Property<string>("FirstName")
                        .HasColumnType("text")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .HasColumnType("text")
                        .HasColumnName("last_name");

                    b.Property<string>("Nationality")
                        .HasColumnType("text")
                        .HasColumnName("nationality");

                    b.HasKey("ScreenWriterId");

                    b.ToTable("screen_writers", "moviebase");
                });

            modelBuilder.Entity("MovieBaseApi.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .HasColumnType("text")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .HasColumnType("text")
                        .HasColumnName("last_name");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("register_data");

                    b.HasKey("Id");

                    b.ToTable("users", "moviebase");
                });

            modelBuilder.Entity("MovieBaseApi.Models.ActorMovie", b =>
                {
                    b.HasOne("MovieBaseApi.Models.Movie", "Movie")
                        .WithMany("ActorMovie")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieBaseApi.Models.Actor", "Actor")
                        .WithMany("ActorMovie")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("MovieBaseApi.Models.ActorRating", b =>
                {
                    b.HasOne("MovieBaseApi.Models.Actor", "Actor")
                        .WithMany("ActorRating")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieBaseApi.Models.User", "User")
                        .WithOne("ActorRating")
                        .HasForeignKey("MovieBaseApi.Models.ActorRating", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MovieBaseApi.Models.Movie", b =>
                {
                    b.HasOne("MovieBaseApi.Models.Director", "Director")
                        .WithMany("Movies")
                        .HasForeignKey("DirectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieBaseApi.Models.ScreenWriter", "ScreenWriter")
                        .WithMany("Movies")
                        .HasForeignKey("ScreenWriterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Director");

                    b.Navigation("ScreenWriter");
                });

            modelBuilder.Entity("MovieBaseApi.Models.MovieRating", b =>
                {
                    b.HasOne("MovieBaseApi.Models.Movie", "Movie")
                        .WithMany("MovieRating")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieBaseApi.Models.User", "User")
                        .WithOne("MovieRating")
                        .HasForeignKey("MovieBaseApi.Models.MovieRating", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MovieBaseApi.Models.Actor", b =>
                {
                    b.Navigation("ActorMovie");

                    b.Navigation("ActorRating");
                });

            modelBuilder.Entity("MovieBaseApi.Models.Director", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("MovieBaseApi.Models.Movie", b =>
                {
                    b.Navigation("ActorMovie");

                    b.Navigation("MovieRating");
                });

            modelBuilder.Entity("MovieBaseApi.Models.ScreenWriter", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("MovieBaseApi.Models.User", b =>
                {
                    b.Navigation("ActorRating");

                    b.Navigation("MovieRating");
                });
#pragma warning restore 612, 618
        }
    }
}
