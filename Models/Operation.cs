using System.Xml.Serialization;

namespace CalculatorApp.DTO
{
    public class Operation
    {
        [XmlAttribute("ID")]
        public string ID { get; set; }
        [XmlElement("Value")]
        public string[] Value { get; set; }
    }

}
