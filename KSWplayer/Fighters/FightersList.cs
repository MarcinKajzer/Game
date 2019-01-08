using KSWplayer.Fighters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSWplayer
{
    class FightersList
    {
        
        public static IFighter Szadzinski = new Lekka("Gracjan Szadziński", "Gracjan", 175, 70, 5, 7) { };
        
        public static IFighter Szulakowski = new Lekka("Grzegorz Szulakowski", "Szuli", 180, 70, 6, 6) { };

        public static IFighter Gamrot = new Lekka("Mateusz Gamrot", "Gamer", 177, 70, 100, 100) { }; // 7,5

        public static IFighter Sowinski = new Lekka("Artur Sowiński", "Kornik", 178, 66, 5, 7) { };

        public static IFighter Ziolkowski = new Lekka("Marian Ziółkowski", "Golden Boy", 185, 70, 7, 4) { };


        public static IFighter Szymuszowski = new Polsrednia("Kamil Szymuszowski", "Szymek", 187, 77, 7, 9) { };

        public static IFighter Mankowski = new Polsrednia("Borys Mańkowski", "Diabeł Tasmański", 171, 77, 8, 8) { };

        public static IFighter Soldic = new Polsrednia("Roberto Soldic", "RoboCop", 180, 77, 9, 7) { };

        public static IFighter DuPlessis = new Polsrednia("Dricus Du Plessis", "Stillknocks", 183, 77, 9, 6) { };

        public static IFighter Kaszubowski = new Polsrednia("Krystian Kaszubowski", "Kaszub", 180, 77, 6, 9) { };


        public static IFighter Khalidov = new Srednia("Mamed Khalidov", "Mamed", 183, 83, 9, 11) { };

        public static IFighter Materla = new Srednia("Michał Materla", "Magik", 180, 84, 10, 9) { };

        public static IFighter Janikowski = new Srednia("Damian Janikowski", "Janek", 180, 84, 8, 11) { };

        public static IFighter Askham = new Srednia("Scot Askham", "Scot", 191, 84, 11, 9) { };

        public static IFighter Wojcik = new Srednia("Marcin Wójcik", "The Gigant", 183, 84, 10, 10) { };

        
        public static IFighter Jurkowski = new Polciezka("Łukasz Jurkowski", "Juras", 186, 93, 12, 11) { };
        
        public static IFighter Narkun = new Polciezka("Tomasz Narkun", "Żyrafa", 190, 92, 12, 12) { };
        
        public static IFighter Prado = new Polciezka("Wagner Prado", "Calderrao", 183, 93, 11, 11) { };
        
        public static IFighter Fields = new Polciezka("Chris Fields", "The Houswives' Choice", 190, 84, 13, 10) { };
        
        public static IFighter Zawada = new Polciezka("Martin Zawada", "King Kong", 181, 92, 12, 11) { };
        

        public static IFighter Pudzianowski = new Ciezka("Mariusz Pudzianowski", "Pudzian", 186, 115, 13, 13) { };
        
        public static IFighter Bedorf = new Ciezka("Karol Bedorf", "Coco", 188, 116, 14, 14) { }; 
        
        public static IFighter Rozal = new Ciezka("Marcin Różalski", "Różal", 188, 110, 15, 12) { };
        
        public static IFighter DeFries = new Ciezka("Phil de Fries", "Phil", 193, 120, 12, 16) { };
        
        public static IFighter Andryszak = new Ciezka("Michał Andryszak", "Longer", 200, 110, 15, 12) { };
       
        public static IFighter[] AllFightersList = { Gamrot, Mankowski, Janikowski, Jurkowski, Pudzianowski,
                                                    Szulakowski, Soldic, Materla, Narkun, Bedorf,
                                                    Szadzinski, Szymuszowski, Khalidov, Prado, Rozal,
                                                    Sowinski, DuPlessis, Askham, Fields, DeFries,
                                                    Ziolkowski, Kaszubowski, Wojcik, Zawada, Andryszak };
    };

    
}
