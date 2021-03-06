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
    
    
    public partial class TransportExecutionPlanRequestType : System.ComponentModel.INotifyPropertyChanged {
        
        private ObservableCollection<UBLExtensionType> uBLExtensionsField;
        
        private UBLVersionIDType uBLVersionIDField;
        
        private CustomizationIDType customizationIDField;
        
        private ProfileIDType profileIDField;
        
        private ProfileExecutionIDType profileExecutionIDField;
        
        private IDType idField;
        
        private VersionIDType versionIDField;
        
        private CopyIndicatorType copyIndicatorField;
        
        private UUIDType uUIDField;
        
        private IssueDateType issueDateField;
        
        private IssueTimeType issueTimeField;
        
        private DocumentStatusCodeType documentStatusCodeField;
        
        private DocumentStatusReasonCodeType documentStatusReasonCodeField;
        
        private ObservableCollection<DocumentStatusReasonDescriptionType> documentStatusReasonDescriptionField;
        
        private ObservableCollection<NoteType> noteField;
        
        private ObservableCollection<TransportUserRemarksType> transportUserRemarksField;
        
        private PartyType senderPartyField;
        
        private PartyType receiverPartyField;
        
        private PartyType transportUserPartyField;
        
        private PartyType transportServiceProviderPartyField;
        
        private PartyType payeePartyField;
        
        private ObservableCollection<SignatureType> signatureField;
        
        private DocumentReferenceType transportExecutionPlanDocumentReferenceField;
        
        private DocumentReferenceType transportServiceDescriptionDocumentReferenceField;
        
        private ObservableCollection<DocumentReferenceType> additionalDocumentReferenceField;
        
        private ContractType transportContractField;
        
        private ObservableCollection<PeriodType> transportServiceProviderResponseDeadlinePeriodField;
        
        private TransportationServiceType mainTransportationServiceField;
        
        private ObservableCollection<TransportationServiceType> additionalTransportationServiceField;
        
        private PeriodType serviceStartTimePeriodField;
        
        private PeriodType serviceEndTimePeriodField;
        
        private LocationType1 fromLocationField;
        
        private LocationType1 toLocationField;
        
        private LocationType1 atLocationField;
        
        private TransportExecutionTermsType transportExecutionTermsField;
        
        private ObservableCollection<ConsignmentType> consignmentField;
        
        private static System.Xml.Serialization.XmlSerializer serializer;
        
        public TransportExecutionPlanRequestType() {
            this.consignmentField = new ObservableCollection<ConsignmentType>();
            this.transportExecutionTermsField = new TransportExecutionTermsType();
            this.atLocationField = new LocationType1();
            this.toLocationField = new LocationType1();
            this.fromLocationField = new LocationType1();
            this.serviceEndTimePeriodField = new PeriodType();
            this.serviceStartTimePeriodField = new PeriodType();
            this.additionalTransportationServiceField = new ObservableCollection<TransportationServiceType>();
            this.mainTransportationServiceField = new TransportationServiceType();
            this.transportServiceProviderResponseDeadlinePeriodField = new ObservableCollection<PeriodType>();
            this.transportContractField = new ContractType();
            this.additionalDocumentReferenceField = new ObservableCollection<DocumentReferenceType>();
            this.transportServiceDescriptionDocumentReferenceField = new DocumentReferenceType();
            this.transportExecutionPlanDocumentReferenceField = new DocumentReferenceType();
            this.signatureField = new ObservableCollection<SignatureType>();
            this.payeePartyField = new PartyType();
            this.transportServiceProviderPartyField = new PartyType();
            this.transportUserPartyField = new PartyType();
            this.receiverPartyField = new PartyType();
            this.senderPartyField = new PartyType();
            this.transportUserRemarksField = new ObservableCollection<TransportUserRemarksType>();
            this.noteField = new ObservableCollection<NoteType>();
            this.documentStatusReasonDescriptionField = new ObservableCollection<DocumentStatusReasonDescriptionType>();
            this.documentStatusReasonCodeField = new DocumentStatusReasonCodeType();
            this.documentStatusCodeField = new DocumentStatusCodeType();
            this.issueTimeField = new IssueTimeType();
            this.issueDateField = new IssueDateType();
            this.uUIDField = new UUIDType();
            this.copyIndicatorField = new CopyIndicatorType();
            this.versionIDField = new VersionIDType();
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
        
        public VersionIDType VersionID {
            get {
                return this.versionIDField;
            }
            set {
                if ((this.versionIDField != null)) {
                    if ((versionIDField.Equals(value) != true)) {
                        this.versionIDField = value;
                        this.OnPropertyChanged("VersionID");
                    }
                }
                else {
                    this.versionIDField = value;
                    this.OnPropertyChanged("VersionID");
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
        
        public DocumentStatusCodeType DocumentStatusCode {
            get {
                return this.documentStatusCodeField;
            }
            set {
                if ((this.documentStatusCodeField != null)) {
                    if ((documentStatusCodeField.Equals(value) != true)) {
                        this.documentStatusCodeField = value;
                        this.OnPropertyChanged("DocumentStatusCode");
                    }
                }
                else {
                    this.documentStatusCodeField = value;
                    this.OnPropertyChanged("DocumentStatusCode");
                }
            }
        }
        
        public DocumentStatusReasonCodeType DocumentStatusReasonCode {
            get {
                return this.documentStatusReasonCodeField;
            }
            set {
                if ((this.documentStatusReasonCodeField != null)) {
                    if ((documentStatusReasonCodeField.Equals(value) != true)) {
                        this.documentStatusReasonCodeField = value;
                        this.OnPropertyChanged("DocumentStatusReasonCode");
                    }
                }
                else {
                    this.documentStatusReasonCodeField = value;
                    this.OnPropertyChanged("DocumentStatusReasonCode");
                }
            }
        }
        
        public ObservableCollection<DocumentStatusReasonDescriptionType> DocumentStatusReasonDescription {
            get {
                return this.documentStatusReasonDescriptionField;
            }
            set {
                if ((this.documentStatusReasonDescriptionField != null)) {
                    if ((documentStatusReasonDescriptionField.Equals(value) != true)) {
                        this.documentStatusReasonDescriptionField = value;
                        this.OnPropertyChanged("DocumentStatusReasonDescription");
                    }
                }
                else {
                    this.documentStatusReasonDescriptionField = value;
                    this.OnPropertyChanged("DocumentStatusReasonDescription");
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
        
        public ObservableCollection<TransportUserRemarksType> TransportUserRemarks {
            get {
                return this.transportUserRemarksField;
            }
            set {
                if ((this.transportUserRemarksField != null)) {
                    if ((transportUserRemarksField.Equals(value) != true)) {
                        this.transportUserRemarksField = value;
                        this.OnPropertyChanged("TransportUserRemarks");
                    }
                }
                else {
                    this.transportUserRemarksField = value;
                    this.OnPropertyChanged("TransportUserRemarks");
                }
            }
        }
        
        public PartyType SenderParty {
            get {
                return this.senderPartyField;
            }
            set {
                if ((this.senderPartyField != null)) {
                    if ((senderPartyField.Equals(value) != true)) {
                        this.senderPartyField = value;
                        this.OnPropertyChanged("SenderParty");
                    }
                }
                else {
                    this.senderPartyField = value;
                    this.OnPropertyChanged("SenderParty");
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
        
        public PartyType TransportUserParty {
            get {
                return this.transportUserPartyField;
            }
            set {
                if ((this.transportUserPartyField != null)) {
                    if ((transportUserPartyField.Equals(value) != true)) {
                        this.transportUserPartyField = value;
                        this.OnPropertyChanged("TransportUserParty");
                    }
                }
                else {
                    this.transportUserPartyField = value;
                    this.OnPropertyChanged("TransportUserParty");
                }
            }
        }
        
        public PartyType TransportServiceProviderParty {
            get {
                return this.transportServiceProviderPartyField;
            }
            set {
                if ((this.transportServiceProviderPartyField != null)) {
                    if ((transportServiceProviderPartyField.Equals(value) != true)) {
                        this.transportServiceProviderPartyField = value;
                        this.OnPropertyChanged("TransportServiceProviderParty");
                    }
                }
                else {
                    this.transportServiceProviderPartyField = value;
                    this.OnPropertyChanged("TransportServiceProviderParty");
                }
            }
        }
        
        public PartyType PayeeParty {
            get {
                return this.payeePartyField;
            }
            set {
                if ((this.payeePartyField != null)) {
                    if ((payeePartyField.Equals(value) != true)) {
                        this.payeePartyField = value;
                        this.OnPropertyChanged("PayeeParty");
                    }
                }
                else {
                    this.payeePartyField = value;
                    this.OnPropertyChanged("PayeeParty");
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
        
        public DocumentReferenceType TransportExecutionPlanDocumentReference {
            get {
                return this.transportExecutionPlanDocumentReferenceField;
            }
            set {
                if ((this.transportExecutionPlanDocumentReferenceField != null)) {
                    if ((transportExecutionPlanDocumentReferenceField.Equals(value) != true)) {
                        this.transportExecutionPlanDocumentReferenceField = value;
                        this.OnPropertyChanged("TransportExecutionPlanDocumentReference");
                    }
                }
                else {
                    this.transportExecutionPlanDocumentReferenceField = value;
                    this.OnPropertyChanged("TransportExecutionPlanDocumentReference");
                }
            }
        }
        
        public DocumentReferenceType TransportServiceDescriptionDocumentReference {
            get {
                return this.transportServiceDescriptionDocumentReferenceField;
            }
            set {
                if ((this.transportServiceDescriptionDocumentReferenceField != null)) {
                    if ((transportServiceDescriptionDocumentReferenceField.Equals(value) != true)) {
                        this.transportServiceDescriptionDocumentReferenceField = value;
                        this.OnPropertyChanged("TransportServiceDescriptionDocumentReference");
                    }
                }
                else {
                    this.transportServiceDescriptionDocumentReferenceField = value;
                    this.OnPropertyChanged("TransportServiceDescriptionDocumentReference");
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
        
        public ContractType TransportContract {
            get {
                return this.transportContractField;
            }
            set {
                if ((this.transportContractField != null)) {
                    if ((transportContractField.Equals(value) != true)) {
                        this.transportContractField = value;
                        this.OnPropertyChanged("TransportContract");
                    }
                }
                else {
                    this.transportContractField = value;
                    this.OnPropertyChanged("TransportContract");
                }
            }
        }
        
        public ObservableCollection<PeriodType> TransportServiceProviderResponseDeadlinePeriod {
            get {
                return this.transportServiceProviderResponseDeadlinePeriodField;
            }
            set {
                if ((this.transportServiceProviderResponseDeadlinePeriodField != null)) {
                    if ((transportServiceProviderResponseDeadlinePeriodField.Equals(value) != true)) {
                        this.transportServiceProviderResponseDeadlinePeriodField = value;
                        this.OnPropertyChanged("TransportServiceProviderResponseDeadlinePeriod");
                    }
                }
                else {
                    this.transportServiceProviderResponseDeadlinePeriodField = value;
                    this.OnPropertyChanged("TransportServiceProviderResponseDeadlinePeriod");
                }
            }
        }
        
        public TransportationServiceType MainTransportationService {
            get {
                return this.mainTransportationServiceField;
            }
            set {
                if ((this.mainTransportationServiceField != null)) {
                    if ((mainTransportationServiceField.Equals(value) != true)) {
                        this.mainTransportationServiceField = value;
                        this.OnPropertyChanged("MainTransportationService");
                    }
                }
                else {
                    this.mainTransportationServiceField = value;
                    this.OnPropertyChanged("MainTransportationService");
                }
            }
        }
        
        public ObservableCollection<TransportationServiceType> AdditionalTransportationService {
            get {
                return this.additionalTransportationServiceField;
            }
            set {
                if ((this.additionalTransportationServiceField != null)) {
                    if ((additionalTransportationServiceField.Equals(value) != true)) {
                        this.additionalTransportationServiceField = value;
                        this.OnPropertyChanged("AdditionalTransportationService");
                    }
                }
                else {
                    this.additionalTransportationServiceField = value;
                    this.OnPropertyChanged("AdditionalTransportationService");
                }
            }
        }
        
        public PeriodType ServiceStartTimePeriod {
            get {
                return this.serviceStartTimePeriodField;
            }
            set {
                if ((this.serviceStartTimePeriodField != null)) {
                    if ((serviceStartTimePeriodField.Equals(value) != true)) {
                        this.serviceStartTimePeriodField = value;
                        this.OnPropertyChanged("ServiceStartTimePeriod");
                    }
                }
                else {
                    this.serviceStartTimePeriodField = value;
                    this.OnPropertyChanged("ServiceStartTimePeriod");
                }
            }
        }
        
        public PeriodType ServiceEndTimePeriod {
            get {
                return this.serviceEndTimePeriodField;
            }
            set {
                if ((this.serviceEndTimePeriodField != null)) {
                    if ((serviceEndTimePeriodField.Equals(value) != true)) {
                        this.serviceEndTimePeriodField = value;
                        this.OnPropertyChanged("ServiceEndTimePeriod");
                    }
                }
                else {
                    this.serviceEndTimePeriodField = value;
                    this.OnPropertyChanged("ServiceEndTimePeriod");
                }
            }
        }
        
        public LocationType1 FromLocation {
            get {
                return this.fromLocationField;
            }
            set {
                if ((this.fromLocationField != null)) {
                    if ((fromLocationField.Equals(value) != true)) {
                        this.fromLocationField = value;
                        this.OnPropertyChanged("FromLocation");
                    }
                }
                else {
                    this.fromLocationField = value;
                    this.OnPropertyChanged("FromLocation");
                }
            }
        }
        
        public LocationType1 ToLocation {
            get {
                return this.toLocationField;
            }
            set {
                if ((this.toLocationField != null)) {
                    if ((toLocationField.Equals(value) != true)) {
                        this.toLocationField = value;
                        this.OnPropertyChanged("ToLocation");
                    }
                }
                else {
                    this.toLocationField = value;
                    this.OnPropertyChanged("ToLocation");
                }
            }
        }
        
        public LocationType1 AtLocation {
            get {
                return this.atLocationField;
            }
            set {
                if ((this.atLocationField != null)) {
                    if ((atLocationField.Equals(value) != true)) {
                        this.atLocationField = value;
                        this.OnPropertyChanged("AtLocation");
                    }
                }
                else {
                    this.atLocationField = value;
                    this.OnPropertyChanged("AtLocation");
                }
            }
        }
        
        public TransportExecutionTermsType TransportExecutionTerms {
            get {
                return this.transportExecutionTermsField;
            }
            set {
                if ((this.transportExecutionTermsField != null)) {
                    if ((transportExecutionTermsField.Equals(value) != true)) {
                        this.transportExecutionTermsField = value;
                        this.OnPropertyChanged("TransportExecutionTerms");
                    }
                }
                else {
                    this.transportExecutionTermsField = value;
                    this.OnPropertyChanged("TransportExecutionTerms");
                }
            }
        }
        
        public ObservableCollection<ConsignmentType> Consignment {
            get {
                return this.consignmentField;
            }
            set {
                if ((this.consignmentField != null)) {
                    if ((consignmentField.Equals(value) != true)) {
                        this.consignmentField = value;
                        this.OnPropertyChanged("Consignment");
                    }
                }
                else {
                    this.consignmentField = value;
                    this.OnPropertyChanged("Consignment");
                }
            }
        }
        
        private static System.Xml.Serialization.XmlSerializer Serializer {
            get {
                if ((serializer == null)) {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(TransportExecutionPlanRequestType));
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
        /// Serializes current TransportExecutionPlanRequestType object into an XML document
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
        /// Deserializes workflow markup into an TransportExecutionPlanRequestType object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output TransportExecutionPlanRequestType object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out TransportExecutionPlanRequestType obj, out System.Exception exception) {
            exception = null;
            obj = default(TransportExecutionPlanRequestType);
            try {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string xml, out TransportExecutionPlanRequestType obj) {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }
        
        public static TransportExecutionPlanRequestType Deserialize(string xml) {
            System.IO.StringReader stringReader = null;
            try {
                stringReader = new System.IO.StringReader(xml);
                return ((TransportExecutionPlanRequestType)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally {
                if ((stringReader != null)) {
                    stringReader.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Serializes current TransportExecutionPlanRequestType object into file
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
        /// Deserializes xml markup from file into an TransportExecutionPlanRequestType object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output TransportExecutionPlanRequestType object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out TransportExecutionPlanRequestType obj, out System.Exception exception) {
            exception = null;
            obj = default(TransportExecutionPlanRequestType);
            try {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out TransportExecutionPlanRequestType obj) {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static TransportExecutionPlanRequestType LoadFromFile(string fileName) {
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
        /// Create a clone of this TransportExecutionPlanRequestType object
        /// </summary>
        public virtual TransportExecutionPlanRequestType Clone() {
            return ((TransportExecutionPlanRequestType)(this.MemberwiseClone()));
        }
        #endregion
    }
}
