using Model;

namespace Data
{
    public class Menu
    {
        public static List<Models> Ulams()
        {
            List<Models> ulams = new List<Models>();

            Models ulam1 = new Models
            {
                name = "Adobong manok",
                prize = 50.00
            };
            ulams.Add(ulam1);

            Models ulam2 = new Models
            {
                name = "Tinola",
                prize = 50.00
            };
            ulams.Add(ulam2);

            Models ulam4 = new Models
            {
                name = "Bicol express",
                prize = 50.00
            };
            ulams.Add(ulam4);

            Models ulam5 = new Models
            {
                name = "Kaldereta",
                prize = 50.00
            };
            ulams.Add(ulam5);

            Models ulam6 = new Models
            {
                name = "Bopis",
                prize = 50.00
            };
            ulams.Add(ulam6);
 
            Models ulam7 = new Models
            {
                name = "Chopsuy",
                prize = 50.00
            };
            ulams.Add(ulam7);

            Models ulam8 = new Models
            {
                name = "Rice",
                prize = 12.00
            };
            ulams.Add(ulam8);

            Models ulam3 = new Models
            {
                name = "Sinigang",
                prize = 50.00
            };
            ulams.Add(ulam3);
            
            return ulams;
        }

    }


}

    

