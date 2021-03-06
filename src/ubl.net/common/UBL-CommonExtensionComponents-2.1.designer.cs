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
    
    
    public partial class UBLExtensionsType {
        
        private ObservableCollection<UBLExtensionType> uBLExtensionField;
        
        public UBLExtensionsType() {
            this.uBLExtensionField = new ObservableCollection<UBLExtensionType>();
        }
        
        public ObservableCollection<UBLExtensionType> UBLExtension {
            get {
                return this.uBLExtensionField;
            }
            set {
                this.uBLExtensionField = value;
            }
        }
    }
    
    public partial class UBLExtensionType {
        
        private IDType idField;
        
        private NameType1 nameField;
        
        private ExtensionAgencyIDType extensionAgencyIDField;
        
        private ExtensionAgencyNameType extensionAgencyNameField;
        
        private ExtensionVersionIDType extensionVersionIDField;
        
        private ExtensionAgencyURIType extensionAgencyURIField;
        
        private ExtensionURIType extensionURIField;
        
        private ExtensionReasonCodeType extensionReasonCodeField;
        
        private ExtensionReasonType extensionReasonField;
        
        private System.Xml.XmlElement extensionContentField;
        
        public UBLExtensionType() {
            this.extensionReasonField = new ExtensionReasonType();
            this.extensionReasonCodeField = new ExtensionReasonCodeType();
            this.extensionURIField = new ExtensionURIType();
            this.extensionAgencyURIField = new ExtensionAgencyURIType();
            this.extensionVersionIDField = new ExtensionVersionIDType();
            this.extensionAgencyNameField = new ExtensionAgencyNameType();
            this.extensionAgencyIDField = new ExtensionAgencyIDType();
            this.nameField = new NameType1();
            this.idField = new IDType();
        }

        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType1 Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        public ExtensionAgencyIDType ExtensionAgencyID {
            get {
                return this.extensionAgencyIDField;
            }
            set {
                this.extensionAgencyIDField = value;
            }
        }
        
        public ExtensionAgencyNameType ExtensionAgencyName {
            get {
                return this.extensionAgencyNameField;
            }
            set {
                this.extensionAgencyNameField = value;
            }
        }
        
        public ExtensionVersionIDType ExtensionVersionID {
            get {
                return this.extensionVersionIDField;
            }
            set {
                this.extensionVersionIDField = value;
            }
        }
        
        public ExtensionAgencyURIType ExtensionAgencyURI {
            get {
                return this.extensionAgencyURIField;
            }
            set {
                this.extensionAgencyURIField = value;
            }
        }
        
        public ExtensionURIType ExtensionURI {
            get {
                return this.extensionURIField;
            }
            set {
                this.extensionURIField = value;
            }
        }
        
        public ExtensionReasonCodeType ExtensionReasonCode {
            get {
                return this.extensionReasonCodeField;
            }
            set {
                this.extensionReasonCodeField = value;
            }
        }
        
        public ExtensionReasonType ExtensionReason {
            get {
                return this.extensionReasonField;
            }
            set {
                this.extensionReasonField = value;
            }
        }
        
        public System.Xml.XmlElement ExtensionContent {
            get {
                return this.extensionContentField;
            }
            set {
                this.extensionContentField = value;
            }
        }
    }
    
    public partial class ExtensionReasonCodeType : CodeType1 {
    }
    
    public partial class ExtensionReasonType : TextType1 {
    }
    
    public partial class ExtensionAgencyNameType : TextType1 {
    }
    
    public partial class ExtensionVersionIDType : IdentifierType1 {
    }
    
    public partial class ExtensionURIType : IdentifierType1 {
    }
    
    public partial class ExtensionAgencyURIType : IdentifierType1 {
    }
    
    public partial class ExtensionAgencyIDType : IdentifierType1 {
    }
}
