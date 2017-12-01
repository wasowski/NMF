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
    
    
    public class ReferenceTypeEventsCollection : ObservableOppositeList<NMF.Models.Meta.IReferenceType, NMF.Models.Meta.IEvent>
    {
        
        public ReferenceTypeEventsCollection(NMF.Models.Meta.IReferenceType parent) : 
                base(parent)
        {
        }
        
        private void OnItemParentChanged(object sender, ValueChangedEventArgs e)
        {
            if ((e.NewValue != this.Parent))
            {
                this.Remove(((NMF.Models.Meta.IEvent)(sender)));
            }
        }
        
        protected override void SetOpposite(NMF.Models.Meta.IEvent item, NMF.Models.Meta.IReferenceType parent)
        {
            if ((parent != null))
            {
                item.ParentChanged += this.OnItemParentChanged;
                item.DeclaringType = parent;
            }
            else
            {
                item.ParentChanged -= this.OnItemParentChanged;
                if ((item.DeclaringType == this.Parent))
                {
                    item.DeclaringType = parent;
                }
            }
        }
    }
}

