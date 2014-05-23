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
    
    
    public partial class StatementType : System.ComponentModel.INotifyPropertyChanged {
        
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
        
        private DocumentCurrencyCodeType documentCurrencyCodeField;
        
        private TotalDebitAmountType totalDebitAmountField;
        
        private TotalCreditAmountType totalCreditAmountField;
        
        private TotalBalanceAmountType totalBalanceAmountField;
        
        private LineCountNumericType lineCountNumericField;
        
        private StatementTypeCodeType statementTypeCodeField;
        
        private PeriodType statementPeriodField;
        
        private ObservableCollection<DocumentReferenceType> additionalDocumentReferenceField;
        
        private ObservableCollection<SignatureType> signatureField;
        
        private SupplierPartyType accountingSupplierPartyField;
        
        private CustomerPartyType accountingCustomerPartyField;
        
        private CustomerPartyType buyerCustomerPartyField;
        
        private SupplierPartyType sellerSupplierPartyField;
        
        private CustomerPartyType originatorCustomerPartyField;
        
        private PartyType payeePartyField;
        
        private ObservableCollection<PaymentMeansType> paymentMeansField;
        
        private ObservableCollection<PaymentTermsType> paymentTermsField;
        
        private ObservableCollection<AllowanceChargeType> allowanceChargeField;
        
        private ObservableCollection<TaxTotalType> taxTotalField;
        
        private ObservableCollection<StatementLineType> statementLineField;
        
        private static System.Xml.Serialization.XmlSerializer serializer;
        
        public StatementType() {
            this.statementLineField = new ObservableCollection<StatementLineType>();
            this.taxTotalField = new ObservableCollection<TaxTotalType>();
            this.allowanceChargeField = new ObservableCollection<AllowanceChargeType>();
            this.paymentTermsField = new ObservableCollection<PaymentTermsType>();
            this.paymentMeansField = new ObservableCollection<PaymentMeansType>();
            this.payeePartyField = new PartyType();
            this.originatorCustomerPartyField = new CustomerPartyType();
            this.sellerSupplierPartyField = new SupplierPartyType();
            this.buyerCustomerPartyField = new CustomerPartyType();
            this.accountingCustomerPartyField = new CustomerPartyType();
            this.accountingSupplierPartyField = new SupplierPartyType();
            this.signatureField = new ObservableCollection<SignatureType>();
            this.additionalDocumentReferenceField = new ObservableCollection<DocumentReferenceType>();
            this.statementPeriodField = new PeriodType();
            this.statementTypeCodeField = new StatementTypeCodeType();
            this.lineCountNumericField = new LineCountNumericType();
            this.totalBalanceAmountField = new TotalBalanceAmountType();
            this.totalCreditAmountField = new TotalCreditAmountType();
            this.totalDebitAmountField = new TotalDebitAmountType();
            this.documentCurrencyCodeField = new DocumentCurrencyCodeType();
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
        
        public DocumentCurrencyCodeType DocumentCurrencyCode {
            get {
                return this.documentCurrencyCodeField;
            }
            set {
                if ((this.documentCurrencyCodeField != null)) {
                    if ((documentCurrencyCodeField.Equals(value) != true)) {
                        this.documentCurrencyCodeField = value;
                        this.OnPropertyChanged("DocumentCurrencyCode");
                    }
                }
                else {
                    this.documentCurrencyCodeField = value;
                    this.OnPropertyChanged("DocumentCurrencyCode");
                }
            }
        }
        
        public TotalDebitAmountType TotalDebitAmount {
            get {
                return this.totalDebitAmountField;
            }
            set {
                if ((this.totalDebitAmountField != null)) {
                    if ((totalDebitAmountField.Equals(value) != true)) {
                        this.totalDebitAmountField = value;
                        this.OnPropertyChanged("TotalDebitAmount");
                    }
                }
                else {
                    this.totalDebitAmountField = value;
                    this.OnPropertyChanged("TotalDebitAmount");
                }
            }
        }
        
        public TotalCreditAmountType TotalCreditAmount {
            get {
                return this.totalCreditAmountField;
            }
            set {
                if ((this.totalCreditAmountField != null)) {
                    if ((totalCreditAmountField.Equals(value) != true)) {
                        this.totalCreditAmountField = value;
                        this.OnPropertyChanged("TotalCreditAmount");
                    }
                }
                else {
                    this.totalCreditAmountField = value;
                    this.OnPropertyChanged("TotalCreditAmount");
                }
            }
        }
        
        public TotalBalanceAmountType TotalBalanceAmount {
            get {
                return this.totalBalanceAmountField;
            }
            set {
                if ((this.totalBalanceAmountField != null)) {
                    if ((totalBalanceAmountField.Equals(value) != true)) {
                        this.totalBalanceAmountField = value;
                        this.OnPropertyChanged("TotalBalanceAmount");
                    }
                }
                else {
                    this.totalBalanceAmountField = value;
                    this.OnPropertyChanged("TotalBalanceAmount");
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
        
        public StatementTypeCodeType StatementTypeCode {
            get {
                return this.statementTypeCodeField;
            }
            set {
                if ((this.statementTypeCodeField != null)) {
                    if ((statementTypeCodeField.Equals(value) != true)) {
                        this.statementTypeCodeField = value;
                        this.OnPropertyChanged("StatementTypeCode");
                    }
                }
                else {
                    this.statementTypeCodeField = value;
                    this.OnPropertyChanged("StatementTypeCode");
                }
            }
        }
        
        public PeriodType StatementPeriod {
            get {
                return this.statementPeriodField;
            }
            set {
                if ((this.statementPeriodField != null)) {
                    if ((statementPeriodField.Equals(value) != true)) {
                        this.statementPeriodField = value;
                        this.OnPropertyChanged("StatementPeriod");
                    }
                }
                else {
                    this.statementPeriodField = value;
                    this.OnPropertyChanged("StatementPeriod");
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
        
        public SupplierPartyType AccountingSupplierParty {
            get {
                return this.accountingSupplierPartyField;
            }
            set {
                if ((this.accountingSupplierPartyField != null)) {
                    if ((accountingSupplierPartyField.Equals(value) != true)) {
                        this.accountingSupplierPartyField = value;
                        this.OnPropertyChanged("AccountingSupplierParty");
                    }
                }
                else {
                    this.accountingSupplierPartyField = value;
                    this.OnPropertyChanged("AccountingSupplierParty");
                }
            }
        }
        
        public CustomerPartyType AccountingCustomerParty {
            get {
                return this.accountingCustomerPartyField;
            }
            set {
                if ((this.accountingCustomerPartyField != null)) {
                    if ((accountingCustomerPartyField.Equals(value) != true)) {
                        this.accountingCustomerPartyField = value;
                        this.OnPropertyChanged("AccountingCustomerParty");
                    }
                }
                else {
                    this.accountingCustomerPartyField = value;
                    this.OnPropertyChanged("AccountingCustomerParty");
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
        
        public ObservableCollection<PaymentMeansType> PaymentMeans {
            get {
                return this.paymentMeansField;
            }
            set {
                if ((this.paymentMeansField != null)) {
                    if ((paymentMeansField.Equals(value) != true)) {
                        this.paymentMeansField = value;
                        this.OnPropertyChanged("PaymentMeans");
                    }
                }
                else {
                    this.paymentMeansField = value;
                    this.OnPropertyChanged("PaymentMeans");
                }
            }
        }
        
        public ObservableCollection<PaymentTermsType> PaymentTerms {
            get {
                return this.paymentTermsField;
            }
            set {
                if ((this.paymentTermsField != null)) {
                    if ((paymentTermsField.Equals(value) != true)) {
                        this.paymentTermsField = value;
                        this.OnPropertyChanged("PaymentTerms");
                    }
                }
                else {
                    this.paymentTermsField = value;
                    this.OnPropertyChanged("PaymentTerms");
                }
            }
        }
        
        public ObservableCollection<AllowanceChargeType> AllowanceCharge {
            get {
                return this.allowanceChargeField;
            }
            set {
                if ((this.allowanceChargeField != null)) {
                    if ((allowanceChargeField.Equals(value) != true)) {
                        this.allowanceChargeField = value;
                        this.OnPropertyChanged("AllowanceCharge");
                    }
                }
                else {
                    this.allowanceChargeField = value;
                    this.OnPropertyChanged("AllowanceCharge");
                }
            }
        }
        
        public ObservableCollection<TaxTotalType> TaxTotal {
            get {
                return this.taxTotalField;
            }
            set {
                if ((this.taxTotalField != null)) {
                    if ((taxTotalField.Equals(value) != true)) {
                        this.taxTotalField = value;
                        this.OnPropertyChanged("TaxTotal");
                    }
                }
                else {
                    this.taxTotalField = value;
                    this.OnPropertyChanged("TaxTotal");
                }
            }
        }
        
        public ObservableCollection<StatementLineType> StatementLine {
            get {
                return this.statementLineField;
            }
            set {
                if ((this.statementLineField != null)) {
                    if ((statementLineField.Equals(value) != true)) {
                        this.statementLineField = value;
                        this.OnPropertyChanged("StatementLine");
                    }
                }
                else {
                    this.statementLineField = value;
                    this.OnPropertyChanged("StatementLine");
                }
            }
        }
        
        private static System.Xml.Serialization.XmlSerializer Serializer {
            get {
                if ((serializer == null)) {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(StatementType));
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
        /// Serializes current StatementType object into an XML document
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
        /// Deserializes workflow markup into an StatementType object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output StatementType object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out StatementType obj, out System.Exception exception) {
            exception = null;
            obj = default(StatementType);
            try {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string xml, out StatementType obj) {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }
        
        public static StatementType Deserialize(string xml) {
            System.IO.StringReader stringReader = null;
            try {
                stringReader = new System.IO.StringReader(xml);
                return ((StatementType)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally {
                if ((stringReader != null)) {
                    stringReader.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Serializes current StatementType object into file
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
        /// Deserializes xml markup from file into an StatementType object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output StatementType object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out StatementType obj, out System.Exception exception) {
            exception = null;
            obj = default(StatementType);
            try {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out StatementType obj) {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static StatementType LoadFromFile(string fileName) {
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
        /// Create a clone of this StatementType object
        /// </summary>
        public virtual StatementType Clone() {
            return ((StatementType)(this.MemberwiseClone()));
        }
        #endregion
    }
}
