using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace Quartett
{
    class Card
    {
        private Int32 id;

        private string name;

        private Player player;

        private List<String> image = new List<string>();

        public const int numberOfProperties = 5;

        List<Property> properties = new List<Property>();


        public Int32 Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public Player Player
        {
            get
            {
                return player;
            }
            set
            {
                player = value;
            }
        }

        public List<Property> Properties
        {
            get
            {
                return properties;
            }
            set
            {
                properties = value;
            }
        }

        public List<string> GetImage()
        {
            int i = 0;
            string root = new FileInfo(Assembly.GetExecutingAssembly().Location).FullName;
            if (image.Count() == 0)
            {
                System.IO.StreamReader file =
                    new System.IO.StreamReader(@root + "..\\..\\..\\..\\HarryPotter_Schulprojekt\\ASCII_Images\\" + name + ".txt");
                while (!file.EndOfStream)
                {
                    image.Add(file.ReadLine());
                    i++;
                }
                file.Close();
            }
            return image;
        }
    }
}
