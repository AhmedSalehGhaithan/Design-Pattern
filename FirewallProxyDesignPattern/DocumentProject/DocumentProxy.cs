namespace FirewallProxyDesignPattern.DocumentProject
{
    public class DocumentProxy : IDocument
    {
        private Document _document;
        private string _employeeAccessLevel;
        public DocumentProxy(string content, string sensitivity, string employeeAccessLevel)
        {
            _document = new Document(content, sensitivity);
            _employeeAccessLevel = employeeAccessLevel;
        }
        private bool CanAccessDocument()
        {
            switch (_document.Sensitivity)
            {
                case "Public":
                    return true;
                case "Confidential":
                    return (_employeeAccessLevel == "Manager" || _employeeAccessLevel == "Executive");
                case "Top-Secret":
                    return (_employeeAccessLevel == "Executive");
                default:
                    return false;
            }
        }
        public string ReadContent() 
            => CanAccessDocument()? _document.ReadContent(): "Access Denied!";
    }
}
