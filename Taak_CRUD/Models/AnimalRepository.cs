namespace Taak_CRUD.Models
{
    public class AnimalRepository
    {
        private static int animalId;
        private static List<Animal> animals = new List<Animal>();

        public IList<Animal> GetAnimals() 
        {
            return animals;
        }

        public Animal LookForAnimal(int id)
        {
            foreach (var animal in animals)
            {
                if (animal.Id == id)
                {
                    return animal;
                }
            }
            return null;
        }
        public Animal AddNewAnimal(Animal animal)
        {
            animalId++;
            animal.Id = animalId;
            animals.Add(animal);
            return animal;
        }

        public void UpdateAnimal(int id, Animal animal)
        {
            Animal a = LookForAnimal(id);
            a.Name = animal.Name;
            a.Species = animal.Species;
            a.Birthyear = animal.Birthyear;
            a.Vaccinated = animal.Vaccinated;
        }

        public void DeleteAnimal(int id)
        {
            Animal toBeDeleted = LookForAnimal(id);
            if(toBeDeleted != null)
            {
                animals.Remove(toBeDeleted);
            }
        }
    }
}
