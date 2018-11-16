namespace VmExpertise.Azure.Sentiment.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://VmExpertise.Azure.Sentiment.Schemas.message1",@"Root")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::VmExpertise.Azure.Sentiment.PropertySchema.goodorbad), XPath = @"/*[local-name()='Root' and namespace-uri()='http://VmExpertise.Azure.Sentiment.Schemas.message1']/*[local-name()='message' and namespace-uri()='']/*[local-name()='goodorbad' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Root"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"VmExpertise.Azure.Sentiment.PropertySchema.PropertySchema", typeof(global::VmExpertise.Azure.Sentiment.PropertySchema.PropertySchema))]
    public sealed class message1 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://VmExpertise.Azure.Sentiment.Schemas.message1"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://VmExpertise.Azure.Sentiment.PropertySchema"" targetNamespace=""http://VmExpertise.Azure.Sentiment.Schemas.message1"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://VmExpertise.Azure.Sentiment.PropertySchema"" location=""VmExpertise.Azure.Sentiment.PropertySchema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Root"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:goodorbad"" xpath=""/*[local-name()='Root' and namespace-uri()='http://VmExpertise.Azure.Sentiment.Schemas.message1']/*[local-name()='message' and namespace-uri()='']/*[local-name()='goodorbad' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""message"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""goodorbad"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public message1() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Root";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
