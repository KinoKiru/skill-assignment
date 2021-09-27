using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skills
{
   public class Row 
    {
        private string name;
        private int id;
        private decimal price;
        private int minPlayers;
        private int maxPlayers;
        private string type;
        private int minAge;
        private int maxAge;
        private float playDuration;
        private string imgUrl;

        #region properties
        public string ImgUrl
        {
            get { return imgUrl; }
            set { imgUrl = value; }
        }


        public float PlayDuration
        {
            get { return playDuration; }
            set { playDuration = value; }
        }


        public int MaxAge
        {
            get { return maxAge; }
            set { maxAge = value; }
        }


        public int MinAge
        {
            get { return minAge; }
            set { minAge = value; }
        }


        public string Type
        {
            get { return type; }
            set { type = value; }
        }


        public int MaxPlayers
        {
            get { return maxPlayers; }
            set { maxPlayers = value; }
        }


        public int MinPlayers
        {
            get { return minPlayers; }
            set { minPlayers = value; }
        }


        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        #endregion


    
    }
}
