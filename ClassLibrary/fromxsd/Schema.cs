﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.8.3928.0.
// 
namespace Library {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://example.org/jk/ryllm")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://example.org/jk/ryllm", IsNullable=false)]
    public partial class RootElement {
        
        private RootElementMeeting[] meetingsField;
        
        private RootElementPasture[] pasturesField;
        
        private object[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Meeting", IsNullable=false)]
        public RootElementMeeting[] Meetings {
            get {
                return this.meetingsField;
            }
            set {
                this.meetingsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Pasture", IsNullable=false)]
        public RootElementPasture[] Pastures {
            get {
                return this.pasturesField;
            }
            set {
                this.pasturesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Centaur", typeof(RootElementCentaur))]
        [System.Xml.Serialization.XmlElementAttribute("Minotaur", typeof(RootElementMinotaur))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://example.org/jk/ryllm")]
    public partial class RootElementMeeting {
        
        private int[] participantField;
        
        private string locationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Participant")]
        public int[] Participant {
            get {
                return this.participantField;
            }
            set {
                this.participantField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://example.org/jk/ryllm")]
    public partial class RootElementPasture {
        
        private string[] nameField;
        
        private decimal areaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Name")]
        public string[] Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Area {
            get {
                return this.areaField;
            }
            set {
                this.areaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://example.org/jk/ryllm")]
    public partial class RootElementCentaur {
        
        private object beardField;
        
        private object mustacheField;
        
        private object whiskersField;
        
        private int idField;
        
        private string nameField;
        
        private int ageField;
        
        private bool ageFieldSpecified;
        
        /// <remarks/>
        public object Beard {
            get {
                return this.beardField;
            }
            set {
                this.beardField = value;
            }
        }
        
        /// <remarks/>
        public object Mustache {
            get {
                return this.mustacheField;
            }
            set {
                this.mustacheField = value;
            }
        }
        
        /// <remarks/>
        public object Whiskers {
            get {
                return this.whiskersField;
            }
            set {
                this.whiskersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Age {
            get {
                return this.ageField;
            }
            set {
                this.ageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AgeSpecified {
            get {
                return this.ageFieldSpecified;
            }
            set {
                this.ageFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://example.org/jk/ryllm")]
    public partial class RootElementMinotaur {
        
        private int idField;
        
        private string nameField;
        
        private int ageField;
        
        private bool ageFieldSpecified;
        
        private decimal massField;
        
        private bool massFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Age {
            get {
                return this.ageField;
            }
            set {
                this.ageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AgeSpecified {
            get {
                return this.ageFieldSpecified;
            }
            set {
                this.ageFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Mass {
            get {
                return this.massField;
            }
            set {
                this.massField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MassSpecified {
            get {
                return this.massFieldSpecified;
            }
            set {
                this.massFieldSpecified = value;
            }
        }
    }
}
