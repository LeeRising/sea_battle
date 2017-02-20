using System.Drawing;
using System.Net;

namespace Morskoy_boy.Tools
{
    class FriendsList
    {
        private string first_name;
        private string last_name;
        private string rank;
        private string photo_url;
        private string state;
        public FriendsList(string _first_name, string _last_name, string _rank, string _photo_url, string _state)
        {
            first_name = _first_name;
            last_name = _last_name;
            rank = _rank;
            photo_url = _photo_url;
            state = _state;
        }
        public string First_name
        {
            get { return first_name; }
            set { first_name = value; }
        }
        public string Last_name
        {
            get { return last_name; }
            set { last_name = value; }
        }
        public string Rank
        {
            get { return rank; }
            set { rank = value; }
        }
        public string Photo
        {
            get { return photo_url; }
            set { photo_url = value; }
        }
        public string State
        {
            get { return state.Substring(0, state.Length - 1); }
            set { state = value; }
        }
        public static Image Avatar(string photo_url)
        {
            var request = WebRequest.Create("https://leebattle.000webhostapp.com/avatar/" + photo_url);
            Image ava = null ;
            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                ava = Bitmap.FromStream(stream);
            }
            return ava;
        }
    }
}
