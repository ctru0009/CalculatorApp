using System.Xml.Serialization;

namespace CalculatorApp.DTO
{
    [XmlRoot("Maths")]
    public class Maths
    {
        [XmlElement("Operation")]
        public List<Operation> Operation { get; set; }
    }

}
