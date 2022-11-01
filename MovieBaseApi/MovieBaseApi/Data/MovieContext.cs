﻿using Microsoft.EntityFrameworkCore;
using MovieBaseApi.Models;

namespace MovieBaseApi.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext()
        {

        }
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {

        }

        public virtual DbSet<Actor>? Actors { get; set; }
        public virtual DbSet<ActorRating>? ActorRatings { get; set; }
        public virtual DbSet<Director>? Directors { get; set; }
        public virtual DbSet<Movie>? Movies { get; set; }
        public virtual DbSet<MovieRating>? MovieRatings { get; set; }
        public virtual DbSet<ScreenWriter>? ScreenWriters { get; set; }
        public virtual DbSet<User>? Users { get; set; }
        public virtual DbSet<ActorMovie>? ActorMovie { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Database=postgresMovie;Username=postgres;Password=mysecretpassword");
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<Actor>(entity =>
            {
                entity.ToTable("actors", "moviebase");
                entity.Property(e => e.ActorId)
                .ValueGeneratedOnAdd()
                .HasColumnName("actor_id");
                entity.Property(e => e.FirstName)
                .HasColumnName("first_name");
                entity.Property(e => e.LastName)
                .HasColumnName("last_name");
                entity.Property(e => e.BirthDate)
                .HasColumnName("birth_date");
                entity.Property(e => e.Nationality)
                .HasColumnName("Nationality");
                entity.Property(e => e.MovieId)
                .HasColumnName("movie_id");

            });

            modelBuilder.Entity<ActorRating>(entity =>
            {
                entity.ToTable("actor_ratings", "moviebase");
                entity.Property(e => e.ActorRatingId)
                .ValueGeneratedOnAdd()
                .HasColumnName("actor_rating_id");
                entity.Property(e => e.RatingDate)
                .HasColumnName("rating_date");
                entity.Property(e => e.RatingValue)
                .HasColumnName("rating_value");
                entity.Property(e => e.UserId)
                .HasColumnName("user_id");
                entity.Property(e => e.ActorId)
                .HasColumnName("actor_id");

                //entity.HasOne(d => d.User)
                //.WithOne(p => p.ActorRating)
                //.HasForeignKey<ActorRating>(ad => ad.IdUser)
                //.HasConstraintName("action_rating_user_id_fkey");

                //entity.HasOne<Actor>(s => s.Actor)
                //.WithMany(g => g.ActorRatings)
                //.HasForeignKey(s => s.IdActor);

            });

            modelBuilder.Entity<Director>(entity =>
            {
                entity.ToTable("directors", "moviebase");
                entity.Property(e => e.DirectorId)
                .ValueGeneratedOnAdd()
                .HasColumnName("director_id");
                entity.Property(e => e.FirstName)
                .HasColumnName("first_name");
                entity.Property(e => e.LastName)
                .HasColumnName("last_name");
                entity.Property(e => e.BirthDate)
                .HasColumnName("birth_date");
                entity.Property(e => e.Nationality)
                .HasColumnName("nationality");

            });

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.ToTable("movies", "moviebase");
                entity.Property(e => e.MovieId)
                .ValueGeneratedOnAdd()
                .HasColumnName("movie_id");
                entity.Property(e => e.Title)
                .HasColumnName("title");
                entity.Property(e => e.RelaseDate)
                .HasColumnName("release_date");
                entity.Property(e => e.Category)
                .HasColumnName("category");
                entity.Property(e => e.ScreenWriterId)
                .HasColumnName("ScreenWriterId");
                entity.Property(e => e.DirectorId)
                .HasColumnName("Director_id");

                //entity.HasOne<Director>(s => s.Director)
                //.WithMany(g => g.Movies)
                //.HasForeignKey(s => s.DirectorId);

                //entity.HasOne<ScreenWriter>(s => s.ScreenWriter)
                //.WithMany(g => g.Movies)
                //.HasForeignKey(s => s.ScreeWriterId);

            });

            modelBuilder.Entity<MovieRating>(entity =>
            {
                entity.ToTable("movie_ratings", "moviebase");
                entity.Property(e => e.MovieRatingId)
                .ValueGeneratedOnAdd()
                .HasColumnName("movie_rating_id");
                entity.Property(e => e.RatingDate)
                .HasColumnName("rating_date");
                entity.Property(e => e.MovieId)
                .HasColumnName("movie_id");
                entity.Property(e => e.UserId)
                .HasColumnName("user_id");

                //entity.HasOne<Movie>(s => s.Movie)
                //.WithMany(g => g.MovieRatings)
                //.HasForeignKey(s => s.IdMovie);
            });

            modelBuilder.Entity<ScreenWriter>(entity =>
            {
                entity.ToTable("screen_writers", "moviebase");
                entity.Property(e => e.ScreenWriterId)
                .ValueGeneratedOnAdd()
                .HasColumnName("screen_writer_id");
                entity.Property(e => e.FirstName)
                .HasColumnName("first_name");
                entity.Property(e => e.LastName)
                .HasColumnName("last_name");
                entity.Property(e => e.Nationality)
                .HasColumnName("nationality");
                entity.Property(e => e.BirthDate)
                .HasColumnName("birth_date");
            });
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users", "moviebase");
                entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
                entity.Property(e => e.FirstName)
                .HasColumnName("first_name");
                entity.Property(e => e.LastName)
                .HasColumnName("last_name");
                entity.Property(e => e.RegisterDate)
                .HasColumnName("register_data");

            });

            modelBuilder.Entity<ActorMovie>().HasKey(sc => new { sc.ActorId, sc.MovieId });

            modelBuilder.Entity<ActorMovie>()
            .HasOne<Movie>(sc => sc.Movie)
            .WithMany(s => s.ActorMovie)
             .HasForeignKey(sc => sc.ActorId);


            modelBuilder.Entity<ActorMovie>()
            .HasOne<Actor>(sc => sc.Actor)
            .WithMany(s => s.ActorMovie)
            .HasForeignKey(sc => sc.MovieId);
        }
        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

