namespace svar
{

    

    public class Lärare
    {
        public string namn;
        public int ålder;

        public Lärare(string namn)
        {
            this.ålder = 35;
            this.namn = namn;
        }




        public Lärare(string namn, int ålder)
        {
            this.namn = namn;
            this.ålder = ålder;
        }
    }
}