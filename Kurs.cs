using System;
using System.Collections.Generic;


namespace svar
{
    public enum Betyg
    {
        U = -1,
        G = 2,
        VG = 3
    }

    public enum kursNamn
    {
        Matte,
        Svenska,
        Historia,
        Engelska
    }


    public class Kurs
    {
        //properties
        int kursId;
        string namn;

        public List<Lärare> lärare;
        public List<Student> studenter;
        public List<Uppgift> uppgifter;



        public Kurs(kursNamn namn = kursNamn.Engelska)
        {
            lärare = new List<Lärare>();
            studenter = new List<Student>();
            uppgifter = new List<Uppgift>();

            switch (namn)
            {
                case kursNamn.Matte:
                    //lägger till matte uppgifter
                    Uppgift uppgift1 = new Uppgift("Vad är x", "7");
                    uppgifter.Add(uppgift1);
                    Lärare mattelärare = new Lärare("Roger");
                    lärare.Add(mattelärare);
                    break;

                case kursNamn.Svenska:
                    //lägger till svenska uppgifter
                    Uppgift uppgift2 = new Uppgift("Vad är ett substantiv", "är en sak");
                    uppgifter.Add(uppgift2);
                    Lärare svenskalärare = new Lärare("Sara");
                    lärare.Add(svenskalärare);
                    break;

                case kursNamn.Historia:
                    //lägger till historia uppgifter
                    Uppgift uppgift3 = new Uppgift("Hur gammal är gustav 16", "77");
                    uppgifter.Add(uppgift3);
                    Lärare historialärare = new Lärare("Martin");
                    lärare.Add(historialärare);
                    break;

                case kursNamn.Engelska:
                    //lägger till historia uppgifter
                    Uppgift uppgift4 = new Uppgift("Hur säger man hej på engelska?", "Hello");
                    uppgifter.Add(uppgift4);
                    Lärare engelskalärare = new Lärare("Linda");
                    lärare.Add(engelskalärare);
                    break;


            }
        }


        public int KursId { get => kursId; set => kursId = value; }
        public string Namn { get => namn; set => namn = value; }
       
    }
}
