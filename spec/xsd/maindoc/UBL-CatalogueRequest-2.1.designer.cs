// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.32989
//    <NameSpace>Oasis.Ubl.v21</NameSpace><Collection>ObservableCollection</Collection><codeType>CSharp</codeType><EnableDataBinding>True</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>True</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>True</GenerateCloneMethod><GenerateDataContracts>True</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>False</GenerateXMLAttributes><OrderXMLAttrib>False</OrderXMLAttrib><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace Oasis.Ubl.v21 {
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.IO;
    using System.Text;
    using System.Collections.ObjectModel;
    
    
    public partial class CatalogueRequestType : System.ComponentModel.INotifyPropertyChanged {
        
        private ObservableCollection<UBLExtensionType> uBLExtensionsField;
        
        private UBLVersionIDType uBLVersionIDField;
        
        private CustomizationIDType customizationIDField;
        
        private ProfileIDType profileIDField;
        
        private ProfileExecutionIDType profileExecutionIDField;
        
        private IDType idField;
        
        private UUIDType uUIDField;
        
        private NameType1 nameField;
        
        private IssueDateType issueDateField;
        
        private IssueTimeType issueTimeField;
        
        private ObservableCollection<NoteType> noteField;
        
        private ObservableCollection<DescriptionType> descriptionField;
        
        private PricingUpdateRequestIndicatorType pricingUpdateRequestIndicatorField;
        
        private ItemUpdateRequestIndicatorType itemUpdateRequestIndicatorField;
        
        private LineCountNumericType lineCountNumericField;
        
        private ObservableCollection<PeriodType> validityPeriodField;
        
        private ObservableCollection<SignatureType> signatureField;
        
        private PartyType receiverPartyField;
        
        private PartyType providerPartyField;
        
        private SupplierPartyType sellerSupplierPartyField;
        
        private CustomerPartyType contractorCustomerPartyField;
        
        private CatalogueReferenceType requestedCatalogueReferenceField;
        
        private ObservableCollection<ContractType> referencedContractField;
        
        private TradingTermsType tradingTermsField;
        
        private ObservableCollection<DocumentReferenceType> documentReferenceField;
        
        private ObservableCollection<AddressType> applicableTerritoryAddressField;
        
        private LanguageType requestedLanguageField;
        
        private ObservableCollection<ClassificationSchemeType> requestedClassificationSchemeField;
        
        private ObservableCollection<CatalogueRequestLineType> catalogueRequestLineField;
        
        private static System.Xml.Serialization.XmlSerializer serializer;
        
        public CatalogueRequestType() {
            this.catalogueRequestLineField = new ObservableCollection<CatalogueRequestLineType>();
            this.requestedClassificationSchemeField = new ObservableCollection<ClassificationSchemeType>();
            this.requestedLanguageField = new LanguageType();
            this.applicableTerritoryAddressField = new ObservableCollection<AddressType>();
            this.documentReferenceField = new ObservableCollection<DocumentReferenceType>();
            this.tradingTermsField = new TradingTermsType();
            this.referencedContractField = new ObservableCollection<ContractType>();
            this.requestedCatalogueReferenceField = new CatalogueReferenceType();
            this.contractorCustomerPartyField = new CustomerPartyType();
            this.sellerSupplierPartyField = new SupplierPartyType();
            this.providerPartyField = new PartyType();
            this.receiverPartyField = new PartyType();
            this.signatureField = new ObservableCollection<SignatureType>();
            this.validityPeriodField = new ObservableCollection<PeriodType>();
            this.lineCountNumericField = new LineCountNumericType();
            this.itemUpdateRequestIndicatorField = new ItemUpdateRequestIndicatorType();
            this.pricingUpdateRequestIndicatorField = new PricingUpdateRequestIndicatorType();
            this.descriptionField = new ObservableCollection<DescriptionType>();
            this.noteField = new ObservableCollection<NoteType>();
            this.issueTimeField = new IssueTimeType();
            this.issueDateField = new IssueDateType();
            this.nameField = new NameType1();
            this.uUIDField = new UUIDType();
            this.idField = new IDType();
            this.profileExecutionIDField = new ProfileExecutionIDType();
            this.profileIDField = new ProfileIDType();
            this.customizationIDField = new CustomizationIDType();
            this.uBLVersionIDField = new UBLVersionIDType();
            this.uBLExtensionsField = new ObservableCollection<UBLExtensionType>();
        }
        
        [System.Xml.Serialization.XmlArrayAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
        [System.Xml.Serialization.XmlArrayItemAttribute("UBLExtension", IsNullable=false)]
        public ObservableCollection<UBLExtensionType> UBLExtensions {
            get {
                return this.uBLExtensionsField;
            }
            set {
                if ((this.uBLExtensionsField != null)) {
                    if ((uBLExtensionsField.Equals(value) != true)) {
                        this.uBLExtensionsField = value;
                        this.OnPropertyChanged("UBLExtensions");
                    }
                }
                else {
                    this.uBLExtensionsField = value;
                    this.OnPropertyChanged("UBLExtensions");
                }
            }
        }
        
        public UBLVersionIDType UBLVersionID {
            get {
                return this.uBLVersionIDField;
            }
            set {
                if ((this.uBLVersionIDField != null)) {
                    if ((uBLVersionIDField.Equals(value) != true)) {
                        this.uBLVersionIDField = value;
                        this.OnPropertyChanged("UBLVersionID");
                    }
                }
                else {
                    this.uBLVersionIDField = value;
                    this.OnPropertyChanged("UBLVersionID");
                }
            }
        }
        
        public CustomizationIDType CustomizationID {
            get {
                return this.customizationIDField;
            }
            set {
                if ((this.customizationIDField != null)) {
                    if ((customizationIDField.Equals(value) != true)) {
                        this.customizationIDField = value;
                        this.OnPropertyChanged("CustomizationID");
                    }
                }
                else {
                    this.customizationIDField = value;
                    this.OnPropertyChanged("CustomizationID");
                }
            }
        }
        
        public ProfileIDType ProfileID {
            get {
                return this.profileIDField;
            }
            set {
                if ((this.profileIDField != null)) {
                    if ((profileIDField.Equals(value) != true)) {
                        this.profileIDField = value;
                        this.OnPropertyChanged("ProfileID");
                    }
                }
                else {
                    this.profileIDField = value;
                    this.OnPropertyChanged("ProfileID");
                }
            }
        }
        
        public ProfileExecutionIDType ProfileExecutionID {
            get {
                return this.profileExecutionIDField;
            }
            set {
                if ((this.profileExecutionIDField != null)) {
                    if ((profileExecutionIDField.Equals(value) != true)) {
                        this.profileExecutionIDField = value;
                        this.OnPropertyChanged("ProfileExecutionID");
                    }
                }
                else {
                    this.profileExecutionIDField = value;
                    this.OnPropertyChanged("ProfileExecutionID");
                }
            }
        }
        
        public IDType ID {
            get {
                return this.idField;
            }
            set {
                if ((this.idField != null)) {
                    if ((idField.Equals(value) != true)) {
                        this.idField = value;
                        this.OnPropertyChanged("ID");
                    }
                }
                else {
                    this.idField = value;
                    this.OnPropertyChanged("ID");
                }
            }
        }
        
        public UUIDType UUID {
            get {
                return this.uUIDField;
            }
            set {
                if ((this.uUIDField != null)) {
                    if ((uUIDField.Equals(value) != true)) {
                        this.uUIDField = value;
                        this.OnPropertyChanged("UUID");
                    }
                }
                else {
                    this.uUIDField = value;
                    this.OnPropertyChanged("UUID");
                }
            }
        }
        
        public NameType1 Name {
            get {
                return this.nameField;
            }
            set {
                if ((this.nameField != null)) {
                    if ((nameField.Equals(value) != true)) {
                        this.nameField = value;
                        this.OnPropertyChanged("Name");
                    }
                }
                else {
                    this.nameField = value;
                    this.OnPropertyChanged("Name");
                }
            }
        }
        
        public IssueDateType IssueDate {
            get {
                return this.issueDateField;
            }
            set {
                if ((this.issueDateField != null)) {
                    if ((issueDateField.Equals(value) != true)) {
                        this.issueDateField = value;
                        this.OnPropertyChanged("IssueDate");
                    }
                }
                else {
                    this.issueDateField = value;
                    this.OnPropertyChanged("IssueDate");
                }
            }
        }
        
        public IssueTimeType IssueTime {
            get {
                return this.issueTimeField;
            }
            set {
                if ((this.issueTimeField != null)) {
                    if ((issueTimeField.Equals(value) != true)) {
                        this.issueTimeField = value;
                        this.OnPropertyChanged("IssueTime");
                    }
                }
                else {
                    this.issueTimeField = value;
                    this.OnPropertyChanged("IssueTime");
                }
            }
        }
        
        public ObservableCollection<NoteType> Note {
            get {
                return this.noteField;
            }
            set {
                if ((this.noteField != null)) {
                    if ((noteField.Equals(value) != true)) {
                        this.noteField = value;
                        this.OnPropertyChanged("Note");
                    }
                }
                else {
                    this.noteField = value;
                    this.OnPropertyChanged("Note");
                }
            }
        }
        
        public ObservableCollection<DescriptionType> Description {
            get {
                return this.descriptionField;
            }
            set {
                if ((this.descriptionField != null)) {
                    if ((descriptionField.Equals(value) != true)) {
                        this.descriptionField = value;
                        this.OnPropertyChanged("Description");
                    }
                }
                else {
                    this.descriptionField = value;
                    this.OnPropertyChanged("Description");
                }
            }
        }
        
        public PricingUpdateRequestIndicatorType PricingUpdateRequestIndicator {
            get {
                return this.pricingUpdateRequestIndicatorField;
            }
            set {
                if ((this.pricingUpdateRequestIndicatorField != null)) {
                    if ((pricingUpdateRequestIndicatorField.Equals(value) != true)) {
                        this.pricingUpdateRequestIndicatorField = value;
                        this.OnPropertyChanged("PricingUpdateRequestIndicator");
                    }
                }
                else {
                    this.pricingUpdateRequestIndicatorField = value;
                    this.OnPropertyChanged("PricingUpdateRequestIndicator");
                }
            }
        }
        
        public ItemUpdateRequestIndicatorType ItemUpdateRequestIndicator {
            get {
                return this.itemUpdateRequestIndicatorField;
            }
            set {
                if ((this.itemUpdateRequestIndicatorField != null)) {
                    if ((itemUpdateRequestIndicatorField.Equals(value) != true)) {
                        this.itemUpdateRequestIndicatorField = value;
                        this.OnPropertyChanged("ItemUpdateRequestIndicator");
                    }
                }
                else {
                    this.itemUpdateRequestIndicatorField = value;
                    this.OnPropertyChanged("ItemUpdateRequestIndicator");
                }
            }
        }
        
        public LineCountNumericType LineCountNumeric {
            get {
                return this.lineCountNumericField;
            }
            set {
                if ((this.lineCountNumericField != null)) {
                    if ((lineCountNumericField.Equals(value) != true)) {
                        this.lineCountNumericField = value;
                        this.OnPropertyChanged("LineCountNumeric");
                    }
                }
                else {
                    this.lineCountNumericField = value;
                    this.OnPropertyChanged("LineCountNumeric");
                }
            }
        }
        
        public ObservableCollection<PeriodType> ValidityPeriod {
            get {
                return this.validityPeriodField;
            }
            set {
                if ((this.validityPeriodField != null)) {
                    if ((validityPeriodField.Equals(value) != true)) {
                        this.validityPeriodField = value;
                        this.OnPropertyChanged("ValidityPeriod");
                    }
                }
                else {
                    this.validityPeriodField = value;
                    this.OnPropertyChanged("ValidityPeriod");
                }
            }
        }
        
        public ObservableCollection<SignatureType> Signature {
            get {
                return this.signatureField;
            }
            set {
                if ((this.signatureField != null)) {
                    if ((signatureField.Equals(value) != true)) {
                        this.signatureField = value;
                        this.OnPropertyChanged("Signature");
                    }
                }
                else {
                    this.signatureField = value;
                    this.OnPropertyChanged("Signature");
                }
            }
        }
        
        public PartyType ReceiverParty {
            get {
                return this.receiverPartyField;
            }
            set {
                if ((this.receiverPartyField != null)) {
                    if ((receiverPartyField.Equals(value) != true)) {
                        this.receiverPartyField = value;
                        this.OnPropertyChanged("ReceiverParty");
                    }
                }
                else {
                    this.receiverPartyField = value;
                    this.OnPropertyChanged("ReceiverParty");
                }
            }
        }
        
        public PartyType ProviderParty {
            get {
                return this.providerPartyField;
            }
            set {
                if ((this.providerPartyField != null)) {
                    if ((providerPartyField.Equals(value) != true)) {
                        this.providerPartyField = value;
                        this.OnPropertyChanged("ProviderParty");
                    }
                }
                else {
                    this.providerPartyField = value;
                    this.OnPropertyChanged("ProviderParty");
                }
            }
        }
        
        public SupplierPartyType SellerSupplierParty {
            get {
                return this.sellerSupplierPartyField;
            }
            set {
                if ((this.sellerSupplierPartyField != null)) {
                    if ((sellerSupplierPartyField.Equals(value) != true)) {
                        this.sellerSupplierPartyField = value;
                        this.OnPropertyChanged("SellerSupplierParty");
                    }
                }
                else {
                    this.sellerSupplierPartyField = value;
                    this.OnPropertyChanged("SellerSupplierParty");
                }
            }
        }
        
        public CustomerPartyType ContractorCustomerParty {
            get {
                return this.contractorCustomerPartyField;
            }
            set {
                if ((this.contractorCustomerPartyField != null)) {
                    if ((contractorCustomerPartyField.Equals(value) != true)) {
                        this.contractorCustomerPartyField = value;
                        this.OnPropertyChanged("ContractorCustomerParty");
                    }
                }
                else {
                    this.contractorCustomerPartyField = value;
                    this.OnPropertyChanged("ContractorCustomerParty");
                }
            }
        }
        
        public CatalogueReferenceType RequestedCatalogueReference {
            get {
                return this.requestedCatalogueReferenceField;
            }
            set {
                if ((this.requestedCatalogueReferenceField != null)) {
                    if ((requestedCatalogueReferenceField.Equals(value) != true)) {
                        this.requestedCatalogueReferenceField = value;
                        this.OnPropertyChanged("RequestedCatalogueReference");
                    }
                }
                else {
                    this.requestedCatalogueReferenceField = value;
                    this.OnPropertyChanged("RequestedCatalogueReference");
                }
            }
        }
        
        public ObservableCollection<ContractType> ReferencedContract {
            get {
                return this.referencedContractField;
            }
            set {
                if ((this.referencedContractField != null)) {
                    if ((referencedContractField.Equals(value) != true)) {
                        this.referencedContractField = value;
                        this.OnPropertyChanged("ReferencedContract");
                    }
                }
                else {
                    this.referencedContractField = value;
                    this.OnPropertyChanged("ReferencedContract");
                }
            }
        }
        
        public TradingTermsType TradingTerms {
            get {
                return this.tradingTermsField;
            }
            set {
                if ((this.tradingTermsField != null)) {
                    if ((tradingTermsField.Equals(value) != true)) {
                        this.tradingTermsField = value;
                        this.OnPropertyChanged("TradingTerms");
                    }
                }
                else {
                    this.tradingTermsField = value;
                    this.OnPropertyChanged("TradingTerms");
                }
            }
        }
        
        public ObservableCollection<DocumentReferenceType> DocumentReference {
            get {
                return this.documentReferenceField;
            }
            set {
                if ((this.documentReferenceField != null)) {
                    if ((documentReferenceField.Equals(value) != true)) {
                        this.documentReferenceField = value;
                        this.OnPropertyChanged("DocumentReference");
                    }
                }
                else {
                    this.documentReferenceField = value;
                    this.OnPropertyChanged("DocumentReference");
                }
            }
        }
        
        public ObservableCollection<AddressType> ApplicableTerritoryAddress {
            get {
                return this.applicableTerritoryAddressField;
            }
            set {
                if ((this.applicableTerritoryAddressField != null)) {
                    if ((applicableTerritoryAddressField.Equals(value) != true)) {
                        this.applicableTerritoryAddressField = value;
                        this.OnPropertyChanged("ApplicableTerritoryAddress");
                    }
                }
                else {
                    this.applicableTerritoryAddressField = value;
                    this.OnPropertyChanged("ApplicableTerritoryAddress");
                }
            }
        }
        
        public LanguageType RequestedLanguage {
            get {
                return this.requestedLanguageField;
            }
            set {
                if ((this.requestedLanguageField != null)) {
                    if ((requestedLanguageField.Equals(value) != true)) {
                        this.requestedLanguageField = value;
                        this.OnPropertyChanged("RequestedLanguage");
                    }
                }
                else {
                    this.requestedLanguageField = value;
                    this.OnPropertyChanged("RequestedLanguage");
                }
            }
        }
        
        public ObservableCollection<ClassificationSchemeType> RequestedClassificationScheme {
            get {
                return this.requestedClassificationSchemeField;
            }
            set {
                if ((this.requestedClassificationSchemeField != null)) {
                    if ((requestedClassificationSchemeField.Equals(value) != true)) {
                        this.requestedClassificationSchemeField = value;
                        this.OnPropertyChanged("RequestedClassificationScheme");
                    }
                }
                else {
                    this.requestedClassificationSchemeField = value;
                    this.OnPropertyChanged("RequestedClassificationScheme");
                }
            }
        }
        
        public ObservableCollection<CatalogueRequestLineType> CatalogueRequestLine {
            get {
                return this.catalogueRequestLineField;
            }
            set {
                if ((this.catalogueRequestLineField != null)) {
                    if ((catalogueRequestLineField.Equals(value) != true)) {
                        this.catalogueRequestLineField = value;
                        this.OnPropertyChanged("CatalogueRequestLine");
                    }
                }
                else {
                    this.catalogueRequestLineField = value;
                    this.OnPropertyChanged("CatalogueRequestLine");
                }
            }
        }
        
        private static System.Xml.Serialization.XmlSerializer Serializer {
            get {
                if ((serializer == null)) {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(CatalogueRequestType));
                }
                return serializer;
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        public virtual void OnPropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null)) {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
        
        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current CatalogueRequestType object into an XML document
        /// </summary>
        /// <returns>string XML value</returns>
        public virtual string Serialize() {
            System.IO.StreamReader streamReader = null;
            System.IO.MemoryStream memoryStream = null;
            try {
                memoryStream = new System.IO.MemoryStream();
                Serializer.Serialize(memoryStream, this);
                memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
                streamReader = new System.IO.StreamReader(memoryStream);
                return streamReader.ReadToEnd();
            }
            finally {
                if ((streamReader != null)) {
                    streamReader.Dispose();
                }
                if ((memoryStream != null)) {
                    memoryStream.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Deserializes workflow markup into an CatalogueRequestType object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output CatalogueRequestType object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out CatalogueRequestType obj, out System.Exception exception) {
            exception = null;
            obj = default(CatalogueRequestType);
            try {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string xml, out CatalogueRequestType obj) {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }
        
        public static CatalogueRequestType Deserialize(string xml) {
            System.IO.StringReader stringReader = null;
            try {
                stringReader = new System.IO.StringReader(xml);
                return ((CatalogueRequestType)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally {
                if ((stringReader != null)) {
                    stringReader.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Serializes current CatalogueRequestType object into file
        /// </summary>
        /// <param name="fileName">full path of outupt xml file</param>
        /// <param name="exception">output Exception value if failed</param>
        /// <returns>true if can serialize and save into file; otherwise, false</returns>
        public virtual bool SaveToFile(string fileName, out System.Exception exception) {
            exception = null;
            try {
                SaveToFile(fileName);
                return true;
            }
            catch (System.Exception e) {
                exception = e;
                return false;
            }
        }
        
        public virtual void SaveToFile(string fileName) {
            System.IO.StreamWriter streamWriter = null;
            try {
                string xmlString = Serialize();
                System.IO.FileInfo xmlFile = new System.IO.FileInfo(fileName);
                streamWriter = xmlFile.CreateText();
                streamWriter.WriteLine(xmlString);
                streamWriter.Close();
            }
            finally {
                if ((streamWriter != null)) {
                    streamWriter.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Deserializes xml markup from file into an CatalogueRequestType object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output CatalogueRequestType object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out CatalogueRequestType obj, out System.Exception exception) {
            exception = null;
            obj = default(CatalogueRequestType);
            try {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out CatalogueRequestType obj) {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static CatalogueRequestType LoadFromFile(string fileName) {
            System.IO.FileStream file = null;
            System.IO.StreamReader sr = null;
            try {
                file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
                sr = new System.IO.StreamReader(file);
                string xmlString = sr.ReadToEnd();
                sr.Close();
                file.Close();
                return Deserialize(xmlString);
            }
            finally {
                if ((file != null)) {
                    file.Dispose();
                }
                if ((sr != null)) {
                    sr.Dispose();
                }
            }
        }
        #endregion
        
        #region Clone method
        /// <summary>
        /// Create a clone of this CatalogueRequestType object
        /// </summary>
        public virtual CatalogueRequestType Clone() {
            return ((CatalogueRequestType)(this.MemberwiseClone()));
        }
        #endregion
    }
}
