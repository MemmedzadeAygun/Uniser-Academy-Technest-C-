

using GenericTask.Classes;
using GenericTask.Managers;

Console.WriteLine("Welcome to Restorane app");
Console.WriteLine("Enter your choice");
Console.WriteLine("1.Worker");
Console.WriteLine("2.Customer");
Console.Write("Enter status: ");
int status = Convert.ToInt32(Console.ReadLine());


DesertManager desertManager = new DesertManager();
DrinksManager drinksManager = new DrinksManager();
FastFoodManager fastFoodManager = new FastFoodManager();
MealManager mealManager = new MealManager();

switch (status)
{
	case 1:
		Console.WriteLine("1.Add Product to Menu");
		Console.WriteLine("2.Delete Product from Menu");
		Console.WriteLine("3.Get All");
		Console.Write("Enter operation: ");
		int operation = Convert.ToInt32(Console.ReadLine());

		switch (operation)
		{
			case 1:
				Console.WriteLine("Add Operation");
				Console.WriteLine("1.Add Drink");
				Console.WriteLine("2.Add Meal");
				Console.WriteLine("3.Add FastFood");
				Console.WriteLine("4.Add Desert");
				Console.Write("Enter add operation name: ");

				int choice = Convert.ToInt32(Console.ReadLine());
				switch (choice)
				{
					case 1:
                        Console.WriteLine("Drinks add operation");
						int addDrinkId = drinksManager.GetAll().Count();
						Console.Write("Enter drink name: ");
						string? addDrinkName = Console.ReadLine();
						Console.Write("Enter drink price: ");
						int addDrinkPrice = Convert.ToInt32(Console.ReadLine());
						Console.WriteLine($"id: {addDrinkId+1} Name: {addDrinkName} Price: {addDrinkPrice}");

						Drinks drinks = new Drinks { Id = addDrinkId+1, Name = addDrinkName, Price = addDrinkPrice };
						drinksManager.Add(drinks);
						break;

					case 2:
						Console.WriteLine("Meals Add operation");
						int addMealId = mealManager.GetAll().Count();
						Console.Write("Enter meal name: ");
						string addMealName = Console.ReadLine();
                        Console.Write("Enter meal indrigients: ");
                        string addMealIndrigients = Console.ReadLine();
                        Console.Write("Enter meal price: ");
						int addMealPrice = Convert.ToInt32(Console.ReadLine());	
						Console.WriteLine($"id: {addMealId+1} Name: {addMealName} Indrigients: {addMealIndrigients} Price: {addMealPrice}");

						Meal meal = new Meal { Id = addMealId + 1, Name = addMealName, Indrigients = addMealIndrigients, Price = addMealPrice };
						mealManager.Add(meal);
						break;

					case 3:
						Console.WriteLine("FastFood Add operation");
						int addFFoodId = fastFoodManager.GetAll().Count();
						Console.Write("Enter Fastfood name: ");
						string addFFoodName = Console.ReadLine();
						Console.Write("Enter Fastfood price: ");
						int addFFoodPrice = Convert.ToInt32(Console.ReadLine());
						Console.WriteLine($"Id: {addFFoodId + 1} Name: {addFFoodName} Price: {addFFoodPrice}");

						FastFood fastfood = new FastFood { Id = addFFoodId + 1, Name = addFFoodName, Price = addFFoodPrice };
						fastFoodManager.Add(fastfood);
						break;

					case 4:
						Console.WriteLine("Desert Add operation");
						int addDesertId = desertManager.GetAll().Count();
						Console.Write("Enter Desert Name: ");
						string addDesertName = Console.ReadLine();
						Console.Write("Enter Desert Indrigients");
						string addDesertIndrigients = Console.ReadLine();
						Console.Write("Enter Desert price: ");
						int addDesertPrice = Convert.ToInt32(Console.ReadLine());
						Console.WriteLine($"Id: {addDesertId + 1} Name: {addDesertName} Indrigients: {addDesertIndrigients} Price: {addDesertPrice}");

						Desert desert = new Desert { Id = addDesertId + 1, Name = addDesertName, Indrigients = addDesertIndrigients, Price = addDesertPrice };
						desertManager.Add(desert);
						break;
                }
			break;

			case 2:
				Console.WriteLine("Delete Operation");
				Console.WriteLine("1.Delete Drink");
				Console.WriteLine("2.Delete Meal");
				Console.WriteLine("3.Delete FastFood");
				Console.WriteLine("4.Delete Desert");
				Console.Write("Enter delete operation name: ");

				int choice2 = Convert.ToInt32(Console.ReadLine());
				switch (choice2)
				{
					case 1:
						Console.Write("Enter the id of the Drink you want to delete: ");
						int deleteDrinkId =Convert.ToInt32(Console.ReadLine());
						drinksManager.Delete(deleteDrinkId);
						break;

					case 2:
						Console.Write("Enter the id of the Meal you want to delete: ");
						int deleteMealId = Convert.ToInt32(Console.ReadLine());
						mealManager.Delete(deleteMealId);
						break;

					case 3:
                        Console.Write("Enter the id of the Fastfood you want to delete: ");
						int deleteFastFoodId = Convert.ToInt32(Console.ReadLine());
						fastFoodManager.Delete(deleteFastFoodId);
						break;

					case 4:
                        Console.Write("Enter the id of the Desert you want to delete: ");
						int deleteDesertId = Convert.ToInt32(Console.ReadLine());
						desertManager.Delete(deleteDesertId);
						break;
                }
				break;

			case 3:
				Console.WriteLine("GetAll Operation");
				Console.WriteLine("1.GetAll Drink");
				Console.WriteLine("2.GetAll Meal");
				Console.WriteLine("3.GetAll FastFood");
				Console.WriteLine("4.GetAll Desert");
				Console.WriteLine("Enter your choice: ");
				int choice3 = Convert.ToInt32(Console.ReadLine());

				switch (choice3)
				{
					case 1:					
						Console.WriteLine(drinksManager.GetAll());
						break;

					case 2:				
						Console.WriteLine(mealManager.GetAll());
						break;

					case 3:      
						Console.WriteLine(fastFoodManager.GetAll());
						break;

					case 4:                    
						Console.WriteLine(desertManager.GetAll());
						break;
                }
				break;
		}
		break;

	case 2:
		Console.WriteLine("1.GetAll Drinks");
		Console.WriteLine("2.GetAll Meal");
		Console.WriteLine("3.GetAll FastFood");
		Console.WriteLine("4.GetAll Desert");
		Console.WriteLine("Enter your choice: ");
		int choice4 = Convert.ToInt32(Console.ReadLine());

		switch (choice4)
		{
			case 1:             
				Console.WriteLine(drinksManager.GetAll());
				break;

			case 2:
				Console.WriteLine(mealManager.GetAll());
				break;
			case 3:              
				Console.WriteLine(fastFoodManager.GetAll());
				break;
			case 4:            
				Console.WriteLine(desertManager.GetAll());
				break;
        }
		break;
}

