using FluentApiExample.Config;
using FluentApiExample.Interfaces;

namespace FluentApiExample
{
    public class FluentEmailSender : ISetServer, ISetSubject, ISetBody, IAddTo, ISendFunction
    {
        private string _server;
        private List<string> _to = [];
        private string _subject;
        private string _body;

        private FluentEmailSender() { }

        public static ISetServer CreateSender(Action<SenderConfiguration> config)
        {
            var _config = new SenderConfiguration();
            config?.Invoke(_config);
            var apiKey = _config?.ApiKey;

            return new FluentEmailSender();
        }
        public static ISetServer CreateSender()
        {
            return new FluentEmailSender();
        }

        public bool Send()
        {
            // Email sending operations
            Console.WriteLine("sending emails..");
            return true;
        }

        public ISetSubject SetServer(string server)
        {
            this._server = server;
            return this;
        }

        public ISetBody SetSubject(string subject)
        {
            this._subject = subject;
            return this;
        }

        public IAddTo SetBody(string body)
        {
            this._body = body;
            return this;
        }

        public ISendFunction AddTo(string to)
        {
            this._to.Add(to);
            return this;
        }
    }
}
