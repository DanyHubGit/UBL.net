#region Copyright
/*
Copyright 2014 Cluster Reply s.r.l.

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/
#endregion
// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.32989
//    <NameSpace>Oasis.Ubl.v21</NameSpace><Collection>ObservableCollection</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>False</GenerateXMLAttributes><OrderXMLAttrib>False</OrderXMLAttrib><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace Oasis.Ubl.v21 {
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.ObjectModel;
    
    
    public partial class SignatureType {
        
        private SignedInfoType signedInfoField;
        
        private SignatureValueType signatureValueField;
        
        private KeyInfoType keyInfoField;
        
        private ObservableCollection<ObjectType> objectField;
        
        //private string idField;


        public SignatureType()
        {
            this.objectField = new ObservableCollection<ObjectType>();
            this.keyInfoField = new KeyInfoType();
            this.signatureValueField = new SignatureValueType();
            this.signedInfoField = new SignedInfoType();
        }
        
        public SignedInfoType SignedInfo {
            get {
                return this.signedInfoField;
            }
            set {
                this.signedInfoField = value;
            }
        }
        
        public SignatureValueType SignatureValue {
            get {
                return this.signatureValueField;
            }
            set {
                this.signatureValueField = value;
            }
        }
        
        public KeyInfoType KeyInfo {
            get {
                return this.keyInfoField;
            }
            set {
                this.keyInfoField = value;
            }
        }
        
        public ObservableCollection<ObjectType> Object {
            get {
                return this.objectField;
            }
            set {
                this.objectField = value;
            }
        }

        //public string Id {
        //    get {
        //        return this.idField;
        //    }
        //    set {
        //        this.idField = value;
        //    }
        //}
    }
    
    public partial class SignedInfoType {
        
        private CanonicalizationMethodType canonicalizationMethodField;
        
        private SignatureMethodType signatureMethodField;
        
        private ObservableCollection<ReferenceType> referenceField;
        
        private string idField;
        
        public SignedInfoType() {
            this.referenceField = new ObservableCollection<ReferenceType>();
            this.signatureMethodField = new SignatureMethodType();
            this.canonicalizationMethodField = new CanonicalizationMethodType();
        }
        
        public CanonicalizationMethodType CanonicalizationMethod {
            get {
                return this.canonicalizationMethodField;
            }
            set {
                this.canonicalizationMethodField = value;
            }
        }
        
        public SignatureMethodType SignatureMethod {
            get {
                return this.signatureMethodField;
            }
            set {
                this.signatureMethodField = value;
            }
        }
        
        public ObservableCollection<ReferenceType> Reference {
            get {
                return this.referenceField;
            }
            set {
                this.referenceField = value;
            }
        }
        
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    public partial class CanonicalizationMethodType {
        
        private ObservableCollection<System.Xml.XmlNode> anyField;
        
        private string algorithmField;
        
        public CanonicalizationMethodType() {
            this.anyField = new ObservableCollection<System.Xml.XmlNode>();
        }
        
        //[System.Xml.Serialization.XmlAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        //[System.Xml.Serialization.XmlArrayItemAttribute()]

        public ObservableCollection<System.Xml.XmlNode> Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
        
        public string Algorithm {
            get {
                return this.algorithmField;
            }
            set {
                this.algorithmField = value;
            }
        }
    }
    
    public partial class ObjectType {
        
        private ObservableCollection<System.Xml.XmlNode> anyField;
        
        private string idField;
        
        private string mimeTypeField;
        
        private string encodingField;
        
        public ObjectType() {
            this.anyField = new ObservableCollection<System.Xml.XmlNode>();
        }
        
        //[System.Xml.Serialization.XmlAttribute()]
        //[System.Xml.Serialization.XmlAnyElementAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute()]
        public ObservableCollection<System.Xml.XmlNode> Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
        
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        public string MimeType {
            get {
                return this.mimeTypeField;
            }
            set {
                this.mimeTypeField = value;
            }
        }
        
        public string Encoding {
            get {
                return this.encodingField;
            }
            set {
                this.encodingField = value;
            }
        }
    }
    
    public partial class SPKIDataType {
        
        private byte[][] sPKISexpField;
        
        private System.Xml.XmlElement anyField;
        
        public byte[][] SPKISexp {
            get {
                return this.sPKISexpField;
            }
            set {
                this.sPKISexpField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
    }
    
    public partial class PGPDataType {

        private object[] _items;

        private ItemsChoiceType1[] _itemsElementName;

      
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("PGPKeyID", typeof(byte[]), DataType = "base64Binary")]
        [System.Xml.Serialization.XmlElementAttribute("PGPKeyPacket", typeof(byte[]), DataType = "base64Binary")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this._items;
            }
            set
            {
                this._items = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType1[] ItemsElementName
        {
            get
            {
                return this._itemsElementName;
            }
            set
            {
                this._itemsElementName = value;
            }
        }
    }
    
    public enum ItemsChoiceType1 {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("##any:")]
        Item,
        
        /// <remarks/>
        PGPKeyID,
        
        /// <remarks/>
        PGPKeyPacket,
    }
    
    public partial class X509IssuerSerialType {
        
        private string x509IssuerNameField;
        
        private string x509SerialNumberField;
        
        public string X509IssuerName {
            get {
                return this.x509IssuerNameField;
            }
            set {
                this.x509IssuerNameField = value;
            }
        }
        
        public string X509SerialNumber {
            get {
                return this.x509SerialNumberField;
            }
            set {
                this.x509SerialNumberField = value;
            }
        }
    }
    
    public partial class X509DataType {

        private object[] _items;

        private ItemsChoiceType[] _itemsElementName;

        [System.Xml.Serialization.XmlAnyElementAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("X509CRL", typeof(byte[]), DataType = "base64Binary")]
        [System.Xml.Serialization.XmlElementAttribute("X509Certificate", typeof(byte[]), DataType = "base64Binary")]
        [System.Xml.Serialization.XmlElementAttribute("X509IssuerSerial", typeof(X509IssuerSerialType))]
        [System.Xml.Serialization.XmlElementAttribute("X509SKI", typeof(byte[]), DataType = "base64Binary")]
        [System.Xml.Serialization.XmlElementAttribute("X509SubjectName", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this._items;
            }
            set
            {
                this._items = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this._itemsElementName;
            }
            set
            {
                this._itemsElementName = value;
            }
        }
    }
    
    public enum ItemsChoiceType {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("##any:")]
        Item,
        
        /// <remarks/>
        X509CRL,
        
        /// <remarks/>
        X509Certificate,
        
        /// <remarks/>
        X509IssuerSerial,
        
        /// <remarks/>
        X509SKI,
        
        /// <remarks/>
        X509SubjectName,
    }
    
    public partial class RetrievalMethodType {
        
        private ObservableCollection<TransformType> transformsField;
        
        private string uRIField;
        
        private string typeField;
        
        public RetrievalMethodType() {
            this.transformsField = new ObservableCollection<TransformType>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable=false)]
        public ObservableCollection<TransformType> Transforms {
            get {
                return this.transformsField;
            }
            set {
                this.transformsField = value;
            }
        }
        
        public string URI {
            get {
                return this.uRIField;
            }
            set {
                this.uRIField = value;
            }
        }
        
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
    }
    
    public partial class TransformType {
        
        private ObservableCollection<object> itemsField;
        
        private ObservableCollection<string> textField;
        
        private string algorithmField;
        
        public TransformType() {
            this.textField = new ObservableCollection<string>();
            this.itemsField = new ObservableCollection<object>();
        }
        
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public ObservableCollection<object> Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttribute()]
        public ObservableCollection<string> Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
        
        public string Algorithm {
            get {
                return this.algorithmField;
            }
            set {
                this.algorithmField = value;
            }
        }
    }
    
    public partial class RSAKeyValueType {
        
        private byte[] modulusField;
        
        private byte[] exponentField;
        
        public byte[] Modulus {
            get {
                return this.modulusField;
            }
            set {
                this.modulusField = value;
            }
        }
        
        public byte[] Exponent {
            get {
                return this.exponentField;
            }
            set {
                this.exponentField = value;
            }
        }
    }
    
    public partial class DSAKeyValueType {
        
        private byte[] pField;
        
        private byte[] qField;
        
        private byte[] gField;
        
        private byte[] yField;
        
        private byte[] jField;
        
        private byte[] seedField;
        
        private byte[] pgenCounterField;
        
        public byte[] P {
            get {
                return this.pField;
            }
            set {
                this.pField = value;
            }
        }
        
        public byte[] Q {
            get {
                return this.qField;
            }
            set {
                this.qField = value;
            }
        }
        
        public byte[] G {
            get {
                return this.gField;
            }
            set {
                this.gField = value;
            }
        }
        
        public byte[] Y {
            get {
                return this.yField;
            }
            set {
                this.yField = value;
            }
        }
        
        public byte[] J {
            get {
                return this.jField;
            }
            set {
                this.jField = value;
            }
        }
        
        public byte[] Seed {
            get {
                return this.seedField;
            }
            set {
                this.seedField = value;
            }
        }
        
        public byte[] PgenCounter {
            get {
                return this.pgenCounterField;
            }
            set {
                this.pgenCounterField = value;
            }
        }
    }
    
    public partial class KeyValueType {
        
        private object itemField;
        
        private ObservableCollection<string> textField;
        
        public KeyValueType() {
            this.textField = new ObservableCollection<string>();
        }
        
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttribute()]
        public ObservableCollection<string> Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
    }
    
    public partial class KeyInfoType {
        
        private ItemsChoiceType2[] _itemsElementName;

        private ObservableCollection<string> _text;

        private string _id;

        private object[] _items;

        public KeyInfoType()
        {
            this._text = new ObservableCollection<string>();
        }

        [System.Xml.Serialization.XmlAnyElementAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("KeyName", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("KeyValue", typeof(KeyValueType))]
        [System.Xml.Serialization.XmlElementAttribute("MgmtData", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("PGPData", typeof(PGPDataType))]
        [System.Xml.Serialization.XmlElementAttribute("RetrievalMethod", typeof(RetrievalMethodType))]
        [System.Xml.Serialization.XmlElementAttribute("SPKIData", typeof(SPKIDataType))]
        [System.Xml.Serialization.XmlElementAttribute("X509Data", typeof(X509DataType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this._items;
            }
            set
            {
                this._items = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType2[] ItemsElementName
        {
            get
            {
                return this._itemsElementName;
            }
            set
            {
                this._itemsElementName = value;
            }
        }

        [System.Xml.Serialization.XmlTextAttribute()]
        public ObservableCollection<string> Text
        {
            get
            {
                return this._text;
            }
            set
            {
                this._text = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        }
    
    public enum ItemsChoiceType2 {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("##any:")]
        Item,
        
        /// <remarks/>
        KeyName,
        
        /// <remarks/>
        KeyValue,
        
        /// <remarks/>
        MgmtData,
        
        /// <remarks/>
        PGPData,
        
        /// <remarks/>
        RetrievalMethod,
        
        /// <remarks/>
        SPKIData,
        
        /// <remarks/>
        X509Data,
    }
    
    public partial class SignatureValueType {
        
        private string idField;
        
        private byte[] valueField;
        
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttribute(DataType="base64Binary")]
        public byte[] Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    public partial class DigestMethodType {
        
        private ObservableCollection<System.Xml.XmlNode> anyField;
        
        private string algorithmField;
        
        public DigestMethodType() {
            this.anyField = new ObservableCollection<System.Xml.XmlNode>();
        }
        
        //[System.Xml.Serialization.XmlAttribute()]
        //[System.Xml.Serialization.XmlAnyElementAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute()]
        public ObservableCollection<System.Xml.XmlNode> Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
        
        public string Algorithm {
            get {
                return this.algorithmField;
            }
            set {
                this.algorithmField = value;
            }
        }
    }
    
    public partial class ReferenceType {
        
        private ObservableCollection<TransformType> transformsField;
        
        private DigestMethodType digestMethodField;
        
        private byte[] digestValueField;
        
        private string idField;
        
        private string uRIField;
        
        private string typeField;
        
        public ReferenceType() {
            this.digestMethodField = new DigestMethodType();
            this.transformsField = new ObservableCollection<TransformType>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable=false)]
        public ObservableCollection<TransformType> Transforms {
            get {
                return this.transformsField;
            }
            set {
                this.transformsField = value;
            }
        }
        
        public DigestMethodType DigestMethod {
            get {
                return this.digestMethodField;
            }
            set {
                this.digestMethodField = value;
            }
        }
        
        public byte[] DigestValue {
            get {
                return this.digestValueField;
            }
            set {
                this.digestValueField = value;
            }
        }
        
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        public string URI {
            get {
                return this.uRIField;
            }
            set {
                this.uRIField = value;
            }
        }
        
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
    }
    
    public partial class SignatureMethodType {
        
        private string hMACOutputLengthField;
        
        private ObservableCollection<System.Xml.XmlNode> anyField;
        
        private string algorithmField;
        
        public SignatureMethodType() {
            this.anyField = new ObservableCollection<System.Xml.XmlNode>();
        }
        
        public string HMACOutputLength {
            get {
                return this.hMACOutputLengthField;
            }
            set {
                this.hMACOutputLengthField = value;
            }
        }
        
        //[System.Xml.Serialization.XmlAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        //[System.Xml.Serialization.XmlArrayItemAttribute()]

        public ObservableCollection<System.Xml.XmlNode> Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
        
        public string Algorithm {
            get {
                return this.algorithmField;
            }
            set {
                this.algorithmField = value;
            }
        }
    }
    
    public partial class TransformsType {
        
        private ObservableCollection<TransformType> transformField;
        
        public TransformsType() {
            this.transformField = new ObservableCollection<TransformType>();
        }
        
        public ObservableCollection<TransformType> Transform {
            get {
                return this.transformField;
            }
            set {
                this.transformField = value;
            }
        }
    }
    
    public partial class ManifestType {
        
        private ObservableCollection<ReferenceType> referenceField;
        
        private string idField;
        
        public ManifestType() {
            this.referenceField = new ObservableCollection<ReferenceType>();
        }
        
        public ObservableCollection<ReferenceType> Reference {
            get {
                return this.referenceField;
            }
            set {
                this.referenceField = value;
            }
        }
        
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    public partial class SignaturePropertiesType {
        
        private ObservableCollection<SignaturePropertyType> signaturePropertyField;
        
        private string idField;
        
        public SignaturePropertiesType() {
            this.signaturePropertyField = new ObservableCollection<SignaturePropertyType>();
        }
        
        public ObservableCollection<SignaturePropertyType> SignatureProperty {
            get {
                return this.signaturePropertyField;
            }
            set {
                this.signaturePropertyField = value;
            }
        }
        
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    public partial class SignaturePropertyType {
        
        private ObservableCollection<System.Xml.XmlElement> itemsField;
        
        private ObservableCollection<string> textField;
        
        private string targetField;
        
        private string idField;
        
        public SignaturePropertyType() {
            this.textField = new ObservableCollection<string>();
            this.itemsField = new ObservableCollection<System.Xml.XmlElement>();
        }
        
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public ObservableCollection<System.Xml.XmlElement> Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttribute()]
        public ObservableCollection<string> Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
        
        public string Target {
            get {
                return this.targetField;
            }
            set {
                this.targetField = value;
            }
        }
        
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
}
