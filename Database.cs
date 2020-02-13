using Microsoft.Win32;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace HotelManager
{
    static class Database
    {
        static Database()
        {
            Load();
        }

        public static List<User> DefaultUsers { get; } = new List<User>
        {
            new User(Role.Manager, "Manager", "Manager"),
            new User(Role.Administrator, "Admin", "Admin")
        };
        public static List<Hotel> Hotels { get; } = new List<Hotel>();
        public static List<Administrator> Administrators { get; } = new List<Administrator>();
        public static List<Guest> Guests { get; } = new List<Guest>();
        public static List<Room> Rooms { get; } = new List<Room>();

        public static void Load()
        {
            Load(Hotels, "Hotel");
            Load(Administrators, "Admin");
            Load(Guests, "Guest");
            Load(Rooms, "Room");

            for (int i = 0; i < Administrators.Count; i++)
            {
                int hotelId = Administrators[i].Hotel.Id;
                Administrators[i].Hotel = Hotels.First(x => x.Id == hotelId);
            }

            for (int i = 0; i < Rooms.Count; i++)
            {
                int hotelId = Rooms[i].Hotel.Id;
                Rooms[i].Hotel = Hotels.First(x => x.Id == hotelId);
            }
        }

        public static void Save()
        {
            Save(Hotels, "Hotel");
            Save(Administrators, "Admin");
            Save(Guests, "Guest");
            Save(Rooms, "Room");
        }

        private static void Load<T>(List<T> list, string keyStart)
        {
            string[] keyNames = GetKeyNames(keyStart);

            if (keyNames.Length == 0)
                return;

            foreach (var keyName in keyNames)
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(keyName);
                T item = JsonConvert.DeserializeObject<T>((string)key.GetValue("Object"));
                list.Add(item);
            }
        }

        private static void Save<T>(List<T> list, string keyStart) where T : IIdentifiable
        {
            string[] keyNames = GetKeyNames(keyStart);

            if (list.Count == 0)
                return;

            foreach (var item in list)
            {
                string json = JsonConvert.SerializeObject(item);
                RegistryKey key = GetKey(item.Id, keyStart, keyNames);
                key.SetValue("Object", json);
                key.Close();
            }
        }

        private static RegistryKey GetKey(int id, string keyStart, string[] existingSubKeys)
        {
            if (existingSubKeys.Contains($"{keyStart}{id}"))
                return Registry.CurrentUser.OpenSubKey($"{keyStart}{id}", true);
            else
                return Registry.CurrentUser.CreateSubKey($"{keyStart}{id}");
        }

        private static string[] GetKeyNames(string keyStart)
        {
            return Registry.CurrentUser.GetSubKeyNames()
                                                .Where(x => x.StartsWith(keyStart))
                                                .ToArray();
        }
    }
}
