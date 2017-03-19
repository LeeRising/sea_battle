namespace ChatServer
{
    class ChatHistory
    {
        private string fromname;
        private string toname;
        private string message;
        public ChatHistory(string _fromname,string _toname,string _message)
        {
            this.fromname = _fromname;
            this.toname = _toname;
            this.message = _message;
        }
        public string FromName
        {
            get { return toname; }
            set { toname = value; }
        }
        public string ToName
        {
            get { return fromname; }
            set { fromname = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }
    }
}