using System;
using System.Xml;
using System.Xml.Serialization;
namespace grendgine_collada
{

    [Serializable]
    [XmlType(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(ElementName = "texture", Namespace = "http://www.collada.org/2005/11/COLLADASchema", IsNullable = true)]
    public partial class Grendgine_Collada_Texture
    {
        [XmlAttribute("texture")]
        public string Texture;

        [XmlAttribute("texcoord")]
        public string TexCoord;

        [XmlElement(ElementName = "extra")]
        public Grendgine_Collada_Extra[] Extra;
    }
}

