using System;
using System.Diagnostics;

namespace M120Projekt
{
    static class APIDemo
    {
        #region KlasseA
        // Create
        public static void DemoACreate()
        {
            Debug.Print("--- DemoACreate ---");
            // KlasseA
            Data.ToDo klasseA1 = new Data.ToDo();
            klasseA1.Title = "Artikel 1";
            klasseA1.Description = "This is for school";
            klasseA1.DueDate = DateTime.Today;
            klasseA1.Importance = 5;
            klasseA1.Category = "School";
            klasseA1.Done = false;
            Int64 klasseA1Id = klasseA1.Erstellen();
            Debug.Print("Artikel erstellt mit Id:" + klasseA1Id);
        }
        public static void DemoACreateKurz()
        {
            Data.ToDo klasseA2 = new Data.ToDo { Title = "Artikel 2", Description = "This is for school", DueDate = DateTime.Today, Importance = 5, Category = "School" };
            Int64 klasseA2Id = klasseA2.Erstellen();
            Debug.Print("Artikel erstellt mit Id:" + klasseA2Id);
        }

        // Read
        public static void DemoARead()
        {
            Debug.Print("--- DemoARead ---");
            // Demo liest alle
            foreach (Data.ToDo klasseA in Data.ToDo.LesenAlle())
            {
                Debug.Print("Artikel Id:" + klasseA.ToDoId + " Name:" + klasseA.Title);
            }
        }
        // Update
        public static void DemoAUpdate()
        {
            Debug.Print("--- DemoAUpdate ---");
            // KlasseA ändert Attribute
            Data.ToDo klasseA1 = Data.ToDo.LesenID(1);
            klasseA1.Title = "Artikel 1 nach Update";
            klasseA1.Aktualisieren();
        }
        // Delete
        public static void DemoADelete()
        {
            Debug.Print("--- DemoADelete ---");
            Data.ToDo.LesenID(2).Loeschen();
            Debug.Print("Artikel mit Id 2 gelöscht");
        }
        #endregion
    }
}
