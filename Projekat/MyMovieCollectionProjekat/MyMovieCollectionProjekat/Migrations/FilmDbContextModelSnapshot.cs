using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using MyMovieCollectionProjekat.MyMovieCollection.Models;

namespace MyMovieCollectionProjekatMigrations
{
    [ContextType(typeof(FilmDbContext))]
    partial class FilmDbContextModelSnapshot : ModelSnapshot
    {
        public override void BuildModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("MyMovieCollectionProjekat.MyMovieCollection.Models.Film", b =>
                {
                    b.Property<int>("FilmId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Godina");

                    b.Property<int>("KolekcijaId");

                    b.Property<int>("KorisnikId");

                    b.Property<string>("Link");

                    b.Property<string>("Naziv");

                    b.Property<string>("Opis");

                    b.Property<double>("ProsjecnaOcjena");

                    b.Property<DateTime>("god");

                    b.Property<byte[]>("slika");

                    b.Key("FilmId");
                });
        }
    }
}
