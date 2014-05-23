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
    
    
    public partial class TransportServiceDescriptionRequestType : System.ComponentModel.INotifyPropertyChanged {
        
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
        
        private ServiceInformationPreferenceCodeType serviceInformationPreferenceCodeField;
        
        private ObservableCollection<SignatureType> signatureField;
        
        private PartyType senderPartyField;
        
        private PartyType receiverPartyField;
        
        private PartyType transportServiceProviderPartyField;
        
        private ObservableCollection<TransportationServiceType> transportationServiceField;
        
        private static System.Xml.Serialization.XmlSerializer serializer;
        
        public TransportServiceDescriptionRequestType() {
            this.transportationServiceField = new ObservableCollection<TransportationServiceType>();
            this.transportServiceProviderPartyField = new PartyType();
            this.receiverPartyField = new PartyType();
            this.senderPartyField = new PartyType();
            this.signatureField = new ObservableCollection<SignatureType>();
            this.serviceInformationPreferenceCodeField = new ServiceInformationPreferenceCodeType();
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
        
        public ServiceInformationPreferenceCodeType ServiceInformationPreferenceCode {
            get {
                return this.serviceInformationPreferenceCodeField;
            }
            set {
                if ((this.serviceInformationPreferenceCodeField != null)) {
                    if ((serviceInformationPreferenceCodeField.Equals(value) != true)) {
                        this.serviceInformationPreferenceCodeField = value;
                        this.OnPropertyChanged("ServiceInformationPreferenceCode");
                    }
                }
                else {
                    this.serviceInformationPreferenceCodeField = value;
                    this.OnPropertyChanged("ServiceInformationPreferenceCode");
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
        
        public ObservableCollection<TransportationServiceType> TransportationService {
            get {
                return this.transportationServiceField;
            }
            set {
                if ((this.transportationServiceField != null)) {
                    if ((transportationServiceField.Equals(value) != true)) {
                        this.transportationServiceField = value;
                        this.OnPropertyChanged("TransportationService");
                    }
                }
                else {
                    this.transportationServiceField = value;
                    this.OnPropertyChanged("TransportationService");
                }
            }
        }
        
        private static System.Xml.Serialization.XmlSerializer Serializer {
            get {
                if ((serializer == null)) {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(TransportServiceDescriptionRequestType));
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
        /// Serializes current TransportServiceDescriptionRequestType object into an XML document
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
        /// Deserializes workflow markup into an TransportServiceDescriptionRequestType object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output TransportServiceDescriptionRequestType object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out TransportServiceDescriptionRequestType obj, out System.Exception exception) {
            exception = null;
            obj = default(TransportServiceDescriptionRequestType);
            try {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string xml, out TransportServiceDescriptionRequestType obj) {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }
        
        public static TransportServiceDescriptionRequestType Deserialize(string xml) {
            System.IO.StringReader stringReader = null;
            try {
                stringReader = new System.IO.StringReader(xml);
                return ((TransportServiceDescriptionRequestType)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally {
                if ((stringReader != null)) {
                    stringReader.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Serializes current TransportServiceDescriptionRequestType object into file
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
        /// Deserializes xml markup from file into an TransportServiceDescriptionRequestType object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output TransportServiceDescriptionRequestType object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out TransportServiceDescriptionRequestType obj, out System.Exception exception) {
            exception = null;
            obj = default(TransportServiceDescriptionRequestType);
            try {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out TransportServiceDescriptionRequestType obj) {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static TransportServiceDescriptionRequestType LoadFromFile(string fileName) {
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
        /// Create a clone of this TransportServiceDescriptionRequestType object
        /// </summary>
        public virtual TransportServiceDescriptionRequestType Clone() {
            return ((TransportServiceDescriptionRequestType)(this.MemberwiseClone()));
        }
        #endregion
    }
}
