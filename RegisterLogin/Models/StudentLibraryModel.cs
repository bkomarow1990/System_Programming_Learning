using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;

namespace RegisterLogin
{
    public class StudentLibraryModel : DbContext
    {
        // Your context has been configured to use a 'StudentLibraryModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'RegisterLogin.StudentLibraryModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'StudentLibraryModel' 
        // connection string in the application configuration file.
        public StudentLibraryModel()
            : base("name=StudentLibraryModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
    }
    public class User
    {
        public int Id { get; set; }
        [Required] // Атрибут, при якому дана властивість має бути вказана тобто NOT NULL
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        public int RoleId { get; set; }
        // Navigation Properties
        public virtual Role Role{ get; set; }


        /* public int? Money { get; set; }*/ // Властивість може бути NULL
    }
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigation Properties
        public virtual ICollection<User> User { get; set; }
    }
}