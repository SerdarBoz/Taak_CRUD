namespace Taak_CRUD.Models
{
    public class Animal
    {
        public string Name { get; set; }
        public string Species {  get; set; }
        public int Birthyear { get; set; }
        public Boolean Vaccinated { get; set; }
        public int Age {
            get
            {
                return DateTime.Now.Year - Birthyear;
            }
        }

        public int Id { get; set; }
    }
}
