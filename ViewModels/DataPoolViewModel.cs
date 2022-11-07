using DataGenerator.Models;

namespace DataGenerator.ViewModels
{
    public class DataPoolViewModel
    {
        public List<FirstNamePool>? FirstNamePools { get; set; }
        public List<LastNamePool>? LastNamePools { get; set; }

        public string RandomFirstName()
        {
            string randName = "null";
            var rando = new Random();
            int index = rando.Next(FirstNamePools.Count);
            randName = FirstNamePools[index].FirstName;
            return randName;
        }
        public string RandomLastName()
        {
            string randName = "null";
            var rando = new Random();
            int index = rando.Next(LastNamePools.Count);
            randName = LastNamePools[index].LastName;
            return randName;
        }
    }
}
