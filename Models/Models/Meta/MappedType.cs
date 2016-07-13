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
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using NMF.Models.Repository;

namespace NMF.Models.Meta
{
    
    
    /// <summary>
    /// The MappedType extension
    /// </summary>
    public class MappedType : ModelElementExtension<IType>
    {
        
        /// <summary>
        /// The backing field for the SystemType property
        /// </summary>
        private System.Type _systemType;
        
        private static IExtension _extensionType = ((IExtension)(MetaRepository.Instance.ResolveType("http://nmf.codeplex.com/nmeta/#//MappedType/")));
        
        /// <summary>
        /// Creates a new extension instance for the given parent
        /// </summary>
        /// <param name="parent">The parent model element</param>
        public MappedType(IType parent) : 
                base(parent)
        {
        }
        
        /// <summary>
        /// The SystemType property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual System.Type SystemType
        {
            get
            {
                return this._systemType;
            }
            set
            {
                if ((this._systemType != value))
                {
                    System.Type old = this._systemType;
                    this._systemType = value;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnSystemTypeChanged(e);
                    this.OnPropertyChanged("SystemType", e);
                }
            }
        }
        
        /// <summary>
        /// Gets fired when the SystemType property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> SystemTypeChanged;
        
        /// <summary>
        /// Raises the SystemTypeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSystemTypeChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.SystemTypeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Gets the MappedType extension from the given model element
        /// </summary>
        /// <returns>The extension object or null, if the model element does not have this extension</returns>
        /// <param name="parent">The parent model element that may hold the extension</param>
        public static MappedType FromType(IType parent)
        {
            if ((parent == null))
            {
                return null;
            }
            MappedType extension = parent.GetExtension<MappedType>();
            if ((extension != null))
            {
                return extension;
            }
            extension = new MappedType(parent);
            parent.Extensions.Add(extension);
            return extension;
        }
        
        public override IExtension GetExtension()
        {
            return _extensionType;
        }
    }
}

