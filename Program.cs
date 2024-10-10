using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Text;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)

        {
             Geocoding();
             Console.ReadLine();
        }

        public static void Geocoding()
        {
            //coordinates();
            //For Users
            double aLatitude = 45.59104000;
            double aLongitude = -73.43605000;

            //For Farm
            //45.30713 - 73.26259
            double bLatitude = 45.3071;
            double bLongitude = -73.2626;

            Console.WriteLine(DistanceTo(aLatitude, aLongitude, bLatitude, bLongitude));
            //Console.ReadLine();
        }

        public static void Currency()
        {
            double amount = 25000;

            Console.WriteLine(amount.ToString("N2"));

        }

        public static double DistanceTo(double lat1, double lon1, double lat2, double lon2, char unit = 'K')
        {
            double rlat1 = Math.PI * lat1 / 180;
            double rlat2 = Math.PI * lat2 / 180;
            double theta = lon1 - lon2;
            double rtheta = Math.PI * theta / 180;
            double dist =
                Math.Sin(rlat1) * Math.Sin(rlat2) + Math.Cos(rlat1) *
                Math.Cos(rlat2) * Math.Cos(rtheta);
            dist = Math.Acos(dist);
            dist = dist * 180 / Math.PI;
            dist = dist * 60 * 1.1515;

            switch (unit)
            {
                case 'K': //Kilometers -> default
                    return dist * 1.609344;
                case 'N': //Nautical Miles 
                    return dist * 0.8684;
                case 'M': //Miles
                    return dist;
            }

            return dist;
        }


        public static void coordinates()
        {  
            //For Users
            double aLatitude = 45.59104000;
            double aLongitude = -73.43605000;

            //For Farm
            //45.30713 - 73.26259
            double bLatitude = 45.3071;
            double bLongitude = -73.2626;

            const double EarthRadiusInKm = 6371.0; // Earth's radius in kilometers

            double deltaLongitude = Math.Abs(aLongitude - bLongitude);
            double centralAngle = Math.Acos(
                Math.Sin(aLatitude) * Math.Sin(bLatitude) +
                Math.Cos(aLatitude) * Math.Cos(bLatitude) * Math.Cos(deltaLongitude)
            );

            double distanceInKm = EarthRadiusInKm * centralAngle;

            Console.WriteLine($"Distance between A and B: {distanceInKm} kilometers");
        }

        public static void JsonReader()
        {
            string json = "\"[\\r\\n  {\\r\\n    \\\"ID\\\": 1,\\r\\n    \\\"From\\\": \\\"Karongi,Western Province\\\",\\r\\n    \\\"To\\\": \\\"Kigali\\\",\\r\\n    \\\"Details\\\": \\\"test\\\",\\r\\n    \\\"PickupLoc\\\": \\\"Bus Stop 1\\\",\\r\\n    \\\"DropoffLoc\\\": \\\"Bus Stop 2\\\",\\r\\n    \\\"DateTime\\\": \\\"2024-07-09T15:00:00\\\",\\r\\n    \\\"Seathowmany\\\": 4,\\r\\n    \\\"Cost\\\": 25.0\\r\\n  }\\r\\n]\\r\\n\"";

            try
            {
                var jsonObject = JArray.Parse(json);

            }


            catch (Exception ex) { string message = ex.Message; }

        }

        public static void DoCall()
        {
            var phonecall = PhoneCall("Jacques Gendron;(450) 655-2292;06/07/2020 06:30;false");

            Console.WriteLine(phonecall.Item1);
            Console.WriteLine(phonecall.Item2);
            Console.WriteLine(phonecall.Item3);
            Console.WriteLine(phonecall.Item4);
            Console.ReadLine();
        }

        public static void DoAdd()
        {
            var phrase = addphonenum("add Misc Business:18773450000:blocked");

            Console.WriteLine(phrase.Item1);
            Console.WriteLine(phrase.Item2);
            Console.WriteLine(phrase.Item3);
            Console.ReadLine();
        }

        public static void IpAddress()
        {
            Console.WriteLine("Hello World!");
            string iptemp = "";
            int location = 0;
            string IPAddress = "192.0.0.1";

            if (IPAddress.IndexOf(".", 1) > 0)
            {
                int i = 0;
                for (i = 0; i <= 3 - 1; i++)

                    switch (i)
                    {
                        case 0:
                            location = IPAddress.IndexOf(".", 1);
                            iptemp = Mid(IPAddress, location);
                            break;

                        case 1:
                            location = iptemp.IndexOf(".", 1);
                            iptemp = Mid(iptemp, location);
                            break;
                    }
            }

            Console.WriteLine("XXX.XXX." + iptemp);
            Console.ReadLine();
        }

        public static void writerecords()
        {
            double records = 20;
            int record = 0;
            int count = 0;
            int i = 0;
            double numberofpagesd = 0;
            int numberofpages = 0;
            int RECORDS_PER_PAGE = 4;
            int page = 0;
            int pagenum = 0;
            int nPage = 3;

            if (nPage == 0) { nPage = 1; }

            numberofpagesd = records / RECORDS_PER_PAGE;
            if (numberofpagesd > (int)(numberofpagesd)) { numberofpages = (int)(numberofpagesd) + 1; } else { numberofpages = (int)(numberofpagesd); }

            if (records <= RECORDS_PER_PAGE)
            { count = (int)records; pagenum = 0; }
            else
            {
                Boolean check = ((int)(records) - (RECORDS_PER_PAGE * numberofpages) == 0) ? true : false;
                if (nPage != numberofpages) { count = (nPage * RECORDS_PER_PAGE); pagenum = (count - RECORDS_PER_PAGE); }
                else
                {
                    count = ((int)records);
                    { if (check) { pagenum = RECORDS_PER_PAGE; } else { pagenum = ((count / RECORDS_PER_PAGE) * RECORDS_PER_PAGE); } }
                }
            }

            for (record = pagenum; record <= count - 1; record++)
            {

                {
                    Console.WriteLine("This is record " + record + " of " + count + " on page " + nPage + " of " + records + " records");
                }
            }

            Console.ReadLine();
        }

        public static void SortString()
        {
            string str;
            char[] arr1;
            char ch;
            int i, j, l;
            Console.Write("\n\nSort a string array in ascending order :\n");
            Console.Write("--------------------------------------------\n");
            Console.Write("Input the string : ");
            str = Console.ReadLine();
            l = str.Length;
            arr1 = str.ToCharArray(0, l);

            for (i = 1; i < l; i++)
                for (j = 0; j < l - i; j++)

                    if (arr1[j] > arr1[j + 1])
                    {
                        ch = arr1[j];
                        arr1[j] = arr1[j + 1];
                        arr1[j + 1] = ch;
                    }
            Console.Write("After sorting the string appears like : \n");
            foreach (char c in arr1)
            {
                ch = c;
                Console.Write("{0} ", ch);
            }
            Console.WriteLine("\n");
            Console.ReadLine();
        }

        public static void Searchfield()
        {
            Console.WriteLine("Hello World!");
            string searchtemp = "";
            string word = "";
            int location = 0;
            string searchfield = "This+is+a+test";
            int i = 0;
            searchtemp = searchfield;
            word = Left(searchtemp, searchtemp.IndexOf("+", 1));
            for (i = 0; i <= searchfield.Length - 1; i++)
            {
                if (searchtemp.IndexOf("+", 1) > 0)
                {
                    try
                    {
                        Console.WriteLine(word);
                        location = searchtemp.IndexOf("+", 1);
                        searchtemp = Mid(searchtemp, location);
                        word = Left(searchtemp, searchtemp.IndexOf("+", 1));
                    }
                    catch { break; }
                }
            }

            {

            }

            Console.WriteLine(searchtemp);
            Console.ReadLine();
        }

        public static string Mid(string s, int a)

        {

            string temp = s.Substring(a + 1);

            return temp;

        }

        public static string Left(string s, int a)

        {

            string temp = s.Substring(0, a);

            return temp;

        }

        public static void DoLinuxFilename()
            {
            string filename = "";
            int index = 0;
            int length = 0;
            string filestr = "home/richard/Projects/www/Home/Documents/";
            string filestr2 = "home/richard/Projects/www/Home/Documents/test2.txt";

            index = filestr2.IndexOf("/Documents/");

            length = filestr2.Length - filestr.Length;

            if (index != -1)
            {
                filename = Mid(filestr2,filestr.Length-1);
            }
            else
                filename = "text2.txt";

            Console.WriteLine(filename);
            Console.ReadLine();
        }

        public static (string, string, string, string) PhoneCall(string pagesource)
        {
            string name = "";
            string phonenum = "";
            string datetime = "";
            string blocked = "";
            string phonecallstr = "";
            int pos = 0;

            phonecallstr = pagesource;

            //for (int i = 0; i < pagesource.Length; i++)
            {

                pos = phonecallstr.IndexOf(";");
                name = Left(phonecallstr, pos );

                phonecallstr = Mid(phonecallstr, pos);

                pos = phonecallstr.IndexOf(";");
                phonenum = Left(phonecallstr, pos);

                phonecallstr = Mid(phonecallstr, pos);

                pos = phonecallstr.IndexOf(";");
                datetime = Left(phonecallstr, pos);

                phonecallstr = Mid(phonecallstr, pos);

                blocked = phonecallstr;

            }

            return (name, phonenum, datetime, blocked);
        }

        public static (string, string, string) addphonenum(string input)
        {
            //example add Misc Business:18773450000:blocked

            string phrase = "";
            string name = "";
            string phonenumber = "";
            string blocked = "";
            int pos = 0;

            phrase = input;
            phrase = Mid(input, 3);
            pos = phrase.IndexOf(":");

            name = Left(phrase, pos);

            phrase = Mid(phrase, name.Length);
            pos = phrase.IndexOf(":");

            phonenumber = Left(phrase, pos);

            blocked = Mid(phrase, phonenumber.Length);

            return (name, phonenumber, blocked);
        }
    }
}
