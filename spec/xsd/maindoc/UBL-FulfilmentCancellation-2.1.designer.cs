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
    
    
    public partial class FulfilmentCancellationType : System.ComponentModel.INotifyPropertyChanged {
        
        private ObservableCollection<UBLExtensionType> uBLExtensionsField;
        
        private UBLVersionIDType uBLVersionIDField;
        
        private CustomizationIDType customizationIDField;
        
        private ProfileIDType profileIDField;
        
        private ProfileExecutionIDType profileExecutionIDField;
        
        private IDType idField;
        
        private CopyIndicatorType copyIndicatorField;
        
        private UUIDType uUIDField;
        
        private IssueDateType issueDateField;
        
        private IssueTimeType issueTimeField;
        
        private ObservableCollection<NoteType> noteField;
        
        private ObservableCollection<CancellationNoteType> cancellationNoteField;
        
        private ObservableCollection<DocumentReferenceType> despatchDocumentReferenceField;
        
        private ObservableCollection<DocumentReferenceType> receiptDocumentReferenceField;
        
        private ObservableCollection<OrderReferenceType> orderReferenceField;
        
        private ObservableCollection<DocumentReferenceType> additionalDocumentReferenceField;
        
        private ObservableCollection<ContractType> contractField;
        
        private ObservableCollection<SignatureType> signatureField;
        
        private CustomerPartyType buyerCustomerPartyField;
        
        private SupplierPartyType sellerSupplierPartyField;
        
        private CustomerPartyType deliveryCustomerPartyField;
        
        private SupplierPartyType despatchSupplierPartyField;
        
        private CustomerPartyType originatorCustomerPartyField;
        
        private static System.Xml.Serialization.XmlSerializer serializer;
        
        public FulfilmentCancellationType() {
            this.originatorCustomerPartyField = new CustomerPartyType();
            this.despatchSupplierPartyField = new SupplierPartyType();
            this.deliveryCustomerPartyField = new CustomerPartyType();
            this.sellerSupplierPartyField = new SupplierPartyType();
            this.buyerCustomerPartyField = new CustomerPartyType();
            this.signatureField = new ObservableCollection<SignatureType>();
            this.contractField = new ObservableCollection<ContractType>();
            this.additionalDocumentReferenceField = new ObservableCollection<DocumentReferenceType>();
            this.orderReferenceField = new ObservableCollection<OrderReferenceType>();
            this.receiptDocumentReferenceField = new ObservableCollection<DocumentReferenceType>();
            this.despatchDocumentReferenceField = new ObservableCollection<DocumentReferenceType>();
            this.cancellationNoteField = new ObservableCollection<CancellationNoteType>();
            this.noteField = new ObservableCollection<NoteType>();
            this.issueTimeField = new IssueTimeType();
            this.issueDateField = new IssueDateType();
            this.uUIDField = new UUIDType();
            this.copyIndicatorField = new CopyIndicatorType();
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
        
        public CopyIndicatorType CopyIndicator {
            get {
                return this.copyIndicatorField;
            }
            set {
                if ((this.copyIndicatorField != null)) {
                    if ((copyIndicatorField.Equals(value) != true)) {
                        this.copyIndicatorField = value;
                        this.OnPropertyChanged("CopyIndicator");
                    }
                }
                else {
                    this.copyIndicatorField = value;
                    this.OnPropertyChanged("CopyIndicator");
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
        
        public ObservableCollection<CancellationNoteType> CancellationNote {
            get {
                return this.cancellationNoteField;
            }
            set {
                if ((this.cancellationNoteField != null)) {
                    if ((cancellationNoteField.Equals(value) != true)) {
                        this.cancellationNoteField = value;
                        this.OnPropertyChanged("CancellationNote");
                    }
                }
                else {
                    this.cancellationNoteField = value;
                    this.OnPropertyChanged("CancellationNote");
                }
            }
        }
        
        public ObservableCollection<DocumentReferenceType> DespatchDocumentReference {
            get {
                return this.despatchDocumentReferenceField;
            }
            set {
                if ((this.despatchDocumentReferenceField != null)) {
                    if ((despatchDocumentReferenceField.Equals(value) != true)) {
                        this.despatchDocumentReferenceField = value;
                        this.OnPropertyChanged("DespatchDocumentReference");
                    }
                }
                else {
                    this.despatchDocumentReferenceField = value;
                    this.OnPropertyChanged("DespatchDocumentReference");
                }
            }
        }
        
        public ObservableCollection<DocumentReferenceType> ReceiptDocumentReference {
            get {
                return this.receiptDocumentReferenceField;
            }
            set {
                if ((this.receiptDocumentReferenceField != null)) {
                    if ((receiptDocumentReferenceField.Equals(value) != true)) {
                        this.receiptDocumentReferenceField = value;
                        this.OnPropertyChanged("ReceiptDocumentReference");
                    }
                }
                else {
                    this.receiptDocumentReferenceField = value;
                    this.OnPropertyChanged("ReceiptDocumentReference");
                }
            }
        }
        
        public ObservableCollection<OrderReferenceType> OrderReference {
            get {
                return this.orderReferenceField;
            }
            set {
                if ((this.orderReferenceField != null)) {
                    if ((orderReferenceField.Equals(value) != true)) {
                        this.orderReferenceField = value;
                        this.OnPropertyChanged("OrderReference");
                    }
                }
                else {
                    this.orderReferenceField = value;
                    this.OnPropertyChanged("OrderReference");
                }
            }
        }
        
        public ObservableCollection<DocumentReferenceType> AdditionalDocumentReference {
            get {
                return this.additionalDocumentReferenceField;
            }
            set {
                if ((this.additionalDocumentReferenceField != null)) {
                    if ((additionalDocumentReferenceField.Equals(value) != true)) {
                        this.additionalDocumentReferenceField = value;
                        this.OnPropertyChanged("AdditionalDocumentReference");
                    }
                }
                else {
                    this.additionalDocumentReferenceField = value;
                    this.OnPropertyChanged("AdditionalDocumentReference");
                }
            }
        }
        
        public ObservableCollection<ContractType> Contract {
            get {
                return this.contractField;
            }
            set {
                if ((this.contractField != null)) {
                    if ((contractField.Equals(value) != true)) {
                        this.contractField = value;
                        this.OnPropertyChanged("Contract");
                    }
                }
                else {
                    this.contractField = value;
                    this.OnPropertyChanged("Contract");
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
        
        public CustomerPartyType BuyerCustomerParty {
            get {
                return this.buyerCustomerPartyField;
            }
            set {
                if ((this.buyerCustomerPartyField != null)) {
                    if ((buyerCustomerPartyField.Equals(value) != true)) {
                        this.buyerCustomerPartyField = value;
                        this.OnPropertyChanged("BuyerCustomerParty");
                    }
                }
                else {
                    this.buyerCustomerPartyField = value;
                    this.OnPropertyChanged("BuyerCustomerParty");
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
        
        public CustomerPartyType DeliveryCustomerParty {
            get {
                return this.deliveryCustomerPartyField;
            }
            set {
                if ((this.deliveryCustomerPartyField != null)) {
                    if ((deliveryCustomerPartyField.Equals(value) != true)) {
                        this.deliveryCustomerPartyField = value;
                        this.OnPropertyChanged("DeliveryCustomerParty");
                    }
                }
                else {
                    this.deliveryCustomerPartyField = value;
                    this.OnPropertyChanged("DeliveryCustomerParty");
                }
            }
        }
        
        public SupplierPartyType DespatchSupplierParty {
            get {
                return this.despatchSupplierPartyField;
            }
            set {
                if ((this.despatchSupplierPartyField != null)) {
                    if ((despatchSupplierPartyField.Equals(value) != true)) {
                        this.despatchSupplierPartyField = value;
                        this.OnPropertyChanged("DespatchSupplierParty");
                    }
                }
                else {
                    this.despatchSupplierPartyField = value;
                    this.OnPropertyChanged("DespatchSupplierParty");
                }
            }
        }
        
        public CustomerPartyType OriginatorCustomerParty {
            get {
                return this.originatorCustomerPartyField;
            }
            set {
                if ((this.originatorCustomerPartyField != null)) {
                    if ((originatorCustomerPartyField.Equals(value) != true)) {
                        this.originatorCustomerPartyField = value;
                        this.OnPropertyChanged("OriginatorCustomerParty");
                    }
                }
                else {
                    this.originatorCustomerPartyField = value;
                    this.OnPropertyChanged("OriginatorCustomerParty");
                }
            }
        }
        
        private static System.Xml.Serialization.XmlSerializer Serializer {
            get {
                if ((serializer == null)) {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(FulfilmentCancellationType));
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
        /// Serializes current FulfilmentCancellationType object into an XML document
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
        /// Deserializes workflow markup into an FulfilmentCancellationType object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output FulfilmentCancellationType object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out FulfilmentCancellationType obj, out System.Exception exception) {
            exception = null;
            obj = default(FulfilmentCancellationType);
            try {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string xml, out FulfilmentCancellationType obj) {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }
        
        public static FulfilmentCancellationType Deserialize(string xml) {
            System.IO.StringReader stringReader = null;
            try {
                stringReader = new System.IO.StringReader(xml);
                return ((FulfilmentCancellationType)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally {
                if ((stringReader != null)) {
                    stringReader.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Serializes current FulfilmentCancellationType object into file
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
        /// Deserializes xml markup from file into an FulfilmentCancellationType object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output FulfilmentCancellationType object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out FulfilmentCancellationType obj, out System.Exception exception) {
            exception = null;
            obj = default(FulfilmentCancellationType);
            try {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out FulfilmentCancellationType obj) {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static FulfilmentCancellationType LoadFromFile(string fileName) {
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
        /// Create a clone of this FulfilmentCancellationType object
        /// </summary>
        public virtual FulfilmentCancellationType Clone() {
            return ((FulfilmentCancellationType)(this.MemberwiseClone()));
        }
        #endregion
    }
}
