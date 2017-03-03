using System.Drawing;
using System.Net;
using Morskoy_boy.Tools;

namespace Morskoy_boy.Tools
{
    class FriendsList
    {
        private uint id;
        private string first_name;
        private string last_name;
        private string rank;
        private string photo_url;
        private string state;
        private string last_online;
        public FriendsList(uint _id,string _first_name, string _last_name, string _rank, string _photo_url, string _state,string _last_online)
        {
            id = _id;
            first_name = _first_name;
            last_name = _last_name;
            rank = _rank;
            photo_url = _photo_url;
            state = _state;
            last_online = _last_online;
        }
        public uint Id
        {
            get { return id; }
            set { id = value; }
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
            get { return state; }
            set { state = value; }
        }
        public string Last_online
        {
            get { return last_online; }
            set { last_online = value; }
        }
        public static Image Avatar(string photo_url)
        {
            var request = WebRequest.Create(Variables._avatar + photo_url);
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
