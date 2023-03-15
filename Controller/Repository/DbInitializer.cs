namespace Controller.Repository
{
    public class DbInitializer
    {
        public static void Initialize(Context context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            var users = new User[]
            {
                new User{Id="1", Name="test 1"},
                new User{Id="2", Name="test 2"},
                new User{Id="3", Name="test 3"},
                new User{Id="4", Name="test 4"},
            };

            context.Users.AddRange(users);
            context.SaveChanges();


        }
    }
}
