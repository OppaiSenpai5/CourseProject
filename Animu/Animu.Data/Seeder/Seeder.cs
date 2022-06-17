using Animu.Data.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animu.Data.Seeder
{
    public class Seeder
    {
        private const char colSeparator = (char)9;
        private const char rowSeparator = (char)10;

        private const string animesConnectionString = @"..\Animu.Data\Seeder\files\animes.txt";
        private const string tagsConnectionString = @"..\Animu.Data\Seeder\files\tags.txt";
        private const string tagAnimesConnectionString = @"..\Animu.Data\Seeder\files\taganimes.txt";
        private const string episodesConnectionString = @"..\Animu.Data\Seeder\files\episodes.txt";
        private const string usersConnectionString = @"..\Animu.Data\Seeder\files\users.txt";
        private const string rolesConnectionString = @"..\Animu.Data\Seeder\files\roles.txt";
        private const string userRolesConnectionString = @"..\Animu.Data\Seeder\files\userroles.txt";

        public static IEnumerable<Anime> AnimesSeed()
        {
            using(StreamReader reader = new StreamReader(animesConnectionString))
            {
                var table = reader.ReadToEnd();
                var rows = table.Split(rowSeparator);

                foreach(var row in rows)
                {
                    var cols = row.Split(colSeparator);
                    yield return new Anime()
                    {
                        Id = Guid.Parse(cols[0]),
                        Title = cols[1],
                        ImageUrl = cols[2],
                        Synopsis = cols[3]
                    };
                }
            }
        }

        public static IEnumerable<Tag> TagsSeed()
        {
            using (StreamReader reader = new StreamReader(tagsConnectionString))
            {
                var table = reader.ReadToEnd();
                var rows = table.Split(rowSeparator);

                foreach (var row in rows)
                {
                    var cols = row.Split(colSeparator);
                    yield return new Tag()
                    {
                        Id = Guid.Parse(cols[0]),
                        Name = cols[1]
                    };
                }
            }
        }

        public static IEnumerable<TagAnime> TagAnimesSeed()
        {
            using (StreamReader reader = new StreamReader(tagAnimesConnectionString))
            {
                var table = reader.ReadToEnd();
                var rows = table.Split(rowSeparator);

                foreach (var row in rows)
                {
                    var cols = row.Split(colSeparator);
                    yield return new TagAnime()
                    {
                        TagId = Guid.Parse(cols[0]),
                        AnimeId = Guid.Parse(cols[1])
                    };
                }
            }
        }

        public static IEnumerable<Episode> EpisodesSeed()
        {
            using (StreamReader reader = new StreamReader(episodesConnectionString))
            {
                var table = reader.ReadToEnd();
                var rows = table.Split(rowSeparator);

                foreach (var row in rows)
                {
                    var cols = row.Split(colSeparator);
                    yield return new Episode()
                    {
                        Id = Guid.Parse(cols[0]),
                        Number = int.Parse(cols[1]),
                        Title = cols[2],
                        VideoUrl = cols[3],
                        AnimeId = Guid.Parse(cols[4])
                    };
                }
            }
        }

        public static IEnumerable<IdentityUser> UsersSeed()
        {
            using (StreamReader reader = new StreamReader(usersConnectionString))
            {
                var table = reader.ReadToEnd();
                var rows = table.Split(rowSeparator);

                foreach (var row in rows)
                {
                    var cols = row.Split(colSeparator);
                    yield return new IdentityUser()
                    {
                        Id = cols[0],
                        UserName = cols[1],
                        NormalizedUserName = cols[2],
                        Email = cols[3],
                        NormalizedEmail = cols[4],
                        EmailConfirmed = cols[5] == "1" ? true : false,
                        PasswordHash = cols[6],
                        SecurityStamp = cols[7],
                        ConcurrencyStamp = cols[8],
                        PhoneNumber = null,
                        PhoneNumberConfirmed = cols[10] == "1" ? true : false,
                        TwoFactorEnabled = cols[11] == "1" ? true : false,
                        LockoutEnd = null,
                        LockoutEnabled = cols[13] == "1" ? true : false,
                        AccessFailedCount = int.Parse(cols[14])
                    };
                }
            }
        }

        public static IEnumerable<IdentityRole> RolesSeed()
        {
            using (StreamReader reader = new StreamReader(rolesConnectionString))
            {
                var table = reader.ReadToEnd();
                var rows = table.Split(rowSeparator);

                foreach (var row in rows)
                {
                    var cols = row.Split(colSeparator);
                    yield return new IdentityRole()
                    {
                        Id = cols[0],
                        Name = cols[1],
                        NormalizedName = cols[2],
                        ConcurrencyStamp = cols[3]
                    };
                }
            }
        }

        public static IEnumerable<IdentityUserRole<string>> UserRolesSeed()
        {
            using (StreamReader reader = new StreamReader(userRolesConnectionString))
            {
                var table = reader.ReadToEnd();
                var rows = table.Split(rowSeparator);

                foreach (var row in rows)
                {
                    var cols = row.Split(colSeparator);
                    yield return new IdentityUserRole<string>()
                    {
                        UserId = cols[0],
                        RoleId = cols[1]
                    };
                }
            }
        }
    }
}
