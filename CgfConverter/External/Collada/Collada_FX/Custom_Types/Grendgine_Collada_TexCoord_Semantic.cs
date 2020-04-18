using System;
using System.Xml;
using System.Xml.Serialization;
namespace grendgine_collada
{

    [Serializable]
    [XmlType(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(ElementName = "texcoord", Namespace = "http://www.collada.org/2005/11/COLLADASchema", IsNullable = true)]
    public partial class Grendgine_Collada_TexCoord_Semantic
    {


        [XmlAttribute("semantic")]
        public string Semantic;
    }
}

