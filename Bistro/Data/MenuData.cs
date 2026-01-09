using Bistro.Models;

namespace Bistro.Data
{
    public static class MenuData
    {
        public static List<MenuItem> GetAllItems()
        {
            return new List<MenuItem>
            {
                // Appetizers (Jevonn Suru) - 6 items
                new MenuItem { Id = 1, Name = "Beef Chilly Fry", Description = "Spicy stir-fried beef with onions, green chilies, and aromatic Goan spices", Price = 12.99m, Category = Category.Appetizers, Emoji = "🥩" },
                new MenuItem { Id = 2, Name = "Prawn Balchão", Description = "Fiery pickled prawns in tangy red masala with a perfect kick of spice", Price = 14.99m, Category = Category.Appetizers, Emoji = "🦐" },
                new MenuItem { Id = 3, Name = "Fish Cutlets", Description = "Crispy golden fish cakes seasoned with traditional Goan spices", Price = 10.99m, Category = Category.Appetizers, Emoji = "🐟" },
                new MenuItem { Id = 4, Name = "Chorizo Pulao Bites", Description = "Mini rice balls stuffed with spicy Goan chorizo sausage", Price = 9.99m, Category = Category.Appetizers, Emoji = "🍚" },
                new MenuItem { Id = 5, Name = "Stuffed Crab", Description = "Fresh crab shells filled with spiced crab meat and baked golden", Price = 15.99m, Category = Category.Appetizers, Emoji = "🦀" },
                new MenuItem { Id = 6, Name = "Chicken Cafreal", Description = "Green masala marinated chicken, pan-fried to perfection", Price = 11.99m, Category = Category.Appetizers, Emoji = "🍗" },

                // Mains (Mukhya Jevonn) - 6 items
                new MenuItem { Id = 7, Name = "Fish Curry Rice", Description = "Classic Goan fish curry with coconut, kokum, and perfectly steamed rice", Price = 16.99m, Category = Category.Mains, Emoji = "🐠" },
                new MenuItem { Id = 8, Name = "Pork Vindaloo", Description = "Legendary fiery pork in vinegar-garlic gravy - a true Goan classic", Price = 17.99m, Category = Category.Mains, Emoji = "🐷" },
                new MenuItem { Id = 9, Name = "Chicken Xacuti", Description = "Aromatic chicken in roasted coconut and poppy seed curry", Price = 15.99m, Category = Category.Mains, Emoji = "🍗" },
                new MenuItem { Id = 10, Name = "Prawn Curry", Description = "Succulent prawns in creamy coconut gravy with tangy kokum", Price = 18.99m, Category = Category.Mains, Emoji = "🦐" },
                new MenuItem { Id = 11, Name = "Sorpotel", Description = "Traditional Goan pork and liver stew with warming spices", Price = 16.99m, Category = Category.Mains, Emoji = "🍖" },
                new MenuItem { Id = 12, Name = "Crab Xec Xec", Description = "Whole crab in rich, dry-roasted spice and coconut gravy", Price = 22.99m, Category = Category.Mains, Emoji = "🦀" },

                // Drinks (Piyevpa) - 6 items
                new MenuItem { Id = 13, Name = "Kokum Sarbat", Description = "Refreshing kokum berry cooler - the taste of Goan summers", Price = 4.99m, Category = Category.Drinks, Emoji = "🍹" },
                new MenuItem { Id = 14, Name = "Sol Kadhi", Description = "Cooling coconut milk with kokum - perfect digestive drink", Price = 4.99m, Category = Category.Drinks, Emoji = "🥥" },
                new MenuItem { Id = 15, Name = "Feni Cocktail", Description = "Signature cashew feni with fresh lime and sparkling soda", Price = 8.99m, Category = Category.Drinks, Emoji = "🍸" },
                new MenuItem { Id = 16, Name = "Fresh Coconut Water", Description = "Sweet tender coconut water served straight from the shell", Price = 3.99m, Category = Category.Drinks, Emoji = "🥥" },
                new MenuItem { Id = 17, Name = "Mango Lassi", Description = "Creamy yogurt smoothie blended with ripe Alphonso mangoes", Price = 5.99m, Category = Category.Drinks, Emoji = "🥭" },
                new MenuItem { Id = 18, Name = "Ginger Lime Soda", Description = "Zesty fresh ginger and lime with sparkling soda water", Price = 4.49m, Category = Category.Drinks, Emoji = "🍋" },

                // Desserts (Goad Jevonn) - 6 items
                new MenuItem { Id = 19, Name = "Bebinca", Description = "Traditional 16-layer Goan cake made with coconut milk and ghee", Price = 7.99m, Category = Category.Desserts, Emoji = "🍰" },
                new MenuItem { Id = 20, Name = "Dodol", Description = "Chewy coconut and jaggery sweet - a festive Goan favorite", Price = 5.99m, Category = Category.Desserts, Emoji = "🍮" },
                new MenuItem { Id = 21, Name = "Serradura", Description = "Portuguese-inspired sawdust pudding with cream and biscuit", Price = 6.99m, Category = Category.Desserts, Emoji = "🍨" },
                new MenuItem { Id = 22, Name = "Coconut Ladoo", Description = "Sweet coconut balls made with fresh coconut and condensed milk", Price = 4.99m, Category = Category.Desserts, Emoji = "🥥" },
                new MenuItem { Id = 23, Name = "Mango Pudding", Description = "Silky smooth Alphonso mango pudding topped with fresh cream", Price = 6.49m, Category = Category.Desserts, Emoji = "🥭" },
                new MenuItem { Id = 24, Name = "Kulkuls", Description = "Crispy curled cookies dusted with powdered sugar - Christmas special", Price = 5.49m, Category = Category.Desserts, Emoji = "🍪" }
            };
        }

        public static List<MenuItem> GetByCategory(Category category)
        {
            return GetAllItems().Where(x => x.Category == category).ToList();
        }

        public static Dictionary<Category, List<MenuItem>> GetGroupedByCategory()
        {
            return GetAllItems().GroupBy(x => x.Category).ToDictionary(g => g.Key, g => g.ToList());
        }
    }
}
