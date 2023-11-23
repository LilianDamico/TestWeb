using System.Text.RegularExpressions;

namespace TestWeb.Models
{
    public class Container
    {
        
        public int ContainerID { get; set; }

        public string Client { get; set; }

        public string BillOfLading { get; set; }

        private string _containerIdentity;

        public string ContainerIdentity
        {
            get { return _containerIdentity; }
            set
            {
                if (IsValidContainerIdentity(value))
                    _containerIdentity = value;
                else
                    throw new ArgumentException("Invalid Container Identity format. It must be 4 letters followed by 7 numbers.");
            }
        }

        public string ContainerType { get; set; }

        public string ContainerDimension { get; set; }

        public bool Status { get; set; }

        public bool Comex { get; set; }

        private bool IsValidContainerIdentity(string identity)
        {
            return Regex.IsMatch(identity, @"^[A-Za-z]{4}\d{7}$");
        }
    }
}
