using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterLogin.Models
{
    // Ініціалізуємо нашу базу даних (в нашому випадку колекції DbSet в Model об`єкті)
    // CreateDatabaseIfNotExists - Ініціалізуємо при відсутності бази даних
    // 
    class StudentLibraryModelInitializer : CreateDatabaseIfNotExists<StudentLibraryModel>
    {

    }
}
