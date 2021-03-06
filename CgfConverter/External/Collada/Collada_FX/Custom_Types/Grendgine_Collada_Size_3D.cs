using System;
using System.Xml;
using System.Xml.Serialization;
namespace grendgine_collada
{

    [Serializable]
    [XmlType(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(ElementName = "size", Namespace = "http://www.collada.org/2005/11/COLLADASchema", IsNullable = true)]
    public partial class Grendgine_Collada_Size_3D
    {


        [XmlAttribute("width")]
        public int Width;

        [XmlAttribute("height")]
        public int Height;

        [XmlAttribute("depth")]
        public int Depth;
    }
}

