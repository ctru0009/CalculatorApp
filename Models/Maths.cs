using System.Xml.Serialization;

namespace CalculatorApp.Models
{
    [XmlRoot("Maths")]
    public class Maths
    {
        [XmlElement("Operation")]
        public required List<Operation> Operation { get; set; }
    }

}
