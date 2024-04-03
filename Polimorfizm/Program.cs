

using Polimorfizm.Managers;

Console.OutputEncoding = System.Text.Encoding.UTF8;
MovieManager movieManager = new MovieManager(new Polimorfizm.Classes.Movie { Name="Inception", Director="Nolan", imdPoint=9.1});
movieManager.Watching();
