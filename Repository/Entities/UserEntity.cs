using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace Repository.Entities
{
    public class UserEntity : IBaseEntity, IUser
    {
        [Key]
        public string Id { get; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? UpdatedDate { get; set; }

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
            CreatedDate = DateTime.UtcNow;
            Email = email;
            Name = name;
        }

        public UserEntity(string id, DateTime createdDate, DateTime? updatedDate, string email, string name)
        {
            Id = id;
            CreatedDate = createdDate;
            UpdatedDate = updatedDate;
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
