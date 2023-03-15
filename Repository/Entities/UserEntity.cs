using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Repository.Entities
{
    public class UserEntity : IUser
    {
        [Key]
        public string Id { get; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Name { get; set; }

        #region Relations

        #endregion

        #region Constructors

        public UserEntity(string email, string name)
        {
            Id = Guid.NewGuid().ToString();
            Email = email;
            Name = name;
        }

        public UserEntity(string id, string email, string name)
        {
            Id = id;
            Email = email;
            Name = name;
        }

        #endregion

        #region Mapping

        public static void Map(ModelBuilder modelBuilder)
        {
            var map = modelBuilder.Entity<UserEntity>();
            map.HasIndex(x => x.Id).IsUnique();

            map.HasIndex(x => x.Email).IsUnique();
        }

        #endregion
    }
}
