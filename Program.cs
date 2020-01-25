using System;
using System.Collections.Generic;
using svar;

namespace test
{
    class MainClass
    {

        static List<Kurs> kurser = new List<Kurs>();
        static List<Student> studenter = new List<Student>();
             

        public static void Main(string[] args)
        {
            setup();


            for (int i = 0; i < kurser.Count; i++)
            {
                Console.WriteLine(kurser[i]);

            }


            Kurs matte = kurser[0];


            LabbBetyg betyg = new LabbBetyg();

        }



        //skapa kurs
        public void skapaKurs(kursNamn namn)
        {
            Kurs kurs = new Kurs(namn);

            kurser.Add(kurs);
        }

        //lägg till lärare
        public static void läggTillLärare(Kurs kurs, Lärare lärare)
        {
            kurs.lärare.Add(lärare);
        }

        //lägg till uppgift
        public static void läggTillUppgift(Kurs kurs, Uppgift uppgift)
        {
            kurs.uppgifter.Add(uppgift);
        }

        //lägg till elever
        public static void läggTillBetyg(Kurs kurs, Student student)
        {
            kurs.studenter.Add(student);
        }


        //lägg till betyg
        public static void läggTillBetyg(LabbBetyg betyg, Uppgift uppgift)
        {
            uppgift.Betyg.Add(betyg);
        }


        //setup
        private static void setup() 
        {
            for( int i = 0; i < 5; i ++)
            {
                Student nyStudent = new Student();

                studenter.Add(nyStudent);

                Kurs kurs = new Kurs(kursNamn.Matte);

                if (i % 2 == 0)
                {
                    Lärare lärare = new Lärare("Eva");
                    kurs.lärare.Add(lärare);
                }
                kurser.Add(kurs);
            }

            Kurs engelskakurs = new Kurs();


           

              

        }
    }
}
