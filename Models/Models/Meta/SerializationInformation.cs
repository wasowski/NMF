//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Models;
using NMF.Models.Collections;
using NMF.Models.Expressions;
using NMF.Models.Meta;
using NMF.Models.Repository;
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace NMF.Models.Meta
{
    
    
    /// <summary>
    /// The SerializationInformation extension
    /// </summary>
    public class SerializationInformation : ModelElementExtension<NMF.Models.Meta.IMetaElement>
    {
        
        /// <summary>
        /// The backing field for the SerializationName property
        /// </summary>
        private string _serializationName;
        
        private static Lazy<ITypedElement> _serializationNameAttribute = new Lazy<ITypedElement>(RetrieveSerializationNameAttribute);
        
        private static IExtension _extensionType;
        
        /// <summary>
        /// Creates a new extension instance for the given parent
        /// </summary>
        /// <param name="parent">The parent model element</param>
        public SerializationInformation(NMF.Models.Meta.IMetaElement parent) : 
                base(parent)
        {
        }
        
        /// <summary>
        /// The SerializationName property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public string SerializationName
        {
            get
            {
                return this._serializationName;
            }
            set
            {
                if ((this._serializationName != value))
                {
                    string old = this._serializationName;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnSerializationNameChanging(e);
                    this.OnPropertyChanging("SerializationName", e, _serializationNameAttribute);
                    this._serializationName = value;
                    this.OnSerializationNameChanged(e);
                    this.OnPropertyChanged("SerializationName", e, _serializationNameAttribute);
                }
            }
        }
        
        /// <summary>
        /// Gets fired before the SerializationName property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SerializationNameChanging;
        
        /// <summary>
        /// Gets fired when the SerializationName property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SerializationNameChanged;
        
        private static ITypedElement RetrieveSerializationNameAttribute()
        {
            return ((ITypedElement)(((NMF.Models.ModelElement)(SerializationInformation.ClassInstance)).Resolve("SerializationName")));
        }
        
        /// <summary>
        /// Raises the SerializationNameChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSerializationNameChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SerializationNameChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the SerializationNameChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSerializationNameChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SerializationNameChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Gets the SerializationInformation extension from the given model element
        /// </summary>
        /// <returns>The extension object or null, if the model element does not have this extension</returns>
        /// <param name="parent">The parent model element that may hold the extension</param>
        public static SerializationInformation FromMetaElement(NMF.Models.Meta.IMetaElement parent)
        {
            if ((parent == null))
            {
                return null;
            }
            SerializationInformation extension = parent.GetExtension<SerializationInformation>();
            if ((extension != null))
            {
                return extension;
            }
            extension = new SerializationInformation(parent);
            parent.Extensions.Add(extension);
            return extension;
        }
        
        /// <summary>
        /// Gets the extension model element for the given model extension class
        /// </summary>
        public override IExtension GetExtension()
        {
            if ((_extensionType == null))
            {
                _extensionType = ((IExtension)(MetaRepository.Instance.Resolve("http://nmf.codeplex.com/nmeta/#//SerializationInformation")));
            }
            return _extensionType;
        }
    }
}

