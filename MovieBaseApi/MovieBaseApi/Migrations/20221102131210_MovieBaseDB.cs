using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MovieBaseApi.Migrations
{
    public partial class MovieBaseDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "moviebase");

            migrationBuilder.CreateTable(
                name: "actors",
                schema: "moviebase",
                columns: table => new
                {
                    actor_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    first_name = table.Column<string>(type: "text", nullable: true),
                    last_name = table.Column<string>(type: "text", nullable: true),
                    birth_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Nationality = table.Column<string>(type: "text", nullable: true),
                    movie_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_actors", x => x.actor_id);
                });

            migrationBuilder.CreateTable(
                name: "directors",
                schema: "moviebase",
                columns: table => new
                {
                    director_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    first_name = table.Column<string>(type: "text", nullable: true),
                    last_name = table.Column<string>(type: "text", nullable: true),
                    birth_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    nationality = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_directors", x => x.director_id);
                });

            migrationBuilder.CreateTable(
                name: "screen_writers",
                schema: "moviebase",
                columns: table => new
                {
                    screen_writer_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    first_name = table.Column<string>(type: "text", nullable: true),
                    last_name = table.Column<string>(type: "text", nullable: true),
                    birth_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    nationality = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_screen_writers", x => x.screen_writer_id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                schema: "moviebase",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    first_name = table.Column<string>(type: "text", nullable: true),
                    last_name = table.Column<string>(type: "text", nullable: true),
                    register_data = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.user_id);
                });

            migrationBuilder.CreateTable(
                name: "movies",
                schema: "moviebase",
                columns: table => new
                {
                    movie_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "text", nullable: true),
                    release_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    category = table.Column<string>(type: "text", nullable: true),
                    Director_id = table.Column<int>(type: "integer", nullable: false),
                    ScreenWriterId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movies", x => x.movie_id);
                    table.ForeignKey(
                        name: "FK_movies_directors_Director_id",
                        column: x => x.Director_id,
                        principalSchema: "moviebase",
                        principalTable: "directors",
                        principalColumn: "director_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_movies_screen_writers_ScreenWriterId",
                        column: x => x.ScreenWriterId,
                        principalSchema: "moviebase",
                        principalTable: "screen_writers",
                        principalColumn: "screen_writer_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "actor_ratings",
                schema: "moviebase",
                columns: table => new
                {
                    actor_rating_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_id = table.Column<int>(type: "integer", nullable: false),
                    rating_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    actor_id = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_actor_ratings", x => x.actor_rating_id);
                    table.ForeignKey(
                        name: "FK_actor_ratings_actors_actor_id",
                        column: x => x.actor_id,
                        principalSchema: "moviebase",
                        principalTable: "actors",
                        principalColumn: "actor_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_actor_ratings_users_UserId",
                        column: x => x.UserId,
                        principalSchema: "moviebase",
                        principalTable: "users",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "contact",
                schema: "moviebase",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    email = table.Column<string>(type: "text", nullable: true),
                    phone_number = table.Column<string>(type: "text", nullable: true),
                    user_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contact", x => x.ContactId);
                    table.ForeignKey(
                        name: "FK_contact_users_user_id",
                        column: x => x.user_id,
                        principalSchema: "moviebase",
                        principalTable: "users",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "actor_movie",
                schema: "moviebase",
                columns: table => new
                {
                    ActorId = table.Column<int>(type: "integer", nullable: false),
                    MovieId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_actor_movie", x => new { x.ActorId, x.MovieId });
                    table.ForeignKey(
                        name: "FK_actor_movie_actors_ActorId",
                        column: x => x.ActorId,
                        principalSchema: "moviebase",
                        principalTable: "actors",
                        principalColumn: "actor_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_actor_movie_movies_MovieId",
                        column: x => x.MovieId,
                        principalSchema: "moviebase",
                        principalTable: "movies",
                        principalColumn: "movie_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "movie_ratings",
                schema: "moviebase",
                columns: table => new
                {
                    movie_rating_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RatingValue = table.Column<int>(type: "integer", nullable: false),
                    rating_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    movie_id = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movie_ratings", x => x.movie_rating_id);
                    table.ForeignKey(
                        name: "FK_movie_ratings_movies_movie_id",
                        column: x => x.movie_id,
                        principalSchema: "moviebase",
                        principalTable: "movies",
                        principalColumn: "movie_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_movie_ratings_users_UserId",
                        column: x => x.UserId,
                        principalSchema: "moviebase",
                        principalTable: "users",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_actor_movie_MovieId",
                schema: "moviebase",
                table: "actor_movie",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_actor_ratings_actor_id",
                schema: "moviebase",
                table: "actor_ratings",
                column: "actor_id");

            migrationBuilder.CreateIndex(
                name: "IX_actor_ratings_UserId",
                schema: "moviebase",
                table: "actor_ratings",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_contact_user_id",
                schema: "moviebase",
                table: "contact",
                column: "user_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_movie_ratings_movie_id",
                schema: "moviebase",
                table: "movie_ratings",
                column: "movie_id");

            migrationBuilder.CreateIndex(
                name: "IX_movie_ratings_UserId",
                schema: "moviebase",
                table: "movie_ratings",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_movies_Director_id",
                schema: "moviebase",
                table: "movies",
                column: "Director_id");

            migrationBuilder.CreateIndex(
                name: "IX_movies_ScreenWriterId",
                schema: "moviebase",
                table: "movies",
                column: "ScreenWriterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "actor_movie",
                schema: "moviebase");

            migrationBuilder.DropTable(
                name: "actor_ratings",
                schema: "moviebase");

            migrationBuilder.DropTable(
                name: "contact",
                schema: "moviebase");

            migrationBuilder.DropTable(
                name: "movie_ratings",
                schema: "moviebase");

            migrationBuilder.DropTable(
                name: "actors",
                schema: "moviebase");

            migrationBuilder.DropTable(
                name: "movies",
                schema: "moviebase");

            migrationBuilder.DropTable(
                name: "users",
                schema: "moviebase");

            migrationBuilder.DropTable(
                name: "directors",
                schema: "moviebase");

            migrationBuilder.DropTable(
                name: "screen_writers",
                schema: "moviebase");
        }
    }
}
