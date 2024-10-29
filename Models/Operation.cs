using System.Xml.Serialization;

namespace CalculatorApp.Models
{
    public class Operation
    {
        [XmlAttribute("ID")]
        public required string ID { get; set; }
        [XmlElement("Value")]
        public required string[] Value { get; set; }
    }

}
