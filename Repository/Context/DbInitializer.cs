using Repository.Entities;

namespace Repository.Context
{
    public class DbInitializer
    {
        public static void Initialize(BaseContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            var users = new UserEntity[]
            {
                new UserEntity("test1@email.com", "test1"),
                new UserEntity("test2@email.com", "test2"),
                new UserEntity("test3@email.com", "test3"),
                new UserEntity("test4@email.com", "test4"),
            };

            context.Users.AddRange(users);
            context.SaveChanges();
        }
    }
}
