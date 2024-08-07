namespace FirewallProxyDesignPattern.DocumentProject
{
    internal class Document : IDocument
    {
        private string _content;
        private string _sensitivity;
        public Document(string content, string sensitivity)
        {
            _content = content;
            _sensitivity = sensitivity;
        }
        public string Sensitivity => _sensitivity;
        public string ReadContent() => _content;
    }
}
