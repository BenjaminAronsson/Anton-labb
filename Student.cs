
using test;

namespace svar
{
    public class Student : IPerson
    {

        int id;

        public int Id { get => id; set => id = value; }

        public string GetAge()
        {
            throw new System.NotImplementedException();
        }

        public string GetNamn()
        {
            throw new System.NotImplementedException();
        }
    }
}