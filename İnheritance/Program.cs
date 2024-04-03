

namespace İnheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.animal_name = "Boncuk";
            cat.animal_gender = "disi";
            cat.animal_color = "Boz";
            cat.cat_age = 2;

            cat.CatMethod();
            cat.showAnimalInfo();

        }
    }
}
